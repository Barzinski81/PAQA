namespace _04.TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");

            string text = Console.ReadLine();

            foreach (string word in bannedWords) 
            { 
                string stars = new ('*', word.Length);
                
                if(text.Contains(word))

                {
                    text = text.Replace(word, stars);
                }
            
            }

            Console.WriteLine(text);
        }
    }
}
