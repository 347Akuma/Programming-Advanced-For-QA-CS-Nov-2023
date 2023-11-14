int n = int.Parse(Console.ReadLine());


// create two Dictionaries - one to keep student name and their actual grade
Dictionary<string, double> gradeValues = new Dictionary<string, double>();

// one to keep the amount of grades they have received
Dictionary<string, int> gradeAmounts = new Dictionary<string, int>();

// loop n amount of times
for (int i = 0; i < n; i++)
{
    // receive student name
    string name = Console.ReadLine();
    // receive current grade
    double grade = double.Parse(Console.ReadLine());

    // check if student exists:
    if (gradeValues.ContainsKey(name))
    {
        // if they do -> add their new grade, keeping track of all previous ones
        gradeValues[name] += grade;
        gradeAmounts[name] += 1;
    }
    else
    {
        // if not -> add them
        gradeValues.Add(name, grade);
        gradeAmounts.Add(name, 1);
    }
}

foreach (KeyValuePair<string, double> student in gradeValues)
{
    double studentAverage = gradeValues[student.Key] / gradeAmounts[student.Key];

    if (studentAverage >= 4.50)
    {
        Console.WriteLine($"{student.Key} -> {studentAverage:f2}");
    }
}

// calculate average grades of each student:
// only keep the ones with >= 4.50 (remove all else)

// printer {name} -> {averageGrade}