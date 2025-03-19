using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostgreSqlToDoListApp_10
{
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }
       string connectionString = "Server=localhost;port=5432;Database=PostgreSqlToDoListApp_10;User Id=postgres;Password=123456789";

        void CategoryList()
        {
            try
            {
                var connection = new NpgsqlConnection(connectionString);
                connection.Open();
                string query = "SELECT * FROM \"categories\" order by CategoryId";

                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection);
                DataSet dataset = new DataSet();

                adapter.Fill(dataset);
                if (dataset.Tables.Count > 0)
                {
                    dataGridView1.DataSource = dataset.Tables[0];
                    dataGridView1.AutoGenerateColumns = true;
                }
                else
                {
                    MessageBox.Show("No data available in the table.");
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void FrmCategory_Load(object sender, EventArgs e)
        {
            CategoryList();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            CategoryList();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "insert into \"categories\" (CategoryName) values (@name)";
            using (var command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@name", txtCategoryName.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Kategori Eklendi");
                CategoryList();
                txtCategoryName.Text = "";
            }
            connection.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);

            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "delete from \"categories\" where CategoryId =@id";
            using(var command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                MessageBox.Show("Belirtilmiş olan kategori silindi!");
                CategoryList();
                txtCategoryId.Text = "";
            }
            connection.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            string categoryName = txtCategoryName.Text;

            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "update \"categories\" set CategoryName=@name where CategoryId =@id";
            using(var command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@name", categoryName);
                command.ExecuteNonQuery();
                MessageBox.Show("Kategori başarılıyla güncellendi!");
                CategoryList();
                txtCategoryId.Text = "";
                txtCategoryName.Text = "";

            }
            connection.Close();
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "select * from \"categories\" where CategoryId=@id";
                using(var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using(var adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable data = new DataTable();
                        adapter.Fill(data);
                        dataGridView1.DataSource = data;
                        txtCategoryId.Text = "";
                    }
                }

            }

        }
    }
}
