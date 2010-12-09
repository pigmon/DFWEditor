namespace DFWEditor_Alpha
{
    partial class GridSettings
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
            this.Bt_OK = new System.Windows.Forms.Button();
            this.Bt_Cancel = new System.Windows.Forms.Button();
            this.Lb_Deity = new System.Windows.Forms.Label();
            this.Lb_Event = new System.Windows.Forms.Label();
            this.Lb_Bank = new System.Windows.Forms.Label();
            this.Lb_Estate = new System.Windows.Forms.Label();
            this.CB_Deity = new System.Windows.Forms.ComboBox();
            this.CB_Event = new System.Windows.Forms.ComboBox();
            this.CB_Bank = new System.Windows.Forms.CheckBox();
            this.Lb_ESLoc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Bt_OK
            // 
            this.Bt_OK.Location = new System.Drawing.Point(116, 276);
            this.Bt_OK.Name = "Bt_OK";
            this.Bt_OK.Size = new System.Drawing.Size(75, 23);
            this.Bt_OK.TabIndex = 1;
            this.Bt_OK.Text = "确定";
            this.Bt_OK.UseVisualStyleBackColor = true;
            this.Bt_OK.Click += new System.EventHandler(this.Bt_OK_Click);
            // 
            // Bt_Cancel
            // 
            this.Bt_Cancel.Location = new System.Drawing.Point(197, 276);
            this.Bt_Cancel.Name = "Bt_Cancel";
            this.Bt_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Bt_Cancel.TabIndex = 2;
            this.Bt_Cancel.Text = "取消";
            this.Bt_Cancel.UseVisualStyleBackColor = true;
            this.Bt_Cancel.Click += new System.EventHandler(this.Bt_Cancel_Click);
            // 
            // Lb_Deity
            // 
            this.Lb_Deity.AutoSize = true;
            this.Lb_Deity.Location = new System.Drawing.Point(13, 13);
            this.Lb_Deity.Name = "Lb_Deity";
            this.Lb_Deity.Size = new System.Drawing.Size(41, 12);
            this.Lb_Deity.TabIndex = 3;
            this.Lb_Deity.Text = "神仙：";
            // 
            // Lb_Event
            // 
            this.Lb_Event.AutoSize = true;
            this.Lb_Event.Location = new System.Drawing.Point(13, 41);
            this.Lb_Event.Name = "Lb_Event";
            this.Lb_Event.Size = new System.Drawing.Size(41, 12);
            this.Lb_Event.TabIndex = 4;
            this.Lb_Event.Text = "事件：";
            // 
            // Lb_Bank
            // 
            this.Lb_Bank.AutoSize = true;
            this.Lb_Bank.Location = new System.Drawing.Point(13, 69);
            this.Lb_Bank.Name = "Lb_Bank";
            this.Lb_Bank.Size = new System.Drawing.Size(41, 12);
            this.Lb_Bank.TabIndex = 5;
            this.Lb_Bank.Text = "银行：";
            // 
            // Lb_Estate
            // 
            this.Lb_Estate.AutoSize = true;
            this.Lb_Estate.Location = new System.Drawing.Point(13, 97);
            this.Lb_Estate.Name = "Lb_Estate";
            this.Lb_Estate.Size = new System.Drawing.Size(41, 12);
            this.Lb_Estate.TabIndex = 6;
            this.Lb_Estate.Text = "房产：";
            // 
            // CB_Deity
            // 
            this.CB_Deity.FormattingEnabled = true;
            this.CB_Deity.Items.AddRange(new object[] {
            "财神",
            "福神",
            "穷神",
            "衰神"});
            this.CB_Deity.Location = new System.Drawing.Point(151, 10);
            this.CB_Deity.Name = "CB_Deity";
            this.CB_Deity.Size = new System.Drawing.Size(121, 20);
            this.CB_Deity.TabIndex = 7;
            // 
            // CB_Event
            // 
            this.CB_Event.FormattingEnabled = true;
            this.CB_Event.Items.AddRange(new object[] {
            "Player",
            "World"});
            this.CB_Event.Location = new System.Drawing.Point(151, 38);
            this.CB_Event.Name = "CB_Event";
            this.CB_Event.Size = new System.Drawing.Size(121, 20);
            this.CB_Event.TabIndex = 8;
            // 
            // CB_Bank
            // 
            this.CB_Bank.AutoSize = true;
            this.CB_Bank.Location = new System.Drawing.Point(151, 68);
            this.CB_Bank.Name = "CB_Bank";
            this.CB_Bank.Size = new System.Drawing.Size(48, 16);
            this.CB_Bank.TabIndex = 9;
            this.CB_Bank.Text = "银行";
            this.CB_Bank.UseVisualStyleBackColor = true;
            // 
            // Lb_ESLoc
            // 
            this.Lb_ESLoc.AutoSize = true;
            this.Lb_ESLoc.Location = new System.Drawing.Point(149, 97);
            this.Lb_ESLoc.Name = "Lb_ESLoc";
            this.Lb_ESLoc.Size = new System.Drawing.Size(29, 12);
            this.Lb_ESLoc.TabIndex = 10;
            this.Lb_ESLoc.Text = "null";
            // 
            // GridSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 306);
            this.Controls.Add(this.Lb_ESLoc);
            this.Controls.Add(this.CB_Bank);
            this.Controls.Add(this.CB_Event);
            this.Controls.Add(this.CB_Deity);
            this.Controls.Add(this.Lb_Estate);
            this.Controls.Add(this.Lb_Bank);
            this.Controls.Add(this.Lb_Event);
            this.Controls.Add(this.Lb_Deity);
            this.Controls.Add(this.Bt_Cancel);
            this.Controls.Add(this.Bt_OK);
            this.Name = "GridSettings";
            this.Text = "GridSettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bt_OK;
        private System.Windows.Forms.Button Bt_Cancel;
        private System.Windows.Forms.Label Lb_Deity;
        private System.Windows.Forms.Label Lb_Event;
        private System.Windows.Forms.Label Lb_Bank;
        private System.Windows.Forms.Label Lb_Estate;
        private System.Windows.Forms.ComboBox CB_Deity;
        private System.Windows.Forms.ComboBox CB_Event;
        private System.Windows.Forms.CheckBox CB_Bank;
        private System.Windows.Forms.Label Lb_ESLoc;
    }
}