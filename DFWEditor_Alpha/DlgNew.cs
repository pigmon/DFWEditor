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
    }
}
