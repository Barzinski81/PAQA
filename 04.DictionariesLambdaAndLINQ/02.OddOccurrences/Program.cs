namespace _02.OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> sequence = Console.ReadLine().Split().Select(w => w.ToLower()).ToList();

            Dictionary<string, int> words = new Dictionary<string, int>();

            for (int i = 0; i < sequence.Count; i++)
            {
                string word = sequence[i];

                if (words.ContainsKey(word))
                {
                    words[word] ++;
                }
                else
                {
                    words.Add(word, 1);
                }
            }

            foreach (var item in words)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write($"{item.Key} ");
                }
            }
        }
    }
}
