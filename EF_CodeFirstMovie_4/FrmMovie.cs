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
    public partial class FrmMovie : Form
    {
        public FrmMovie()
        {
            InitializeComponent();
        }

        MovieContext context = new MovieContext();
        private void btnList_Click(object sender, EventArgs e)
        {
            var values = context.Movies.ToList();
            dataGridView1.DataSource = values;

        }

        void CategoryList()
        {
            var values = context.Categories.ToList();
            cmbKategori.DisplayMember = "CategoryName";
            cmbKategori.ValueMember = "CategoryId";
            cmbKategori.DataSource = values;
        }

        private void FrmMovie_Load(object sender, EventArgs e)
        {
            CategoryList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie();
            movie.MovieTitle = txtboxName.Text;
            movie.Description = txtboxAciklama.Text;
            movie.CreatedDate = DateTime.Parse(txtboxIzlemeTarih.Text);
            movie.CategoryId = int.Parse(cmbKategori.SelectedValue.ToString());
            movie.Duration = int.Parse(txtboxSure.Text);
            context.Movies.Add(movie);
            context.SaveChanges();
            MessageBox.Show("İşlem Başarılı");

            txtboxName.Text = "";
            txtboxAciklama.Text = "";
            txtboxIzlemeTarih.Text = "";
            cmbKategori.SelectedValue = -1;
            txtboxSure.Text = "";

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtboxId.Text);
            var value = context.Movies.Find(id);
            context.Movies.Remove(value);
            context.SaveChanges();

            MessageBox.Show("İşlem Başarılı");
            txtboxId.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var values = context.Movies.Where(x => x.MovieTitle == txtboxName.Text).ToList();
            dataGridView1.DataSource = values;
            txtboxName.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtboxId.Text);
            var value = context.Movies.Find(id);
            value.Duration = int.Parse(txtboxSure.Text);
            value.MovieTitle = txtboxName.Text;
            value.Description = txtboxAciklama.Text;
            value.CreatedDate = DateTime.Parse(txtboxIzlemeTarih.Text);
            value.CategoryId = int.Parse(cmbKategori.SelectedValue.ToString());
            context.SaveChanges();
            MessageBox.Show("İşlem Başarılı");

            txtboxId.Text = "";
            txtboxName.Text = "";
            txtboxAciklama.Text = "";
            txtboxIzlemeTarih.Text = "";
            cmbKategori.SelectedValue = -1;
            txtboxSure.Text = "";

        }

        private void btnListMovieAndCategory_Click(object sender, EventArgs e)
        {
            var values = context.Movies
                         .Join(context.Categories,
                         movie => movie.CategoryId,
                         category => category.CategoryId,
                         (movie, category) => new
                         {
                             MovieId = movie.MovieId,
                             MovieTitle = movie.MovieTitle,
                             Description = movie.Description,
                             Duration = movie.Duration,
                             CategoryName = category.CategoryName

                         }).ToList();

            dataGridView1.DataSource = values;
        }
    }
}
