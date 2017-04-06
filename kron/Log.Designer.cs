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
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ccbLogLevel = new CheckComboBoxTest.CheckedComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ccbMesSrc = new CheckComboBoxTest.CheckedComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rtbLog
            // 
            this.rtbLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbLog.Location = new System.Drawing.Point(0, 0);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.Size = new System.Drawing.Size(739, 158);
            this.rtbLog.TabIndex = 0;
            this.rtbLog.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(739, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ccbLogLevel
            // 
            this.ccbLogLevel.CheckOnClick = true;
            this.ccbLogLevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ccbLogLevel.DropDownHeight = 1;
            this.ccbLogLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ccbLogLevel.FormattingEnabled = true;
            this.ccbLogLevel.IntegralHeight = false;
            this.ccbLogLevel.Location = new System.Drawing.Point(70, 1);
            this.ccbLogLevel.Name = "ccbLogLevel";
            this.ccbLogLevel.Size = new System.Drawing.Size(176, 21);
            this.ccbLogLevel.TabIndex = 2;
            this.ccbLogLevel.ValueSeparator = ", ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Уровень";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Источник";
            // 
            // ccbMesSrc
            // 
            this.ccbMesSrc.CheckOnClick = true;
            this.ccbMesSrc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ccbMesSrc.DropDownHeight = 1;
            this.ccbMesSrc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ccbMesSrc.FormattingEnabled = true;
            this.ccbMesSrc.IntegralHeight = false;
            this.ccbMesSrc.Location = new System.Drawing.Point(317, 2);
            this.ccbMesSrc.Name = "ccbMesSrc";
            this.ccbMesSrc.Size = new System.Drawing.Size(150, 21);
            this.ccbMesSrc.TabIndex = 5;
            this.ccbMesSrc.ValueSeparator = ", ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(473, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Признак";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(530, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 20);
            this.textBox1.TabIndex = 7;
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 158);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ccbMesSrc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ccbLogLevel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.rtbLog);
            this.Name = "Log";
            this.Text = "Log";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private CheckComboBoxTest.CheckedComboBox ccbLogLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CheckComboBoxTest.CheckedComboBox ccbMesSrc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}