using System;

namespace _3nPlusOne
{
	class Program
	{
		static void Main(string[] args)
		{
			int i=0, startN, n;
			
			Console.Write("Starting number: ");
			startN = Convert.ToInt32(Console.ReadLine());
			n = startN;
			while (n > 1)
			{
				if (n % 2 != 0)
				{
					n = (3 * n) + 1;
					i++;
					Console.WriteLine(i + " " + n);
				}
				if (n % 2 == 0)
				{
					n = n / 2;
					i++;
					Console.WriteLine(i + " " + n);
				}
				
			}
			Console.Write("It took " + i + " steps to get from " + startN + " to " + n);
			Console.ReadLine();
		}
	}
}
