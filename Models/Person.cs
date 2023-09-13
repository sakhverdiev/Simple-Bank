namespace BankApp.Models;

public class Person
{
    Guid _id { get; set; } = Guid.NewGuid();
    string _name { get; set; }
    string _surname { get; set; }
    int _age { get; set; }
    string _position { get; set; }

    double _salary { get; set; }

    public Person() { }

    public Person(string name, string surname, int age, string position, double salary)
    {
        _name = name;
        _surname = surname;
        _age = age;
        _position = position;
        _salary = salary;
    }

    virtual public void show()
    {
        Console.WriteLine($"Name \t--> {_name}\nSurname --> {_surname}\nAge \t--> {_age}\nPositon --> {_position}\nSalary \t--> {_salary}");
    }

}