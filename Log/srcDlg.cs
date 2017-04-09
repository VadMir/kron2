using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Log
{
    public partial class srcDlg : Form
    {
        public Dictionary<string, bool> src;
        public srcDlg(Dictionary<string, bool> src)
        {
            InitializeComponent();
            this.src = src;
        }

        private void srcDlg_Load(object sender, EventArgs e)
        {
            BeginInvoke(new Action(() => { 
            lbSrc.Items.Clear();
            foreach (var item in src)
            {
                lbSrc.Items.Add(item.Key, item.Value);
            }
            }));
        }

        private void lbSrc_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (lbSrc.SelectedItem!=null)  src[lbSrc.SelectedItem.ToString()] = e.NewValue.Equals(CheckState.Checked);
         }
    }
}
