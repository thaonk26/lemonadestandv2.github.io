using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandv2
{
    class Game
    {
        Player player1;
        //Player player2;
        Day day = new Day();
        Recipe recipe = new Recipe();
        Ice ice = new Ice();
        Lemon lemon = new Lemon();
        Sugar sugar = new Sugar();
        Cups cups = new Cups();
        Bank bank = new Bank();
        Customer customer = new Customer();
        Weather weather = new Weather();
        Weather tomorrowsWeather;
        Pitcher pitcher = new Pitcher();
        Inventory inventory = new Inventory();
        Store store = new Store();
        public List<int> customerGenerate = new List<int>();
       
        
        public Game()
        {
            Console.WriteLine("What would you liked to be called?");
            player1 = new Player(Console.ReadLine());
        }
        public void RunGame(Game game)
        {
            Console.WriteLine("How many days would you like to play Lemonadestand for? (Minimum 7 days)");
            int.TryParse(Console.ReadLine(), out day.setDay);
            for (int i = 0; i < day.setDay; i++)
            {
                day.currentDay = i + 1;
                tomorrowsWeather = new Weather();
                tomorrowsWeather.SetWeather();
                tomorrowsWeather.SetTemperature();
                customer.SpawnCustomer(game);
                weather.GetCurrentWeather();
                player1.PrepLemonade(bank, weather, tomorrowsWeather, inventory, day, lemon, sugar, ice, cups);
                player1.SetRecipe(recipe);
                day.RunDay(pitcher, recipe, ice, lemon, sugar, cups, bank, player1, customer, day, inventory, weather, game);
                Console.ReadLine();
                weather = tomorrowsWeather;
            }
            bank.TotalSalesResults(inventory, player1, day, ice, lemon, sugar, cups, store);
        }
    }
}
