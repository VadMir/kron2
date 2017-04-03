using NLog;

using System;
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
            xmlStore2.DirectoryName = @"C:\Users\Public\Documents\NShape\Demo Projects";
            xmlStore2.FileExtension = "nspj";
            project2.Name = "Circles";
            project2.LibrarySearchPaths.Add(@"C:\Users\Public\Documents\NShape\bin\Debug");
            project2.AutoLoadLibraries = true;
            project2.Open();
            display2.LoadDiagram("Diagram 1");

         
       
                        logger.Trace("trace log message");
                        logger.Debug("debug log message");
                        logger.Info("info log message");
                        logger.Warn("warn log message");
                        logger.Error("error log message");
                        logger.Fatal("fatal log message");
                        logger.Fatal("fatal log message, rather serious"); ;
        }
    }
}
