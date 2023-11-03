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
            MessageBox.Show("Successful", "You Was Pay!!!");
            
        }

        private void dgvListCart_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var rowSelected = this.dgvListCart.Rows[e.RowIndex];
               // rowSelected.Cells["City"].Value;
                //rowSelected.Cells[3].Value;

            }
            btnCheckout.Enabled = false;// bam vo la o check out bi mo di ko cho sai nua
            btnRemoveCart.Enabled = true;//duoc cho phep nhan khi remove cart
        }

        private void btnRemoveCart_Click(object sender, EventArgs e)
        {
            // code cho xong

        }
    }
}