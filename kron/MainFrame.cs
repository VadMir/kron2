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
using System.Threading;
using System.Net.Sockets;
using System.Net;

namespace kron
{

    public partial class MainFrame : Form
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();
        public static bool stopAllThreads = false;

        DockPanel dockPanel;
        Editor graph;
        Toolbox tools;
        Log.Log log;
       
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

            this.log = new Log.Log();
            log.Text = "dddddddddd";
            log.Show(this.dockPanel, DockState.DockBottom);
            if (log.init()) { }
            //logger.Info("Модуль логгера инициализирован");
            //else   logger.Error("Ошибка инициализации модуля логгера");

            this.tools = new Toolbox();
            tools.Text = "Типы объектов";
            tools.Show(this.dockPanel, DockState.DockLeft);
            ///////////////////////////////

           
            new Thread(new ThreadStart(new Action(() =>
            {
                while (!stopAllThreads)
                {
                    logger.Log(LogLevel.Debug, "debug mes");
                    logger.Log(LogLevel.Trace, "debug mes");
                    Thread.Sleep(500);
                    logger.Log(LogLevel.Info, "info mes");
                    logger.Log(LogLevel.Warn, "inhhhfo mes");
                    logger.Log(LogLevel.Error, "info mes");
                    logger.Log(LogLevel.Fatal, "info mes");
                    Thread.Sleep(500);
                }
            }))).Start();
        }

        private void MainFrame_FormClosing(object sender, FormClosingEventArgs e)
        {
            stopAllThreads = true;
            log.stop();
        }
      
    }
}
