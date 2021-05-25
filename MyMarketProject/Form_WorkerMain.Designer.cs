
namespace MyMarketProject
{
    partial class Form_WorkerMain
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
            this.dataGridView_wProducts = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Exit = new System.Windows.Forms.Button();
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textbox_pSearch = new System.Windows.Forms.TextBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_pAmount = new System.Windows.Forms.TextBox();
            this.textBox_pPhoto = new System.Windows.Forms.TextBox();
            this.textBox_pPrice = new System.Windows.Forms.TextBox();
            this.textBox_pName = new System.Windows.Forms.TextBox();
            this.textBox_pId = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView_wOrders = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_wProducts)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_wOrders)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(1464, 729);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView_wProducts);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1456, 696);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ürün İşlemleri";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView_wProducts
            // 
            this.dataGridView_wProducts.AllowUserToAddRows = false;
            this.dataGridView_wProducts.AllowUserToDeleteRows = false;
            this.dataGridView_wProducts.AllowUserToOrderColumns = true;
            this.dataGridView_wProducts.AllowUserToResizeColumns = false;
            this.dataGridView_wProducts.AllowUserToResizeRows = false;
            this.dataGridView_wProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_wProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_wProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_wProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_wProducts.Location = new System.Drawing.Point(253, 3);
            this.dataGridView_wProducts.MultiSelect = false;
            this.dataGridView_wProducts.Name = "dataGridView_wProducts";
            this.dataGridView_wProducts.ReadOnly = true;
            this.dataGridView_wProducts.RowTemplate.Height = 25;
            this.dataGridView_wProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_wProducts.Size = new System.Drawing.Size(1200, 690);
            this.dataGridView_wProducts.TabIndex = 1;
            this.dataGridView_wProducts.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_wProducts_CellEnter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.panel1.Controls.Add(this.button_Exit);
            this.panel1.Controls.Add(this.comboBox_category);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textbox_pSearch);
            this.panel1.Controls.Add(this.button_clear);
            this.panel1.Controls.Add(this.button_update);
            this.panel1.Controls.Add(this.button_delete);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_pAmount);
            this.panel1.Controls.Add(this.textBox_pPhoto);
            this.panel1.Controls.Add(this.textBox_pPrice);
            this.panel1.Controls.Add(this.textBox_pName);
            this.panel1.Controls.Add(this.textBox_pId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 690);
            this.panel1.TabIndex = 0;
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.button_Exit.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Exit.Location = new System.Drawing.Point(21, 553);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(209, 30);
            this.button_Exit.TabIndex = 19;
            this.button_Exit.Text = "Çıkış";
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // comboBox_category
            // 
            this.comboBox_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.Location = new System.Drawing.Point(21, 403);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(209, 28);
            this.comboBox_category.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Ürün Ara";
            // 
            // textbox_pSearch
            // 
            this.textbox_pSearch.Location = new System.Drawing.Point(21, 91);
            this.textbox_pSearch.Name = "textbox_pSearch";
            this.textbox_pSearch.Size = new System.Drawing.Size(209, 27);
            this.textbox_pSearch.TabIndex = 16;
            this.textbox_pSearch.TextChanged += new System.EventHandler(this.textbox_pSearch_TextChanged);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(155, 492);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(75, 27);
            this.button_clear.TabIndex = 15;
            this.button_clear.Text = "Yeni";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(155, 452);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 27);
            this.button_update.TabIndex = 14;
            this.button_update.Text = "Güncelle";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(21, 452);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 27);
            this.button_delete.TabIndex = 13;
            this.button_delete.Text = "Sil";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(21, 492);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 27);
            this.button_add.TabIndex = 12;
            this.button_add.Text = "Ekle";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ürün Kategori";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ürün Stok Adeti";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ürün Resim Yolu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ürün Fiyatı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ürün Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ürün Id";
            // 
            // textBox_pAmount
            // 
            this.textBox_pAmount.Location = new System.Drawing.Point(21, 353);
            this.textBox_pAmount.Name = "textBox_pAmount";
            this.textBox_pAmount.Size = new System.Drawing.Size(209, 27);
            this.textBox_pAmount.TabIndex = 4;
            this.textBox_pAmount.TextChanged += new System.EventHandler(this.textBox_pAmount_TextChanged);
            // 
            // textBox_pPhoto
            // 
            this.textBox_pPhoto.Location = new System.Drawing.Point(21, 303);
            this.textBox_pPhoto.Name = "textBox_pPhoto";
            this.textBox_pPhoto.Size = new System.Drawing.Size(209, 27);
            this.textBox_pPhoto.TabIndex = 3;
            // 
            // textBox_pPrice
            // 
            this.textBox_pPrice.Location = new System.Drawing.Point(21, 253);
            this.textBox_pPrice.Name = "textBox_pPrice";
            this.textBox_pPrice.Size = new System.Drawing.Size(209, 27);
            this.textBox_pPrice.TabIndex = 2;
            this.textBox_pPrice.TextChanged += new System.EventHandler(this.textBox_pPrice_TextChanged);
            // 
            // textBox_pName
            // 
            this.textBox_pName.Location = new System.Drawing.Point(21, 203);
            this.textBox_pName.Name = "textBox_pName";
            this.textBox_pName.Size = new System.Drawing.Size(209, 27);
            this.textBox_pName.TabIndex = 1;
            // 
            // textBox_pId
            // 
            this.textBox_pId.Location = new System.Drawing.Point(21, 153);
            this.textBox_pId.Name = "textBox_pId";
            this.textBox_pId.ReadOnly = true;
            this.textBox_pId.Size = new System.Drawing.Size(209, 27);
            this.textBox_pId.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView_wOrders);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1456, 696);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Siparişler";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView_wOrders
            // 
            this.dataGridView_wOrders.AllowUserToAddRows = false;
            this.dataGridView_wOrders.AllowUserToDeleteRows = false;
            this.dataGridView_wOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_wOrders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_wOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_wOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_wOrders.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_wOrders.MultiSelect = false;
            this.dataGridView_wOrders.Name = "dataGridView_wOrders";
            this.dataGridView_wOrders.ReadOnly = true;
            this.dataGridView_wOrders.RowTemplate.Height = 25;
            this.dataGridView_wOrders.Size = new System.Drawing.Size(1450, 690);
            this.dataGridView_wOrders.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(155, 400);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 27);
            this.button3.TabIndex = 14;
            this.button3.Text = "Güncelle";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form_WorkerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1464, 729);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_WorkerMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_WorkerMain";
            this.Load += new System.EventHandler(this.Form_WorkerMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_wProducts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_wOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView_wProducts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_pAmount;
        private System.Windows.Forms.TextBox textBox_pPhoto;
        private System.Windows.Forms.TextBox textBox_pPrice;
        private System.Windows.Forms.TextBox textBox_pName;
        private System.Windows.Forms.TextBox textBox_pId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.DataGridView dataGridView_orders;
        private System.Windows.Forms.DataGridView dataGridView_wOrders;
        private System.Windows.Forms.TextBox textbox_pSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.Button button_Exit;
    }
}