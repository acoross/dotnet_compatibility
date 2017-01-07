using System;

class Program
{
    static void Main(string[] args)
    {
        dotnet2Lib.Class1 d2 = new dotnet2Lib.Class1();
        Console.WriteLine(d2.val);

        dotnetLib.Class1 dl = new dotnetLib.Class1();
        Console.WriteLine(dl.a);

        Console.WriteLine("Hello World!");
    }
}
