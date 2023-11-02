using DataAccessObjects;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SaleManagementWinApp
{
    public partial class frmCheckOut : Form
    {
        OrderDetailDAO orderDetailDAO = new OrderDetailDAO();
        public frmCheckOut()
        {
            InitializeComponent();
        }

        private void frmCheckOut_Load(object sender, EventArgs e)
        {

        }

        private void dgvListCart_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnRemoveCart_Click(object sender, EventArgs e)
        {

                
        }
    }
}
