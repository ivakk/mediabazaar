using MP_EntityLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP_BusinessLogic.InterfacesDal
{
    public interface IBrandDalManager
    {
        List<Brand> GetAll();
        Brand GetByName(string Name);
    }
}
