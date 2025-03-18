namespace _04.SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> parking = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string command = input[0];
                string username = input[1];

                if (command == "register")
                {
                    string plateNumber = input[2];
                    
                    if (parking.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {parking[username]}");
                    }
                    
                    if (!parking.ContainsKey(username))
                    {
                        parking.Add(username, plateNumber);
                        Console.WriteLine($"{username} registered {plateNumber} successfully");
                    }
                }

                else if (command == "unregister")
                {
                    if (!parking.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }

                    if (parking.ContainsKey(username))
                    {
                        parking.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }


            }
            
            foreach (KeyValuePair<string, string> item in parking)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }

        }
    }
}
