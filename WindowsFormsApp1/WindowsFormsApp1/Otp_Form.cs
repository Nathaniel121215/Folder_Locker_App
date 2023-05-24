using Bunifu.Framework.UI;
using Firebase.Auth;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio.TwiML.Voice;

namespace WindowsFormsApp1
{
    public partial class Otp_Form : Form
    {
        public static string FOLDER_ID { get; set; }
        public static string FOLDER_PATH { get; set; }
        public static string FOLDER_NAME { get; set; }
        public static string FOLDER_DATE { get; set; }
        public static string FOLDER_STATUS { get; set; }
        public static string FOLDER_USERNAME { get; set; }
        public static string FOLDER_USER_NUMBER { get; set; }


        public static string USER { get; set; }
        public static string PASS { get; set; }
        public static string NUMBER { get; set; }
        public static string DATE { get; set; }
        public static string EMAIL { get; set; }
        public static string LEVEL { get; set; }




        public static string LOGINUSERID { get; set; }
        public static string LOGINUSER { get; set; }
        public static string LOGINPASS { get; set; }
        public static string LOGINNUMBER { get; set; }
        public static string LOGINDATE { get; set; }
        public static string LOGINEMAIL { get; set; }
        public static string OPERATION { get; set; }



        public static string FORGOTUSERID { get; set; }
        public static string FORGOTUSER { get; set; }
        public static string FORGOTPASS { get; set; }
        public static string FORGOTNUMBER { get; set; }
        public static string FORGOTDATE { get; set; }
        public static string FORGOTEMAIL { get; set; }



        public static string otp ="";

        private const string FirebaseProjectId = "lockerdata-e9e3e";
        FireSharp.Config.FirebaseConfig _config = new FireSharp.Config.FirebaseConfig
        {
            AuthSecret = "9YNo57rimM5AGM7iqRSmTvzaH26sFuzStdnixvz5",
            BasePath = "https://lockerdata-e9e3e-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient _firebaseClient;

        public Otp_Form()
        {
            InitializeComponent();
            _firebaseClient = new FireSharp.FirebaseClient(_config);
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
           

            if (OPERATION == "LOCK" || OPERATION == "UNLOCK")
            {
                this.Hide();


            }
            else
            {
                System.Windows.Forms.Application.Exit();

            }
        }

        private void Otp_Form_Load(object sender, EventArgs e)
        {
            _firebaseClient = new FireSharp.FirebaseClient(_config);


            otp = GenerateOTP();
            Console.WriteLine(otp);

            try
            {
                if (EMAIL != null && EMAIL != "")
                {
                    // Send the OTP to the email address
                    string email = EMAIL;
                    string subject = "OTP";
                    string body = $"Your OTP is: {otp}";

                    // Gmail SMTP server details
                    string smtpServer = "smtp.gmail.com";
                    int smtpPort = 587;
                    string smtpUsername = "folderlocker.otp@gmail.com";
                    string smtpPassword = "ascjyylxbldqqgtk";

                    // Create and configure the email message
                    MailMessage message = new MailMessage();
                    message.From = new MailAddress(smtpUsername);
                    message.To.Add(email);
                    message.Subject = subject;
                    message.Body = body;

                    // Set up the SMTP client
                    SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort);
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.EnableSsl = true;
                    smtpClient.Credentials = new System.Net.NetworkCredential(smtpUsername, smtpPassword);

                    // Send the email
                    smtpClient.Send(message);
                }
                else if(LOGINEMAIL != null && LOGINEMAIL != "")
                {

                    // Send the OTP to the email address
                    string email = LOGINEMAIL;
                    string subject = "OTP";
                    string body = $"Your OTP is: {otp}";

                    // Gmail SMTP server details
                    string smtpServer = "smtp.gmail.com";
                    int smtpPort = 587;
                    string smtpUsername = "folderlocker.otp@gmail.com";
                    string smtpPassword = "ascjyylxbldqqgtk";

                    // Create and configure the email message
                    MailMessage message = new MailMessage();
                    message.From = new MailAddress(smtpUsername);
                    message.To.Add(email);
                    message.Subject = subject;
                    message.Body = body;

                    // Set up the SMTP client
                    SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort);
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.EnableSsl = true;
                    smtpClient.Credentials = new System.Net.NetworkCredential(smtpUsername, smtpPassword);

                    // Send the email
                    smtpClient.Send(message);

                }
                else
                {

                    // Send the OTP to the email address
                    string email = FOLDER_USER_NUMBER;
                    string subject = "OTP";
                    string body = $"Your OTP is: {otp}";

                    // Gmail SMTP server details
                    string smtpServer = "smtp.gmail.com";
                    int smtpPort = 587;
                    string smtpUsername = "folderlocker.otp@gmail.com";
                    string smtpPassword = "ascjyylxbldqqgtk";

                    // Create and configure the email message
                    MailMessage message = new MailMessage();
                    message.From = new MailAddress(smtpUsername);
                    message.To.Add(email);
                    message.Subject = subject;
                    message.Body = body;

                    // Set up the SMTP client
                    SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort);
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.EnableSsl = true;
                    smtpClient.Credentials = new System.Net.NetworkCredential(smtpUsername, smtpPassword);

                    // Send the email
                    smtpClient.Send(message);

                }
                

            }
            catch
            {

            }


            






