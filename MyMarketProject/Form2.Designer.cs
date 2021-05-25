
namespace MyMarketProject
{
    partial class Form_CustomerMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CustomerMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_cuOkay = new System.Windows.Forms.Button();
            this.button_cuSettings = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_cuMax = new System.Windows.Forms.TextBox();
            this.textBox_cuLow = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_cuSearch = new System.Windows.Forms.TextBox();
            this.button_cuExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_cuOrderCount = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView_cu = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.button_cuOkay);
            this.panel1.Controls.Add(this.button_cuSettings);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox_cuMax);
            this.panel1.Controls.Add(this.textBox_cuLow);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_cuSearch);
            this.panel1.Controls.Add(this.button_cuExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 768);
            this.panel1.TabIndex = 0;
            // 
            // button_cuOkay
            // 
            this.button_cuOkay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.button_cuOkay.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_cuOkay.Location = new System.Drawing.Point(0, 335);
            this.button_cuOkay.Name = "button_cuOkay";
            this.button_cuOkay.Size = new System.Drawing.Size(200, 29);
            this.button_cuOkay.TabIndex = 8;
            this.button_cuOkay.Text = "Listele";
            this.button_cuOkay.UseVisualStyleBackColor = false;
            this.button_cuOkay.Click += new System.EventHandler(this.button_cuOkay_Click);
            // 
            // button_cuSettings
            // 
            this.button_cuSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.button_cuSettings.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_cuSettings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_cuSettings.Location = new System.Drawing.Point(0, 384);
            this.button_cuSettings.Name = "button_cuSettings";
            this.button_cuSettings.Size = new System.Drawing.Size(200, 31);
            this.button_cuSettings.TabIndex = 7;
            this.button_cuSettings.Text = "Hesap Ayarları";
            this.button_cuSettings.UseVisualStyleBackColor = false;
            this.button_cuSettings.Click += new System.EventHandler(this.button_cuSettings_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(91, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "-";
            // 
            // textBox_cuMax
            // 
            this.textBox_cuMax.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_cuMax.Location = new System.Drawing.Point(109, 259);
            this.textBox_cuMax.Name = "textBox_cuMax";
            this.textBox_cuMax.PlaceholderText = "En çok";
            this.textBox_cuMax.Size = new System.Drawing.Size(54, 27);
            this.textBox_cuMax.TabIndex = 5;
            // 
            // textBox_cuLow
            // 
            this.textBox_cuLow.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_cuLow.Location = new System.Drawing.Point(39, 259);
            this.textBox_cuLow.Name = "textBox_cuLow";
            this.textBox_cuLow.PlaceholderText = "En az";
            this.textBox_cuLow.Size = new System.Drawing.Size(45, 27);
            this.textBox_cuLow.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(21, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fiyat Aralığı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(21, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürün ara";
            // 
            // textBox_cuSearch
            // 
            this.textBox_cuSearch.Location = new System.Drawing.Point(21, 176);
            this.textBox_cuSearch.Name = "textBox_cuSearch";
            this.textBox_cuSearch.Size = new System.Drawing.Size(153, 23);
            this.textBox_cuSearch.TabIndex = 1;
            this.textBox_cuSearch.TextChanged += new System.EventHandler(this.textBox_cuSearch_TextChanged);
            // 
            // button_cuExit
            // 
            this.button_cuExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.button_cuExit.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_cuExit.Location = new System.Drawing.Point(0, 433);
            this.button_cuExit.Name = "button_cuExit";
            this.button_cuExit.Size = new System.Drawing.Size(200, 30);
            this.button_cuExit.TabIndex = 0;
            this.button_cuExit.Text = "Çıkış";
            this.button_cuExit.UseVisualStyleBackColor = false;
            this.button_cuExit.Click += new System.EventHandler(this.button_cuExit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.panel2.Controls.Add(this.label_cuOrderCount);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1180, 64);
            this.panel2.TabIndex = 1;
            // 
            // label_cuOrderCount
            // 
            this.label_cuOrderCount.AccessibleName = "";
            this.label_cuOrderCount.AutoSize = true;
            this.label_cuOrderCount.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_cuOrderCount.Location = new System.Drawing.Point(1082, 43);
            this.label_cuOrderCount.Name = "label_cuOrderCount";
            this.label_cuOrderCount.Size = new System.Drawing.Size(19, 21);
            this.label_cuOrderCount.TabIndex = 1;
            this.label_cuOrderCount.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::MyMarketProject.Properties.Resources.basket;
            this.pictureBox1.Location = new System.Drawing.Point(1082, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dataGridView_cu
            // 
            this.dataGridView_cu.AllowUserToAddRows = false;
            this.dataGridView_cu.AllowUserToDeleteRows = false;
            this.dataGridView_cu.AllowUserToOrderColumns = true;
            this.dataGridView_cu.AllowUserToResizeColumns = false;
            this.dataGridView_cu.AllowUserToResizeRows = false;
            this.dataGridView_cu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_cu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_cu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.dataGridView_cu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_cu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_cu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_cu.Location = new System.Drawing.Point(200, 64);
            this.dataGridView_cu.Name = "dataGridView_cu";
            this.dataGridView_cu.ReadOnly = true;
            this.dataGridView_cu.RowTemplate.Height = 25;
            this.dataGridView_cu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_cu.Size = new System.Drawing.Size(1180, 704);
            this.dataGridView_cu.TabIndex = 2;
            this.dataGridView_cu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_cu_CellClick);
            this.dataGridView_cu.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_cu_CellMouseMove);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(30, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(144, 109);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // Form_CustomerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1380, 768);
            this.Controls.Add(this.dataGridView_cu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_CustomerMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form_CustomerMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_cu;
        private System.Windows.Forms.Button button_cuExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView_cu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_cuMax;
        private System.Windows.Forms.TextBox textBox_cuLow;
        private System.Windows.Forms.Button button_cuSettings;
        private System.Windows.Forms.TextBox textBox_cuSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_cuOkay;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label_cuOrderCount;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}