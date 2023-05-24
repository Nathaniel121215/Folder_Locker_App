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

namespace WindowsFormsApp1
{
    public partial class Forgotpassword_Form : Form
    {

        private const string FirebaseProjectId = "lockerdata-e9e3e";
        FireSharp.Config.FirebaseConfig _config = new FireSharp.Config.FirebaseConfig
        {
            AuthSecret = "9YNo57rimM5AGM7iqRSmTvzaH26sFuzStdnixvz5",
            BasePath = "https://lockerdata-e9e3e-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient _firebaseClient;


        public Forgotpassword_Form()
        {
            InitializeComponent();
            _firebaseClient = new FireSharp.FirebaseClient(_config);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if(accounttxt.Text != null && accounttxt.Text != "")
            {
                try
                {
                    int i = 0;
                    FirebaseResponse resp = _firebaseClient.Get("Account_Counter/node");
                    Account_Counter_Number obj = resp.ResultAs<Account_Counter_Number>();
                    int cnt = Convert.ToInt32(obj.cnt);

                    while (i <= cnt)
                    {
                        if (i == cnt)
                        {
                            MessageBox.Show("Account not Found.");
                            break;

                        }
                        i++;
                        try
                        {
                            //Account DB
                            FirebaseResponse resp1 = _firebaseClient.Get("Accounts/" + i);
                            User_Class obj2 = resp1.ResultAs<User_Class>();

                            if (accounttxt.Text.ToLower() == obj2.Email.ToLower())
                            {
                                Otp_Form.FORGOTUSERID = obj2.User_ID;
                                Otp_Form.FORGOTUSER = obj2.Username;
                                Otp_Form.FORGOTPASS = obj2.Password;
                                Otp_Form.FORGOTNUMBER = obj2.Number;
                                Otp_Form.FORGOTDATE = obj2.Date_Added;
                                Otp_Form.FORGOTEMAIL = obj2.Email;
                                Otp_Form.LEVEL = obj2.UserLevel;
                                Otp_Form.OPERATION = "FORGOT";

                                Otp_Form a = new Otp_Form();
                                this.Hide();
                                a.Show();


                                break;
                            }
                            else
                            {
                                
                            }

                        }
                        catch
                        {

                        }
                    }
                }
                catch
                {

                }

            }
            else
            {
                MessageBox.Show("Fill all the necessary fields properly.");
            }
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

        private void Forgotpassword_Form_Load(object sender, EventArgs e)
        {
            _firebaseClient = new FireSharp.FirebaseClient(_config);
        }
    }
}
