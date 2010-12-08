namespace DFWEditor_Alpha
{
    partial class EStateSettings
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
            this.Lb_Section = new System.Windows.Forms.Label();
            this.Lb_BasePrice = new System.Windows.Forms.Label();
            this.Tb_Section = new System.Windows.Forms.TextBox();
            this.Num_BasePrice = new System.Windows.Forms.NumericUpDown();
            this.Bt_Cancel = new System.Windows.Forms.Button();
            this.Bt_OK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Num_BasePrice)).BeginInit();
            this.SuspendLayout();
            // 
            // Lb_Section
            // 
            this.Lb_Section.AutoSize = true;
            this.Lb_Section.Location = new System.Drawing.Point(13, 13);
            this.Lb_Section.Name = "Lb_Section";
            this.Lb_Section.Size = new System.Drawing.Size(41, 12);
            this.Lb_Section.TabIndex = 0;
            this.Lb_Section.Text = "地段：";
            // 
            // Lb_BasePrice
            // 
            this.Lb_BasePrice.AutoSize = true;
            this.Lb_BasePrice.Location = new System.Drawing.Point(13, 45);
            this.Lb_BasePrice.Name = "Lb_BasePrice";
            this.Lb_BasePrice.Size = new System.Drawing.Size(41, 12);
            this.Lb_BasePrice.TabIndex = 1;
            this.Lb_BasePrice.Text = "基价：";
            // 
            // Tb_Section
            // 
            this.Tb_Section.Location = new System.Drawing.Point(152, 10);
            this.Tb_Section.Name = "Tb_Section";
            this.Tb_Section.Size = new System.Drawing.Size(120, 21);
            this.Tb_Section.TabIndex = 2;
            // 
            // Num_BasePrice
            // 
            this.Num_BasePrice.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.Num_BasePrice.Location = new System.Drawing.Point(152, 43);
            this.Num_BasePrice.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.Num_BasePrice.Name = "Num_BasePrice";
            this.Num_BasePrice.Size = new System.Drawing.Size(120, 21);
            this.Num_BasePrice.TabIndex = 3;
            // 
            // Bt_Cancel
            // 
            this.Bt_Cancel.Location = new System.Drawing.Point(196, 229);
            this.Bt_Cancel.Name = "Bt_Cancel";
            this.Bt_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Bt_Cancel.TabIndex = 4;
            this.Bt_Cancel.Text = "取消";
            this.Bt_Cancel.UseVisualStyleBackColor = true;
            this.Bt_Cancel.Click += new System.EventHandler(this.Bt_Cancel_Click);
            // 
            // Bt_OK
            // 
            this.Bt_OK.Location = new System.Drawing.Point(115, 229);
            this.Bt_OK.Name = "Bt_OK";
            this.Bt_OK.Size = new System.Drawing.Size(75, 23);
            this.Bt_OK.TabIndex = 5;
            this.Bt_OK.Text = "确定";
            this.Bt_OK.UseVisualStyleBackColor = true;
            this.Bt_OK.Click += new System.EventHandler(this.Bt_OK_Click);
            // 
            // EStateSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Bt_OK);
            this.Controls.Add(this.Bt_Cancel);
            this.Controls.Add(this.Num_BasePrice);
            this.Controls.Add(this.Tb_Section);
            this.Controls.Add(this.Lb_BasePrice);
            this.Controls.Add(this.Lb_Section);
            this.Name = "EStateSettings";
            this.Text = "EStateSettings";
            ((System.ComponentModel.ISupportInitialize)(this.Num_BasePrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_Section;
        private System.Windows.Forms.Label Lb_BasePrice;
        private System.Windows.Forms.TextBox Tb_Section;
        private System.Windows.Forms.NumericUpDown Num_BasePrice;
        private System.Windows.Forms.Button Bt_Cancel;
        private System.Windows.Forms.Button Bt_OK;
    }
}