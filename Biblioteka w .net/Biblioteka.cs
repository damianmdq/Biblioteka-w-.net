using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using Biblioteka_w_Dotnet;

namespace Biblioteka_w_Dotnet
{
    public partial class Biblioteka : Form
    {
        public Biblioteka()
        {
            InitializeComponent();
        }

        //    Thread th;  // Threading

        //Otwieranie nowego formularza Biblioteka
        //     private void openNewForm(object obj)
        //     {
        //         Application.Run(new KsiazkiForm());
        //     }

        public SQLiteConnection db_connect = new SQLiteConnection("Data Source = ./DBbiblioteka.db;Version=3;New=False;Compress=True;");         //zmienna przechowująca obiekt bazy danych
        public string db_querry = null;             //zmienna przechowująca zapytanie do bazy danych
        public string db_querry2 = null;
        public SQLiteCommand db_command;            //zmienna przechowująca obiekt do wysyłania zapytań
        public SQLiteDataReader db_read;            //zmienna przechowująca odebrane informacje zwrócone dla zapytania doczytującego

        // DataGridView Lista Wypożyczających
        private SQLiteDataAdapter DBListaWypozyczajacych;
        private DataSet DSListaWypozyczajacych = new DataSet();
        private DataTable DTListaWypozyczajacych = new DataTable();

        // DataGridView Lista Wypożyczeń
        private SQLiteDataAdapter DBListaWypozyczen;
        private DataSet DSListaWypozyczen = new DataSet();
        private DataTable DTListaWypozyczen = new DataTable();

        // DataGridView Lista Książek
        private SQLiteDataAdapter DBKsiazki;
        private DataSet DSKsiazki = new DataSet();
        private DataTable DTKsiazki = new DataTable();

        // Czas z komputera
        DateTime lokalnaDatata = DateTime.UtcNow.ToLocalTime();


        

