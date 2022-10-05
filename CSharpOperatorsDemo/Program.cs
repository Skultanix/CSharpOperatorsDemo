using System;

namespace CSharpOperatorsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //var a = 10;
            //var b = 3;

            var a = 1;
            var b = 2;
            var c = 3;

            //Console.WriteLine(a + b);
            //Console.WriteLine((float)a / (float)b);

            //Operators in C# behave like typical order of operations in math
            //Console.WriteLine(a + b * c);
            //Console.WriteLine((a+b) * c);

            /* Console.WriteLine(a < b); //returns true
             Console.WriteLine(a == b); //returns false
             Console.WriteLine(a != b); //returns true
             Console.WriteLine(!(a != b)); //returns false, double negative*/

            Console.WriteLine(c > b && c > a); //returns true
            Console.WriteLine(c > b && c == a); //returns false
            Console.WriteLine(c > b || c == a); //returns true
            Console.WriteLine(!(c > b || c == a)); //returns false
        }
    }
}