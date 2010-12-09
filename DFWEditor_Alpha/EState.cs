using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DFWEditor_Alpha
{
    public class EState
    {
        public String section;
        public int basePrice;
        public int x, y;

        public EState(int _x, int _y)
        {
            section = "null";
            basePrice = 0;
            x = _x;
            y = _y;
        }

        public EState(int _x, int _y, String _section, int _basePrice)
        {
            section = _section;
            basePrice = _basePrice;
            x = _x;
            y = _y;
        }
    }
}
