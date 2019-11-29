using Microsoft.Win32;
using RegistryLibrary;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Instruction
{
    public partial class Zastavka : Form
    {
        public Zastavka()
        {
            InitializeComponent();
        }
        public int load;
        public bool linsVersion;
        RegistryClass registry = new RegistryClass();
        RegistryKey currentUserKey = Registry.CurrentUser;

        string OSversion;
        private void Zastavka_Load(object sender, EventArgs e)
        {
            registry.FormConfigurationGet();
            Color color = Color.FromName(RegistryClass.ColorFonText);
            BackColor = color;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //прозрачность формы прибавляется
            if (Opacity != 1) Opacity += 0.01;
            else
            {
                timer1.Enabled = false;
                timer2.Enabled = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            load = pbLoad.Value;
            if (pbLoad.Value != pbLoad.Maximum)
            {

                pbLoad.PerformStep();
                switch (load)
                {
                    case (0):
                        //Проверка версии ОС
                        OSversion = Environment.OSVersion.ToString();
                        lbLoad.Text = "Проверка версия ОС: " + OSversion;
                        if (Environment.OSVersion.ToString() == "Microsoft Windows NT 6.1.7602 Service Pack 1")
                        {
                            timer2.Stop();
                            MessageBox.Show("Программа не подходит к версии ОС, могут присудствовать критические ошибки");
                            timer2.Start();
                        }
                        break;
                    case (20):
                        //проверка подключения библиотеки
                        lbLoad.Text = "Проверка подключенных библиотек: RegistryLibrary.dll";
                        //проверка на присудствие библиотеки
                        if (!(File.Exists("RegistryLibrary.dll")))
                        {
                            timer2.Stop();
                            MessageBox.Show("Критическая ошибка!!!переустановите программный продукт");
                            this.Close();
                        }

                        break;
                    case (40):
                        //проверка подключения библиотеки
                        lbLoad.Text = "Проверка библиотек: Microsoft.Office.Interop.Excel.dll";
                        if (!(File.Exists("Microsoft.Office.Interop.Excel.dll")))
                        {
                            timer2.Stop();
                            MessageBox.Show("Программный продукт установлен не коректно, установите его заново!");
                            this.Close();
                        }
                        break;
                    case (60):
                        //проверка подключения к бд
                        lbLoad.Text = "Проверка подключение к БД:";
                        RegistryKey redInstr = currentUserKey.OpenSubKey("Instruction");
                        string bdinstr = redInstr.GetValue("IC").ToString();
                        if (bdinstr != "Instructions")
                        {
                            timer2.Enabled = false;
                            MessageBox.Show("Подключение отсутствует, обрадитесь администратору для подключения");
                            timer2.Enabled = true;
                        }
                        else
                            timer2.Enabled = true;
                        break;

                    case (80):
                        //проверка лицензии
                        lbLoad.Text = "Проверка Лицензии: ";
                        try
                        {
                            RegistryKey versLins = currentUserKey.OpenSubKey("Instruction\\KeyLins");
                            string lins = versLins.GetValue("Key").ToString();
                            if (lins == "")
                            {
                                linsVersion = false;
                            }
                            else
                                if (lins == "LTMXB-OYTEQ-MYNTP-QWMOA")
                                linsVersion = true;
                        }
                        catch
                        {
                            timer2.Stop();
                            MessageBox.Show("Программа не активирована, дема версия работает в течении 10 минут");
                            timer2.Start();
                        }
                        break;

                    case (90):
                        timer2.Interval = 10;
                        break;
                }
            }
            
            if (Opacity != 0) Opacity -= 0.01;
            else
            {

                //Переменой присваивается форма
                MainForm main = new MainForm();
                //показывает форму
                main.Show();
                //прячет форму 
                Hide();
                timer2.Enabled = false;
            }

        }

        }
}
    

