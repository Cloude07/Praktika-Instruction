using RegistryLibrary;
using System;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Instruction
{
    public partial class Otzev : Form
    {
        public Otzev()
        {
            InitializeComponent();
        }

        private void Otzev_Load(object sender, EventArgs e)
        {
            RegistryClass a = new RegistryClass();
            a.FormConfigurationGet();
            Color color = Color.FromName(RegistryClass.ColorFonText);
            BackColor = color;
        }

        public void MySendMail(string bodyMail, string nameAuthor, string subject)
        {
                try
                {
                    var form = new MailAddress("cloude070797@yandex.ru", nameAuthor);
                    var to = new MailAddress("i_s.s.popov@mpt.ru");
                    //указание портокола яндекс
                    SmtpClient smtp = new SmtpClient("smtp.yandex.ru", 587);
                    //авторизация в почту
                    smtp.Credentials = new NetworkCredential("cloude070797", "ser2012");
                    //указание протокола
                    smtp.EnableSsl = true;
                    //отправление от кого кому сообщение
                    MailMessage mail = new MailMessage(form, to);
                    mail.Subject = subject;
                    mail.Body = bodyMail;

                    //отправление
                    smtp.Send(mail);
                    MessageBox.Show("Сообщение отправлено", "Информационное письмо", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Ошибка отправлена", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        

        private void button1_Click(object sender, EventArgs e)
        {

        MySendMail(tbText.Text,tbOtKovo.Text, tbTema.Text);
        }


    }
}
