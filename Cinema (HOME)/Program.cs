using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema__HOME_
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double totalIncome = 0;

            switch (projection)
            {
                case "Premiere":
                    {
                        totalIncome = rows * columns * 12.00;
                    }
                    break;
                case "Normal":
                    {
                        totalIncome = rows * columns * 7.50;
                    }
                    break;
                case "Discount":
                    {
                        totalIncome = rows * columns * 5.00;
                    }
                    break;
            }

            Console.WriteLine("{0:F2} leva", totalIncome);

        }
    }
}
