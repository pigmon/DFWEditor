namespace DFWEditor_Alpha
{
    partial class PopZone
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Lb_TextureName = new System.Windows.Forms.Label();
            this.Bt_Del = new System.Windows.Forms.Button();
            this.Bt_Min = new System.Windows.Forms.Button();
            this.TileWindow = new DFWEditor_Alpha.DoubleBufferedPanel();
            this.SuspendLayout();
            // 
            // Lb_TextureName
            // 
            this.Lb_TextureName.AutoSize = true;
            this.Lb_TextureName.Location = new System.Drawing.Point(3, 7);
            this.Lb_TextureName.Name = "Lb_TextureName";
            this.Lb_TextureName.Size = new System.Drawing.Size(77, 12);
            this.Lb_TextureName.TabIndex = 3;
            this.Lb_TextureName.Text = "Texture Name";
            // 
            // Bt_Del
            // 
            this.Bt_Del.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Bt_Del.BackgroundImage = global::DFWEditor_Alpha.Properties.Resources.del;
            this.Bt_Del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Bt_Del.Location = new System.Drawing.Point(256, 5);
            this.Bt_Del.Name = "Bt_Del";
            this.Bt_Del.Size = new System.Drawing.Size(17, 17);
            this.Bt_Del.TabIndex = 2;
            this.Bt_Del.UseVisualStyleBackColor = true;
            this.Bt_Del.Click += new System.EventHandler(this.Bt_Del_Click);
            // 
            // Bt_Min
            // 
            this.Bt_Min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Bt_Min.BackgroundImage = global::DFWEditor_Alpha.Properties.Resources.min;
            this.Bt_Min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Bt_Min.Location = new System.Drawing.Point(279, 5);
            this.Bt_Min.Name = "Bt_Min";
            this.Bt_Min.Size = new System.Drawing.Size(17, 17);
            this.Bt_Min.TabIndex = 1;
            this.Bt_Min.UseVisualStyleBackColor = true;
            this.Bt_Min.Click += new System.EventHandler(this.Bt_Min_Click);
            // 
            // TileWindow
            // 
            this.TileWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TileWindow.BackColor = System.Drawing.SystemColors.Window;
            this.TileWindow.Location = new System.Drawing.Point(3, 26);
            this.TileWindow.Name = "TileWindow";
            this.TileWindow.Size = new System.Drawing.Size(293, 271);
            this.TileWindow.TabIndex = 4;
            this.TileWindow.Paint += new System.Windows.Forms.PaintEventHandler(this.TileWindow_Paint);
            this.TileWindow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TileWindow_MouseDown);
            // 
            // PopZone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.TileWindow);
            this.Controls.Add(this.Lb_TextureName);
            this.Controls.Add(this.Bt_Del);
            this.Controls.Add(this.Bt_Min);
            this.Name = "PopZone";
            this.Size = new System.Drawing.Size(300, 300);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PopZone_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bt_Min;
        private System.Windows.Forms.Button Bt_Del;
        private System.Windows.Forms.Label Lb_TextureName;
        private DoubleBufferedPanel TileWindow;

    }
}
