using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            // krajna cena = broi cvetia * cena na cveteto
            // cena s oststupka
            // proverka s biudjeta

            string typeFlowers = Console.ReadLine();
            int flowersCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double priceForOneFlower = 0;

            if (typeFlowers == "Roses")
            {
                priceForOneFlower = 5.00;
            }
            else if (typeFlowers == "Dahlias")
            {
                priceForOneFlower = 3.80;
            }
            else if (typeFlowers == "Tulips")
            {
                priceForOneFlower = 2.80;
            }

            double totalPrice = flowersCount * priceForOneFlower;

            if (flowersCount > 80 && typeFlowers == "Roses")
            {
                totalPrice -= totalPrice * 0.90;
            }
            else if (flowersCount > 90 && typeFlowers == "Dahlias")
            {
                totalPrice -= totalPrice * 0.10;
            }
            else if (flowersCount < 120 && typeFlowers == "Narcissus")
            {
                totalPrice += totalPrice * 0.15;
            }
            else if (flowersCount < 80 && typeFlowers == "Gladiolus")
            {
                totalPrice = totalPrice * 1.20;
            }

            if (budget >= totalPrice)
            {
                double leftMoney = budget - totalPrice;
                Console.WriteLine($"Hey, you have a great garden with {flowersCount} {typeFlowers} and {leftMoney:F2} leva left.");
            }
            else
            {
                double moneyNeeded = totalPrice - budget;
                Console.WriteLine($"Not enough money, you need {moneyNeeded:F2} leva more.");
            }
        }
    }
}
