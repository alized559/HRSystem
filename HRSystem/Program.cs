using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRSystem
{
    internal static class Program
    {
        internal static string connection;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SignUp());

            connection = "Data source=DESKTOP-KING'\'SQLEXPRESS;Initial Catalog=HRSystem;Integrated Security=true";
        }
    }
}
