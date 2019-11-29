using RegistryLibrary;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Instruction
{
    public partial class Role : Form
    {
        public Role()
        {
            InitializeComponent();
        }

        SqlCommand command = new SqlCommand("", RegistryClass.sqlConnection);
        MainForm mainForm = new MainForm();
        Int32 id_role, Table_Avtoriz, Table_History, Table_Electronic_jornal,Table_Conducrion_instruction, Table_Sotr, Table_Doljnosty,
              Table_Status_sotr, Table_Status_instruction, Table_Instruction, Table_role;

        private void dgvRole_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id_role = Convert.ToInt32(dgvRole.CurrentRow.Cells[0].Value.ToString());
                if (dgvRole.CurrentRow.Cells[2].Value.ToString() == "0") rbAvtoriz_0.Checked = true;
                else rbAvtoriz_1.Checked = true;
                if (dgvRole.CurrentRow.Cells[3].Value.ToString() == "0") rbHistory_0.Checked = true;
                else rbHistory_1.Checked = true;
                if (dgvRole.CurrentRow.Cells[4].Value.ToString() == "0") rbJornal_0.Checked = true;
                else rbJornal_1.Checked = true;
                if (dgvRole.CurrentRow.Cells[5].Value.ToString() == "0") rbConduction_0.Checked = true;
                else rbConduction_1.Checked = true;
                if (dgvRole.CurrentRow.Cells[6].Value.ToString() == "0") rbSotr_0.Checked = true;
                else rbSotr_1.Checked = true;
                if (dgvRole.CurrentRow.Cells[7].Value.ToString() == "0") rbDoljnost_0.Checked = true;
                else rbDoljnost_1.Checked = true;
                if (dgvRole.CurrentRow.Cells[8].Value.ToString() == "0") rbStatus_sotr_0.Checked = true;
                else rbStatus_sotr_1.Checked = true;
                if (dgvRole.CurrentRow.Cells[9].Value.ToString() == "0") rbStatus_Instruction_0.Checked = true;
                else rbStatus_Instruction_1.Checked = true;
                if (dgvRole.CurrentRow.Cells[10].Value.ToString() == "0") rbInstruction_0.Checked = true;
                else rbInstruction_1.Checked = true;
                if (dgvRole.CurrentRow.Cells[11].Value.ToString() == "0") rbRole_0.Checked = true;
                else rbRole_1.Checked = true;
                tbRoleName.Text = dgvRole.CurrentRow.Cells[1].Value.ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        DataBase_Procedure procedure = new DataBase_Procedure();
        private void btDelete_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Вы точно хотите удалить роль?", "Подтверждение удаления", MessageBoxButtons.YesNo))
            {
                case (DialogResult.Yes):

                    procedure.spRole_Delete(id_role);
                    Role_Load(sender, e);
                    break;
            }
        }

        private void proverka()
        {
            if (rbAvtoriz_0.Checked) Table_Avtoriz = 0;
            else Table_Avtoriz = 1;
            if (rbHistory_0.Checked) Table_History = 0;
            else Table_History = 1;
            if (rbJornal_0.Checked) Table_Electronic_jornal = 0;
            else Table_Electronic_jornal = 1;
            if (rbConduction_0.Checked) Table_Conducrion_instruction = 0;
            else Table_Conducrion_instruction = 1;
            if (rbSotr_0.Checked) Table_Sotr = 0;
            else Table_Sotr = 1;
            if (rbDoljnost_0.Checked) Table_Doljnosty = 0;
            else Table_Doljnosty = 1;
            if (rbStatus_sotr_0.Checked) Table_Status_sotr = 0;
            else Table_Status_sotr = 1;
            if (rbStatus_Instruction_0.Checked) Table_Status_instruction = 0;
            else Table_Status_instruction = 1;
            if (rbInstruction_0.Checked) Table_Instruction = 0;
            else Table_Instruction = 1;
            if (rbRole_0.Checked) Table_role = 0;
            else Table_role = 1;
        }


        private void btUpdate_Click(object sender, EventArgs e)
        {
            switch (tbRoleName.Text == "")
            {
                case (true):
                    MessageBox.Show("Введите имя роли!");
                    break;
                case (false):
                    try
                    {
                        switch (MessageBox.Show("Вы точно хотите изменить  Роль?", "Подтверждение изменения", MessageBoxButtons.YesNo))
                        {

                            case (DialogResult.Yes):
                                {
                                    proverka();
                                    procedure.spRole_Update(id_role, tbRoleName.Text, Table_Avtoriz, Table_History, Table_Electronic_jornal, Table_Conducrion_instruction, Table_Sotr,
                                        Table_Doljnosty, Table_Status_sotr, Table_Status_instruction, Table_Instruction, Table_role);
                                    Role_fill();
                                }
                                break;
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                    finally
                    {
                        tbRoleName.Clear();
                        Role_Load(sender, e);
                    }
                    break;
            }
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            switch (tbRoleName.Text == "")
            {
                case (true):
                    MessageBox.Show("Введите имя роли!");
                    break;
                case (false):
                    try
                    {
                        proverka();
                        procedure.spRole_Insert(tbRoleName.Text, Table_Avtoriz, Table_History, Table_Electronic_jornal, Table_Conducrion_instruction, Table_Sotr,
                            Table_Doljnosty, Table_Status_sotr, Table_Status_instruction, Table_Instruction, Table_role);
                        Role_fill();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }

        private void Role_Load(object sender, EventArgs e)
        {
            this.BringToFront();
            RegistryClass a = new RegistryClass();
            a.FormConfigurationGet();
            Color color = Color.FromName(RegistryClass.ColorFonText);
            BackColor = color;
            Role_fill();
        }

        public void Role_fill()
        {
            DataBase_Table_Instruction data = new DataBase_Table_Instruction();
            data.dtRoleFill();
            dgvRole.DataSource = data.dtRole;
            dgvRole.Columns[0].Visible = false;
        }
    }
}
