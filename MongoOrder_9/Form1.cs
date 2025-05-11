using MongoOrder_9.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MongoOrder_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OrderOperation orderOperation = new OrderOperation();
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //mongo db de tablolar birer collection(koleksiyon) şeklinde adlandırılır.
        //kayıtlar yani satırlar birer doküman(document)
        //sütunlar ise birer field olarak adlandırılır.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var order = new Order
            {
                //OrderId = txtOrderId.Text, otomatik gelecek bu 
                CustomerName = txtCustomer.Text,
                District = txtDistrict.Text,
                City = txtCity.Text,
                TotalPrice = decimal.Parse(txtTotalPrice.Text)
            };
            orderOperation.AddOrder(order);
            MessageBox.Show("Ekleme işlemi yapıldı.");
            boxClear();
        }

        void boxClear()
        {
            txtCustomer.Text = "";
            txtDistrict.Text = "";
            txtCity.Text = "";
            txtTotalPrice.Text = "";
            txtOrderId.Text = "";
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List<Order> orders = orderOperation.GetAllOrder();
            dataGridView1.DataSource = orders;
             
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string orderId = txtOrderId.Text;
            orderOperation.DeleteOrder(orderId);
            MessageBox.Show("Silme işlemi başarılı şekilde yapıldı.");
            txtOrderId.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = txtOrderId.Text;
            var updateOrder = new Order
            {
                OrderId = id,
                City = txtCity.Text,
                District = txtDistrict.Text,
                CustomerName = txtCustomer.Text,
                TotalPrice = decimal.Parse(txtTotalPrice.Text)
            };
            orderOperation.UpdateOrder(updateOrder);
            boxClear();
        }

        private void btnBring_Click(object sender, EventArgs e)
        {
            string id = txtOrderId.Text;
            Order orders = orderOperation.GetOrderById(id);
            dataGridView1.DataSource = new List<Order> { orders };
            txtOrderId.Text = "";
        }
    }
}
