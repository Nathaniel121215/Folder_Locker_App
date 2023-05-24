using System;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Twilio;
using Twilio.Rest.Verify.V2.Service;
using FireSharp.Extensions;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using Twilio.TwiML.Voice;
using Firebase.Auth;
using Google.Apis.Logging;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Newpassword_Form : Form
    {
        private const string FirebaseProjectId = "lockerdata-e9e3e";
        FireSharp.Config.FirebaseConfig _config = new FireSharp.Config.FirebaseConfig
        {
            AuthSecret = "9YNo57rimM5AGM7iqRSmTvzaH26sFuzStdnixvz5",
            BasePath = "https://lockerdata-e9e3e-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient _firebaseClient;

        public Newpassword_Form()
        {
            InitializeComponent();
            _firebaseClient = new FireSharp.FirebaseClient(_config);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (pass1txt.Text != "" && pass2txt.Text != "" && pass1txt.Text == pass2txt.Text)
                {
                    var data = new User_Class
                    {

                        User_ID = Otp_Form.FORGOTUSERID,
                        Username = Otp_Form.FORGOTUSER,
                        Password = pass1txt.Text,
                        Number = Otp_Form.FORGOTNUMBER,
                        Date_Added = Otp_Form.FORGOTDATE,
                        Email = Otp_Form.FORGOTEMAIL,
                        UserLevel = Otp_Form.LEVEL,

                    };

                    FirebaseResponse response = _firebaseClient.Update("Accounts/" + data.User_ID, data);

                    Form1 a = new Form1();
                    this.Hide();
                    a.Show();

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

        private void Newpassword_Form_Load(object sender, EventArgs e)
        {
            _firebaseClient = new FireSharp.FirebaseClient(_config);
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            this.Hide();
            a.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            this.Hide();
            a.Show();
        }
    }
}
