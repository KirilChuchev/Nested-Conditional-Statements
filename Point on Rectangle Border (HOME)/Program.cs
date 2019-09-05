﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_on_Rectangle_Border__HOME_
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            bool side1 = x == x1 && y >= y1 && y <= y2;
            bool side2 = x == x2 && y >= y1 && y <= y2;
            bool side3 = y == y1 && x >= x1 && x <= x2;
            bool side4 = y == y2 && x >= x1 && x <= x2;

            if (side1 || side2 || side3 || side4)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }

        }
    }
}
