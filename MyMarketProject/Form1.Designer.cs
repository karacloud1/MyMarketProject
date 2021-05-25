
namespace MyMarketProject
{
    partial class Form_login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_login));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_login = new System.Windows.Forms.Button();
            this.button_register = new System.Windows.Forms.Button();
            this.panel_register = new System.Windows.Forms.Panel();
            this.button_regClear = new System.Windows.Forms.Button();
            this.textBox_regAdress = new System.Windows.Forms.TextBox();
            this.textBox_regSurname = new System.Windows.Forms.TextBox();
            this.textBox_regName = new System.Windows.Forms.TextBox();
            this.button_regBack = new System.Windows.Forms.Button();
            this.button_regComplete = new System.Windows.Forms.Button();
            this.textBox_regMail = new System.Windows.Forms.TextBox();
            this.textBox_regTel = new System.Windows.Forms.TextBox();
            this.textBox_regPw = new System.Windows.Forms.TextBox();
            this.textBox_regId = new System.Windows.Forms.TextBox();
            this.pictureBox_closeApp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel_register.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_closeApp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Constantia", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(124, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLOUD";
            // 
            // textBox_id
            // 
            this.textBox_id.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_id.Font = new System.Drawing.Font("Franklin Gothic Book", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_id.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_id.Location = new System.Drawing.Point(124, 180);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.PlaceholderText = "Kullanıcı Adı";
            this.textBox_id.Size = new System.Drawing.Size(220, 28);
            this.textBox_id.TabIndex = 1;
            // 
            // textBox_password
            // 
            this.textBox_password.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_password.Font = new System.Drawing.Font("Franklin Gothic Book", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_password.Location = new System.Drawing.Point(124, 278);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.PlaceholderText = "Şifre";
            this.textBox_password.Size = new System.Drawing.Size(220, 28);
            this.textBox_password.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::MyMarketProject.Properties.Resources.id_icon;
            this.pictureBox1.Location = new System.Drawing.Point(70, 180);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(70, 278);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.Transparent;
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_login.Font = new System.Drawing.Font("Franklin Gothic Book", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_login.Location = new System.Drawing.Point(124, 369);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(220, 43);
            this.button_login.TabIndex = 5;
            this.button_login.Text = "Giriş";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // button_register
            // 
            this.button_register.BackColor = System.Drawing.Color.Transparent;
            this.button_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_register.Font = new System.Drawing.Font("Franklin Gothic Book", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_register.Location = new System.Drawing.Point(124, 450);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(220, 39);
            this.button_register.TabIndex = 6;
            this.button_register.Text = "Kayıt Ol";
            this.button_register.UseVisualStyleBackColor = false;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // panel_register
            // 
            this.panel_register.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_register.BackgroundImage")));
            this.panel_register.Controls.Add(this.button_regClear);
            this.panel_register.Controls.Add(this.textBox_regAdress);
            this.panel_register.Controls.Add(this.textBox_regSurname);
            this.panel_register.Controls.Add(this.textBox_regName);
            this.panel_register.Controls.Add(this.button_regBack);
            this.panel_register.Controls.Add(this.button_regComplete);
            this.panel_register.Controls.Add(this.textBox_regMail);
            this.panel_register.Controls.Add(this.textBox_regTel);
            this.panel_register.Controls.Add(this.textBox_regPw);
            this.panel_register.Controls.Add(this.textBox_regId);
            this.panel_register.Location = new System.Drawing.Point(0, 0);
            this.panel_register.Name = "panel_register";
            this.panel_register.Size = new System.Drawing.Size(400, 700);
            this.panel_register.TabIndex = 7;
            this.panel_register.Visible = false;
            // 
            // button_regClear
            // 
            this.button_regClear.BackColor = System.Drawing.Color.Transparent;
            this.button_regClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_regClear.Font = new System.Drawing.Font("Franklin Gothic Book", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_regClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_regClear.Location = new System.Drawing.Point(94, 610);
            this.button_regClear.Name = "button_regClear";
            this.button_regClear.Size = new System.Drawing.Size(220, 35);
            this.button_regClear.TabIndex = 12;
            this.button_regClear.Text = "Temizle";
            this.button_regClear.UseVisualStyleBackColor = false;
            this.button_regClear.Click += new System.EventHandler(this.button_regClear_Click);
            // 
            // textBox_regAdress
            // 
            this.textBox_regAdress.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_regAdress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_regAdress.Font = new System.Drawing.Font("Franklin Gothic Book", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_regAdress.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_regAdress.Location = new System.Drawing.Point(94, 390);
            this.textBox_regAdress.Name = "textBox_regAdress";
            this.textBox_regAdress.PlaceholderText = "Adres";
            this.textBox_regAdress.Size = new System.Drawing.Size(220, 28);
            this.textBox_regAdress.TabIndex = 11;
            // 
            // textBox_regSurname
            // 
            this.textBox_regSurname.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_regSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_regSurname.Font = new System.Drawing.Font("Franklin Gothic Book", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_regSurname.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_regSurname.Location = new System.Drawing.Point(94, 340);
            this.textBox_regSurname.Name = "textBox_regSurname";
            this.textBox_regSurname.PlaceholderText = "Soyad";
            this.textBox_regSurname.Size = new System.Drawing.Size(220, 28);
            this.textBox_regSurname.TabIndex = 10;
            // 
            // textBox_regName
            // 
            this.textBox_regName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_regName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_regName.Font = new System.Drawing.Font("Franklin Gothic Book", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_regName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_regName.Location = new System.Drawing.Point(94, 290);
            this.textBox_regName.Name = "textBox_regName";
            this.textBox_regName.PlaceholderText = "Ad";
            this.textBox_regName.Size = new System.Drawing.Size(220, 28);
            this.textBox_regName.TabIndex = 9;
            // 
            // button_regBack
            // 
            this.button_regBack.BackColor = System.Drawing.Color.Transparent;
            this.button_regBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_regBack.Font = new System.Drawing.Font("Franklin Gothic Book", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_regBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_regBack.Location = new System.Drawing.Point(94, 550);
            this.button_regBack.Name = "button_regBack";
            this.button_regBack.Size = new System.Drawing.Size(220, 35);
            this.button_regBack.TabIndex = 8;
            this.button_regBack.Text = "Geri";
            this.button_regBack.UseVisualStyleBackColor = false;
            this.button_regBack.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_regComplete
            // 
            this.button_regComplete.BackColor = System.Drawing.Color.Transparent;
            this.button_regComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_regComplete.Font = new System.Drawing.Font("Franklin Gothic Book", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_regComplete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_regComplete.Location = new System.Drawing.Point(94, 490);
            this.button_regComplete.Name = "button_regComplete";
            this.button_regComplete.Size = new System.Drawing.Size(220, 35);
            this.button_regComplete.TabIndex = 7;
            this.button_regComplete.Text = "Kaydı Tamamla";
            this.button_regComplete.UseVisualStyleBackColor = false;
            this.button_regComplete.Click += new System.EventHandler(this.button_regComplete_Click);
            // 
            // textBox_regMail
            // 
            this.textBox_regMail.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_regMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_regMail.Font = new System.Drawing.Font("Franklin Gothic Book", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_regMail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_regMail.Location = new System.Drawing.Point(94, 240);
            this.textBox_regMail.Name = "textBox_regMail";
            this.textBox_regMail.PlaceholderText = "Email";
            this.textBox_regMail.Size = new System.Drawing.Size(220, 28);
            this.textBox_regMail.TabIndex = 5;
            // 
            // textBox_regTel
            // 
            this.textBox_regTel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_regTel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_regTel.Font = new System.Drawing.Font("Franklin Gothic Book", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_regTel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_regTel.Location = new System.Drawing.Point(94, 190);
            this.textBox_regTel.MaxLength = 10;
            this.textBox_regTel.Name = "textBox_regTel";
            this.textBox_regTel.PlaceholderText = "Telefon Numarası";
            this.textBox_regTel.Size = new System.Drawing.Size(220, 28);
            this.textBox_regTel.TabIndex = 4;
            this.textBox_regTel.TextChanged += new System.EventHandler(this.textBox_regTel_TextChanged);
            // 
            // textBox_regPw
            // 
            this.textBox_regPw.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_regPw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_regPw.Font = new System.Drawing.Font("Franklin Gothic Book", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_regPw.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_regPw.Location = new System.Drawing.Point(94, 140);
            this.textBox_regPw.Name = "textBox_regPw";
            this.textBox_regPw.PlaceholderText = "Şifre";
            this.textBox_regPw.Size = new System.Drawing.Size(220, 28);
            this.textBox_regPw.TabIndex = 3;
            // 
            // textBox_regId
            // 
            this.textBox_regId.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_regId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_regId.Font = new System.Drawing.Font("Franklin Gothic Book", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_regId.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_regId.Location = new System.Drawing.Point(94, 90);
            this.textBox_regId.Name = "textBox_regId";
            this.textBox_regId.PlaceholderText = "Kullanıcı Adı";
            this.textBox_regId.Size = new System.Drawing.Size(220, 28);
            this.textBox_regId.TabIndex = 2;
            // 
            // pictureBox_closeApp
            // 
            this.pictureBox_closeApp.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_closeApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_closeApp.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_closeApp.Image")));
            this.pictureBox_closeApp.Location = new System.Drawing.Point(354, 12);
            this.pictureBox_closeApp.Name = "pictureBox_closeApp";
            this.pictureBox_closeApp.Size = new System.Drawing.Size(34, 34);
            this.pictureBox_closeApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_closeApp.TabIndex = 8;
            this.pictureBox_closeApp.TabStop = false;
            this.pictureBox_closeApp.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(400, 700);
            this.Controls.Add(this.pictureBox_closeApp);
            this.Controls.Add(this.panel_register);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel_register.ResumeLayout(false);
            this.panel_register.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_closeApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.Panel panel_register;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_regComplete;
        private System.Windows.Forms.TextBox textBox_regMail;
        private System.Windows.Forms.TextBox textBox_regTel;
        private System.Windows.Forms.TextBox textBox_regPw;
        private System.Windows.Forms.TextBox textBox_regId;
        private System.Windows.Forms.PictureBox pictureBox_closeApp;
        private System.Windows.Forms.TextBox textBox_regAddress;
        private System.Windows.Forms.TextBox textBox_regSurname;
        private System.Windows.Forms.TextBox textBox_regName;
        private System.Windows.Forms.TextBox textBox_regAdress;
        private System.Windows.Forms.Button button_regClear;
        private System.Windows.Forms.Button button_regBack;
    }
}

