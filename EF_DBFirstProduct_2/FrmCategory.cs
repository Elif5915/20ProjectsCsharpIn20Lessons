using System;
using System.Linq;
using System.Windows.Forms;


namespace EF_DBFirstProduct_2
{
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }

        Db20Lesson20Project2Entities entities = new Db20Lesson20Project2Entities();

        void categoryList()
        {
            //var category = entities.Category.ToList();
            //  dataGridView1.DataSource = category;
            dataGridView1.DataSource = entities.Category.ToList();
        }
        private void btnList_Click(object sender, System.EventArgs e)
        {
            categoryList();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            Category db = new Category();
            db.CategoryName = txtCategoryName.Text;
            entities.Category.Add(db);
            entities.SaveChanges();
            categoryList();
            txtCategoryName.Text = "";
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            int id = Convert.ToInt32(txtCategoryId.Text);
            var value = entities.Category.Find(id);
            entities.Category.Remove(value);
            entities.SaveChanges();
            categoryList();
            txtCategoryId.Text = "";

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtCategoryId.Text);
            var value = entities.Category.Find(id);
            value.CategoryName = txtCategoryName.Text;
            entities.SaveChanges();
            categoryList();
            txtCategoryId.Text = "";
            txtCategoryName.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var values = entities.Category.Where(x => x.CategoryName == txtCategoryName.Text).ToList();
            dataGridView1.DataSource = values;
        }
    }
}
