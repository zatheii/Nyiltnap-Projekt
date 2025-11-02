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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
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

                    dataGridViewFoglalasokad.DataSource = dt;
                    dataGridViewFoglalasokad.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nem sikerült betölteni a foglalásokat:\n" + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void foglalastorl_Click(object sender, EventArgs e)
        {
            string foglalasId = textBoxFoglalasId.Text.Trim();

            if (string.IsNullOrEmpty(foglalasId))
            {
                MessageBox.Show("Kérlek, add meg a foglalás ID-t!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                string connectionString = "Server=localhost;Database=appappdb;Uid=root; ";


                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "DELETE FROM foglalasok WHERE id = @id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("A foglalás sikeresen törölve.", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Nem található ilyen ID-jű foglalás.", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt a törlés közben: " + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            textBoxFoglalasId.Clear();
        }
    }
}

