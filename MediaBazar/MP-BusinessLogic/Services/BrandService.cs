using MP_DataAccess.DALManagers;
using MP_EntityLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP_BusinessLogic.Services
{
    public class BrandService
    {
        private BrandDALManager dalManager = new BrandDALManager();

        public List<Brand> GetAll()
        {
            return (List<Brand>)dalManager.GetAll();
        }
        public Brand GetByName(string Name)
        {
            foreach (Brand brand in GetAll())
            {
                if(brand.Name == Name)
                    return brand;
            }
            return null;
        }
    }
}
