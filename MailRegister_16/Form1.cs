using MimeKit;
using System;
using System.Windows.Forms;

namespace MailRegister_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TestEntities context = new TestEntities();
        private void btnRegister_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int confirmCode = random.Next(100000, 1000000);

            MailUser user = new MailUser();
            user.Email = txtMail.Text;
            user.Name = txtName.Text;
            user.Surname = txtSurname.Text;
            user.Password = txtPassword.Text;
            user.IsConfirm = false; //baslangıcta kullancı IsConfirm olmayacak yani onaylı olmayacak
            user.ConfirmCode = confirmCode.ToString();

            context.MailUser.Add(user);
            context.SaveChanges();
            MessageBox.Show("Kayıt İşlemi Başarıyla Tamamlandı..");
            txtMail.Text = "";
            txtName.Text = "";
            txtSurname.Text = "";
            txtPassword.Text = "";
            txtRepeatPassword.Text = "";

            #region Mail Gönderme

            MimeMessage mimeMesagge = new MimeMessage();

            MailboxAddress mailboxAddressFrom = new MailboxAddress("AdminRegister", "projekursdeneme@gmail.com");
            mimeMesagge.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAddressTo = new MailboxAddress("User", txtMail.Text);
            mimeMesagge.To.Add(mailboxAddressTo);

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = "Enail Adresinizin Konfirmasyon Kodu: " + confirmCode;
            mimeMesagge.Body = bodyBuilder.ToMessageBody();

            mimeMesagge.Subject = "Email Konfirmasyon Kodu";

            //Smtp Client: Smtp mail trasnfer protokolüdür.
            //SMTP, Basit Posta Aktarım Protokolü anlamına gelir.
            //İnternet üzerinden e-posta mesajları göndermek ve almak için kullanılan
            //bir iletişim protokolüdür. 

            MailKit.Net.Smtp.SmtpClient smtpClient = new MailKit.Net.Smtp.SmtpClient();
            smtpClient.Connect("smtp.gmail.com", 587,false); //türkiyenin port numarası 587 dir. use ssl kullanılmasın ondan false dedik.
            smtpClient.Authenticate("projekursdeneme@gmail.com", "vfkj grgy twya rhgm"); //buradaki key ise şu google hesabınızın 2fa doğrulamayı açıp daha sonra google hesaplarındaki arama alanına "uygulama şifreleri" yazıp oraya şifreni yazıp giriş yapıyorsun sonra ise uyg şifreleri sf giriş sonrası yeni uygulama şifresi alıyorsun oluştur butonu ok ile.. 16 karakterlik bir key veriyor sana  
            smtpClient.Send(mimeMesagge);
            smtpClient.Disconnect(true);

            MessageBox.Show("Mail adresinize doğrulama kodu gönderilmiştir.");

            FrmMailConfirm frmMailConfirm = new FrmMailConfirm();
            frmMailConfirm.email = txtMail.Text;
            frmMailConfirm.Show();

            #endregion
        }
    }
}
