using System;
namespace Tamrin1
{
    class test1
    {
        public static void Main()
        {
            Console.WriteLine("Enter Length:");
            double L = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Width:");
            double W = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Height:");
            double H = Convert.ToDouble(Console.ReadLine());
            double Result = Calc(L, W, H);
            Console.WriteLine("Result is :");
            Console.WriteLine(Result);
            Console.ReadKey();
        }
        static double Calc(double num1, double num2, double num3)
        {
            double Voloum = num1 * num2 * num3;
            return Voloum;
        }
    }
}
