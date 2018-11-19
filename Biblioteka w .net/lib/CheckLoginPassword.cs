/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Biblioteka_w_Dotnet.lib;
using Biblioteka_w_Dotnet;


namespace Biblioteka_w_Dotnet.lib
{

    


    public class CheckLoginPassword
    {
        //sprawdzanie loginu i hasła
        public CheckLoginPassword(string login)
        {
            string query = "SELECT " + login + " FROM uzytkownicy";
            var DBConnect = new DBConnect();
            DBConnect.SetConnection();
            DBConnect.ExecuteQuery(query);


            MessageBox.Show(query);
        }
    }
}
*/