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
    public partial class GPO : PictureBox
    {
        public int type;
        private bool bMouseDown;
        private int deltaX, deltaY;

        public GPO()
        {
            InitializeComponent();
            G.currentGPO = this;
            bMouseDown = false;
        }

        private void ResetLoc()
        {
            int x = Location.X;
            int y = Location.Y;

            Point pt = new Point();

            if (x % G.tileSize < G.tileSize / 2)
                pt.X = x / G.tileSize * G.tileSize;
            else
                pt.X = x / G.tileSize * G.tileSize + G.tileSize;

            if (pt.X < 0)
                pt.X = 0;
            if (pt.X > G.currentMap.getSize().Width * G.tileSize - G.tileSize)
                pt.X = G.currentMap.getSize().Width * G.tileSize - G.tileSize;

            if (y % G.tileSize < G.tileSize / 2)
                pt.Y = y / G.tileSize * G.tileSize;
            else
                pt.Y = y / G.tileSize * G.tileSize + G.tileSize;

            if (pt.Y < 0)
                pt.Y = 0;
            if (pt.Y > G.currentMap.getSize().Height * G.tileSize - G.tileSize)
                pt.Y = G.currentMap.getSize().Height * G.tileSize - G.tileSize;

            Location = new Point(pt.X, pt.Y);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            Graphics g = pe.Graphics;

            if (G.currentGPO == this)
            {
                Pen penOutLine = new Pen(Color.Blue, 2);
                g.DrawRectangle(penOutLine, 1, 1, Size.Width - 2, Size.Height - 2);
            }
        }

        private void GPO_Click(object sender, EventArgs e)
        {

        }

        private void GPO_MouseDown(object sender, MouseEventArgs e)
        {
            G.currentPicking = this;
            bMouseDown = true;
            deltaX = e.X;
            deltaY = e.Y;

            G.currentGPO = this;
            G.bRepaintMainPanel = true;
        }

        private void GPO_MouseUp(object sender, MouseEventArgs e)
        {
            G.currentPicking = null;
            bMouseDown = false;
            deltaX = 0;
            deltaY = 0;
            ResetLoc();
        }

        private void GPO_MouseMove(object sender, MouseEventArgs e)
        {
            if (bMouseDown)
            {
                int dx = e.X - deltaX;
                int dy = e.Y - deltaY;
                Location = new Point(Location.X + dx, Location.Y + dy);
            }
        }
    }
}
