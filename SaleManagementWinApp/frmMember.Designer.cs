namespace SaleManagementWinApp
{
    partial class frmMember
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
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            txtCompanyName = new System.Windows.Forms.TextBox();
            txtId = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            txtCity = new System.Windows.Forms.TextBox();
            txtCountry = new System.Windows.Forms.TextBox();
            btnSearchMember = new System.Windows.Forms.Button();
            btnAddMember = new System.Windows.Forms.Button();
            btnDeleteMember = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            dgvMemberList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(23, 30);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(17, 15);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(23, 70);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(23, 108);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(94, 15);
            label3.TabIndex = 2;
            label3.Text = "Company Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(23, 144);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(28, 15);
            label4.TabIndex = 3;
            label4.Text = "City";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(23, 184);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(50, 15);
            label5.TabIndex = 4;
            label5.Text = "Country";
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new System.Drawing.Point(138, 105);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new System.Drawing.Size(208, 23);
            txtCompanyName.TabIndex = 5;
            // 
            // txtId
            // 
            txtId.Location = new System.Drawing.Point(138, 27);
            txtId.Name = "txtId";
            txtId.Size = new System.Drawing.Size(208, 23);
            txtId.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(138, 67);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(208, 23);
            txtEmail.TabIndex = 7;
            // 
            // txtCity
            // 
            txtCity.Location = new System.Drawing.Point(138, 141);
            txtCity.Name = "txtCity";
            txtCity.Size = new System.Drawing.Size(208, 23);
            txtCity.TabIndex = 8;
            // 
            // txtCountry
            // 
            txtCountry.Location = new System.Drawing.Point(138, 181);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new System.Drawing.Size(208, 23);
            txtCountry.TabIndex = 9;
            // 
            // btnSearchMember
            // 
            btnSearchMember.Location = new System.Drawing.Point(389, 27);
            btnSearchMember.Name = "btnSearchMember";
            btnSearchMember.Size = new System.Drawing.Size(136, 23);
            btnSearchMember.TabIndex = 10;
            btnSearchMember.Text = "Search";
            btnSearchMember.UseVisualStyleBackColor = true;
            btnSearchMember.Click += btnSearchMember_Click;
            // 
            // btnAddMember
            // 
            btnAddMember.Location = new System.Drawing.Point(42, 238);
            btnAddMember.Name = "btnAddMember";
            btnAddMember.Size = new System.Drawing.Size(75, 23);
            btnAddMember.TabIndex = 11;
            btnAddMember.Text = "Add";
            btnAddMember.UseVisualStyleBackColor = true;
            btnAddMember.Click += btnAddMember_Click;
            // 
            // btnDeleteMember
            // 
            btnDeleteMember.Location = new System.Drawing.Point(159, 238);
            btnDeleteMember.Name = "btnDeleteMember";
            btnDeleteMember.Size = new System.Drawing.Size(75, 23);
            btnDeleteMember.TabIndex = 12;
            btnDeleteMember.Text = "Delete";
            btnDeleteMember.UseVisualStyleBackColor = true;
            btnDeleteMember.Click += btnDeleteMember_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(271, 238);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(75, 23);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dgvMemberList
            // 
            dgvMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMemberList.Location = new System.Drawing.Point(389, 56);
            dgvMemberList.Name = "dgvMemberList";
            dgvMemberList.RowTemplate.Height = 25;
            dgvMemberList.Size = new System.Drawing.Size(378, 205);
            dgvMemberList.TabIndex = 14;
            dgvMemberList.CellContentClick += dgvMemberList_CellContentClick;
            // 
            // frmMember
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(779, 289);
            Controls.Add(dgvMemberList);
            Controls.Add(btnUpdate);
            Controls.Add(btnDeleteMember);
            Controls.Add(btnAddMember);
            Controls.Add(btnSearchMember);
            Controls.Add(txtCountry);
            Controls.Add(txtCity);
            Controls.Add(txtEmail);
            Controls.Add(txtId);
            Controls.Add(txtCompanyName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmMember";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmMember";
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Button btnSearchMember;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button btnDeleteMember;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvMemberList;
    }
}