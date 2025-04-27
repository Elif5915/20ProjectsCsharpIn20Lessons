using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailRegister_16
{
    public partial class FrmMailConfirm : Form
    {
        public FrmMailConfirm()
        {
            InitializeComponent();
        }

        TestEntities context = new TestEntities();
        public string email;
        private void btnCompleteActivation_Click(object sender, EventArgs e)
        {
            var value = context.MailUser.Where(x => x.Email == txtEmailActivation.Text).Select(y => y.ConfirmCode).FirstOrDefault();

            if(txtVerificationCode.Text == value.ToString())
            {
                MessageBox.Show("Hesabınız aktif edildi..");
                var value2 = context.MailUser.Where(x => x.Email == txtEmailActivation.Text).FirstOrDefault();
                value2.IsConfirm = true;
                context.SaveChanges();
            }
            else
            {
                MessageBox.Show("Hatalı doğrulama kodu girilmiştir.Hesap aktif edilemedi!");
            }
        }

        private void FrmMailConfirm_Load(object sender, EventArgs e)
        {
            txtEmailActivation.Text = email;
        }
    }
}
