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
    public partial class JailControl : GPO
    {
        public JailControl()
        {
            InitializeComponent();
            type = (int)(G.gpoType.jail);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
