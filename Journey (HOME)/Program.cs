using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journey__HOME_
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = Double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            string jurney = "";
            double price = 0.0;

			if (budget <= 100 && season == "summer")
			{
				price = 0.3 * budget;
				destination = "Bulgaria";
				jurney = "Camp";

			}
			else if (budget <= 100 && season == "winter")
			{
				price = 0.7 * budget;
				destination = "Bulgaria";
				jurney = "Hotel";

			}
			else if (budget <= 1000 && season == "summer")
			{
				price = 0.4 * budget;
				destination = "Balkans";
				jurney = "Camp";

			}
			else if (budget <= 1000 && season == "winter")
			{
				price = 0.8 * budget;
				destination = "Balkans";
				jurney = "Hotel";

			}
			else if (budget > 1000)
			{
				price = 0.9 * budget;
				destination = "Europe";
				jurney = "Hotel";

			}
			Console.WriteLine($"Somewhere in {destination}");
			Console.WriteLine($"{jurney} - {price:F2}");

		}
    }
}
