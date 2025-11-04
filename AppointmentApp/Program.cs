using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AppointmentApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string connStr = "server=localhost;user=root;database=appappdb;";

            var result = MessageBox.Show("Admin módban szeretnéd elindítani?", "Nézet" ,MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Run(new Login());
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    Console.WriteLine("Kapcsolódva az adatbázishoz...");
                }
            }
            else 
            {
                Application.Run(new UserInterface());
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    Console.WriteLine("Kapcsolódva az adatbázishoz...");
                }
            }
        }
    }
}
