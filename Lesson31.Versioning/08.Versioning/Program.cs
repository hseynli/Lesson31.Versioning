class BaseClass
{
    public virtual void SomeMethods()
    {
        SomeMetod1();
        SomeMetod2();
    }

    public virtual void SomeMetod1() { Console.Write("1."); }
    public virtual void SomeMetod2() { Console.Write("2."); }
}

class DerivedClass : BaseClass
{
    public new void SomeMethods()
    {
        SomeMetod1();
        SomeMetod2();
    }

    public new void SomeMetod1() { Console.Write("3."); }
    public override void SomeMetod2() { Console.Write("4."); }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        while (true)
        {
            Console.Write("Açar daxil edin - 0, 1 və ya 2: ");
            string s = Console.ReadLine();

            if (s == "0") // Versiya: 1.2
                new BaseClass().SomeMethods();

            if (s == "1") // Versiya: 1.4
                (new DerivedClass() as BaseClass).SomeMethods();

            if (s == "2") // Versiya: 3.4                
                new DerivedClass().SomeMethods();

            Console.WriteLine("\n");
        }
    }
}