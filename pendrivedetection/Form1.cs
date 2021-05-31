using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pendrivedetection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var drives = DriveInfo.GetDrives().Where(d => d.IsReady & d.DriveType == DriveType.Removable);
            if (drives.FirstOrDefault() != null)
            {
                labeldriveformat.Text = "Drive Format : " + drives.FirstOrDefault().DriveFormat.ToString();
                labeldrivetype.Text = "Drive Type : " + drives.FirstOrDefault().DriveType.ToString();
                labelfreespace.Text = "Free Space : " + drives.FirstOrDefault().TotalFreeSpace.ToString();
                labelisready.Text = "Is Ready : " + drives.FirstOrDefault().IsReady.ToString();
                labelname.Text = "Name : " + drives.FirstOrDefault().Name.ToString();
                labeltotalspace.Text = "Total Space : " + drives.FirstOrDefault().TotalSize.ToString();
            }
            else
            {
                MessageBox.Show("Pendrive Not Connected...");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            excelview ex = new excelview();
            ex.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

           
        }
    }
}
