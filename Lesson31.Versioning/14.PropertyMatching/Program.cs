Person tom = new Person { Language = "english", Status = "user", Name = "Tom" };
Person pierre = new Person { Language = "french", Status = "user", Name = "Pierre" };
Person admin = new Person { Language = "english", Status = "admin", Name = "Admin" };

SayHello(tom);      // Hello
SayHello(pierre);   // Salut

Console.WriteLine(new string('-', 120));

SayHello2(admin);    // Hello, admin

Console.WriteLine(new string('-', 120));

Console.WriteLine(GetMessage(tom));

Console.WriteLine(new string('-', 120));

Console.WriteLine(GetMessage2(pierre));

void SayHello(Person person)
{
    if (person is Person { Language: "french" })
    {
        Console.WriteLine("Salut");
    }
    else
    {
        Console.WriteLine("Hello");
    }
}


void SayHello2(Person person)
{
    if (person is Person { Language: "english", Status: "admin" })
    {
        Console.WriteLine("Hello, admin");
    }
    else if (person is Person { Language: "french" })
    {
        Console.WriteLine("Salut");
    }
    else
    {
        Console.WriteLine("Hello");
    }
}

string GetMessage(Person p) => p switch
{
    { Language: "english" } => "Hello!",
    { Language: "german", Status: "admin" } => "Hallo, admin!",
    { Language: "french" } => "Salut!",
    { } => "undefined",
    null => "null"       // əgər Person p = null
};

string GetMessage2(Person p) => p switch
{
    { Language: "german", Status: "admin" } => "Hallo, admin!",
    { Language: "french", Name: string name } => $"Salut, {name}!",
    { Language: var lang } => $"Unknown language: {lang}",
    null => "null"
};

class Person
{
    public string Name { get; set; } = "";
    public string Status { get; set; } = "";
    public string Language { get; set; } = "";
}