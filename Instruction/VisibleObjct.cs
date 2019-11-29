using System.Windows.Forms;


namespace Instruction
{
    class VisibleObjct
    {

        public void InstructionClick(Button btInsertVis, Button btUpdateVis, Button btDeleteVis, Button btClearVis,
Label lb1Vis, Label lb2Vis, Label lb3Vis, Label lb4Vis,  Label lb5Vis, Label lb6Vis, Label lb7Vis, Label lb8Vis, Label lb9Vis, Label lbpoiskVis,
TextBox tbPoiskVis, TextBox tb1, TextBox tb2, TextBox tb3,
ComboBox cb1, ComboBox cb2, ComboBox cb3, ComboBox cb4, DateTimePicker mtb2, MaskedTextBox mtb1, GroupBox box)
        {
            //Button
            btInsertVis.Visible = true;
            btUpdateVis.Visible = true;
            btDeleteVis.Visible = true;
            btClearVis.Visible = false;
            //Label
            lb1Vis.Visible = true;
            lb1Vis.Text = "Вид инструктажа";
            lb2Vis.Visible = true;
            lb2Vis.Text = "Время проведения";
            lb3Vis.Visible = false;
            lb4Vis.Visible = false;
            lb5Vis.Visible = false;
            lb6Vis.Visible = false;
            lb7Vis.Visible = false;
            lb8Vis.Visible = false;

            lb9Vis.Visible = false;
            lbpoiskVis.Visible = true;
            //TextBox
            tbPoiskVis.Visible = true;
            tb1.Visible = true;
            tb2.Visible = false;
            tb3.Visible = false;
            //ComboBox
            cb1.Visible = false;
            cb2.Visible = false;
            cb3.Visible = false;
            cb4.Visible = false;
            mtb1.Visible = true;
            mtb2.Visible = false;
            //GrobBox
            box.Visible = true;
        }

        public void VisiblTabClick(Button btInsertVis, Button btUpdateVis, Button btDeleteVis, Button btClearVis,
Label lb1Vis, Label lb2Vis, Label lb3Vis, Label lb4Vis, MaskedTextBox mtb1, Label lb5Vis, Label lb6Vis, Label lb7Vis, Label lb8Vis, Label lb9Vis, Label lbpoiskVis,
TextBox tbPoiskVis, TextBox tb1, TextBox tb2, TextBox tb3,
ComboBox cb1, ComboBox cb2, ComboBox cb3, ComboBox cb4, DateTimePicker mtb2, GroupBox box)
        {
            //Button
            btInsertVis.Visible = false;
            btUpdateVis.Visible = false;
            btDeleteVis.Visible = false;
            btClearVis.Visible = false;
            //Label
            lb1Vis.Text = "";
            lb2Vis.Text = "";
            lb3Vis.Text = "";
            lb4Vis.Text = "";
            lb5Vis.Text = "";
            lb6Vis.Text = "";
            lb7Vis.Text = "";
            lb8Vis.Text = "";
            lb9Vis.Text = "";
            //TextBox
            tbPoiskVis.Text = "";
            tb1.Text = "";
            tb2.Text = "";
            tb3.Text = "";
            //ComboBox

            mtb1.Text = "";
            mtb2.Text = "";
            //GrobBox

            lb1Vis.Visible = false;
            lb2Vis.Visible = false;
            lb3Vis.Visible = false;
            lb4Vis.Visible = false;
            lb5Vis.Visible = false;
            lb6Vis.Visible = false;
            lb7Vis.Visible = false;
            lb8Vis.Visible = false;
            lb9Vis.Visible = false;
            tbPoiskVis.Visible = false;
            tb1.Visible = false;
            tb2.Visible = false;
            tb3.Visible = false;
            mtb1.Visible = false;
            mtb2.Visible = false;
            box.Visible = false;
        }

