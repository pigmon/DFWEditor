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
        public BrushData[,] tiles;

        public Map(String _name, int _width, int _height)
        {
            name = _name;
            width = _width;
            height = _height;

            tiles = new BrushData[width, height];
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    tiles[i, j] = new BrushData();
                }
            }
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
