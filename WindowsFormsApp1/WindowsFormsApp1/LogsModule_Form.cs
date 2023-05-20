using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LogsModule_Form : Form
    {
        public LogsModule_Form()
        {
            InitializeComponent();
        }

        private void Account_Logo_Click(object sender, EventArgs e)
        {
            Account_Management_Form a = new Account_Management_Form();
            a.ShowDialog();

            if (Account_Management_Form.STATUS == "SUCCESS")
            {
                Form1 b = new Form1();
                this.Hide();
                b.Show();
            }
            else
            {

            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Folderlocker_Form a = new Folderlocker_Form();
            this.Hide();
            a.Show();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            this.Hide();
            a.Show();
        }
    }
}
