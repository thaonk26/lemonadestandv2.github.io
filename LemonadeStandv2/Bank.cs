using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandv2
{
    class Bank
    {
        public double money = 20.00;
        public double totalSales;
        public double totalMoneySpent;
        
        public Bank()
        {

        }
        public void TotalSalesResults(Inventory inventory, Player player1, Day day, Ice ice, Lemon lemon, Sugar sugar, Cups cups, Store store)
        {
            Console.Clear();
            Console.WriteLine("*************************************************************");
            Console.WriteLine("Congrats {0}!!! You finished your {1} Days of Lemonade Stand!", player1.name, day.setDay);
            Console.WriteLine("Your total sales for {1} Days are ${0}", totalSales, day.setDay);
            Console.WriteLine("Your total money spent during the {0} Days are ${1}", day.setDay, totalMoneySpent);
            inventory.liquidatedInventory = ((ice.ice * ice.pricePerIceCube) + (lemon.lemon * lemon.pricePerLemon) + (sugar.sugar * sugar.pricePerSugarCube) + (cups.cups * cups.pricePerCup));
            Console.WriteLine("Your liquidated inventory value is ${0}", inventory.liquidatedInventory);
            double profits = totalSales - totalMoneySpent - inventory.liquidatedInventory;
            if (profits > 0)
            {
                Console.WriteLine("You have made a profit of ${0:00.00}", profits);
            }
            else
            {
                Console.WriteLine("You didn't make a profit and lost ${0:00.00}", profits);
            }
            Console.WriteLine("**************************************************************");
            Console.ReadLine();
        }
    }
}
