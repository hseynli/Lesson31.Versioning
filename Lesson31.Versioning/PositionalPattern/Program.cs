Console.OutputEncoding = System.Text.Encoding.UTF8;

MessageDetails details1 = new MessageDetails { Language = "english", DateTime = "evening", Status = "user" };
string message = GetWelcome(details1);
Console.WriteLine(message);  // Good evening

MessageDetails details2 = new MessageDetails { Language = "french", DateTime = "morning", Status = "admin" };
message = GetWelcome(details2);
Console.WriteLine(message);  // Hello, Admin

Console.WriteLine(new string('-', 120));

details1 = new MessageDetails
{
    Language = "chinese",
    DateTime = "night",
    Status = "moderator"
};
message = GetWelcome2(details1);
Console.WriteLine(message);  // chinese not found, night unknown, moderator undefined

string GetWelcome(MessageDetails details) => details switch
{
    ("english", "morning", _) => "Good morning",
    ("english", "evening", _) => "Good evening",
    ("german", "morning", _) => "Guten Morgen",
    ("german", "evening", _) => "Guten Abend",
    (_, _, "admin") => "Hello, Admin",
    _ => "Здрасьть"
};

string GetWelcome2(MessageDetails details) => details switch
{
    ("english", "morning", _) => "Good morning",
    ("english", "evening", _) => "Good evening",
    ("german", "morning", _) => "Guten Morgen",
    ("german", "evening", _) => "Guten Abend",
    (_, _, "admin") => "Hello, Admin",
    (var lang, var datetime, var status) => $"{lang} not found, {datetime} unknown, {status} undefined",
    _ => "Здрасьть"
};

class MessageDetails
{
    public string Language { get; set; } = "";
    public string DateTime { get; set; } = "";
    public string Status { get; set; } = "";

    public void Deconstruct(out string lang, out string datetime, out string status)
    {
        lang = Language;
        datetime = DateTime;
        status = Status;
    }
}