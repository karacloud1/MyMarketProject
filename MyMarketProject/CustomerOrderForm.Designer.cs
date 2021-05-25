
namespace MyMarketProject
{
    partial class CustomerOrderForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_pDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_oTotal = new System.Windows.Forms.TextBox();
            this.textBox_oName = new System.Windows.Forms.TextBox();
            this.textBox_oPrice = new System.Windows.Forms.TextBox();
            this.button_oOkay = new System.Windows.Forms.Button();
            this.button_pAllDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_pDelete);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_oTotal);
            this.panel1.Controls.Add(this.textBox_oName);
            this.panel1.Controls.Add(this.textBox_oPrice);
            this.panel1.Controls.Add(this.button_oOkay);
            this.panel1.Controls.Add(this.button_pAllDelete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(944, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 450);
            this.panel1.TabIndex = 0;
            // 
            // button_pDelete
            // 
            this.button_pDelete.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_pDelete.Location = new System.Drawing.Point(58, 188);
            this.button_pDelete.Name = "button_pDelete";
            this.button_pDelete.Size = new System.Drawing.Size(120, 28);
            this.button_pDelete.TabIndex = 8;
            this.button_pDelete.Text = "Seçili Ürünü Sil";
            this.button_pDelete.UseVisualStyleBackColor = true;
            this.button_pDelete.Click += new System.EventHandler(this.button_pDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(58, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sepet Toplam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(58, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Birim Fiyatı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(58, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ürün Adı";
            // 
            // textBox_oTotal
            // 
            this.textBox_oTotal.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_oTotal.Location = new System.Drawing.Point(58, 266);
            this.textBox_oTotal.Name = "textBox_oTotal";
            this.textBox_oTotal.ReadOnly = true;
            this.textBox_oTotal.Size = new System.Drawing.Size(100, 27);
            this.textBox_oTotal.TabIndex = 4;
            // 
            // textBox_oName
            // 
            this.textBox_oName.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_oName.Location = new System.Drawing.Point(58, 95);
            this.textBox_oName.Name = "textBox_oName";
            this.textBox_oName.ReadOnly = true;
            this.textBox_oName.Size = new System.Drawing.Size(150, 27);
            this.textBox_oName.TabIndex = 3;
            // 
            // textBox_oPrice
            // 
            this.textBox_oPrice.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_oPrice.Location = new System.Drawing.Point(58, 146);
            this.textBox_oPrice.Name = "textBox_oPrice";
            this.textBox_oPrice.ReadOnly = true;
            this.textBox_oPrice.Size = new System.Drawing.Size(100, 27);
            this.textBox_oPrice.TabIndex = 2;
            // 
            // button_oOkay
            // 
            this.button_oOkay.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_oOkay.Location = new System.Drawing.Point(58, 317);
            this.button_oOkay.Name = "button_oOkay";
            this.button_oOkay.Size = new System.Drawing.Size(120, 29);
            this.button_oOkay.TabIndex = 1;
            this.button_oOkay.Text = "Sepeti Onayla";
            this.button_oOkay.UseVisualStyleBackColor = true;
            this.button_oOkay.Click += new System.EventHandler(this.button_oOkay_Click);
            // 
            // button_pAllDelete
            // 
            this.button_pAllDelete.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_pAllDelete.Location = new System.Drawing.Point(58, 371);
            this.button_pAllDelete.Name = "button_pAllDelete";
            this.button_pAllDelete.Size = new System.Drawing.Size(120, 28);
            this.button_pAllDelete.TabIndex = 0;
            this.button_pAllDelete.Text = "Sepeti Temizle";
            this.button_pAllDelete.UseVisualStyleBackColor = true;
            this.button_pAllDelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(944, 450);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // CustomerOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1164, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CustomerOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sepet";
            this.Load += new System.EventHandler(this.CustomerOrderForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_oTotal;
        private System.Windows.Forms.TextBox textBox_oName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_pAllDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_oPrice;
        private System.Windows.Forms.Button button_pDelete;
        private System.Windows.Forms.Button button_oOkay;
    }
}