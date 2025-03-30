using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriggerOrderStock_11.Data;

namespace TriggerOrderStock_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestEntities context = new TestEntities();

            string number;
            Console.WriteLine("### Sipariş Stok Sistemi ###");
            Console.WriteLine();
            Console.WriteLine("1-Ürün Listesi");
            Console.WriteLine("2-Sipariş Listesi");
            Console.WriteLine("3-Kasa Durumu");
            Console.WriteLine("4-Yeni Ürün Sipariş Girişi");
            Console.WriteLine("5-İşlem Sayacı");
            //Console.WriteLine("6-Ürün Stok Güncelleme");
            Console.WriteLine();
            Console.WriteLine("-------------------------------");
            Console.WriteLine();

            Console.Write("Lütfen yapmak istediğiniz işlemi seçin: ");
            number = Console.ReadLine();
            Console.WriteLine();

            if(number == "1")
            {
                Console.WriteLine("---- Ürün Listesi ----");
                var values = context.Products.ToList();
                foreach(var item in values)
                {
                    Console.WriteLine(item.ProductId + "-" + item.ProductName + "Stok Sayısı:" + item.ProductStock + "Fiyatı:" + item.ProductPrice + "TL");
                }
            }
            if(number == "2")
            {
                Console.WriteLine("---- Sipariş Listesi ----");
                var values = context.Orders.ToList();
                foreach (var item in values)
                {
                    Console.WriteLine(item.OrderId + " " + item.Products.ProductName + "Birim Fiyat :" + item.UnitPrice + "Adet :" + item.Quantity + "Toplam Fiyat : " + item.TotalPrice);
                }
            }
            if(number == "3")
            {
                Console.WriteLine("---- Kasa Durumu ----");
                var values = context.CashRegister.Select(x => x.Balance).FirstOrDefault();
                Console.Write("Kasadaki Toplam Tutar : " + values + "TL");
            }
            if(number == "4")
            {
                Console.WriteLine("---- Yeni Ürün Sipariş Girişi ----");

                Console.Write("Müşteri Adı/Soyadı: ");
                string customer = Console.ReadLine();
                Console.Write("Ürün Id: ");
                int productId = int.Parse(Console.ReadLine());
                Console.Write("Ürün Adedi: ");
                int quantity = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("--- Ürün Bilgileri ---");

                var productName = context.Products.Where(x => x.ProductId == productId).Select(y => y.ProductName).FirstOrDefault();
                Console.WriteLine("Ürün Adı: " + productName);

                var productUnitPrice = context.Products.Where(x => x.ProductId == productId).Select(y => y.ProductPrice).FirstOrDefault();
                Console.WriteLine("Birim Fiyat: " + productUnitPrice);

               //decimal totalPrice = decimal.Parse((quantity * productUnitPrice).ToString());
                decimal totalPrice = quantity * decimal.Parse(productUnitPrice.ToString());
                Console.WriteLine("Toplam Fiyat: " + totalPrice);

                Console.WriteLine();
                Orders order = new Orders();
                order.UnitPrice = productUnitPrice;
                order.ProductId = productId;
                order.Quantity = quantity;
                order.TotalPrice = totalPrice;
                order.Customer = customer;

                context.Orders.Add(order); //database tabloya ekle
                context.SaveChanges();    //değişiklikleri db kayıt et
               
            }
            if(number == "5")
            {
                var value = context.Processes.Select(x => x.Process).FirstOrDefault();
                Console.WriteLine("Toplam İşlem Sayısı: " + value);
            }
            Console.Read();
        }
    }
}
