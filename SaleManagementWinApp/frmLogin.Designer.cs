namespace SaleManagementWinApp
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            btnLogin = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            txtEmail = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(35, 46);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(35, 109);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.Location = new System.Drawing.Point(181, 158);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(79, 21);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(286, 158);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(79, 21);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(110, 43);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(255, 23);
            txtEmail.TabIndex = 4;
            txtEmail.Text = "admin@fstore.com";
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(110, 106);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(255, 23);
            txtPassword.TabIndex = 5;
            txtPassword.Text = "admin@@";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(400, 198);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmLogin";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Login Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
    }
}
