namespace DSE243F_FINAL_PROKECT
{
    partial class Manager_Dialog_AddProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblExVal1 = new System.Windows.Forms.Label();
            this.lblExVal2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.nmInitStock = new System.Windows.Forms.NumericUpDown();
            this.nmId = new System.Windows.Forms.NumericUpDown();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtVal2 = new System.Windows.Forms.TextBox();
            this.txtVal1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmInitStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmId)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-15, -12);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1093, 79);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(94)))), ((int)(((byte)(60)))));
            this.label2.Location = new System.Drawing.Point(11, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product ID";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(174, 412);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(178, 55);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add Product";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(360, 412);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(178, 55);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(94)))), ((int)(((byte)(60)))));
            this.label3.Location = new System.Drawing.Point(11, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Product Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(94)))), ((int)(((byte)(60)))));
            this.label4.Location = new System.Drawing.Point(11, 168);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "Product Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(94)))), ((int)(((byte)(60)))));
            this.label5.Location = new System.Drawing.Point(11, 218);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "Initial Stock";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(94)))), ((int)(((byte)(60)))));
            this.label6.Location = new System.Drawing.Point(11, 266);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 28);
            this.label6.TabIndex = 12;
            this.label6.Text = "Category";
            // 
            // lblExVal1
            // 
            this.lblExVal1.AutoSize = true;
            this.lblExVal1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblExVal1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(94)))), ((int)(((byte)(60)))));
            this.lblExVal1.Location = new System.Drawing.Point(11, 320);
            this.lblExVal1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExVal1.Name = "lblExVal1";
            this.lblExVal1.Size = new System.Drawing.Size(75, 28);
            this.lblExVal1.TabIndex = 13;
            this.lblExVal1.Text = "Value 1";
            // 
            // lblExVal2
            // 
            this.lblExVal2.AutoSize = true;
            this.lblExVal2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblExVal2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(94)))), ((int)(((byte)(60)))));
            this.lblExVal2.Location = new System.Drawing.Point(11, 358);
            this.lblExVal2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExVal2.Name = "lblExVal2";
            this.lblExVal2.Size = new System.Drawing.Size(75, 28);
            this.lblExVal2.TabIndex = 14;
            this.lblExVal2.Text = "Value 2";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtName.Location = new System.Drawing.Point(174, 128);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(341, 34);
            this.txtName.TabIndex = 15;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPrice.Location = new System.Drawing.Point(174, 168);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(341, 34);
            this.txtPrice.TabIndex = 16;
            // 
            // nmInitStock
            // 
            this.nmInitStock.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nmInitStock.Location = new System.Drawing.Point(174, 216);
            this.nmInitStock.Name = "nmInitStock";
            this.nmInitStock.Size = new System.Drawing.Size(120, 34);
            this.nmInitStock.TabIndex = 17;
            // 
            // nmId
            // 
            this.nmId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nmId.Location = new System.Drawing.Point(174, 83);
            this.nmId.Name = "nmId";
            this.nmId.Size = new System.Drawing.Size(120, 34);
            this.nmId.TabIndex = 18;
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Poster",
            "Book"});
            this.cmbCategory.Location = new System.Drawing.Point(173, 263);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(342, 36);
            this.cmbCategory.TabIndex = 19;
            this.cmbCategory.SelectedValueChanged += new System.EventHandler(this.cmbCategory_SelectedValueChanged);
            // 
            // txtVal2
            // 
            this.txtVal2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtVal2.Location = new System.Drawing.Point(174, 355);
            this.txtVal2.Name = "txtVal2";
            this.txtVal2.Size = new System.Drawing.Size(341, 34);
            this.txtVal2.TabIndex = 20;
            // 
            // txtVal1
            // 
            this.txtVal1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtVal1.Location = new System.Drawing.Point(173, 314);
            this.txtVal1.Name = "txtVal1";
            this.txtVal1.Size = new System.Drawing.Size(341, 34);
            this.txtVal1.TabIndex = 20;
            // 
            // Manager_Dialog_AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(551, 480);
            this.Controls.Add(this.txtVal1);
            this.Controls.Add(this.txtVal2);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.nmId);
            this.Controls.Add(this.nmInitStock);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblExVal2);
            this.Controls.Add(this.lblExVal1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Manager_Dialog_AddProduct";
            this.Text = "Manager_Dialog_AddProduct";
            this.Load += new System.EventHandler(this.Manager_Dialog_AddProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmInitStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Button btnAdd;
        protected System.Windows.Forms.Button btnClose;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Label label6;
        protected System.Windows.Forms.Label lblExVal1;
        protected System.Windows.Forms.Label lblExVal2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.NumericUpDown nmInitStock;
        private System.Windows.Forms.NumericUpDown nmId;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox txtVal2;
        private System.Windows.Forms.TextBox txtVal1;
    }
}