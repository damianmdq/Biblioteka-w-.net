/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using Biblioteka_w_Dotnet;
using System.Windows.Forms;

namespace Biblioteka_w_Dotnet.lib
{
   class DBConnect
    {
        private SQLiteConnection dbConnection;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();

        //ustawianie połączenia

        public void SetConnection()
        {
            dbConnection = new SQLiteConnection("Data Source = ./DBbiblioteka.db;Version=3;New=False;Compress=True;");
        }
        // Otwieranie bazy
        public void OpenConnection()
        {
            dbConnection.Open();
        }
        // Zamykanie bazy
        public void CloseConnection()
        {
            dbConnection.Close();
        }
        //ustawianie ExecuteQuery
        public void ExecuteQuery(String txtQuery)
        {
            SetConnection();
            dbConnection.Open();
            sql_cmd = dbConnection.CreateCommand();
            sql_cmd.CommandText = txtQuery;
         //   sql_cmd.ExecuteNonQuery();
            dbConnection.Close();
        }

        
        

        //ustawienie LoadDatabase
        public void LoadData()
        {
            SetConnection();
            dbConnection.Open();
            sql_cmd = dbConnection.CreateCommand();
            string CommandText = "SELECT * FROM uzytkownicy";
            DB = new SQLiteDataAdapter(CommandText, dbConnection);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            var DGV = new Biblioteka();
            DGV.dgvListaWypozyczajacych.DataSource = DT;
            dbConnection.Close(); 
        }
    }
}
*/