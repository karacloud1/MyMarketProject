
namespace MyMarketProject
{
    partial class Form3
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_cuUpdate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_cuEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_cuTel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_cuAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_cuPw = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_cuId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_cuSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_cuName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView_cuOrder = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cuOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.button_cuUpdate);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.textBox_cuEmail);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.textBox_cuTel);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textBox_cuAddress);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBox_cuPw);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBox_cuId);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBox_cuSurname);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox_cuName);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hesap Bilgileri";
            // 
            // button_cuUpdate
            // 
            this.button_cuUpdate.Location = new System.Drawing.Point(380, 230);
            this.button_cuUpdate.Name = "button_cuUpdate";
            this.button_cuUpdate.Size = new System.Drawing.Size(150, 27);
            this.button_cuUpdate.TabIndex = 14;
            this.button_cuUpdate.Text = "Güncelle";
            this.button_cuUpdate.UseVisualStyleBackColor = true;
            this.button_cuUpdate.Click += new System.EventHandler(this.button_cuUpdate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(380, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "E-Posta Adresi";
            // 
            // textBox_cuEmail
            // 
            this.textBox_cuEmail.Location = new System.Drawing.Point(380, 166);
            this.textBox_cuEmail.Name = "textBox_cuEmail";
            this.textBox_cuEmail.Size = new System.Drawing.Size(200, 27);
            this.textBox_cuEmail.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(380, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Telefon";
            // 
            // textBox_cuTel
            // 
            this.textBox_cuTel.Location = new System.Drawing.Point(380, 104);
            this.textBox_cuTel.MaxLength = 10;
            this.textBox_cuTel.Name = "textBox_cuTel";
            this.textBox_cuTel.Size = new System.Drawing.Size(150, 27);
            this.textBox_cuTel.TabIndex = 10;
            this.textBox_cuTel.TextChanged += new System.EventHandler(this.textBox_cuTel_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Adres";
            // 
            // textBox_cuAddress
            // 
            this.textBox_cuAddress.Location = new System.Drawing.Point(380, 49);
            this.textBox_cuAddress.Name = "textBox_cuAddress";
            this.textBox_cuAddress.Size = new System.Drawing.Size(150, 27);
            this.textBox_cuAddress.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Şifre";
            // 
            // textBox_cuPw
            // 
            this.textBox_cuPw.Location = new System.Drawing.Point(70, 230);
            this.textBox_cuPw.Name = "textBox_cuPw";
            this.textBox_cuPw.Size = new System.Drawing.Size(150, 27);
            this.textBox_cuPw.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // textBox_cuId
            // 
            this.textBox_cuId.Location = new System.Drawing.Point(70, 166);
            this.textBox_cuId.Name = "textBox_cuId";
            this.textBox_cuId.ReadOnly = true;
            this.textBox_cuId.Size = new System.Drawing.Size(148, 27);
            this.textBox_cuId.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Soyad";
            // 
            // textBox_cuSurname
            // 
            this.textBox_cuSurname.Location = new System.Drawing.Point(70, 104);
            this.textBox_cuSurname.Name = "textBox_cuSurname";
            this.textBox_cuSurname.Size = new System.Drawing.Size(150, 27);
            this.textBox_cuSurname.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad";
            // 
            // textBox_cuName
            // 
            this.textBox_cuName.Location = new System.Drawing.Point(70, 49);
            this.textBox_cuName.Name = "textBox_cuName";
            this.textBox_cuName.Size = new System.Drawing.Size(150, 27);
            this.textBox_cuName.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView_cuOrder);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage2.Size = new System.Drawing.Size(792, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Siparişlerim";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView_cuOrder
            // 
            this.dataGridView_cuOrder.AllowUserToAddRows = false;
            this.dataGridView_cuOrder.AllowUserToDeleteRows = false;
            this.dataGridView_cuOrder.AllowUserToResizeColumns = false;
            this.dataGridView_cuOrder.AllowUserToResizeRows = false;
            this.dataGridView_cuOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_cuOrder.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_cuOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_cuOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_cuOrder.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_cuOrder.MultiSelect = false;
            this.dataGridView_cuOrder.Name = "dataGridView_cuOrder";
            this.dataGridView_cuOrder.ReadOnly = true;
            this.dataGridView_cuOrder.RowTemplate.Height = 25;
            this.dataGridView_cuOrder.Size = new System.Drawing.Size(786, 411);
            this.dataGridView_cuOrder.TabIndex = 0;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesabım";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cuOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_cuEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_cuTel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_cuAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_cuPw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_cuId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_cuSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_cuName;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView_cu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView_cuOrder;
        private System.Windows.Forms.Button button_cuUpdate;
    }
}