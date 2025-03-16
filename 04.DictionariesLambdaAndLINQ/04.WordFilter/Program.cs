namespace _04.WordFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split().Where(s => s.Length % 2 == 0).ToArray();

            foreach (string s in strings)
            {
                Console.WriteLine(s);
            }
        }
    }
}
