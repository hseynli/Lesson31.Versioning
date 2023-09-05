Console.OutputEncoding = System.Text.Encoding.UTF8;

string message = GetWelcome("english", "evening");
Console.WriteLine(message);  // Good evening

message = GetWelcome("french", "morning");
Console.WriteLine(message);  // Здрасьть

Console.WriteLine(new string('-', 120));

message = GetWelcome2("english", "evening", "user");
Console.WriteLine(message);  // Good evening

message = GetWelcome2("french", "morning", "admin");
Console.WriteLine(message);  // Hello, Admin

string GetWelcome(string lang, string daytime) => (lang, daytime) switch
{
    ("english", "morning") => "Good morning",
    ("english", "evening") => "Good evening",
    ("german", "morning") => "Guten Morgen",
    ("german", "evening") => "Guten Abend",
    _ => "Здрасьть"
};

string GetWelcome2(string lang, string daytime, string status) => (lang, daytime, status) switch
{
    ("english", "morning", _) => "Good morning",
    ("english", "evening", _) => "Good evening",
    ("german", "morning", _) => "Guten Morgen",
    ("german", "evening", _) => "Guten Abend",
    (_, _, "admin") => "Hello, Admin",
    _ => "Здрасьть"
};