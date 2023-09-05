int[] numbers = { 2, 3, 5 };
if (numbers is [var first, var second, .., var last])
{
    Console.WriteLine($"first: {first}, second: {second}  last: {last}");
}

Console.WriteLine(new string('-', 120));

Console.WriteLine(GetSlice(new[] { 2, 3, 4, 5 }));      // Middle: 3, 4
Console.WriteLine(GetSlice(new[] { 2, 4, 6, 8 }));      // End: 4, 6, 8
Console.WriteLine(GetSlice(new[] { 1, 2, 3, 5 }));      // Start: 1, 2, 3
Console.WriteLine(GetSlice(new[] { 1, 2, 3, 4 }));      // All: 1, 2, 3, 4
Console.WriteLine(GetSlice(new int[] { }));             // All: 

string GetSlice(int[] values) => values switch
{
    [2, .. var middle, 5] => $"Middle: {string.Join(", ", middle)}",
    [2, .. var end] => $"End: {string.Join(", ", end)}",
    [.. var start, 5] => $"Start: {string.Join(", ", start)}",
    [.. var all] => $"All: {string.Join(", ", all)}"
};