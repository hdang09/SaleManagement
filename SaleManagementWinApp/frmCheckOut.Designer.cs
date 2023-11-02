namespace SaleManagementWinApp
{
    partial class frmCheckOut
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
            dgvListCart = new System.Windows.Forms.DataGridView();
            btnCheckout = new System.Windows.Forms.Button();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            btnRemoveCart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvListCart).BeginInit();
            SuspendLayout();
            // 
            // dgvListCart
            // 
            dgvListCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListCart.Location = new System.Drawing.Point(12, 71);
            dgvListCart.Name = "dgvListCart";
            dgvListCart.RowTemplate.Height = 25;
            dgvListCart.Size = new System.Drawing.Size(776, 267);
            dgvListCart.TabIndex = 0;
            dgvListCart.CellDoubleClick += dgvListCart_CellDoubleClick;
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new System.Drawing.Point(689, 358);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new System.Drawing.Size(99, 38);
            btnCheckout.TabIndex = 1;
            btnCheckout.Text = "CheckOut";
            btnCheckout.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new System.Drawing.Point(579, 31);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(74, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // btnRemoveCart
            // 
            btnRemoveCart.Location = new System.Drawing.Point(554, 358);
            btnRemoveCart.Name = "btnRemoveCart";
            btnRemoveCart.Size = new System.Drawing.Size(99, 38);
            btnRemoveCart.TabIndex = 3;
            btnRemoveCart.Text = "Remove";
            btnRemoveCart.UseVisualStyleBackColor = true;
            btnRemoveCart.Click += btnRemoveCart_Click;
            // 
            // frmCheckOut
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnRemoveCart);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnCheckout);
            Controls.Add(dgvListCart);
            Name = "frmCheckOut";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmCheckOut";
            ((System.ComponentModel.ISupportInitialize)dgvListCart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListCart;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnRemoveCart;
    }
}