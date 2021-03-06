﻿using System;
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
        public List<Point> playerStarts;

        public MapInfo()
        {
            jailExit = new Point(-1, -1);
            hospitalExit = new Point(-1, -1);
            playerStarts = new List<Point>();
        }
    }
    public class Map
    {
        public String name;
        public int width, height;
        public String textureName;
        public List<Image> imgList;
        public int[,] tiles;
        public int[,] gamePlayes;
        public List<EState> eStates;

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
            gamePlayes = new int[width, height];

            textureName = _textureName;
            Image texture = Image.FromFile(_textureName);
            imgList = new List<Image>();
            ImageManager.Cut(texture, G.tileSize, G.tileSize, "png", imgList);

            // Map info
            info = new MapInfo();

            // Grids
            grids = new List<MapGrid>();
            eStates = new List<EState>();
        }

        public String Check()
        {
            Save();
            int warningCount = 0;
            int errorCount = 0;
            String ret = "Build resulds: \n";
            // Check the player starts
            if (info.playerStarts.Count() != 4)
            {
                ret += "Warning: Player Start数量为" + info.playerStarts.Count() + ", 应为4。\n";
                warningCount++;
            }
            // Hospital
            if (info.hospitalExit.X == -1 || info.hospitalExit.Y == -1)
            {
                ret += "Warning: 没有设置医院出口。\n";
                warningCount++;
            }
            // Jail
            if (info.jailExit.X == -1 || info.jailExit.Y == -1)
            {
                ret += "Warning: 没有设置监狱出口。\n";
                warningCount++;
            }

            if (grids == null || grids.Count() == 0)
            {
                ret += "Error: 没有路径！\n";
                errorCount++;
            }
            for (int i = 0; i < grids.Count(); i++)
            {
                if (grids[i].neighbours.Count() == 0)
                {
                    ret += "Error: Grid (" + grids[i].x + ", " + grids[i].y + ")与其他任何Grid没有相邻。\n";
                    errorCount++;
                }

                int esCount = 0;
                List<Point> _nbs = new List<Point>();
                if (grids[i].x > 0)
                    _nbs.Add(new Point(grids[i].x - 1, grids[i].y));
                if (grids[i].x < width - 1)
                    _nbs.Add(new Point(grids[i].x + 1, grids[i].y));
                if (grids[i].y > 0)
                    _nbs.Add(new Point(grids[i].x, grids[i].y - 1));
                if (grids[i].y < height - 1)
                    _nbs.Add(new Point(grids[i].x, grids[i].y + 1));

                for (int j = 0; j < _nbs.Count(); j++)
                {
                    if (gamePlayes[_nbs[j].X, _nbs[j].Y] == 3)
                    {
                        esCount++;
                    }
                }

                if (esCount > 1)
                {
                    ret += "Error: Grid (" + grids[i].x + ", " + grids[i].y + ")与超过一处地产相邻。\n";
                    errorCount++;
                }

                _nbs.Clear();
                _nbs = null;
            }

            ret += "\n\n";
            ret += "Warnings: " + warningCount + "\n";
            ret += "Errors: " + errorCount + "\n";
            
            return ret;
        }

        public EState FindEState(int x, int y)
        {
            for (int i = 0; i < eStates.Count(); i++)
            {
                if (eStates[i].x == x && eStates[i].y == y)
                    return eStates[i];
            }

            return null;
        }

        public void CheckGrids()
        {
            info.playerStarts.Clear();
            for (int i = 0; i < grids.Count(); i++)
            {
                if (grids[i].bHospital)
                    info.hospitalExit = new Point(grids[i].x, grids[i].y);
                if (grids[i].bJail)
                    info.jailExit = new Point(grids[i].x, grids[i].y);
                if (grids[i].bPlayerStart)
                    info.playerStarts.Add(new Point(grids[i].x, grids[i].y));

                List<Point> _nbs = new List<Point>();
                if (grids[i].x > 0)
                    _nbs.Add(new Point(grids[i].x - 1, grids[i].y));
                if (grids[i].x < width - 1)
                    _nbs.Add(new Point(grids[i].x + 1, grids[i].y));
                if (grids[i].y > 0)
                    _nbs.Add(new Point(grids[i].x, grids[i].y - 1));
                if (grids[i].y < height - 1)
                    _nbs.Add(new Point(grids[i].x, grids[i].y + 1));

                grids[i].neighbours.Clear();
                for (int j = 0; j < _nbs.Count(); j++)
                {
                    if (gamePlayes[_nbs[j].X, _nbs[j].Y] == 2)
                    {
                        grids[i].neighbours.Add(_nbs[j]);
                    }
                }


                for (int j = 0; j < _nbs.Count(); j++)
                {
                    if (gamePlayes[_nbs[j].X, _nbs[j].Y] == 3)
                    {
                        EState es = FindEState(_nbs[j].X, _nbs[j].Y);
                        if (es != null)
                        {
                            grids[i].eState = es;
                            break;
                        }
                    }

                    grids[i].eState = null;
                }

                _nbs.Clear();
                _nbs = null;
            }
        }

        public void UpdateGrids()
        {
            for (int i = 0; i < grids.Count(); i++)
            {
                Point loc = new Point(grids[i].x, grids[i].y);
                if (info.hospitalExit != loc)
                    grids[i].bHospital = false;
                else
                {
                    if (info.hospitalExit == loc && !grids[i].bHospital)
                        info.hospitalExit = new Point(-1, -1);
                }
                if (info.jailExit != loc)
                    grids[i].bJail = false;
                else
                {
                    if (info.jailExit == loc && !grids[i].bJail)
                        info.jailExit = new Point(-1, -1);
                }
            }
        }

        public void Save()
        {
            CheckGrids();
            if (!Directory.Exists(G.SavePath))
                Directory.CreateDirectory(G.SavePath);
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

                sw.WriteLine("//Grids");
                int gCount = grids.Count();
                sw.WriteLine(gCount);
                for (int i = 0; i < gCount; i++)
                {
                    //sw.WriteLine("//--Grid" + i);
                    sw.WriteLine(grids[i].x + "," + grids[i].y + "," + grids[i].eventContainer + "," + grids[i].deity + "," + grids[i].bank + "," + grids[i].bHospital + "," + grids[i].bJail + "," + grids[i].bPlayerStart);
                    //sw.WriteLine("//----EState");
                    if (grids[i].eState != null)
                        sw.WriteLine(grids[i].eState.x + "," + grids[i].eState.y + "," + grids[i].eState.section + "," + grids[i].eState.basePrice);
                    else
                        sw.WriteLine("null");
                    int nbCount = grids[i].neighbours.Count();
                    //sw.WriteLine("//----neighbours");
                    sw.Write(nbCount + ",");
                    if (nbCount > 0)
                    {
                        for (int j = 0; j < nbCount; j++)
                        {
                            sw.Write(grids[i].neighbours[j].X + "," + grids[i].neighbours[j].Y + ",");
                        }
                        sw.WriteLine();
                    }
                    else
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
            JailExit.SetAttribute("x", info.jailExit.Y.ToString());
            JailExit.SetAttribute("y", info.jailExit.X.ToString());
            MapInfo.AppendChild(JailExit);
            // -->Hospital exit
            XmlElement HospitalExit = xmldoc.CreateElement("HospitalExit");
            HospitalExit.SetAttribute("x", info.hospitalExit.Y.ToString());
            HospitalExit.SetAttribute("y", info.hospitalExit.X.ToString());
            MapInfo.AppendChild(HospitalExit);
            // -->Player starts
            XmlElement PlayerStarts = xmldoc.CreateElement("PlayerStarts");
            for (int i = 0; i < info.playerStarts.Count(); i++)
            {
                XmlElement Coord2D = xmldoc.CreateElement("Coord2D");
                Coord2D.SetAttribute("x", info.playerStarts[i].Y.ToString());
                Coord2D.SetAttribute("y", info.playerStarts[i].X.ToString());
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
                Grid.SetAttribute("x", grids[i].y.ToString());
                Grid.SetAttribute("y", grids[i].x.ToString());
                XmlElement Neighbours = xmldoc.CreateElement("Neighbours");
                if (grids[i].neighbours != null && grids[i].neighbours.Count() > 0)
                {
                    for (int j = 0; j < grids[i].neighbours.Count(); j++)
                    {
                        XmlElement nbCoord2D = xmldoc.CreateElement("Coord2D");
                        nbCoord2D.SetAttribute("x", grids[i].neighbours[j].Y.ToString());
                        nbCoord2D.SetAttribute("y", grids[i].neighbours[j].X.ToString());
                        Neighbours.AppendChild(nbCoord2D);
                    }
                }
                Grid.AppendChild(Neighbours);
                XmlElement GameplayObjects = xmldoc.CreateElement("GameplayObjects");
                if (grids[i].bank)
                {
                    XmlElement Bank = xmldoc.CreateElement("Bank");
                    GameplayObjects.AppendChild(Bank);
                }
                if (grids[i].eventContainer != "null")
                {
                    XmlElement EventContainer = xmldoc.CreateElement("EventContainer");
                    EventContainer.SetAttribute("type", grids[i].eventContainer);
                    GameplayObjects.AppendChild(EventContainer);
                }
                if (grids[i].deity >= 0)
                {
                    XmlElement Deity = xmldoc.CreateElement("Deity");
                    Deity.SetAttribute("type", grids[i].deity.ToString());
                    GameplayObjects.AppendChild(Deity);
                }
                if (grids[i].eState != null)
                {
                    XmlElement ElemEState = xmldoc.CreateElement("Estate");
                    ElemEState.SetAttribute("x", grids[i].eState.y.ToString());
                    ElemEState.SetAttribute("y", grids[i].eState.x.ToString());
                    ElemEState.SetAttribute("Section", grids[i].eState.section);
                    ElemEState.SetAttribute("BasePrice", grids[i].eState.basePrice.ToString());
                    ElemEState.SetAttribute("Level", "0");
                    ElemEState.SetAttribute("OwnerID", "-1");
                    GameplayObjects.AppendChild(ElemEState);
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

                
                // Grids
                sr.ReadLine();
                int gCount = Int32.Parse(sr.ReadLine());
                info.playerStarts.Clear();
                for (int i = 0; i < gCount; i++)
                {
                    MapGrid grid = new MapGrid();
                    String baseInfoLine = sr.ReadLine();
                    String[] baseNums = baseInfoLine.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                    grid.x = Int32.Parse(baseNums[0]);
                    grid.y = Int32.Parse(baseNums[1]);
                    grid.eventContainer = baseNums[2];
                    grid.deity = Int32.Parse(baseNums[3]);
                    grid.bank = Boolean.Parse(baseNums[4]);
                    grid.bHospital = Boolean.Parse(baseNums[5]);
                    if (grid.bHospital)
                        info.hospitalExit = new Point(grid.x, grid.y);
                    grid.bJail = Boolean.Parse(baseNums[6]);
                    if (grid.bJail)
                        info.jailExit = new Point(grid.x, grid.y);
                    grid.bPlayerStart = Boolean.Parse(baseNums[7]);
                    if (grid.bPlayerStart)
                        info.playerStarts.Add(new Point(grid.x, grid.y));

                    String esLine = sr.ReadLine();
                    if (esLine != "null")
                    {
                        String[] esNums = esLine.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                        int x = Int32.Parse(esNums[0]);
                        int y = Int32.Parse(esNums[1]);
                        String section = esNums[2];
                        int basePrice = Int32.Parse(esNums[3]);
                        grid.eState = new EState(x, y, section, basePrice);
                        gamePlayes[x, y] = 3;
                        eStates.Add(grid.eState);
                    }

                    String nbLine = sr.ReadLine();
                    String[] nbNums = nbLine.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                    int nbCount = Int32.Parse(nbNums[0]);
                    for (int j = 1; j < nbNums.Length - 1; j += 2)
                    {
                        int x = Int32.Parse(nbNums[j]);
                        int y = Int32.Parse(nbNums[j + 1]);
                        Point pt = new Point(x, y);
                        grid.neighbours.Add(pt);
                    }

                    grids.Add(grid);
                    gamePlayes[grid.x, grid.y] = 2;
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
