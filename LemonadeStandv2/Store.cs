using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandv2
{
    class Store
    {
        public int storeLemons = 0;
        public int storeIce = 0;
        public int storeCups = 0;
        public int storeSugar = 0;
        public double pricePerLemon = .10;
        public double pricePerIce = .008;
        public double pricePerCup = 0.0375;
        public double pricePerSugar = .10;

        public Store()
        {

        }
        public int BuyLemons(Bank bank, Weather currentWeather, Weather tomorrowsWeather, Inventory inventory, Day day, Lemon lemon, Sugar sugar, Ice ice, Cups cups, Player player)
        {
            bool buyingLemons = true;
            int amountOfLemons;
            while (buyingLemons)
            {
                Console.Clear();
                inventory.printDisplay(bank, currentWeather, tomorrowsWeather, lemon, sugar, ice, cups, day, player);
                Console.WriteLine();
                Console.WriteLine("Would you like to buy 10($1), 20($2) or 40($4) Lemons? Enter to move on.");
                int.TryParse(Console.ReadLine(), out amountOfLemons);
                switch (amountOfLemons)
                {
                    case 10:
                        if ((bank.money - (pricePerLemon * amountOfLemons) > 0))
                        {
                            storeLemons = storeLemons + amountOfLemons;
                            bank.money = bank.money - (pricePerLemon * amountOfLemons);
                            lemon.lemon = lemon.lemon + storeLemons;
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough money");
                            Console.ReadLine();
                        }
                        break;
                    case 20:
                        if ((bank.money - (pricePerLemon * amountOfLemons) > 0))
                        {
                            storeLemons = storeLemons + amountOfLemons;
                            bank.money = bank.money - (pricePerLemon * amountOfLemons);
                            lemon.lemon = lemon.lemon + storeLemons;
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough money");
                            Console.ReadLine();
                        }
                        break;
                    case 40:
                        if ((bank.money - (pricePerLemon * amountOfLemons) > 0))
                        {
                            storeLemons = storeLemons + amountOfLemons;
                            bank.money = bank.money - (pricePerLemon * amountOfLemons);
                            lemon.lemon = lemon.lemon + storeLemons;
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough money");
                            Console.ReadLine();
                        }
                        break;
                    default:
                        buyingLemons = false;
                        break;
                }
            }
            return storeLemons;
        }
        public int BuyCups(Bank bank, Weather currentWeather, Weather tomorrowsWeather, Inventory inventory, Day day, Cups cups, Lemon lemon, Ice ice, Sugar sugar, Player player)
        {
            bool buyingCups = true;
            int amountOfCups;
            while (buyingCups)
            {
                Console.Clear();
                inventory.printDisplay(bank, currentWeather, tomorrowsWeather, lemon, sugar, ice, cups, day, player);
                Console.WriteLine();
                Console.WriteLine("Would you like to buy 20($0.75), 40($1.50) or 100($3.75) Cups? Enter to move on");
                int.TryParse(Console.ReadLine(), out amountOfCups);
                switch (amountOfCups)
                {
                    case 20:
                        if ((bank.money - (pricePerCup * amountOfCups) > 0))
                        {
                            storeCups = storeCups + amountOfCups;
                            bank.money = bank.money - (pricePerLemon * amountOfCups);
                            cups.cups = cups.cups + storeCups;
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough money");
                            Console.ReadLine();
                        }
                        break;
                    case 40:
                        if ((bank.money - (pricePerCup * amountOfCups) > 0))
                        {
                            storeCups = storeCups + amountOfCups;
                            bank.money = bank.money - (pricePerLemon * amountOfCups);
                            cups.cups = cups.cups + storeCups;
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough money");
                            Console.ReadLine();
                        }
                        break;
                    case 100:
                        if ((bank.money - (pricePerCup * amountOfCups) > 0))
                        {
                            storeCups = storeCups + amountOfCups;
                            bank.money = bank.money - (pricePerLemon * amountOfCups);
                            cups.cups = cups.cups + storeCups;
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough money");
                            Console.ReadLine();
                        }
                        break;
                    default:
                        buyingCups = false;
                        break;
                }
            }
            return storeCups;
        }
        public int BuyIce(Bank bank, Weather currentWeather, Weather tomorrowsWeather, Inventory inventory, Day day, Ice ice, Lemon lemon, Sugar sugar, Cups cups, Player player)
        {
            bool buyingIce = true;
            int amountOfIce;
            while (buyingIce)
            {
                Console.Clear();
                inventory.printDisplay(bank, currentWeather, tomorrowsWeather, lemon, sugar, ice, cups, day, player);
                Console.WriteLine();
                Console.WriteLine("Would you like to buy 100($0.80), 200($1.60) or 500($4) Ice? Enter to move on.");
                int.TryParse(Console.ReadLine(), out amountOfIce);
                switch (amountOfIce)
                {
                    case 100:
                        if ((bank.money - (pricePerIce * amountOfIce) > 0))
                        {
                            storeIce = storeIce + amountOfIce;
                            bank.money = bank.money - (pricePerIce * amountOfIce);
                            ice.ice = ice.ice + storeIce;
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough money");
                            Console.ReadLine();
                        }
                        break;

                    case 200:
                        if ((bank.money - (pricePerIce * amountOfIce) > 0))
                        {
                            storeIce = storeIce + amountOfIce;
                            bank.money = bank.money - (pricePerIce * amountOfIce);
                            ice.ice = ice.ice + storeIce;
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough money");
                            Console.ReadLine();
                        }
                        break;
                    case 500:
                        if ((bank.money - (pricePerIce * amountOfIce) > 0))
                        {
                            storeIce = storeIce + amountOfIce;
                            bank.money = bank.money - (pricePerIce * amountOfIce);
                            ice.ice = ice.ice + storeIce;
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough money");
                            Console.ReadLine();
                        }
                        break;
                    default:
                        buyingIce = false;
                        break;
                }
            }
            return storeIce;
        }
        public int BuySugar(Bank bank, Weather currentWeather, Weather tomorrowsWeather, Inventory inventory, Day day, Sugar sugar, Lemon lemon, Ice ice, Cups cups, Player player)
        {
            bool buyingSugar = true;
            int amountOfSugar;
            while (buyingSugar)
            {
                Console.Clear();
                inventory.printDisplay(bank, currentWeather, tomorrowsWeather, lemon, sugar, ice, cups, day, player);
                Console.WriteLine();
                Console.WriteLine("Would you like to buy 10($1), 20($2) or 40($4) Sugar? Enter to move on.");
                int.TryParse(Console.ReadLine(), out amountOfSugar);
                switch (amountOfSugar)
                {
                    case 10:
                        if ((bank.money - (pricePerSugar * amountOfSugar) > 0))
                        {
                            storeSugar = storeSugar + amountOfSugar;
                            bank.money = bank.money - (pricePerSugar * amountOfSugar);
                            sugar.sugar = sugar.sugar + storeSugar;
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough money");
                            Console.ReadLine();
                        }
                        break;
                    case 20:
                        if ((bank.money - (pricePerSugar * amountOfSugar) > 0))
                        {
                            storeSugar = storeSugar + amountOfSugar;
                            bank.money = bank.money - (pricePerSugar * amountOfSugar);
                            sugar.sugar = sugar.sugar + storeSugar;
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough money");
                            Console.ReadLine();
                        }
                        break;
                    case 40:
                        if ((bank.money - (pricePerSugar * amountOfSugar) > 0))
                        {
                            storeSugar = storeSugar + amountOfSugar;
                            bank.money = bank.money - (pricePerSugar * amountOfSugar);
                            sugar.sugar = sugar.sugar + storeSugar;
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough money");
                            Console.ReadLine();
                        }
                        break;
                    default:
                        buyingSugar = false;
                        break;
                }
            }
            return storeSugar;
        }
    }
}
