﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetCustomer_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection("Server= NETCADYAZ; initial catalog = Customer;integrated security = true");
        private void btnList_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand sql = new SqlCommand("Select *from City", connect);// burada sql tarafındaki sorgumuzu yazıyor belirtiyoruz.
            SqlDataAdapter adapter = new SqlDataAdapter(sql); //SqlDataAdapter hafızaya verdiğimiz sorgudan gelen dataları tutup onları ekrana yansıtmamızı sağlayan köprü görevinde 
            DataTable dataTable = new DataTable(); // sanal tablo nesnesi oluşturuyoruz
            adapter.Fill(dataTable); //hafızaya almış olduğumuz sorgu var.bu sorgudan gelen verileri datagrid viewde göstermeden önce datatable sanal tablonun içerisine doldur demiş oluyorum.
            dataGridView1.DataSource = dataTable; 
            connect.Close();

            /*
            Sqlcommand  = > biz sorgumuzu oluşturduk
            adapter => biz sqlcommand ile oluşturduğumuz sorguyu Adapter içerine gönderiyoruz adapter gelen datayı hafızaya alıp onu datagrid view göndermek için 
                       köprüsü görevi görecek.
            Datatable => gelen verileri hafızaya almak için sanal tablo oluşturuyoruz 
            adapter.fill(datatable) => datatable ile  bu sanal tabloyu gelen veriler ile doldurma işlemini yapıyoruz
            sonra onu datagridview datasourcena gönderip orada göstermesini sağlıyoruz verileri.

            */

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("insert into City (CityName, CityCountry) values (@p1,@p2)", connect);
            command.Parameters.AddWithValue("@p1", txtCityName.Text);
            command.Parameters.AddWithValue("@p2", txtCityCountry.Text);
            command.ExecuteNonQuery(); //ExecuteNonQuery bri nevi Savechanges anlamında sorguyu çalıştırve kaydet yapıyor db ye 
            connect.Close();

            MessageBox.Show("Transaction Successful");
            txtCityName.Text = "";
            txtCityCountry.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("delete from City where CityId = @p1", connect);
            command.Parameters.AddWithValue("@p1", txtCityId.Text);
            command.ExecuteNonQuery();
            connect.Close();

            MessageBox.Show("Transaction Successful");
            txtCityId.Text = "";

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }


}