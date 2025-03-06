using System.Text;

namespace _01.ReverseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            while (text != "end")
            {
                sb.Clear();

                for (int i = text.Length -1; i >= 0; i--)
                {
                    sb.Append(text[i]);
                }

                Console.WriteLine($"{text} = {sb}");

                text = Console.ReadLine();
            }
            
        }
    }
}
