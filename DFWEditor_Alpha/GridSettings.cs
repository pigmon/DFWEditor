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
    public partial class GridSettings : Form
    {
        public int deity;
        public String eventType;
        public bool bBank;
        public Point eStateLoc;

        public GridSettings(int _deity, String _eventType, bool _bBank, Point esLoc)
        {
            InitializeComponent();

            deity = _deity;
            CB_Deity.SelectedIndex = deity;
            bBank = _bBank;
            CB_Bank.Checked = bBank;

            if (_eventType == "Player")
            {
                CB_Event.SelectedIndex = 0;
                eventType = _eventType;
            }
            else if (_eventType == "World")
            {
                CB_Event.SelectedIndex = 1;
                eventType = _eventType;
            }
            else
            {
                CB_Event.SelectedIndex = -1;
                eventType = "null";
            }

            Lb_ESLoc.Text = "(" + esLoc.X.ToString() + " ," + esLoc.Y.ToString() + ")";
            eStateLoc = esLoc;
        }

        private void Bt_OK_Click(object sender, EventArgs e)
        {
            deity = CB_Deity.SelectedIndex;
            if (CB_Event.Text.Length > 0)
                eventType = CB_Event.Text;
            else
                eventType = "null";
            bBank = CB_Bank.Checked;

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
