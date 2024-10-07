using System;
using System.Linq;
using System.Windows.Forms;

namespace EF_DBFirstProduct_2
{
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }

        Db20Lesson20Project2Entities entities = new Db20Lesson20Project2Entities();

        void ProductList()
        {
            dataGridView1.DataSource = entities.Product.ToList();
        }
        private void FrmProduct_Load(object sender, EventArgs e)
        {
            var values = entities.Category.ToList();
            cmbProductCategory.DisplayMember = "CategoryName";// kullanıcıya görünecek kısım
            cmbProductCategory.ValueMember = "CategoryId"; //arka tarafya işlemlerde kullanılacak kısımlar.
            cmbProductCategory.DataSource = values;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            ProductList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ProductPrice = decimal.Parse(txtProductPrice.Text);
            product.ProductStock = int.Parse(txtProductStock.Text);
            product.ProductName = txtProductName.Text;
            product.CategoryId = int.Parse(cmbProductCategory.SelectedValue.ToString());
            entities.Product.Add(product);
            entities.SaveChanges();
            ProductList();

            txtProductName.Text = "";
            txtProductPrice.Text = "";
            txtProductStock.Text = "";
            cmbProductCategory.SelectedIndex = -1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var value = entities.Product.Find(int.Parse(txtProductId.Text));
            entities.Product.Remove(value);
            entities.SaveChanges();
            ProductList();

            txtProductId.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var value = entities.Product.Find(int.Parse(txtProductId.Text));

            value.ProductPrice = decimal.Parse(txtProductPrice.Text);
            value.ProductStock = int.Parse(txtProductStock.Text);
            value.ProductName = txtProductName.Text;
            value.CategoryId = int.Parse(cmbProductCategory.SelectedValue.ToString());
            entities.SaveChanges();
            ProductList();

            txtProductId.Text = "";
            txtProductName.Text = "";
            txtProductPrice.Text = "";
            txtProductStock.Text = "";
            cmbProductCategory.SelectedIndex = -1;
        }

        private void btnProductListWithCategory_Click(object sender, EventArgs e)
        {
            var values = entities.Product.Join(entities.Category,
                                               x => x.CategoryId,
                                               y => y.CategoryId,
                                               (x, y) => new
                                               {
                                                   ProductId = x.ProductId,
                                                   ProductName = x.ProductName,
                                                   ProductPrice = x.ProductPrice,
                                                   ProductStock = x.ProductStock,
                                                   CategoryId = y.CategoryId,
                                                   CategoryName = y.CategoryName,
                                               }).ToList();
            dataGridView1.DataSource = values;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var values = entities.Product.Where(x => x.ProductName == txtProductName.Text).ToList();
            dataGridView1.DataSource = values;
        }
    }
}
