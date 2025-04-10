using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp;

public class SentenceAnalyzer
{
    public static Dictionary<string, int> Analyze(string sentence)
    {
        Dictionary<string, int> symbols = new Dictionary<string, int>();

        foreach (char symbol in sentence)
        {
            if (char.IsWhiteSpace(symbol))
            {
                continue;
            }
            if (char.IsLetter(symbol))
            {
                if (symbols.ContainsKey("letters") == false)
                {
                    symbols.Add("letters", 0);
                }

                symbols["letters"]++;
            }
            else if (char.IsDigit(symbol))
            {
                if (symbols.ContainsKey("digits") == false)
                {
                    symbols.Add("digits", 0);
                }

                symbols["digits"]++;
            }
            else
            {
                if (symbols.ContainsKey("special characters") == false)
                {
                    symbols.Add("special characters", 0);
                }

                symbols["special characters"]++;
            }
        }

        return symbols;
    }
}

