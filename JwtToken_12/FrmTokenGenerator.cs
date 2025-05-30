﻿using JwtToken_12.JWT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JwtToken_12
{
    public partial class FrmTokenGenerator : Form
    {
        public FrmTokenGenerator()
        {
            InitializeComponent();
        }

        void parametersClear()
        {
            txtUserName.Text = "";
            txtEmail.Text = "";
            txtName.Text = "";
            txtSurname.Text = "";
        }
        private void btnTokenCreate_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string email = txtEmail.Text;
            string name = txtName.Text;
            string surname = txtSurname.Text;
            TokenGenerator tokenGenerate = new TokenGenerator();
            string token = tokenGenerate.GenerateJwtToken(username,email,name,surname);
            richTextBox1.Text = token;
            parametersClear();
        }
    }
}
