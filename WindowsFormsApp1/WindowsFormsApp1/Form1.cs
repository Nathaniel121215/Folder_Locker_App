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
    public partial class Form1 : Form
    {
        private const string FirebaseProjectId = "lockerdata-e9e3e";
        FireSharp.Config.FirebaseConfig _config = new FireSharp.Config.FirebaseConfig
        {
            AuthSecret = "9YNo57rimM5AGM7iqRSmTvzaH26sFuzStdnixvz5",
            BasePath = "https://lockerdata-e9e3e-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient _firebaseClient;


        public static string loginuserid;
        public static string loginuser;
        public static string loginpass;
        public static string loginnumber;
        public static string logindateadded;
        public static string loginlevel;

        public Form1()
        {
            InitializeComponent();
            _firebaseClient = new FireSharp.FirebaseClient(_config);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _firebaseClient = new FireSharp.FirebaseClient(_config);

            bunifuCustomLabel1.Select();


            //string phoneNumber = "+639550961345"; // Replace with the user's phone number
           // string otp = GenerateOTP(); // Generate a random OTP



            //string accountSid = "ACeaed0eda4cf7d0fa091db08f8dff5840";
            //string authToken = "4c21eb4cc5aef00acdd2cba3d8fa1049";

            //TwilioClient.Init(accountSid, authToken);


           // var messageOptions = new CreateMessageOptions(
            //  new PhoneNumber("+639550961345"));
            //messageOptions.From = new PhoneNumber("+16206589589");
            //messageOptions.Body = otp;


           // var message = MessageResource.Create(messageOptions);
           // Console.WriteLine(message.Body);



            //MessageBox.Show($"OTP {otp} sent to {phoneNumber}"); // Display a message to the user
        }

   
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void usertxt_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void passtxt_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e) 
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
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

                        if(usertxt.Text == obj2.Username)
                        {
                            if (passtxt.Text == obj2.Password)
                            {
                                loginuserid = obj2.User_ID;
                                loginuser = usertxt.Text;
                                loginpass = passtxt.Text;
                                logindateadded = obj2.Date_Added;
                                loginnumber = obj2.Number;
                                loginlevel = obj2.UserLevel;

                                //MessageBox.Show("Logged in successfully");



                                Otp_Form.LOGINUSERID = loginuserid;
                                Otp_Form.LOGINUSER = loginuser;
                                Otp_Form.LOGINPASS = loginpass;
                                Otp_Form.LOGINNUMBER = loginnumber;
                                Otp_Form.LOGINDATE = logindateadded;
                                Otp_Form.LEVEL = loginlevel;
                                Otp_Form.OPERATION = "LOGIN";
                                Otp_Form a = new Otp_Form();
                                this.Hide();
                                a.Show();


                                break;
                            }

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

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Signup_Form a = new Signup_Form();
            this.Hide();
            a.Show();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            Otp_Form a = new Otp_Form();
            this.Hide();
            a.Show();
        }

        private void passtxt_Enter(object sender, EventArgs e)
        {
            passtxt.Text = "";
            passtxt.ForeColor = Color.Black;
        }

        private void passtxt_Leave(object sender, EventArgs e)
        {
            if (passtxt.Text == "")
            {
                passtxt.Text = "Password";
                passtxt.ForeColor = Color.Gray;


            }
        }

        private void usertxt_Enter(object sender, EventArgs e)
        {
            if (usertxt.Text == "Username")
            {
                usertxt.Text = "";


                usertxt.ForeColor = Color.Black;

            }
        }

        private void usertxt_Leave(object sender, EventArgs e)
        {
            if (usertxt.Text == "")
            {
                usertxt.Text = "Username";
                usertxt.ForeColor = Color.Gray;


            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Forgotpassword_Form a = new Forgotpassword_Form();
            this.Hide();
            a.Show();
        }
    }
}
