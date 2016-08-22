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
        public void PrepLemonade(Bank bank, Weather currentWeather, Inventory inventory, Day day, Lemon lemon, Sugar sugar, Ice ice, Cups cups, Player player)
        {
            Store store = new Store();
            store.BuyLemons(bank, currentWeather, inventory, day, lemon, sugar, ice, cups, player);
            store.BuyCups(bank, currentWeather, inventory, day, cups, lemon, ice, sugar, player);
            store.BuyIce(bank, currentWeather,   inventory, day, ice, lemon, sugar, cups, player);
            store.BuySugar(bank, currentWeather,   inventory, day, sugar, lemon,ice, cups, player);
            Console.Clear();
            inventory.printDisplay(bank, currentWeather, lemon, sugar, ice, cups, day, player);
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
