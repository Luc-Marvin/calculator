using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication2
{
    class MySqlConnection
    {
        private string connectionString;

        public MySqlConnection(string connectionString)
        {
            // TODO: Complete member initialization
            this.connectionString = connectionString;
        }
        internal void Close()
        {
            throw new NotImplementedException();
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }
    }
}
