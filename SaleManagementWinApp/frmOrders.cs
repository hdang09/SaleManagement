using DataAccessObjects;
using System.Linq;
using System.Windows.Forms;

namespace SaleManagementWinApp
{
    public partial class frmOrders : Form
    {
        OrderDAO orderDAO = new OrderDAO();
        public frmOrders()
        {
            InitializeComponent();
            
        }

        private void btnSearchOrder_Click(object sender, System.EventArgs e)
        {
            
        }
    }
}
