using MP_BusinessLogic.InterfacesDal;
using MP_BusinessLogic.InterfacesLL;
using MP_EntityLibrary;

namespace MP_BusinessLogic.Services
{
    public class BrandService : IBrandService
    {
        IBrandDalManager controller;

        public BrandService(IBrandDalManager controller)
        {
            this.controller = controller;
        }
        
        public List<Brand> GetAll()
        {
            return controller.GetAll();
        }

        public Brand GetByName(string Name)
        {
            return controller.GetByName(Name);
            //foreach (Brand brand in GetAll())
            //{
            //    if (brand.Name == Name)
            //        return brand;
            //}
            //return null;
        }
    }
}
