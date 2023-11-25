int studentsCount = int.Parse(Console.ReadLine());

List<Student> students = new List<Student>();

for (int i = 1; i <= studentsCount; i++)
{
    string[] input = Console.ReadLine().Split();

    string firstname = input[0];
    string secondname = input[1];
    double grade = double.Parse(input[2]);

    Student student = new Student(firstname, secondname, grade);

    students.Add(student);
}

students = students.OrderByDescending(s => s.Grade).ToList(); // prezapisvame spisuka sled sortiraneto, aka davame mu finalnata stoinost

foreach (Student student in students)
{
    Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
}
