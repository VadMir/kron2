using System;
using NLog;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Text;
using System.Collections.Generic;
using System.Drawing;
using WeifenLuo.WinFormsUI.Docking;
using System.Windows.Forms;
namespace Log
{
    public partial class Log : DockContent, kron_dev.kron_Docking
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();

        public static bool stopAllThreads = false;
        /// <summary>
        ///  Хранит флаги уровней логов
        /// </summary>
        int logLvl = 0;
        /// <summary>
        /// Список источников логов
        /// </summary>
        Dictionary<string,bool> log_sources = new Dictionary<string, bool>();


        public Log()
        {
            InitializeComponent();


        }
        /// <summary>
        /// Добавляет сообщение в лог
        /// </summary>
        /// <param name="mes"> Строка-сообщение</param>
        public void addMessage(string mes)
        {
            string[] tokens = mes.Split('|');
            if (!log_sources.ContainsKey(tokens[2])) log_sources.Add(tokens[2], true);

            if (!log_sources[tokens[2]]) return;

                Color selColor = Color.White;
            if (tokens[1].ToUpper().Trim() == NLog.LogLevel.Trace.Name.ToUpper()) { selColor = Color.Pink; if ((logLvl & 1) == 0) return; }
            if (tokens[1].ToUpper().Trim() == NLog.LogLevel.Debug.Name.ToUpper()) { selColor = Color.LightBlue; if ((logLvl >> 1 & 1) == 0) return; }
            if (tokens[1].ToUpper().Trim() == NLog.LogLevel.Info.Name.ToUpper()) { selColor = Color.LightGreen; if ((logLvl>>2 & 1) == 0) return;     }
            if (tokens[1].ToUpper().Trim() == NLog.LogLevel.Warn.Name.ToUpper()) { selColor = Color.Yellow; if ((logLvl>>3 & 1) == 0) return;      }
            if (tokens[1].ToUpper().Trim() == NLog.LogLevel.Error.Name.ToUpper()) { selColor = Color.Red; if ((logLvl>>4 & 1) == 0) return;      }
            if (tokens[1].ToUpper().Trim() == NLog.LogLevel.Fatal.Name.ToUpper()) { selColor = Color.Magenta; if ((logLvl>>5 & 1) == 0) return;       }

            BeginInvoke(new Action(() => {
                rtbLog.AppendText(tokens[0]+ "|");

                int currentPos = rtbLog.Text.Length;
                rtbLog.AppendText(tokens[1] + "|");
                rtbLog.Select(currentPos, rtbLog.Text.Length- currentPos-1);
                rtbLog.SelectionBackColor = selColor;
                rtbLog.SelectionFont = new Font(rtbLog.Font, FontStyle.Bold);

                currentPos = rtbLog.Text.Length ;
                rtbLog.AppendText(tokens[2] + "|");
               

                currentPos = rtbLog.Text.Length ;
                rtbLog.AppendText(tokens[3] + "\r\n");
                rtbLog.Select(currentPos, rtbLog.Text.Length - currentPos - 1);
                
                rtbLog.SelectionFont = new Font(rtbLog.Font, FontStyle.Bold);
                
            })) ;
            

        }

        private void tbLvl_click(object sender, EventArgs e)
        {
            logLvl = 0;
            logLvl += Convert.ToByte(tbTrace.Checked);
            logLvl += Convert.ToByte(tbDebug.Checked)<<1;
            logLvl += Convert.ToByte(tbInfo.Checked) << 2;
            logLvl += Convert.ToByte(tbWarning.Checked) << 3;
            logLvl += Convert.ToByte(tbError.Checked) << 4;
            logLvl += Convert.ToByte(tbFatal.Checked) << 5; 
        }

        private void choose_src(object sender, EventArgs e)
        {
            new srcDlg(log_sources).ShowDialog();
           
        }
        public  bool start()
        { return true; }
        public  bool stop()
        {
            stopAllThreads = true;
            return true; }
        public  bool init()
        {
            tbLvl_click(null, null);
            Task.Run(async () =>
            {
                using (var udpClient = new UdpClient(4001))
                {
                    logger.Info("Логгер {0} инициализирован",logger.Name);
                    while (!stopAllThreads)
                    {
                        var receivedResults = await udpClient.ReceiveAsync();
                        addMessage(Encoding.UTF8.GetString(receivedResults.Buffer));
                    }
                    logger.Info("Логгер {1} остановлен", logger.Name);
                    udpClient.Close();
                    
                }
            });
            
            return true;
        }
    }
    
}
