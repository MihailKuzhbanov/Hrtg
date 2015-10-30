using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hrtg
{
    class Inventory
    {
        string SlotOne, SlotTwo, SlotThree, SlotFour;
        int SpaceOne, SpaceTwo, SpaceThree, SpaceFour;
        public void AddInventory(Something Some)
        {
            if (SpaceOne == 0)
            {
                SlotOne = Some.SmthName;
                SpaceOne = 1;
            }
            if (SpaceTwo == 0)
            {
                SlotTwo = Some.SmthName;
                SpaceTwo = 1;
            }
            if (SpaceThree == 0)
            {
                SlotThree = Some.SmthName;
                SpaceThree = 1;
            }
            if (SpaceFour == 0)
            {
                SlotFour = Some.SmthName;
                SpaceFour = 1;
            }
        }
        public void DelInventory(int Choose)
        {
            if (Choose == 1)
            {
                SlotOne = "";
                SpaceOne = 0;
            }
            if (Choose == 2)
            {
                SlotTwo = "";
                SpaceTwo = 0;
            }
            if (Choose == 3)
            {
                SlotThree = "";
                SpaceThree = 0;
            }
            if (Choose == 4)
            {
                SlotFour = "";
                SpaceFour = 0;
            }
        }
        public void ClrInventory(Something Some)
        {
                SlotOne = "";
                SpaceOne = 0;
                SlotTwo = "";
                SpaceTwo = 0;
                SlotThree = "";
                SpaceThree = 0;
                SlotFour = "";
                SpaceFour = 0;
        }
    }
}
