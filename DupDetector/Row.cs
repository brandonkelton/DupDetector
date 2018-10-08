using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DupDetector
{
    public class Row
    {
        public List<string> Fields { get; private set; }
        public string Delimiter { get; private set; } = String.Empty;

        public Row SetDelimiter(string delimiter)
        {
            if (String.IsNullOrEmpty(delimiter)) throw new ArgumentException("Delimiter must be at least one character.");
            this.Delimiter = delimiter;
            return this;
        }

        public Row SetRow(string text)
        {
            if (String.IsNullOrEmpty(text)) throw new ArgumentException("Text can not be null or empty.");
            Fields = new List<string>(ProcessText(text));
            return this;
        }

        private List<string> ProcessText(string text)
        {
            var tokenizer = new Tokenizer();
            tokenizer.Tokenize(text);
            return tokenizer.Tokens;
        }
    }
}
