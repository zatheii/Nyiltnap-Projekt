using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointmentApp
{
    public partial class AdminPanel : Form
    {
        private const string ConnectionString = "Server=localhost;Database=appappdb;Uid=root; ";

        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            textBoxFoglalasId.TabIndex = 0;
            foglalastorl.TabIndex = 1;
            txtDoktorId.TabIndex = 2;
            txtDoktorNev.TabIndex = 3;
            txtSzakterulet.TabIndex = 4;
            doktorfelv.TabIndex = 5;

            LoadFoglalasok();
        }

        private void LoadFoglalasok()
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
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
            if (string.IsNullOrWhiteSpace(textBoxFoglalasId.Text))
            {
                MessageBox.Show("Kérlek, add meg a törlendő foglalás ID-ját!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBoxFoglalasId.Text, out int id))
            {
                MessageBox.Show("Az ID csak szám lehet!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();

                    string query = "DELETE FROM foglalas WHERE id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("A foglalás sikeresen törölve.", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBoxFoglalasId.Clear();
                            LoadFoglalasok(); 
                        }
                        else
                        {
                            MessageBox.Show("Nem található ilyen ID-jű foglalás.", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba a törlés során:\n" + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void doktorfelv_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDoktorId.Text) ||
                string.IsNullOrWhiteSpace(txtDoktorNev.Text) ||
                string.IsNullOrWhiteSpace(txtSzakterulet.Text))
            {
                MessageBox.Show("Kérlek, töltsd ki az összes mezőt!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtDoktorId.Text, out int id))
            {
                MessageBox.Show("A Doktor ID csak szám lehet!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nev = txtDoktorNev.Text.Trim();
            string szakterulet = txtSzakterulet.Text.Trim();

            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();

                    string query = "INSERT INTO doktor (id, nev, szakterulet) VALUES (@id, @nev, @szakterulet)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@nev", nev);
                        cmd.Parameters.AddWithValue("@szakterulet", szakterulet);

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("A doktor sikeresen hozzáadva!", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtDoktorId.Clear();
                            txtDoktorNev.Clear();
                            txtSzakterulet.Clear();
                        }
                        else
                        {
                            MessageBox.Show("A beszúrás nem sikerült.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Hiba történt az adatbázis művelet során:\n" + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ismeretlen hiba:\n" + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

