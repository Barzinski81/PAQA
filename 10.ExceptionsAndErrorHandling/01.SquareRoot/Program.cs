namespace _01.SquareRoot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int number = int.Parse(Console.ReadLine());

                if (number < 0)
                {
                    throw new Exception("Invalid number.");
                }

                double numberSquare = Math.Sqrt(number);
                Console.WriteLine(numberSquare);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.WriteLine("Goodbye.");
            }
        }
    }
}
