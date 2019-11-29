using RegistryLibrary;
using System;
using System.Data;
using excel = Microsoft.Office.Interop.Excel;

namespace Instruction
{
    class Excel
    {
        public string Group_name = "";
        public DataTable dtDiscipline = new DataTable();
        public DataTable dtStudents = new DataTable();
        
      public void Creet_excel()
        {
            string name = RegistryClass.DirPath + Group_name + "Электронный журнал"
                + DateTime.Now.ToString("_dd_MM_yyyy") + ".xlsx";
        excel.Application application = new excel.Application();
        excel.Workbook workbook = application.Workbooks.Add();
        excel.Worksheet worksheet =
           (excel.Worksheet)workbook.ActiveSheet;
            RegistryClass a = new RegistryClass();
            a.ConfigurationGet();
            try
            {
                    worksheet.Cells[1, 4] = "№ПП";
                    worksheet.Cells[2, 4] = "Электронный журнал инструктажа";


            }
            catch (Exception ex)
            {
                RegistryClass.error_message += "\n"
                   + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
              workbook.SaveAs(name, application.DefaultSaveFormat);
              workbook.Close();
              application.Quit();
            }
        }
    }
}
