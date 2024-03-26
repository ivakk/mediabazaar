using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MP_DataAccess.DALManagers
{
    public abstract class Connection{
        
        private readonly string ConnectionString = "Server = mssqlstud.fhict.local; Database=dbi503708_mp;User Id=dbi503708_mp; Password=password;";

        public SqlConnection connection;
        protected Connection()
        {
            connection = new SqlConnection(ConnectionString);
        }
    }
}