        public void Visible_Status_sotr(Button btInsertVis, Button btUpdateVis, Button btDeleteVis, Button btClearVis,
Label lb1Vis, Label lb2Vis, Label lb3Vis, Label lb4Vis, MaskedTextBox mtb1, Label lb5Vis, Label lb6Vis, Label lb7Vis, Label lb8Vis, Label lb9Vis, Label lbpoiskVis,
TextBox tbPoiskVis, TextBox tb1, TextBox tb2, TextBox tb3,
ComboBox cb1, ComboBox cb2, ComboBox cb3, ComboBox cb4, DateTimePicker mtb2, GroupBox box)
        {
            //Button
            btInsertVis.Visible = true;
            btUpdateVis.Visible = true;
            btDeleteVis.Visible = true;
            btClearVis.Visible = false;
            //Label
            lb1Vis.Visible = true;
            lb1Vis.Text = "Статус сотрудника";
            lb2Vis.Visible = false;
            lb3Vis.Visible = false;
            lb4Vis.Visible = false;
            lb5Vis.Visible = false;
            lb6Vis.Visible = false;
            lb7Vis.Visible = false;
            lb8Vis.Visible = false;
            lb9Vis.Visible = false;
            lbpoiskVis.Visible = true;
            //TextBox
            tbPoiskVis.Visible = true;
            tb1.Visible = true;
            tb2.Visible = false;
            tb3.Visible = false;
            //ComboBox
            cb1.Visible = false;
            cb2.Visible = false;
            cb3.Visible = false;
            cb4.Visible = false;
            mtb1.Visible = false;
            mtb2.Visible = false;
            //GrobBox
            box.Visible = true;
        }

        public void Visible_Doljnosty(Button btInsertVis, Button btUpdateVis, Button btDeleteVis, Button btClearVis,
Label lb1Vis, Label lb2Vis, Label lb3Vis, Label lb4Vis, MaskedTextBox mtb1, Label lb5Vis, Label lb6Vis, Label lb7Vis, Label lb8Vis, Label lb9Vis, Label lbpoiskVis,
TextBox tbPoiskVis, TextBox tb1, TextBox tb2, TextBox tb3,
ComboBox cb1, ComboBox cb2, ComboBox cb3, ComboBox cb4, DateTimePicker mtb2, GroupBox box)
        {
            //Button
            btInsertVis.Visible = true;
            btUpdateVis.Visible = true;
            btDeleteVis.Visible = true;
            btClearVis.Visible = false;
            //Label
            lb1Vis.Visible = true;
            lb1Vis.Text = "Должность";
            lb2Vis.Visible = false;
            lb3Vis.Visible = false;
            lb4Vis.Visible = false;
            lb5Vis.Visible = false;
            lb6Vis.Visible = false;
            lb7Vis.Visible = false;
            lb8Vis.Visible = false;
            lb9Vis.Visible = false;
            lbpoiskVis.Visible = true;
            //TextBox
            tbPoiskVis.Visible = true;
            tb1.Visible = true;
            tb2.Visible = false;
            tb3.Visible = false;
            //ComboBox
            cb1.Visible = false;
            cb2.Visible = false;
            cb3.Visible = false;
            cb4.Visible = false;
            mtb1.Visible = false;
            mtb2.Visible = false;
            //GrobBox
            box.Visible = true;
        }

        public void Visible_Status_instruction(Button btInsertVis, Button btUpdateVis, Button btDeleteVis, Button btClearVis,
Label lb1Vis, Label lb2Vis, Label lb3Vis, Label lb4Vis, MaskedTextBox mtb1, Label lb5Vis, Label lb6Vis, Label lb7Vis, Label lb8Vis, Label lb9Vis, Label lbpoiskVis,
TextBox tbPoiskVis, TextBox tb1, TextBox tb2, TextBox tb3,
ComboBox cb1, ComboBox cb2, ComboBox cb3, ComboBox cb4, DateTimePicker mtb2, GroupBox box)
        {
            //Button
            btInsertVis.Visible = true;
            btUpdateVis.Visible = true;
            btDeleteVis.Visible = true;
            btClearVis.Visible = false;
            //Label
            lb1Vis.Visible = true;
            lb1Vis.Text = "Статус инструктажа";
            lb2Vis.Visible = false;
            lb3Vis.Visible = false;
            lb4Vis.Visible = false;
            lb5Vis.Visible = false;
            lb6Vis.Visible = false;
            lb7Vis.Visible = false;
            lb8Vis.Visible = false;
            lb9Vis.Visible = false;
            lbpoiskVis.Visible = true;
            //TextBox
            tbPoiskVis.Visible = true;
            tb1.Visible = true;
            tb2.Visible = false;
            tb3.Visible = false;
            //ComboBox
            cb1.Visible = false;
            cb2.Visible = false;
            cb3.Visible = false;
            cb4.Visible = false;
            mtb1.Visible = false;
            mtb2.Visible = false;
            //GrobBox
            box.Visible = true;
        }

