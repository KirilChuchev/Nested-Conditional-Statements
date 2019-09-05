using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Room__HOME_
{
	class Program
	{
		static void Main(string[] args)
		{

			string month = Console.ReadLine();
			int overnights = int.Parse(Console.ReadLine());

			double priceStudio = 0.0;
			double priceApartment = 0.0;

			// ((month == "May" || month == "October") && overnights > 7 )



			switch (month) 
			{
				case "May":
				case "October":
					{
						priceStudio = overnights * 50.0;
						priceApartment = overnights * 65.0;

						if (overnights > 7 && overnights <= 14)
						{
							priceStudio -= 0.05 * priceStudio;
						}
						else if (overnights > 14)
						{
							priceStudio -= 0.30 * priceStudio;
							priceApartment -= 0.10 * priceApartment;
						}
						else
						{

						}
					}
					break;
				case "June":
				case "September ":
					{
						priceStudio = overnights * 75.2;
						priceApartment = overnights * 68.7;

						if (overnights > 14)
						{
							priceStudio -= 0.20 * priceStudio;
							priceApartment -= 0.10 * priceApartment;
						}
						else
						{

						}
					}
					break;

				case "July":
				case "August":
					{
						priceStudio = overnights * 76.0;
						priceApartment = overnights * 77.0;

						if (overnights > 14)
						{
							priceApartment -= 0.10 * priceApartment;
						}
						else
						{

						}
					}
					break;
				default:
					break;

			}

			Console.WriteLine($"Apartment: {priceApartment:F2} lv.");
			Console.WriteLine($"Studio: {priceStudio:F2} lv.");
			
			
		}
	}
}
