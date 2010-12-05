using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DFWEditor_Alpha
{
    public partial class PopZone : UserControl
    {
        private int miniHeight;
        private Size currentSize;
        private List<Image> imgList;
        private int line;
        private bool bDelMe;
        private const int blank = 10;
        private const int imgSize = 32;
        private int blockX, blockY;
        private int selectedIndex;

        public bool bMinimize; 
        public String textureName;

        public PopZone()
        {
            InitializeComponent();
            currentSize = new Size(G.PopZoneWidth, 300);
            Size = new Size(G.PopZoneWidth, 300);
            miniHeight = 26;
            bDelMe = false;
            selectedIndex = -1;
        }

        public PopZone(String _textureName, List<Image> _imgList)
        {
            InitializeComponent();
            //currentSize = new Size(300, 300);
            miniHeight = 26;
            textureName = _textureName;
            Lb_TextureName.Text = textureName;
            imgList = _imgList;

            int count = imgList.Count();
            line = count / G.TilesPerLineInTexture;
            if (line == 0)
                line = 1;
            if (count - line * G.TilesPerLineInTexture > 0)
                line += 1;

            int maxHeight = miniHeight + line * (imgSize + blank) + blank;
            currentSize = new Size(G.PopZoneWidth, maxHeight);
            Size = new Size(G.PopZoneWidth, maxHeight);

            bDelMe = false;
            selectedIndex = -1;
        }

        ~PopZone()
        {
            if (imgList != null)
            {
                for (int i = 0; i < imgList.Count(); i++)
                {
                    imgList[i].Dispose();
                    imgList[i] = null;
                }

                imgList.Clear();
                imgList = null;
            }
        }

        public int getHeight()
        {
            return (bMinimize) ? 26 : currentSize.Height;
        }

        public bool checkDelete()
        {
            return bDelMe;
        }

        public List<Image> getImgList()
        {
            return imgList;
        }

        public int getCurrentIndex()
        {
            if (G.selectedTexture != this)
                return -1;

            return selectedIndex;
        }

        private void Bt_Min_Click(object sender, EventArgs e)
        {
            if (!bMinimize)
            {
                bMinimize = true;
                Bt_Min.BackgroundImage = Properties.Resources.max;
                this.Size = new Size(currentSize.Width, miniHeight);
            }
            else
            {
                bMinimize = false;
                Bt_Min.BackgroundImage = Properties.Resources.min;
                this.Size = new Size(currentSize.Width, currentSize.Height);
            }

            G.bRepaintAll = true;
        }

        private DialogResult CheckDelete()
        {
            return MessageBox.Show("确定要删除贴图么？", "删除确认", MessageBoxButtons.YesNo);
        }

        private void Bt_Del_Click(object sender, EventArgs e)
        {
            DialogResult result = CheckDelete();

            if (result == DialogResult.No)
                return;
            else if (result == DialogResult.Yes)
            {
                bDelMe = true;
            }

        }

        private void DrawBlock(Graphics g, int x, int y)
        {
            Pen penBlock = new Pen(Color.Red, 1);
            Brush brushBlock = new SolidBrush(Color.FromArgb(64, Color.Red));

            g.DrawRectangle(penBlock, new Rectangle(x, y, imgSize - 1, imgSize - 1));
            g.FillRectangle(brushBlock, new Rectangle(x, y, imgSize - 1, imgSize - 1));
        }

        private void PopZone_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TileWindow_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int count = imgList.Count();
            line = count / G.TilesPerLineInTexture;
            if (line == 0)
                line = 1;
            if (count - line * G.TilesPerLineInTexture > 0)
                line += 1;

            int maxHeight = miniHeight + line * (imgSize + blank) + blank;
            Size = new Size(G.PopZoneWidth, maxHeight);
            currentSize = new Size(G.PopZoneWidth, maxHeight);

            int length = G.TilesPerLineInTexture;
            for (int i = 0; i < line; i++)
            {
                if (i == line - 1 && imgList.Count() % G.TilesPerLineInTexture != 0)
                    length = imgList.Count() % G.TilesPerLineInTexture;
                for (int j = 0; j < length; j++)
                {
                    g.DrawImage(imgList[i * G.TilesPerLineInTexture + j],
                        new Rectangle(blank * j + imgSize * j, blank + blank * i + imgSize * i, imgSize, imgSize));
                }
            }

            if (G.selectedTexture == this && G.selectedTile != null)
            {
                DrawBlock(g, blockX, blockY);
            }
        }

        private void TileWindow_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.X > 0 && e.X < TileWindow.Size.Width &&
                e.Y > 0 && e.Y < TileWindow.Size.Height)
            {
                G.selectedTexture = this;
            }
            else
                return;

            G.selectedTile = null;

            int i = e.X / (imgSize + blank);
            int j = (e.Y - blank) / (imgSize + blank);

            if (i >= G.TilesPerLineInTexture || j * G.TilesPerLineInTexture + i > imgList.Count() - 1)
                return;

            G.selectedTile = imgList[j * G.TilesPerLineInTexture + i];
            selectedIndex = j * G.TilesPerLineInTexture + i;
            G.bRepaintTextures = true;

            blockX = blank * i + imgSize * i;
            blockY = blank + blank * j + imgSize * j;

            TileWindow.Invalidate();
        }
    }
}