        public void Visible_Instruction(Button btInsertVis, Button btUpdateVis, Button btDeleteVis, Button btClearVis,
Label lb1Vis, Label lb2Vis, Label lb3Vis, Label lb4Vis, MaskedTextBox mtb1, Label lb5Vis, Label lb6Vis, Label lb7Vis, Label lb8Vis, Label lb9Vis, Label lbpoiskVis,
TextBox tbPoiskVis, TextBox tb1, TextBox tb2, TextBox tb3,
ComboBox cb1, ComboBox cb2, ComboBox cb3, ComboBox cb4, DateTimePicker mtb2, GroupBox box)
        {
            //Button
            btInsertVis.Visible = true;
            btUpdateVis.Visible = true;
            btDeleteVis.Visible = true;
            btClearVis.Visible = false;
            //Label
            lb1Vis.Visible = true;
            lb1Vis.Text = "Вид инструктажа";
            lb2Vis.Visible = true;
            lb2Vis.Text = "Время выполнения";
            lb3Vis.Visible = false;
            lb4Vis.Visible = false;
            lb5Vis.Visible = false;
            lb6Vis.Visible = false;
            lb7Vis.Visible = false;
            lb8Vis.Visible = false;
            lb9Vis.Visible = false;
            lbpoiskVis.Visible = true;
            //TextBox
            tbPoiskVis.Visible = true;
            tb1.Visible = true;
            tb2.Visible = false;
            tb3.Visible = false;
            //ComboBox
            cb1.Visible = false;
            cb2.Visible = false;
            cb3.Visible = false;
            cb4.Visible = false;
            mtb1.Visible = false;
            mtb2.Visible = true;
            //GrobBox
            box.Visible = true;
        }

        public void Visible_SotrClick(Button btInsertVis, Button btUpdateVis, Button btDeleteVis, Button btClearVis,
Label lb1Vis, Label lb2Vis, Label lb3Vis, Label lb4Vis, MaskedTextBox mtb1, Label lb5Vis, Label lb6Vis, Label lb7Vis, Label lb8Vis, Label lb9Vis, Label lbpoiskVis,
TextBox tbPoiskVis, TextBox tb1, TextBox tb2, TextBox tb3,
ComboBox cb1, ComboBox cb2, ComboBox cb3, ComboBox cb4, DateTimePicker mtb2, GroupBox box)
        {
            //Button
            btInsertVis.Visible = true;
            btUpdateVis.Visible = true;
            btDeleteVis.Visible = true;
            btClearVis.Visible = false;
            //Label
            lb1Vis.Visible = true;
            lb1Vis.Text = "Фамилия сотрудника";
            lb2Vis.Visible = true;
            lb2Vis.Text = "Имя Сотрудника";
            lb3Vis.Visible = true;
            lb3Vis.Text = "Отчество сотрудника";
            lb7Vis.Visible = true;
            lb7Vis.Text = "Дата рождения";
            lb4Vis.Visible = true;
            lb4Vis.Text = "Статус сотрудника";
            lb5Vis.Visible = true;
            lb5Vis.Text = "Должность";
            lb6Vis.Visible = false;
            lb8Vis.Visible = false;
            lb9Vis.Visible = false;
            lbpoiskVis.Visible = true;
            //TextBox
            tbPoiskVis.Visible = true;
            tb1.Visible = true;
            tb2.Visible = true;
            tb3.Visible = true;
            //ComboBox
            cb1.Visible = true;
            cb2.Visible = true;
            cb3.Visible = false;
            cb4.Visible = false;
            mtb1.Visible = false;
            mtb2.Visible = true;
            //GrobBox
            box.Visible = true;
        }


