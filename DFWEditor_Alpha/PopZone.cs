using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DFWEditor_Alpha
{
    public partial class PopZone : UserControl
    {
        private int miniHeight;
        private Size currentSize;
        private String textureName;
        private List<Image> imgList;
        private int line;
        private bool bDelMe;

        public bool bMinimize;

        public PopZone()
        {
            InitializeComponent();
            currentSize = new Size(350, 300);
            Size = new Size(350, 300);
            miniHeight = 26;
            bDelMe = false;
        }

        public PopZone(String _textureName, List<Image> _imgList)
        {
            InitializeComponent();
            //currentSize = new Size(300, 300);
            miniHeight = 26;
            textureName = _textureName;
            Lb_TextureName.Text = textureName;
            imgList = _imgList;

            int count = imgList.Count();
            line = count / 8;
            if (line == 0)
                line = 1;
            if (count - line * 8 > 0)
                line += 1;

            int maxHeight = miniHeight + line * (32 + 10) + 10;
            currentSize = new Size(350, maxHeight);
            Size = new Size(350, maxHeight);

            bDelMe = false;
        }

        ~PopZone()
        {
            if (imgList != null)
            {
                for (int i = 0; i < imgList.Count(); i++)
                {
                    imgList[i].Dispose();
                    imgList[i] = null;
                }

                imgList.Clear();
                imgList = null;
            }
        }

        public int getHeight()
        {
            return (bMinimize) ? 26 : currentSize.Height;
        }

        public bool checkDelete()
        {
            return bDelMe;
        }

        private void Bt_Min_Click(object sender, EventArgs e)
        {
            if (!bMinimize)
            {
                bMinimize = true;
                Bt_Min.BackgroundImage = Properties.Resources.max;
                this.Size = new Size(currentSize.Width, miniHeight);
            }
            else
            {
                bMinimize = false;
                Bt_Min.BackgroundImage = Properties.Resources.min;
                this.Size = new Size(currentSize.Width, currentSize.Height);
            }
        }

        private DialogResult CheckDelete()
        {
            return MessageBox.Show("确定要删除贴图么？", "删除确认", MessageBoxButtons.YesNo);
        }

        private void Bt_Del_Click(object sender, EventArgs e)
        {
            DialogResult result = CheckDelete();

            if (result == DialogResult.No)
                return;
            else if (result == DialogResult.Yes)
            {
                bDelMe = true;
            }

        }

        private void PopZone_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TileWindow_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    g.DrawImage(imgList[i * 8 + j], 
                        new Rectangle(10 * j + j * 32, 10 + 10 * i + i * 32, 32, 32));
                }
            }
        }
    }
}
