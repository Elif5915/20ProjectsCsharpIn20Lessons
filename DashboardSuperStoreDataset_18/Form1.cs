using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashboardSuperStoreDataset_18
{
    public partial class lblProductCount : Form
    {
        public lblProductCount()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection("Server=DESKTOP-NM06KEK\\SQLKODLAR;initial catalog=Db20Lesson20Project17;integrated security=true");
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblProductCount_Load(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("Select Count(*) from superstore",connect);
            SqlDataReader read = command.ExecuteReader();
            while(read.Read())
            {
                lblProductTotal.Text = read[0].ToString();
            }
            connect.Close();

            connect.Open();
            SqlCommand command2 = new SqlCommand("Select Count(Distinct(State)) from [superstore]", connect);
            SqlDataReader read2 = command2.ExecuteReader();
            while (read2.Read())
            {
                lblCityCount.Text = read2[0].ToString();
            }
            connect.Close();

            connect.Open();
            SqlCommand command3 = new SqlCommand("Select Count(Distinct(Sub_Category)) from [superstore]", connect);
            SqlDataReader read3 = command3.ExecuteReader();
            while (read3.Read())
            {
                lblCategoryCount.Text = read3[0].ToString();
            }
            connect.Close();

            connect.Open();
            SqlCommand command4 = new SqlCommand("Select Count(*) from [superstore] where Country='Turkey'", connect);
            SqlDataReader read4 = command4.ExecuteReader();
            while (read4.Read())
            {
                lblTurkeyOrder.Text = read4[0].ToString();
            }
            connect.Close();

        }
    }
}
