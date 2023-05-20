using Firebase.Auth;
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
using Twilio.TwiML.Voice;
using Twilio.Types;


using Twilio;
using Twilio.Rest.Verify.V2.Service;
using FireSharp.Extensions;
using Twilio.Rest.Api.V2010.Account;


namespace WindowsFormsApp1
{
    public partial class Signup_Form : Form
    {
        private const string FirebaseProjectId = "lockerdata-e9e3e";
        FireSharp.Config.FirebaseConfig _config = new FireSharp.Config.FirebaseConfig
        {
            AuthSecret = "9YNo57rimM5AGM7iqRSmTvzaH26sFuzStdnixvz5",
            BasePath = "https://lockerdata-e9e3e-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient _firebaseClient;


        public static string user;
        public static string pass;
        public static string pass2;
        public static string number;
        public static string dateadded;

        public static string status;


        public Signup_Form()
        {
            InitializeComponent();
            _firebaseClient = new FireSharp.FirebaseClient(_config);
        }

        private void Signup_Form_Load(object sender, EventArgs e)
        {
            _firebaseClient = new FireSharp.FirebaseClient(_config);




        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            if (usertxt.Text != "" && passtxt.Text != "" && passtxt2.Text != "" && phonenumbertxt.Text != "" && passtxt.Text == passtxt2.Text)
            {
                if (MessageBox.Show("Please confirm before proceeding" + "\n" + "Do you want to Continue ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {
   
                    

                    String date = DateTime.Now.ToString("MM/dd/yyyy");

                    user = usertxt.Text;
                    pass = passtxt.Text;
                    pass2 = passtxt2.Text;
                    number = phonenumbertxt.Text;
                    dateadded = date;

                    Otp_Form a = new Otp_Form();

                    Otp_Form.USER = user;
                    Otp_Form.PASS = pass;
                    Otp_Form.NUMBER = number;
                    Otp_Form.DATE = dateadded;
                    Otp_Form.LEVEL = "User";

                    Otp_Form.OPERATION = "SIGNUP";
                    this.Hide();
                    a.Show();


                    
                }

                else
                {

                }

            }
            else
            {
                MessageBox.Show("Fill up all necessary fields correctly.");
            }




        }

  

  



        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void passtxt_Enter(object sender, EventArgs e)
        {
            passtxt.Text = "";
        }

        private void passtxt2_Enter(object sender, EventArgs e)
        {
            passtxt2.Text = "";
        }

        private void passtxt_Leave(object sender, EventArgs e)
        {
            if (passtxt.Text == "")
            {
                passtxt.Text = "Password";
                passtxt.ForeColor = Color.Gray;


            }
        }

        private void passtxt2_Leave(object sender, EventArgs e)
        {
            if (passtxt2.Text == "")
            {
                passtxt2.Text = "Password";
                passtxt2.ForeColor = Color.Gray;


            }
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            this.Hide();
            a.Show();
        }
    }
}
