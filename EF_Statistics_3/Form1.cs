using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_Statistics_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Db20Lesson20Project3Entities
        Db20Lesson20Project3Entities entities = new Db20Lesson20Project3Entities();

        private void Form1_Load(object sender, EventArgs e)
        {
            // Toplam kategori sayısı
            int categoryCount = entities.Category.Count();
            lblCategoryCount.Text = categoryCount.ToString();
            //Toplam ürün sayısı
            int productCount = entities.Product.Count();
            lblProductCount.Text = productCount.ToString();
            //toplam Müşteri sayısı
            int customerCount = entities.Customer.Count();
            lblCustomerCount.Text = customerCount.ToString();
            //toplam sipariş sayısı
            int orderCount = entities.Order.Count();
            lblOrderCount.Text = orderCount.ToString();

            //toplam stok sayısı
            var totalStok = entities.Product.Sum(x => x.Stock);
            lblToplamStokSayısı.Text = totalStok.ToString();
            //Ortalama ürün Fiyatı 
            var averageProduct = entities.Product.Average(x => x.Price);
            lblOrtalamaUrunFiyatı.Text = averageProduct.ToString() + " ₺";
            //toplam meyve stok
            var totalFruit = entities.Product.Where(x => x.CategoryId == 1).Sum(y => y.Stock);
            lblToplamMeyveStok.Text = totalFruit.ToString();
            // Gazoz toplam işlem hacmi
            var totalGetStokGazoz = entities.Product.Where(x => x.Name == "Gazoz").Select(y=> y.Stock).FirstOrDefault();
            var totalGetPriceGazoz = entities.Product.Where(x => x.Name == "Gazoz").Select(y => y.Price).FirstOrDefault();
            var totalIslemHacim = totalGetStokGazoz * totalGetPriceGazoz;
            lblGazozİşlemHacmi.Text = totalIslemHacim.ToString() + " ₺";
            //stok sayısı 100 den az olan ürünler
            var stok100AzUrunler = entities.Product.Where(x => x.Stock < 100).Count();
            lblStok100AzUrunler.Text = stok100AzUrunler.ToString();
            //Aktif Sebze Stok toplamı

            //var aktifSebzeStok = entities.Product.Where(x => x.CategoryId == 2 && x.Status == true).Sum(y => y.Stock);
            // int id = entities.Category.Where(x => x.Name == "Sebze").Select(y => y.CategoryId).FirstOrDefault();
            var aktifSebzeStok = entities.Product.Where(x => x.CategoryId == (entities.Category.Where(z => z.Name == "Sebze").Select(y => y.CategoryId).FirstOrDefault()) && x.Status == true).Sum(y => y.Stock);
            lblAktifSebzeStok.Text = aktifSebzeStok.ToString();

            //Türkiyeden Yapılan Siparişler
            var customerId = entities.Customer.Where(x => x.Country == "Türkiye").Select(y => y.CustomerId).ToList();
            lblTurkiyeYapilanSiparis.Text = customerId.ToString();
        }
    }
}
