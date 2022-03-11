using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication2
{
    class MysqlConnection
    {
        private string ConnectString;

        public MysqlConnection(string ConnectString)
        {
            // TODO: Complete member initialization
            this.ConnectString = ConnectString;
        }
        internal void Open()
        {
            throw new NotImplementedException();
        }
    }
}
