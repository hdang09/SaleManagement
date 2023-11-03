using Repositories.Models;
using System;
using DataAccessObjects;
using System.Windows.Forms;
using System.Linq;

namespace SaleManagementWinApp
{
    public partial class frmCreateOrder : Form
    {
        OrderDAO orderDAO = new OrderDAO();
        ProductDAO productDAO = new ProductDAO();
        public frmCreateOrder()
        {
            InitializeComponent();
            var list = productDAO.GetAll().Select(p => new {  p.ProductName, p.UnitPrice, p.UnitsInStock }).ToList();
            dgvListProduct.DataSource = list;
        }

        private void btnBuyProduct1_Click(object sender, EventArgs e)
        {
            var Order = new Order();
            orderDAO = new OrderDAO();
            if (orderDAO.GetAll().Where(p => p.OrderId.Equals(Order.OrderId)).FirstOrDefault() != null)
            {
                MessageBox.Show("OrderId Existed ", "hello", MessageBoxButtons.OK);
                return;
            }
            orderDAO.Create(Order);
            MessageBox.Show("Order created successfully.");

        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            frmCheckOut frmCheckOut = new frmCheckOut();
            frmCheckOut.ShowDialog();
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {

            frmOrders frmOrder = new frmOrders();
            frmOrder.ShowDialog();
        }

        private void dgvListProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
