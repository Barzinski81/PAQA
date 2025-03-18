namespace _02.AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resourceName = Console.ReadLine();

            Dictionary<string, int> resources = new Dictionary<string, int>();

            while (resourceName != "stop")
            {
                int resourceQuantity = int.Parse(Console.ReadLine());

                if (!resources.ContainsKey(resourceName))
                {
                    resources.Add(resourceName, resourceQuantity);
                }
                else
                {
                    resources[resourceName] += resourceQuantity;
                }

                resourceName = Console.ReadLine();
            }

            foreach (KeyValuePair<string, int> item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