        public void Visible_HistoryClick(Button btInsertVis, Button btUpdateVis, Button btDeleteVis, Button btClearVis,
Label lb1Vis, Label lb2Vis, Label lb3Vis, Label lb4Vis, MaskedTextBox mtb1, Label lb5Vis, Label lb6Vis, Label lb7Vis, Label lb8Vis, Label lb9Vis, Label lbpoiskVis,
TextBox tbPoiskVis, TextBox tb1, TextBox tb2, TextBox tb3,
ComboBox cb1, ComboBox cb2, ComboBox cb3, ComboBox cb4, DateTimePicker mtb2, GroupBox box)
        {
            //Button
            btInsertVis.Visible = false;
            btUpdateVis.Visible = false;
            btDeleteVis.Visible = false;
            btClearVis.Visible = true;
            //Label
            lb1Vis.Visible = false;
            lb1Vis.Text = "Фамилия сотрудника";
            lb2Vis.Visible = false;
            lb2Vis.Text = "Имя Сотрудника";
            lb3Vis.Visible = false;
            lb3Vis.Text = "Отчество сотрудника";
            lb7Vis.Visible = false;
            lb7Vis.Text = "Дата рождения";
            lb4Vis.Visible = false;
            lb4Vis.Text = "Статус сотрудника";
            lb5Vis.Visible = false;
            lb5Vis.Text = "Должность";
            lb6Vis.Visible = false;
            lb8Vis.Visible = false;
            lb9Vis.Visible = false;
            lbpoiskVis.Visible = false;
            //TextBox
            tbPoiskVis.Visible = true;
            tb1.Visible = false;
            tb2.Visible = false;
            tb3.Visible = false;
            //ComboBox
            cb1.Visible = false;
            cb2.Visible = false;
            cb3.Visible = false;
            cb4.Visible = false;
            mtb1.Visible = false;
            mtb2.Visible = false;
            //GrobBox
            box.Visible = false;
        }

        public void VisibleConduction_the_instructionClick(Button btInsertVis, Button btUpdateVis, Button btDeleteVis, Button btClearVis,
Label lb1Vis, Label lb2Vis, Label lb3Vis, Label lb4Vis, MaskedTextBox mtb1, Label lb5Vis, Label lb6Vis, Label lb7Vis, Label lb8Vis, Label lb9Vis, Label lbpoiskVis,
TextBox tbPoiskVis, TextBox tb1, TextBox tb2, TextBox tb3,
ComboBox cb1, ComboBox cb2, ComboBox cb3, ComboBox cb4, DateTimePicker mtb2, GroupBox box)
        {
            //Button
            btInsertVis.Visible = true;
            btUpdateVis.Visible = true;
            btDeleteVis.Visible = true;
            btClearVis.Visible = false;
            //Label
            lb1Vis.Visible = true;
            lb1Vis.Text = "Проводящий инструктаж";
            lb2Vis.Visible = false;
            lb2Vis.Text = "Имя Сотрудника";
            lb3Vis.Visible = false;
            lb3Vis.Text = "Отчество сотрудника";
            lb7Vis.Visible = false;
            lb7Vis.Text = "Дата рождения";
            lb4Vis.Visible = false;
            lb4Vis.Text = "Статус сотрудника";
            lb5Vis.Visible = false;
            lb5Vis.Text = "Должность";
            lb6Vis.Visible = false;
            lb8Vis.Visible = false;
            lb9Vis.Visible = false;
            lbpoiskVis.Visible = true;
            //TextBox
            tbPoiskVis.Visible = true;
            tb1.Visible = false;
            tb2.Visible = false;
            tb3.Visible = false;
            //ComboBox
            cb1.Visible = true;
            cb2.Visible = false;
            cb3.Visible = false;
            cb4.Visible = false;
            mtb1.Visible = false;
            mtb2.Visible = false;
            //GrobBox
            box.Visible = true;
        }

