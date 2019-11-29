using System;
using System.Data;
using System.Data.SqlClient;
using RegistryLibrary;

namespace Instruction
{
    class DataBase_Table_Instruction
    {
        //подключение к базе
        public SqlCommand command = new SqlCommand("", RegistryClass.sqlConnection);      
        //создание переменные для обращения к таблицам
        public DataTable dtAvtoriz = new DataTable("Avtoriz");
        public DataTable dtConduction_the_instruction = new DataTable("Conduction_the_instruction");
        public DataTable dtDoljnost = new DataTable("Doljnost");
        public DataTable dtElectronic_journal_of_instruction = new DataTable("Electronic_journal_of_instruction");
        public DataTable dtHistory = new DataTable("History");
        public DataTable dtInstruction = new DataTable("Instruction");
        public DataTable dtSotr = new DataTable("Sotr");
        public DataTable dtStatus_instruction = new DataTable("Status_instruction");
        public DataTable dtStatus_sotr = new DataTable("Status_sotr");
        public DataTable dtRole = new DataTable("Role");
        //Представляет зависимость уведомления запроса между приложением и экземпляром SQL Server
        public SqlDependency dependency = new SqlDependency();

        public string qrAvtoriz = "select * from View_Avtoriz",
            qrConduction_the_instruction = "select * from View_Conduction_the_instructio",
            qrDoljnost = "select * from View_Doljnost",
            qrElectronic_journal_of_instruction = "select * from View_Electronic_journal_of_instruction",
            qrHistory = "select * from View_History",
            qrInstruction = "select * from View_Instruction",
            qrRole = "select * from View_Role",
            qrSotr = "select * from View_Sotr",
            qrStatus_instruction = "select * from View_Status_instruction",
            qrStatus_sotr = "select * from View_Status_sotr";

        public void dtFill(DataTable table, string query)
        {
            try
            {
                command.Notification = null;
                command.CommandText = query;
                RegistryClass.sqlConnection.Open();

                table.Load(command.ExecuteReader());
            }
            catch (Exception ex)
            {
                RegistryClass.error_message += "\n"
                    + DateTime.Now.ToLongDateString() + ex.Message;
            }
            finally
            {
                RegistryClass.sqlConnection.Close();

            }

        }

        public void dtAvtorizFill()
        {
            dtFill(dtAvtoriz, qrAvtoriz);
        }

        public void dtConduction_the_instructionFill()
        {
            dtFill(dtConduction_the_instruction, qrConduction_the_instruction);
        }

        public void dtDoljnostFill()
        {
            dtFill(dtDoljnost, qrDoljnost);
        }

        public void dtElectronic_journal_of_instructionFill()
        {
            dtFill(dtElectronic_journal_of_instruction, qrElectronic_journal_of_instruction);
        }

        public void dtHistoryFill()
        {
            dtFill(dtHistory, qrHistory);
        }

        public void dtInstructionFill()
        {
            dtFill(dtInstruction, qrInstruction);
        }

        public void dtSotrFill()
        {
            dtFill(dtSotr, qrSotr);
        }

        public void dtStatus_instructionFill()
        {
            dtFill(dtStatus_instruction, qrStatus_instruction);
        }

        public void dtStatus_sotrFill()
        {
            dtFill(dtStatus_sotr, qrStatus_sotr);
        }

        public void dtRoleFill()
        {
            dtFill(dtRole, qrRole);
        }
    }
}
