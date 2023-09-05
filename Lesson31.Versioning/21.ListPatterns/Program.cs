// Kolleksiyanın xassələri

int[] numbers = { 2, 3, 5 };
if (numbers is { Length: 3 } and [var first, var second, var third])
{
    Console.WriteLine($"first: {first}, second: {second}  third: {third}");
}