using DataAccessObjects;
using Repositories.Models;
using System.Linq;
using System.Windows.Forms;

namespace SaleManagementWinApp
{
    public partial class frmProducts : Form
    {
        ProductDAO productsDAO = new ProductDAO();
        public frmProducts()
        {
            InitializeComponent();
            

        }

        private void button1_Click(object sender, System.EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, System.EventArgs e)
        {

            
        }

        private void dgvProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void btnCreate_Click(object sender, System.EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            
        }
    }
}
