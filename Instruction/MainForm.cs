using System;
using System.Windows.Forms;
using RegistryLibrary;
using System.Drawing;
using System.Threading;
using System.IO;
using Microsoft.Win32;

namespace Instruction
{
    public partial class MainForm : Form
    {
        RegistryClass registry = new RegistryClass();
        DataBase_Configuration data = new DataBase_Configuration();
        ConectionForm conection = new ConectionForm();
        DataBase_Procedure procedure = new DataBase_Procedure();
        TableLoad tableLoad = new TableLoad();
        VisibleObjct visiblObjct = new VisibleObjct();
        RegistryClass RegClassGet = new RegistryClass();
        RegistryKey currentUserKey = Registry.CurrentUser;
        GetDateTable getDateTable = new GetDateTable();
        Avtoriz avtoriz = new Avtoriz();


        string SFF;
        string nameTable;
        string colorFonTextSet, sizeForm, burderStyle;
        string openTable = "";
        public static Int32 id_status_sotr, id_doljnosty, id_status_instruction, id_instruction, id_sotr,
            id_conduction_the_instruction, id_role, id_Electronic_Jornal, ID_Avtoriz;
        int timeDemo = 600;
        public MainForm()
        {
            InitializeComponent();

        }
        public static System.Drawing.Text.InstalledFontCollection fonts = new System.Drawing.Text.InstalledFontCollection();
        public void MainForm_Load(object sender, EventArgs e)
        {
            Program.Avtoriz_user = false;
            Visible_menu();
            StatusMod();
            registry.Registry_Get();
            mstbLins.Text = RegistryClass.KeyProd;
            RegClassGet.FormConfigurationGet();
            //переменная для цвета
            Color color = Color.FromName(RegistryClass.ColorFonText);
            //Задний цвет равен переменной цвета
            this.BackColor = color;
            registry.FormConfigurationGet();
            //загрузка с реестра настройки
            sizeForm = RegistryClass.SizeForm;
            burderStyle = RegistryClass.BurderStatus;
            cbColor.SelectedItem = RegistryClass.ColorFonText;
            //Загрузка процедур
            BorderSwitch();
            SizeForm();
            //перемменая равна выбранному цвету из ComboBox
            colorFonTextSet = cbColor.SelectedItem.ToString();
            ColorFon();
            ////Проверка подключения к серверу
            tsslCon.Visible = true;
            tsslCon.Text = "...Определение серверера";
            data.conState += constate;
            Thread thread = new Thread(data.Connection_check);
            thread.Start();


        }
        public void timer1_Tick(object sender, EventArgs e)
        {
            //Вывод даты и время
            tssldateTime.Text = DateTime.Now.ToLongTimeString() + "/" + DateTime.Now.ToShortDateString();
           

        }

        //Процедура для проверки подключения
        private void constate(bool value)
        {
            Action action = () =>
            {
                switch (value)
                {
                    case (true):
                        tsslCon.Text = RegistryClass.DSIP + "\\" + RegistryClass.DSSN + " - " + RegistryClass.IC;
                        break;
                    case (false):

                        tsslCon.Text = "!Подключение отсутвует";
                        break;
                }
            };
            Invoke(action);
        }

        private void отключитсяОтСервераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //отелючение от сервера
            tsslCon.Text = "...Определение серверера";
            DataBase_Configuration.logCon = false;

        }

