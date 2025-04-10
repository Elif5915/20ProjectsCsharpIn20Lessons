using JwtToken_12.JWT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JwtToken_12
{
    public partial class FrmEmployee : Form
    {
        public FrmEmployee()
        {
            InitializeComponent();
        }
        public string tokenGet;
        SqlConnection connect = new SqlConnection("Server= DESKTOP-NM06KEK\\SQLKODLAR; initial catalog = Test;integrated security = true");
        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            TokenValidator tokenValidator = new TokenValidator();
            richTextBox1.Text = tokenGet;
            var principal = tokenValidator.ValidatorJwtToken(tokenGet);

            if(principal != null)
            {
                string username = principal.FindFirst(JwtRegisteredClaimNames.Sub).Value;
                MessageBox.Show("Hoşgeldiniz," + username);

                connect.Open();
                SqlCommand command = new SqlCommand("Select *from Employee", connect);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                connect.Close();
            }
            else
            {
                MessageBox.Show("Geçersiz Token!!!");
            }
        }
    }
}
