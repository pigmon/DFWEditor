namespace DFWEditor_Alpha
{
    partial class MainForm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_New = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_OpenLevel = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_OpenTexture = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_ShowGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_AreaBrush = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TB_New = new System.Windows.Forms.ToolStripButton();
            this.TB_Open = new System.Windows.Forms.ToolStripButton();
            this.TB_Save = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TB_Del = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSeparator();
            this.TB_Grid = new System.Windows.Forms.ToolStripButton();
            this.TB_AreaBrush = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Dlg_OpenTexture = new System.Windows.Forms.OpenFileDialog();
            this.MainPanel = new DFWEditor_Alpha.DoubleBufferedPanel();
            this.MainMenu.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.工具ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1264, 25);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_New,
            this.Menu_Open,
            this.Menu_Save,
            this.Menu_SaveAs,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // Menu_New
            // 
            this.Menu_New.Name = "Menu_New";
            this.Menu_New.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.Menu_New.Size = new System.Drawing.Size(147, 22);
            this.Menu_New.Text = "新建";
            // 
            // Menu_Open
            // 
            this.Menu_Open.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_OpenLevel,
            this.Menu_OpenTexture});
            this.Menu_Open.Name = "Menu_Open";
            this.Menu_Open.Size = new System.Drawing.Size(147, 22);
            this.Menu_Open.Text = "打开";
            // 
            // Menu_OpenLevel
            // 
            this.Menu_OpenLevel.Name = "Menu_OpenLevel";
            this.Menu_OpenLevel.Size = new System.Drawing.Size(124, 22);
            this.Menu_OpenLevel.Text = "关卡文件";
            // 
            // Menu_OpenTexture
            // 
            this.Menu_OpenTexture.Name = "Menu_OpenTexture";
            this.Menu_OpenTexture.Size = new System.Drawing.Size(124, 22);
            this.Menu_OpenTexture.Text = "贴图";
            this.Menu_OpenTexture.Click += new System.EventHandler(this.Menu_OpenTexture_Click);
            // 
            // Menu_Save
            // 
            this.Menu_Save.Name = "Menu_Save";
            this.Menu_Save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.Menu_Save.Size = new System.Drawing.Size(147, 22);
            this.Menu_Save.Text = "保存";
            // 
            // Menu_SaveAs
            // 
            this.Menu_SaveAs.Name = "Menu_SaveAs";
            this.Menu_SaveAs.Size = new System.Drawing.Size(147, 22);
            this.Menu_SaveAs.Text = "另存为";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_ShowGrid,
            this.Menu_AreaBrush});
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.工具ToolStripMenuItem.Text = "工具";
            // 
            // Menu_ShowGrid
            // 
            this.Menu_ShowGrid.CheckOnClick = true;
            this.Menu_ShowGrid.Name = "Menu_ShowGrid";
            this.Menu_ShowGrid.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.G)));
            this.Menu_ShowGrid.Size = new System.Drawing.Size(176, 22);
            this.Menu_ShowGrid.Text = "显示网格";
            this.Menu_ShowGrid.Click += new System.EventHandler(this.Menu_ShowGrid_Click);
            // 
            // Menu_AreaBrush
            // 
            this.Menu_AreaBrush.CheckOnClick = true;
            this.Menu_AreaBrush.Name = "Menu_AreaBrush";
            this.Menu_AreaBrush.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.Menu_AreaBrush.Size = new System.Drawing.Size(176, 22);
            this.Menu_AreaBrush.Text = "区域地形刷";
            this.Menu_AreaBrush.Click += new System.EventHandler(this.Menu_AreaBrush_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TB_New,
            this.TB_Open,
            this.TB_Save,
            this.toolStripSeparator1,
            this.TB_Del,
            this.toolStripSplitButton1,
            this.TB_Grid,
            this.TB_AreaBrush});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1264, 35);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TB_New
            // 
            this.TB_New.AutoSize = false;
            this.TB_New.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TB_New.Image = global::DFWEditor_Alpha.Properties.Resources._new;
            this.TB_New.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TB_New.Name = "TB_New";
            this.TB_New.Size = new System.Drawing.Size(32, 32);
            this.TB_New.Text = "toolStripButton1";
            this.TB_New.ToolTipText = "新建";
            // 
            // TB_Open
            // 
            this.TB_Open.AutoSize = false;
            this.TB_Open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TB_Open.Image = global::DFWEditor_Alpha.Properties.Resources.open;
            this.TB_Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TB_Open.Name = "TB_Open";
            this.TB_Open.Size = new System.Drawing.Size(32, 32);
            this.TB_Open.Text = "toolStripButton1";
            this.TB_Open.ToolTipText = "打开贴图";
            this.TB_Open.Click += new System.EventHandler(this.TB_Open_Click);
            // 
            // TB_Save
            // 
            this.TB_Save.AutoSize = false;
            this.TB_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TB_Save.Image = global::DFWEditor_Alpha.Properties.Resources.save;
            this.TB_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TB_Save.Name = "TB_Save";
            this.TB_Save.Size = new System.Drawing.Size(32, 32);
            this.TB_Save.Text = "toolStripButton1";
            this.TB_Save.ToolTipText = "保存";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // TB_Del
            // 
            this.TB_Del.AutoSize = false;
            this.TB_Del.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TB_Del.Image = global::DFWEditor_Alpha.Properties.Resources.del;
            this.TB_Del.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TB_Del.Name = "TB_Del";
            this.TB_Del.Size = new System.Drawing.Size(32, 32);
            this.TB_Del.Text = "toolStripButton1";
            this.TB_Del.ToolTipText = "删除";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(6, 35);
            // 
            // TB_Grid
            // 
            this.TB_Grid.AutoSize = false;
            this.TB_Grid.CheckOnClick = true;
            this.TB_Grid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TB_Grid.Image = global::DFWEditor_Alpha.Properties.Resources.Grid3;
            this.TB_Grid.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TB_Grid.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TB_Grid.Name = "TB_Grid";
            this.TB_Grid.Size = new System.Drawing.Size(32, 32);
            this.TB_Grid.Text = "toolStripButton1";
            this.TB_Grid.ToolTipText = "显示网格";
            this.TB_Grid.CheckedChanged += new System.EventHandler(this.TB_Grid_CheckedChanged);
            // 
            // TB_AreaBrush
            // 
            this.TB_AreaBrush.AutoSize = false;
            this.TB_AreaBrush.CheckOnClick = true;
            this.TB_AreaBrush.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TB_AreaBrush.Image = global::DFWEditor_Alpha.Properties.Resources.brushArea;
            this.TB_AreaBrush.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TB_AreaBrush.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TB_AreaBrush.Name = "TB_AreaBrush";
            this.TB_AreaBrush.Size = new System.Drawing.Size(32, 32);
            this.TB_AreaBrush.Text = "toolStripButton1";
            this.TB_AreaBrush.ToolTipText = "区域地形刷";
            this.TB_AreaBrush.CheckedChanged += new System.EventHandler(this.TB_AreaBrush_CheckedChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 60);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.splitContainer1.Panel2.Controls.Add(this.MainPanel);
            this.splitContainer1.Size = new System.Drawing.Size(1264, 622);
            this.splitContainer1.SplitterDistance = 346;
            this.splitContainer1.TabIndex = 2;
            // 
            // Dlg_OpenTexture
            // 
            this.Dlg_OpenTexture.Filter = "图像文件(*.bmp,*.png,*.gif) |*.bmp;*.png;*.gif";
            this.Dlg_OpenTexture.FileOk += new System.ComponentModel.CancelEventHandler(this.Dlg_OpenTexture_FileOk);
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.BackColor = System.Drawing.SystemColors.Window;
            this.MainPanel.Location = new System.Drawing.Point(4, 3);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(909, 618);
            this.MainPanel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.MainMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainForm";
            this.Text = "DFWEditor_Alpha";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_New;
        private System.Windows.Forms.ToolStripMenuItem Menu_Open;
        private System.Windows.Forms.ToolStripMenuItem Menu_Save;
        private System.Windows.Forms.ToolStripMenuItem Menu_SaveAs;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_ShowGrid;
        private System.Windows.Forms.ToolStripMenuItem Menu_AreaBrush;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TB_New;
        private System.Windows.Forms.ToolStripButton TB_Open;
        private System.Windows.Forms.ToolStripButton TB_Save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TB_Del;
        private System.Windows.Forms.ToolStripSeparator toolStripSplitButton1;
        private System.Windows.Forms.ToolStripButton TB_Grid;
        private System.Windows.Forms.ToolStripButton TB_AreaBrush;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem Menu_OpenLevel;
        private System.Windows.Forms.ToolStripMenuItem Menu_OpenTexture;
        private System.Windows.Forms.OpenFileDialog Dlg_OpenTexture;
        private DoubleBufferedPanel MainPanel;
    }
}

