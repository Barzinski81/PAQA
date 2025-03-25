namespace _02.EnterNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            int start = 1;

            while (numbers.Count < 10)
            {

                try
                {
                    int currentNumber = ReadNumber(start, 100);
                    numbers.Add(currentNumber);
                    start = currentNumber;
                }

                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine($"Your number is not in range {start} - 100!");
                }

                catch (FormatException)
                {
                    Console.WriteLine("Invalid Number!");
                }

            }

            Console.WriteLine(string.Join(", ",numbers));

            int ReadNumber (int start, int end)
            {
                int number = int.Parse(Console.ReadLine());

                if (number <= start || number >= end)
                {
                    throw new ArgumentOutOfRangeException();
                }

                return number;
            }
        }
    }
}
