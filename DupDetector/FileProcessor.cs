using DupDetector.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Concurrent;
using System.Text.RegularExpressions;

namespace DupDetector
{
    public class FileProcessor
    {
        public string FileName { get; private set; }
        public ConcurrentBag<Product> Products { get; private set; }

        public async Task<RowCollection> Extract(string fileName)
        {
            this.FileName = fileName;
            RowCollection rowCollection = new RowCollection().SetDelimiter(",");

            using (TextReader reader = new StreamReader(fileName))
            {
                rowCollection.SetRows(await reader.ReadToEndAsync(), true);
            }

            return rowCollection;
        }

        public async Task Translate(RowCollection rowCollection)
        {
            Products = new ConcurrentBag<Product>();

            var factory = new TaskFactory();
            await factory.StartNew(() =>
            {
                for (int r = 0; r < rowCollection.Rows.Count; r++)
                {
                    var product = new Product();

                    for (int i = 0; i < rowCollection.ColumnNames.Count; i++)
                    {
                        var fileColName = rowCollection.ColumnNames[i];
                        var row = rowCollection.Rows[r];
                        var props = typeof(Product).GetProperties().Where(p => p.GetCustomAttributes(typeof(ColumnAttribute), false).OfType<ColumnAttribute>().Where(a => a.Name == fileColName).Count() > 0);
                        if (props.Count() > 0)
                        {
                            string value = row.Fields[i];
                            if (Regex.IsMatch(value, @"^\d+$"))
                            {
                                int convertedValue;
                                if (int.TryParse(value, out convertedValue))
                                {
                                    props.ElementAt(0).SetValue(product, convertedValue);
                                }
                            }
                            else
                            {
                                props.ElementAt(0).SetValue(product, value);
                            }
                        }
                        else
                        {
                            throw new Exception("Unknown column: " + fileColName);
                        }
                    }

                    this.Products.Add(product);
                }
            });
        }
    }
}
