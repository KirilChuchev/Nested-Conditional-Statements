using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfMovie = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            int seats = rows * columns;
            double priceOfTicket = 0.00;

            if (typeOfMovie == "Premiere")
            {
                 priceOfTicket = 12.00;
            }
            else if (typeOfMovie == "Normal")
            {
                 priceOfTicket = 7.5;
            }
            else if (typeOfMovie == "Discount")
            {
                 priceOfTicket = 7.5;
            }

            double totalPrice = priceOfTicket * seats;

            Console.WriteLine("{0:f2} leva", totalPrice);
        }
    }
}
