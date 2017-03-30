using System;
namespace ConfigFileCs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Read.FromConfig("HelloWorld"));
            Console.WriteLine(Read.FromConfig("KeyOne"));
            Console.WriteLine(Read.FromConfig("KeyTwo"));
			Console.WriteLine(Read.FromConfig("MacOs"));
			Console.ReadKey();
        }
    }
}
