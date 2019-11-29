using System;
using System.Windows.Forms;
using RegistryLibrary;
using System.Data.SqlClient;

namespace Instruction
{
    class TableLoad
    {
        SqlCommand command = new SqlCommand("", RegistryClass.sqlConnection);
        DataBase_Procedure procedure = new DataBase_Procedure();
        public void dgvHistoryFill(DataGridView dgv)
        {
            try
            {
                DataBase_Table_Instruction dtHistory = new DataBase_Table_Instruction();
                dtHistory.dtHistoryFill();
                dgv.DataSource = dtHistory.dtHistory;

                dgv.Columns[0].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void dgvInstructionFill(DataGridView dgv)
        {
            try
            {
                DataBase_Table_Instruction dtInstruction = new DataBase_Table_Instruction();
                dtInstruction.dtInstructionFill();
                dgv.DataSource = dtInstruction.dtInstruction;

                dgv.Columns[0].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void dgvAvtoriz(DataGridView dgv)
        {
            try
            {
                DataBase_Table_Instruction dtAvtoriz = new DataBase_Table_Instruction();
                dtAvtoriz.dtAvtorizFill();
                dgv.DataSource = dtAvtoriz.dtAvtoriz;

                dgv.Columns[0].Visible = false;
                dgv.Columns[3].Visible = false;
                dgv.Columns[7].Visible = false;
                dgv.Columns[9].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void dgvRole(DataGridView dgv)
        {
            try
            {
                DataBase_Table_Instruction dtRole = new DataBase_Table_Instruction();
                dtRole.dtRoleFill();
                dgv.DataSource = dtRole.dtRole;

                dgv.Columns[0].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void dgvSotr (DataGridView dgv)
        {
            try
            {
                DataBase_Table_Instruction dtSotr = new DataBase_Table_Instruction();
                dtSotr.dtSotrFill();
                dgv.DataSource = dtSotr.dtSotr;

                dgv.Columns[0].Visible = false;
                dgv.Columns[5].Visible = false;
                dgv.Columns[7].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void dgvDoljnost(DataGridView dgv)
        {
            try
            {
                DataBase_Table_Instruction dtDoljnost = new DataBase_Table_Instruction();
                dtDoljnost.dtDoljnostFill();
                dgv.DataSource = dtDoljnost.dtDoljnost;

                dgv.Columns[0].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void dgvStatus_sotr (DataGridView dgv)
        {
            try
            {
                DataBase_Table_Instruction dtStatus_sotr = new DataBase_Table_Instruction();
                dtStatus_sotr.dtStatus_sotrFill();
                dgv.DataSource = dtStatus_sotr.dtStatus_sotr;

                dgv.Columns[0].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void dgvStatus_instruction (DataGridView dgv)
        {
            try
            {
                DataBase_Table_Instruction dtStatus_instruction = new DataBase_Table_Instruction();
                dtStatus_instruction.dtStatus_instructionFill();
                dgv.DataSource = dtStatus_instruction.dtStatus_instruction;

                dgv.Columns[0].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void dgvConduction_the_instruction (DataGridView dgv)
        {
            try
            {
                DataBase_Table_Instruction dtConduction_the_instruction = new DataBase_Table_Instruction();
                dtConduction_the_instruction.dtConduction_the_instructionFill();
                dgv.DataSource = dtConduction_the_instruction.dtConduction_the_instruction;

                dgv.Columns[0].Visible = false;
                dgv.Columns[1].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void dgvElectronic_journal_of_instruction (DataGridView dgv)
        {
            try
            {
                DataBase_Table_Instruction dtElectronic_journal_of_instruction = new DataBase_Table_Instruction();
                dtElectronic_journal_of_instruction.dtElectronic_journal_of_instructionFill();
                dgv.DataSource = dtElectronic_journal_of_instruction.dtElectronic_journal_of_instruction;

                dgv.Columns[0].Visible = false;
                dgv.Columns[2].Visible = false;
                dgv.Columns[5].Visible = false;
                dgv.Columns[7].Visible = false;
                dgv.Columns[11].Visible = false;
                dgv.Columns[12].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
