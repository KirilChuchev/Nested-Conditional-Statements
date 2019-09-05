using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summer_Outfit__HOME_
{
    class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string partOfDay = Console.ReadLine();

            string Outfit = "";
            string Shoes = "";
            partOfDay = partOfDay.ToLower();

            //(partOfDay == "Мorning" || partOfDay == "Evening" || partOfDay == "Afternoon")
           // bool isOurPartOfTheDay = (partOfDay == "morning") || (partOfDay == "evening") || (partOfDay == "afternoon");

            if ((degrees >= 10 && degrees <= 18) && ((partOfDay == "evening") || (partOfDay == "afternoon")))
            {
                Outfit = "Shirt";
                Shoes = "Moccasins";
                Console.WriteLine($"It's {degrees} degrees, get your {Outfit} and {Shoes}.");
            }
            else if ((degrees >= 10 && degrees <= 18) && (partOfDay == "morning"))
            {
                Outfit = "Sweatshirt";
                Shoes = "Sneakers";
                Console.WriteLine($"It's {degrees} degrees, get your {Outfit} and {Shoes}.");
            }
            else if ((degrees > 18 && degrees <= 24) && (partOfDay == "morning" || partOfDay == "evening"))
            {
                Outfit = "Shirt";
                Shoes = "Moccasins";
                Console.WriteLine($"It's {degrees} degrees, get your {Outfit} and {Shoes}.");

            }
            else if ((degrees > 18 && degrees <= 24) && partOfDay == "afternoon")
            {
                Outfit = "T-Shirt";
                Shoes = "Sandals";
                Console.WriteLine($"It's {degrees} degrees, get your {Outfit} and {Shoes}.");

            }
            else if (degrees >= 25)
            {
                switch (partOfDay)
                {
                    case "morning":
                        {
                            Outfit = "T-Shirt";
                            Shoes = "Sandals";
                            Console.WriteLine($"It's {degrees} degrees, get your {Outfit} and {Shoes}.");

                        }
                        break;
                    case "afternoon":
                        {
                            Outfit = "Swim Suit";
                            Shoes = "Barefoot";
                            Console.WriteLine($"It's {degrees} degrees, get your {Outfit} and {Shoes}.");

                        }
                        break;
                    case "evening":
                        {
                            Outfit = "Shirt";
                            Shoes = "Moccasins";
                            Console.WriteLine($"It's {degrees} degrees, get your {Outfit} and {Shoes}.");

                        }
                        break;
                }
            }
        }
    }
}
