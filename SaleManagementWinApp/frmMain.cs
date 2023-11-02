using System;
using System.Windows.Forms;

namespace SaleManagementWinApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e) => this.Close();

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e) { Application.Exit(); }
    }
}
