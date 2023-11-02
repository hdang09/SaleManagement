namespace SaleManagementWinApp
{
    partial class frmOrders
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
            label2 = new System.Windows.Forms.Label();
            dtpStartDate = new System.Windows.Forms.DateTimePicker();
            dtpEndDate = new System.Windows.Forms.DateTimePicker();
            btnSearchOrder = new System.Windows.Forms.Button();
            dgvListOrder = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvListOrder).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(55, 32);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Start Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(328, 32);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "End Date";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new System.Drawing.Point(41, 50);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new System.Drawing.Size(200, 23);
            dtpStartDate.TabIndex = 2;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new System.Drawing.Point(310, 50);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new System.Drawing.Size(200, 23);
            dtpEndDate.TabIndex = 3;
            // 
            // btnSearchOrder
            // 
            btnSearchOrder.Location = new System.Drawing.Point(543, 52);
            btnSearchOrder.Name = "btnSearchOrder";
            btnSearchOrder.Size = new System.Drawing.Size(101, 23);
            btnSearchOrder.TabIndex = 4;
            btnSearchOrder.Text = "Search";
            btnSearchOrder.UseVisualStyleBackColor = true;
            btnSearchOrder.Click += btnSearchOrder_Click;
            // 
            // dgvListOrder
            // 
            dgvListOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListOrder.Location = new System.Drawing.Point(41, 79);
            dgvListOrder.Name = "dgvListOrder";
            dgvListOrder.RowTemplate.Height = 25;
            dgvListOrder.Size = new System.Drawing.Size(603, 295);
            dgvListOrder.TabIndex = 5;
            // 
            // frmOrders
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(675, 386);
            Controls.Add(dgvListOrder);
            Controls.Add(btnSearchOrder);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmOrders";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmOrders";
            ((System.ComponentModel.ISupportInitialize)dgvListOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnSearchOrder;
        private System.Windows.Forms.DataGridView dgvListOrder;
    }
}