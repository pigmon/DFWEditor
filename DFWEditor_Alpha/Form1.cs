using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DFWEditor_Alpha
{
    public partial class MainForm : Form
    {
        private List<PopZone> textureList;
        private Timer timer = new Timer();

        public MainForm()
        {
            InitializeComponent();
            textureList = new List<PopZone>();

            // Timer
            timer.Tick += new EventHandler(TimerProcess);
            timer.Interval = 50;
            timer.Start();
        }

        ~MainForm()
        {
            if (textureList != null)
            {
                for (int i = 0; i < textureList.Count(); i++)
                {
                    textureList[i].Dispose();
                    textureList[i] = null;
                }
                textureList = null;
            }

            timer.Stop();
            timer.Dispose();
            timer = null;
        }

        private void TimerProcess(Object myObject, EventArgs myEventArgs)
        {
            for (int i = 0; i < textureList.Count(); i++)
            {
                if (textureList[i].checkDelete())
                {
                    this.splitContainer1.Panel1.Controls.Remove(textureList[i]);
                    textureList[i].Dispose();
                    textureList[i] = null;
                    textureList.RemoveAt(i);
                    Refresh();
                }
            }

            if (G.bRepaintTextures)
            {
                splitContainer1.Panel1.Refresh();
                G.bRepaintTextures = false;
            }
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

        private void LeftPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Menu_OpenTexture_Click(object sender, EventArgs e)
        {
            Dlg_OpenTexture.ShowDialog(this);
        }

        private void TB_Open_Click(object sender, EventArgs e)
        {
            Dlg_OpenTexture.ShowDialog(this);
        }

        private void Dlg_OpenTexture_FileOk(object sender, CancelEventArgs e)
        {
            String fileName = Dlg_OpenTexture.FileName;
            Image texture = Image.FromFile(fileName);
            List<Image> cutList;
            cutList = new List<Image>();
            ImageManager.Cut(texture, G.tileSize, G.tileSize, "png", cutList);

            String[] split = { "\\" };
            String[] path = fileName.Split(split, StringSplitOptions.RemoveEmptyEntries);
            String texName = path[path.Count() - 1];

            PopZone popZone = new PopZone(texName, cutList);
            textureList.Add(popZone);
            this.splitContainer1.Panel1.Controls.Add(popZone);

            texture.Dispose();
            texture = null;
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            //splitContainer1.Panel1.Refresh();

            if (textureList.Count() > 0)
            {
                textureList[0].Location = new Point(splitContainer1.Panel1.Left + 32, splitContainer1.Panel1.Top + 32);
            }
            for (int i = 1; i < textureList.Count(); i++)
            {
                textureList[i].Location = new Point(splitContainer1.Panel1.Left + 32, textureList[i - 1].Location.Y + textureList[i - 1].getHeight() + 32);
            }
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

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
        }
    }
}
