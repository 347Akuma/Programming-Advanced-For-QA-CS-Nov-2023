public class Student
{
    public Student(string firstName, string lastName, int age, string homeTown)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        HomeTown = homeTown;
    }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public int Age { get; set; }

    public string HomeTown { get; set; }

}

namespace _02._Students
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] studentInfo = input.Split(" ");

                string studentFirstName = studentInfo[0];
                string studentLastName = studentInfo[1];
                int studentAge = int.Parse(studentInfo[2]);
                string homeTown = studentInfo[3];

                Student currentStudent = new Student(studentFirstName, studentLastName, studentAge, homeTown);

                students.Add(currentStudent);
            }
            string targetCity = Console.ReadLine();

            List<Student> filteredStudents = students
                .Where(x => x.HomeTown == targetCity)
                .ToList();

            foreach (Student student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }
}