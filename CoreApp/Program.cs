using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        SharedProject1.SharedClass sc = new SharedProject1.SharedClass();
        dotnetLib.Class1 cl = new dotnetLib.Class1();
        dotnet2Lib.Class1 d2 = new dotnet2Lib.Class1();

        WriteLine(cl.a);
        WriteLine(d2.val);

        WriteLine("Hello World!");

        ReadKey();
    }
}