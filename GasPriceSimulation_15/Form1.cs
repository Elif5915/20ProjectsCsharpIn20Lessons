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
        double gasAmount;
        double progressBarValue;
        double totalPrice;
        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 500;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gasAmount = Convert.ToDouble(txtbxGasAmount.Text);
            progressBar1.Value += 5;
            if (rdbBenzin.Checked)
            { 
                progressBar1.Value += 3;
                if(progressBar1.Value == 99)
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
