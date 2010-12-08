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

        public GPO()
        {
            InitializeComponent();
            G.currentGPO = this;
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
            G.currentGPO = this;
            G.bRepaintMainPanel = true;
        }
    }
}
