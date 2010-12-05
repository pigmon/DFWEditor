using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DFWEditor_Alpha
{
    public class Map
    {
        private int width, height;

        public Map(int _width, int _height)
        {
            width = _width;
            height = _height;
        }

        ~Map()
        {
            Clean();
        }

        public void Save()
        {

        }

        public void Clean()
        {

        }
    }
}
