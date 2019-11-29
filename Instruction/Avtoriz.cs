using RegistryLibrary;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Instruction
{
    class Avtoriz
    {
        
    public Int32 id_role;

        SqlCommand command = new SqlCommand("", RegistryClass.sqlConnection);
        public void Authoriz(TextBox TblLogin, TextBox TblPassword)
        {
            try
            {
                RegistryClass.sqlConnection.Close();
                command.CommandText = "Select id_Role " +
                    "from Avtoriz " +
                    "where (Login = '" + TblLogin.Text + "') " +
                    "and (Password = '" + TblPassword.Text + "')";
                RegistryClass.sqlConnection.Open();
                id_role = Convert.ToInt32(command.ExecuteScalar().ToString());

                RegistryClass.sqlConnection.Close();
                //если нет в отделе кадров
                switch (id_role)
                {
                    case (0):
                        {
                            MessageBox.Show("Данного пользователя нет в системе!");
                        }
                        break;

                    default:
                        {
                            check_access_user();
                            Program.Avtoriz_user = true;
                            MainForm mainForm = new MainForm();
                            mainForm.Visible_menu();

                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                
            }
        

        private void check_access_user()
        {
            RegistryClass.sqlConnection.Close();
            RegistryClass.sqlConnection.Open();
            check_access("Table_Avtoriz");
            Program.Table_Avtoriz =
            Convert.ToInt32(command.ExecuteScalar().ToString());

            check_access("Table_History");
            Program.Table_History =
            Convert.ToInt32(command.ExecuteScalar().ToString());

            check_access("Table_Electronic_journal_of_instruction");
            Program.Table_Electronic_journal_of_instruction =
            Convert.ToInt32(command.ExecuteScalar().ToString());

            check_access("Table_Conduction_the_instruction");
            Program.Table_Conduction_the_instruction =
            Convert.ToInt32(command.ExecuteScalar().ToString());

            check_access("Table_Sotr");
            Program.Table_Sotr =
            Convert.ToInt32(command.ExecuteScalar().ToString());

            check_access("Table_Doljnost");
            Program.Table_Doljnost =
            Convert.ToInt32(command.ExecuteScalar().ToString());

            check_access("Table_Status_sotr");
            Program.Table_Status_sotr =
            Convert.ToInt32(command.ExecuteScalar().ToString());

            check_access("Table_Status_instruction");
            Program.Table_Status_instruction =
            Convert.ToInt32(command.ExecuteScalar().ToString());

            check_access("Table_Instruction");
            Program.Table_Instruction =
            Convert.ToInt32(command.ExecuteScalar().ToString());


            check_access("Table_Role");
            Program.Table_Role =
            Convert.ToInt32(command.ExecuteScalar().ToString());

            RegistryClass.sqlConnection.Close();

        }

        private void check_access(string table)
        {
            command.CommandText = "select Role." + table + " " +
       "from Role where id_role=" + id_role;
           
        }

    }
}

        
