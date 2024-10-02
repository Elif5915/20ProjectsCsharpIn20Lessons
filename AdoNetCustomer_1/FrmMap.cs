using System;
using System.Windows.Forms;

namespace AdoNetCustomer_1
{
    public partial class FrmMap : Form
    {
        public FrmMap()
        {
            InitializeComponent();
        }

        private void btnCityForm_Click(object sender, EventArgs e)
        {
            FrmCity frmCity = new FrmCity();
            frmCity.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();  // Uygulamayı tamamen sonlandırır
        }

        private void btnCustomerForm_Click(object sender, EventArgs e)
        {
            FrmCustomer frmCustomer = new FrmCustomer();
            frmCustomer.Show();
        }
    }
}
