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

namespace Windows_Contact_Tracing_Records_Viewer
{
    public partial class WindowsContactTracingRecordsViewer : Form
    {
        public WindowsContactTracingRecordsViewer()
        {
            InitializeComponent();
        }

        private void BtnCheckRecord_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "txt Files (*.txt) | *.txt";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Data.Text = File.ReadAllText(ofd.FileName);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Are you sure you want to close this window?", "Windows Contact Tracing Records Viewer",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (iExit == DialogResult.OK)
            {
                Application.Exit();
            }

            else if (iExit == DialogResult.Cancel)
            {
                return;
            }
        }

        private void BtnClearData_Click(object sender, EventArgs e)
        {
            Data.Clear();
        }
    }
}
