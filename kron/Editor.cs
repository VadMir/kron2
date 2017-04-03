using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace kron
{
    public partial class Editor : DockContent
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public Editor()
        {
            InitializeComponent();
        }

        private void Editor_Load(object sender, EventArgs e)
        {
            xmlStore1.DirectoryName = @"C:\Users\Public\Documents\NShape\Demo Projects";
            xmlStore1.FileExtension = "nspj";
            project1.Name = "Circles";
            project1.LibrarySearchPaths.Add(@"C:\Users\Public\Documents\NShape\bin\Debug");
            project1.AutoLoadLibraries = true;
            project1.Open();
            display1.LoadDiagram("Diagram 1");

            logger.Trace("Sample trace message");
            logger.Debug("Sample debug message");
            logger.Info("Sample informational message");

            int k = 42;
            int l = 100;
            logger.Trace("Sample trace message, k={0}, l={1}", k, l);
            logger.Debug("Sample debug message, k={0}, l={1}", k, l);
            logger.Info("Sample informational message, k={0}, l={1}", k, l);
        }
    }
}
