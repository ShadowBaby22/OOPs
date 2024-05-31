using System;

public class PermanentEmployee : Employee
{
    public int PermanentEmployeeId { get; set; }

    public PermanentEmployee(int id, string name, DateTime dob, int salary, int permId)
        : base(id, name, dob, salary)
    {
        PermanentEmployeeId = permId;
    }

    public override string DisplayEmployee()
    {
        return base.DisplayEmployee() + ", Employee Type: Permanent";
    }

}