namespace _03.WordSynonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> wordsList = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!wordsList.ContainsKey(word))
                {
                    wordsList.Add(word, new List<string>());
                }
                                
                    wordsList[word].Add(synonym);
                
            }

            foreach (var item in wordsList)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ",item.Value)}");
            }

        }
    }
}
