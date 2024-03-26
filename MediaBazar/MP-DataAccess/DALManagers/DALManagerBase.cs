using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MP_EntityLibrary;

namespace MP_DataAccess.DALManagers
{
    public interface DALManagerBase {
        public object? Get(int id);
        public object? GetAll();
        public object? Update(object entity);
        public bool Delete(int id);

    }
}
