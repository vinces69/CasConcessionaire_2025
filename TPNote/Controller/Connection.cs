using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TPNote.Modele
{
    class Connection
    {
        public MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        public Connection()
        {
            Initialise();
        }

        private void Initialise()
        {
            server = "localhost";
            database = "bdd_concession";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }
    }
}
