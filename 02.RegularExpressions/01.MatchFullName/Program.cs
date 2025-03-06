using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string pattern = @"\b[A-Z][a-z]+[ ][A-Z][a-z]+";

            string input = Console.ReadLine();
            
            MatchCollection regexMatches = Regex.Matches(input, pattern);

            Console.WriteLine(string.Join(" ", regexMatches));

        }
    }
}
