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
    public partial class FrmToDoListApp : Form
    {
        public FrmToDoListApp()
        {
            InitializeComponent();
        }

        private void FrmToDoListApp_Load(object sender, EventArgs e)
        {
            NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;port=5432;Database=PostgreSqlToDoListApp_10;User Id=postgres;Password=123456789");

            try
            {
                
                string query = "SELECT * FROM \"ToDoLists\"";  

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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }





        }
        
    }
}
