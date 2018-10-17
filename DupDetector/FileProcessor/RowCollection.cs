using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DupDetector
{
    public class RowCollection
    {
        public List<string> ColumnNames { get; private set; }
        public List<Row> Rows { get; private set; }
        public string Delimiter { get; private set; } = String.Empty;

        public RowCollection SetDelimiter(string delimiter)
        {
            if (String.IsNullOrEmpty(delimiter)) throw new ArgumentException("Delimiter must be at least one character.");
            this.Delimiter = delimiter;
            return this;
        }

        public RowCollection SetColumns(string text)
        {
            if (this.Delimiter == String.Empty) throw new ArgumentException("Delimiter required before setting columns.");
            if (String.IsNullOrEmpty(text)) throw new ArgumentException("Text can not be null or empty.");
            ColumnNames = new List<string>(text.Split(new[] { Delimiter }, StringSplitOptions.None));
            return this;
        }

        public RowCollection SetRows(string text, bool columnsIncluded = false)
        {
            if (String.IsNullOrEmpty(text)) throw new ArgumentException("Text can not be null or empty.");
            var rawRows = text.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            Rows = new List<Row>();

            bool isFirstRow = columnsIncluded;
            foreach (string r in rawRows)
            {
                if (isFirstRow)
                {
                    this.SetColumns(r);
                    isFirstRow = false;
                }
                else
                {
                    var row = new Row().SetDelimiter(Delimiter).SetRow(r);
                    while (row.Fields.Count < this.ColumnNames.Count) row.Fields.Add(String.Empty);
                    Rows.Add(row);
                }
            }

            return this;
        }
    }
}
