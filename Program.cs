/*Employee 
AddEmployee(), DeleteEmployee(), UpdateEmployee()

AddEmployee ==> Employee obj
DeleteEmployee ==> id
UpdateEmployee ==> Employee obj

=====================================================

Console Application.

PermanentEmployye : Employee ==> PeId 

ContractEmployee : Employee ==> Cid

=====================================================

Do you want to create permanent employee press 1

else press 2 to create contract employee

press 3 to view all employees

======================================================

press 1: Add permanent employee ===> add 

press 2: Add Contract employee ==> add 

Press 3: Show all */ 

using System;
using System.Collections.Generic;

public class Program
{
    static List<Employee> employees = new List<Employee>();

    public static void Main(string[] args)
    {
        int choice;
        do
        {
            Console.WriteLine("Please enter your choice:");
            Console.WriteLine("1. Add a permanent employee");
            Console.WriteLine("2. Add a contract employee");
            Console.WriteLine("3. View all employees");
            Console.WriteLine("4. Delete an employee");
            Console.WriteLine("5. Update an employee");
            Console.WriteLine("6. Exit");
            bool isNumeric = int.TryParse(Console.ReadLine(), out choice);

            if (!isNumeric || choice < 1 || choice > 6)
                {
                    Console.WriteLine("Please enter a valid choice.");
                    continue;
                }

            switch (choice)
            {
                case 1:
                try
                {
                    Console.WriteLine("Enter Employee ID:");
                    int permId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Employee Name:");
                    string permName = Console.ReadLine();
                    Console.WriteLine("Enter Employee Date of Birth (yyyy-mm-dd):");
                    DateTime permDob = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Permanent Employee ID:");
                    int permEmpId = Convert.ToInt32(Console.ReadLine());
                    AddEmployee(new PermanentEmployee(permId, permName, permDob, 50000, permEmpId));
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid format. Please enter the correct format.");
                    continue;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                    continue;
                }
                break;

                case 2:
                try
                {
                    Console.WriteLine("Enter Employee ID:");
                    int contId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Employee Name:");
                    string contName = Console.ReadLine();
                    Console.WriteLine("Enter Employee Date of Birth (yyyy-mm-dd):");
                    DateTime contDob = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Contract Employee ID:");
                    int contEmpId = Convert.ToInt32(Console.ReadLine());
                    AddEmployee(new ContractEmployee(contId, contName, contDob, 30000, contEmpId));
                }

                catch (FormatException)
                {
                    Console.WriteLine("Invalid format. Please enter the correct format.");
                    continue;
                }

                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                    continue;
                }
                break;

                case 3:
                    ViewAllEmployees();
                    break;

                case 4:
                    Console.WriteLine("Enter the employee id to delete:");
                    int idToDelete = Convert.ToInt32(Console.ReadLine());
                    DeleteEmployee(idToDelete);
                    break;

                case 5:
                    Console.WriteLine("Enter the employee id to update:");
                    int idToUpdate = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the new name:");
                    string newName = Console.ReadLine();
                    UpdateEmployee(new Employee(idToUpdate, newName, DateTime.Now, 50000));
                    break;
                        }
        } while (choice != 6);
    }

    static void AddEmployee(Employee employee)
    {
        employees.Add(employee);
        Console.WriteLine(employee.DisplayEmployee());
    }

    static void DeleteEmployee(int id)
    {
        employees.RemoveAll(e => e.Id == id);
    }

    static void UpdateEmployee(Employee updatedEmployee)
    {
        for (int i = 0; i < employees.Count; i++)
        {
            if (employees[i].Id == updatedEmployee.Id)
            {
                employees[i] = updatedEmployee;
                break;
            }
        }
    }

    static void ViewAllEmployees()
    {
        if (employees.Count == 0)
        {
            Console.WriteLine($"Warning: No employees to display. Please add an Employee first.");
            return;
        }

        foreach (var employee in employees)
        {
            Console.WriteLine(employee.DisplayEmployee());
        }
    }
}