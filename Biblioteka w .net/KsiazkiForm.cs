using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using Biblioteka_w_Dotnet;

namespace Biblioteka_w_Dotnet
{
    public partial class KsiazkiForm : Form
    {
        Biblioteka biblioteka;
        public KsiazkiForm(Biblioteka biblioteka)
        {
            this.biblioteka = biblioteka;
            InitializeComponent();
        }

        

        // DataGridView Lista Książek
        private SQLiteDataAdapter DBKsiazki;
        private DataSet DSKsiazki = new DataSet();
        private DataTable DTKsiazki = new DataTable();

        // Czas z komputera
       DateTime lokalnaData = DateTime.UtcNow.ToLocalTime();

        //Połączenie z bazą danych
        SQLiteConnection sqliteCon = new SQLiteConnection("Data Source = ./DBbiblioteka.db;Version=3;New=False;Compress=True;");

        // Przycisk szukanie książek
        private void btnSzukaj_Click(object sender, EventArgs e)
        {
            try
            {
                
                sqliteCon.Open();
                String Query = 
                "SELECT* FROM Ksiazki WHERE kategoria || ' ' || tytul || ' ' || opis || ' ' || autor || ' ' || wydawnictwo || ' ' || rok_wydania LIKE'%" + this.txtBoxSzukaj.Text +
                                        "%' OR kategoria || ' ' || tytul || ' ' || opis || ' ' || autor || ' ' || rok_wydania || ' ' || wydawnictwo LIKE'%" + this.txtBoxSzukaj.Text +
                                        "%' OR kategoria || ' ' || tytul || ' ' || opis || ' ' || wydawnictwo || ' ' || autor || ' ' || rok_wydania LIKE'%" + this.txtBoxSzukaj.Text +
                                        "%' OR kategoria || ' ' || tytul || ' ' || opis || ' ' || wydawnictwo || ' ' || rok_wydania || ' ' || autor LIKE'%" + this.txtBoxSzukaj.Text +
                                        "%' OR kategoria || ' ' || tytul || ' ' || wydawnictwo || ' ' || opis || ' ' || autor || ' ' || rok_wydania LIKE'%" + this.txtBoxSzukaj.Text +
                                        "%' OR kategoria || ' ' || tytul || ' ' || wydawnictwo || ' ' || autor || ' ' || opis || ' ' || rok_wydania LIKE'%" + this.txtBoxSzukaj.Text +
                                        "%' OR kategoria || ' ' || tytul || ' ' || wydawnictwo || ' ' || rok_wydania || ' ' || autor || ' ' || opis LIKE'%" + this.txtBoxSzukaj.Text +
                                        "%' OR kategoria || ' ' || tytul || ' ' || wydawnictwo || ' ' || rok_wydania || ' ' || opis || ' ' || autor LIKE'%" + this.txtBoxSzukaj.Text +
                                        "%' OR kategoria || ' ' || autor || ' ' || opis || ' ' || rok_wydania || ' ' || wydawnictwo || ' ' || tytul LIKE'%" + this.txtBoxSzukaj.Text +
                                        "%' OR kategoria || ' ' || opis || ' ' || autor || ' ' || rok_wydania || ' ' || wydawnictwo || ' ' || tytul LIKE'%" + this.txtBoxSzukaj.Text +
                                        "%' OR kategoria || ' ' || wydawnictwo || ' ' || autor || ' ' || rok_wydania || ' ' || tytul || ' ' || opis LIKE'%" + this.txtBoxSzukaj.Text +
                                        "%' OR kategoria || ' ' || rok_wydania || ' ' || wydawnictwo || ' ' || autor || ' ' || opis || ' ' || tytul LIKE'%" + this.txtBoxSzukaj.Text + "%'";
                SQLiteCommand createCommand = new SQLiteCommand(Query, sqliteCon);
                DBKsiazki = new SQLiteDataAdapter(Query, sqliteCon);
                DSKsiazki.Clear();
                DBKsiazki.Fill(DSKsiazki);
                DTKsiazki = DSKsiazki.Tables[0];
                dgvKsiazki.DataSource = DTKsiazki;
                this.dgvKsiazki.Columns["id_ksiazka"].Visible = false;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Przycisk wypożyczenie książki
        private void btnWypozycz_Click(object sender, EventArgs e)
        {
            string dataWypozyczenia = lokalnaData.ToString();
            try
            {
             //   Biblioteka biblioteka = new Biblioteka();
                //biblioteka.dgvListaWypozyczajacych.SelectedRows[0].Cells["id_czytelnika"].Value.ToString();
                
        //   string checkUser = biblioteka.dgvListaWypozyczajacych.SelectedRows[0].Cells["id_czytelnika"].Value.ToString();

       // sqliteCon.Open();
                String Query = "INSERT INTO Wypozyczenia (id_czytelnik, id_ksiazka, data_wypozyczenia, data_oddania) VALUES " +
                               "('" + biblioteka.dgvListaWypozyczajacych.SelectedRows[0].Cells["id_czytelnik"].Value.ToString() + "', '" + dgvKsiazki.SelectedRows[0].Cells["id_ksiazka"].Value + "', '" + dataWypozyczenia +"' , 2019) ";
                SQLiteCommand createCommand = new SQLiteCommand(Query, sqliteCon);
                createCommand.ExecuteNonQuery();
                sqliteCon.Close(); 
                MessageBox.Show("Książka została wypożyczona");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Przycisk Wyjście
        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            KsiazkiForm.ActiveForm.Close();
        }
    }
}
