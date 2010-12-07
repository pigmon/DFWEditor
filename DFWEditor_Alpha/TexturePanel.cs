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
    public partial class TexturePanel : DoubleBufferedPanel
    {
        private List<Image> imgList;
        private int line;
        private const int blank = 10;
        private const int imgSize = 32;
        private int blockX, blockY;
        private int selectedIndex;

        public String textureName;


        public TexturePanel()
        {
            InitializeComponent();
            selectedIndex = -1;
        }

        public TexturePanel(String _textureName, List<Image> _imgList)
        {
            InitializeComponent();

            textureName = _textureName;
            imgList = _imgList;

            int count = imgList.Count();
            line = count / G.TilesPerLineInTexture;
            if (line == 0)
                line = 1;
            if (count - line * G.TilesPerLineInTexture > 0)
                line += 1;

            int maxHeight = line * (imgSize + blank) + blank;
            Size = new Size(G.PopZoneWidth, maxHeight);

            selectedIndex = -1;
        }

        ~TexturePanel()
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

        public List<Image> getImgList()
        {
            return imgList;
        }

        public int getCurrentIndex()
        {
            return selectedIndex;
        }

        private void DrawBlock(Graphics g, int x, int y)
        {
            Pen penBlock = new Pen(Color.Red, 1);
            Brush brushBlock = new SolidBrush(Color.FromArgb(64, Color.Red));

            g.DrawRectangle(penBlock, new Rectangle(x, y, imgSize - 1, imgSize - 1));
            g.FillRectangle(brushBlock, new Rectangle(x, y, imgSize - 1, imgSize - 1));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int count = imgList.Count();
            line = count / G.TilesPerLineInTexture;
            if (line == 0)
                line = 1;
            if (count - line * G.TilesPerLineInTexture > 0)
                line += 1;

            int maxHeight = line * (imgSize + blank) + blank;
            Size = new Size(G.PopZoneWidth, maxHeight);

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

            if (G.selectedTile != null)
            {
                DrawBlock(g, blockX, blockY);
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
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

            Invalidate();
        }
    }
}
