using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp;

public class WordLengthAnalyzer
{
    public static Dictionary<string, int> AnalyzeSentence(string sentence)
    {
        Dictionary<string, int> words = new();

        if (string.IsNullOrWhiteSpace(sentence))
        {
            return words;
        }

        var allWords = sentence
            .Split(" \t\r\n.:;!?-_,".ToCharArray(), StringSplitOptions.RemoveEmptyEntries) //split by multible symbols - tabulation, new line, punctuation
            .Where(w => w.All(char.IsLetter)) // check if each word contains only letters
            .ToArray();

        foreach (var word in allWords)
        {
            int wordLength = word.Length;

            if (wordLength >= 9)
            {
                if (words.ContainsKey("long") == false)
                {
                    words.Add("long", 0);
                }
                words["long"]++;
            }
            else if (wordLength <= 8 && wordLength > 4)
            {
                if (words.ContainsKey("medium") == false)
                {
                    words.Add("medium", 0);
                }
                words["medium"]++;
            }
            else
            {
                if (words.ContainsKey("short") == false)
                {
                    words.Add("short", 0);
                }
                words["short"]++;
            }
        }

        return words;
    }
}

