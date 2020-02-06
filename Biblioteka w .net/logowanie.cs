using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Security.Cryptography;

namespace Biblioteka_w_Dotnet
{
    public partial class logowanie : Form
    {
        public logowanie()
        {
            InitializeComponent();
        }

        Thread th;  // Threading 

        //Otwieranie nowego formularza Biblioteka
        private void openNewForm(object obj)
        {
            Application.Run(new Biblioteka());
        }

        //Połączenie z bazą danych
        SQLiteConnection sqliteCon = new SQLiteConnection("Data Source = ./DBbiblioteka.db;Version=3;New=False;Compress=True;");

        public void btnZaloguj_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqliteCon != null && sqliteCon.State == ConnectionState.Closed) { sqliteCon.Open(); }

                string haslo = "";
                using (MD5 md5 = MD5.Create())
                {
                    haslo = GetMD5Hash(md5, this.txtBoxHaslo.Text);
                }
                
                string Query = "SELECT id_pracownik FROM Pracownicy WHERE login='" + this.txtBoxLogin.Text + "' AND haslo ='" + haslo + "'";
                //string Query = string.Format("SELECT * FROM Pracownicy WHERE login = '{0} AND haslo = '{1}'", this.txtBoxLogin.Text, haslo);
                SQLiteCommand createCommand = new SQLiteCommand(Query, sqliteCon);

                createCommand.ExecuteNonQuery();
                SQLiteDataReader dr = createCommand.ExecuteReader();

                int count = 0;
                while (dr.Read())
                {
                    count++;
                }
                if (count == 1)
                {
                 //   MessageBox.Show("Username is correct");
                    this.Close();
                    th = new Thread(openNewForm);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                if(count > 1)
                    MessageBox.Show("Nazwa użytkownika lub hasło są niepoprawne");
                if (count < 1)
                    MessageBox.Show("Nazwa użytkownika lub hasło są niepoprawne");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        // Przycisk zakończenia aplikacji
        private void btnZakoncz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        string GetMD5Hash(MD5 hash, string input)
        {
            byte[] tab = hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < tab.Length; i++)
                sBuilder.Append(tab[i].ToString("x2"));

            return sBuilder.ToString();
        }
    }
}
