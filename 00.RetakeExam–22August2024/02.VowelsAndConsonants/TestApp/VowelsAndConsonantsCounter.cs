namespace TestApp
{
    public class VowelsAndConsonantsCounter
    {
        public static Dictionary<string, int> AnalyzeSentence(string sentence)
        {
            Dictionary<string, int> result = new();

            if (string.IsNullOrEmpty(sentence))
            {
                return result;
            }

            string[] words = sentence.ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            
            foreach (string word in words)
            {
                int wordClassifiedHandler = 0;

                foreach (char letter in word)
                {
                    if (char.IsLetter(letter))
                    {
                        if ("aeiou".Contains(letter))
                        {
                            wordClassifiedHandler += 1;
                        }
                        else
                        {
                            wordClassifiedHandler -= 1;
                        }
                    }
                }

                if (wordClassifiedHandler > 0)
                {
                    if (result.ContainsKey("vowel-rich") == false)
                    {
                        result.Add("vowel-rich", 0);
                    }

                    result["vowel-rich"]++;
                }
                else if (wordClassifiedHandler < 0) 
                {
                    if (result.ContainsKey("consonant-rich") == false)
                    {
                        result.Add("consonant-rich", 0);
                    }

                    result["consonant-rich"]++;
                }
                else
                {
                    if (result.ContainsKey("balanced") == false)
                    {
                        result.Add("balanced", 0);
                    }

                    result["balanced"]++;
                }
            }

            return result;
        }
    }
}
