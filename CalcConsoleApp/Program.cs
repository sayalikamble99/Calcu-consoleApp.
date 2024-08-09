using System.Diagnostics.CodeAnalysis;

namespace CalcConsoleApp
{
    [ExcludeFromCodeCoverage]

    class Hello
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Started!");
            MathCls mathCls = new MathCls();
            Console.WriteLine("2 + 3 = {0}", mathCls.Add(2, 3));

        }
    }
}