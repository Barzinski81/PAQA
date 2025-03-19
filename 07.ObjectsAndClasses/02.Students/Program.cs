namespace _02.Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Student> students = new List<Student>();

            while (input != "end")
            {
                string[] studentsInfo = input.Split();

                Student student = new Student();

                student.FirstName = studentsInfo[0];
                student.LastName = studentsInfo[1];
                student.Age = int.Parse(studentsInfo[2]);
                student.HomeTown = studentsInfo[3];

                students.Add(student);

                input = Console.ReadLine() ;

            }

            string town = Console.ReadLine();

            foreach (var item in students.Where(s => s.HomeTown == town))
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} is {item.Age} years old.");

            }
        }
    }

    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string HomeTown { get; set; }
    }
}
