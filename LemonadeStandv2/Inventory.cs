using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandv2
{
    class Inventory
    {
        public double liquidatedInventory;
        public Inventory()
        {

        }
        public void printDisplay(Bank bank, Weather weather, Lemon lemon, Sugar sugar, Ice ice, Cups cups, Day day, Player player)
        {
            Console.Clear();
            Console.WriteLine("         ******************************************************");
            Console.WriteLine("                           {0}'s Lemonade Stand                  ", player.name);
            Console.WriteLine("         ${0:000.00}     Today: {1} {2}*F   Tomorrow: {3} {4}*F",  bank.money, weather.currentWeather, weather.currentTemperature, weather.tomorrowsWeather, weather.tomorrowsTemperature);
            Console.WriteLine("         {0} Lemons   {1} Sugar   {2} Ice   {3} Cups  Day {4} of {5}",  lemon.lemon, sugar.sugar, ice.ice, cups.cups, day.currentDay, day.setDay);
            Console.WriteLine("         ******************************************************");
        }
    }
}
