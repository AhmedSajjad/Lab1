using System;

namespace FirstLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            Console.WriteLine("Sajjad Ahmed");

            int x=8;
            int y=4;
            int sum = x + y;
            int div = x / y;
            Console.WriteLine("sum is:"+sum);
            Console.WriteLine("div is:"+div);

            
            int expression1 = -5 + 8 * 6;
            Console.WriteLine("Expression1 is:" + expression1);
            int expression2 = (55 + 9) % 9;
            Console.WriteLine("Expression2 is:" + expression2);
            int expression3 = 20 + -3 * 5 / 8;
            Console.WriteLine("Expression3 is:" + expression3);
            int expression4 = 5 + 15 / 3 * 2 - 8 % 3;
            Console.WriteLine("Expression4 is:" + expression4);


            int add = x + y;
            Console.WriteLine("add is:" + add);
            int sub = x - y;
            Console.WriteLine("sub is:" + sub);
            int mul = x * y;
            Console.WriteLine("mul is:" + mul);
            int Div = x / y;
            Console.WriteLine("Div is:" + Div);
            int rem = x % y;
            Console.WriteLine("rem is:" + rem);


            double expression = ((25.5 * 3.5 - 3.5 * 3.5) / (40.5 - 4.5));
            Console.WriteLine("Expression is:" + expression);


            double h = 8.5, w = 5.6;
            double Area = 8.5 * 5.6;
            double p = 2 * (8.5 + 5.6);
            Console.WriteLine("Area is " +w+ " * " +h+ " = " +Area);
            Console.WriteLine("Perimeter is 2 * ("+w+" + "+h+") = " +p );








        }
    }
}
