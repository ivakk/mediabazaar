using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MP_SchedulingDAL
{
    public abstract class Connection{

        //private string ConnectionString = "Server=CHERNORIZEC\\SQLEXPRESS;Database=SRS-local;Trusted_Connection=True";
        public string ConnectionString = "Server = mssqlstud.fhict.local; Database=dbi493091_srs;User Id = dbi493091_srs; Password=password;";

        public SqlConnection connection;
        protected Connection()
        {
            connection = new SqlConnection(ConnectionString);
        }
    }
}
