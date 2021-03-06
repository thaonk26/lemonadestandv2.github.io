﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandv2
{
    class Day
    {
        public int currentDay;
        public int setDay;
        public bool customerBuy = true;
        public int customerCount;
        public Day()
        {

        }
        public void RunDay(Pitcher pitcher, Recipe recipe, Ice ice, Lemon lemon, Sugar sugar, Cups cups, Bank bank, Player player1, Customer customer, Day day, Inventory inventory, Weather weather, Game game)
        {
            customerBuy = true;
            while (customerBuy)
            {
                for (int i = 0; i < game.customerGenerate.Count; i++)
                {
                    customerCount = i + 1;
                    if (customer.CustomerBuyChance(inventory, weather, recipe, player1) != false && player1.lemonadePrice <= 1.5 && player1.lemonadePrice > .05)
                    {
                        pitcher.pourPitcher(recipe, ice, lemon, sugar, cups, bank, player1, day, game);
                        //Console.WriteLine("Customer {0} bought a cup", i + 1);
                    }else
                    {
                        Console.WriteLine("Customer {0} walked away", i + 1);
                    }
                }
                customerBuy = false;
            }
            Console.Clear();
            Console.WriteLine("All you ice has melted");
            ice.liquidateIce = ice.liquidateIce + ice.ice;
            ice.ice = 0;
        }
    }
}
