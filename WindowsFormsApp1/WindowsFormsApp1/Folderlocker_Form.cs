using Firebase.Auth;
using FireSharp.Interfaces;
using FireSharp.Response;
using Google.Api.Gax.ResourceNames;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio.TwiML.Voice;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace WindowsFormsApp1
{
    public partial class Folderlocker_Form : Form

    {
        public static string folder_id;
        public static string folder_path;
        public static string folder_name;
        public static string folder_date;
        public static string folder_status;
        public static string folder_username;

        public static string LOGINUSERID { get; set; }
        public static string LOGINUSER { get; set; }
        public static string LOGINPASS { get; set; }
        public static string LOGINNUMBER { get; set; }
        public static string LOGINDATE { get; set; }
        public static string LOGINEMAIL { get; set; }
        
        public static string LOGINLEVEL { get; set; }

        DataTable dt = new DataTable();

        private const string FirebaseProjectId = "lockerdata-e9e3e";
        FireSharp.Config.FirebaseConfig _config = new FireSharp.Config.FirebaseConfig
        {
            AuthSecret = "9YNo57rimM5AGM7iqRSmTvzaH26sFuzStdnixvz5",
            BasePath = "https://lockerdata-e9e3e-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient _firebaseClient;

        public Folderlocker_Form()
        {
            InitializeComponent();
            _firebaseClient = new FireSharp.FirebaseClient(_config);
        }

        private void Folderlocker_Form_Load(object sender, EventArgs e)
        {
            _firebaseClient = new FireSharp.FirebaseClient(_config);

            dt.Columns.Add("Folder ID");
            dt.Columns.Add("Folder Path");
            dt.Columns.Add("Folder Name");
            dt.Columns.Add("Date Encrypted");
            dt.Columns.Add("Folder Status");
            dt.Columns.Add("Username");


            this.Folder_Datagrid.AllowUserToAddRows = false;

            Folder_Datagrid.DataSource = dt;

            DataGridViewImageColumn lockk = new DataGridViewImageColumn();
            Folder_Datagrid.Columns.Add(lockk);
            lockk.HeaderText = "";
            lockk.Name = "lock";
            lockk.ImageLayout = DataGridViewImageCellLayout.Zoom;
            lockk.Image = Properties.Resources.newlock_button;

            DataGridViewImageColumn unlockk = new DataGridViewImageColumn();
            Folder_Datagrid.Columns.Add(unlockk);
            unlockk.HeaderText = "";
            unlockk.Name = "unlock";
            unlockk.ImageLayout = DataGridViewImageCellLayout.Zoom;
            unlockk.Image = Properties.Resources.newunlock_button;



            dataview();

            

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            this.Hide();
            a.Show();
        }



        public static void LockFolder(string path)
        {
  
            // Generate a random key and IV for encryption
            byte[] key, iv;
            using (var aes = Aes.Create())
            {
                key = aes.Key;
                iv = aes.IV;
            }

            // Encrypt all files in the folder
            foreach (string file in Directory.GetFiles(path))
            {
                using (var aes = Aes.Create())
                using (var encryptor = aes.CreateEncryptor(key, iv))
                using (var input = File.OpenRead(file))
                using (var output = File.Create(file + ".encrypted"))
                using (var crypto = new CryptoStream(output, encryptor, CryptoStreamMode.Write))
                {
                    input.CopyTo(crypto);
                }
                File.Delete(file);
            }

            // Write the key and IV to a file
            string keyFile = Path.Combine(path, "key.bin");
            using (var stream = new FileStream(keyFile, FileMode.Create))
            using (var writer = new BinaryWriter(stream))
            {
                writer.Write(key.Length);
                writer.Write(key);
                writer.Write(iv.Length);
                writer.Write(iv);
            }
            File.SetAttributes(path, File.GetAttributes(path) | FileAttributes.Hidden);

        }

        public static void UnlockFolder(string path)
        {
            // Read the key and IV from the file
            string keyFile = Path.Combine(path, "key.bin");
            byte[] key, iv;
            using (var stream = new FileStream(keyFile, FileMode.Open))
            using (var reader = new BinaryReader(stream))
            {
                int keyLength = reader.ReadInt32();
                key = reader.ReadBytes(keyLength);
                int ivLength = reader.ReadInt32();
                iv = reader.ReadBytes(ivLength);
            }

            // Decrypt all encrypted files in the folder
            foreach (string file in Directory.GetFiles(path))
            {
                if (file.EndsWith(".encrypted"))
                {
                    string originalFileName = file.Substring(0, file.Length - ".encrypted".Length);
                    using (var aes = Aes.Create())
                    using (var decryptor = aes.CreateDecryptor(key, iv))
                    using (var input = File.OpenRead(file))
                    using (var output = File.Create(originalFileName))
                    using (var crypto = new CryptoStream(input, decryptor, CryptoStreamMode.Read))
                    {
                        crypto.CopyTo(output);
                    }
                    File.Delete(file);
                }
            }

            // Remove the hidden attribute from the folder
            FileAttributes attributes = File.GetAttributes(path);
            if ((attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
            {
                File.SetAttributes(path, attributes & ~FileAttributes.Hidden);
            }

            // Securely delete the key file
            File.Delete(keyFile);
        }







        private void button2_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text;
            LockFolder(path);
            MessageBox.Show("Folder locked.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text;
            UnlockFolder(path);
            MessageBox.Show("Folder unlocked.");
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            // Create a new instance of the FolderBrowserDialog class
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();

            // Show the dialog and get the result
            DialogResult result = folderBrowserDialog1.ShowDialog();

            // If the user clicked "OK"
            if (result == DialogResult.OK)
            {
                // Set the text of the folder path textbox to the selected path
                textBox1.Text = folderBrowserDialog1.SelectedPath;

                // Get the name of the selected folder
                string folderName = Path.GetFileName(folderBrowserDialog1.SelectedPath);

                // Set the text of the folder name textbox to the folder name
                textBox2.Text = folderName;




                FirebaseResponse resp = _firebaseClient.Get("Folder_Counter/node");
                Account_Counter_Number get = resp.ResultAs<Account_Counter_Number>();
                int cnt = Convert.ToInt32(get.cnt);

                //checking
                int i = 0;

                while (i <= cnt)
                {
                    try
                    {
                        //Account DB
                        FirebaseResponse resp1 = _firebaseClient.Get("Folders/" + i);
                        Folder_Class obj2 = resp1.ResultAs<Folder_Class>();

                        if (folderBrowserDialog1.SelectedPath == obj2.Folder_Path)
                        {
                            MessageBox.Show("Folder Already Exist in the Database.");
                            break;

                        }
                        else
                        {


                        }

                    }
                    catch
                    {

                    }


                    if (i == cnt)
                    {
                        var data = new Folder_Class
                        {
                            Folder_ID = (Convert.ToInt32(get.cnt) + 1).ToString(),
                            Folder_Path = folderBrowserDialog1.SelectedPath,
                            Folder_Name = folderName,
                            Date_Encrypted = "None",
                            Folder_Status = "Newly Added",
                            Username = LOGINUSER,
                        };


                        SetResponse response = _firebaseClient.Set("Folders/" + data.Folder_ID, data);
                        Folder_Class result2 = response.ResultAs<Folder_Class>();

                        var obj = new Account_Counter_Number
                        {
                            cnt = data.Folder_ID
                        };

                        SetResponse response1 = _firebaseClient.Set("Folder_Counter/node", obj);


                        //////////////////////////////////////
                        ///

                        FirebaseResponse resp1 = _firebaseClient.Get("Log_Counter/node");
                        Account_Counter_Number get1 = resp.ResultAs<Account_Counter_Number>();

                        var data1 = new Log_Class
                        {
                            Log_ID = (Convert.ToInt32(get.cnt) + 1).ToString(),
                            Action = "Added New Folder Named: " + folderName,
                            Module = "Folder Locker Module",
                            Date_Added = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt"),
                            Username = folder_username,
                        };

                        SetResponse response2 = _firebaseClient.Set("Logs/" + data1.Log_ID, data1);
                        User_Class result1 = response.ResultAs<User_Class>();

                        var obj1 = new Account_Counter_Number
                        {
                            cnt = data1.Log_ID
                        };

                        SetResponse response3= _firebaseClient.Set("Log_Counter/node", obj);




                        ///////////////////////////////////////



                        dataview();

                        break;

                    }
                    i++;
                    
                }



                
            }
        }

        public async void dataview()
        {

            DataGridViewColumn column0 = Folder_Datagrid.Columns[0];
            column0.Width = 100;
            DataGridViewColumn column1 = Folder_Datagrid.Columns[1];
            column1.Width = 230;



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
                    FirebaseResponse resp1 = await _firebaseClient.GetTaskAsync("Folders/" + i);
                    Folder_Class act = resp1.ResultAs<Folder_Class>();

                    DataRow r = dt.NewRow();

                    r["Folder ID"] = act.Folder_ID;
                    r["Folder Path"] = act.Folder_Path;
                    r["Folder Name"] = act.Folder_Name;
                    r["Date Encrypted"] = act.Date_Encrypted;
                    r["Folder Status"] = act.Folder_Status;
                    r["Username"] = act.Username;


                    dt.Rows.Add(r);

                    DataView dv = dt.DefaultView;
                    dv.RowFilter = $"Username = '{LOGINUSER}'";
                }

                catch
                {

                }


            }

            







        }

        private void Folder_Datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Folder_Datagrid.Columns[6].Index)
            {

                string status = Folder_Datagrid.Rows[e.RowIndex].Cells[4].Value.ToString();

                if(status == "Newly Added")
                {

                    folder_id = Folder_Datagrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                    folder_path = Folder_Datagrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                    folder_name = Folder_Datagrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                    folder_date = Folder_Datagrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                    folder_status = Folder_Datagrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                    folder_username = Folder_Datagrid.Rows[e.RowIndex].Cells[5].Value.ToString();



                    Otp_Form a = new Otp_Form();

                    Otp_Form.FOLDER_ID = folder_id;
                    Otp_Form.FOLDER_PATH = folder_path;
                    Otp_Form.FOLDER_NAME = folder_name;
                    Otp_Form.FOLDER_DATE = folder_date;
                    Otp_Form.FOLDER_STATUS = folder_status;
                    Otp_Form.FOLDER_USERNAME = folder_username;
                    Otp_Form.FOLDER_USER_NUMBER = LOGINNUMBER;
                    Otp_Form.OPERATION = "LOCK";

                    //////////////////////////////////////////////////////////////////////////////////////////
                    //////////////////////////////////////////////////////////////////////////////////////////
                    
                    FirebaseResponse resp = _firebaseClient.Get("Log_Counter/node");
                    Account_Counter_Number get = resp.ResultAs<Account_Counter_Number>();

                    var data = new Log_Class
                    {
                        Log_ID = (Convert.ToInt32(get.cnt) + 1).ToString(),
                        Action = "Locked Folder Name: "+ folder_name,
                        Module = "Folder Locker Module",
                        Date_Added = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt"),
                        Username = folder_username,
                    };

                    SetResponse response = _firebaseClient.Set("Logs/" + data.Log_ID, data);
                    User_Class result = response.ResultAs<User_Class>();

                    var obj = new Account_Counter_Number
                    {
                        cnt = data.Log_ID
                    };

                    SetResponse response1 = _firebaseClient.Set("Log_Counter/node", obj);


                    //////////////////////////////////////////////////////////////////////////////////////////
                    /////////////////////////////////////////////////////////////////////////////////////////////




                    a.ShowDialog();
                    dataview();



                }
                else
                {
                    MessageBox.Show("Cannot Encrypt a folder that is locked already.");

                }

                


            }
            else if (e.ColumnIndex == Folder_Datagrid.Columns[7].Index)
            {

                string status = Folder_Datagrid.Rows[e.RowIndex].Cells[4].Value.ToString();

                if (status != "Newly Added")
                {
                    folder_id = Folder_Datagrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                    folder_path = Folder_Datagrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                    folder_name = Folder_Datagrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                    folder_date = Folder_Datagrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                    folder_status = Folder_Datagrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                    folder_username = Folder_Datagrid.Rows[e.RowIndex].Cells[5].Value.ToString();

                    Otp_Form a = new Otp_Form();

                    Otp_Form.FOLDER_ID = folder_id;
                    Otp_Form.FOLDER_PATH = folder_path;
                    Otp_Form.FOLDER_NAME = folder_name;
                    Otp_Form.FOLDER_DATE = folder_date;
                    Otp_Form.FOLDER_STATUS = folder_status;
                    Otp_Form.FOLDER_USERNAME = folder_username;
                    Otp_Form.FOLDER_USER_NUMBER = LOGINNUMBER;
                    Otp_Form.OPERATION = "UNLOCK";



                    //////////////////////////////////////////////////////////////////////////////////////////
                    //////////////////////////////////////////////////////////////////////////////////////////

                    FirebaseResponse resp = _firebaseClient.Get("Log_Counter/node");
                    Account_Counter_Number get = resp.ResultAs<Account_Counter_Number>();

                    var data = new Log_Class
                    {
                        Log_ID = (Convert.ToInt32(get.cnt) + 1).ToString(),
                        Action = "Unlocked Folder Name: " + folder_name,
                        Module = "Folder Locker Module",
                        Date_Added = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt"),
                        Username = folder_username,
                    };

                    SetResponse response = _firebaseClient.Set("Logs/" + data.Log_ID, data);
                    User_Class result = response.ResultAs<User_Class>();

                    var obj = new Account_Counter_Number
                    {
                        cnt = data.Log_ID
                    };

                    SetResponse response1 = _firebaseClient.Set("Log_Counter/node", obj);


                    //////////////////////////////////////////////////////////////////////////////////////////
                    /////////////////////////////////////////////////////////////////////////////////////////////



                    a.ShowDialog();
                    dataview();



   

                    

                }
                else
                {
                    MessageBox.Show("Cannot Decrypt a folder that is not locked.");

                }


                
            }
        }

        private void Account_Logo_Click(object sender, EventArgs e)
        {
            Account_Management_Form a = new Account_Management_Form();
            a.ShowDialog();

            if(Account_Management_Form.STATUS =="SUCCESS")
            {
                Form1 b = new Form1();
                this.Hide();
                b.Show();
            }
            else
            {

            }
        }

        public void restart()
        {
            Otp_Form a = new Otp_Form();
            this.Hide();
            a.Show();


        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            LogsModule_Form a = new LogsModule_Form();
            this.Hide();
            a.Show();

        }
    }
}
