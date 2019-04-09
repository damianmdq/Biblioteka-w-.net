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
using System.Net;
using System.Net.Mail;

namespace Biblioteka_w_Dotnet
{
    public partial class Biblioteka : Form
    {
        public Biblioteka()
        {
            InitializeComponent();
        }

        public class Task
        {
            public int Id { get; set; }
          //  public string Name { get; set; }
          //  public string Key { get; set; }
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

        // DataGridView Lista Czytelników
        private SQLiteDataAdapter DBdgvCzytelnicyListaWypozyczajacych;
        private DataSet DSdgvCzytelnicyListaWypozyczajacych = new DataSet();
        private DataTable DTdgvCzytelnicyListaWypozyczajacych = new DataTable();

        // Czas z komputera
        DateTime lokalnaData = DateTime.UtcNow.ToLocalTime();
        DateTime dataWyslaniaMaila = DateTime.UtcNow.ToLocalTime().AddDays(14);




        public void btnWypozyczeniaSzukaj_Click(object sender, EventArgs e)
        {
            try
            {
                string dataWypozyczenia = lokalnaData.ToString("yyyy-MM-dd");
                MessageBox.Show(dataWypozyczenia);
                if (db_connect != null && db_connect.State == ConnectionState.Closed) { db_connect.Open(); }
                db_querry = "SELECT * FROM Czytelnicy WHERE imie || ' ' || nazwisko || ' ' || miasto || ' ' || ulica || ' ' || email LIKE'%" + txtBoxWypozyczeniaSzukaj.Text +
                                                    "%' OR imie || ' ' || miasto || ' ' || nazwisko || ' ' || ulica || ' ' || email LIKE'%" + txtBoxWypozyczeniaSzukaj.Text +
                                                    "%' OR nazwisko || ' ' || imie || ' ' || miasto || ' ' || ulica || ' ' || email LIKE'%" + txtBoxWypozyczeniaSzukaj.Text +
                                                    "%' OR nazwisko || ' ' || miasto || ' ' || imie || ' ' || ulica || ' ' || email LIKE'%" + txtBoxWypozyczeniaSzukaj.Text +
                                                    "%' OR ulica || ' ' || miasto || ' ' || imie || ' ' || nazwisko || ' ' || email LIKE'%" + txtBoxWypozyczeniaSzukaj.Text +
                                                    "%' OR email || ' ' || miasto || ' ' || imie || ' ' || ulica || ' ' || nazwisko LIKE'%" + txtBoxWypozyczeniaSzukaj.Text +
                                                    "%' OR miasto || ' ' || imie || ' ' || nazwisko || ' ' || ulica || ' ' || email LIKE'%" + txtBoxWypozyczeniaSzukaj.Text +
                                                    "%' OR miasto || ' ' || nazwisko || ' ' || imie || ' ' || ulica || ' ' || email LIKE'%" + txtBoxWypozyczeniaSzukaj.Text + "%'";
                DBListaWypozyczajacych = new SQLiteDataAdapter(db_querry, db_connect);
                DSListaWypozyczajacych.Clear();
                DBListaWypozyczajacych.Fill(DSListaWypozyczajacych);
                DTListaWypozyczajacych = DSListaWypozyczajacych.Tables[0];
                dgvListaWypozyczajacych.DataSource = DTListaWypozyczajacych;
                dgvListaWypozyczajacych.Columns["id_czytelnik"].Visible = false;
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
                    "           Ksiazki.id_ksiazka, Wypozyczenia.id_wypozyczenie, Ksiazki.kategoria, Ksiazki.tytul, Ksiazki.opis, Ksiazki.autor " +
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
                dgvKsiazkiWypozyczone.Columns["id_ksiazka"].Visible = false;
                dgvKsiazkiWypozyczone.Columns["id_wypozyczenie"].Visible = false;
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

        ///////////////// Button Wypożyczenie z zakładki Wypożyczenia ///////////////////
        private void btnWypozyczeniaWypozyczenie_Click(object sender, EventArgs e)
        {
            KsiazkiForm ksiazkiForm = new KsiazkiForm(this);
            ksiazkiForm.Owner = this;
            ksiazkiForm.ShowDialog();
        }

        ///////////////// Button Zwrot z zakładki Wypożyczenia ///////////////////
        private void btnWypozyczeniaZwrot_Click(object sender, EventArgs e)
        {
            try
            {
                if (db_connect != null && db_connect.State == ConnectionState.Closed) { db_connect.Open(); }
                db_querry = "SELECT ilosc_w_bibliotece FROM Ksiazki WHERE id_ksiazka = '" + dgvKsiazkiWypozyczone.SelectedRows[0].Cells["id_ksiazka"].Value + "' ;";
                db_command = new SQLiteCommand(db_querry, db_connect);
                db_read = db_command.ExecuteReader();
                db_read.Read();
                string iloscWBibliotece = db_read["ilosc_w_bibliotece"].ToString();

                int iloscPoZwrocie = int.Parse(iloscWBibliotece) + 1;
                if (db_connect != null && db_connect.State == ConnectionState.Closed) { db_connect.Open(); }
                db_querry = "UPDATE Ksiazki SET ilosc_w_bibliotece = '" + iloscPoZwrocie + "' WHERE Ksiazki.id_ksiazka = '" + dgvKsiazkiWypozyczone.SelectedRows[0].Cells["id_ksiazka"].Value + "'; ";
                db_command = new SQLiteCommand(db_querry, db_connect);
                db_command.ExecuteNonQuery();

                db_querry2 = "DELETE FROM Wypozyczenia WHERE id_wypozyczenie = '" + dgvKsiazkiWypozyczone.SelectedRows[0].Cells["id_wypozyczenie"].Value.ToString() + "'; ";
                db_command = new SQLiteCommand(db_querry2, db_connect);
                db_command.ExecuteNonQuery();
            }
            catch (Exception errorZwrot)
            {
                MessageBox.Show(errorZwrot.Message);
            }
        }
        ///////////////// Reakcja po kliknięciu w text box szukaj ksiazki z zakładki Książki ///////////////////
        private void txtBoxWypozyczeniaSzukaj_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtBoxWypozyczeniaSzukaj.Text == "Wprowadź imię, nazwisko lub miejscowość")
            {
                txtBoxWypozyczeniaSzukaj.Text = string.Empty;
                txtBoxWypozyczeniaSzukaj.ForeColor = SystemColors.WindowText;
            }
        }

