using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359([ -])2\1\d{3}\1\d{4}\b";

            string input = Console.ReadLine();

            MatchCollection validNumbers = Regex.Matches(input, pattern);

            Console.WriteLine(string.Join(", ", validNumbers));

        }
    }
}
