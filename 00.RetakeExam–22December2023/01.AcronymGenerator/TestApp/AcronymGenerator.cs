using System;
using System.Linq;
using System.Text;

namespace TestApp;

public class AcronymGenerator
{
    public static string GenerateAcronym(string phrase)
    {
        string[] words = phrase.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        StringBuilder sb = new();

        string[] ignoredWords = { "of", "and", "the", "in" };
        foreach (string word in words)
        {
            if (char.IsLetter(word[0]) && !ignoredWords.Contains(word.ToLower()))
            {
                sb.Append(char.ToUpper(word[0]));
            }
        }

        return sb.ToString();
    }
}
