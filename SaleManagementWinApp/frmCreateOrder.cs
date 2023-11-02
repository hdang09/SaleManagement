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
        }

        private void btnBuyProduct1_Click(object sender, EventArgs e)
        {

        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {

                
        }
    }
}
