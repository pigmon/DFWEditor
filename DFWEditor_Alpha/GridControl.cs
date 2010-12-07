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
    public partial class GridControl : PictureBox
    {
        public MapGrid data;

        public GridControl()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
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
        }
    }
}
