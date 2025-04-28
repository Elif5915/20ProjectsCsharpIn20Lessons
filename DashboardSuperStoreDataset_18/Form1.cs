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
       
        private void lblProductCount_Load(object sender, EventArgs e)
        {
            #region Widgets
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
            #endregion

            #region Manuel Veri Çekme Charts
            //chart1.Series["Series1"].Points.AddXY("Milano",53);
            //chart1.Series["Series1"].Points.AddXY("Paris", 47);
            //chart1.Series["Series1"].Points.AddXY("Los Angeles", 32);

            //chart2.Series["Series1"].Points.AddXY("Los Angeles", 47);
            //chart2.Series["Series1"].Points.AddXY("Milano", 17);
            //chart2.Series["Series1"].Points.AddXY("Paris", 36);

            //chart3.Series["Series1"].Points.AddXY("Milano", 22);
            //chart3.Series["Series1"].Points.AddXY("Paris", 73);
            #endregion

            #region Dinamik Charts Veri Çekme

            connect.Open();
            SqlCommand command5 = new SqlCommand("select top(7) Country,Count(*) from superstore group by Country order by Count(*) desc", connect);
            SqlDataReader read5 = command5.ExecuteReader();
            while (read5.Read())
            {
                chart1.Series["Series1"].Points.AddXY(read5[0], read5[1]);
            }
            connect.Close();

            connect.Open();
            SqlCommand command6 = new SqlCommand("select top (3) Country,sum(Quantity) from superstore group by Country order by Sum(Quantity) desc;", connect);
            SqlDataReader read6 = command6.ExecuteReader();
            while (read6.Read())
            {
                chart2.Series["Series1"].Points.AddXY(read6[0], read6[1]);
            }
            connect.Close();

            connect.Open();
            SqlCommand command7 = new SqlCommand("select Order_Priority,Count(*) from superstore group by Order_Priority order by Order_Priority desc;", connect);
            SqlDataReader read7 = command7.ExecuteReader();
            while (read7.Read())
            {
                chart3.Series["Series1"].Points.AddXY(read7[0], read7[1]);
            }
            connect.Close();
            #endregion
        }


    }
}
