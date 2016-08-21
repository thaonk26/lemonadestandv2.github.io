using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandv2
{
    class Pitcher
    {
        public double pitcher;
        public Pitcher()
        {

        }
        public void pourPitcher(Recipe recipe, Ice ice, Lemon lemon, Sugar sugar, Cups cups, Bank bank, Player player, Day day, Game game)
        {
            if(pitcher > 0 && recipe.iceRecipe > 0)
            {
                pitcher--;
                ice.ice = ice.ice - recipe.iceRecipe;
                bank.money = bank.money + player.lemonadePrice;
                bank.totalSales = bank.totalSales + player.lemonadePrice;
                Console.WriteLine("Customer {0} bought a cup", day.customerCount);

            }
            else
            {
                if(lemon.lemon - recipe.lemonRecipe > 0 && sugar.sugar - recipe.sugarRecipe > 0 && cups.cups - 12 > 0)
                {
                    makePitcher(recipe, ice, lemon, sugar, cups, bank, player);
                } else
                {
                    Console.WriteLine("SOLD OUT!!");
                    day.customerBuy = false;
                }
            }

        }
        public void makePitcher(Recipe recipe, Ice ice, Lemon lemon, Sugar sugar, Cups cups, Bank bank, Player player)
        {
            if(lemon.lemon - recipe.lemonRecipe > 0 && sugar.sugar - recipe.sugarRecipe > 0 && cups.cups - 12 > 0)
            {
                pitcher = 12;
                lemon.lemon = lemon.lemon - recipe.lemonRecipe;
                sugar.sugar = sugar.sugar - recipe.sugarRecipe;
                cups.cups = cups.cups - 12;
            }
            else
            {
                pitcher = 0;
            }
        }
    }
}
