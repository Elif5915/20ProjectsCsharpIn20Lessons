using Dapper;
using DapperNorthwind_5.DTO.CategoryDto;
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

namespace DapperNorthwind_5
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		//dapper de ado.netteki gibi queryler gönderiliyor.
		//ama entity frameworkde add,insert,tolist metodu gibi tek kelimelerden oluşan metodlar gönderiliyordu.

		SqlConnection connection = new SqlConnection("Server= NETCADYAZ; initial catalog = Northwind;integrated security = true"); // connection değişkeni tanımlıyoruz
		private async void btnCategoryList_Click(object sender, EventArgs e)
		{
			string query = "Select *from Categories"; //bu bizim dapperda sorgumuz
			var values =await connection.QueryAsync<ResultCategoryDto>(query);
			dataGridView1.DataSource= values;
		}

		private async void btnCategoryAdd_Click(object sender, EventArgs e)
		{
			string sql = "insert into Categories(CategoryName,Description) values (@p1,@p2)";
			var parameteres = new DynamicParameters();
			parameteres.Add("@p1",txtCategoryName.Text);
			parameteres.Add("@p2",txtCategoryDescription.Text);

			await connection.ExecuteAsync(sql, parameteres);

			MessageBox.Show("Category adding successful!");
			txtCategoryDescription.Text = "";
			txtCategoryName.Text = "";
		}

		private async void btnCategoryDelete_Click(object sender, EventArgs e)
		{
			string query = "Delete from Categories where CategoryID = @categoryId";
			var parameteres = new DynamicParameters();
			parameteres.Add("@categoryId", txtCategoryId.Text);
			await connection.ExecuteAsync(query, parameteres);


			MessageBox.Show("Category delete successful!");
			txtCategoryId.Text = "";
			

		}

		private async void btnCategoryUpdate_Click(object sender, EventArgs e)
		{
			string query = "update Categories set CategoryName= @name, Description = @desc where CategoryID = @categoryId";
			var parameteres = new DynamicParameters();
			parameteres.Add("@name", txtCategoryName.Text);
			parameteres.Add("@desc", txtCategoryDescription.Text);
			parameteres.Add("@categoryId", txtCategoryId.Text);

			await connection.ExecuteAsync(query, parameteres);

			MessageBox.Show("Category update successful!");
			txtCategoryId.Text = "";
			txtCategoryDescription.Text = "";
			txtCategoryName.Text = "";
		}

		private async void Form1_Load(object sender, EventArgs e)
		{
			//kategori sayısı
			string query = "Select Count(*) from Categories";
			var count = await connection.ExecuteScalarAsync<int>(query);
			lblCategoryCount.Text = "Total Number Of Categories:" + count;
			//ürün sayısı
			string sql = "Select Count(*) from Products";
			var productCount = await connection.ExecuteScalarAsync<int>(sql);
			lblProductCount.Text = "Total Number Of Products:" + count;

			//ortalama ürün stok sayısı
			string sqlStok = "Select Avg(UnitsInStock) from Products";
			var productStok = await connection.ExecuteScalarAsync<int>(sqlStok);
			lblProductStok.Text = "Total Number Of Products Stok:" + productStok;

			// deniz ürünleri toplam fiyatı
			string sqlSea = "Select Sum(UnitPrice) from Products Where CategoryID=(select CategoryID from Categories where CategoryName= 'Seafood')";
			var productSea = await connection.ExecuteScalarAsync<decimal>(sqlSea);
			lblPorductSeaTotal.Text = "Seafood Total Price:" + productSea;
		}
	}
}
