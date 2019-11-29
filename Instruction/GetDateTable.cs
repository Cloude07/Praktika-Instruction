using System;
using System.Windows.Forms;
using RegistryLibrary;
using System.Data.SqlClient;

namespace Instruction
{
    class GetDateTable
    {
        SqlCommand command = new SqlCommand("", RegistryClass.sqlConnection);
        DataBase_Procedure procedure = new DataBase_Procedure();

        public void AddData_Status_sotr(TextBox tb1)
        {
            switch (tb1.Text == "")
            {
                case (true):
                    MessageBox.Show("Введите данные!");
                    break;
                case (false):
                    try
                    {
                        procedure.spStatus_sotr_insert(tb1.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        tb1.Clear();
                    }
                    break;
            }
        }
        public void UpdateStatus_Sotr(TextBox tb1, Int32 ID_Status_sotr)
        {
            try
            {
                switch (MessageBox.Show("Вы точно хотите изменить статус сотрудника?", "Подтверждение изменения", MessageBoxButtons.YesNo))
                {

                    case (DialogResult.Yes):
                        {
                            procedure.spStatus_sotr_Update(ID_Status_sotr, tb1.Text);
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tb1.Clear();
            }
        }
        public void DeleteStatus_Sotr(Int32 ID_Status_sotr, TextBox tb1)
        {
            try
            {
                switch (MessageBox.Show("Вы точно хотите удалить статус сотрудника?", "Подтверждение удаления", MessageBoxButtons.YesNo))
                {

                    case (DialogResult.Yes):

                        {
                            procedure.spStatus_sotr_Delete(ID_Status_sotr);
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tb1.Clear();
            }
        }

        public void AddData_Doljnosty(TextBox tb1)
        {
            switch (tb1.Text == "")
            {
                case (true):
                    MessageBox.Show("Введите данные!");
                    break;
                case (false):
                    try
                    {
                        procedure.spDoljnost_insert(tb1.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        tb1.Clear();
                    }
                    break;
            }
        }
        public void UpdateDoljnosty(TextBox tb1, Int32 ID_Doljnosty)
        {
            try
            {
                switch (MessageBox.Show("Вы точно хотите изменить должность?", "Подтверждение изменения", MessageBoxButtons.YesNo))
                {

                    case (DialogResult.Yes):
                        {
                            procedure.spDoljnost_Update(ID_Doljnosty, tb1.Text);
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tb1.Clear();
            }
        }
        public void DeleteDoljnosty(Int32 ID_Doljnosty, TextBox tb1)
        {
            try
            {
                switch (MessageBox.Show("Вы точно хотите удалить должность?", "Подтверждение удаления", MessageBoxButtons.YesNo))
                {
                    case (DialogResult.Yes):
                        {
                            procedure.spDoljnost_Delete(ID_Doljnosty);
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tb1.Clear();
            }
        }

        public void AddData_Status_instruction(TextBox tb1)
        {
            switch (tb1.Text == "")
            {
                case (true):
                    MessageBox.Show("Введите данные!");
                    break;
                case (false):
                    try
                    {
                        procedure.spStatus_instruction_insert(tb1.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        tb1.Clear();
                    }
                    break;
            }
        }
        public void UpdateStatus_instruction(TextBox tb1, Int32 ID_status_instruction)
        {
            try
            {
                switch (MessageBox.Show("Вы точно хотите изменить статус инструктажа?", "Подтверждение изменения", MessageBoxButtons.YesNo))
                {

                    case (DialogResult.Yes):
                        {
                            procedure.spStatus_instruction_Update(ID_status_instruction, tb1.Text);
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tb1.Clear();
            }
        }
        public void DeleteStatus_instruction(Int32 ID_status_instruction, TextBox tb1)
        {
            try
            {
                switch (MessageBox.Show("Вы точно хотите удалить статус инструктажа?", "Подтверждение удаления", MessageBoxButtons.YesNo))
                {

                    case (DialogResult.Yes):
                        {
                            procedure.spStatus_instruction_Delete(ID_status_instruction);
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tb1.Clear();
            }
        }

        public void AddData_Instruction(TextBox tb1, MaskedTextBox mtb1)
        {
            switch (tb1.Text == "" && mtb1.Text == "")
            {
                case (true):
                    MessageBox.Show("Введите данные!");
                    break;
                case (false):
                    try
                    {
                        procedure.spInstruction_insert(tb1.Text, mtb1.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        tb1.Clear();
                        mtb1.Clear();
                    }
                    break;
            }
        }
        public void UpdateInstruction(TextBox tb1, MaskedTextBox mtb1, Int32 ID_instruction)
        {
            try
            {
                switch (MessageBox.Show("Вы точно хотите изменить инструктаж?", "Подтверждение изменения", MessageBoxButtons.YesNo))
                {

                    case (DialogResult.Yes):
                        {
                            procedure.spInstruction_Update(ID_instruction, tb1.Text, mtb1.Text);
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tb1.Clear();
                mtb1.Clear();
            }
        }
        public void DeleteInstruction(Int32 ID_instruction, TextBox tb1, MaskedTextBox mtb1)
        {
            try
            {
                switch (MessageBox.Show("Вы точно хотите удалить инструктаж?", "Подтверждение удаления", MessageBoxButtons.YesNo))
                {

                    case (DialogResult.Yes):
                        {
                            procedure.spInstruction_Delete(ID_instruction);
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tb1.Clear();
                mtb1.Clear();
            }
        }

        public void AddData_Sotr(TextBox tb1, TextBox tb2, TextBox tb3, DateTimePicker mtb2, Int32 ID_Status_Sotr, Int32 ID_Doljnosty)
        {
            switch (tb1.Text == "" && tb2.Text == "" && tb3.Text == "")
            {
                case (true):
                    MessageBox.Show("Введите данные!");
                    break;
                case (false):
                    try
                    {
                        procedure.spSotr_insert(tb1.Text, tb2.Text, tb3.Text, mtb2.Value.ToString(), ID_Status_Sotr, ID_Doljnosty);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        tb1.Clear();
                        tb2.Clear();
                        tb3.Clear();

                    }
                    break;
            }

        }

        public void UpdateSotr(Int32 ID_Sotr, TextBox tb1, TextBox tb2, TextBox tb3, DateTimePicker mtb2, Int32 ID_Status_Sotr, Int32 ID_Doljnosty)
        {
            try
            {
                switch (MessageBox.Show("Вы точно хотите изменить сотрудника?", "Подтверждение изменения", MessageBoxButtons.YesNo))
                {

                    case (DialogResult.Yes):
                        {
                            procedure.spSotr_Update(ID_Sotr, tb1.Text, tb2.Text, tb3.Text, mtb2.Value.ToString(), ID_Status_Sotr, ID_Doljnosty);
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tb1.Clear();
                tb2.Clear();
                tb3.Clear();
            }
        }
        public void DeleteSotr(Int32 ID_Sotr, TextBox tb1, TextBox tb2, TextBox tb3, DateTimePicker mtb2)
        {
            try
            {
                switch (MessageBox.Show("Вы точно хотите удалить сотрудника?", "Подтверждение удаления", MessageBoxButtons.YesNo))
                {

                    case (DialogResult.Yes):
                        {
                            procedure.spSotr_Delete(ID_Sotr);
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tb1.Clear();
                tb2.Clear();
                tb3.Clear();

            }
        }

        public void AddData_Conduction_the_instruction(Int32 ID_Sotr)
        {
            try
            {
                procedure.spConduction_the_instruction_insert(ID_Sotr);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateConduction_the_instruction(Int32 ID_Sotr, Int32 ID_Conduction_the_instruction)
        {
            try
            {
                switch (MessageBox.Show("Вы точно хотите изменить проводящего инструктаж?", "Подтверждение изменения", MessageBoxButtons.YesNo))
                {

                    case (DialogResult.Yes):
                        {
                            procedure.spConduction_the_instruction_Update(ID_Conduction_the_instruction, ID_Sotr);
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void DeleteConduction_the_instruction(Int32 ID_Conduction_the_instruction)
        {
            try
            {
                switch (MessageBox.Show("Вы точно хотите удалить проводящего инструктаж?", "Подтверждение удаления", MessageBoxButtons.YesNo))
                {

                    case (DialogResult.Yes):
                        {
                            procedure.spConduction_the_instruction_Delete(ID_Conduction_the_instruction);
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void AddData_Jornal(DateTimePicker mtb2, Int32 ID_Instruction, Int32 ID_Status_instruction, Int32 ID_Sotr, Int32 ID_Conduction_the_instruction)
        {
                    try
                    {
                        procedure.spElectronic_journal_of_instruction_insert(mtb2.Text, ID_Instruction,ID_Status_instruction,ID_Sotr,ID_Conduction_the_instruction);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
            }

        

        public void UpdateJornal(Int32 ID_Electronic_jornal, DateTimePicker mtb2, Int32 ID_Instruction, Int32 ID_Status_instruction, Int32 ID_Sotr, Int32 ID_Conduction_the_instruction)
        {
            try
            {
                switch (MessageBox.Show("Вы точно хотите изменить журнал иструктажа?", "Подтверждение изменить", MessageBoxButtons.YesNo))
                {

                    case (DialogResult.Yes):
                        {
                            procedure.spElectronic_journal_of_instruction_Update(ID_Electronic_jornal, mtb2.Text, ID_Instruction, ID_Status_instruction, ID_Sotr, ID_Conduction_the_instruction);
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DeleteJornal(Int32 ID_Electronic_jornal)
        {
            try
            {
                switch (MessageBox.Show("Вы точно хотите удалить журнал инструктажа?", "Подтверждение удаления", MessageBoxButtons.YesNo))
                {

                    case (DialogResult.Yes):
                        {
                            procedure.spElectronic_journal_of_instruction_Delete(ID_Electronic_jornal);
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AddData_Avtoriz(TextBox tb1, TextBox tb2, Int32 ID_Sotr, Int32 ID_Role)
        {
            try
            {
                procedure.spAvtoriz_Insert(tb1.Text, tb2.Text, ID_Sotr, ID_Role);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        public void UpdateAvtoriz(Int32 ID_Avtoriz, TextBox tb1, TextBox tb2, Int32 ID_Sotr, Int32 ID_Role)
        {
            try
            {
                switch (MessageBox.Show("Вы точно хотите изменить Авторизацию?", "Подтверждение изменить", MessageBoxButtons.YesNo))
                {

                    case (DialogResult.Yes):
                        {
                            procedure.spAvtoriz_Update(ID_Avtoriz, tb1.Text, tb2.Text, ID_Sotr, ID_Role);
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DeleteAvtoriz(Int32 ID_Avtoriz)
        {
            try
            {
                switch (MessageBox.Show("Вы точно хотите удалить Авторизацию?", "Подтверждение удаления", MessageBoxButtons.YesNo))
                {

                    case (DialogResult.Yes):
                        {
                            procedure.spAvtoriz_Delete(ID_Avtoriz);
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void cbDoljnostyFill(ComboBox cb2)
        {
            try
            {
                DataBase_Table_Instruction dtDoljnost = new DataBase_Table_Instruction();
                dtDoljnost.dtDoljnostFill();
                cb2.DataSource = dtDoljnost.dtDoljnost;
                cb2.ValueMember = "Ключ должности";
                cb2.DisplayMember = "Должность";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void cbConduction_the_instructionFill(ComboBox cb1)
        {
            try
            {
                DataBase_Table_Instruction dtConduction_the_instruction = new DataBase_Table_Instruction();
                dtConduction_the_instruction.dtConduction_the_instructionFill();
                cb1.DataSource = dtConduction_the_instruction.dtConduction_the_instruction;
                cb1.ValueMember = "Ключ проводящего инструктаж";
                cb1.DisplayMember = "Проводящий инструктаж";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void cbStatusSotrFill(ComboBox cb1)
        {
            try
            {
                DataBase_Table_Instruction dtStatus = new DataBase_Table_Instruction();
                dtStatus.dtStatus_sotrFill();
                cb1.DataSource = dtStatus.dtStatus_sotr;
                cb1.ValueMember = "Ключ статуса сотрудника";
                cb1.DisplayMember = "Статус сотрудника";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void cbSotrFill(ComboBox cb1)
        {
            try
            {
                DataBase_Table_Instruction dtSotr = new DataBase_Table_Instruction();
                dtSotr.dtSotrFill();
                cb1.DataSource = dtSotr.dtSotr;
                cb1.ValueMember = "Ключ сотрудника";
                cb1.DisplayMember = "Имя сотрудника";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void cbStatus_instructionFill(ComboBox cb1)
        {
            try
            {
                DataBase_Table_Instruction dtStatus_instruction = new DataBase_Table_Instruction();
                dtStatus_instruction.dtStatus_instructionFill();
                cb1.DataSource = dtStatus_instruction.dtStatus_instruction;
                cb1.ValueMember = "Ключ статуса инструктажа";
                cb1.DisplayMember = "Статус инструктажа";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void cbInstructionFill(ComboBox cb1)
        {
            try
            {
                DataBase_Table_Instruction dtInstruction = new DataBase_Table_Instruction();
                dtInstruction.dtInstructionFill();
                cb1.DataSource = dtInstruction.dtInstruction;
                cb1.ValueMember = "Ключ инструктажа";
                cb1.DisplayMember = "Bнструктаж";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void cbRoleFill(ComboBox cb2)
        {
            try
            {
                DataBase_Table_Instruction dtRole = new DataBase_Table_Instruction();
                dtRole.dtRoleFill();
                cb2.DataSource = dtRole.dtRole;
                cb2.ValueMember = "Ключ Роли";
                cb2.DisplayMember = "Роль";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
    }
}

