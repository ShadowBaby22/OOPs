using System;

public class ContractEmployee : Employee
{
    public int ContractEmployeeId { get; set; }

    public ContractEmployee(int id, string name, DateTime dob, int salary, int contractId)
        : base(id, name, dob, salary)
    {
        ContractEmployeeId = contractId;
    }

    public override string DisplayEmployee()
    {
        return base.DisplayEmployee() + ", Employee Type: Contract";
    }

}