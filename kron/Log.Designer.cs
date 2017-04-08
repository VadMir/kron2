namespace kron
{
    partial class Log
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log));
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.kuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbTrace = new System.Windows.Forms.ToolStripButton();
            this.tbDebug = new System.Windows.Forms.ToolStripButton();
            this.tbInfo = new System.Windows.Forms.ToolStripButton();
            this.tbWarning = new System.Windows.Forms.ToolStripButton();
            this.tbError = new System.Windows.Forms.ToolStripButton();
            this.tbFatal = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbLog
            // 
            this.rtbLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbLog.Location = new System.Drawing.Point(0, 0);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.Size = new System.Drawing.Size(739, 231);
            this.rtbLog.TabIndex = 0;
            this.rtbLog.Text = "";
            // 
            // kuToolStripMenuItem
            // 
            this.kuToolStripMenuItem.Name = "kuToolStripMenuItem";
            this.kuToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kuToolStripMenuItem.Text = "ku";
            // 
            // uikToolStripMenuItem
            // 
            this.uikToolStripMenuItem.Name = "uikToolStripMenuItem";
            this.uikToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.uikToolStripMenuItem.Text = "uik";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "alert.png");
            this.imageList1.Images.SetKeyName(1, "debug.png");
            this.imageList1.Images.SetKeyName(2, "fatal.png");
            this.imageList1.Images.SetKeyName(3, "info-2-xxl.png");
            this.imageList1.Images.SetKeyName(4, "trace.png");
            this.imageList1.Images.SetKeyName(5, "warning.png");
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.rtbLog);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(739, 231);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(739, 256);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbTrace,
            this.tbDebug,
            this.tbInfo,
            this.tbWarning,
            this.tbError,
            this.tbFatal,
            this.toolStripSeparator1,
            this.toolStripButton7,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.toolStripTextBox1});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(464, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // tbTrace
            // 
            this.tbTrace.Checked = true;
            this.tbTrace.CheckOnClick = true;
            this.tbTrace.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbTrace.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbTrace.Image = ((System.Drawing.Image)(resources.GetObject("tbTrace.Image")));
            this.tbTrace.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbTrace.Name = "tbTrace";
            this.tbTrace.Size = new System.Drawing.Size(23, 22);
            this.tbTrace.Text = "toolStripButton1";
            this.tbTrace.ToolTipText = "TRACE";
            this.tbTrace.Click += new System.EventHandler(this.tbLvl_click);
            // 
            // tbDebug
            // 
            this.tbDebug.Checked = true;
            this.tbDebug.CheckOnClick = true;
            this.tbDebug.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbDebug.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbDebug.Image = ((System.Drawing.Image)(resources.GetObject("tbDebug.Image")));
            this.tbDebug.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbDebug.Name = "tbDebug";
            this.tbDebug.Size = new System.Drawing.Size(23, 22);
            this.tbDebug.Text = "toolStripButton1";
            this.tbDebug.ToolTipText = "DEBUG";
            this.tbDebug.Click += new System.EventHandler(this.tbLvl_click);
            // 
            // tbInfo
            // 
            this.tbInfo.Checked = true;
            this.tbInfo.CheckOnClick = true;
            this.tbInfo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbInfo.Image = ((System.Drawing.Image)(resources.GetObject("tbInfo.Image")));
            this.tbInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Size = new System.Drawing.Size(23, 22);
            this.tbInfo.Text = "toolStripButton1";
            this.tbInfo.ToolTipText = "INFO";
            this.tbInfo.Click += new System.EventHandler(this.tbLvl_click);
            // 
            // tbWarning
            // 
            this.tbWarning.Checked = true;
            this.tbWarning.CheckOnClick = true;
            this.tbWarning.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbWarning.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbWarning.Image = ((System.Drawing.Image)(resources.GetObject("tbWarning.Image")));
            this.tbWarning.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbWarning.Name = "tbWarning";
            this.tbWarning.Size = new System.Drawing.Size(23, 22);
            this.tbWarning.Text = "toolStripButton1";
            this.tbWarning.ToolTipText = "WARNING";
            this.tbWarning.Click += new System.EventHandler(this.tbLvl_click);
            // 
            // tbError
            // 
            this.tbError.Checked = true;
            this.tbError.CheckOnClick = true;
            this.tbError.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbError.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbError.Image = ((System.Drawing.Image)(resources.GetObject("tbError.Image")));
            this.tbError.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbError.Name = "tbError";
            this.tbError.Size = new System.Drawing.Size(23, 22);
            this.tbError.Text = "toolStripButton1";
            this.tbError.ToolTipText = "ERROR";
            this.tbError.Click += new System.EventHandler(this.tbLvl_click);
            // 
            // tbFatal
            // 
            this.tbFatal.Checked = true;
            this.tbFatal.CheckOnClick = true;
            this.tbFatal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbFatal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbFatal.Image = ((System.Drawing.Image)(resources.GetObject("tbFatal.Image")));
            this.tbFatal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbFatal.Name = "tbFatal";
            this.tbFatal.Size = new System.Drawing.Size(23, 22);
            this.tbFatal.Text = "toolStripButton1";
            this.tbFatal.ToolTipText = "FATAL";
            this.tbFatal.Click += new System.EventHandler(this.tbLvl_click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(65, 22);
            this.toolStripButton7.Text = "Источник";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(54, 22);
            this.toolStripLabel1.Text = "Признак";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(150, 25);
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 256);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "Log";
            this.Text = "Log";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.ToolStripMenuItem kuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uikToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbTrace;
        private System.Windows.Forms.ToolStripButton tbDebug;
        private System.Windows.Forms.ToolStripButton tbInfo;
        private System.Windows.Forms.ToolStripButton tbWarning;
        private System.Windows.Forms.ToolStripButton tbError;
        private System.Windows.Forms.ToolStripButton tbFatal;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
    }
}