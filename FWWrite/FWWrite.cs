using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WRITE_REGINFO
{
    public partial class FWWrite : Form
    {
        public FWWrite()
        {
            InitializeComponent();
        }

        private void writebtn_Click(object sender, EventArgs e)
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey("Software", true);
            RegistryKey keyw = key.CreateSubKey(@"FirmwareInfo");  //Required, Firmware Info subkey may not exist!
            keyw.SetValue("DeviceModel", devmtb.Text);
            keyw.SetValue("DeviceCodename", devctb.Text);
            keyw.SetValue("SoftwareBuild", fbtb.Text);
            keyw.SetValue("BuildDate", fbdatetb.Text);
            MessageBox.Show("Writed", "             ");

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}