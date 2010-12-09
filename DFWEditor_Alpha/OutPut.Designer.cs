namespace DFWEditor_Alpha
{
    partial class OutPut
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
            this.RTb_output = new System.Windows.Forms.RichTextBox();
            this.Bt_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RTb_output
            // 
            this.RTb_output.Location = new System.Drawing.Point(2, 2);
            this.RTb_output.Name = "RTb_output";
            this.RTb_output.Size = new System.Drawing.Size(426, 403);
            this.RTb_output.TabIndex = 0;
            this.RTb_output.Text = "";
            // 
            // Bt_Close
            // 
            this.Bt_Close.Location = new System.Drawing.Point(353, 411);
            this.Bt_Close.Name = "Bt_Close";
            this.Bt_Close.Size = new System.Drawing.Size(75, 23);
            this.Bt_Close.TabIndex = 1;
            this.Bt_Close.Text = "关闭";
            this.Bt_Close.UseVisualStyleBackColor = true;
            this.Bt_Close.Click += new System.EventHandler(this.Bt_Close_Click);
            // 
            // OutPut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 438);
            this.Controls.Add(this.Bt_Close);
            this.Controls.Add(this.RTb_output);
            this.Name = "OutPut";
            this.Text = "OutPut";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTb_output;
        private System.Windows.Forms.Button Bt_Close;
    }
}