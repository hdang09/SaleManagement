namespace SaleManagementWinApp
{
    partial class frmCreateOrder
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
            label1 = new System.Windows.Forms.Label();
            txtUnitInStock = new System.Windows.Forms.TextBox();
            txtUnitPrice = new System.Windows.Forms.TextBox();
            txtProductName = new System.Windows.Forms.TextBox();
            txtProductID = new System.Windows.Forms.MaskedTextBox();
            label7 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            btnSearchProduct = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            btnBuyProduct1 = new System.Windows.Forms.Button();
            lbPrice = new System.Windows.Forms.Label();
            lbProductName = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            btnBuyProduct2 = new System.Windows.Forms.Button();
            lbPrice1 = new System.Windows.Forms.Label();
            lbProductName1 = new System.Windows.Forms.Label();
            groupBox3 = new System.Windows.Forms.GroupBox();
            btnBuyProduct3 = new System.Windows.Forms.Button();
            lbPrice2 = new System.Windows.Forms.Label();
            lbProductName2 = new System.Windows.Forms.Label();
            groupBox4 = new System.Windows.Forms.GroupBox();
            btnBuyProduct4 = new System.Windows.Forms.Button();
            lbPrice3 = new System.Windows.Forms.Label();
            lbProductName3 = new System.Windows.Forms.Label();
            groupBox5 = new System.Windows.Forms.GroupBox();
            btnBuyProduct5 = new System.Windows.Forms.Button();
            lbPrice4 = new System.Windows.Forms.Label();
            lbProductName4 = new System.Windows.Forms.Label();
            btnCart = new System.Windows.Forms.Button();
            dgvListProduct = new System.Windows.Forms.DataGridView();
            button1 = new System.Windows.Forms.Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListProduct).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(14, 17);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(69, 25);
            label1.TabIndex = 0;
            label1.Text = "Home";
            // 
            // txtUnitInStock
            // 
            txtUnitInStock.Location = new System.Drawing.Point(675, 45);
            txtUnitInStock.Name = "txtUnitInStock";
            txtUnitInStock.Size = new System.Drawing.Size(209, 23);
            txtUnitInStock.TabIndex = 28;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new System.Drawing.Point(513, 45);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new System.Drawing.Size(146, 23);
            txtUnitPrice.TabIndex = 25;
            // 
            // txtProductName
            // 
            txtProductName.Location = new System.Drawing.Point(309, 45);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new System.Drawing.Size(179, 23);
            txtProductName.TabIndex = 24;
            // 
            // txtProductID
            // 
            txtProductID.Location = new System.Drawing.Point(164, 45);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new System.Drawing.Size(117, 23);
            txtProductID.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(691, 27);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(73, 15);
            label7.TabIndex = 22;
            label7.Text = "Unit in stock";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(529, 27);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(58, 15);
            label3.TabIndex = 19;
            label3.Text = "Unit Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(331, 27);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(84, 15);
            label2.TabIndex = 18;
            label2.Text = "Product Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(181, 27);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(63, 15);
            label5.TabIndex = 17;
            label5.Text = "Product ID";
            // 
            // btnSearchProduct
            // 
            btnSearchProduct.Location = new System.Drawing.Point(675, 100);
            btnSearchProduct.Name = "btnSearchProduct";
            btnSearchProduct.Size = new System.Drawing.Size(108, 24);
            btnSearchProduct.TabIndex = 29;
            btnSearchProduct.Text = "Search";
            btnSearchProduct.UseVisualStyleBackColor = true;
            btnSearchProduct.Click += btnSearchProduct_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBuyProduct1);
            groupBox1.Controls.Add(lbPrice);
            groupBox1.Controls.Add(lbProductName);
            groupBox1.Location = new System.Drawing.Point(109, 415);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(84, 99);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            // 
            // btnBuyProduct1
            // 
            btnBuyProduct1.BackColor = System.Drawing.Color.Red;
            btnBuyProduct1.ForeColor = System.Drawing.SystemColors.ControlText;
            btnBuyProduct1.Location = new System.Drawing.Point(0, 71);
            btnBuyProduct1.Name = "btnBuyProduct1";
            btnBuyProduct1.Size = new System.Drawing.Size(84, 28);
            btnBuyProduct1.TabIndex = 2;
            btnBuyProduct1.Text = "Buy";
            btnBuyProduct1.UseVisualStyleBackColor = false;
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.ForeColor = System.Drawing.Color.Red;
            lbPrice.Location = new System.Drawing.Point(6, 43);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new System.Drawing.Size(64, 15);
            lbPrice.TabIndex = 1;
            lbPrice.Text = "20000.0000";
            // 
            // lbProductName
            // 
            lbProductName.AutoSize = true;
            lbProductName.ForeColor = System.Drawing.Color.DarkOrange;
            lbProductName.Location = new System.Drawing.Point(6, 19);
            lbProductName.Name = "lbProductName";
            lbProductName.Size = new System.Drawing.Size(41, 15);
            lbProductName.TabIndex = 0;
            lbProductName.Text = "Candy";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnBuyProduct2);
            groupBox2.Controls.Add(lbPrice1);
            groupBox2.Controls.Add(lbProductName1);
            groupBox2.Location = new System.Drawing.Point(234, 415);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(84, 99);
            groupBox2.TabIndex = 31;
            groupBox2.TabStop = false;
            // 
            // btnBuyProduct2
            // 
            btnBuyProduct2.BackColor = System.Drawing.Color.Red;
            btnBuyProduct2.ForeColor = System.Drawing.SystemColors.ControlText;
            btnBuyProduct2.Location = new System.Drawing.Point(0, 71);
            btnBuyProduct2.Name = "btnBuyProduct2";
            btnBuyProduct2.Size = new System.Drawing.Size(84, 28);
            btnBuyProduct2.TabIndex = 2;
            btnBuyProduct2.Text = "Buy";
            btnBuyProduct2.UseVisualStyleBackColor = false;
            // 
            // lbPrice1
            // 
            lbPrice1.AutoSize = true;
            lbPrice1.ForeColor = System.Drawing.Color.Red;
            lbPrice1.Location = new System.Drawing.Point(6, 43);
            lbPrice1.Name = "lbPrice1";
            lbPrice1.Size = new System.Drawing.Size(64, 15);
            lbPrice1.TabIndex = 1;
            lbPrice1.Text = "30000.0000";
            // 
            // lbProductName1
            // 
            lbProductName1.AutoSize = true;
            lbProductName1.ForeColor = System.Drawing.Color.DarkOrange;
            lbProductName1.Location = new System.Drawing.Point(6, 20);
            lbProductName1.Name = "lbProductName1";
            lbProductName1.Size = new System.Drawing.Size(77, 15);
            lbProductName1.TabIndex = 0;
            lbProductName1.Text = "Mixed Candy";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnBuyProduct3);
            groupBox3.Controls.Add(lbPrice2);
            groupBox3.Controls.Add(lbProductName2);
            groupBox3.Location = new System.Drawing.Point(355, 415);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(84, 99);
            groupBox3.TabIndex = 31;
            groupBox3.TabStop = false;
            // 
            // btnBuyProduct3
            // 
            btnBuyProduct3.BackColor = System.Drawing.Color.Red;
            btnBuyProduct3.ForeColor = System.Drawing.SystemColors.ControlText;
            btnBuyProduct3.Location = new System.Drawing.Point(0, 71);
            btnBuyProduct3.Name = "btnBuyProduct3";
            btnBuyProduct3.Size = new System.Drawing.Size(84, 28);
            btnBuyProduct3.TabIndex = 2;
            btnBuyProduct3.Text = "Buy";
            btnBuyProduct3.UseVisualStyleBackColor = false;
            // 
            // lbPrice2
            // 
            lbPrice2.AutoSize = true;
            lbPrice2.ForeColor = System.Drawing.Color.Red;
            lbPrice2.Location = new System.Drawing.Point(6, 43);
            lbPrice2.Name = "lbPrice2";
            lbPrice2.Size = new System.Drawing.Size(64, 15);
            lbPrice2.TabIndex = 1;
            lbPrice2.Text = "15000.0000";
            // 
            // lbProductName2
            // 
            lbProductName2.AutoSize = true;
            lbProductName2.ForeColor = System.Drawing.Color.DarkOrange;
            lbProductName2.Location = new System.Drawing.Point(6, 19);
            lbProductName2.Name = "lbProductName2";
            lbProductName2.Size = new System.Drawing.Size(33, 15);
            lbProductName2.TabIndex = 0;
            lbProductName2.Text = "Cake";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnBuyProduct4);
            groupBox4.Controls.Add(lbPrice3);
            groupBox4.Controls.Add(lbProductName3);
            groupBox4.Location = new System.Drawing.Point(473, 415);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(84, 99);
            groupBox4.TabIndex = 31;
            groupBox4.TabStop = false;
            // 
            // btnBuyProduct4
            // 
            btnBuyProduct4.BackColor = System.Drawing.Color.Red;
            btnBuyProduct4.ForeColor = System.Drawing.SystemColors.ControlText;
            btnBuyProduct4.Location = new System.Drawing.Point(0, 71);
            btnBuyProduct4.Name = "btnBuyProduct4";
            btnBuyProduct4.Size = new System.Drawing.Size(84, 28);
            btnBuyProduct4.TabIndex = 2;
            btnBuyProduct4.Text = "Buy";
            btnBuyProduct4.UseVisualStyleBackColor = false;
            // 
            // lbPrice3
            // 
            lbPrice3.AutoSize = true;
            lbPrice3.ForeColor = System.Drawing.Color.Red;
            lbPrice3.Location = new System.Drawing.Point(6, 43);
            lbPrice3.Name = "lbPrice3";
            lbPrice3.Size = new System.Drawing.Size(64, 15);
            lbPrice3.TabIndex = 1;
            lbPrice3.Text = "10000.0000";
            // 
            // lbProductName3
            // 
            lbProductName3.AutoSize = true;
            lbProductName3.ForeColor = System.Drawing.Color.DarkOrange;
            lbProductName3.Location = new System.Drawing.Point(6, 19);
            lbProductName3.Name = "lbProductName3";
            lbProductName3.Size = new System.Drawing.Size(35, 15);
            lbProductName3.TabIndex = 0;
            lbProductName3.Text = "Pepsi";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnBuyProduct5);
            groupBox5.Controls.Add(lbPrice4);
            groupBox5.Controls.Add(lbProductName4);
            groupBox5.Location = new System.Drawing.Point(600, 415);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new System.Drawing.Size(84, 99);
            groupBox5.TabIndex = 31;
            groupBox5.TabStop = false;
            // 
            // btnBuyProduct5
            // 
            btnBuyProduct5.BackColor = System.Drawing.Color.Red;
            btnBuyProduct5.ForeColor = System.Drawing.SystemColors.ControlText;
            btnBuyProduct5.Location = new System.Drawing.Point(0, 71);
            btnBuyProduct5.Name = "btnBuyProduct5";
            btnBuyProduct5.Size = new System.Drawing.Size(84, 28);
            btnBuyProduct5.TabIndex = 2;
            btnBuyProduct5.Text = "Buy";
            btnBuyProduct5.UseVisualStyleBackColor = false;
            // 
            // lbPrice4
            // 
            lbPrice4.AutoSize = true;
            lbPrice4.ForeColor = System.Drawing.Color.Red;
            lbPrice4.Location = new System.Drawing.Point(6, 43);
            lbPrice4.Name = "lbPrice4";
            lbPrice4.Size = new System.Drawing.Size(64, 15);
            lbPrice4.TabIndex = 1;
            lbPrice4.Text = "15000.0000";
            // 
            // lbProductName4
            // 
            lbProductName4.AutoSize = true;
            lbProductName4.ForeColor = System.Drawing.Color.DarkOrange;
            lbProductName4.Location = new System.Drawing.Point(6, 19);
            lbProductName4.Name = "lbProductName4";
            lbProductName4.Size = new System.Drawing.Size(73, 15);
            lbProductName4.TabIndex = 0;
            lbProductName4.Text = "Snack Oshi's";
            // 
            // btnCart
            // 
            btnCart.BackColor = System.Drawing.Color.Cyan;
            btnCart.Location = new System.Drawing.Point(800, 100);
            btnCart.Name = "btnCart";
            btnCart.Size = new System.Drawing.Size(84, 24);
            btnCart.TabIndex = 32;
            btnCart.Text = "Cart";
            btnCart.UseVisualStyleBackColor = false;
            btnCart.Click += btnCart_Click;
            // 
            // dgvListProduct
            // 
            dgvListProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListProduct.Location = new System.Drawing.Point(109, 100);
            dgvListProduct.Name = "dgvListProduct";
            dgvListProduct.RowTemplate.Height = 25;
            dgvListProduct.Size = new System.Drawing.Size(550, 309);
            dgvListProduct.TabIndex = 33;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Red;
            button1.ForeColor = System.Drawing.SystemColors.ControlText;
            button1.Location = new System.Drawing.Point(675, 141);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(108, 41);
            button1.TabIndex = 3;
            button1.Text = "Buy";
            button1.UseVisualStyleBackColor = false;
            // 
            // frmCreateOrder
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(973, 543);
            Controls.Add(button1);
            Controls.Add(dgvListProduct);
            Controls.Add(btnCart);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Controls.Add(groupBox5);
            Controls.Add(groupBox1);
            Controls.Add(btnSearchProduct);
            Controls.Add(txtUnitInStock);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtProductName);
            Controls.Add(txtProductID);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "frmCreateOrder";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmCreateOrder";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUnitInStock;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.MaskedTextBox txtProductID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearchProduct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuyProduct1;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuyProduct2;
        private System.Windows.Forms.Label lbPrice1;
        private System.Windows.Forms.Label lbProductName1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBuyProduct3;
        private System.Windows.Forms.Label lbPrice2;
        private System.Windows.Forms.Label lbProductName2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnBuyProduct4;
        private System.Windows.Forms.Label lbPrice3;
        private System.Windows.Forms.Label lbProductName3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnBuyProduct5;
        private System.Windows.Forms.Label lbPrice4;
        private System.Windows.Forms.Label lbProductName4;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.DataGridView dgvListProduct;
        private System.Windows.Forms.Button button1;
    }
}