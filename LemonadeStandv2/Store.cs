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
        public int storeIce;
        public int storeCups;
        public int storeSugar;

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
                if (amountOfLemons == 999)
                {
                    storeLemons = 0;
                    buyingLemons = false;
                }else if ((bank.money - (lemon.pricePerLemon * amountOfLemons) > 0))
                {
                    storeLemons = storeLemons + amountOfLemons;
                    bank.totalMoneySpent = bank.totalMoneySpent + (lemon.pricePerLemon * amountOfLemons);
                    bank.money = bank.money - (lemon.pricePerLemon * amountOfLemons);
                    lemon.lemon = lemon.lemon + storeLemons;
                
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
                storeCups = 0;
                int.TryParse(Console.ReadLine(), out amountOfCups);
                if (amountOfCups == 999)
                {
                    storeCups = 0;
                    buyingCups = false;
                }else if ((bank.money - (cups.pricePerCup * amountOfCups) > 0))
                {
                    storeCups = storeCups + amountOfCups;
                    bank.totalMoneySpent = bank.totalMoneySpent + (cups.pricePerCup * amountOfCups);
                    bank.money = bank.money - (cups.pricePerCup * amountOfCups);
                    cups.cups = cups.cups + storeCups;
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
                storeIce = 0;
                int.TryParse(Console.ReadLine(), out amountOfIce);
                if (amountOfIce == 999)
                {
                    storeIce = 0;
                    buyingIce = false;
                }else if ((bank.money - (ice.pricePerIceCube * amountOfIce) > 0))
                {
                    storeIce = storeIce + amountOfIce;
                    bank.totalMoneySpent = bank.totalMoneySpent + (ice.pricePerIceCube * amountOfIce);
                    bank.money = bank.money - (ice.pricePerIceCube * amountOfIce);
                    ice.ice = ice.ice + storeIce;
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
                storeSugar = 0;
                int.TryParse(Console.ReadLine(), out amountOfSugar);
                if (amountOfSugar == 999)
                {
                    storeSugar = 0;
                    buyingSugar = false;
                }
                else if ((bank.money - (sugar.pricePerSugarCube * amountOfSugar) > 0))
                {
                    storeSugar = storeSugar + amountOfSugar;
                    bank.totalMoneySpent = bank.totalMoneySpent + (sugar.pricePerSugarCube * amountOfSugar);
                    bank.money = bank.money - (sugar.pricePerSugarCube * amountOfSugar);
                    sugar.sugar = sugar.sugar + storeSugar;
                } else{
                    Console.WriteLine("You don't have enough money");
                    Console.ReadLine();
                }               
            }
            return storeSugar;
        }
    }
}
