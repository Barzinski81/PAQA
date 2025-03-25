namespace _03.SumOfIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            List<int> numbers = new List<int>();

            foreach (var item in input)
            {
                try
                {
                   int number = int.Parse(item);
                   numbers.Add(number);
                      
                }

                catch (FormatException)
                {
                    Console.WriteLine($"The element '{item}' is in wrong format!");
                }

                catch (OverflowException)

                {
                    Console.WriteLine($"The element '{item}' is out of range!");
                }

                finally
                {
                    Console.WriteLine($"Element '{item}' processed - current sum: {numbers.Sum()}");
                }

            }

            Console.WriteLine($"The total sum of all integers is: {numbers.Sum()}");
        }
    }
}
