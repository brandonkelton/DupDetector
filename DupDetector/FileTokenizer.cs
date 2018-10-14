using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DupDetector
{
    public class FileTokenizer : ITokenizer
    {
        public List<string> Tokens { get; private set; }

        public void Tokenize(string text)
        {
            bool isEscaped = false;
            bool isQuoted = false;
            StringBuilder builder = new StringBuilder();
            Tokens = new List<string>();

            for (int i=0; i<text.Length; i++)
            {
                char c = text[i];

                if (c == '\\' && !isEscaped)
                {
                    isEscaped = true;
                }
                else if (c == '"' && !isEscaped && !isQuoted)
                {
                    isQuoted = true;
                }
                else if (c == '"' && !isEscaped && isQuoted)
                {
                    isQuoted = false;
                }
                else if ((c == ',' || c == '\n' || c == '\r' || c == '\t' || i == text.Length - 1) && !isQuoted && !isEscaped)
                {
                    Tokens.Add(builder.ToString());
                    builder.Clear();
                }
                else
                {
                    builder.Append(c);
                    isEscaped = false;
                }
            }
        }
    }
}
