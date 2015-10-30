using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hrtg
{
    class Something
    {
        int SmthCount;
        public string SmthName, SmthDisc;
        public void Spawn(Player player1)
        {
            SmthCount = player1.lvl;
            Random rnd = new Random();
            int RndNmb = rnd.Next(SmthCount);
            switch (RndNmb)
            {
                case 0: SmthName = "Something0"; SmthDisc = "Text0";
                    break;
                case 1: SmthName = "Something1"; SmthDisc = "Text1";
                    break;
            }
        }
    
    }
}