        ///////////////// Reakcja po kliknięciu w text box szukaj ksiazki z zakładki Wypożyczenia ///////////////////
        private void txtBoxSzukajKsiazki_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtBoxSzukajKsiazki.Text == "Wprowadź dane ksiązki, którą chcesz wyszukać")
            {
                txtBoxSzukajKsiazki.Text = string.Empty;
                txtBoxSzukajKsiazki.ForeColor = SystemColors.WindowText;
            }
        }

        ///////////////// Button Szukaj Ksiażki ///////////////////
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

        ///////////////// Reakcja po kliknięciu w data grid view książki ///////////////////
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

        ///////////////// Button edytuj Ksiażkę ///////////////////
        private void btnEdytujKsiazke_Click(object sender, EventArgs e)
        {
            try
            {
                if (db_connect != null && db_connect.State == ConnectionState.Closed) { db_connect.Open(); }
                db_querry = "UPDATE Ksiazki SET kategoria = '" + txtBoxKategoria.Text.ToString() + "', tytul = '" + txtBoxTytul.Text.ToString() + "', opis = '" + txtBoxOpis.Text.ToString() + "', autor = '" + txtBoxAutor.Text.ToString() + "', wydawnictwo = '" + txtBoxWydawnictwo.Text.ToString() + "', rok_wydania = '" + txtBoxRokWydania.Text.ToString() + "', posiadana_ilosc = '" + txtBoxPosiadanaIlosc.Text.ToString() + "', ilosc_w_bibliotece = '" + txtBoxIloscWBibliotece.Text.ToString() + "' WHERE Ksiazki.id_ksiazka = '" + dgvKsiazki.SelectedRows[0].Cells["id_ksiazka"].Value.ToString() + "'; ";
                DialogResult czyEdytowacKsiazke = MessageBox.Show("Czy na pewno chcesz edytować tą książkę? ", "Uwaga", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (czyEdytowacKsiazke == DialogResult.Yes)
                {
                    db_command = new SQLiteCommand(db_querry, db_connect);
                    db_command.ExecuteNonQuery();
                    MessageBox.Show("Książka została edytowana");
                }
            }
            catch (Exception ErrorEdytujKsiazke)
            {
                MessageBox.Show(ErrorEdytujKsiazke.Message);
            }
        }

        ///////////////// Button dodaj Ksiażkę ///////////////////
        private void btnDodajKsiazke_Click(object sender, EventArgs e)
        {
            try
            {
                if (db_connect != null && db_connect.State == ConnectionState.Closed) { db_connect.Open(); }
                db_querry = "INSERT INTO Ksiazki (kategoria, tytul, opis, autor, wydawnictwo, rok_wydania, posiadana_ilosc, ilosc_w_bibliotece) VALUES " +
                               "('" + txtBoxKategoria.Text.ToString() + "', '" + txtBoxTytul.Text.ToString() + "', '" + txtBoxOpis.Text.ToString() + "' , '" + txtBoxAutor.Text.ToString() + "', '" + txtBoxWydawnictwo.Text.ToString() + "', '" + txtBoxRokWydania.Text.ToString() + "', '" + txtBoxPosiadanaIlosc.Text.ToString() + "', '" + txtBoxIloscWBibliotece.Text.ToString() + "'); ";
                DialogResult czyDodacKsiazke = MessageBox.Show("Czy na pewno chcesz dodać tą książkę? ", "Uwaga", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (czyDodacKsiazke == DialogResult.Yes)
                {
                    db_command = new SQLiteCommand(db_querry, db_connect);
                    db_command.ExecuteNonQuery();
                    MessageBox.Show("Książka została dodana");
                }
            }
            catch (Exception errorDodajKsiazke)
            {
                MessageBox.Show(errorDodajKsiazke.Message);
            }
        }

        ///////////////// Button usuń Ksiażkę ///////////////////
        private void btnUsunKsiazke_Click(object sender, EventArgs e)
        {
            try
            {
                if (db_connect != null && db_connect.State == ConnectionState.Closed) { db_connect.Open(); }
                db_querry = "DELETE FROM Ksiazki WHERE id_ksiazka = '" + dgvKsiazki.SelectedRows[0].Cells["id_ksiazka"].Value.ToString() + "'; ";
                DialogResult czyUsunacKsiazke = MessageBox.Show("Czy na pewno chcesz usunąć tą książkę? ", "Uwaga", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (czyUsunacKsiazke == DialogResult.Yes)
                {
                    db_command = new SQLiteCommand(db_querry, db_connect);
                    db_command.ExecuteNonQuery();
                    MessageBox.Show("Książka została usunięta");
                }
            }
            catch (Exception errorEdytujKsiazke)
            {
                MessageBox.Show(errorEdytujKsiazke.Message);
            }
        }

        ///////////////// Napis w textBoxie txtBoxCzytelnicySzukaj ///////////////////
        private void txtBoxCzytelnicySzukaj_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtBoxCzytelnicySzukaj.Text == "Wprowadź dane czytelnika")
            {
                txtBoxCzytelnicySzukaj.Text = string.Empty;
                txtBoxCzytelnicySzukaj.ForeColor = SystemColors.WindowText;
            }
        }

        ///////////////// Button dodaj czytelnika ///////////////////
        private void btnCzytelnicyDodajCzytelnika_Click(object sender, EventArgs e)
        {
            try
            {
                if (db_connect != null && db_connect.State == ConnectionState.Closed) { db_connect.Open(); }
                db_querry = "INSERT INTO Czytelnicy (imie, nazwisko, miasto, ulica, email) VALUES " +
                               "('" + txtBoxCzytelnicyImie.Text.ToString() + "', '" + txtBoxCzytelnicyNazwisko.Text.ToString() + "', '" + txtBoxCzytelnicyMiasto.Text.ToString() + "' , '" + txtBoxCzytelnicyUlica.Text.ToString() + "', '" + txtBoxCzytelnicyEmail.Text.ToString() + "'); ";
                DialogResult czyDodacCzytelnika = MessageBox.Show("Czy na pewno chcesz dodać czytelnika? ", "Uwaga", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (czyDodacCzytelnika == DialogResult.Yes)
                {
                    db_command = new SQLiteCommand(db_querry, db_connect);
                    db_command.ExecuteNonQuery();
                    MessageBox.Show("Czytelnik został dodany");
                }
            }
            catch (Exception errorDodajKsiazke)
            {
                MessageBox.Show(errorDodajKsiazke.Message);
            }
        }

        ///////////////// Button edytuj czytelnika ///////////////////
        private void btnCzytelnicyEdytujCzytelnika_Click(object sender, EventArgs e)
        {
            try
            {
                if (db_connect != null && db_connect.State == ConnectionState.Closed) { db_connect.Open(); }
                db_querry = "UPDATE Czytelnicy SET imie = '" + txtBoxCzytelnicyImie.Text.ToString() + "', nazwisko = '" + txtBoxCzytelnicyNazwisko.Text.ToString() + "', miasto = '" + txtBoxCzytelnicyMiasto.Text.ToString() + "', ulica = '" + txtBoxCzytelnicyUlica.Text.ToString() + "', email = '" + txtBoxCzytelnicyEmail.Text.ToString() + "' WHERE Czytelnicy.id_czytelnik = '" + dgvCzytelnicyListaWypozyczajacych.SelectedRows[0].Cells["id_czytelnik"].Value.ToString() + "'; ";
                DialogResult czyEdytowacCzytelnika = MessageBox.Show("Czy na pewno chcesz edytować tego czytelnika? ", "Uwaga", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (czyEdytowacCzytelnika == DialogResult.Yes)
                {
                    db_command = new SQLiteCommand(db_querry, db_connect);
                    db_command.ExecuteNonQuery();
                    MessageBox.Show("Czytelnik został edytowany");
                }
            }
            catch (Exception ErrorEdytujKsiazke)
            {
                MessageBox.Show(ErrorEdytujKsiazke.Message);
            }
        }

        ///////////////// Button usuń czytelnika ///////////////////
        private void btnCzytelnicyUsunCzytelnika_Click(object sender, EventArgs e)
        {
            try
            {
                if (db_connect != null && db_connect.State == ConnectionState.Closed) { db_connect.Open(); }
                db_querry = "DELETE FROM Czytelnicy WHERE id_czytelnik = '" + dgvCzytelnicyListaWypozyczajacych.SelectedRows[0].Cells["id_czytelnik"].Value.ToString() + "'; ";
                DialogResult czyUsunacCzytelnika = MessageBox.Show("Czy na pewno chcesz usunąć tego czytelnika? ", "Uwaga", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (czyUsunacCzytelnika == DialogResult.Yes)
                {
                    db_command = new SQLiteCommand(db_querry, db_connect);
                    db_command.ExecuteNonQuery();
                    MessageBox.Show("Czytelnik został usunięty");
                }
            }
            catch (Exception errorEdytujKsiazke)
            {
                MessageBox.Show(errorEdytujKsiazke.Message);
            }
        }

        ///////////////// Button Szukaj czytelnika ///////////////////
        private void btnCzytelnicySzukaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (db_connect != null && db_connect.State == ConnectionState.Closed) { db_connect.Open(); }
                db_querry = "SELECT * FROM Czytelnicy WHERE imie || ' ' || nazwisko || ' ' || miasto || ' ' || ulica || ' ' || email LIKE'%" + txtBoxCzytelnicySzukaj.Text +
                                                        "%' OR imie || ' ' || miasto || ' ' || nazwisko || ' ' || ulica || ' ' || email LIKE'%" + txtBoxCzytelnicySzukaj.Text +
                                                        "%' OR nazwisko || ' ' || imie || ' ' || miasto || ' ' || ulica || ' ' || email LIKE'%" + txtBoxCzytelnicySzukaj.Text +
                                                        "%' OR nazwisko || ' ' || miasto || ' ' || imie || ' ' || ulica || ' ' || email LIKE'%" + txtBoxCzytelnicySzukaj.Text +
                                                        "%' OR ulica || ' ' || miasto || ' ' || imie || ' ' || nazwisko || ' ' || email LIKE'%" + txtBoxCzytelnicySzukaj.Text +
                                                        "%' OR email || ' ' || miasto || ' ' || imie || ' ' || ulica || ' ' || nazwisko LIKE'%" + txtBoxCzytelnicySzukaj.Text +
                                                        "%' OR miasto || ' ' || imie || ' ' || nazwisko || ' ' || ulica || ' ' || email LIKE'%" + txtBoxCzytelnicySzukaj.Text +
                                                        "%' OR miasto || ' ' || nazwisko || ' ' || imie || ' ' || ulica || ' ' || email LIKE'%" + txtBoxCzytelnicySzukaj.Text + "%'";
                DBdgvCzytelnicyListaWypozyczajacych = new SQLiteDataAdapter(db_querry, db_connect);
                DSdgvCzytelnicyListaWypozyczajacych.Clear();
                DBdgvCzytelnicyListaWypozyczajacych.Fill(DSdgvCzytelnicyListaWypozyczajacych);
                DTdgvCzytelnicyListaWypozyczajacych = DSdgvCzytelnicyListaWypozyczajacych.Tables[0];
                dgvCzytelnicyListaWypozyczajacych.DataSource = DTdgvCzytelnicyListaWypozyczajacych;
                dgvCzytelnicyListaWypozyczajacych.Columns["id_czytelnik"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        ///////////////// Data Grid View Lista Wypożyczających z zakładki Czytelnicy ///////////////////
        private void dgvCzytelnicyListaWypozyczajacych_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBoxCzytelnicyImie.Text = dgvCzytelnicyListaWypozyczajacych.SelectedRows[0].Cells["imie"].Value.ToString();
            txtBoxCzytelnicyNazwisko.Text = dgvCzytelnicyListaWypozyczajacych.SelectedRows[0].Cells["nazwisko"].Value.ToString();
            txtBoxCzytelnicyMiasto.Text = dgvCzytelnicyListaWypozyczajacych.SelectedRows[0].Cells["miasto"].Value.ToString();
            txtBoxCzytelnicyUlica.Text = dgvCzytelnicyListaWypozyczajacych.SelectedRows[0].Cells["ulica"].Value.ToString();
            txtBoxCzytelnicyEmail.Text = dgvCzytelnicyListaWypozyczajacych.SelectedRows[0].Cells["email"].Value.ToString();
        }

        ///////////////// Button z funkcją wyczyszczenia textboxów z zakładki Czytelnicy ///////////////////
        private void btnCzytelnicyWyczysc_Click(object sender, EventArgs e)
        {
            txtBoxCzytelnicyImie.Text = null;
            txtBoxCzytelnicyNazwisko.Text = null;
            txtBoxCzytelnicyMiasto.Text = null;
            txtBoxCzytelnicyUlica.Text = null;
            txtBoxCzytelnicyEmail.Text = null;
        }

        private void btnWyslijEmaile_Click(object sender, EventArgs e)
        {
       

        string data_wyslania_maila = dataWyslaniaMaila.ToString("yyyy-MM-dd");
            try
            {
                if (db_connect != null && db_connect.State == ConnectionState.Closed) { db_connect.Open(); }
                db_querry = "SELECT id_czytelnik FROM Wypozyczenia WHERE data_oddania = '" + data_wyslania_maila.ToString() + "' ;";
                db_command = new SQLiteCommand(db_querry, db_connect);
                db_read = db_command.ExecuteReader();


                var idCzytelnikow = new List<Int32>();

                while (db_read.Read())
                {
                    idCzytelnikow.Add(db_read.GetInt32(0));
                    MessageBox.Show(idCzytelnikow.ToString());
                }
                
                


                




                //      string [] idCzytelnika = new string [2];
                //       idCzytelnika[] = db_read["id_czytelnik"].ToString();
                //  string idCzytelnika = db_read["id_czytelnik"].ToString();
                /*   MessageBox.Show(idCzytelnika.ToString());
                   MessageBox.Show(data_wyslania_maila.ToString());

                   if (idCzytelnika != null)
                   { 
                       db_querry = "SELECT imie, nazwisko, email FROM Czytelnicy WHERE id_czytelnik = '" + idCzytelnika.ToString() + "' ;";
                       db_command = new SQLiteCommand(db_querry, db_connect);
                       db_read = db_command.ExecuteReader();
                       db_read.Read();
                       string imie = db_read["imie"].ToString();
                       string nazwisko = db_read["nazwisko"].ToString();
                       string email = db_read["email"].ToString();
                       MessageBox.Show(imie + nazwisko + email);

                       string tresc = imie.ToString() + " " + nazwisko.ToString() + " za 14 dni kończy się Ci okres wypożyczenia";
                       Biblioteka_w.net.lib.MailSender MailSender = new Biblioteka_w.net.lib.MailSender();
                       MailSender.mailSender(email.ToString(), "Powiadomienie o wypożyczeniu", tresc);
                       MessageBox.Show("Maile zostały wysłane");
                   }*/
            }                         
            catch (Exception errorWyslijEmaile)
            {
                MessageBox.Show(errorWyslijEmaile.Message);
            }
            /*

                        try
                        {
                            if (db_connect != null && db_connect.State == ConnectionState.Closed) { db_connect.Open(); }
                            db_querry = "SELECT data_oddania FROM Wypozyczenia";
                            DialogResult czyWyslacPowiadomienia = MessageBox.Show("Czy na pewno chcesz wysłać powiadomienia do czytelnikó? ", "Uwaga", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                            if (czyWyslacPowiadomienia == DialogResult.Yes)
                            {
                                db_command = new SQLiteCommand(db_querry, db_connect);
                                db_command.ExecuteNonQuery();
                            }

                        }
                        catch (Exception errorWyslijEmaile)
                        {
                            MessageBox.Show(errorWyslijEmaile.Message);
                        }
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        }
    
}
    
// dodana linijka