using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using RegistryLibrary;

namespace Instruction
{
    class DataBase_Configuration
    {
        public event Action<DataTable> dtServers;
        public event Action<DataTable> dtDatabases;
        public event Action<bool> conState;
        public string cds, cui, cpw;
        public static bool logCon;
        RegistryClass registry = new RegistryClass();


        public void Servers_get()
        {
            SqlDataSourceEnumerator sourceEnumerator
                = SqlDataSourceEnumerator.Instance;
            dtServers(sourceEnumerator.GetDataSources());
        }

        public void Databases_get()
        {
            SqlConnection sql = new SqlConnection("Data Source = " + cds +
                "; Initial Catalog = master; Persist Security Info = true; " +
                " User ID = " + cui + "; Password = \"" + cpw + "\"");
            try
            {
                SqlCommand command = new SqlCommand("select name from sys.databases " +
                    "where name not in ('master','tempdb','model','msdb')", sql);
                DataTable table = new DataTable();
                sql.Open();
                table.Load(command.ExecuteReader());
                dtDatabases(table);
            }
            catch (SqlException ex)
            {
                RegistryClass.error_message += "\n" + DateTime.Now.ToLongDateString()
                    + ex.Message;
            }
            finally
            {
                sql.Close();
            }
        }

        public void Connection_check()
        {
            registry.Registry_Get();
            try
            {
                RegistryClass.sqlConnection.Open();
                conState(true);
                logCon = true;
            }
            catch (Exception ex)
            {
                RegistryClass.error_message += "\n" + DateTime.Now.ToLongDateString()
                    + ex.Message;
                conState(false);
                logCon = false;
            }
            finally
            {
                RegistryClass.sqlConnection.Close();
            }
        }
    }
}
