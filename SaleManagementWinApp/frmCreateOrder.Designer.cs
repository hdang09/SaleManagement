﻿namespace SaleManagementWinApp
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
            btnCart = new System.Windows.Forms.Button();
            dgvListProduct = new System.Windows.Forms.DataGridView();
            btnBuy = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            txtQuantity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvListProduct).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(16, 23);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(88, 32);
            label1.TabIndex = 0;
            label1.Text = "Home";
            // 
            // txtUnitInStock
            // 
            txtUnitInStock.Location = new System.Drawing.Point(686, 60);
            txtUnitInStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtUnitInStock.Name = "txtUnitInStock";
            txtUnitInStock.Size = new System.Drawing.Size(123, 27);
            txtUnitInStock.TabIndex = 28;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new System.Drawing.Point(520, 60);
            txtUnitPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new System.Drawing.Size(117, 27);
            txtUnitPrice.TabIndex = 25;
            // 
            // txtProductName
            // 
            txtProductName.Location = new System.Drawing.Point(353, 60);
            txtProductName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new System.Drawing.Size(129, 27);
            txtProductName.TabIndex = 24;
            // 
            // txtProductID
            // 
            txtProductID.Location = new System.Drawing.Point(187, 60);
            txtProductID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new System.Drawing.Size(133, 27);
            txtProductID.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(692, 36);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(90, 20);
            label7.TabIndex = 22;
            label7.Text = "Unit in stock";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(541, 31);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(72, 20);
            label3.TabIndex = 19;
            label3.Text = "Unit Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(378, 36);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(104, 20);
            label2.TabIndex = 18;
            label2.Text = "Product Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(207, 36);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(79, 20);
            label5.TabIndex = 17;
            label5.Text = "Product ID";
            // 
            // btnSearchProduct
            // 
            btnSearchProduct.Location = new System.Drawing.Point(771, 133);
            btnSearchProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSearchProduct.Name = "btnSearchProduct";
            btnSearchProduct.Size = new System.Drawing.Size(123, 32);
            btnSearchProduct.TabIndex = 29;
            btnSearchProduct.Text = "Search";
            btnSearchProduct.UseVisualStyleBackColor = true;
            btnSearchProduct.Click += btnSearchProduct_Click;
            // 
            // btnCart
            // 
            btnCart.BackColor = System.Drawing.Color.Cyan;
            btnCart.Location = new System.Drawing.Point(914, 133);
            btnCart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCart.Name = "btnCart";
            btnCart.Size = new System.Drawing.Size(96, 32);
            btnCart.TabIndex = 32;
            btnCart.Text = "Cart";
            btnCart.UseVisualStyleBackColor = false;
            btnCart.Click += btnCart_Click;
            // 
            // dgvListProduct
            // 
            dgvListProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListProduct.Location = new System.Drawing.Point(125, 133);
            dgvListProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvListProduct.Name = "dgvListProduct";
            dgvListProduct.RowHeadersWidth = 51;
            dgvListProduct.RowTemplate.Height = 25;
            dgvListProduct.Size = new System.Drawing.Size(629, 412);
            dgvListProduct.TabIndex = 33;
            dgvListProduct.CellClick += dgvListProduct_CellClick;
            // 
            // btnBuy
            // 
            btnBuy.BackColor = System.Drawing.Color.Red;
            btnBuy.ForeColor = System.Drawing.SystemColors.ControlText;
            btnBuy.Location = new System.Drawing.Point(771, 188);
            btnBuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new System.Drawing.Size(123, 55);
            btnBuy.TabIndex = 3;
            btnBuy.Text = "Buy";
            btnBuy.UseVisualStyleBackColor = false;
            btnBuy.Click += btnBuy_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(869, 36);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(65, 20);
            label4.TabIndex = 34;
            label4.Text = "Quantity";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new System.Drawing.Point(847, 59);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new System.Drawing.Size(125, 27);
            txtQuantity.TabIndex = 35;
            txtQuantity.Text = "0";
            
            // 
            // frmCreateOrder
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1112, 724);
            Controls.Add(txtQuantity);
            Controls.Add(label4);
            Controls.Add(btnBuy);
            Controls.Add(dgvListProduct);
            Controls.Add(btnCart);
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
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "frmCreateOrder";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmCreateOrder";
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnBuy;
    }
}