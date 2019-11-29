using System;
using System.Data.SqlClient;
using RegistryLibrary;


namespace Instruction
{
    class DataBase_Procedure
    {
        //Переменная для подключения к серверу
        public static SqlCommand command = new SqlCommand("", RegistryClass.sqlConnection);
        // Общая переменная
        private void spConfiguration(string spName)
        {
            command.CommandText = spName;
            command.CommandType = System.Data.CommandType.StoredProcedure;
        }

        private void Message(object sender, SqlInfoMessageEventArgs e)
        {
            RegistryClass.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + e.Message;
        }

        public void spInstruction_insert(string Vid_instruction, string Time_execution_the_instuction)
        {
            spConfiguration("Instruction_insert");
            try
            {
                command.Parameters.AddWithValue("@Vid_instruction", Vid_instruction);
                command.Parameters.AddWithValue("@Time_execution_the_instuction", Time_execution_the_instuction);
                RegistryClass.sqlConnection.Open();
                RegistryClass.sqlConnection.InfoMessage += Message;
                command.ExecuteNonQuery();
                command.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                RegistryClass.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {

                RegistryClass.sqlConnection.Close();
            }
        }

        public void spInstruction_Update(Int32 ID_Instruction, string Vid_instruction, string Time_execution_the_instuction)
        {
            spConfiguration("Instruction_Update");
            try
            {
                command.Parameters.AddWithValue("@ID_Instruction", ID_Instruction);
                command.Parameters.AddWithValue("@Vid_instruction", Vid_instruction);
                command.Parameters.AddWithValue("@Time_execution_the_instuction", Time_execution_the_instuction);
                RegistryClass.sqlConnection.Open();
                RegistryClass.sqlConnection.InfoMessage += Message;
                command.ExecuteNonQuery();
                command.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                RegistryClass.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                RegistryClass.sqlConnection.Close();
            }
        }

        public void spInstruction_Delete(Int32 ID_Instruction)
        {
            spConfiguration("Instruction_Delete");
            try
            {
                command.Parameters.AddWithValue("@ID_Instruction", ID_Instruction);
                RegistryClass.sqlConnection.Open();
                RegistryClass.sqlConnection.InfoMessage += Message;
                command.ExecuteNonQuery();
                command.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                RegistryClass.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                RegistryClass.sqlConnection.Close();
            }
        }

        public void spStatus_instruction_insert(string Status_instruction)
        {
            spConfiguration("Status_instruction_insert");
            try
            {
                command.Parameters.AddWithValue("@Status_instruction", Status_instruction);
                RegistryClass.sqlConnection.Open();
                RegistryClass.sqlConnection.InfoMessage += Message;
                command.ExecuteNonQuery();
                command.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                RegistryClass.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {

                RegistryClass.sqlConnection.Close();
            }
        }

        public void spStatus_instruction_Update(Int32 ID_Status_instruction, string Status_instruction)
        {
            spConfiguration("Status_instruction_Update");
            try
            {
                command.Parameters.AddWithValue("@ID_Status_instruction", ID_Status_instruction);
                command.Parameters.AddWithValue("@Status_instruction", Status_instruction);
                RegistryClass.sqlConnection.Open();
                RegistryClass.sqlConnection.InfoMessage += Message;
                command.ExecuteNonQuery();
                command.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                RegistryClass.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                RegistryClass.sqlConnection.Close();
            }
        }

        public void spStatus_instruction_Delete(Int32 ID_Status_instruction)
        {
            spConfiguration("Status_instruction_Delete");
            try
            {
                command.Parameters.AddWithValue("@ID_Status_instruction", ID_Status_instruction);
                RegistryClass.sqlConnection.Open();
                RegistryClass.sqlConnection.InfoMessage += Message;
                command.ExecuteNonQuery();
                command.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                RegistryClass.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                RegistryClass.sqlConnection.Close();
            }
        }

        public void spStatus_sotr_insert(string Status_sotr)
        {
            spConfiguration("Status_sotr_insert");
            try
            {
                command.Parameters.AddWithValue("@Status_sotr", Status_sotr);
                RegistryClass.sqlConnection.Open();
                RegistryClass.sqlConnection.InfoMessage += Message;
                command.ExecuteNonQuery();
                command.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                RegistryClass.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {

                RegistryClass.sqlConnection.Close();
            }
        }

        public void spStatus_sotr_Update(Int32 ID_Status_sotr, string Status_sotr)
        {
            spConfiguration("Status_sotr_Update");
            try
            {
                command.Parameters.AddWithValue("@ID_Status_sotr", ID_Status_sotr);
                command.Parameters.AddWithValue("@Status_sotr", Status_sotr);
                RegistryClass.sqlConnection.Open();
                RegistryClass.sqlConnection.InfoMessage += Message;
                command.ExecuteNonQuery();
                command.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                RegistryClass.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                RegistryClass.sqlConnection.Close();
            }
        }

        public void spStatus_sotr_Delete(Int32 ID_Status_sotr)
        {
            spConfiguration("Status_sotr_Delete");
            try
            {
                command.Parameters.AddWithValue("@ID_Status_sotr", ID_Status_sotr);
                RegistryClass.sqlConnection.Open();
                RegistryClass.sqlConnection.InfoMessage += Message;
                command.ExecuteNonQuery();
                command.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                RegistryClass.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                RegistryClass.sqlConnection.Close();
            }
        }

        public void spDoljnost_insert(string Doljnost)
        {
            spConfiguration("Doljnost_insert");
            try
            {
                command.Parameters.AddWithValue("@Doljnost", Doljnost);
                RegistryClass.sqlConnection.Open();
                RegistryClass.sqlConnection.InfoMessage += Message;
                command.ExecuteNonQuery();
                command.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                RegistryClass.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {

                RegistryClass.sqlConnection.Close();
            }
        }

        public void spDoljnost_Update(Int32 ID_Doljnost, string Doljnost)
        {
            spConfiguration("Doljnost_Update");
            try
            {
                command.Parameters.AddWithValue("@ID_Doljnost", ID_Doljnost);
                command.Parameters.AddWithValue("@Doljnost", Doljnost);
                RegistryClass.sqlConnection.Open();
                RegistryClass.sqlConnection.InfoMessage += Message;
                command.ExecuteNonQuery();
                command.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                RegistryClass.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                RegistryClass.sqlConnection.Close();
            }
        }

        public void spDoljnost_Delete(Int32 ID_Doljnost)
        {
            spConfiguration("Doljnost_Delete");
            try
            {
                command.Parameters.AddWithValue("@ID_Doljnost", ID_Doljnost);
                RegistryClass.sqlConnection.Open();
                RegistryClass.sqlConnection.InfoMessage += Message;
                command.ExecuteNonQuery();
                command.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                RegistryClass.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                RegistryClass.sqlConnection.Close();
            }
        }

        public void spSotr_insert(string Firstname_sotr, string Name_sotr, string Otchestvo_sotr,
            string Date_birthday, Int32 ID_Status_sotr, Int32 ID_Doljnost)
        {
            spConfiguration("Sotr_insert");
            try
            {
                command.Parameters.AddWithValue("@Firstname_sotr", Firstname_sotr);
                command.Parameters.AddWithValue("@Name_sotr", Name_sotr);
                command.Parameters.AddWithValue("@Otchestvo_sotr", Otchestvo_sotr);
                command.Parameters.AddWithValue("@Date_birthday", Date_birthday);
                command.Parameters.AddWithValue("@ID_Status_sotr", ID_Status_sotr);
                command.Parameters.AddWithValue("@ID_Doljnost", ID_Doljnost);
                RegistryClass.sqlConnection.Open();
                RegistryClass.sqlConnection.InfoMessage += Message;
                command.ExecuteNonQuery();
                command.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                RegistryClass.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {

                RegistryClass.sqlConnection.Close();
            }
        }

        public void spSotr_Update(Int32 id_Sotr, string Firstname_sotr, string Name_sotr, string Otchestvo_sotr,
            string Date_birthday, Int32 ID_Status_sotr, Int32 ID_Doljnost)
        {
            spConfiguration("Sotr_Update");
            try
            {
                command.Parameters.AddWithValue("@id_Sotr", id_Sotr);
                command.Parameters.AddWithValue("@Firstname_sotr", Firstname_sotr);
                command.Parameters.AddWithValue("@Name_sotr", Name_sotr);
                command.Parameters.AddWithValue("@Otchestvo_sotr", Otchestvo_sotr);
                command.Parameters.AddWithValue("@Date_birthday", Date_birthday);
                command.Parameters.AddWithValue("@ID_Status_sotr", ID_Status_sotr);
                command.Parameters.AddWithValue("@ID_Doljnost", ID_Doljnost);
                RegistryClass.sqlConnection.Open();
                RegistryClass.sqlConnection.InfoMessage += Message;
                command.ExecuteNonQuery();
                command.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                RegistryClass.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                RegistryClass.sqlConnection.Close();
            }
        }

        public void spSotr_Delete(Int32 ID_Sotr)
        {
            spConfiguration("Sotr_Delete");
            try
            {
                command.Parameters.AddWithValue("@ID_Sotr", ID_Sotr);
                RegistryClass.sqlConnection.Open();
                RegistryClass.sqlConnection.InfoMessage += Message;
                command.ExecuteNonQuery();
                command.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                RegistryClass.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                RegistryClass.sqlConnection.Close();
            }
        }

        public void spConduction_the_instruction_insert(Int32 ID_Sotr)
        {
            spConfiguration("Conduction_the_instruction_insert");
            try
            {
                command.Parameters.AddWithValue("@ID_Sotr", ID_Sotr);
                RegistryClass.sqlConnection.Open();
                RegistryClass.sqlConnection.InfoMessage += Message;
                command.ExecuteNonQuery();
                command.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                RegistryClass.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {

                RegistryClass.sqlConnection.Close();
            }
        }

        public void spConduction_the_instruction_Update(Int32 ID_Conduction_the_instruction, Int32 ID_Sotr)
        {
            spConfiguration("Conduction_the_instruction_Update");
            try
            {
                command.Parameters.AddWithValue("@ID_Conduction_the_instruction", ID_Conduction_the_instruction);
                command.Parameters.AddWithValue("@ID_Sotr", ID_Sotr);
                RegistryClass.sqlConnection.Open();
                RegistryClass.sqlConnection.InfoMessage += Message;
                command.ExecuteNonQuery();
                command.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                RegistryClass.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                RegistryClass.sqlConnection.Close();
            }
        }

        public void spConduction_the_instruction_Delete(Int32 ID_Conduction_the_instruction)
        {
            spConfiguration("Conduction_the_instruction_Delete");
            try
            {
                command.Parameters.AddWithValue("@ID_Conduction_the_instruction", ID_Conduction_the_instruction);
                RegistryClass.sqlConnection.Open();
                RegistryClass.sqlConnection.InfoMessage += Message;
                command.ExecuteNonQuery();
                command.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                RegistryClass.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                RegistryClass.sqlConnection.Close();
            }
        }

        public void spRole_Insert(string Name_role, Int32 Table_Avtoriz, Int32 Table_History, Int32 Table_Electronic_journal_of_instruction,
            Int32 Table_Conduction_the_instruction, Int32 Table_Sotr, Int32 Table_Doljnost, Int32 Table_Status_sotr, Int32 Table_Status_instruction,
            Int32 Table_Instruction, Int32 Table_Role)
        {
            spConfiguration("Role_Insert");
            try
            {
                command.Parameters.AddWithValue("@Name_role", Name_role);
                command.Parameters.AddWithValue("@Table_Avtoriz", Table_Avtoriz);
                command.Parameters.AddWithValue("@Table_History", Table_History);
                command.Parameters.AddWithValue("@Table_Electronic_journal_of_instruction", Table_Electronic_journal_of_instruction);
                command.Parameters.AddWithValue("@Table_Conduction_the_instruction", Table_Conduction_the_instruction);
                command.Parameters.AddWithValue("@Table_Sotr", Table_Sotr);
                command.Parameters.AddWithValue("@Table_Doljnost", Table_Doljnost);
                command.Parameters.AddWithValue("@Table_Status_sotr", Table_Status_sotr);
                command.Parameters.AddWithValue("@Table_Status_instruction", Table_Status_instruction);
                command.Parameters.AddWithValue("@Table_Instruction", Table_Instruction);
                command.Parameters.AddWithValue("@Table_Role", Table_Role);
                RegistryClass.sqlConnection.Open();
                RegistryClass.sqlConnection.InfoMessage += Message;
                command.ExecuteNonQuery();
                command.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                RegistryClass.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {

                RegistryClass.sqlConnection.Close();
            }
        }

        public void spRole_Update(Int32 ID_Role, string Name_role, Int32 Table_Avtoriz, Int32 Table_History, Int32 Table_Electronic_journal_of_instruction,
            Int32 Table_Conduction_the_instruction, Int32 Table_Sotr, Int32 Table_Doljnost, Int32 Table_Status_sotr, Int32 Table_Status_instruction,
            Int32 Table_Instruction, Int32 Table_role)
        {
            spConfiguration("Role_Update");
            try
            {
                command.Parameters.AddWithValue("@ID_Role", ID_Role);
                command.Parameters.AddWithValue("@Name_role", Name_role);
                command.Parameters.AddWithValue("@Table_Avtoriz", Table_Avtoriz);
                command.Parameters.AddWithValue("@Table_History", Table_History);
                command.Parameters.AddWithValue("@Table_Electronic_journal_of_instruction", Table_Electronic_journal_of_instruction);
                command.Parameters.AddWithValue("@Table_Conduction_the_instruction", Table_Conduction_the_instruction);
                command.Parameters.AddWithValue("@Table_Sotr", Table_Sotr);
                command.Parameters.AddWithValue("@Table_Doljnost", Table_Doljnost);
                command.Parameters.AddWithValue("@Table_Status_sotr", Table_Status_sotr);
                command.Parameters.AddWithValue("@Table_Status_instruction", Table_Status_instruction);
                command.Parameters.AddWithValue("@Table_Instruction", Table_Instruction);
                command.Parameters.AddWithValue("@Table_Role", Table_role);
                RegistryClass.sqlConnection.Open();
                RegistryClass.sqlConnection.InfoMessage += Message;
                command.ExecuteNonQuery();
                command.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                RegistryClass.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                RegistryClass.sqlConnection.Close();
            }
        }

        public void spRole_Delete(Int32 ID_Role)
        {
            spConfiguration("Role_Delete");
            try
            {
                command.Parameters.AddWithValue("@ID_Role", ID_Role);
                RegistryClass.sqlConnection.Open();
                RegistryClass.sqlConnection.InfoMessage += Message;
                command.ExecuteNonQuery();
                command.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                RegistryClass.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                RegistryClass.sqlConnection.Close();
            }
        }

        public void spElectronic_journal_of_instruction_insert(string Date_of_instruction, Int32 ID_Instruction, Int32 ID_Status_instruction, Int32 ID_Sotr,
    Int32 ID_Conduction_the_instruction)
        {
            spConfiguration("Electronic_journal_of_instruction_insert");
            try
            {
                command.Parameters.AddWithValue("@Date_of_instruction", Date_of_instruction);
                command.Parameters.AddWithValue("@ID_Instruction", ID_Instruction);
                command.Parameters.AddWithValue("@ID_Status_instruction", ID_Status_instruction);
                command.Parameters.AddWithValue("@ID_Sotr", ID_Sotr);
                command.Parameters.AddWithValue("@ID_Conduction_the_instruction", ID_Conduction_the_instruction);
                RegistryClass.sqlConnection.Open();
                RegistryClass.sqlConnection.InfoMessage += Message;
                command.ExecuteNonQuery();
                command.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                RegistryClass.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {

                RegistryClass.sqlConnection.Close();
            }
        }

        public void spElectronic_journal_of_instruction_Update(Int32 ID_Electronic_journal_of_instruction, string Date_of_instruction, Int32 ID_Instruction, Int32 ID_Status_instruction, Int32 ID_Sotr,
    Int32 ID_Conduction_the_instruction)
        {
            spConfiguration("Electronic_journal_of_instruction_Update");
            try
            {
                command.Parameters.AddWithValue("@ID_Electronic_journal_of_instruction", ID_Electronic_journal_of_instruction);
                command.Parameters.AddWithValue("@Date_of_instruction", Date_of_instruction);
                command.Parameters.AddWithValue("@ID_Instruction", ID_Instruction);
                command.Parameters.AddWithValue("@ID_Status_instruction", ID_Status_instruction);
                command.Parameters.AddWithValue("@ID_Sotr", ID_Sotr);
                command.Parameters.AddWithValue("@ID_Conduction_the_instruction", ID_Conduction_the_instruction);
                RegistryClass.sqlConnection.Open();
                RegistryClass.sqlConnection.InfoMessage += Message;
                command.ExecuteNonQuery();
                command.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                RegistryClass.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                RegistryClass.sqlConnection.Close();
            }
        }

        public void spElectronic_journal_of_instruction_Delete(Int32 ID_Electronic_journal_of_instruction)
        {
            spConfiguration("Electronic_journal_of_instruction_Delete");
            try
            {
                command.Parameters.AddWithValue("@ID_Electronic_journal_of_instruction", ID_Electronic_journal_of_instruction);
                RegistryClass.sqlConnection.Open();
                RegistryClass.sqlConnection.InfoMessage += Message;
                command.ExecuteNonQuery();
                command.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                RegistryClass.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                RegistryClass.sqlConnection.Close();
            }
        }

        public void spAvtoriz_Insert(string Login, string Password, Int32 ID_Sotr, Int32 ID_Role)
        {
            spConfiguration("Avtoriz_insert");
            try
            {
                command.Parameters.AddWithValue("@Login", Login);
                command.Parameters.AddWithValue("@Password", Password);
                command.Parameters.AddWithValue("@ID_Sotr", ID_Sotr);
                command.Parameters.AddWithValue("@ID_Role", ID_Role);
                RegistryClass.sqlConnection.Open();
                RegistryClass.sqlConnection.InfoMessage += Message;
                command.ExecuteNonQuery();
                command.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                RegistryClass.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {

                RegistryClass.sqlConnection.Close();
            }
        }

        public void spAvtoriz_Update(Int32 ID_Avtoriz, string Login, string Password, Int32 ID_Sotr, Int32 ID_Role)
        {
            spConfiguration("Avtoriz_Update");
            try
            {
                command.Parameters.AddWithValue("@ID_Avtoriz", ID_Avtoriz);
                command.Parameters.AddWithValue("@Login", Login);
                command.Parameters.AddWithValue("@Password", Password);
                command.Parameters.AddWithValue("@ID_Sotr", ID_Sotr);
                command.Parameters.AddWithValue("@ID_Role", ID_Role);
                RegistryClass.sqlConnection.Open();
                RegistryClass.sqlConnection.InfoMessage += Message;
                command.ExecuteNonQuery();
                command.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                RegistryClass.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                RegistryClass.sqlConnection.Close();
            }
        }

        public void spAvtoriz_Delete(Int32 ID_Avtoriz)
        {
            spConfiguration("Avtoriz_Delete");
            try
            {
                command.Parameters.AddWithValue("@ID_Avtoriz", ID_Avtoriz);
                RegistryClass.sqlConnection.Open();
                RegistryClass.sqlConnection.InfoMessage += Message;
                command.ExecuteNonQuery();
                command.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                RegistryClass.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                RegistryClass.sqlConnection.Close();
            }
        }

        public void spHistory_clear()
        {
            spConfiguration("History_clear");
            try
            {
                RegistryClass.sqlConnection.Open();
                command.ExecuteNonQuery();
                command.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                RegistryClass.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                RegistryClass.sqlConnection.Close();
            }
        }


    }
}
  

