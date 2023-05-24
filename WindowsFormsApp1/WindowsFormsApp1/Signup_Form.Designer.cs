namespace WindowsFormsApp1
{
    partial class Signup_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.passtxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.usertxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.passtxt2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.phonenumbertxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.emailaddresstxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // passtxt
            // 
            this.passtxt.BackColor = System.Drawing.Color.White;
            this.passtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passtxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passtxt.ForeColor = System.Drawing.Color.Gray;
            this.passtxt.HintForeColor = System.Drawing.Color.Gray;
            this.passtxt.HintText = "";
            this.passtxt.isPassword = true;
            this.passtxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(115)))), ((int)(((byte)(225)))));
            this.passtxt.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(75)))), ((int)(((byte)(182)))));
            this.passtxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(115)))), ((int)(((byte)(225)))));
            this.passtxt.LineThickness = 3;
            this.passtxt.Location = new System.Drawing.Point(633, 163);
            this.passtxt.Margin = new System.Windows.Forms.Padding(4);
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(306, 41);
            this.passtxt.TabIndex = 23;
            this.passtxt.Text = "Password";
            this.passtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passtxt.Enter += new System.EventHandler(this.passtxt_Enter);
            this.passtxt.Leave += new System.EventHandler(this.passtxt_Leave);
            // 
            // usertxt
            // 
            this.usertxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usertxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertxt.ForeColor = System.Drawing.Color.Gray;
            this.usertxt.HintForeColor = System.Drawing.Color.Gray;
            this.usertxt.HintText = "Username";
            this.usertxt.isPassword = false;
            this.usertxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(115)))), ((int)(((byte)(225)))));
            this.usertxt.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(75)))), ((int)(((byte)(182)))));
            this.usertxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(115)))), ((int)(((byte)(225)))));
            this.usertxt.LineThickness = 3;
            this.usertxt.Location = new System.Drawing.Point(633, 103);
            this.usertxt.Margin = new System.Windows.Forms.Padding(4);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(306, 41);
            this.usertxt.TabIndex = 22;
            this.usertxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(75)))), ((int)(((byte)(182)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(731, 61);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(117, 29);
            this.bunifuCustomLabel1.TabIndex = 21;
            this.bunifuCustomLabel1.Text = "SIGN UP";
            // 
            // passtxt2
            // 
            this.passtxt2.BackColor = System.Drawing.Color.White;
            this.passtxt2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passtxt2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passtxt2.ForeColor = System.Drawing.Color.Gray;
            this.passtxt2.HintForeColor = System.Drawing.Color.Gray;
            this.passtxt2.HintText = "";
            this.passtxt2.isPassword = true;
            this.passtxt2.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(115)))), ((int)(((byte)(225)))));
            this.passtxt2.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(75)))), ((int)(((byte)(182)))));
            this.passtxt2.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(115)))), ((int)(((byte)(225)))));
            this.passtxt2.LineThickness = 3;
            this.passtxt2.Location = new System.Drawing.Point(633, 225);
            this.passtxt2.Margin = new System.Windows.Forms.Padding(4);
            this.passtxt2.Name = "passtxt2";
            this.passtxt2.Size = new System.Drawing.Size(306, 41);
            this.passtxt2.TabIndex = 25;
            this.passtxt2.Text = "Password";
            this.passtxt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passtxt2.Enter += new System.EventHandler(this.passtxt2_Enter);
            this.passtxt2.Leave += new System.EventHandler(this.passtxt2_Leave);
            // 
            // phonenumbertxt
            // 
            this.phonenumbertxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phonenumbertxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonenumbertxt.ForeColor = System.Drawing.Color.Gray;
            this.phonenumbertxt.HintForeColor = System.Drawing.Color.Gray;
            this.phonenumbertxt.HintText = "Phone Number";
            this.phonenumbertxt.isPassword = false;
            this.phonenumbertxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(115)))), ((int)(((byte)(225)))));
            this.phonenumbertxt.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(75)))), ((int)(((byte)(182)))));
            this.phonenumbertxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(115)))), ((int)(((byte)(225)))));
            this.phonenumbertxt.LineThickness = 3;
            this.phonenumbertxt.Location = new System.Drawing.Point(633, 285);
            this.phonenumbertxt.Margin = new System.Windows.Forms.Padding(4);
            this.phonenumbertxt.Name = "phonenumbertxt";
            this.phonenumbertxt.Size = new System.Drawing.Size(306, 41);
            this.phonenumbertxt.TabIndex = 26;
            this.phonenumbertxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton4.Image = global::WindowsFormsApp1.Properties.Resources.image_9;
            this.bunifuImageButton4.ImageActive = null;
            this.bunifuImageButton4.Location = new System.Drawing.Point(16, 15);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Size = new System.Drawing.Size(30, 32);
            this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton4.TabIndex = 30;
            this.bunifuImageButton4.TabStop = false;
            this.bunifuImageButton4.Zoom = 10;
            this.bunifuImageButton4.Click += new System.EventHandler(this.bunifuImageButton4_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::WindowsFormsApp1.Properties.Resources.x;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(986, 15);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(30, 32);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 29;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = global::WindowsFormsApp1.Properties.Resources.cancel_button;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(633, 452);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(306, 37);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton2.TabIndex = 28;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.Image = global::WindowsFormsApp1.Properties.Resources.signup_button2;
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(633, 407);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(306, 37);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton3.TabIndex = 27;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.signup_img;
            this.panel1.Location = new System.Drawing.Point(82, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 307);
            this.panel1.TabIndex = 20;
            // 
            // emailaddresstxt
            // 
            this.emailaddresstxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailaddresstxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailaddresstxt.ForeColor = System.Drawing.Color.Gray;
            this.emailaddresstxt.HintForeColor = System.Drawing.Color.Gray;
            this.emailaddresstxt.HintText = "Email Address";
            this.emailaddresstxt.isPassword = false;
            this.emailaddresstxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(115)))), ((int)(((byte)(225)))));
            this.emailaddresstxt.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(75)))), ((int)(((byte)(182)))));
            this.emailaddresstxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(115)))), ((int)(((byte)(225)))));
            this.emailaddresstxt.LineThickness = 3;
            this.emailaddresstxt.Location = new System.Drawing.Point(633, 342);
            this.emailaddresstxt.Margin = new System.Windows.Forms.Padding(4);
            this.emailaddresstxt.Name = "emailaddresstxt";
            this.emailaddresstxt.Size = new System.Drawing.Size(306, 41);
            this.emailaddresstxt.TabIndex = 31;
            this.emailaddresstxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Signup_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1033, 563);
            this.Controls.Add(this.emailaddresstxt);
            this.Controls.Add(this.bunifuImageButton4);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.bunifuImageButton3);
            this.Controls.Add(this.phonenumbertxt);
            this.Controls.Add(this.passtxt2);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Signup_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signup_Form";
            this.Load += new System.EventHandler(this.Signup_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passtxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox usertxt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox phonenumbertxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passtxt2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox emailaddresstxt;
    }
}