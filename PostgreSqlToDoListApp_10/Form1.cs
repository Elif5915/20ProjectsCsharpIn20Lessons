using Npgsql;
using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
   
    string connectionString = "Server=localhost;port=5432;Database=PostgreSqlToDoListApp_10;User Id=postgres;Password=123456789";
        void ToDoList()
        {
            try
            {
                var connection = new NpgsqlConnection(connectionString);
                connection.Open();
                string query = "SELECT * FROM \"todolists\"";

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

        void CategoryList()
        {
            try
            {
                var connection = new NpgsqlConnection(connectionString);
                connection.Open();
                string query = "SELECT * FROM \"categories\"";

                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection);
                DataSet dataset = new DataSet();

                adapter.Fill(dataset);
                if (dataset.Tables.Count > 0)
                {
                    cmbCategory.DisplayMember = "categoryname";
                    cmbCategory.ValueMember = "categoryid";
                    cmbCategory.DataSource = dataset.Tables[0];
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
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCategoryList_Click(object sender, EventArgs e)
        {
            FrmCategory category = new FrmCategory();
            category.Show();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            ToDoList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToDoList();
            CategoryList();
        }

        private void btnListAll_Click(object sender, EventArgs e)
        {
            try
            {
                var connection = new NpgsqlConnection(connectionString);
                connection.Open();
                string query = "select title,description,status,priority,categoryname from todolists\r\ninner join categories\r\non todolists.categoryid = categories.categoryid";

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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int categoryid = int.Parse(cmbCategory.SelectedValue.ToString());
            string title = txtTitle.Text;
            string priority = txtPriority.Text;
            string desc = txtDescription.Text;

            BitArray status = new BitArray(1); // Status için BitArray oluştur
            status.Set(0, rdbCompleted.Checked);  //tamamlnadıysa 1 devam ediyorsa 0 olacak.
           
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "insert into \"todolists\" (title,description,status,priority,categoryid) values (@title,@description,@status,@priority,@categoryid)";
            using (var command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@description", desc);
                command.Parameters.AddWithValue("@status", NpgsqlTypes.NpgsqlDbType.Bit,status);
                command.Parameters.AddWithValue("@priority", priority);
                command.Parameters.AddWithValue("@categoryid", categoryid);
                command.ExecuteNonQuery();
                MessageBox.Show("Yapılacak işlem Eklendi");
                ToDoList();
                txtTitle.Text = "";
                txtPriority.Text = "";
                txtDescription.Text = "";
            }
            connection.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);

            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "delete from \"todolists\" where todolistid =@id";
            using (var command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                MessageBox.Show("Belirtilmiş olan işlem silindi!");
                ToDoList();
                txtId.Text = "";
            }
            connection.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            int categoryid = int.Parse(cmbCategory.SelectedValue.ToString());
            string title = txtTitle.Text;
            string priority = txtPriority.Text;
            string desc = txtDescription.Text;

            BitArray status = new BitArray(1); // Status için BitArray oluştur
            status.Set(0, rdbCompleted.Checked);  //tamamlnadıysa 1 devam ediyorsa 0 olacak.

            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "update \"todolists\" set title=@title,description=@description,status=@status,priority=@priority,categoryid=@categoryid where todolistid =@id";
            using (var command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@description", desc);
                command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@priority", priority);
                command.Parameters.AddWithValue("@categoryid", categoryid);
                command.ExecuteNonQuery();
                MessageBox.Show("Yapılacak işlem başarılıyla güncellendi!");
                ToDoList();
                txtTitle.Text = "";
                txtPriority.Text = "";
                txtDescription.Text = "";
                txtId.Text = "";
                cmbCategory.SelectedValue = 0;
            }
            connection.Close();
        }

        private void btnCompleted_Click(object sender, EventArgs e)
        {
            try
            {
                var connection = new NpgsqlConnection(connectionString);
                connection.Open();
                string query = "SELECT * FROM \"todolists\" where status='1'";

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

        private void btnContinue_Click(object sender, EventArgs e)
        {
            try
            {
                var connection = new NpgsqlConnection(connectionString);
                connection.Open();
                string query = "SELECT * FROM \"todolists\" where status='0'";

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
    }
}
