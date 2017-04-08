using System;
using WeifenLuo.WinFormsUI.Docking;
using NLog.LogReceiverService;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Text;
namespace kron
{
    public partial class Log : DockContent
    {
        int logLvl = 0;
        UdpClient udpClient;
        public Log()
        {
            InitializeComponent();
            tbLvl_click(null, null);
            Task.Run(async () =>
            {
                using (var udpClient = new UdpClient(4001))
                {
                    while (!MainFrame.stopAllThreads)
                    {
                        //IPEndPoint object will allow us to read datagrams sent from any source.
                        var receivedResults = await udpClient.ReceiveAsync();
                        addMessage(Encoding.UTF8.GetString(receivedResults.Buffer));
                    }
                    udpClient.Close();
                }
            });

        }
        public  void addMessage(string mes) 
        {
            string[] tokens = mes.Split('|');
         
            if (tokens[1].ToUpper() == NLog.LogLevel.Trace.Name.ToUpper()) if ((logLvl & 1) == 0) return;
            if (tokens[1].ToUpper() == NLog.LogLevel.Debug.Name.ToUpper()) if ((logLvl>>1 & 1) == 0) return;
            if (tokens[1].ToUpper() == NLog.LogLevel.Info.Name.ToUpper()) if ((logLvl>>2 & 1) == 0) return;
            if (tokens[1].ToUpper() == NLog.LogLevel.Warn.Name.ToUpper()) if ((logLvl>>3 & 1) == 0) return;
            if (tokens[1].ToUpper() == NLog.LogLevel.Error.Name.ToUpper()) if ((logLvl>>4 & 1) == 0) return;
            if (tokens[1].ToUpper() == NLog.LogLevel.Fatal.Name.ToUpper()) if ((logLvl>>5 & 1) == 0) return;

            BeginInvoke(new Action(() => { rtbLog.AppendText(mes + "\r\n"); })) ;
            

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
    }
    
}
