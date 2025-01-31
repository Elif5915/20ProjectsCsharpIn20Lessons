using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Windows.Forms;

namespace RapidApiCurrency_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        decimal dollar = 0;
        decimal euro = 0;
        decimal pound = 0;

        private async void Form1_Load(object sender, EventArgs e)
        {
            #region dolar
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=USD&to=TRY&amount=1"),
                Headers =
                {
                    { "x-rapidapi-key", "8be6f92745mshaf73e9b2522c8f1p11a194jsn36e6ac18ef3b" },
                    { "x-rapidapi-host", "currency-conversion-and-exchange-rates.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var json = JObject.Parse(body);
                var value = json["result"].ToString();
                lblDolar.Text = "Dolar:" + value;
                dollar = Convert.ToDecimal(value);
                // Console.WriteLine(body);
            }
            #endregion

            #region euro
            var client2 = new HttpClient();
            var request2 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=EUR&to=TRY&amount=1"),
                Headers =
                {
                    { "x-rapidapi-key", "8be6f92745mshaf73e9b2522c8f1p11a194jsn36e6ac18ef3b" },
                    { "x-rapidapi-host", "currency-conversion-and-exchange-rates.p.rapidapi.com" },
                },
            };
            using (var response2 = await client2.SendAsync(request2))
            {
                response2.EnsureSuccessStatusCode();
                var body2 = await response2.Content.ReadAsStringAsync();
                var json2 = JObject.Parse(body2);
                var value2 = json2["result"].ToString();
                lblEuro.Text = "Euro:" + value2;
                euro = Convert.ToDecimal(value2);
            }
            #endregion  

            #region sterlin
            var client3 = new HttpClient();
            var request3 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=GBP&to=TRY&amount=1"),
                Headers =
                {
                    { "x-rapidapi-key", "8be6f92745mshaf73e9b2522c8f1p11a194jsn36e6ac18ef3b" },
                    { "x-rapidapi-host", "currency-conversion-and-exchange-rates.p.rapidapi.com" },
                },
            };
            using (var response3 = await client3.SendAsync(request3))
            {
                response3.EnsureSuccessStatusCode();
                var body3 = await response3.Content.ReadAsStringAsync();
                var json3 = JObject.Parse(body3);
                var value3 = json3["result"].ToString();
                lblSterlin.Text = "Sterlin" + value3;
                pound = Convert.ToDecimal(value3);

            }

            #endregion

            txtOdenecekTutar.Enabled = false;
        }

        private void btnİslemYap_Click(object sender, EventArgs e)
        {
            decimal unitprice = decimal.Parse(txtBirimTutar.Text);


            decimal totalPrice = 0;

            if (rdbDolar.Checked)
            {
                totalPrice = unitprice * dollar;
            }
            if (rdbEuro.Checked)
            {
                totalPrice = unitprice * euro;
            }
            if (rdbSterlin.Checked)
            {
                totalPrice = unitprice * pound;
            }
            txtOdenecekTutar.Text = totalPrice.ToString();
        }
    }
}

