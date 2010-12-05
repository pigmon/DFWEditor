using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DFWEditor_Alpha
{
    public class Map
    {
        private String name;
        private int width, height;

        public Map(String _name, int _width, int _height)
        {
            name = _name;
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

        public Size getSize()
        {
            return new Size(width, height);
        }
    }
}
