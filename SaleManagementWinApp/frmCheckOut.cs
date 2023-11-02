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
            var list = orderDetailDAO.GetAll().Select(p => new { p.OrderId, p.ProductId, p.UnitPrice, p.Quantity, p.Discount }).ToList();
            dgvListCart.DataSource = list;
        }

        private void frmCheckOut_Load(object sender, EventArgs e)
        {

        }

        private void dgvListCart_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var rowSelected = this.dgvListCart.Rows[e.RowIndex];

            }
            btnCheckout.Enabled = false;
            btnRemoveCart.Enabled = true;
        }

        private void btnRemoveCart_Click(object sender, EventArgs e)
        {


        }
    }
}