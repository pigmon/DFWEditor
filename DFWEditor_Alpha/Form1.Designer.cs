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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_New = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_ShowGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_AreaBrush = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_DefaultPath = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Bt_AddGrid = new System.Windows.Forms.ToolStripButton();
            this.Bt_Land = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.MainPanel = new DFWEditor_Alpha.DoubleBufferedPanel();
            this.Dlg_OpenMap = new System.Windows.Forms.OpenFileDialog();
            this.Dlg_DefaultPath = new System.Windows.Forms.FolderBrowserDialog();
            this.Menu_Del = new System.Windows.Forms.ToolStripMenuItem();
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
            this.Menu_New.Click += new System.EventHandler(this.Menu_New_Click);
            // 
            // Menu_Open
            // 
            this.Menu_Open.Name = "Menu_Open";
            this.Menu_Open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.Menu_Open.Size = new System.Drawing.Size(147, 22);
            this.Menu_Open.Text = "打开";
            this.Menu_Open.Click += new System.EventHandler(this.Menu_Open_Click);
            // 
            // Menu_Save
            // 
            this.Menu_Save.Name = "Menu_Save";
            this.Menu_Save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.Menu_Save.Size = new System.Drawing.Size(147, 22);
            this.Menu_Save.Text = "保存";
            this.Menu_Save.Click += new System.EventHandler(this.Menu_Save_Click);
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
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Del});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_ShowGrid,
            this.Menu_AreaBrush,
            this.Menu_DefaultPath});
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
            // Menu_DefaultPath
            // 
            this.Menu_DefaultPath.Name = "Menu_DefaultPath";
            this.Menu_DefaultPath.Size = new System.Drawing.Size(176, 22);
            this.Menu_DefaultPath.Text = "设置默认存储路径";
            this.Menu_DefaultPath.Click += new System.EventHandler(this.Menu_DefaultPath_Click);
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
            this.TB_AreaBrush,
            this.toolStripSeparator2,
            this.Bt_AddGrid,
            this.Bt_Land});
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
            this.TB_New.Click += new System.EventHandler(this.TB_New_Click);
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
            this.TB_Save.Click += new System.EventHandler(this.TB_Save_Click);
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
            this.TB_Del.Click += new System.EventHandler(this.TB_Del_Click);
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // Bt_AddGrid
            // 
            this.Bt_AddGrid.AutoSize = false;
            this.Bt_AddGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Bt_AddGrid.CheckOnClick = true;
            this.Bt_AddGrid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Bt_AddGrid.Image = global::DFWEditor_Alpha.Properties.Resources.NavPoint;
            this.Bt_AddGrid.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Bt_AddGrid.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Bt_AddGrid.Name = "Bt_AddGrid";
            this.Bt_AddGrid.Size = new System.Drawing.Size(32, 32);
            this.Bt_AddGrid.Text = "toolStripButton1";
            this.Bt_AddGrid.ToolTipText = "路格";
            this.Bt_AddGrid.CheckedChanged += new System.EventHandler(this.Bt_AddGrid_CheckedChanged);
            // 
            // Bt_Land
            // 
            this.Bt_Land.AutoSize = false;
            this.Bt_Land.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_Land.CheckOnClick = true;
            this.Bt_Land.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Bt_Land.Image = ((System.Drawing.Image)(resources.GetObject("Bt_Land.Image")));
            this.Bt_Land.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Bt_Land.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Bt_Land.Name = "Bt_Land";
            this.Bt_Land.Size = new System.Drawing.Size(32, 32);
            this.Bt_Land.Text = "toolStripButton1";
            this.Bt_Land.ToolTipText = "土地";
            this.Bt_Land.CheckedChanged += new System.EventHandler(this.bt_Land_CheckedChanged);
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
            this.splitContainer1.Panel1.SizeChanged += new System.EventHandler(this.splitContainer1_Panel1_SizeChanged);
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
            // MainPanel
            // 
            this.MainPanel.AutoScroll = true;
            this.MainPanel.BackColor = System.Drawing.SystemColors.Window;
            this.MainPanel.Location = new System.Drawing.Point(3, 3);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(2048, 2048);
            this.MainPanel.TabIndex = 0;
            this.MainPanel.MouseLeave += new System.EventHandler(this.MainPanel_MouseLeave);
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.MainPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseUp);
            // 
            // Dlg_OpenMap
            // 
            this.Dlg_OpenMap.Filter = "关卡文件 *.map|*.map";
            this.Dlg_OpenMap.FileOk += new System.ComponentModel.CancelEventHandler(this.Dlg_OpenMap_FileOk);
            // 
            // Dlg_DefaultPath
            // 
            this.Dlg_DefaultPath.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // Menu_Del
            // 
            this.Menu_Del.Name = "Menu_Del";
            this.Menu_Del.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.Menu_Del.Size = new System.Drawing.Size(152, 22);
            this.Menu_Del.Text = "删除";
            this.Menu_Del.Click += new System.EventHandler(this.Menu_Del_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
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
        private DoubleBufferedPanel MainPanel;
        private System.Windows.Forms.OpenFileDialog Dlg_OpenMap;
        private System.Windows.Forms.FolderBrowserDialog Dlg_DefaultPath;
        private System.Windows.Forms.ToolStripMenuItem Menu_DefaultPath;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton Bt_AddGrid;
        private System.Windows.Forms.ToolStripButton Bt_Land;
        private System.Windows.Forms.ToolStripMenuItem Menu_Del;
    }
}

