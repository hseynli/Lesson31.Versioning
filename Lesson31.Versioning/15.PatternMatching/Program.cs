Company microsoft = new Company("Microsoft");
Company google = new Company("Google");
Employee tom = new Employee("Tom", microsoft);
Employee bob = new Employee("Bob", google);

PrintCompany(tom);
PrintCompany(bob);

Console.WriteLine(new string('-', 120));

PrintCompany2(tom);
PrintCompany2(bob);

void PrintCompany(Employee employee)
{
    if (employee is Employee { Company: { Title: "Microsoft" } })
    {
        Console.WriteLine($"{employee.Name} works in Microsoft");
    }
    else
    {
        Console.WriteLine($"{employee.Name} works someware");
    }
}

void PrintCompany2(Employee employee)
{
    if (employee is Employee { Company.Title: "Microsoft" })
    {
        Console.WriteLine($"{employee.Name} works in Microsoft");
    }
    else
    {
        Console.WriteLine($"{employee.Name} works someware");
    }
}

class Employee
{
    public string Name { get; }
    public Company Company { get; set; }
    public Employee(string name, Company company)
    {
        Name = name;
        Company = company;
    }

}
class Company
{
    public string Title { get; }
    public Company(string title) => Title = title;
}