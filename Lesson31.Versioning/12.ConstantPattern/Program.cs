string message = "hello";

if (message is "hello")
{
    Console.WriteLine("hello");
}

Console.WriteLine(new string('-', 120));

string name = null;

if (name is null) //name is not null
{
    Console.WriteLine("name is null");
}
else
    Console.WriteLine(name);