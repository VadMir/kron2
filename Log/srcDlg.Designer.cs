namespace Log
{
    partial class srcDlg
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
            this.lbSrc = new System.Windows.Forms.CheckedListBox();
            this.bOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSrc
            // 
            this.lbSrc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbSrc.FormattingEnabled = true;
            this.lbSrc.Items.AddRange(new object[] {
            "",
            "sdc",
            "sdc",
            "s",
            "dc"});
            this.lbSrc.Location = new System.Drawing.Point(12, 12);
            this.lbSrc.Name = "lbSrc";
            this.lbSrc.Size = new System.Drawing.Size(274, 240);
            this.lbSrc.TabIndex = 0;
            this.lbSrc.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lbSrc_ItemCheck);
            // 
            // bOK
            // 
            this.bOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOK.Location = new System.Drawing.Point(211, 284);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(75, 23);
            this.bOK.TabIndex = 1;
            this.bOK.Text = "ОК";
            this.bOK.UseVisualStyleBackColor = true;
            // 
            // srcDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 319);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.lbSrc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "srcDlg";
            this.Text = "Источники сообщений";
            this.Load += new System.EventHandler(this.srcDlg_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox lbSrc;
        private System.Windows.Forms.Button bOK;
    }
}