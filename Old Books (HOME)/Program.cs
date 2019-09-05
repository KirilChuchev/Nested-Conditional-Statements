using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Old_Books__HOME_
{
	class Program
	{
		static void Main(string[] args)
		{

			string bookOfAni = Console.ReadLine();
			int capacity = int.Parse(Console.ReadLine());

			
			string booksAvailable = Console.ReadLine();
			int counter = 1;

			while (bookOfAni != booksAvailable)
			{
				

				if (counter >= capacity)
				{
					Console.WriteLine("The book you search is not here!");
					Console.WriteLine($"You checked {capacity} books.");
					break;
				}

				booksAvailable = Console.ReadLine();
				counter++;

			}

			if (bookOfAni == booksAvailable)
			{
				Console.WriteLine($"You checked {counter - 1} books and found it.");
			}
			
			
		}
	}
}
