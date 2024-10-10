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

            //Türkiyeden Yapılan Siparişler sqlquerysi ile getirme işlemi
           var sql = entities.Database.SqlQuery<int>("select count(*) from [Order] where CustomerId In (select CustomerId from Customer where Country = 'Türkiye')").FirstOrDefault();
            lblTurkiyeYapilanSiparis.Text = sql.ToString();
            
            //Türkiyeden Yapılan Siparişler Entity framework metodu ile getirme işlemi
            var turkishCustomerId = entities.Customer.Where(x => x.Country == "Türkiye")
                                           .Select(y => y.CustomerId)
                                           .ToList();
            var orderCountFromTurkishWithEf = entities.Order.Count(z => turkishCustomerId.Contains(z.CustomerId.Value));
            lblTurkiyeYapilanSiparisEF.Text = orderCountFromTurkishWithEf.ToString();

            //Meyve satış kazancı Sqlquery şeklinde yazılması
            var totalPriceMeyve = entities.Database.SqlQuery<decimal>("select Sum(o.TotalPrice) from[Order] o  join Product p on p.ProductId = o.ProductId join Category c on p.CategoryId = c.CategoryId where c.Name = 'Meyve'").FirstOrDefault();
            lblMeyveSatisKazanci.Text = totalPriceMeyve.ToString() + " ₺";

            //Meyve satış kazancı Entity frame.metodu ile yazılması
            var totalPriceMeyveEF = (from o in entities.Order
                                     join p in entities.Product on o.ProductId equals p.ProductId
                                     join c in entities.Category on p.CategoryId equals c.CategoryId
                                     where c.Name == "Meyve"
                                     select o.TotalPrice).Sum();
            lblMeyveSatisKazanciEF.Text = totalPriceMeyveEF.ToString() + " ₺";

            //En son eklenen ürün ismi
            var lastProductName = entities.Product.OrderByDescending(x => x.ProductId).Select(y => y.Name).FirstOrDefault();
            lblEnSonEklenenUrunAd.Text = lastProductName.ToString();

            //en son eklenen ürünün kategori ismi 
            var lastProductCategoryId = entities.Product.OrderByDescending(x => x.ProductId).Select(y => y.CategoryId).FirstOrDefault();
            var lastProductCategoryName = entities.Category.Where(x => x.CategoryId == lastProductCategoryId).Select(y => y.Name).FirstOrDefault();
            lblEnSonEklenenKategori.Text = lastProductCategoryName.ToString();

            //Aktif Ürün Sayısı 
            var activeProduct = entities.Product.Where(x => x.Status == true).Count();
            lblAktifUrunSayisi.Text = activeProduct.ToString();

            //toplam kola kazan tutarı 
            var colaStock = entities.Product.Where(x => x.Name == "Kola").Select(y => y.Stock).FirstOrDefault(); 
            var colaPrice = entities.Product.Where(y => y.Name == "Kola").Select(y => y.Price).FirstOrDefault();

            var totalKolaKazanc = colaStock * colaPrice;
            lblToplamKolaKazancTutari.Text = totalKolaKazanc.ToString() + " ₺";

            //Son Siparişi veren kişinin ad/soyad bilgisi
            var lastCustomerId = entities.Order.OrderByDescending(x => x.OrderId).Select(y => y.CustomerId).FirstOrDefault();
            var lastCustomerName = entities.Customer.Where(x => x.CustomerId == lastCustomerId).Select(y => y.Name).FirstOrDefault();
            lblSonSiparisiVerenKisi.Text = lastCustomerName.ToString();

            //Farklı Ülke Sayısı
            var countryCount = entities.Customer.Select(x => x.Country).Distinct().Count();
            lblFarkliUlkeSayisi.Text = countryCount.ToString();
        }
    }
}
