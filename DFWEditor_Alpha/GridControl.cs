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
    public partial class GridControl : GPO
    {
        public MapGrid data;

        public GridControl()
        {
            InitializeComponent();

            type = (int)(G.gpoType.grid);
        }

        public void SetEstate(EState _eState)
        {
            if (data != null)
                data.SetEstate(_eState);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Graphics g = pe.Graphics;

            if (data.bank)
                g.DrawImage(Properties.Resources.bank, new Rectangle(0, 0, 32, 32));
            if (data.bPlayerStart)
                g.DrawImage(Properties.Resources.TransTarget, new Rectangle(0, 32, 32, 32));
            if (data.bHospital)
                g.DrawImage(Properties.Resources.hospital, new Rectangle(32, 0, 32, 32));
            if (data.bJail)
                g.DrawImage(Properties.Resources.Jail, new Rectangle(32, 32, 32, 32));
        }

        private void GridControl_DoubleClick(object sender, EventArgs e)
        {
            if (data == null)
                return;

            Point esLoc;
            if (data.eState != null)
                esLoc = new Point(data.eState.x, data.eState.y);
            else
                esLoc = new Point(-1, -1);

            GridSettings gsDlg = new GridSettings(data.deity, data.eventContainer, data.bank, data.bHospital, data.bJail, data.bPlayerStart, esLoc);
            if (gsDlg.ShowDialog(this) == DialogResult.OK)
            {
                data.bank = gsDlg.bBank;
                data.eventContainer = gsDlg.eventType;
                data.deity = gsDlg.deity;
                data.bHospital = gsDlg.bHospital;
                data.bJail = gsDlg.bJail;
                data.bPlayerStart = gsDlg.bPlayerStart;

                if (data.bHospital)
                    G.currentMap.info.hospitalExit = new Point(Location.X / G.tileSize, Location.Y / G.tileSize);
                if (data.bJail)
                    G.currentMap.info.jailExit = new Point(Location.X / G.tileSize, Location.Y / G.tileSize);
                if (data.bPlayerStart)
                    G.currentMap.info.playerStarts.Add(new Point(Location.X / G.tileSize, Location.Y / G.tileSize));

                G.currentMap.UpdateGrids();
            }

            G.currentGPO = this;
            G.bRepaintMainPanel = true;
        }

        private void GridControl_Click(object sender, EventArgs e)
        {
            if (G.operation == 4)
            {
                data.bHospital = true;
                G.currentMap.info.hospitalExit = new Point(data.x, data.y);
                G.currentMap.UpdateGrids();
            }
            else if (G.operation == 5)
            {
                data.bJail = true;
                G.currentMap.info.jailExit = new Point(data.x, data.y);
                G.currentMap.UpdateGrids();
            }
            else if (G.operation == 6)
            {
                data.bPlayerStart = true;
                G.currentMap.info.playerStarts.Add(new Point(data.x, data.y));
            }
                

            G.chosingGrid = this;
            //G.operation = -1;
        }

       
    }
}
