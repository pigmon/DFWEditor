using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DFWEditor_Alpha
{
    public class MapGrid
    {
        public int x, y;
        public int deity;
        public String eventContainer;
        public bool bank;
        public EState eState;
        public List<Point> neighbours;
        public bool bHospital;
        public bool bJail;
        public bool bPlayerStart;

        public MapGrid()
        {
            x = y = -1;
            deity = -1;
            eventContainer = "null";
            bank = bHospital = bJail = bPlayerStart = false;
            neighbours = new List<Point>();
        }

        public MapGrid(int _x, int _y)
        {
            x = _x;
            y = _y;
            deity = -1;
            eventContainer = "null";
            bank = bHospital = bJail = bPlayerStart = false;
            neighbours = new List<Point>();
        }

        ~MapGrid()
        {
            if (neighbours != null)
            {
                neighbours.Clear();
                neighbours = null;
            }
        }

        public void SetEstate(EState _eState)
        {
            eState = _eState;
        }

        public void AddNeighbour(Point loc)
        {
            neighbours.Add(loc);
        }
    }
}
