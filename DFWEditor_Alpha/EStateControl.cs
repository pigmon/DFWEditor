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
        }
    }
}