        public void VisibleJornal_instructionClick(Button btInsertVis, Button btUpdateVis, Button btDeleteVis, Button btClearVis,
Label lb1Vis, Label lb2Vis, Label lb3Vis, Label lb4Vis, MaskedTextBox mtb1, Label lb5Vis, Label lb6Vis, Label lb7Vis, Label lb8Vis, Label lb9Vis, Label lbpoiskVis,
TextBox tbPoiskVis, TextBox tb1, TextBox tb2, TextBox tb3,
ComboBox cb1, ComboBox cb2, ComboBox cb3, ComboBox cb4, DateTimePicker mtb2, GroupBox box)
        {
            //Button
            btInsertVis.Visible = true;
            btUpdateVis.Visible = true;
            btDeleteVis.Visible = true;
            btClearVis.Visible = false;
            //Label
            lb1Vis.Visible = true;
            lb1Vis.Text = "Инструктаж";
            lb2Vis.Visible = false;
            lb3Vis.Visible = false;
            lb4Vis.Visible = false;
            lb4Vis.Text = "Статус инструктажа";
            lb5Vis.Visible = true;
            lb5Vis.Text = "Статус инструктажа";
            lb6Vis.Visible = true;
            lb6Vis.Text = "Сотруники";
            lb7Vis.Visible = true;
            lb7Vis.Text = "Дата проведения инструктажа";
            lb8Vis.Visible = false;
            lb9Vis.Visible = true;
            lb9Vis.Text = "Проводящи инструктаж";
            lbpoiskVis.Visible = true;
            //TextBox
            tbPoiskVis.Visible = true;
            tb1.Visible = false;
            tb2.Visible = false;
            tb3.Visible = false;
            //ComboBox
            cb1.Visible = true;
            cb2.Visible = true;
            cb3.Visible = true;
            cb4.Visible = true;
            mtb1.Visible = false;
            mtb2.Visible = true;
            //GrobBox
            box.Visible = true;
        }

        public void VisibleAvtroziClick(Button btInsertVis, Button btUpdateVis, Button btDeleteVis, Button btClearVis,
Label lb1Vis, Label lb2Vis, Label lb3Vis, Label lb4Vis, MaskedTextBox mtb1, Label lb5Vis, Label lb6Vis, Label lb7Vis, Label lb8Vis, Label lb9Vis, Label lbpoiskVis,
TextBox tbPoiskVis, TextBox tb1, TextBox tb2, TextBox tb3,
ComboBox cb1, ComboBox cb2, ComboBox cb3, ComboBox cb4, DateTimePicker mtb2, GroupBox box)
        {
            //Button
            btInsertVis.Visible = true;
            btUpdateVis.Visible = true;
            btDeleteVis.Visible = true;
            btClearVis.Visible = false;
            //Label
            lb1Vis.Visible = true;
            lb1Vis.Text = "Логин";
            lb2Vis.Visible = true;
            lb2Vis.Text = "Пароль";
            lb3Vis.Visible = true;
            lb3Vis.Text = "Сотрудник";
            lb4Vis.Visible = false;
            lb5Vis.Visible = true;
            lb5Vis.Text = "Роль";
            lb6Vis.Visible = false;
            lb6Vis.Text = "Роль";
            lb7Vis.Visible = false;
            lb7Vis.Text = "Дата проведения инструктажа";
            lb8Vis.Visible = false;
            lb9Vis.Visible = false;
            lb9Vis.Text = "Проводящи инструктаж";
            lbpoiskVis.Visible = true;
            //TextBox
            tbPoiskVis.Visible = true;
            tb1.Visible = true;
            tb2.Visible = true;
            tb3.Visible = false;
            //ComboBox
            cb1.Visible = true;
            cb2.Visible = true;
            cb3.Visible = false;
            cb4.Visible = false;
            mtb1.Visible = false;
            mtb2.Visible = false;
            //GrobBox
            box.Visible = true;
        }

    }
}
