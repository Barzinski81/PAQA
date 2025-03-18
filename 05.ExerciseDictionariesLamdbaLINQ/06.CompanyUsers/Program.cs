namespace _06.CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            while (input != "End")
            {
                string[] splitInput = input.Split(" -> ");

                string companyName = splitInput[0];

                string employeeId = splitInput[1];

                if (!companies.ContainsKey(companyName))
                {
                    companies.Add(companyName, new List<string>());

                    companies[companyName].Add(employeeId);

                }

                else
                {
                    if (!companies[companyName].Contains(employeeId))
                    {
                        companies[companyName].Add(employeeId);

                    }
                }

                input = Console.ReadLine();
            }

            foreach (var item in companies)
            {
                Console.WriteLine(item.Key);

                foreach (var id in item.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
