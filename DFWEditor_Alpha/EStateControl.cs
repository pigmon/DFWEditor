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
    public partial class EStateControl : GPO
    {
        public EState data;

        public EStateControl()
        {
            InitializeComponent();
            type = (int)(G.gpoType.estate);
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

        private void EStateControl_DoubleClick(object sender, EventArgs e)
        {
            if (data == null)
                return;

            EStateSettings dlgSettings = new EStateSettings(data.section, data.basePrice);

            if (dlgSettings.ShowDialog(this) == DialogResult.OK)
            {
                data.section = dlgSettings.section;
                data.basePrice = dlgSettings.basePrice;
            }

            G.currentGPO = this;
            G.bRepaintMainPanel = true;
        }

        private void EStateControl_Click(object sender, EventArgs e)
        {
            if (G.chosingGrid != null)
            {
                G.chosingGrid.SetEstate(data);
                G.chosingGrid = null;
                G.operation = 1;
            }

            G.currentGPO = this;
            G.bRepaintMainPanel = true;
        }
    }
}
