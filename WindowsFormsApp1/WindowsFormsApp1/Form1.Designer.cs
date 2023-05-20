namespace WindowsFormsApp1
{
    partial class Form1
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
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.passtxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.usertxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(75)))), ((int)(((byte)(182)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(722, 98);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(92, 29);
            this.bunifuCustomLabel1.TabIndex = 15;
            this.bunifuCustomLabel1.Text = "LOGIN";
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
            this.passtxt.Location = new System.Drawing.Point(613, 255);
            this.passtxt.Margin = new System.Windows.Forms.Padding(4);
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(306, 41);
            this.passtxt.TabIndex = 18;
            this.passtxt.Text = "Password";
            this.passtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passtxt.OnValueChanged += new System.EventHandler(this.passtxt_OnValueChanged);
            this.passtxt.Enter += new System.EventHandler(this.passtxt_Enter);
            this.passtxt.Leave += new System.EventHandler(this.passtxt_Leave);
            // 
            // usertxt
            // 
            this.usertxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usertxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertxt.ForeColor = System.Drawing.Color.Gray;
            this.usertxt.HintForeColor = System.Drawing.Color.Gray;
            this.usertxt.HintText = "";
            this.usertxt.isPassword = false;
            this.usertxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(115)))), ((int)(((byte)(225)))));
            this.usertxt.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(75)))), ((int)(((byte)(182)))));
            this.usertxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(115)))), ((int)(((byte)(225)))));
            this.usertxt.LineThickness = 3;
            this.usertxt.Location = new System.Drawing.Point(613, 183);
            this.usertxt.Margin = new System.Windows.Forms.Padding(4);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(306, 41);
            this.usertxt.TabIndex = 17;
            this.usertxt.Text = "Username";
            this.usertxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.usertxt.OnValueChanged += new System.EventHandler(this.usertxt_OnValueChanged);
            this.usertxt.Enter += new System.EventHandler(this.usertxt_Enter);
            this.usertxt.Leave += new System.EventHandler(this.usertxt_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(613, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "forgot password";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.Image = global::WindowsFormsApp1.Properties.Resources.x;
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(985, 14);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(30, 32);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 21;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = global::WindowsFormsApp1.Properties.Resources.signup_button;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(613, 396);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(306, 37);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton2.TabIndex = 20;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::WindowsFormsApp1.Properties.Resources.login_button;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(613, 351);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(306, 37);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 19;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.login_img;
            this.panel1.Location = new System.Drawing.Point(40, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 340);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1033, 563);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bunifuImageButton3);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passtxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox usertxt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private System.Windows.Forms.Button button1;
    }
}

