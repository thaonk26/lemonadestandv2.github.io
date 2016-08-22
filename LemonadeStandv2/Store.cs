using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandv2
{
    class Store
    {
        public int storeLemons;
        public int storeIce = 0;
        public int storeCups = 0;
        public int storeSugar = 0;
        public double pricePerLemon = .05;
        public double pricePerIce = .01;
        public double pricePerCup = 0.02;
        public double pricePerSugar = .05;

        public Store()
        {

        }
        public int BuyLemons(Bank bank, Weather currentWeather, Inventory inventory, Day day, Lemon lemon, Sugar sugar, Ice ice, Cups cups, Player player)
        {
            bool buyingLemons = true;
            int amountOfLemons;
            while (buyingLemons)
            {
                Console.Clear();
                inventory.printDisplay(bank, currentWeather, lemon, sugar, ice, cups, day, player);
                Console.WriteLine();
                Console.WriteLine("Each Lemon costs $0.05. Enter '999' to move on.");
                storeLemons = 0;
                int.TryParse(Console.ReadLine(), out amountOfLemons);
                if((bank.money - (pricePerLemon * amountOfLemons) > 0))
                {
                    storeLemons = storeLemons + amountOfLemons;
                    bank.money = bank.money - (pricePerLemon * amountOfLemons);
                    lemon.lemon = lemon.lemon + storeLemons;
                } else if(amountOfLemons == 999)
                {
                    storeLemons = 0;
                    buyingLemons = false;
                } else
                {
                    Console.WriteLine("You don't have enough money");
                    Console.ReadLine();
                }
            }
            return storeLemons;
        }
        public int BuyCups(Bank bank, Weather currentWeather, Inventory inventory, Day day, Cups cups, Lemon lemon, Ice ice, Sugar sugar, Player player)
        {
            bool buyingCups = true;
            int amountOfCups;
            while (buyingCups)
            {
                Console.Clear();
                inventory.printDisplay(bank, currentWeather, lemon, sugar, ice, cups, day, player);
                Console.WriteLine();
                Console.WriteLine("Each Cup costs $0.02. Enter '999' to move on.");
                int.TryParse(Console.ReadLine(), out amountOfCups);
                if ((bank.money - (pricePerCup * amountOfCups) > 0))
                {
                    storeCups = storeCups + amountOfCups;
                    bank.money = bank.money - (pricePerLemon * amountOfCups);
                    cups.cups = cups.cups + storeCups;
                }else if(amountOfCups == 999)
                {
                    storeCups = 0;
                    buyingCups = false;
                }
                else
                {
                    Console.WriteLine("You don't have enough money");
                    Console.ReadLine();
                }
            }
            return storeCups;
        }
        public int BuyIce(Bank bank, Weather currentWeather, Inventory inventory, Day day, Ice ice, Lemon lemon, Sugar sugar, Cups cups, Player player)
        {
            bool buyingIce = true;
            int amountOfIce;
            while (buyingIce)
            {
                Console.Clear();
                inventory.printDisplay(bank, currentWeather, lemon, sugar, ice, cups, day, player);
                Console.WriteLine();
                Console.WriteLine("Each Ice Cube costs $0.01. Enter '999' to move on.");
                int.TryParse(Console.ReadLine(), out amountOfIce);
                if ((bank.money - (pricePerIce * amountOfIce) > 0))
                {
                    storeIce = storeIce + amountOfIce;
                    bank.money = bank.money - (pricePerIce * amountOfIce);
                    ice.ice = ice.ice + storeIce;
                } else if(amountOfIce == 999)
                {
                    storeIce = 0;
                    buyingIce = false;
                }
                else
                {
                    Console.WriteLine("You don't have enough money");
                    Console.ReadLine();
                }
            }
            return storeIce;
        }
        public int BuySugar(Bank bank, Weather currentWeather, Inventory inventory, Day day, Sugar sugar, Lemon lemon, Ice ice, Cups cups, Player player)
        {
            bool buyingSugar = true;
            int amountOfSugar;
            while (buyingSugar)
            {
                Console.Clear();
                inventory.printDisplay(bank, currentWeather, lemon, sugar, ice, cups, day, player);
                Console.WriteLine();
                Console.WriteLine("Each Sugar Cube costs $0.05. Enter '999' to move on.");
                int.TryParse(Console.ReadLine(), out amountOfSugar);
                if ((bank.money - (pricePerSugar * amountOfSugar) > 0))
                {
                    storeSugar = storeSugar + amountOfSugar;
                    bank.money = bank.money - (pricePerSugar * amountOfSugar);
                    sugar.sugar = sugar.sugar + storeSugar;
                } else if( amountOfSugar == 999)
                {
                    storeSugar = 0;
                    buyingSugar = false;
                }
                else
                {
                    Console.WriteLine("You don't have enough money");
                    Console.ReadLine();
                }               
            }
            return storeSugar;
        }
    }
}
