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


        public SQLiteConnection db_connect = new SQLiteConnection("Data Source = ./DBbiblioteka.db;Version=3;New=False;Compress=True;");         //zmienna przechowująca obiekt bazy danych
        public string db_querry = null;             //zmienna przechowująca zapytanie do bazy danych
        public string db_querry2 = null;
        public string db_querry3 = null;
        public SQLiteCommand db_command;            //zmienna przechowująca obiekt do wysyłania zapytań
        public SQLiteDataReader db_read;            //zmienna przechowująca odebrane informacje zwrócone dla zapytania doczytującego

        // DataGridView Lista Książek
        private SQLiteDataAdapter DBKsiazki;
        private DataSet DSKsiazki = new DataSet();
        private DataTable DTKsiazki = new DataTable();

        

        // Czas z komputera
        DateTime lokalnaData = DateTime.UtcNow.ToLocalTime();
        DateTime dataOddania = DateTime.UtcNow.ToLocalTime().AddMonths(1);

      

        // Przycisk szukanie książek
        private void btnSzukaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (db_connect != null && db_connect.State == ConnectionState.Closed) { db_connect.Open(); }
                String Query = 
                "SELECT * FROM Ksiazki WHERE kategoria || ' ' || tytul || ' ' || opis || ' ' || autor || ' ' || wydawnictwo || ' ' || rok_wydania LIKE'%" + this.txtBoxSzukaj.Text +
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

        // Przycisk wypożyczenie książki
        private void btnWypozycz_Click(object sender, EventArgs e)
        {
            try
            {
                string dataWypozyczenia = lokalnaData.ToString("yyyy-MM-dd");
                string dataZwrotu = dataOddania.ToString("yyyy-MM-dd");

                if (db_connect != null && db_connect.State == ConnectionState.Closed) { db_connect.Open(); }
                db_querry = "SELECT ilosc_w_bibliotece FROM Ksiazki WHERE id_ksiazka = '" + dgvKsiazki.SelectedRows[0].Cells["id_ksiazka"].Value + "' ;";
                db_command = new SQLiteCommand(db_querry, db_connect);         
                db_read = db_command.ExecuteReader();           
                db_read.Read();                                 
                string iloscWBibliotece = db_read["ilosc_w_bibliotece"].ToString();

                if ( int.Parse(iloscWBibliotece) > 0)
                {
                    int iloscPoWypozyczeniu = int.Parse(iloscWBibliotece) - 1; 

                    try
                    {
                        if (db_connect != null && db_connect.State == ConnectionState.Closed) { db_connect.Open(); }
                        db_querry = "INSERT INTO Wypozyczenia (id_czytelnik, id_ksiazka, data_wypozyczenia, data_oddania) VALUES " +
                                       "('" + biblioteka.dgvListaWypozyczajacych.SelectedRows[0].Cells["id_czytelnik"].Value.ToString() + "', '" + dgvKsiazki.SelectedRows[0].Cells["id_ksiazka"].Value + "', '" + dataWypozyczenia.ToString() + "' , '" + dataZwrotu.ToString() + "'); ";                       
                        db_command = new SQLiteCommand(db_querry, db_connect);
                        db_command.ExecuteNonQuery();
                        
                        db_querry2 = "UPDATE Ksiazki SET ilosc_w_bibliotece = '" + iloscPoWypozyczeniu + "' WHERE Ksiazki.id_ksiazka = '" + dgvKsiazki.SelectedRows[0].Cells["id_ksiazka"].Value + "'; ";
                        MessageBox.Show(db_querry2);
                        db_command = new SQLiteCommand(db_querry2, db_connect);
                        db_command.ExecuteNonQuery();

                        db_querry3 = "INSERT INTO HistoriaWypozyczen (id_czytelnik, id_ksiazka, data_wypozyczenia, data_oddania) VALUES " +
                                       "('" + biblioteka.dgvListaWypozyczajacych.SelectedRows[0].Cells["id_czytelnik"].Value.ToString() + "', '" + dgvKsiazki.SelectedRows[0].Cells["id_ksiazka"].Value + "', '" + dataWypozyczenia.ToString() + "' , '" + dataZwrotu.ToString() + "'); ";
                        db_command = new SQLiteCommand(db_querry3, db_connect);
                        db_command.ExecuteNonQuery();

                        MessageBox.Show("Książka została wypożyczona" + lokalnaData + dataOddania + iloscPoWypozyczeniu);
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Brak niewypożyczonej książki w bibliotece");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

     /*      
                    
                try
                {
                    String Query = "INSERT INTO Wypozyczenia (id_czytelnik, id_ksiazka, data_wypozyczenia, data_oddania, stan_faktyczny) VALUES " +
                                   "('" + biblioteka.dgvListaWypozyczajacych.SelectedRows[0].Cells["id_czytelnik"].Value.ToString() + "', '" + dgvKsiazki.SelectedRows[0].Cells["id_ksiazka"].Value + "', '" + dataWypozyczenia + "' , 2019, stan_faktyczny -1 ";
                    SQLiteCommand createCommand = new SQLiteCommand(Query, db_connect);
                    createCommand.ExecuteNonQuery();
                    db_connect.Close();
                    MessageBox.Show("Książka została wypożyczona");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
           */ 
        }

        //Przycisk Wyjście
        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            KsiazkiForm.ActiveForm.Close();
        }
    }
}
