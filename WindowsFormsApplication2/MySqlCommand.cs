using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication2
{
    class MySqlCommand
    {
        private string query;
        private MySqlConnection databaseConnection;

        public MySqlCommand(string query, MySqlConnection databaseConnection)
        {
            // TODO: Complete member initialization
            this.query = query;
            this.databaseConnection = databaseConnection;
        }
        internal MySqlDataReader ExecuteReader()
        {
            throw new NotImplementedException();
        }

        public int CommandTimeout { get; set; }
    }
}
