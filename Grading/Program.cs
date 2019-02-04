using System;
using System.Linq;

namespace Grading
{
	class Program
	{
		static void Main()
		{

			Console.WriteLine("Newer stuff");


			Console.WriteLine("\n\nPlease input the students percentage in numerical format only. No percentages or decimal points!." +
				"\nIf you wish to exit, please close the application, otherwise press enter so you can continue to calcluate.\n\n");

			int score = 0;
			int.TryParse(Console.ReadLine(), out score);

			//score is here.
			if (score == 100)
			{
				Console.WriteLine("A! Perfect score!");
			}

			else if (score < 100 && score >= 88)
			{
				Console.WriteLine("A");
			}
			else if (score < 88 && score >= 80)
			{
				Console.WriteLine("B");
			}

			else if (score <= 79 && score >= 67)
			{
				Console.WriteLine("C");
			}

			else if (score <= 66 && score >= 60)
			{
				Console.WriteLine("D");
			}

			else if (score <= 59 && score >= 0)
			{
				Console.WriteLine("F");
			}

			
			Main();

		}
	}
}
