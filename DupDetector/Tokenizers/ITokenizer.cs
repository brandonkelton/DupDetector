using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DupDetector.Tokenizers
{
    public interface ITokenizer
    {
        List<string> Tokens { get; }

        void Tokenize(string text);
    }
}
