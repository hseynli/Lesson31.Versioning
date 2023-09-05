Console.WriteLine(GetNumber(new[] { 2, 3, 5 }));      // 1
Console.WriteLine(GetNumber(new[] { 2, 4, 6 }));      // 2
Console.WriteLine(GetNumber(new[] { 1, 2, 5 }));      // 3
Console.WriteLine(GetNumber(new[] { 1, 2, 3 }));      // 4
Console.WriteLine(GetNumber(new int[] { }));          // 5

int GetNumber(int[] values) => values switch
{
    [2, _, 5] => 1,
    [2, _, _] => 2,
    [_, _, 5] => 3,
    [_, _, _] => 4,
    _ => 5
};

Console.WriteLine(new string('-', 120));

Console.WriteLine(GetNumber2(new[] { 2, 5 }));           // 1
Console.WriteLine(GetNumber2(new[] { 2, 3, 4, 5 }));     // 1

Console.WriteLine(GetNumber2(new[] { 2 }));              // 2
Console.WriteLine(GetNumber2(new[] { 2, 3, 4 }));        // 2

Console.WriteLine(GetNumber2(new[] { 3, 4, 5 }));        // 3
Console.WriteLine(GetNumber2(new[] { 5 }));              // 3

Console.WriteLine(GetNumber2(new int[] { }));            // 4
Console.WriteLine(GetNumber2(new[] { 1 }));              // 4
Console.WriteLine(GetNumber2(new[] { 1, 2, 3 }));        // 4

int GetNumber2(int[] values) => values switch
{
    [2, .., 5] => 1,    // əgər birinci element - 2, sonuncu 5-sə
    [2, ..] => 2,       // əgər birinci element - 2
    [.., 5] => 3,       // əgər sonuncu element - 5
    [..] => 4           // istənilən qədər element
};