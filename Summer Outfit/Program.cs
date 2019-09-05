using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summer_Outfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string partOfDay = Console.ReadLine();

            string outfit = "";
            string shoes = "";

            switch (partOfDay)
            {
                case "Morning":
                    {
                        if (degrees >=10 && degrees <= 18)
                        {
                            outfit = "Sweatshirt";
                            shoes = "Sneakers";
                        }
                        else if (degrees > 18 && degrees <= 24)
                        {
                            outfit = "Shirt";
                            shoes = "Moccasini";
                        }
                        else if (degrees >= 25)
                        {
                            outfit = "T-Shirt";
                            shoes = "Sandals";
                        }
                        break;

                    }
                case "Afternoon":
                    {
                        if (degrees >= 10 && degrees <= 18)
                        {
                            outfit = "Shirt";
                            shoes = "Moccasini";
                        }
                        else if (degrees > 18 && degrees <= 24)
                        {
                            outfit = "T-shirt";
                            shoes = "Sandals";
                        }
                        else if (degrees >= 25)
                        {
                            outfit = "Swim Suit";
                            shoes = "Barefoot";
                        }
                        break;
                    }
                case "Evening":
                    {
                        if (degrees >= 10 && degrees <= 18)
                        {
                            outfit = "Shirt";
                            shoes = "Moccasini";
                        }
                        else if (degrees > 18 && degrees <= 24)
                        {
                            outfit = "Shirt";
                            shoes = "Moccasini";
                        }
                        else if (degrees >= 25)
                        {
                            outfit = "Shirt";
                            shoes = "Moccasini";
                        }
                        break;
                    }
            }

            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");

        }
    }
}
