using System;

namespace PersonInfo;

public class Person
{
    private string _firstName;
    private string _lastName;
    private int _age;

    private const int NAME_MIN_LENGTH = 3;

    public Person(string firstName, string lastName, int age) //add constructor
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
    }

    public string FirstName // at least 3 symbols
    {
        get { return this._firstName; }
        private set
        {
            if (value.Length < NAME_MIN_LENGTH)
            {
                throw new ArgumentException($"First name cannot contain fewer than {NAME_MIN_LENGTH} symbols!");
            }
            this._firstName = value;
        }
    }

    public string LastName
    {
        get { return this._lastName; }
        private set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
            }
            this._lastName = value;
        }
    }

    public int Age // 0 or negative
    {
        get { return this._age; }
        private set 
        { 
            if (value <= 0)
            {
                throw new InvalidOperationException("Age cannot be zero or a negative integer!");
            }
            this._age = value; 
        }
    }

    public override string ToString()
    {
        return $"{this.FirstName} {this.LastName} is {this.Age} years old.";
    }
}

 