        private void подключитсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Открытия формы для подключения
            conection.Show(this);
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            //Выполнение процедуров и скрытие панели с настройками
            btApplye_Click(sender, e);
            pFormConfig.Visible = false;
        }

        public void btApplye_Click(object sender, EventArgs e)
        {
            //Выполнение процедуров
            SizeForm();
            BorderSwitch();
            registry.FormConfigurationSet(colorFonTextSet, sizeForm, burderStyle);
            ColorFon();
        }

        private void cbColor_SelectedValueChanged(object sender, EventArgs e)
        {
            colorFonTextSet = cbColor.SelectedItem.ToString();
        }

        private void btCloseConf1_Click(object sender, EventArgs e)
        {
            pFormConfig.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            plTable.Visible = false;
            visiblObjct.VisiblTabClick(btInsert, btUpdate, btDelete, btClear, lb1, lb2, lb3, lb4, mtbdata, lb5, lb6, lb9, lb8, lb7, lbPoisk, tbPoisk, tb1, tb2,
 tb3, cb1, cb2, cb3, cb4, mtbBirthday, gbData);
        }


        public void ColorFon()
        {

            Color color = Color.FromName(colorFonTextSet);
            if (color.IsNamedColor)
                BackColor = color;
            colorFonTextSet = cbColor.SelectedItem.ToString();
        }

        private void rB1_CheckedChanged(object sender, EventArgs e)
        {
            sizeForm = "Maximized";
        }

        private void rB2_CheckedChanged(object sender, EventArgs e)
        {
            sizeForm = "Normal";
        }


        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TSMIhistory_Click(object sender, EventArgs e)
        {
            //выгрузка данных
            visiblObjct.VisiblTabClick(btInsert, btUpdate, btDelete, btClear, lb1, lb2, lb3, lb4, mtbdata, lb5, lb6, lb9, lb8, lb7, lbPoisk, tbPoisk, tb1, tb2,
tb3, cb1, cb2, cb3, cb4, mtbBirthday, gbData);
            dgvTable.DataSource = null;
            plTable.Show();

            nameTable = "История_изменений";
            gbData.Visible = false;
            try
            {
                visiblObjct.Visible_HistoryClick(btInsert, btUpdate, btDelete, btClear, lb1, lb2, lb3, lb4, mtbdata, lb5, lb6, lb9, lb8,lb7, lbPoisk, tbPoisk, tb1, tb2,
 tb3, cb1, cb2, cb3,cb4, mtbBirthday, gbData);
                tableLoad.dgvHistoryFill(dgvTable);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            lbTableName.Text = "Таблица: История изменений";

        }

        private void btClear_Click(object sender, EventArgs e)
        {
            try
            {
                procedure.spHistory_clear();
                tableLoad.dgvHistoryFill(dgvTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            {
                dgvTable.Refresh();
            }
        }
        private void TSMIinstruction_Click(object sender, EventArgs e)
        {
            //выгрузка данных
            visiblObjct.VisiblTabClick(btInsert, btUpdate, btDelete, btClear, lb1, lb2, lb3, lb4, mtbdata, lb5, lb6, lb9, lb8, lb7,
                lbPoisk, tbPoisk, tb1, tb2,tb3, cb1, cb2, cb3, cb4, mtbBirthday, gbData);
            dgvTable.DataSource = null;
            plTable.Show();
            nameTable = "Инструктаж";

            try
            {
                tableLoad.dgvInstructionFill(dgvTable);
                visiblObjct.InstructionClick(btInsert,btUpdate,btDelete,btClear,lb1,lb2,lb3,lb4,lb5,lb6,lb9,lb8,lb7,lbPoisk,tbPoisk,
                    tb1,tb2,tb3,cb1,cb2,cb3,cb4,mtbBirthday,mtbdata,gbData);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            lbTableName.Text = "Таблица: Инструктаж";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            plConfigDoc.Visible = false;
        }

        private void TSMIavtoriz_Click(object sender, EventArgs e)
        {
            plTable.Show();
            nameTable = "Авторизация";
            try
            {
                visiblObjct.VisiblTabClick(btInsert, btUpdate, btDelete, btClear, lb1, lb2, lb3, lb4, mtbdata, lb5, lb6, lb9, lb8, lb7, lbPoisk, tbPoisk, tb1, tb2,
tb3, cb1, cb2, cb3, cb4, mtbBirthday, gbData);
                dgvTable.DataSource = null;
                visiblObjct.VisibleAvtroziClick(btInsert, btUpdate, btDelete, btClear, lb1, lb2, lb3, lb4, mtbdata, lb5, lb6, lb9, lb8, lb7, lbPoisk, tbPoisk, tb1, tb2,
tb3, cb1, cb2, cb3, cb4, mtbBirthday, gbData);
                tableLoad.dgvAvtoriz(dgvTable);
                getDateTable.cbSotrFill(cb1);
                getDateTable.cbRoleFill(cb2);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            lbTableName.Text = "Таблица: Авторизация";
        }

        private void TSMISotr_Click(object sender, EventArgs e)
        {
            plTable.Show();
            nameTable = "Сотрудники";
            try
            {
                dgvTable.DataSource = null;
                //выгрузка данных
                visiblObjct.VisiblTabClick(btInsert, btUpdate, btDelete, btClear, lb1, lb2, lb3, lb4, mtbdata, lb5, lb6, lb9, lb8, lb7, lbPoisk, tbPoisk, tb1, tb2,
    tb3, cb1, cb2, cb3, cb4, mtbBirthday, gbData);
                tableLoad.dgvSotr(dgvTable);
                visiblObjct.Visible_SotrClick(btInsert, btUpdate, btDelete, btClear,
                    lb1, lb2, lb3, lb4, mtbdata, lb5, lb6, lb9, lb8, lb7, lbPoisk, tbPoisk, tb1, tb2, tb3, cb1, cb2, cb3, cb4, mtbBirthday, gbData);
                getDateTable.cbStatusSotrFill(cb1);
                getDateTable.cbDoljnostyFill(cb2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            lbTableName.Text = "Таблица: Сотрудники";
        }

        private void STMIstatus_Sotr_Click(object sender, EventArgs e)
        {

            plTable.Show();
            nameTable = "Статус_сотрудника";
            try
            {
                //выгрузка данных
                visiblObjct.VisiblTabClick(btInsert, btUpdate, btDelete, btClear, lb1, lb2, lb3, lb4, mtbdata, lb5, lb6, lb9, lb8, lb7, lbPoisk, tbPoisk, tb1, tb2,
    tb3, cb1, cb2, cb3, cb4, mtbBirthday, gbData);
                dgvTable.DataSource = null;

                tableLoad.dgvStatus_sotr(dgvTable);
                visiblObjct.Visible_Status_sotr(btInsert, btUpdate, btDelete, btClear,
                    lb1, lb2, lb3, lb4, mtbdata, lb5, lb6, lb9, lb8, lb7, lbPoisk, tbPoisk, tb1, tb2, tb3, cb1, cb2, cb3, cb4, mtbBirthday, gbData);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            lbTableName.Text = "Таблица: Статус сотрудника";
        }

        private void STMIdoljnost_Click(object sender, EventArgs e)
        {
            plTable.Show();
            nameTable = "Должность";
            try
            {
                //выгрузка данных
                visiblObjct.VisiblTabClick(btInsert, btUpdate, btDelete, btClear, lb1, lb2, lb3, lb4, mtbdata, lb5, lb6, lb9, lb8, lb7, lbPoisk, tbPoisk, tb1, tb2,
    tb3, cb1, cb2, cb3, cb4, mtbBirthday, gbData);
                dgvTable.DataSource = null;

                tableLoad.dgvDoljnost(dgvTable);
                visiblObjct.Visible_Doljnosty(btInsert, btUpdate, btDelete, btClear,
                    lb1, lb2, lb3, lb4, mtbdata, lb5, lb6, lb9, lb8, lb7, lbPoisk, tbPoisk, tb1, tb2, tb3, cb1, cb2, cb3, cb4, mtbBirthday, gbData);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            lbTableName.Text = "Таблица: Должность";
        }

        private void TSMIconductionTheInstruction_Click(object sender, EventArgs e)
        {
            plTable.Show();
            nameTable = "Проводящий_инструктаж";
            try
            {
                //выгрузка данных
                visiblObjct.VisiblTabClick(btInsert, btUpdate, btDelete, btClear, lb1, lb2, lb3, lb4, mtbdata, lb5, lb6, lb9, lb8, lb7, lbPoisk, tbPoisk, tb1, tb2,
    tb3, cb1, cb2, cb3, cb4, mtbBirthday, gbData);
                dgvTable.DataSource = null;

                tableLoad.dgvConduction_the_instruction(dgvTable);
                visiblObjct.VisibleConduction_the_instructionClick(btInsert, btUpdate, btDelete, btClear,
                    lb1, lb2,lb3,lb4,mtbdata,lb5,lb6,lb9,lb8,lb7,lbPoisk,tbPoisk,tb1,tb2,tb3,cb1,cb2,cb3,cb4,mtbBirthday,gbData);
                getDateTable.cbSotrFill(cb1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            lbTableName.Text = "Таблица: Проводящий инструктаж";
        }

        private void TSMIstatusInstruction_Click(object sender, EventArgs e)
        {
            plTable.Show();
            nameTable = "Статус_инструктажа";

            try
            {
                //выгрузка данных
                visiblObjct.VisiblTabClick(btInsert, btUpdate, btDelete, btClear, lb1, lb2, lb3, lb4, mtbdata, lb5, lb6, lb9, lb8, lb7, lbPoisk, tbPoisk, tb1, tb2,
    tb3, cb1, cb2, cb3, cb4, mtbBirthday, gbData);
                dgvTable.DataSource = null;

                tableLoad.dgvStatus_instruction(dgvTable);
                visiblObjct.Visible_Status_instruction(btInsert, btUpdate, btDelete, btClear,
                    lb1, lb2, lb3, lb4, mtbdata, lb5, lb6, lb9, lb8, lb7, lbPoisk, tbPoisk, tb1, tb2, tb3, cb1, cb2, cb3, cb4,
                    mtbBirthday, gbData);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            lbTableName.Text = "Таблица: Статус инструктажа";
        }

        private void TSMIelectronicJournalInstruction_Click(object sender, EventArgs e)
        {
            plTable.Show();
            nameTable = "Электронный_журнал_инструктажа";

            try
            {
                //выгрузка данных
                visiblObjct.VisiblTabClick(btInsert, btUpdate, btDelete, btClear, lb1, lb2, lb3, lb4, mtbdata, lb5, lb6, lb9, lb8, lb7, lbPoisk, tbPoisk, tb1, tb2,
    tb3, cb1, cb2, cb3, cb4, mtbBirthday, gbData);
                dgvTable.DataSource = null;

                tableLoad.dgvElectronic_journal_of_instruction(dgvTable);
                visiblObjct.VisibleJornal_instructionClick(btInsert, btUpdate, btDelete, btClear,
        lb1, lb2, lb3, lb4, mtbdata, lb5, lb6, lb9, lb8, lb7, lbPoisk, tbPoisk, tb1, tb2, tb3, cb1, cb2, cb3, cb4, mtbBirthday, gbData);
                getDateTable.cbInstructionFill(cb1);
                getDateTable.cbStatus_instructionFill(cb2);
                getDateTable.cbSotrFill(cb3);
                getDateTable.cbConduction_the_instructionFill(cb4);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            lbTableName.Text = "Таблица: Электронный журнал инструктажа";
        }

        private void TSMIrole_Click(object sender, EventArgs e)
        {
            if (sizeForm == "Maximized")
            {
                this.SendToBack();
            }
            Role role = new Role();
            role.Show(); 

        }

        private void btCloseDoc_Click(object sender, EventArgs e)
        {
            plConfigDoc.Visible = false;
        }



        private void button3_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            tbPath.Text = folderBrowserDialog1.SelectedPath + "\\Отчёты\\";
        }


        private void button4_Click(object sender, EventArgs e)
        {
            OrganizationSave();
            DocumentSave();
            plConfigDoc.Visible = false;
        }


        private void OrganizationSave()
        {
            registry.MajorConfigurationSet(tbOrganizationName.Text);
        }

        private void DocumentSave()
        {
            string document_default_path = "";
            switch (tbPath.Text == "")
            {
                case (true):
                    document_default_path =
                        "C:\\Users\\" + SystemInformation.UserName
                        + "\\Documents\\Отчёты";
                    if (!Directory.Exists(document_default_path))
                        Directory.CreateDirectory(document_default_path);
                    break;
                case (false):
                    document_default_path = tbPath.Text;
                    if (!Directory.Exists(document_default_path))
                        Directory.CreateDirectory(document_default_path);
                    break;
            }

        }

        private void ComboBoxFontStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            SFF = ComboBoxFontStyle.SelectedItem.ToString();
        }

        private void FillComboBoxFont()
        {
            // загрузка стилей шрифта в ComboBox
            foreach (FontFamily font in fonts.Families)
            {
                ComboBoxFontStyle.Items.Add(font.Name);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OrganizationSave();
            DocumentSave();
        }

        private void закрытьПрограммуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            switch (nameTable)
            {
                case ("Статус_сотрудника"):
                    //Выполнение добавление
                    getDateTable.AddData_Status_sotr(tb1);
                    //Обновление данных для статуса сотрудников
                    tableLoad.dgvStatus_sotr(dgvTable);
                    break;
                case ("Сотрудники"):
                    getDateTable.AddData_Sotr(tb1, tb2, tb3, mtbBirthday, id_status_sotr, id_doljnosty);
                    MessageBox.Show(id_status_sotr.ToString());
                    tableLoad.dgvSotr(dgvTable);
                    
                    break;
                case ("Должность"):
                    getDateTable.AddData_Doljnosty(tb1);
                    tableLoad.dgvDoljnost(dgvTable);
                    break;
                case ("Проводящий_инструктаж"):
                    getDateTable.AddData_Conduction_the_instruction(id_sotr);
                    tableLoad.dgvConduction_the_instruction(dgvTable);
                    break;
                case ("Инструктаж"):
                    //Выполнение добавление
                    getDateTable.AddData_Instruction(tb1, mtbdata);
                    //Обновление данных для статуса сотрудников
                    tableLoad.dgvInstructionFill(dgvTable);
                    break;
                case ("Статус_инструктажа"):
                    getDateTable.AddData_Status_instruction(tb1);
                    tableLoad.dgvStatus_instruction(dgvTable);
                    break;
                case ("Электронный_журнал_инструктажа"):
                    getDateTable.AddData_Jornal(mtbBirthday,id_instruction,id_status_instruction,id_sotr,id_conduction_the_instruction);
                    tableLoad.dgvElectronic_journal_of_instruction(dgvTable);
                    break;
                case ("Авторизация"):
                    getDateTable.AddData_Avtoriz(tb1,tb2,id_sotr,id_role);
                    tableLoad.dgvAvtoriz(dgvTable);
                    break;
                case ("История_изменений"):
                    break;
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btActivLins_Click(object sender, EventArgs e)
        {
            if (mstbLins.Text == "     -     -     -")
            {
                MessageBox.Show("Введите данные!");
            }
            else

             if (mstbLins.Text == "LTMXB-OYTEQ-MYNTP-QWMOA")
            {
                registry.KeyProductSet(mstbLins.Text);
                MessageBox.Show("Ключ активирован");
                toolStrip1.Enabled = true;
                btCloseConf1.Enabled = true;
                StatusMod();
            }
            else
                MessageBox.Show("Введенные данные не вернные!");
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            switch (nameTable)
            {
                case ("Статус_сотрудника"):
                    getDateTable.UpdateStatus_Sotr( tb1, id_status_sotr);
                    tableLoad.dgvStatus_sotr(dgvTable);
                    break;
                case ("Сотрудники"):
                    getDateTable.UpdateSotr(id_sotr, tb1, tb2, tb3, mtbBirthday, id_status_sotr, id_doljnosty);
                    tableLoad.dgvSotr(dgvTable);
                    break;
                case ("Должность"):
                    getDateTable.UpdateDoljnosty(tb1, id_doljnosty);
                    tableLoad.dgvDoljnost(dgvTable);
                    break;
                case ("Проводящий_инструктаж"):
                    getDateTable.UpdateConduction_the_instruction(id_sotr, id_conduction_the_instruction);
                    tableLoad.dgvConduction_the_instruction(dgvTable);
                    break;
                case ("Инструктаж"):
                    getDateTable.UpdateInstruction( tb1, mtbdata, id_instruction);
                    tableLoad.dgvInstructionFill(dgvTable);
                    break;
                case ("Статус_инструктажа"):
                    getDateTable.UpdateStatus_instruction( tb1, id_status_instruction);
                    tableLoad.dgvStatus_instruction(dgvTable);
                    break;
                case ("Электронный_журнал_инструктажа"):
                    getDateTable.UpdateJornal(id_Electronic_Jornal,mtbBirthday, id_instruction, id_status_instruction, id_sotr, id_conduction_the_instruction);
                    tableLoad.dgvElectronic_journal_of_instruction(dgvTable);
                    break;
                case ("Авторизация"):
                    getDateTable.UpdateAvtoriz(ID_Avtoriz,tb1,tb2,id_sotr,id_role);
                    tableLoad.dgvAvtoriz(dgvTable);
                    break;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (timeDemo != 0)
            {
                tsslStatusMod.Text = "Осталось: " + timeDemo.ToString();
                timeDemo--;
               
            }
            else
            {
                timer2.Stop();
                MessageBox.Show("Время истекло, активируете программный продукт");
                pFormConfig.Visible = true;
                toolStrip1.Enabled = false;
                btCloseConf1.Enabled = false;
            }
        }

        private void TSMItool_project_Click(object sender, EventArgs e)
        {
            //Появление панели с настройками
            pFormConfig.Visible = true;
            if (plConfigDoc.Visible == true)
                plConfigDoc.Visible = false;
        }

        private void cb2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch (nameTable)
            {
                case ("Сотрудники"):
                    id_doljnosty = Convert.ToInt32(cb2.SelectedValue);
                    break;
                case ("Электронный_журнал_инструктажа"):
                    id_status_instruction = Convert.ToInt32(cb2.SelectedValue);
                    break;
                case ("Авторизация"):
                    id_role = Convert.ToInt32(cb2.SelectedValue);
                    break;
            }
        }

        private void версияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Версия программы 0.0.2");
        }

        private void tsddbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btVhod_Click(object sender, EventArgs e)
        {
            if ((TblLogin.Text == "") || (TblPassword.Text == ""))
            {
                if (TblLogin.Text == "")
                {
                    TblLogin.BackColor = System.Drawing.Color.Red;
                    LabelError1.Visible = true;
                    LabelError1.Text = "Пустой логин, введите логин";

                }
                else
                {
                    TblLogin.BackColor = System.Drawing.Color.White;
                    LabelError1.Visible = false;

                }

                if (TblPassword.Text == "")
                {
                    TblPassword.BackColor = System.Drawing.Color.Red;
                    LabelError2.Visible = true;
                    LabelError2.Text = "Пустой пароль, введите пароль";

                }
                else
                {
                    TblPassword.BackColor = System.Drawing.Color.White;
                    LabelError2.Visible = false;

                }
            }
            else
            {

                avtoriz.Authoriz(TblLogin, TblPassword);
                plAvtoriz.Visible = false;

            }
        }

        private void tsbLich_cab_Click(object sender, EventArgs e)
        {
            plAvtoriz.Visible = true;
            LabelError1.Visible = false;
            LabelError2.Visible = false;
        }

        private void cb3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch (nameTable)
            {
                case ("Электронный_журнал_инструктажа"):
                    id_sotr = Convert.ToInt32(cb3.SelectedValue);
                    break;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            plAvtoriz.Visible = false;
        }

        private void tbPoisk_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ////вариант 1 поиска
                if (tbPoisk.Text != "")
                {
                    dgvTable.CurrentCell = null;
                    for (int i = 0; i < dgvTable.Rows.Count - 1; i++)
                    {
                        dgvTable.Rows[i].Visible = false;
                        for (int c = 0; c < dgvTable.Columns.Count; c++)
                        {
                            if (dgvTable[c, i].Value.ToString() == tbPoisk.Text)
                            {
                                dgvTable.Rows[i].Visible = true;
                                break;
                            }
                        }
                    }
                }
                else
                {
                    dgvTable.CurrentCell = null;
                    for (int i = 0; i < dgvTable.Rows.Count - 1; i++)
                    {
                        dgvTable.Rows[i].Visible = true;
                    }
                }

                /////вариант 2
                //DataView DV = new DataView();
                //DV.RowFilter = string.Format("Должность LIKE '%{0}%'", tbPoisk.Text);
                //dgvTable.DataSource = DV;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void отзывToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Otzev otzev = new Otzev();
            otzev.Show();
        }

        private void btPichet_Click(object sender, EventArgs e)
        {
            Excel excel = new Excel();
            excel.Creet_excel();
        }

        private void tsbTable_DropDownOpening(object sender, EventArgs e)
        {
            Visible_menu();
        }

        private void cb4_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch (nameTable)
            {
                case ("Электронный_журнал_инструктажа"):
                    id_conduction_the_instruction = Convert.ToInt32(cb4.SelectedValue);
                    break;
            }
        }

        private void cb1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch (nameTable)
            {
                case ("Сотрудники"):
                    id_status_sotr = Convert.ToInt32(cb1.SelectedValue);
                    MessageBox.Show(id_status_sotr.ToString());
                    break;
                case ("Проводящий_инструктаж"):
                    id_sotr = Convert.ToInt32(cb1.SelectedValue);
                    break;
                case ("Электронный_журнал_инструктажа"):
                    id_instruction = Convert.ToInt32(cb1.SelectedValue);
                    break;
                case ("Авторизация"):
                    id_sotr= Convert.ToInt32(cb1.SelectedValue);
                    break;
            }
        }

        private void mtbBirthday_TextChanged(object sender, EventArgs e)
        {
            string dataNew;
            dataNew = mtbBirthday.Text;
            if (dataNew != DateTime.Now.ToLongDateString())
                mtbBirthday.Text = DateTime.Now.ToShortDateString();
        }

        private void TSMItoolDoc_Click(object sender, EventArgs e)
        {
            plConfigDoc.Visible = true;
            plTable.Visible = false;

            FillComboBoxFont();
            tbPath.Text = RegistryClass.DirPath;
            registry.ConfigurationGet();
            tbOrganizationName.Text = RegistryClass.OrganizationName;
            ComboBoxFontStyle.SelectedItem = RegistryClass.DocSFF;
            tbAddress.Text = RegistryClass.Address;
            RegistryClass.Address = tbAddress.Text;
            ComboBoxFontStyle.SelectedItem = SFF;
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            switch (nameTable)
            {
                case ("Статус_сотрудника"):
                    getDateTable.DeleteStatus_Sotr(id_status_sotr, tb1);
                    tableLoad.dgvStatus_sotr(dgvTable);
                    break;
                case ("Сотрудники"):
                    getDateTable.DeleteSotr(id_sotr,tb1,tb2,tb3,mtbBirthday);
                    tableLoad.dgvSotr(dgvTable);
                    break;
                case ("Должность"):
                    getDateTable.DeleteDoljnosty(id_doljnosty, tb1);
                    tableLoad.dgvDoljnost(dgvTable);
                    break;
                case ("Проводящий_инструктаж"):
                    getDateTable.DeleteConduction_the_instruction(id_conduction_the_instruction);
                    tableLoad.dgvConduction_the_instruction(dgvTable);
                    break;
                case ("Инструктаж"):
                    getDateTable.DeleteInstruction(id_instruction,tb1,mtbdata);
                    tableLoad.dgvInstructionFill(dgvTable);
                    break;
                case ("Статус_инструктажа"):
                    getDateTable.DeleteStatus_instruction(id_status_instruction, tb1);
                    tableLoad.dgvStatus_instruction(dgvTable);
                    break;
                case ("Электронный_журнал_инструктажа"):
                    getDateTable.DeleteJornal(id_Electronic_Jornal);
                    tableLoad.dgvElectronic_journal_of_instruction(dgvTable);
                    break;
                case ("Авторизация"):
                    getDateTable.DeleteAvtoriz(ID_Avtoriz);
                    tableLoad.dgvAvtoriz(dgvTable);
                    break;
            }
        }

        private void dgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (nameTable)
            {
                case ("Статус_сотрудника"):
                    try
                    {
                        tb1.Text = dgvTable.CurrentRow.Cells[1].Value.ToString();
                        id_status_sotr = Convert.ToInt32(dgvTable.CurrentRow.Cells[0].Value.ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case ("Сотрудники"):
                    try
                    {
                        id_sotr = Convert.ToInt32(dgvTable.CurrentRow.Cells[0].Value.ToString());
                        tb1.Text = dgvTable.CurrentRow.Cells[1].Value.ToString();
                        tb2.Text = dgvTable.CurrentRow.Cells[2].Value.ToString();
                        tb3.Text = dgvTable.CurrentRow.Cells[3].Value.ToString();
                        mtbBirthday.Text = dgvTable.CurrentRow.Cells[4].Value.ToString();
                        id_status_sotr = Convert.ToInt32(dgvTable.CurrentRow.Cells[5].Value.ToString());
                        id_doljnosty = Convert.ToInt32(dgvTable.CurrentRow.Cells[7].Value.ToString());

                        cb1.SelectedValue = id_status_sotr;
                        cb2.SelectedValue = id_doljnosty;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case ("Должность"):
                    try
                    {
                        tb1.Text = dgvTable.CurrentRow.Cells[1].Value.ToString();
                        id_doljnosty = Convert.ToInt32(dgvTable.CurrentRow.Cells[0].Value.ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case ("Проводящий_инструктаж"):
                    try
                    {
                        id_conduction_the_instruction = Convert.ToInt32(dgvTable.CurrentRow.Cells[0].Value.ToString());
                        id_sotr = Convert.ToInt32(dgvTable.CurrentRow.Cells[1].Value.ToString());
                        cb1.SelectedValue = id_sotr;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case ("Инструктаж"):
                    try
                    {
                        tb1.Text = dgvTable.CurrentRow.Cells[1].Value.ToString();
                        mtbdata.Text = dgvTable.CurrentRow.Cells[2].Value.ToString();
                        id_instruction = Convert.ToInt32(dgvTable.CurrentRow.Cells[0].Value.ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case ("Статус_инструктажа"):
                    try
                    {
                        tb1.Text = dgvTable.CurrentRow.Cells[1].Value.ToString();
                        id_status_instruction = Convert.ToInt32(dgvTable.CurrentRow.Cells[0].Value.ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case ("Электронный_журнал_инструктажа"):
                    try
                    {
                        mtbBirthday.Text = dgvTable.CurrentRow.Cells[1].Value.ToString();
                        id_Electronic_Jornal = Convert.ToInt32(dgvTable.CurrentRow.Cells[0].Value.ToString());
                        id_instruction = Convert.ToInt32(dgvTable.CurrentRow.Cells[2].Value.ToString());
                        id_status_instruction = Convert.ToInt32(dgvTable.CurrentRow.Cells[5].Value.ToString());
                        id_sotr = Convert.ToInt32(dgvTable.CurrentRow.Cells[7].Value.ToString());
                        id_conduction_the_instruction = Convert.ToInt32(dgvTable.CurrentRow.Cells[11].Value.ToString());

                        cb1.SelectedValue = id_instruction;
                        cb2.SelectedValue = id_status_instruction;
                        cb3.SelectedValue = id_sotr;
                        cb4.SelectedValue = id_conduction_the_instruction;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case ("Авторизация"):
                    try
                    {
                        ID_Avtoriz = Convert.ToInt32(dgvTable.CurrentRow.Cells[0].Value.ToString());
                        tb1.Text = dgvTable.CurrentRow.Cells[1].Value.ToString();
                        tb2.Text = dgvTable.CurrentRow.Cells[2].Value.ToString();
                        id_sotr = Convert.ToInt32(dgvTable.CurrentRow.Cells[3].Value.ToString());
                        id_role = Convert.ToInt32(dgvTable.CurrentRow.Cells[9].Value.ToString());

                        cb1.SelectedValue = id_sotr;
                        cb2.SelectedValue = id_role;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }

        public void BorderSwitch()
        {
            switch (burderStyle)
            {
                case ("None"):
                    this.FormBorderStyle = FormBorderStyle.None;
                    break;
                case ("FixedSingle"):
                    this.FormBorderStyle = FormBorderStyle.FixedSingle;
                    break;
            }
        }
        //изменение размера экрана
        public void SizeForm()
        {
            switch (sizeForm)
            {
                case ("Maximized"):
                    {
                        MaximumSize = Screen.PrimaryScreen.Bounds.Size;
                        this.FormBorderStyle = FormBorderStyle.None;
                        burderStyle = "None";
                        this.TopMost = true;
                        this.WindowState = FormWindowState.Maximized;
                        sizeForm = "Maximized";
                        rB1.Checked = true;
                    }
                    break;
                case ("Normal"):
                    {
                        this.WindowState = FormWindowState.Normal;
                        this.FormBorderStyle = FormBorderStyle.FixedSingle;
                        burderStyle = "FixedSingle";
                        this.StartPosition = FormStartPosition.CenterScreen;
                        sizeForm = "Normal";
                        rB2.Checked = true;
                    }
                    break;
            }
        }

        public void StatusMod()
        {
            try
            {
                RegistryKey versLins = currentUserKey.OpenSubKey("Instruction\\KeyLins");
                string lins = versLins.GetValue("Key").ToString();
                if (lins == "LTMXB-OYTEQ-MYNTP-QWMOA")
                {
 
                        tsslStatusMod.Visible = false;
                        btActivLins.Visible = false;
                        lbactiv.Visible = false;
                        mstbLins.Visible = false;
                        timer2.Enabled = false;
                        tsslOST.Visible = false;
                }
                else
                    timer2.Enabled = true;
                    tsslOST.Visible = true;
            }
            catch
            {
                registry.Registry_Get();
                timer2.Enabled = true;
            }        

        }

        public void Visible_menu()
        {
  
            if (Program.Avtoriz_user)
            {
                if (Program.Table_Avtoriz == 1) TSMIavtoriz.Visible = true;
                else TSMIavtoriz.Visible = false;
                if (Program.Table_History == 1) TSMIhistory.Visible = true;
                else TSMIhistory.Visible = false;
                if (Program.Table_Electronic_journal_of_instruction == 1) TSMIelectronicJournalInstruction.Visible = true;
                else TSMIelectronicJournalInstruction.Visible = false;
                if (Program.Table_Conduction_the_instruction == 1) TSMIconductionTheInstruction.Visible = true;
                else TSMIconductionTheInstruction.Visible = false;
                if (Program.Table_Sotr == 1) TSMISotr.Visible = true;
                else TSMISotr.Visible = false;
                if (Program.Table_Doljnost == 1) STMIdoljnost.Visible = true;
                else STMIdoljnost.Visible = false;
                if (Program.Table_Status_sotr == 1) STMIstatus_Sotr.Visible = true;
                else STMIstatus_Sotr.Visible = false;
                if (Program.Table_Status_instruction == 1) TSMIstatusInstruction.Visible = true;
                else TSMIstatusInstruction.Visible = false;
                if (Program.Table_Instruction == 1) TSMIinstruction.Visible = true;
                else TSMIinstruction.Visible = false;
                if (Program.Table_Role == 1) TSMIrole.Visible = true;
                else TSMIrole.Visible = false;
            }
            else
            {
                TSMIavtoriz.Visible = false;
                TSMIhistory.Visible = false;
                TSMIconductionTheInstruction.Visible = false;
                TSMIelectronicJournalInstruction.Visible = false;
                TSMIrole.Visible = false;
                TSMISotr.Visible = false;
                STMIdoljnost.Visible = false;
                STMIstatus_Sotr.Visible = false;
                TSMIstatusInstruction.Visible = false;
                TSMIinstruction.Visible = false;

            }

        }

    }
}

