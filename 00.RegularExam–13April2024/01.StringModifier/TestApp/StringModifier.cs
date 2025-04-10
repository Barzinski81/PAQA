using System;
using System.Text;

namespace TestApp;
public class StringModifier
{
    public static string Modify(string input)
    {
        string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        StringBuilder sb = new();

        foreach (string word in words)
        {
            if (word.Length % 2 == 0)
            {
                sb.Append($"{word.ToUpper()} ");
            }
            else
            {
                sb.Append($"{word.ToLower()} ");
            }
        }

        return sb.ToString().TrimEnd();
    }
}

