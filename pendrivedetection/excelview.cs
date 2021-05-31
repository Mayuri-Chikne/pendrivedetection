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
using ExcelDataReader;


namespace pendrivedetection
{
    public partial class excelview : Form
    {
        public excelview()
        {
            InitializeComponent();
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fil = new OpenFileDialog();
            fil.ShowDialog();
            string path = fil.FileName.ToString();
            excelfilereader(path);
            

        }
        public void excelfilereader(string path)
        {
            var stream = File.Open(path, FileMode.Open, FileAccess.Read);
            var reader = ExcelReaderFactory.CreateReader(stream);
            var result = reader.AsDataSet();
            var tables = result.Tables.Cast<DataTable>();
            foreach (DataTable table in tables)
            { dataGridView1.DataSource = table;
            }
        }

        private void excelview_Load(object sender, EventArgs e)
        {

        }
    }
}
