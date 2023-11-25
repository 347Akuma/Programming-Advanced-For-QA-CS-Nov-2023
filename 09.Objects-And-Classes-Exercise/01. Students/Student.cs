
internal class Student
{
    // fields -> harakteristiki na klasa

    private string firstName;
    private string lastName;
    private double grade;

    //properties -> osigurqvame si dostup do poletata

    public string FirstName
    {
        get { return firstName; } // get current value
        set { firstName = value; } // set new value
    }

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public double Grade
    {
        get { return grade; }
        set { grade = value; }
    }

    //constructor -> method, chrez koito suzdavame obekti ot tozi klas       
    public Student(string firstName, string lastName, double grade) // priema stoinostite
    {
        // suzdava se publichen prazen obekt (s imeto na klasa) sus vsichkite harakteristiki na klasa
        FirstName = firstName; // sreshtu field FirstName -> stoinostta na firstName
        LastName = lastName;
        Grade = grade;

    }
}
