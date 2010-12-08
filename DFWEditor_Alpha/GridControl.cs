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
    public partial class GridControl : GPO
    {
        public MapGrid data;

        public GridControl()
        {
            InitializeComponent();

            type = (int)(G.gpoType.grid);
        }

        public void SetEstate(EState _eState)
        {
            if (data != null)
                data.SetEstate(_eState);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Graphics g = pe.Graphics;

            if (G.currentGPO == this)
            {
                Pen penOutLine = new Pen(Color.Blue, 2);
                g.DrawRectangle(penOutLine, 1, 1, Size.Width-2, Size.Height-2);
            }
        }

        private void GridControl_DoubleClick(object sender, EventArgs e)
        {
            if (data == null)
                return;

            GridSettings gsDlg = new GridSettings(data.deity, data.eventContainer, data.bank);
            if (gsDlg.ShowDialog(this) == DialogResult.OK)
            {
                data.bank = gsDlg.bBank;
                data.eventContainer = gsDlg.eventType;
                data.deity = gsDlg.deity;
            }

            G.currentGPO = this;
            G.bRepaintMainPanel = true;
        }

        private void GridControl_Click(object sender, EventArgs e)
        {
            G.chosingGrid = this;
            G.operation = -1;

            G.currentGPO = this;
            G.bRepaintMainPanel = true;
        }

       
    }
}
