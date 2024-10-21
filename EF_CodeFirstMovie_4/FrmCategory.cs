using EF_CodeFirstMovie_4.DAL.Context;
using EF_CodeFirstMovie_4.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_CodeFirstMovie_4
{
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }

        MovieContext context = new MovieContext();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = context.Categories.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = txtboxName.Text;
            context.Categories.Add(category);
            context.SaveChanges();
            MessageBox.Show("İşlem Başarılı");
            txtboxName.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           // Category category = new Category();
            int id = int.Parse(txtboxId.Text);
            var value = context.Categories.Find(id);
            value.CategoryName = txtboxName.Text;
            context.SaveChanges();
            MessageBox.Show("İşlem Başarılı");

            txtboxId.Text = "";
            txtboxName.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtboxId.Text);
            var values = context.Categories.Find(id);
            context.Categories.Remove(values);
            context.SaveChanges();
            MessageBox.Show("İşlem Başarılı");

            txtboxId.Text = "";

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var values = context.Categories.Where(x => x.CategoryName == txtboxName.Text).ToList();
            dataGridView1.DataSource = values;

            txtboxName.Text = "";
        }
    }
}
