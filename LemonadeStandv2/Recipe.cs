using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandv2
{
    class Recipe
    {
        public int lemonRecipe;
        public int sugarRecipe;
        public int iceRecipe;
        public Recipe()
        {

        }
        public void SetRecipe()
        {
            Console.WriteLine("How much lemons would you like to use per pitcher?");
            int.TryParse(Console.ReadLine(), out lemonRecipe);
            Console.WriteLine("How much sugar would you like to use per pitcher?");
            int.TryParse(Console.ReadLine(), out sugarRecipe);
            Console.WriteLine("How much ice would you like to use per cup?");
            int.TryParse(Console.ReadLine(), out iceRecipe);
        }
    }
}
