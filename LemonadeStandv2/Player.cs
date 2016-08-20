using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandv2
{
    class Player
    {
        public string name;
        public double lemonadePrice;
        
        public Player(string Name)
        {
            this.name = Name;

        }
        public void PrepLemonade(Bank bank, Weather currentWeather, Weather tomorrowsWeather, Inventory inventory, Day day, Lemon lemon, Sugar sugar, Ice ice, Cups cups)
        {
            Store store = new Store();
            store.BuyLemons(bank, currentWeather, tomorrowsWeather, inventory, day, lemon, sugar, ice, cups);
            store.BuyCups(bank, currentWeather, tomorrowsWeather, inventory, day, cups, lemon, ice, sugar);
            store.BuyIce(bank, currentWeather, tomorrowsWeather, inventory, day, ice, lemon, sugar, cups);
            store.BuySugar(bank, currentWeather, tomorrowsWeather, inventory, day, sugar, lemon,ice, cups);
            Console.Clear();
            inventory.printDisplay(bank, currentWeather, tomorrowsWeather, lemon, sugar, ice, cups, day);
            currentWeather.ChangeWeather();
            bank.totalMoneySpent = bank.totalMoneySpent + (store.storeLemons * store.pricePerLemon) + (store.storeSugar * store.pricePerSugar) + (store.storeIce * store.pricePerIce) + (store.storeCups * store.pricePerCup);
            Console.WriteLine("At what would you like to sell your Lemonade at?");
            double.TryParse(Console.ReadLine(), out lemonadePrice);
        }
        public void SetRecipe(Recipe recipe)
        {
            Console.WriteLine("How much lemons would you like to use per pitcher?");
            int.TryParse(Console.ReadLine(), out recipe.lemonRecipe);
            Console.WriteLine("How much sugar would you like to use per pitcher?");
            int.TryParse(Console.ReadLine(), out recipe.sugarRecipe);
            Console.WriteLine("How much ice would you like to use per cup?");
            int.TryParse(Console.ReadLine(), out recipe.iceRecipe);
        }
    }
}
