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

    public partial class MainFrame :  Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        DockPanel dockPanel;
        Editor graph;
        Toolbox tools;
        Log log;
        public MainFrame()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            ///////////////// Dock Pannels 

            this.dockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.dockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Controls.Add(this.dockPanel);
            this.graph = new Editor();
            graph.Text = "dddddddddd";
            graph.Show(this.dockPanel, DockState.Document);

            this.log = new Log();
            log.Text = "dddddddddd";
            log.Show(this.dockPanel, DockState.DockBottomAutoHide);

            this.tools = new Toolbox();
            tools.Text = "Типы объектов";
            tools.Show(this.dockPanel, DockState.DockLeft);
///////////////////////////////

//////////////// Start Log Service//////////////////
//void 
///////////////////////////////////////////////////
        }
    }

}
