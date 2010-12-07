using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Xml;

namespace DFWEditor_Alpha
{
    public class MapInfo
    {
        public Point jailExit;
        public Point hospitalExit;
        public Point[] playerStarts;

        public MapInfo()
        {
            jailExit = new Point(-1, -1);
            hospitalExit = new Point(-1, -1);
            playerStarts = new Point[4];
            for (int i = 0; i < 4; i++)
            {
                playerStarts[i] = new Point(-1, -1);
            }
        }
    }
    public class Map
    {
        public String name;
        public int width, height;
        public String textureName;
        public List<Image> imgList;
        public int[,] tiles;

        // Map info
        public MapInfo info;
        // Grids
        public List<MapGrid> grids;

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

            // Map info
            info = new MapInfo();

            // Grids
            grids = new List<MapGrid>();
        }



        public void Save()
        {
            String mapName = G.SavePath + "\\" + name + ".map";
            SaveAs(mapName);
            String xmlName = G.SavePath + "\\" + name + ".txt";
            SaveXml(xmlName);
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

        private void SaveXml(String fileName)
        {
            XmlDocument xmldoc = new XmlDocument();
            // title
            XmlElement GameLevel = xmldoc.CreateElement("GameLevel");
            GameLevel.SetAttribute("CurrentPlayer", "0");
            GameLevel.SetAttribute("CurrentRound", "0");
            xmldoc.AppendChild(GameLevel);

            ///////////////////////////////////////////////////////////////////////////////////
            // <Players>
            XmlElement Players = xmldoc.CreateElement("Players");
            for (int i = 0; i < 4; i++)
            {
                XmlElement Player = xmldoc.CreateElement("Player");
                Player.SetAttribute("Name", G.players[i]);
                Player.SetAttribute("Cash", "5000000");
                Player.SetAttribute("Deposit", "5000000");
                Player.SetAttribute("UseAI", "1");
                Player.SetAttribute("StopForThisRound", "0");
                Player.SetAttribute("Deity", "-1");
                Player.SetAttribute("DeityDayLeft", "0");

                XmlElement Coord2D1 = xmldoc.CreateElement("Coord2D");
                Coord2D1.SetAttribute("x", G.playerStartInitX[i].ToString());
                Coord2D1.SetAttribute("y", "18");
                Player.AppendChild(Coord2D1);
                XmlElement Coord2D2 = xmldoc.CreateElement("Coord2D");
                Coord2D2.SetAttribute("x", "0");
                Coord2D2.SetAttribute("y", "0");
                Player.AppendChild(Coord2D2);

                XmlElement PlayerSM = xmldoc.CreateElement("PlayerSM");
                PlayerSM.SetAttribute("SpecialStateLeft", "0");
                XmlElement StateMachine = xmldoc.CreateElement("StateMachine");
                StateMachine.SetAttribute("CurrentState", "0");
                StateMachine.SetAttribute("NextState", "0");
                StateMachine.SetAttribute("StateChanged", "0");
                PlayerSM.AppendChild(StateMachine);
                Player.AppendChild(PlayerSM);

                Players.AppendChild(Player);
            }
            GameLevel.AppendChild(Players);
            // </Players>
            ///////////////////////////////////////////////////////////////////////////////////

            ///////////////////////////////////////////////////////////////////////////////////
            // <map info>
            XmlElement MapInfo = xmldoc.CreateElement("MapInfo");
            // -->Jail exit
            XmlElement JailExit = xmldoc.CreateElement("JailExit");
            JailExit.SetAttribute("x", info.jailExit.X.ToString());
            JailExit.SetAttribute("y", info.jailExit.Y.ToString());
            MapInfo.AppendChild(JailExit);
            // -->Hospital exit
            XmlElement HospitalExit = xmldoc.CreateElement("HospitalExit");
            HospitalExit.SetAttribute("x", info.hospitalExit.X.ToString());
            HospitalExit.SetAttribute("y", info.hospitalExit.Y.ToString());
            MapInfo.AppendChild(HospitalExit);
            // -->Player starts
            XmlElement PlayerStarts = xmldoc.CreateElement("PlayerStarts");
            for (int i = 0; i < 4; i++)
            {
                XmlElement Coord2D = xmldoc.CreateElement("Coord2D");
                Coord2D.SetAttribute("x", info.playerStarts[i].X.ToString());
                Coord2D.SetAttribute("y", info.playerStarts[i].Y.ToString());
                PlayerStarts.AppendChild(Coord2D);
            }
            MapInfo.AppendChild(PlayerStarts);
            GameLevel.AppendChild(MapInfo);
            // </map info>
            ///////////////////////////////////////////////////////////////////////////////////

            ///////////////////////////////////////////////////////////////////////////////////
            // <Grids>
            XmlElement Grids = xmldoc.CreateElement("Grids");
            for (int i = 0; i < grids.Count(); i++)
            {
                XmlElement Grid = xmldoc.CreateElement("Grid");
                Grid.SetAttribute("x", grids[i].x.ToString());
                Grid.SetAttribute("y", grids[i].y.ToString());
                XmlElement Neighbours = xmldoc.CreateElement("Neighbours");
                Grid.AppendChild(Neighbours);
                XmlElement GameplayObjects = xmldoc.CreateElement("GameplayObjects");
                if (grids[i].bank)
                {
                    XmlElement Bank = xmldoc.CreateElement("Bank");
                    Grid.AppendChild(Bank);
                }
                if (grids[i].eventContainer.Length > 0)
                {
                    XmlElement EventContainer = xmldoc.CreateElement("EventContainer");
                    EventContainer.SetAttribute("type", grids[i].eventContainer);
                    Grid.AppendChild(EventContainer);
                }
                if (grids[i].deity >= 0)
                {
                    XmlElement Deity = xmldoc.CreateElement("Deity");
                    Deity.SetAttribute("type", grids[i].deity.ToString());
                    Grid.AppendChild(Deity);
                }
                Grid.AppendChild(GameplayObjects);
                Grids.AppendChild(Grid);
            }
            GameLevel.AppendChild(Grids);
            // </Grids>
            ///////////////////////////////////////////////////////////////////////////////////

            try
            {
                xmldoc.Save(fileName);
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.ToString());
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
