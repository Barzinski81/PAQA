namespace _01.CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<char, int> characters = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char currentCharacter = input[i];

                if (currentCharacter == ' ')
                {
                    continue;
                }

                if (!characters.ContainsKey(currentCharacter))
                {
                    characters.Add(currentCharacter, 1);
                }
                else
                {
                    characters[currentCharacter]++;
                }

            }

            foreach (KeyValuePair<char, int> kvp in characters)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
