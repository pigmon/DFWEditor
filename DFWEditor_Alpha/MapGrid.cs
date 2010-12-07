using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DFWEditor_Alpha
{
    public class Estate
    {
        public int x;
        public int y;
        public String section;
        public int basePrice;
        public int level;
        public int ownderID;

        public Estate()
        {
            x = y = ownderID = -1;
            section = "";
            level = 0;
            basePrice = 200000;
        }
    }

    public class MapGrid
    {
        public int x, y;
        public int deity;
        public String eventContainer;
        public bool bank;
        public Estate estate;

        public MapGrid()
        {
            x = y = -1;
            deity = -1;
            eventContainer = "";
            bank = false;
            estate = new Estate();
        }

        public MapGrid(int _x, int _y)
        {
            x = _x;
            y = _y;
            deity = -1;
            eventContainer = "";
            bank = false;
            estate = new Estate();
        }
    }
}
