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
    public partial class DlgNew : Form
    {
        public DlgNew()
        {
            InitializeComponent();
        }

        private void Bt_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Bt_Clear_Click(object sender, EventArgs e)
        {
            Tb_MapName.Text = "";
            Num_MapWidth.Value = Num_MapWidth.Minimum;
            Num_MapHeight.Value = Num_MapHeight.Minimum;
        }

        private void Bt_OK_Click(object sender, EventArgs e)
        {
            if (Tb_MapName.Text.Length <= 0)
            {
                MessageBox.Show("请输入地图名字。");
                return;
            }

            G.currentMap = new Map(Tb_MapName.Text, Decimal.ToInt32(Num_MapWidth.Value), Decimal.ToInt32(Num_MapHeight.Value));

            Close();
        }
    }
}
