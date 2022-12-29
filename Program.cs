using System;
using System.Linq;

namespace Project_2
{
	public static class Program
	{
		public static void Main()
		{
int sum;

            Console.WriteLine("Enter n1 : ");
            int i = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter n2 : ");
            int z = int.Parse(Console.ReadLine());

            Console.WriteLine("The Perfect Numbers between " + i+ " to " + z + " are :");

            for (int n = i; n <= z; n++)
            {
                sum = 0;
                for (int x = 1; x < n; x++)
                {
                    if (n % x == 0)
                    {
                        sum = sum + x;
                    }
                }

                if (sum == n)
                {
                    Console.WriteLine(n );
                }
            }
		}
	}
}