            if (NUMBER != null)
            {
                bunifuCustomLabel3.Text = NUMBER;
            }
            else if (LOGINNUMBER != null)
            {
                bunifuCustomLabel3.Text = LOGINNUMBER;
            }

            else if (FORGOTNUMBER != null)
            {
                bunifuCustomLabel3.Text = FORGOTNUMBER;
            }
            else
            {
                bunifuCustomLabel3.Text = FOLDER_USER_NUMBER;
            }
            
        }

        private void no1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void no1_KeyDown(object sender, KeyEventArgs e)
        {
 
  
        }

        private void no1_MouseEnter(object sender, EventArgs e)
        {
            


        }

        private void no1_OnValueChanged(object sender, EventArgs e)
        {
        
            if (no1.Text.Length > 0)
            {
                no2.Focus();
            }
        }

        private void no1_Enter(object sender, EventArgs e)
        {
            no1.Text = "";
        }

        private void no2_OnValueChanged(object sender, EventArgs e)
        {
            if (no2.Text.Length > 0)
            {
                no3.Focus();
            }
        }

        private void no2_Enter(object sender, EventArgs e)
        {
            no2.Text = "";
        }

        private void no3_OnValueChanged(object sender, EventArgs e)
        {
            if (no3.Text.Length > 0)
            {
                no4.Focus();
            }
        }

        private void no3_Enter(object sender, EventArgs e)
        {
            no3.Text = "";
        }

        private void no4_OnValueChanged(object sender, EventArgs e)
        {
            if (no4.Text.Length > 0)
            {
                bunifuCustomLabel1.Focus();
            }
        }

        private void bunifuCustomLabel1_Enter(object sender, EventArgs e)
        {
            
        }

        private void no4_Enter(object sender, EventArgs e)
        {
            no4.Text = "";
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            string userinput = no1.Text + no2.Text + no3.Text + no4.Text;


            if (otp != "" && OPERATION == "SIGNUP")
            {

                if (otp == userinput)
                {
                    FirebaseResponse resp = _firebaseClient.Get("Account_Counter/node");
                    Account_Counter_Number get = resp.ResultAs<Account_Counter_Number>();

                    var data = new User_Class
                    {
                        User_ID = (Convert.ToInt32(get.cnt) + 1).ToString(),
                        Username = Signup_Form.user,
                        Password = Signup_Form.pass,
                        Number = Signup_Form.number,
                        Date_Added = Signup_Form.dateadded,
                        Email = Signup_Form.email,
                        UserLevel = LEVEL,
                    };

                    SetResponse response = _firebaseClient.Set("Accounts/" + data.User_ID, data);
                    User_Class result = response.ResultAs<User_Class>();

                    var obj = new Account_Counter_Number
                    {
                        cnt = data.User_ID
                    };

                    SetResponse response1 = _firebaseClient.Set("Account_Counter/node", obj);


                    Form1 a = new Form1();
                    this.Hide();
                    a.Show();


                }
                else
                {
                    MessageBox.Show("Wrong OTP code Entered.");
                }

            }
            else if (otp != "" && OPERATION == "LOGIN")
            {
                if (otp == userinput)
                {

                    Folderlocker_Form a = new Folderlocker_Form();


                    Folderlocker_Form.LOGINUSERID = LOGINUSERID;
                    Folderlocker_Form.LOGINUSER = LOGINUSER;
                    Folderlocker_Form.LOGINPASS = LOGINPASS;
                    Folderlocker_Form.LOGINNUMBER = LOGINNUMBER;
                    Folderlocker_Form.LOGINDATE = LOGINDATE;
                    Folderlocker_Form.LOGINEMAIL = LOGINEMAIL;
                    Folderlocker_Form.LOGINLEVEL = LEVEL;


                    this.Hide();
                    a.Show();

                }

                else
                {
                    MessageBox.Show("Wrong OTP code Entered.");
                }



            }
            else if (otp != "" && OPERATION == "LOCK")
            {
                try
                {
                    if (otp == userinput)
                    {
                        Folderlocker_Form a = new Folderlocker_Form();

                        Folderlocker_Form.LockFolder(FOLDER_PATH);

                        var data = new Folder_Class
                        {
                            Folder_ID = FOLDER_ID,
                            Folder_Path = FOLDER_PATH,
                            Folder_Name = FOLDER_NAME,
                            Date_Encrypted = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt"),
                            Folder_Status = "Locked/Encrypted",
                            Username = FOLDER_USERNAME,
                        };

                        FirebaseResponse response = _firebaseClient.Update("Folders/" + data.Folder_ID, data);
                        Folder_Class result = response.ResultAs<Folder_Class>();





                        this.Hide();


                        MessageBox.Show("Folder Locked Successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Wrong OTP code Entered.");
                    }
                    

                }
                catch (DirectoryNotFoundException ex)
                {
                    
                    FirebaseResponse response2 = _firebaseClient.Delete("Folders/" + FOLDER_ID);

                    this.Hide();
                    MessageBox.Show("File path not found in the computer directory. Deleting Folder Record.");
                }

            }

            else if (otp != "" && OPERATION == "UNLOCK")
            {
                try
                {
                    if (otp == userinput)
                    {
                        Folderlocker_Form a = new Folderlocker_Form();
                        Folderlocker_Form.UnlockFolder(FOLDER_PATH);
                        FirebaseResponse response = _firebaseClient.Delete("Folders/" + FOLDER_ID);


                        this.Hide();

                        MessageBox.Show("Folder Unlocked Successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Wrong OTP code Entered.");
                    }
                    

                }
                catch (DirectoryNotFoundException ex)
                {

                    FirebaseResponse response2 = _firebaseClient.Delete("Folders/" + FOLDER_ID);
                    this.Hide();
                    MessageBox.Show("File path not found in the computer directory. Deleting Folder Record.");
                }
            }

            else if (otp != "" && OPERATION == "FORGOT")
            {
                if (otp == userinput)
                {

                    Newpassword_Form a = new Newpassword_Form();
                    this.Hide();
                    a.Show();

                }

                else
                {
                    MessageBox.Show("Wrong OTP code Entered.");
                }



            }


            else
            {

            }
            
            
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            if(OPERATION == "LOCK" || OPERATION == "UNLOCK")
            {
                this.Hide();


            }
            else
            {
                Form1 a = new Form1();
                this.Hide();
                a.Show();

            }
                


        }

        private string GenerateOTP()
        {
            Random random = new Random();
            return random.Next(1000, 9999).ToString();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            resend();
        }

        public void resend()
        {
            otp = GenerateOTP();
            Console.WriteLine(otp);

            try
            {
                if (EMAIL != null && EMAIL != "")
                {
                    // Send the OTP to the email address
                    string email = EMAIL;
                    string subject = "OTP";
                    string body = $"Your OTP is: {otp}";

                    // Gmail SMTP server details
                    string smtpServer = "smtp.gmail.com";
                    int smtpPort = 587;
                    string smtpUsername = "folderlocker.otp@gmail.com";
                    string smtpPassword = "ascjyylxbldqqgtk";

                    // Create and configure the email message
                    MailMessage message = new MailMessage();
                    message.From = new MailAddress(smtpUsername);
                    message.To.Add(email);
                    message.Subject = subject;
                    message.Body = body;

                    // Set up the SMTP client
                    SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort);
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.EnableSsl = true;
                    smtpClient.Credentials = new System.Net.NetworkCredential(smtpUsername, smtpPassword);

                    // Send the email
                    smtpClient.Send(message);
                }
                else if (LOGINEMAIL != null && LOGINEMAIL != "")
                {

                    // Send the OTP to the email address
                    string email = LOGINEMAIL;
                    string subject = "OTP";
                    string body = $"Your OTP is: {otp}";

                    // Gmail SMTP server details
                    string smtpServer = "smtp.gmail.com";
                    int smtpPort = 587;
                    string smtpUsername = "folderlocker.otp@gmail.com";
                    string smtpPassword = "ascjyylxbldqqgtk";

                    // Create and configure the email message
                    MailMessage message = new MailMessage();
                    message.From = new MailAddress(smtpUsername);
                    message.To.Add(email);
                    message.Subject = subject;
                    message.Body = body;

                    // Set up the SMTP client
                    SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort);
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.EnableSsl = true;
                    smtpClient.Credentials = new System.Net.NetworkCredential(smtpUsername, smtpPassword);

                    // Send the email
                    smtpClient.Send(message);

                }
                else
                {

                    // Send the OTP to the email address
                    string email = FOLDER_USER_NUMBER;
                    string subject = "OTP";
                    string body = $"Your OTP is: {otp}";

                    // Gmail SMTP server details
                    string smtpServer = "smtp.gmail.com";
                    int smtpPort = 587;
                    string smtpUsername = "folderlocker.otp@gmail.com";
                    string smtpPassword = "ascjyylxbldqqgtk";

                    // Create and configure the email message
                    MailMessage message = new MailMessage();
                    message.From = new MailAddress(smtpUsername);
                    message.To.Add(email);
                    message.Subject = subject;
                    message.Body = body;

                    // Set up the SMTP client
                    SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort);
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.EnableSsl = true;
                    smtpClient.Credentials = new System.Net.NetworkCredential(smtpUsername, smtpPassword);

                    // Send the email
                    smtpClient.Send(message);

                }


            }
            catch
            {

            }



            if (NUMBER != null)
            {
                bunifuCustomLabel3.Text = NUMBER;
            }
            else if (LOGINNUMBER != null)
            {
                bunifuCustomLabel3.Text = LOGINNUMBER;
            }

            else if (FORGOTNUMBER != null)
            {
                bunifuCustomLabel3.Text = FORGOTNUMBER;
            }
            else
            {
                bunifuCustomLabel3.Text = FOLDER_USER_NUMBER;
            }
        }
    }
}
