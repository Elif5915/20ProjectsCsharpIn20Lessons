using JwtToken_12.JWT;
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

namespace JwtToken_12
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection("Server= DESKTOP-NM06KEK\\SQLKODLAR; initial catalog = Test;integrated security = true");
        private void btnLogin_Click(object sender, EventArgs e)
        {
            TokenGenerator token = new TokenGenerator();

            connect.Open();
            SqlCommand command = new SqlCommand("select *from Users where UserName=@username and Password=@password", connect);
            command.Parameters.AddWithValue("@username", txtUserName.Text);
            command.Parameters.AddWithValue("@password", txtPassword.Text);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            if(sqlDataReader.Read())
            {
                string tokenCreate = token.GenerateJwtToken2(txtUserName.Text);
                //MessageBox.Show(tokenCreate);
                FrmEmployee frm = new FrmEmployee();
                frm.tokenGet = tokenCreate;
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı ya da Şifre");
                txtPassword.Clear();
                txtUserName.Clear();
                txtUserName.Focus(); //imleci yeniden kullanıcı adına odaklasın demiş olduk.
            }
            connect.Close();
        }
    }
}
