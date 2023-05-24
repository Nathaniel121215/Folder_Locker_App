using FireSharp.Interfaces;
using FireSharp.Response;
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
        DataTable dt = new DataTable();

        private const string FirebaseProjectId = "lockerdata-e9e3e";
        FireSharp.Config.FirebaseConfig _config = new FireSharp.Config.FirebaseConfig
        {
            AuthSecret = "9YNo57rimM5AGM7iqRSmTvzaH26sFuzStdnixvz5",
            BasePath = "https://lockerdata-e9e3e-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient _firebaseClient;
        public LogsModule_Form()
        {
            InitializeComponent();
            _firebaseClient = new FireSharp.FirebaseClient(_config);
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

        private void LogsModule_Form_Load(object sender, EventArgs e)
        {
            _firebaseClient = new FireSharp.FirebaseClient(_config);

            dt.Columns.Add("Log ID");
            dt.Columns.Add("Module");
            dt.Columns.Add("Action");
            dt.Columns.Add("Date");
            dt.Columns.Add("Username");



            this.Folder_Datagrid.AllowUserToAddRows = false;

            Folder_Datagrid.DataSource = dt;

            dataview();
            

        }

        public async void dataview()
        {





            foreach (DataGridViewColumn column in Folder_Datagrid.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            dt.Rows.Clear();

            int i = 0;
            FirebaseResponse resp = await _firebaseClient.GetTaskAsync("Folder_Counter/node");
            Account_Counter_Number obj = resp.ResultAs<Account_Counter_Number>();
            int cnt = Convert.ToInt32(obj.cnt);

            while (true)
            {
                if (i == cnt)
                {
                    break;
                }

                i++;
                try
                {
                    FirebaseResponse resp1 = await _firebaseClient.GetTaskAsync("Logs/" + i);
                    Log_Class act = resp1.ResultAs<Log_Class>();

                    DataRow r = dt.NewRow();

                    r["Log ID"] = act.Log_ID;
                    r["Module"] = act.Module;
                    r["Action"] = act.Action;
                    r["Date"] = act.Date_Added;
                    r["Username"] = act.Username;


                    dt.Rows.Add(r);

                    DataView dv = dt.DefaultView;
                    dv.RowFilter = $"Username = '{Folderlocker_Form.LOGINUSER}'";

                }

                catch
                {

                }


            }





        }

    }
}
