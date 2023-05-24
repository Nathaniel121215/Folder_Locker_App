using Bunifu.Framework.UI;
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
    public partial class Account_Management_Form : Form
    {

        private const string FirebaseProjectId = "lockerdata-e9e3e";
        FireSharp.Config.FirebaseConfig _config = new FireSharp.Config.FirebaseConfig
        {
            AuthSecret = "9YNo57rimM5AGM7iqRSmTvzaH26sFuzStdnixvz5",
            BasePath = "https://lockerdata-e9e3e-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient _firebaseClient;

        public static string STATUS = "";

        public Account_Management_Form()
        {
            InitializeComponent();
            _firebaseClient = new FireSharp.FirebaseClient(_config);
        }

        private void Account_Management_Form_Load(object sender, EventArgs e)
        {
            STATUS = "";
            _firebaseClient = new FireSharp.FirebaseClient(_config);
            labeltest.Select();

            usertxt.Text = Folderlocker_Form.LOGINUSER;
            passtxt.Text = Folderlocker_Form.LOGINPASS;
            numbertxt.Text = Folderlocker_Form.LOGINNUMBER;
            emailtxt.Text = Folderlocker_Form.LOGINEMAIL;
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if(usertxt.Text !="" && passtxt.Text != "" && numbertxt.Text != "")
                {
                    var data = new User_Class
                    {

                        User_ID = Folderlocker_Form.LOGINUSERID,
                        Username = usertxt.Text,
                        Password = passtxt.Text,
                        Number = numbertxt.Text,
                        Date_Added = Folderlocker_Form.LOGINDATE,
                        Email = emailtxt.Text,
                        UserLevel = Folderlocker_Form.LOGINLEVEL,

                    };

                    FirebaseResponse response = _firebaseClient.Update("Accounts/" + data.User_ID, data);

                    this.Hide();
                    STATUS = "SUCCESS";

                }
                else
                {
                    MessageBox.Show("Fill all necessary fields correctly.");
                }

            }
            catch
            {

            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
