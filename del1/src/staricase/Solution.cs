using System;
using System.Numerics;

namespace DeleteThis
{
	class Solution
	{
		// This solution is not using recursion! Because i didnt really read the title until i was done
		static void Main(string[] args)
		{
			int s = Convert.ToInt32(Console.ReadLine());
			for (int a0 = 0; a0 < s; a0++)
			{
				int n = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine(CalculateNumWays(n));
			}
		}

		// Returns the number of permutations for all rows. 
		public static BigInteger CalculateNumWays(int n)
		{
			BigInteger possibilities = 0;

			// Starting with the highest numbers possible
			int num3 = (n / 3);
			int num2 = Get2s(num3, n);
			int num1 = Get1s(num3, num2, n); ;
			while(num3 >= 0)
			{
				num2 = Get2s(num3, n);
				while(num2 >= 0)
				{
					num1 = Get1s(num3, num2, n);
					possibilities += CalculateRow(num3, num2, num1);
					num2--;
				}
				num3--;
			}
			return possibilities;
		}

		// Calculating the number of permutations of a row. A row is a set of x amount of 3s 2s and 1s independent of order.
		public static BigInteger CalculateRow(int num3, int num2, int num1)
		{
			int length = num3 + num2 + num1;
			BigInteger maxPermutations = Factorial(length);
			BigInteger result = maxPermutations / ((Factorial(num3) * Factorial(num2) * Factorial(num1)));
			return result;
		}

		// Returns max number of 2s with num3 amount of 3s
		public static int Get2s(int num3, int n)
		{
			return (n - (num3 * 3)) / 2;
		}

		// Returns number of 1s with num3, num2 amount of 3s and 2s
		public static int Get1s(int num3, int num2, int n)
		{
			return (n - ((num3 * 3) + (num2 * 2)));
		}
		// Returns n!
		public static BigInteger Factorial(int n)
		{
			BigInteger result = n;
			int factor = n - 1;

			while (factor > 0)
			{
				result *= factor;
				factor--;
			}
			if (result <= 0)
			{
				result = 1;
			}
			return result;
		}
	}
}
