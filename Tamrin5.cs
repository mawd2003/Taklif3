using System;
namespace Tamrin5
{
	class test1
	{
		public static void Main()
		{
			Console.WriteLine("Enter your number :");
			int X = Convert.ToInt32(Console.ReadLine());
			if (X % 2 == 0)
			{
				even(X);
			}
			else
			{
				odd(X);
			}
			Console.ReadKey();

		}
		static void even(int X)
		{
			int sum = 0, mul = 1;
			for (int i = 2; i <= X; i = i + 2)
			{
				sum += i;
				mul *= i;
			}
			Console.WriteLine("Sum is :");
			Console.WriteLine(sum);
			Console.WriteLine("Mul is :");
			Console.WriteLine(mul);
		}
		static void odd(int X)
		{
			int sum = 0, mul = 1;
			for (int i = 1; i <= X; i = i + 2)
			{
				sum += i;
				mul *= i;
			}
			Console.WriteLine("Sum is :");
			Console.WriteLine(sum);
			Console.WriteLine("Mul is :");
			Console.WriteLine(mul);
		}
	}
}


