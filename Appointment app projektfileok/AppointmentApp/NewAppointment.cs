using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointmentApp
{
    public partial class NewAppointment : Form
    {

        public NewAppointment()
        {
            InitializeComponent();
            string connectionString = "Server=SERVER_NEVE;Database=appappdb;Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(connectionString);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void NewAppointment_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=appappdb;Uid=root; ";
            string query = "SELECT * FROM doktor";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }


        private void newappointmentbutton_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=appappdb;Uid=root;";

            string neve = nev.Text.Trim();
            string tajs = taj.Text.Trim();
            string idopontText = datum.Text.Trim();
            string doktorText = doktorid.Text.Trim();

            if (neve == "" || tajs == "" || idopontText == "" || doktorText == "")
            {
                MessageBox.Show("Minden mezőt ki kell tölteni!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!long.TryParse(tajs, out _) || tajs.Length != 9)
            {
                MessageBox.Show("A TAJ-számnak pontosan 9 számjegynek kell lennie!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(doktorText, out int doktorId))
            {
                MessageBox.Show("A doktor azonosító csak szám lehet!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!DateTime.TryParseExact(idopontText, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime idopont))
            {
                MessageBox.Show("Hibás dátumformátum! Használd: ÉÉÉÉ-HH-NN ÓÓ:PP:MM", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string checkSql = "SELECT COUNT(*) FROM felhasznalo WHERE taj = @taj";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkSql, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@taj", tajs);
                        long count = (long)checkCmd.ExecuteScalar();

                        if (count == 0)
                        {
                            string insertUserSql = "INSERT INTO felhasznalo (taj, nev) VALUES (@taj, @nev)";
                            using (MySqlCommand insertUserCmd = new MySqlCommand(insertUserSql, conn))
                            {
                                insertUserCmd.Parameters.AddWithValue("@taj", tajs);
                                insertUserCmd.Parameters.AddWithValue("@nev", neve);
                                insertUserCmd.ExecuteNonQuery();
                            }
                        }
                    }

                    string insertFoglalasSql = "INSERT INTO foglalas (felh_taj_fk, doktor_id_fk, idopont) VALUES (@taj, @doktor, @idopont)";
                    using (MySqlCommand cmd = new MySqlCommand(insertFoglalasSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@taj", tajs);
                        cmd.Parameters.AddWithValue("@doktor", doktorId);
                        cmd.Parameters.AddWithValue("@idopont", idopont);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Foglalás sikeresen hozzáadva!", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    UserInterface mainForm = new UserInterface();
                    mainForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba történt az adatbázis művelet során:\n" + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
