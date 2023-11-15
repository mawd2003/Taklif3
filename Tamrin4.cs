using System;
namespace Tamrin4
{
    class test1
    {
        public static void Main()
        {
            Console.WriteLine("Enter Mid");
            double Mid = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Final:");
            double Final = Convert.ToDouble(Console.ReadLine());
            Score(Mid, Final);
            Console.ReadKey();
        }
        static void Score(double Mid, double Final)
        {
            double FinalScore = 0.35 * Mid + 0.65 * Final;
            Console.WriteLine("Finsl Score is:");
            Console.WriteLine(FinalScore);
        }
    }
}
