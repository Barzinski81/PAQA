namespace _01.Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Students> grades = new List<Students>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string firstName = input[0];
                string lastName = input[1];
                double grade = double.Parse(input[2]);

                Students students = new Students(firstName, lastName, grade);

                grades.Add(students);

            }

            foreach (var item in grades.OrderByDescending(g => g.Grade))
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}: {item.Grade:F2}");
            }
        }
    }
    public class Students
    {
        public Students(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
    }
}
