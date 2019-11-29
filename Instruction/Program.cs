using System;
using System.Windows.Forms;

namespace Instruction
{
    static class Program
    {
        public static bool Avtoriz_user;
        public static bool access = false;
        public static Int32 Table_Avtoriz = 0, Table_History = 0, Table_Electronic_journal_of_instruction = 0, Table_Conduction_the_instruction = 0,
            Table_Sotr = 0, Table_Doljnost = 0, Table_Status_sotr = 0, Table_Status_instruction = 0, Table_Instruction = 0, Table_Role = 0;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Zastavka());
        }
    }
}
