using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableStatusMomentary_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TestEntities context = new TestEntities();
            var buttons = this.Controls.OfType<Button>().ToList();
            foreach(var btn in buttons)
            {
                this.Controls.Remove(btn);
            }

            var values = context.TablesStatus.ToList();

            int buttonWidth = 100;
            int buttonHeight = 100;
            int padding = 10;
            int xOffset = 10;
            int yOffset = 10;

            for (int i = 0; i < values.Count; i++)
            {
                var item = values[i];
                Button button = new Button();
                //button.Text = $"Masa{i+1}";
                button.Text = item.TableNumber?.ToString() ?? "---";
                button.Size = new Size(buttonWidth, buttonHeight);
                button.Location = new Point(xOffset + (i % 4) * (buttonWidth + padding),
                    yOffset + (i / 4) * (buttonHeight + padding));

                button.BackColor = item.Status.Value ? System.Drawing.Color.Green : System.Drawing.Color.Red; //eğer masa boşsa true ise yeşil, dolu false ise kırmızı olsun.

                this.Controls.Add(button);
            }
        }
    }
}
