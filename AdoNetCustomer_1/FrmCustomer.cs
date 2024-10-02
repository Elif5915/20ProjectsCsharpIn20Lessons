using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AdoNetCustomer_1
{
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Server= NETCADYAZ; initial catalog = Customer;integrated security = true ");
        private void btnList_Click(object sender, System.EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select c.CustomerId, c.Name,c.Surname,c.Balance, c.Status,ct.CityName from  Customer c\r\ninner join City ct on ct.CityId = c.CustomerCity", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void FrmCustomer_Load(object sender, System.EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select * from City", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cmbCity.ValueMember = "CityId"; //arka planda tutulacak değer
            cmbCity.DisplayMember = "CityName"; //kullanıcıya görünecek kısım
            cmbCity.DataSource = dt;
            //SqlDataReader reader = command.ExecuteReader();
            //while (reader.Read())
            //{
            //    cmbCity.Items.Add(reader.GetString(0));
            //}

            connection.Close();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Customer (Name,Surname,Balance,Status,CustomerCity) values (@name,@surname,@balance,@status,@city)", connection);
            command.Parameters.AddWithValue("@name", txtCustomerName.Text);
            command.Parameters.AddWithValue("@surname", txtCustomerSurname.Text);
            command.Parameters.AddWithValue("@balance", txtBalance.Text);

            if (rbActive.Checked)
            {
                command.Parameters.AddWithValue("@status", true);
            }
            if (rbPassive.Checked)
            {
                command.Parameters.AddWithValue("@status", false);
            }
            command.Parameters.AddWithValue("@city", cmbCity.SelectedValue);
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Transaction Successful");

            txtCustomerName.Text = "";
            txtCustomerSurname.Text = "";
            txtBalance.Text = "";
            cmbCity.SelectedIndex = -1; // combobox içinin temizlenmesi 
            rbActive.Checked = false;
            rbPassive.Checked = false;

        }

        private void btnSearch_Click(object sender, System.EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select *from Customer where Name = @Name", connection);
            command.Parameters.AddWithValue("@Name", txtCustomerName.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();

            txtCustomerName.Text = "";

        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("delete from Customer where CustomerId = @p1", connection);
            command.Parameters.AddWithValue("@p1", txtCustomerId.Text);
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Transaction Successful");
            txtCustomerId.Text = "";

        }

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update Customer set Name =@name,Surname = @surname,Balance =@balance,Status=@status,CustomerCity = @city where CustomerId = @id", connection);
            command.Parameters.AddWithValue("@name", txtCustomerName.Text);
            command.Parameters.AddWithValue("@surname", txtCustomerSurname.Text);
            command.Parameters.AddWithValue("@balance", txtBalance.Text);
            command.Parameters.AddWithValue("@id", txtCustomerId.Text);

            if (rbActive.Checked)
            {
                command.Parameters.AddWithValue("@status", true);
            }
            if (rbPassive.Checked)
            {
                command.Parameters.AddWithValue("@status", false);
            }
            command.Parameters.AddWithValue("@city", cmbCity.SelectedValue);
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Transaction Successful");

            txtCustomerName.Text = "";
            txtCustomerSurname.Text = "";
            txtBalance.Text = "";
            txtCustomerId.Text = "";
            cmbCity.SelectedIndex = -1; // combobox içinin temizlenmesi 
            rbActive.Checked = false;
            rbPassive.Checked = false;

        }

        private void btnProcedure_Click(object sender, System.EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("execute CustomerListWithCity", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }
    }
}
