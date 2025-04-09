namespace TestApp;

public class LetterCountCalculator
{
    public static int Calculate(string input)
    {
        int upperCaseCount = 0;
        int lowerCaseCount = 0;

        foreach (var letter in input)
        {
            if (char.IsLetter(letter))
            {
                if (char.IsUpper(letter))
                {
                    upperCaseCount++;
                }
                else
                {
                    lowerCaseCount++;
                }
            }
        }

        return upperCaseCount * lowerCaseCount;
    }
}

