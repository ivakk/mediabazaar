using MP_BusinessLogic.InterfacesDal;
using MP_BusinessLogic.InterfacesLL;
using MP_EntityLibrary;

namespace MP_BusinessLogic.Services
{
    public class CategoryService : ICategoryService
    {
        ICategoryDalManager controller;

        public CategoryService(ICategoryDalManager controller)
        {
            this.controller = controller;
        }

        public List<Category> GetAll()
        {
            return controller.GetAll();
        }
        public Category GetByName(string Name)
        {
            return controller.GetByName(Name);
            //foreach (Category category in GetAll())
            //{
            //    if (category.Name == Name)
            //    {
            //        return category;
            //    }
            //}
            //return null;
        }
    }
}
