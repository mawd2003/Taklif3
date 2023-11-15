using System;
namespace Tamrin3
{
    class test1
    {
        public static void Main()
        {
            Console.WriteLine("Enter X");
            double X = Convert.ToDouble(Console.ReadLine());
            double Result = Answer(X);
            Console.WriteLine("Result is :");
            Console.WriteLine(Result);
            Console.ReadKey();
        }
        static double Answer(double X)
        {
            double voloum = Math.Pow(X, 2) - 2 * X + 4;
            return voloum;
        }
    }
}

