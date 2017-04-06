using System;
using WeifenLuo.WinFormsUI.Docking;
using NLog.LogReceiverService;
namespace kron
{
    public partial class Log : DockContent
    {
        public Log()
        {
            InitializeComponent();

            int all=0;
            foreach(NLog.LogLevel ll in NLog.LogLevel.AllLevels)
            {
                if (ll == NLog.LogLevel.Off) {

                   all= ccbLogLevel.Items.Add("Все");

                }
                else
                {
                    ccbLogLevel.Items.Add(ll);
                }
            }
           
            ccbLogLevel.SetItemChecked(all, true);
      
        }
        public  void addMessage(string mes) 
        {
            string[] tokens = mes.Split('|');
            int idMesSrc = ccbMesSrc.FindString(tokens[2]);
            int idMesLvl = ccbLogLevel.FindString(tokens[1]);
            int idAllLvl = ccbLogLevel.FindString("Все");
            this.BeginInvoke(new Action(() => {
                if (idMesSrc<0)
                {
                    ccbMesSrc.SetItemChecked(ccbMesSrc.Items.Add(tokens[2]),true);
                }
                else
                {
                    if (!ccbMesSrc.GetItemChecked(idMesSrc)) return;
                }
                if (idAllLvl > -1)
                    if (ccbLogLevel.GetItemChecked(idAllLvl))
                    {
                        rtbLog.AppendText(mes + "\r\n");
                        return;
                    }

                if (idMesLvl>-1)
                if (!ccbLogLevel.GetItemChecked(idMesLvl)) return;

                rtbLog.AppendText(mes+"\r\n");
            }));
                                                              
        }

     
    }
    
}
