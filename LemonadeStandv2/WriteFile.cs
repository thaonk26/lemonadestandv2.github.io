using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LemonadeStandv2
{
    class WriteFile
    {
        public WriteFile(List<string> SavedInventory)
        {
            TextWriter saveGame = new StreamWriter(".\\GameSave.txt");
            saveGame.WriteLine(SavedInventory);
            saveGame.Close();
            Environment.Exit(0);
        }
    }
}
