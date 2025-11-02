using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointmentApp
{
    public partial class UserInterface : Form
    {
        private bool isDarkMode = false;
        private bool isEnglish = false;
        public UserInterface()
        {
            InitializeComponent();
        }

        private void DarkModeButton_Click(object sender, EventArgs e)
        {
            if (!isDarkMode)
            {
                this.BackColor = Color.FromArgb(30, 30, 30);
                this.ForeColor = Color.White;

                foreach (Control ctrl in this.Controls)
                {
                    ctrl.BackColor = Color.FromArgb(45, 45, 45);
                    ctrl.ForeColor = Color.White;

                }
            }
            else
            {
                this.BackColor = SystemColors.Control;
                this.ForeColor = Color.Black;

                foreach (Control ctrl in this.Controls)
                {
                    ctrl.BackColor = SystemColors.Control;
                    ctrl.ForeColor = Color.Black;
                }
            }

            isDarkMode = !isDarkMode;
        }

        private void NewAppointment_Click(object sender, EventArgs e)
        {
            var newAppointmentForm = new NewAppointment();
            newAppointmentForm.Show(); 
            this.Hide();

            
        }

        private void DeleteAppointment_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string connectionString = "Server=localhost;Database=appappdb;Uid=root; ";
            SqlConnection connection = new SqlConnection(connectionString);

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            f.id AS 'Foglalás ID',
                            u.nev AS 'Felhasználó neve',
                            d.nev AS 'Doktor neve',
                            d.szakterulet AS 'Szakterület',
                            f.idopont AS 'Időpont'
                        FROM appappdb.foglalas f
                        JOIN appappdb.felhasznalo u ON f.felh_taj_fk = u.taj
                        JOIN appappdb.doktor d ON f.doktor_id_fk = d.id
                        ORDER BY f.idopont;
                    ";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Nincs egyetlen foglalás sem az adatbázisban.", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    dataGridViewFoglalasok.DataSource = dt;
                    dataGridViewFoglalasok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nem sikerült betölteni a foglalásokat:\n" + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void LanguageChange_Click(object sender, EventArgs e)
        {
            if (isEnglish)
            {
                this.Text = "Időpont Foglaló";
                LanguageChange.Text = "Switch to English";
                DarkModeButton.Text = "Sötét mód";
                NewAppointment.Text = "Új időpont";
                isEnglish = !isEnglish;
                isEnglish = !isEnglish;
                return;
            }
            else 
            {
                this.Text = "Appointment Application";
                LanguageChange.Text = "Magyar nyelvre váltás";
                DarkModeButton.Text = "Dark mode";
                NewAppointment.Text = "New appointment";

            }


            isEnglish = !isEnglish;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewFoglalasok_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