        public void btnSzukaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (db_connect != null && db_connect.State == ConnectionState.Closed) { db_connect.Open(); }
                    String db_querry = "SELECT * FROM Czytelnicy WHERE imie || ' ' || nazwisko || ' ' || miasto LIKE'%" + this.txtBoxDane.Text + 
                                                            "%' OR imie || ' ' || miasto || ' ' || nazwisko LIKE'%" + this.txtBoxDane.Text + 
                                                            "%' OR nazwisko || ' ' || imie || ' ' || miasto LIKE'%" + this.txtBoxDane.Text +
                                                            "%' OR nazwisko || ' ' || miasto || ' ' || imie LIKE'%" + this.txtBoxDane.Text +
                                                            "%' OR miasto || ' ' || imie || ' ' || nazwisko LIKE'%" + this.txtBoxDane.Text +
                                                            "%' OR miasto || ' ' || nazwisko || ' ' || imie LIKE'%" + this.txtBoxDane.Text + "%'";
                    DBListaWypozyczajacych = new SQLiteDataAdapter(db_querry, db_connect);
                    DSListaWypozyczajacych.Clear();
                    DBListaWypozyczajacych.Fill(DSListaWypozyczajacych);
                    DTListaWypozyczajacych = DSListaWypozyczajacych.Tables[0];
                    dgvListaWypozyczajacych.DataSource = DTListaWypozyczajacych;
                    this.dgvListaWypozyczajacych.Columns["id_czytelnik"].Visible = false;             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Dodawanie czytelnika
        private void btnDodajOsobe_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (db_connect != null && db_connect.State == ConnectionState.Closed) { db_connect.Open(); }
                String db_querry = "INSERT INTO Czytelnicy (imie, nazwisko, miasto) VALUES ('" + this.txtBoxImie.Text + "', '" + this.txtBoxNazwisko.Text + "', '" + this.txtBoxMiejscowosc.Text + "') ";
                SQLiteCommand createCommand = new SQLiteCommand(db_querry, db_connect);
                createCommand.ExecuteNonQuery();
                db_connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Edytowanie czytelnika
        private void btnEdytujOsobe_Click(object sender, EventArgs e)
        {
            try
            {
                if (db_connect != null && db_connect.State == ConnectionState.Closed) { db_connect.Open(); }
                String db_querry = "UPDATE Czytelnicy SET imie = '" + this.txtBoxImie.Text + 
                                "', nazwisko = '" + this.txtBoxNazwisko.Text +
                                "', miasto = '" + this.txtBoxMiejscowosc.Text +
                                "' WHERE id_czytelnik = '" + this.dgvListaWypozyczajacych.SelectedRows[0].Cells["id_czytelnik"].Value.ToString() + "'";
                SQLiteCommand createCommand = new SQLiteCommand(db_querry, db_connect);
                createCommand.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Usuwanie czytelnika
        private void btnUsunOsobe_Click(object sender, EventArgs e)
        {
            try
            {
                if (db_connect != null && db_connect.State == ConnectionState.Closed) { db_connect.Open(); }
                String db_querry = "DELETE FROM " +
                    "           Czytelnicy " +
                    "           WHERE Czytelnicy.id_czytelnik = '" +
                                this.dgvListaWypozyczajacych.SelectedRows[0].Cells["id_czytelnik"].Value.ToString() + 
                                "' AND Wypozyczenia.id_czytelnik = '" +
                                this.dgvListaWypozyczajacych.SelectedRows[0].Cells["id_czytelnik"].Value.ToString() + "'";
                SQLiteCommand createCommand = new SQLiteCommand(db_querry, db_connect);
                createCommand.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void dgvListaWypozyczajacych_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         //   if (dgvListaWypozyczajacych.SelectedRows.Count > 0)
         //   {
                txtBoxImie.Text = dgvListaWypozyczajacych.SelectedRows[0].Cells["imie"].Value.ToString();
                txtBoxNazwisko.Text = dgvListaWypozyczajacych.SelectedRows[0].Cells["nazwisko"].Value.ToString();
                txtBoxMiejscowosc.Text = dgvListaWypozyczajacych.SelectedRows[0].Cells["miasto"].Value.ToString();

                try
                {         
                    String Query = "SELECT " +
                        "           Ksiazki.kategoria, Ksiazki.tytul, Ksiazki.opis, Ksiazki.autor " +
                        "           FROM " +
                        "           Ksiazki, Wypozyczenia, Czytelnicy " +
                        "           WHERE '" + this.dgvListaWypozyczajacych.SelectedRows[0].Cells["id_czytelnik"].Value.ToString() + 
                                    "' = Czytelnicy.id_czytelnik " +
                                    "AND " +
                                    "Czytelnicy.id_czytelnik = Wypozyczenia.id_czytelnik AND Wypozyczenia.id_ksiazka = Ksiazki.id_ksiazka";
                    SQLiteCommand createCommand = new SQLiteCommand(Query, db_connect);
                    DBListaWypozyczen = new SQLiteDataAdapter(Query, db_connect);
                    DSListaWypozyczen.Reset();
                    DBListaWypozyczen.Fill(DSListaWypozyczen);
                    DTListaWypozyczen = DSListaWypozyczen.Tables[0];
                    dgvKsiazkiWypozyczone.DataSource = DTListaWypozyczen;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        //    }

        }
       

        
        public void dgvKsiazkiWypozyczone_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnListaKsiazek_Click(object sender, EventArgs e)
        {
            KsiazkiForm ksiazkiForm = new KsiazkiForm(this);
            ksiazkiForm.Owner = this;
            ksiazkiForm.ShowDialog();

            //    th = new Thread(openNewForm);
            //    th.SetApartmentState(ApartmentState.STA);
            //    th.Start();

        }

        private void txtBoxDane_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtBoxDane.Text == "Wprowadź imię, nazwisko lub miejscowość")
            {
                txtBoxDane.Text = string.Empty;
                txtBoxDane.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtBoxSzukajKsiazki_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtBoxSzukajKsiazki.Text == "Wprowadź dane ksiązki, którą chcesz wyszukać")
            {
                txtBoxSzukajKsiazki.Text = string.Empty;
                txtBoxSzukajKsiazki.ForeColor = SystemColors.WindowText;
            }
        }

        /// ///////////// Button Szukaj Ksiażki ///////////////////
        private void btnSzukajKsiazki_Click(object sender, EventArgs e)
        {
            try
            {
                if (db_connect != null && db_connect.State == ConnectionState.Closed) { db_connect.Open(); }
                String Query =
                "SELECT * FROM Ksiazki WHERE kategoria || ' ' || tytul || ' ' || opis || ' ' || autor || ' ' || wydawnictwo || ' ' || rok_wydania LIKE'%" + this.txtBoxSzukajKsiazki.Text +
                                        "%' OR kategoria || ' ' || tytul || ' ' || opis || ' ' || autor || ' ' || rok_wydania || ' ' || wydawnictwo LIKE'%" + this.txtBoxSzukajKsiazki.Text +
                                        "%' OR kategoria || ' ' || tytul || ' ' || opis || ' ' || wydawnictwo || ' ' || autor || ' ' || rok_wydania LIKE'%" + this.txtBoxSzukajKsiazki.Text +
                                        "%' OR kategoria || ' ' || tytul || ' ' || opis || ' ' || wydawnictwo || ' ' || rok_wydania || ' ' || autor LIKE'%" + this.txtBoxSzukajKsiazki.Text +
                                        "%' OR kategoria || ' ' || tytul || ' ' || wydawnictwo || ' ' || opis || ' ' || autor || ' ' || rok_wydania LIKE'%" + this.txtBoxSzukajKsiazki.Text +
                                        "%' OR kategoria || ' ' || tytul || ' ' || wydawnictwo || ' ' || autor || ' ' || opis || ' ' || rok_wydania LIKE'%" + this.txtBoxSzukajKsiazki.Text +
                                        "%' OR kategoria || ' ' || tytul || ' ' || wydawnictwo || ' ' || rok_wydania || ' ' || autor || ' ' || opis LIKE'%" + this.txtBoxSzukajKsiazki.Text +
                                        "%' OR kategoria || ' ' || tytul || ' ' || wydawnictwo || ' ' || rok_wydania || ' ' || opis || ' ' || autor LIKE'%" + this.txtBoxSzukajKsiazki.Text +
                                        "%' OR kategoria || ' ' || autor || ' ' || opis || ' ' || rok_wydania || ' ' || wydawnictwo || ' ' || tytul LIKE'%" + this.txtBoxSzukajKsiazki.Text +
                                        "%' OR kategoria || ' ' || opis || ' ' || autor || ' ' || rok_wydania || ' ' || wydawnictwo || ' ' || tytul LIKE'%" + this.txtBoxSzukajKsiazki.Text +
                                        "%' OR kategoria || ' ' || wydawnictwo || ' ' || autor || ' ' || rok_wydania || ' ' || tytul || ' ' || opis LIKE'%" + this.txtBoxSzukajKsiazki.Text +
                                        "%' OR kategoria || ' ' || rok_wydania || ' ' || wydawnictwo || ' ' || autor || ' ' || opis || ' ' || tytul LIKE'%" + this.txtBoxSzukajKsiazki.Text + "%'";
                //    SQLiteCommand createCommand = new SQLiteCommand(Query, db_connect);
                DBKsiazki = new SQLiteDataAdapter(Query, db_connect);
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

        private void dgvKsiazki_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBoxKategoria.Text = dgvKsiazki.SelectedRows[0].Cells["kategoria"].Value.ToString();
            txtBoxTytul.Text = dgvKsiazki.SelectedRows[0].Cells["tytul"].Value.ToString();
            txtBoxOpis.Text = dgvKsiazki.SelectedRows[0].Cells["opis"].Value.ToString();
            txtBoxAutor.Text = dgvKsiazki.SelectedRows[0].Cells["autor"].Value.ToString();
            txtBoxWydawnictwo.Text = dgvKsiazki.SelectedRows[0].Cells["wydawnictwo"].Value.ToString();
            txtBoxRokWydania.Text = dgvKsiazki.SelectedRows[0].Cells["rok_wydania"].Value.ToString();
            txtBoxPosiadanaIlosc.Text = dgvKsiazki.SelectedRows[0].Cells["posiadana_ilosc"].Value.ToString();
            txtBoxIloscWBibliotece.Text = dgvKsiazki.SelectedRows[0].Cells["ilosc_w_bibliotece"].Value.ToString();
        }

        private void btnEdytujKsiazke_Click(object sender, EventArgs e)
        {
            try
            {
                if (db_connect != null && db_connect.State == ConnectionState.Closed) { db_connect.Open(); }
                db_querry = "UPDATE Ksiazki SET kategoria = '" + txtBoxKategoria.Text.ToString() + "', tytul = '" + txtBoxTytul.Text.ToString() + "', opis = '" + txtBoxOpis.Text.ToString() + "', autor = '" + txtBoxAutor.Text.ToString() + "', wydawnictwo = '" + txtBoxWydawnictwo.Text.ToString() + "', rok_wydania = '" + txtBoxRokWydania.Text.ToString() + "', posiadana_ilosc = '" + txtBoxPosiadanaIlosc.Text.ToString() + "', ilosc_w_bibliotece = '" + txtBoxIloscWBibliotece.Text.ToString() + "' WHERE Ksiazki.id_ksiazka = '" + dgvKsiazki.SelectedRows[0].Cells["id_ksiazka"].Value.ToString() + "'; ";
                MessageBox.Show(db_querry);
                db_command = new SQLiteCommand(db_querry, db_connect);
                db_command.ExecuteNonQuery();
            }
            catch (Exception ErrorEdytujKsiazke)
            {
                MessageBox.Show(ErrorEdytujKsiazke.Message);
            }
        }
    }
}
    
// dodana linijka