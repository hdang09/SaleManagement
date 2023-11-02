using DataAccessObjects;
using Repositories.Models;
using System;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace SaleManagementWinApp
{
    public partial class frmLogin : Form
    {
        MemberDAO memberDAO;
        public frmLogin()
        {
            memberDAO = new MemberDAO();
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            var email = txtEmail.Text;
            var password = txtPassword.Text;

            string fileName = "appsettings.json";
            string json = File.ReadAllText(fileName);  //read text from JSON

            // deserialize from JSOn file --> Member obj
            var adminAccount = JsonSerializer.Deserialize<Member>(json, null);

            string emailAd = adminAccount.Email;
            string passwordAd = adminAccount.Password;

            var account = memberDAO.GetAll().Where(p => p.Email.Equals(email.Trim()) && p.Password.Equals(password.Trim())).FirstOrDefault();
            if (account != null)
            {
                frmCreateOrder frmOrder = new frmCreateOrder();
                frmOrder.ShowDialog();

                this.Hide();
            }
            else if (emailAd.Equals(email.Trim()) && passwordAd.Equals(password.Trim()))
            {
                frmMain mainForm = new frmMain();
                mainForm.ShowDialog();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid email or password", "Warning", MessageBoxButtons.OK);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Application.Exit();
    }
}