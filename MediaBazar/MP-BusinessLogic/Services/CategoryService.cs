using MP_DataAccess.DALManagers;
using MP_EntityLibrary;

namespace MP_BusinessLogic.Services
{
    public class CategoryService
    {
        private CategoryDALManager dalManager = new CategoryDALManager();

        public List<Category> GetAll()
        {
            return (List<Category>)dalManager.GetAll();
        }
        public Category GetByName(string Name)
        {
            foreach (Category category in GetAll())
            {
                if (category.Name == Name)
                {
                    return category;
                }
            }
            return null;
        }
    }
}
