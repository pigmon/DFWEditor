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
        private String textureName;
        private List<Image> imgList;
        private int line;
        private bool bDelMe;
        private const int blank = 10;
        private const int imgSize = 32;
        private int blockX, blockY;

        public bool bMinimize;
        public int selectedIndex;

        public PopZone()
        {
            InitializeComponent();
            currentSize = new Size(350, 300);
            Size = new Size(350, 300);
            miniHeight = 26;
            bDelMe = false;
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
            line = count / 8;
            if (line == 0)
                line = 1;
            if (count - line * 8 > 0)
                line += 1;

            int maxHeight = miniHeight + line * (imgSize + blank) + blank;
            currentSize = new Size(350, maxHeight);
            Size = new Size(350, maxHeight);

            bDelMe = false;
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

            int length = 8;
            for (int i = 0; i < line; i++)
            {
                if (i == line - 1 && imgList.Count() % 8 != 0)
                    length = imgList.Count() % 8;
                for (int j = 0; j < length; j++)
                {
                    g.DrawImage(imgList[i * 8 + j],
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

            if (i > 7 || j * 8 + i > imgList.Count() - 1)
                return;

            G.selectedTile = imgList[j * 8 + i];
            G.bRepaintTextures = true;

            blockX = blank * i + imgSize * i;
            blockY = blank + blank * j + imgSize * j;

            TileWindow.Invalidate();
        }
    }
}
