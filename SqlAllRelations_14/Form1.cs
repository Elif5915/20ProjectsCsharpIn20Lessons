using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlAllRelations_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db20Lesson20Project14DataSet.Teams' table. You can move, or remove it, as needed.
            this.teamsTableAdapter.Fill(this.db20Lesson20Project14DataSet.Teams);

        }
    }
}
