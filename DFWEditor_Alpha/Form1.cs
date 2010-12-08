using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DFWEditor_Alpha
{
    public partial class MainForm : Form
    {
        private Timer timer = new Timer();
        // Area brush
        private bool bMouseDownMainPanel;
        private int AreaStartI, AreaStartJ;
        private int AreaEndI, AreaEndJ;
        private int bakOperation;
        private Point mousePt;

        public MainForm()
        {
            InitializeComponent();
            G.TilesPerLineInTexture = (splitContainer1.Panel1.Size.Width - 200) / 42;
            G.PopZoneWidth = G.TilesPerLineInTexture * 42 + 20;
            bMouseDownMainPanel = false;
            AreaStartI = AreaStartJ = AreaEndI = AreaEndJ = -1;
            Dlg_OpenMap.InitialDirectory = G.SavePath;
            bakOperation = 1;

            // Timer
            timer.Tick += new EventHandler(TimerProcess);
            timer.Interval = 50;
            timer.Start();
        }

        ~MainForm()
        {
            timer.Stop();
            timer.Dispose();
            timer = null;
        }

        private void TimerProcess(Object myObject, EventArgs myEventArgs)
        {

            if (G.bRepaintTextures)
            {
                splitContainer1.Panel1.Refresh();
                G.bRepaintTextures = false;
            }

            if (G.bRepaintMainPanel)
            {
                MainPanel.Invalidate();
                G.bRepaintMainPanel = false;
            }

            if (G.bRepaintAll)
            {
                Refresh();
                G.bRepaintAll = false;
            }

            if (G.operation != 2)
                Bt_AddGrid.Checked = false;
            if (G.operation != 3)
                Bt_Land.Checked = false;
        }

        // Check for save when closing or opening
        private DialogResult CheckForSave(String reason)
        {
            return MessageBox.Show("要保存改动么？", reason, MessageBoxButtons.YesNoCancel);
        }

        private void NewMap()
        {
            if (G.currentMap != null)
            {
                DialogResult result = CheckForSave("新建地图");

                if (result == DialogResult.Cancel)
                    return;
                else if (result == DialogResult.Yes)
                {
                    G.currentMap.Save();
                    G.currentMap.Clean();
                    G.currentMap = null;
                }
                else
                {
                    G.currentMap.Clean();
                    G.currentMap = null;
                }
            }

            DlgNew newDlg = new DlgNew();
            if (newDlg.ShowDialog() == DialogResult.OK)
            {
                G.currentTexture = new TexturePanel(G.currentMap.textureName, G.currentMap.imgList);
                this.splitContainer1.Panel1.Controls.Add(G.currentTexture);
            }
        }

        private void TB_Open_Click(object sender, EventArgs e)
        {
            if (G.currentMap != null)
            {
                DialogResult result = CheckForSave("打开地图");

                if (result == DialogResult.Cancel)
                    return;
                else if (result == DialogResult.Yes)
                {
                    G.currentMap.Save();
                    G.currentMap.Clean();
                    G.currentMap = null;
                }
                else
                {
                    G.currentMap.Clean();
                    G.currentMap = null;
                }
            }
            Dlg_OpenMap.ShowDialog(this);
        }

        private void Menu_Open_Click(object sender, EventArgs e)
        {
            if (G.currentMap != null)
            {
                DialogResult result = CheckForSave("打开地图");

                if (result == DialogResult.Cancel)
                    return;
                else if (result == DialogResult.Yes)
                {
                    G.currentMap.Save();
                    G.currentMap.Clean();
                    G.currentMap = null;
                }
                else
                {
                    G.currentMap.Clean();
                    G.currentMap = null;
                }
            }
            Dlg_OpenMap.ShowDialog(this);
        }

        private void Menu_ShowGrid_Click(object sender, EventArgs e)
        {
            TB_Grid.Checked = G.bGrid = Menu_ShowGrid.Checked;
            MainPanel.Invalidate();
        }

        private void TB_Grid_CheckedChanged(object sender, EventArgs e)
        {
            Menu_ShowGrid.Checked = G.bGrid = TB_Grid.Checked;
            MainPanel.Invalidate();
        }

        private void Menu_AreaBrush_Click(object sender, EventArgs e)
        {
            TB_AreaBrush.Checked = G.bAreaBrush = Menu_AreaBrush.Checked;
        }

        private void TB_AreaBrush_CheckedChanged(object sender, EventArgs e)
        {
            Menu_AreaBrush.Checked = G.bAreaBrush = TB_AreaBrush.Checked;
        }

        private void TB_New_Click(object sender, EventArgs e)
        {
            NewMap();
        }

        private void Menu_New_Click(object sender, EventArgs e)
        {
            NewMap();
        }

        private void TB_Save_Click(object sender, EventArgs e)
        {
            if (G.currentMap == null)
                return;

            G.currentMap.Save();
        }

        private void Menu_Save_Click(object sender, EventArgs e)
        {
            if (G.currentMap == null)
                return;

            G.currentMap.Save();
        }

        private void Menu_DefaultPath_Click(object sender, EventArgs e)
        {
            if (Dlg_DefaultPath.ShowDialog() == DialogResult.OK)
                G.SavePath = Dlg_DefaultPath.SelectedPath;
        }

        private void LeftPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Dlg_OpenMap_FileOk(object sender, CancelEventArgs e)
        {
            String fileName = Dlg_OpenMap.FileName;
            G.currentMap = new Map();
            G.currentMap.Load(fileName);
            G.currentTexture = new TexturePanel(G.currentMap.textureName, G.currentMap.imgList);
            this.splitContainer1.Panel1.Controls.Add(G.currentTexture);
        }

        private void Bt_AddGrid_CheckedChanged(object sender, EventArgs e)
        {
            if (Bt_AddGrid.Checked)
                G.operation = 2;
        }

        private void bt_Land_CheckedChanged(object sender, EventArgs e)
        {
            if (Bt_Land.Checked)
            {
                EStateSettings dlgSettings = new EStateSettings(G.currentSection, G.currentBasePrice);

                if (dlgSettings.ShowDialog(this) == DialogResult.OK)
                {
                    G.currentSection = dlgSettings.section;
                    G.currentBasePrice = dlgSettings.basePrice;
                }

                G.operation = 3;
            }
        }

        private void DelGPO()
        {
            if (G.currentMap != null && G.currentGPO != null)
            {
                if (G.currentGPO.type == (int)(G.gpoType.grid))
                {
                    MapGrid data = ((GridControl)G.currentGPO).data;
                    G.currentMap.gamePlayes[data.x, data.y] = 0;
                    G.currentMap.grids.Remove(data);
                    data = null;
                    G.currentGPO.Dispose();
                    G.currentGPO = null;
                }
                else if (G.currentGPO.type == (int)(G.gpoType.estate))
                {
                    EState data = ((EStateControl)G.currentGPO).data;
                    G.currentMap.gamePlayes[data.x, data.y] = 0;
                    G.currentMap.eStates.Remove(data);
                    data = null;
                    G.currentGPO.Dispose();
                    G.currentGPO = null;
                }

                G.bRepaintMainPanel = true;
            }
        }

        private void TB_Del_Click(object sender, EventArgs e)
        {
            DelGPO();
        }

        private void Menu_Del_Click(object sender, EventArgs e)
        {
            DelGPO();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            //splitContainer1.Panel1.Refresh();
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {
            if (G.currentMap == null)
                return;

            if (MainPanel.Size.Width != G.currentMap.getSize().Width * G.tileSize ||
                MainPanel.Size.Height != G.currentMap.getSize().Height * G.tileSize)
            {
                MainPanel.Size =
                    new Size(G.currentMap.getSize().Width * G.tileSize, G.currentMap.getSize().Height * G.tileSize);
            }
                

            Graphics g = e.Graphics;

            
           for (int i = 0; i < G.currentMap.getSize().Width; i++)
           {
               for (int j = 0; j < G.currentMap.getSize().Height; j++)
               {
                   if (G.currentMap.tiles[i, j] < 0)
                       continue;
                   Image currentImg = null;
                   currentImg = (G.currentMap.imgList)[G.currentMap.tiles[i, j]];
                   if (currentImg != null)
                       g.DrawImage(currentImg, i * G.tileSize, j * G.tileSize);
               }
           }
            
            if (G.bGrid)
            {
                Pen gridPen = new Pen(Color.Black, 1);
                int w = MainPanel.Size.Width / G.tileSize + 1;
                int h = MainPanel.Size.Height / G.tileSize + 1;

                for (int i = 0; i < h; i++)
                {
                    g.DrawLine(gridPen, 0, i * G.tileSize, MainPanel.Size.Width, i * G.tileSize);
                }

                for (int i = 0; i < w; i++)
                {
                    g.DrawLine(gridPen, i * G.tileSize, 0, i * G.tileSize, MainPanel.Size.Height);
                }
            }

            if (((G.bAreaBrush && G.operation == 1) || G.operation == 3) && bMouseDownMainPanel)
            {
                Pen AreaPen = new Pen(Color.Gray, 4);
                AreaPen.DashStyle = DashStyle.Dot;
                int startX = (AreaStartI <= AreaEndI) ? AreaStartI : AreaEndI;
                int startY = (AreaStartJ <= AreaEndJ) ? AreaStartJ : AreaEndJ;
                int AreaWidth = Math.Abs(AreaStartI - AreaEndI) + 1;
                int AreaHeight = Math.Abs(AreaStartJ - AreaEndJ) + 1;
                g.DrawRectangle(AreaPen,
                    new Rectangle(startX * G.tileSize, startY * G.tileSize, AreaWidth * G.tileSize, AreaHeight * G.tileSize));
            }

            /*
            if (G.chosingGrid != null)
            {
                Pen pathPen = new Pen(Color.White, 4);
                g.DrawLine(pathPen, G.chosingGrid.Location.X + 32, G.chosingGrid.Location.Y + 32, mousePt.X, mousePt.Y);
            }
            */
        }

        private void updateTile(int i, int j)
        {
            if (G.currentTexture.getCurrentIndex() >= 0)
                G.currentMap.tiles[i, j] = G.currentTexture.getCurrentIndex();
        }

        private void updateArea(int iStart, int jStart, int iEnd, int Jend)
        {
            if (G.operation == 1 && G.bAreaBrush)
            {
                for (int i = iStart; i <= iEnd; i++)
                {
                    for (int j = jStart; j <= Jend; j++)
                    {
                        G.currentMap.tiles[i, j] = G.currentTexture.getCurrentIndex();
                    }
                }
            }
            else if (G.operation == 3)
            {
                for (int i = iStart; i <= iEnd; i++)
                {
                    for (int j = jStart; j <= Jend; j++)
                    {
                        EState eState = new EState(i, j, G.currentSection, G.currentBasePrice);
                        EStateControl ec = new EStateControl();
                        ec.data = eState;
                        MainPanel.Controls.Add(ec);
                        ec.Location = new Point(i * G.tileSize, j * G.tileSize);
                        G.currentMap.gamePlayes[i, j] = 3;
                        G.currentMap.eStates.Add(eState);
                    }
                }
            }
        }

        private bool CheckTile(int x, int y, int type)
        {
            switch (type)
            {
                case 2:     // Grid
                    for (int i = 0; i < G.currentMap.grids.Count(); i++)
                    {
                        if (G.currentMap.grids[i].x == x &&
                            G.currentMap.grids[i].y == y)
                            return false;
                    }
                    break;
                default:
                    break;
            }

            return true;
        }

        private Point getMapMouseLoc(int x, int y)
        {
            Point pt = new Point();

            pt.X = x / G.tileSize * G.tileSize;
            if (pt.X < 0)
                pt.X = 0;
            if (G.currentMap != null && pt.X > G.currentMap.getSize().Width * G.tileSize - G.tileSize)
                pt.X = G.currentMap.getSize().Width * G.tileSize - G.tileSize;

            pt.Y = y / G.tileSize * G.tileSize;
            if (pt.Y < 0)
                pt.Y = 0;
            if (G.currentMap != null && pt.Y > G.currentMap.getSize().Height * G.tileSize - G.tileSize)
                pt.Y = G.currentMap.getSize().Height * G.tileSize - G.tileSize;

            return pt;
        }

        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            bMouseDownMainPanel = true;
            mousePt = getMapMouseLoc(e.X, e.Y);
            if (G.currentMap == null)
                    return;

            if (G.operation == 1)
            {
                if (G.currentTexture == null)
                    return;

                if (G.bAreaBrush)
                {
                    AreaStartI = AreaEndI = mousePt.X / G.tileSize;
                    AreaStartJ = AreaEndJ = mousePt.Y / G.tileSize;
                }
                else
                {
                    updateTile(mousePt.X / G.tileSize, mousePt.Y / G.tileSize);
                }
            }
            else if (G.operation == 2)
            {
                MapGrid grid = new MapGrid(mousePt.X / G.tileSize, mousePt.Y / G.tileSize);
                GridControl gc = new GridControl();
                MainPanel.Controls.Add(gc);
                gc.Location = new Point(mousePt.X, mousePt.Y);
                gc.data = grid;
                G.currentMap.grids.Add(grid);
                G.currentMap.gamePlayes[mousePt.X / G.tileSize, mousePt.Y / G.tileSize] = 2;
            }
            else if (G.operation == 3)
            {
                AreaStartI = AreaEndI = mousePt.X / G.tileSize;
                AreaStartJ = AreaEndJ = mousePt.Y / G.tileSize;
            }

            MainPanel.Invalidate();
        }

        private void MainPanel_MouseLeave(object sender, EventArgs e)
        {
            //bMainPanelMouseDown = false;

            MainPanel.Invalidate();
        }

        private void MainPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (G.operation == 1 || G.operation == 3)
            {
                if (G.currentTexture == null || G.currentMap == null)
                    return;

                mousePt = getMapMouseLoc(e.X, e.Y);
                int i = mousePt.X / G.tileSize;
                int j = mousePt.Y / G.tileSize;

                AreaEndI = i;
                AreaEndJ = j;

                if (AreaEndI >= G.currentMap.getSize().Width)
                    AreaEndI = G.currentMap.getSize().Width - 1;
                if (AreaEndI < 0)
                    AreaEndI = 0;
                if (AreaEndJ >= G.currentMap.getSize().Height)
                    AreaEndJ = G.currentMap.getSize().Height - 1;
                if (AreaEndJ < 0)
                    AreaEndJ = 0;

                int starti = Math.Min(AreaStartI, AreaEndI);
                int startj = Math.Min(AreaStartJ, AreaEndJ);
                int endi = Math.Max(AreaStartI, AreaEndI);
                int endj = Math.Max(AreaStartJ, AreaEndJ);

                updateArea(starti, startj, endi, endj);

                AreaStartI = AreaStartJ = AreaEndI = AreaEndJ = -1;
            }

            bMouseDownMainPanel = false;
            MainPanel.Invalidate();
        }

        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            mousePt = getMapMouseLoc(e.X, e.Y);

            int i = mousePt.X / G.tileSize;
            int j = mousePt.Y / G.tileSize;

            if (((G.operation == 1 && G.bAreaBrush) || G.operation == 3) && bMouseDownMainPanel)
            {
                AreaEndI = i;
                AreaEndJ = j;
            }

            MainPanel.Invalidate();
        }

        private void splitContainer1_Panel1_SizeChanged(object sender, EventArgs e)
        {
            G.TilesPerLineInTexture = splitContainer1.Panel1.Size.Width / 42 - 1;

            if (G.TilesPerLineInTexture < 4)
                G.TilesPerLineInTexture = 4;

            G.PopZoneWidth = G.TilesPerLineInTexture * 42;

            G.bRepaintAll = true;
        }

    }
}
