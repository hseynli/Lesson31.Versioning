﻿public class BaseClass
{
    public virtual void DoWork() { Console.WriteLine("1"); }
}

public sealed class Derived : BaseClass
{
    // Virtual metodun override olunması
    public override void DoWork() { Console.WriteLine("2"); }
}

class Program
{
    static void Main()
    {
        BaseClass instance = new Derived();
        instance.DoWork();  // 2

        // Delay
        Console.ReadKey();
    }
}