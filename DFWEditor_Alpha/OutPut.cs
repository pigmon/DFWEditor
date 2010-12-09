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
    public partial class OutPut : Form
    {
        public OutPut()
        {
            InitializeComponent();
        }

        private void Bt_Close_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        public void setText(String text)
        {
            RTb_output.Text = text;
        }
    }
}
