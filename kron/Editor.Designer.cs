namespace kron
{
    partial class Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            Dataweb.NShape.RoleBasedSecurityManager roleBasedSecurityManager1 = new Dataweb.NShape.RoleBasedSecurityManager();
            this.cachedRepository2 = new Dataweb.NShape.Advanced.CachedRepository();
            this.xmlStore2 = new Dataweb.NShape.XmlStore();
            this.diagramSetController2 = new Dataweb.NShape.Controllers.DiagramSetController();
            this.project2 = new Dataweb.NShape.Project(this.components);
            this.display2 = new Dataweb.NShape.WinFormsUI.Display();
            this.SuspendLayout();
            // 
            // cachedRepository2
            // 
            this.cachedRepository2.ProjectName = null;
            this.cachedRepository2.Store = this.xmlStore2;
            this.cachedRepository2.Version = 0;
            // 
            // xmlStore2
            // 
            this.xmlStore2.DesignFileName = "";
            this.xmlStore2.DirectoryName = "";
            this.xmlStore2.FileExtension = ".xml";
            this.xmlStore2.ImageLocation = Dataweb.NShape.XmlStore.ImageFileLocation.Directory;
            this.xmlStore2.ProjectFilePath = ".xml";
            this.xmlStore2.ProjectName = "";
            // 
            // diagramSetController2
            // 
            this.diagramSetController2.ActiveTool = null;
            this.diagramSetController2.Project = this.project2;
            // 
            // project2
            // 
            this.project2.Description = null;
            this.project2.LibrarySearchPaths = ((System.Collections.Generic.IList<string>)(resources.GetObject("project2.LibrarySearchPaths")));
            this.project2.Name = null;
            this.project2.Repository = this.cachedRepository2;
            roleBasedSecurityManager1.CurrentRole = Dataweb.NShape.StandardRole.Administrator;
            roleBasedSecurityManager1.CurrentRoleName = "Administrator";
            this.project2.SecurityManager = roleBasedSecurityManager1;
            // 
            // display2
            // 
            this.display2.AllowDrop = true;
            this.display2.BackColorGradient = System.Drawing.SystemColors.Control;
            this.display2.DiagramSetController = this.diagramSetController2;
            this.display2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.display2.GridColor = System.Drawing.Color.Gainsboro;
            this.display2.GridSize = 19;
            this.display2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.display2.Location = new System.Drawing.Point(0, 0);
            this.display2.Name = "display2";
            this.display2.PropertyController = null;
            this.display2.SelectionHilightColor = System.Drawing.Color.Firebrick;
            this.display2.SelectionInactiveColor = System.Drawing.Color.Gray;
            this.display2.SelectionInteriorColor = System.Drawing.Color.WhiteSmoke;
            this.display2.SelectionNormalColor = System.Drawing.Color.DarkGreen;
            this.display2.Size = new System.Drawing.Size(836, 302);
            this.display2.TabIndex = 0;
            this.display2.ToolPreviewBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))), ((int)(((byte)(153)))));
            this.display2.ToolPreviewColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            // 
            // Editor
            // 
            this.ClientSize = new System.Drawing.Size(836, 302);
            this.Controls.Add(this.display2);
            this.Name = "Editor";
            this.Load += new System.EventHandler(this.Editor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Dataweb.NShape.Advanced.CachedRepository cachedRepository2;
        private Dataweb.NShape.Controllers.DiagramSetController diagramSetController2;
        private Dataweb.NShape.WinFormsUI.Display display2;
        private Dataweb.NShape.XmlStore xmlStore2;
        private Dataweb.NShape.Project project2;
    }
}