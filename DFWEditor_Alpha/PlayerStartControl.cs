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
    public partial class PlayerStartControl : GPO
    {
        public PlayerStartControl()
        {
            InitializeComponent();
            type = (int)(G.gpoType.playerStart);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
