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
    public partial class EStateSettings : Form
    {
        public String section;
        public int basePrice;

        public EStateSettings(String _section, int _basePrice)
        {
            InitializeComponent();
            section = _section;
            basePrice = _basePrice;

            Tb_Section.Text = section;
            Num_BasePrice.Value = basePrice;
        }

        private void Bt_OK_Click(object sender, EventArgs e)
        {
            section = Tb_Section.Text;
            basePrice = Decimal.ToInt32(Num_BasePrice.Value);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void Bt_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
