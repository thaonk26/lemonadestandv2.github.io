using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LemonadeStandv2
{
    class Customer
    {
        public int setCustomer = 0;
        public Customer()
        {

        }
        public int SpawnCustomer(Game game)
        {
            game.customerGenerate.Clear();
            Random randomCustomer = new Random();
            int numberOfCustomer = randomCustomer.Next(50, 105);
            for (int i = 0; i < numberOfCustomer; i++)
            {
                game.customerGenerate.Add(i);
            }
            return setCustomer;
        }
        public bool CustomerBuyChance(Inventory inventory, Weather weather, Recipe recipe, Player player)
        {
            int buyChanceCounter = 1;
            Thread.Sleep((int)TimeSpan.FromSeconds(.225).TotalMilliseconds);
            Random random = new Random();
            if (weather.currentTemperature < 60 && player.lemonadePrice <= .20 && recipe.iceRecipe <= 4)
            {
                buyChanceCounter += 3;
                if (random.Next(1, buyChanceCounter) == 1) { return true; } else { return false; }
            }
            else if (weather.currentTemperature < 70 && player.lemonadePrice <= .25 && recipe.iceRecipe <= 6)
            {
                buyChanceCounter += 3;
                if (random.Next(1, buyChanceCounter) == 1) { return true; } else { return false; }
            }
            else if (weather.currentTemperature < 80 && player.lemonadePrice <= .30 && recipe.iceRecipe <= 8)
            {
                buyChanceCounter += 3;
                if (random.Next(1, buyChanceCounter) == 1) { return true; } else { return false; }
            }
            else if (weather.currentTemperature < 90 && player.lemonadePrice <= .40 && recipe.iceRecipe <= 10)
            {
                buyChanceCounter += 2;
                if (random.Next(1, buyChanceCounter) == 1) { return true; } else { return false; }
            }
            else if (weather.currentTemperature < 100 && player.lemonadePrice <= .50 && recipe.iceRecipe <= 10)
            {
                buyChanceCounter += 2;
                if (random.Next(1, buyChanceCounter) == 1) { return true; } else { return false; }
            }
            else {
                buyChanceCounter += 8;
                if (random.Next(1, buyChanceCounter) == 1) { return true; } else { return false; }
            }
        }
    }
}
