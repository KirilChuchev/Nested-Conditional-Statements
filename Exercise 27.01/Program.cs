using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_27._01
{
    class Program
    {
        static void Main(string[] args)
        {
            // x1, y1, x2, y2, x и y 

            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            // 	x съвпада с x1 или x2
            // y е между y1 и y2

            bool xEqual = x == x1 || x == x2;
            bool yBetween = y >= y1 && y <= y2;
            bool firstCheck = xEqual && yBetween;

            // •	y съвпада с y1 или y2 
            // x е между x1 и x2
            bool yEqual = y==y1 || y==y2;
            bool xBetween = x >= x1 && x <= x2;
            bool secondCheck = yEqual && xBetween;

            if (firstCheck || secondCheck)
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
