using System.Text.RegularExpressions;

namespace _03.MatchDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<Day>\d{2})(?<sep>[.\-/])(?<Month>[A-Z][a-z]{2})\<sep>(?<Year>\d{4})";

            string input = Console.ReadLine();

            MatchCollection dates = Regex.Matches(input, pattern);

            foreach (Match match in dates)
            {
                string day = match.Groups["Day"].Value;
                string month = match.Groups["Month"].Value;
                string year = match.Groups["Year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }


        }
    }
}
