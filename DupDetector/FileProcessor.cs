using DupDetector.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DupDetector
{
    public class FileProcessor
    {
        public string FileName { get; private set; }
        public List<Product> Products = new List<Product>();

        public async Task<RowCollection> Extract(string fileName)
        {
            this.FileName = fileName;
            RowCollection rowCollection = new RowCollection().SetDelimiter(",");

            using (TextReader reader = new StreamReader(fileName))
            {
                rowCollection.SetRows(await reader.ReadToEndAsync());
            }

            return rowCollection;
        }

        public async Task<List<Product>> Translate(RowCollection rowCollection)
        {
            for (int r=0; r<rowCollection.Rows.Count; r++)
            {
                var product = new Product();

                for (int i = 0; i < rowCollection.ColumnNames.Count; i++)
                {
                    var fileColName = rowCollection.ColumnNames[i];
                    //product.GetType().GetProperties().Where(p => p.GetCustomAttributes(typeof(Column)).Where(a => a.))
                }
            }

            return null;
            
        }
    }
}
