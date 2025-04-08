using System.Text;

namespace TestApp;

public class DivisibilityTransformator
{
    public static string Transform(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return string.Empty;
        }

        string[] values = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        StringBuilder sb = new();

        foreach (string value in values)
        {
            if (int.TryParse(value, out int num))
            {
                if (num == 0 || (num % 2 != 0 && num % 3 != 0))
                {
                    sb.Append($"{num} ");
                }
                else if (num % 2 == 0 && num % 3 == 0)
                {
                    num -= 10;
                    sb.Append($"{num} ");
                }
                else if (num % 2 == 0)
                {
                    sb.Append($"{Math.Pow(num, 2)} ");
                }
                else if (num % 3 == 0)
                {
                    sb.Append($"{num / 2.0} ");
                }
            }
        }

        return sb.ToString().Trim();
    }
}

