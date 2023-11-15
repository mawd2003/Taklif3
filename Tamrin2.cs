using System;
namespace Tamrin2
{
    class test1
    {
        public static void Main()
        {
            Console.WriteLine("Enter X");
            double X = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Y:");
            double Y = Convert.ToDouble(Console.ReadLine());
            math1(X, Y);
            Console.ReadKey();

            static void math1(double X, double Y)
            {
                double Result = Math.Sqrt(Math.Abs(X) + Math.Pow(Y, 2));
                Console.WriteLine("Result is:");
                Console.WriteLine(Result);
            }
        }
    }
}

