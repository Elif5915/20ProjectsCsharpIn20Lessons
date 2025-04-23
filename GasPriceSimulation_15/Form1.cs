using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GasPriceSimulation_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double dieselPrice = 42.25;
        double gasolinePrice = 43.22;
        double lpg = 23.73;
        double gasAmount = 0;
        double dieselAmount = 0;
        double lpgAmount = 0;
        double progressBarValue = 0;
        double totalPrice = 0;
        int count = 0;
        private void btnStart_Click(object sender, EventArgs e)
        {
            gasAmount = Convert.ToDouble(txtbxGasAmount.Text);
            dieselAmount = Convert.ToDouble(txtbxGasAmount.Text);
            lpgAmount = Convert.ToDouble(txtbxGasAmount.Text);
            timer1.Start();
            timer1.Interval = 100;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (rdbBenzin.Checked)
            {
                count++;
                if (count <= gasAmount)
                {
                    totalPrice += gasolinePrice;
                    txtbxTotalAmount.Text = totalPrice.ToString() + " ₺";
                }
                else
                {
                    txtbxTotalAmount.Text = totalPrice.ToString() + " ₺";
                }
                progressBar1.Value += 1;
                if (progressBar1.Value == 99)
                {
                    timer1.Stop();
                }

            }
            if (rdbMotorin.Checked)
            {
                count++;
                if (count <= dieselAmount)
                {
                    totalPrice += dieselPrice;
                    txtbxTotalAmount.Text = totalPrice.ToString() + " ₺";
                }
                else
                {
                    txtbxTotalAmount.Text = totalPrice.ToString() + " ₺";
                }
                progressBar1.Value += 1;
                if (progressBar1.Value == 99)
                {
                    timer1.Stop();
                }

            }
            if (rdbLpg.Checked)
            {
                count++;
                if (count <= lpgAmount)
                {
                    totalPrice += lpg;
                    txtbxTotalAmount.Text = totalPrice.ToString() + " ₺";
                }
                else
                {
                    txtbxTotalAmount.Text = totalPrice.ToString() + " ₺";
                }
                progressBar1.Value += 1;
                if (progressBar1.Value == 99)
                {
                    timer1.Stop();
                }

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtbxBenzin.Text = dieselPrice.ToString() + " ₺";
            txtbxMotorin.Text = gasolinePrice.ToString() + " ₺";
            txtbxLpg.Text = lpg.ToString() + " ₺";

        }
    }
}
