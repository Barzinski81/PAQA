namespace _05.StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> students = new ();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                
                double grade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(name))
                {
                    students.Add(name, new List<double>());
                }

                students[name].Add(grade);

            }

            foreach(var kvp in students.Where(s => s.Value.Average() >= 4.50))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value.Average():F2}");

            }
        }
    }
}
