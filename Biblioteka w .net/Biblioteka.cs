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

        // DataGridView Lista Wypożyczających
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();

        // DataGridView Lista Wypożyczeń
        private SQLiteDataAdapter DB2;
        private DataSet DS2 = new DataSet();
        private DataTable DT2 = new DataTable();

        //Połączenie z bazą danych
        SQLiteConnection sqliteCon = new SQLiteConnection("Data Source = ./DBbiblioteka.db;Version=3;New=False;Compress=True;");
        

        public void btnSzukaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqliteCon != null && sqliteCon.State == ConnectionState.Closed) { sqliteCon.Open(); }
                    String Query = "SELECT * FROM Czytelnicy WHERE imie || ' ' || nazwisko || ' ' || miasto LIKE'%" + this.txtBoxDane.Text + 
                                                            "%' OR imie || ' ' || miasto || ' ' || nazwisko LIKE'%" + this.txtBoxDane.Text + 
                                                            "%' OR nazwisko || ' ' || imie || ' ' || miasto LIKE'%" + this.txtBoxDane.Text +
                                                            "%' OR nazwisko || ' ' || miasto || ' ' || imie LIKE'%" + this.txtBoxDane.Text +
                                                            "%' OR miasto || ' ' || imie || ' ' || nazwisko LIKE'%" + this.txtBoxDane.Text +
                                                            "%' OR miasto || ' ' || nazwisko || ' ' || imie LIKE'%" + this.txtBoxDane.Text + "%'";
                    SQLiteCommand createCommand = new SQLiteCommand(Query, sqliteCon);
                    DB = new SQLiteDataAdapter(Query, sqliteCon);
                    DS.Clear();
                    DB.Fill(DS);
                    DT = DS.Tables[0];
                    dgvListaWypozyczajacych.DataSource = DT;
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
                
                if (sqliteCon != null && sqliteCon.State == ConnectionState.Closed) { sqliteCon.Open(); }
                String Query = "INSERT INTO Czytelnicy (imie, nazwisko, miasto) VALUES ('" + this.txtBoxImie.Text + "', '" + this.txtBoxNazwisko.Text + "', '" + this.txtBoxMiejscowosc.Text + "') ";
                SQLiteCommand createCommand = new SQLiteCommand(Query, sqliteCon);
                createCommand.ExecuteNonQuery();
                sqliteCon.Close();
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
                if (sqliteCon != null && sqliteCon.State == ConnectionState.Closed) { sqliteCon.Open(); }
                String Query = "UPDATE Czytelnicy SET imie = '" + this.txtBoxImie.Text + 
                                "', nazwisko = '" + this.txtBoxNazwisko.Text +
                                "', miasto = '" + this.txtBoxMiejscowosc.Text +
                                "' WHERE id_czytelnik = '" + this.dgvListaWypozyczajacych.SelectedRows[0].Cells["id_czytelnik"].Value.ToString() + "'";
                SQLiteCommand createCommand = new SQLiteCommand(Query, sqliteCon);
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
                if (sqliteCon != null && sqliteCon.State == ConnectionState.Closed) { sqliteCon.Open(); }
                String Query = "DELETE FROM " +
                    "           Czytelnicy " +
                    "           WHERE Czytelnicy.id_czytelnik = '" +
                                this.dgvListaWypozyczajacych.SelectedRows[0].Cells["id_czytelnik"].Value.ToString() + 
                                "' AND Wypozyczenia.id_czytelnik = '" +
                                this.dgvListaWypozyczajacych.SelectedRows[0].Cells["id_czytelnik"].Value.ToString() + "'";
                SQLiteCommand createCommand = new SQLiteCommand(Query, sqliteCon);
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
                    SQLiteCommand createCommand = new SQLiteCommand(Query, sqliteCon);
                    DB2 = new SQLiteDataAdapter(Query, sqliteCon);
                    DS2.Reset();
                    DB2.Fill(DS2);
                    DT2 = DS2.Tables[0];
                    dgvKsiazkiWypozyczone.DataSource = DT2;
                    
                   


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
                txtBoxDane.ForeColor = System.Drawing.SystemColors.WindowText;
            }
        }
    }
    
}
// dodana linijka