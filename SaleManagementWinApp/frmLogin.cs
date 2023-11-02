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

        }

        private void btnCancel_Click(object sender, EventArgs e) => Application.Exit();
    }
}
