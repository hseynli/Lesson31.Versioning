Employee bob = new Employee();
Employee tom = new Manager();
UseEmployee(tom);   // Manager works
UseEmployee(bob);   // Object is not manager

Console.WriteLine(new string('-', 120));

Employee bob2 = new Manager() { IsOnVacation = true };
Employee tom2 = new Manager() { IsOnVacation = false };
UseEmployeeV2(tom2);   // Manager works
UseEmployeeV2(bob2);   // Employee does not work

void UseEmployee(Employee? emp)
{
    switch (emp)
    {
        case Manager manager:
            manager.Work();
            break;
        case null:
            Console.WriteLine("Object is null");
            break;
        default:
            Console.WriteLine("Object is not manager");
            break;
    }
}

void UseEmployeeV2(Employee? emp)
{
    switch (emp)
    {
        case Manager manager when !manager.IsOnVacation:
            manager.Work();
            break;
        case null:
            Console.WriteLine("Employee is null");
            break;
        default:
            Console.WriteLine("Employee does not work");
            break;
    }
}

class Employee
{
    public virtual void Work() => Console.WriteLine("Employee works");
}

class Manager : Employee
{
    public override void Work() => Console.WriteLine("Manager works");
    public bool IsOnVacation { get; set; }
}