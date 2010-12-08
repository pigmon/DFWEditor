using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DFWEditor_Alpha
{
    public class MapGrid
    {
        public int x, y;
        public int deity;
        public String eventContainer;
        public bool bank;
        public EState eState;

        public MapGrid()
        {
            x = y = -1;
            deity = -1;
            eventContainer = "";
            bank = false;
        }

        public MapGrid(int _x, int _y)
        {
            x = _x;
            y = _y;
            deity = -1;
            eventContainer = "";
            bank = false;
        }

        public void setEstate(EState _eState)
        {
            eState = _eState;
        }
    }
}
