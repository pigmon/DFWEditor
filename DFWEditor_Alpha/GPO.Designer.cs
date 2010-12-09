namespace DFWEditor_Alpha
{
    partial class GPO
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
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // GPO
            // 
            this.Size = new System.Drawing.Size(64, 64);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GPO_MouseMove);
            this.Click += new System.EventHandler(this.GPO_Click);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GPO_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GPO_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
