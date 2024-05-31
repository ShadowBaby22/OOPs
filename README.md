Creating a Console App that utilizes Object Oriented Programming Princles: 

Key OOP Concepts Covered
Class and Object: The Employee class serves as the blueprint for creating employee objects. PermanentEmployee and ContractEmployee are subclasses that inherit from Employee.

Inheritance: Demonstrated through the creation of PermanentEmployee and ContractEmployee classes that inherit from the Employee class. This illustrates how common properties and methods are shared among classes, promoting code reusability.

Polymorphism: The AddEmployee method is polymorphic , allowing different behaviors based on whether the employee is a permanent or contract employee.

Encapsulation: The attributes id, name, dob, and salary are encapsulated within the Employee class, and are accessed and modified through methods, maintaining data integrity.

Constructors: Used to initialize employee objects with specific attributes. The constructors ensure that every employee object is created with necessary initial data.

Properties: Used to get and set the values of the employee attributes, ensuring that the encapsulation principle is maintained while allowing controlled access to the object's data.

Association: The relationships between different employee objects and operations such as adding, deleting, and updating employees demonstrate associations between classes.

Project Structure:
Program.cs: Main entry point of the application.
Employee.cs: Base class representing an employee.
PermanentEmployee.cs: Derived class representing a permanent employee.
ContractEmployee.cs: Derived class representing a contract employee.
