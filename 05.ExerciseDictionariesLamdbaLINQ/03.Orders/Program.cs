namespace _03.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, double[]> products = new ();

            while (input != "buy")
            {
                string[] productProperties = input.Split();

                string productName = productProperties[0];
                double productPrice = double.Parse(productProperties[1]);
                double productQuantity = double.Parse(productProperties[2]);

                if (!products.ContainsKey(productName))
                {
                    products.Add(productName, new double[2]);
                }

                products[productName][0] = productPrice;

                products[productName][1] += productQuantity;

                input = Console.ReadLine();
            }

            foreach(KeyValuePair<string, double[]> kvp in products)
            {
                double price = kvp.Value[0];
                double qunatity = kvp.Value[1];

                Console.WriteLine($"{kvp.Key} -> {(kvp.Value[0] * kvp.Value[1]):F2}");
            }
        }
    }
}
