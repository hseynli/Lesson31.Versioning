Employee tom = new Manager();
UseEmployee(tom);   // Manager works

void UseEmployee(Employee emp)
{
    if (emp is Manager manager && manager.IsOnVacation == false)
    {
        manager.Work();
    }
    else
    {
        Console.WriteLine("Casting is not allowed...");
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