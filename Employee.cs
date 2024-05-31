using System;

public class Employee
{
    public int Id { get; set; } //Setting Properties using Getter and Setter    
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    private int Salary { get; set; }

    public Employee(int id, string name, DateTime dob, int salary)
    {
        Id = id;
        Name = name;
        DateOfBirth = dob;
        Salary = salary;
    }

    public virtual string DisplayEmployee() //Virtual Method allows for overriding
    {
    return $"ID: {Id}, Name: {Name}, DOB: {DateOfBirth}, Salary: {Salary}";
    }

}