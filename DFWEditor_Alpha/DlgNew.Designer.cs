namespace DFWEditor_Alpha
{
    partial class DlgNew
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lb_MapName = new System.Windows.Forms.Label();
            this.Tb_MapName = new System.Windows.Forms.TextBox();
            this.Lb_MapWidth = new System.Windows.Forms.Label();
            this.Lb_MapHeight = new System.Windows.Forms.Label();
            this.Num_MapWidth = new System.Windows.Forms.NumericUpDown();
            this.Num_MapHeight = new System.Windows.Forms.NumericUpDown();
            this.Bt_OK = new System.Windows.Forms.Button();
            this.Bt_Clear = new System.Windows.Forms.Button();
            this.Bt_Cancel = new System.Windows.Forms.Button();
            this.Dlg_OpenTexture = new System.Windows.Forms.OpenFileDialog();
            this.Lb_Texture = new System.Windows.Forms.Label();
            this.Bt_OpenTexture = new System.Windows.Forms.Button();
            this.Lb_TextureName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Num_MapWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_MapHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // Lb_MapName
            // 
            this.Lb_MapName.AutoSize = true;
            this.Lb_MapName.Location = new System.Drawing.Point(13, 13);
            this.Lb_MapName.Name = "Lb_MapName";
            this.Lb_MapName.Size = new System.Drawing.Size(41, 12);
            this.Lb_MapName.TabIndex = 0;
            this.Lb_MapName.Text = "名字：";
            // 
            // Tb_MapName
            // 
            this.Tb_MapName.Location = new System.Drawing.Point(153, 10);
            this.Tb_MapName.Name = "Tb_MapName";
            this.Tb_MapName.Size = new System.Drawing.Size(120, 21);
            this.Tb_MapName.TabIndex = 1;
            // 
            // Lb_MapWidth
            // 
            this.Lb_MapWidth.AutoSize = true;
            this.Lb_MapWidth.Location = new System.Drawing.Point(13, 49);
            this.Lb_MapWidth.Name = "Lb_MapWidth";
            this.Lb_MapWidth.Size = new System.Drawing.Size(101, 12);
            this.Lb_MapWidth.TabIndex = 2;
            this.Lb_MapWidth.Text = "宽度（Tile数）：";
            // 
            // Lb_MapHeight
            // 
            this.Lb_MapHeight.AutoSize = true;
            this.Lb_MapHeight.Location = new System.Drawing.Point(13, 85);
            this.Lb_MapHeight.Name = "Lb_MapHeight";
            this.Lb_MapHeight.Size = new System.Drawing.Size(101, 12);
            this.Lb_MapHeight.TabIndex = 3;
            this.Lb_MapHeight.Text = "高度（Tile数）：";
            // 
            // Num_MapWidth
            // 
            this.Num_MapWidth.Location = new System.Drawing.Point(153, 47);
            this.Num_MapWidth.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.Num_MapWidth.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.Num_MapWidth.Name = "Num_MapWidth";
            this.Num_MapWidth.Size = new System.Drawing.Size(120, 21);
            this.Num_MapWidth.TabIndex = 4;
            this.Num_MapWidth.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // Num_MapHeight
            // 
            this.Num_MapHeight.Location = new System.Drawing.Point(153, 83);
            this.Num_MapHeight.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.Num_MapHeight.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Num_MapHeight.Name = "Num_MapHeight";
            this.Num_MapHeight.Size = new System.Drawing.Size(120, 21);
            this.Num_MapHeight.TabIndex = 5;
            this.Num_MapHeight.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Bt_OK
            // 
            this.Bt_OK.Location = new System.Drawing.Point(22, 227);
            this.Bt_OK.Name = "Bt_OK";
            this.Bt_OK.Size = new System.Drawing.Size(75, 23);
            this.Bt_OK.TabIndex = 6;
            this.Bt_OK.Text = "确定";
            this.Bt_OK.UseVisualStyleBackColor = true;
            this.Bt_OK.Click += new System.EventHandler(this.Bt_OK_Click);
            // 
            // Bt_Clear
            // 
            this.Bt_Clear.Location = new System.Drawing.Point(103, 227);
            this.Bt_Clear.Name = "Bt_Clear";
            this.Bt_Clear.Size = new System.Drawing.Size(75, 23);
            this.Bt_Clear.TabIndex = 7;
            this.Bt_Clear.Text = "重置";
            this.Bt_Clear.UseVisualStyleBackColor = true;
            this.Bt_Clear.Click += new System.EventHandler(this.Bt_Clear_Click);
            // 
            // Bt_Cancel
            // 
            this.Bt_Cancel.Location = new System.Drawing.Point(184, 227);
            this.Bt_Cancel.Name = "Bt_Cancel";
            this.Bt_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Bt_Cancel.TabIndex = 8;
            this.Bt_Cancel.Text = "取消";
            this.Bt_Cancel.UseVisualStyleBackColor = true;
            this.Bt_Cancel.Click += new System.EventHandler(this.Bt_Cancel_Click);
            // 
            // Dlg_OpenTexture
            // 
            this.Dlg_OpenTexture.Filter = "图像文件(*.bmp,*.png,*.gif) |*.bmp;*.png;*.gif";
            this.Dlg_OpenTexture.FileOk += new System.ComponentModel.CancelEventHandler(this.Dlg_OpenTexture_FileOk);
            // 
            // Lb_Texture
            // 
            this.Lb_Texture.AutoSize = true;
            this.Lb_Texture.Location = new System.Drawing.Point(14, 122);
            this.Lb_Texture.Name = "Lb_Texture";
            this.Lb_Texture.Size = new System.Drawing.Size(41, 12);
            this.Lb_Texture.TabIndex = 9;
            this.Lb_Texture.Text = "贴图：";
            // 
            // Bt_OpenTexture
            // 
            this.Bt_OpenTexture.Location = new System.Drawing.Point(153, 117);
            this.Bt_OpenTexture.Name = "Bt_OpenTexture";
            this.Bt_OpenTexture.Size = new System.Drawing.Size(35, 23);
            this.Bt_OpenTexture.TabIndex = 10;
            this.Bt_OpenTexture.Text = "...";
            this.Bt_OpenTexture.UseVisualStyleBackColor = true;
            this.Bt_OpenTexture.Click += new System.EventHandler(this.Bt_OpenTexture_Click);
            // 
            // Lb_TextureName
            // 
            this.Lb_TextureName.AutoSize = true;
            this.Lb_TextureName.Location = new System.Drawing.Point(15, 157);
            this.Lb_TextureName.Name = "Lb_TextureName";
            this.Lb_TextureName.Size = new System.Drawing.Size(29, 12);
            this.Lb_TextureName.TabIndex = 11;
            this.Lb_TextureName.Text = "null";
            // 
            // DlgNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Lb_TextureName);
            this.Controls.Add(this.Bt_OpenTexture);
            this.Controls.Add(this.Lb_Texture);
            this.Controls.Add(this.Bt_Cancel);
            this.Controls.Add(this.Bt_Clear);
            this.Controls.Add(this.Bt_OK);
            this.Controls.Add(this.Num_MapHeight);
            this.Controls.Add(this.Num_MapWidth);
            this.Controls.Add(this.Lb_MapHeight);
            this.Controls.Add(this.Lb_MapWidth);
            this.Controls.Add(this.Tb_MapName);
            this.Controls.Add(this.Lb_MapName);
            this.Name = "DlgNew";
            this.Text = "新建地图";
            ((System.ComponentModel.ISupportInitialize)(this.Num_MapWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_MapHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_MapName;
        private System.Windows.Forms.TextBox Tb_MapName;
        private System.Windows.Forms.Label Lb_MapWidth;
        private System.Windows.Forms.Label Lb_MapHeight;
        private System.Windows.Forms.NumericUpDown Num_MapWidth;
        private System.Windows.Forms.NumericUpDown Num_MapHeight;
        private System.Windows.Forms.Button Bt_OK;
        private System.Windows.Forms.Button Bt_Clear;
        private System.Windows.Forms.Button Bt_Cancel;
        private System.Windows.Forms.OpenFileDialog Dlg_OpenTexture;
        private System.Windows.Forms.Label Lb_Texture;
        private System.Windows.Forms.Button Bt_OpenTexture;
        private System.Windows.Forms.Label Lb_TextureName;
    }
}