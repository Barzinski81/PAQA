namespace _01.CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
           
            SortedDictionary<int, int> countOfNumbers = new SortedDictionary<int, int>();

            foreach (int number in numbers)
            {
                if(countOfNumbers.ContainsKey(number))
                {
                    countOfNumbers[number]++;
                }
                else
                {
                    countOfNumbers.Add(number, 1);
                }
            }

            foreach (KeyValuePair<int, int> n in countOfNumbers)
            {
                Console.WriteLine($"{n.Key} -> {n.Value}");
            }
        }
    }
}
