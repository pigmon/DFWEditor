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
        public MainForm()
        {
            InitializeComponent();
        }

        private void Menu_ShowGrid_Click(object sender, EventArgs e)
        {
            TB_Grid.Checked = G.bGrid = Menu_ShowGrid.Checked;
        }

        private void TB_Grid_CheckedChanged(object sender, EventArgs e)
        {
            Menu_ShowGrid.Checked = G.bGrid = TB_Grid.Checked;
        }

        private void Menu_AreaBrush_Click(object sender, EventArgs e)
        {
            TB_AreaBrush.Checked = G.bAreaBrush = Menu_AreaBrush.Checked;
        }

        private void TB_AreaBrush_CheckedChanged(object sender, EventArgs e)
        {
            Menu_AreaBrush.Checked = G.bAreaBrush = TB_AreaBrush.Checked;
        }
    }
}
