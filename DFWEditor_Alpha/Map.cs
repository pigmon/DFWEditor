using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;

namespace DFWEditor_Alpha
{
    public class Map
    {
        public String name;
        public int width, height;
        public String textureName;
        public List<Image> imgList;
        public int[,] tiles;

        public Map()
        {

        }

        public Map(String _name, int _width, int _height, String _textureName)
        {
            Init(_name, _width, _height, _textureName);
        }

        ~Map()
        {
            Clean();
        }

        public void Init(String _name, int _width, int _height, String _textureName)
        {
            name = _name;
            width = _width;
            height = _height;

            tiles = new int[width, height];
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    tiles[i, j] = -1;
                }
            }

            textureName = _textureName;
            Image texture = Image.FromFile(_textureName);
            imgList = new List<Image>();
            ImageManager.Cut(texture, G.tileSize, G.tileSize, "png", imgList);
        }



        public void Save()
        {
            String fileName = G.SavePath + "\\" + name + ".map";
            SaveAs(fileName);
        }

        public void SaveAs(String fileName)
        {
            using (StreamWriter sw = File.CreateText(fileName))
            {
                sw.WriteLine(name);
                sw.WriteLine(width);
                sw.WriteLine(height);
                sw.WriteLine(textureName);
                for (int j = 0; j < tiles.GetLength(1); j++)
                {
                    for (int i = 0; i < tiles.GetLength(0); i++)
                    {
                        int value = tiles[i, j] + 1;
                        sw.Write(value + ",");
                    }

                    sw.WriteLine();
                }
            }
        }

        public void Load(String fileName)
        {
            using (StreamReader sr = File.OpenText(fileName))
            {
                String[] sep = { "," };

                String _name = sr.ReadLine(); // map name
                int _width = Int32.Parse(sr.ReadLine()); // mapWidth
                int _height = Int32.Parse(sr.ReadLine()); // mapHeight
                String _textureName = sr.ReadLine();

                Init(_name, _width, _height, _textureName);

                for (int j = 0; j < tiles.GetLength(1); j++)
                {
                    String line = sr.ReadLine();
                    String[] nums = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < tiles.GetLength(0); i++)
                    {
                        tiles[i, j] = Int32.Parse(nums[i]) - 1;
                    }
                }
            }
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
