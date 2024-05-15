using MP_EntityLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP_BusinessLogic.InterfacesDal
{
    public interface ICategoryDalManager
    {
        List<Category> GetAll();
        Category GetByName(string Name);
    }
}
