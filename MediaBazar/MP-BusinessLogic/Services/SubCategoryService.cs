using MP_DataAccess.DALManagers;
using MP_EntityLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP_BusinessLogic.Services
{
    public class SubCategoryService
    {
        private SubCategoryDALManager dalManager = new SubCategoryDALManager();

        public List<SubCategory> GetAll()
        {
            return (List<SubCategory>)dalManager.GetAll();
        }

        public List<SubCategory> GetForCategory(Category category)
        {
            List<SubCategory> all = GetAll();
            List < SubCategory > result = new List<SubCategory>();
            foreach (SubCategory subCategory in all)
            {
                if(subCategory.Category.Id == category.Id)
                    result.Add(subCategory);
            }
            return result;
        }
        public SubCategory GetByName(string Name)
        {
            foreach (SubCategory subCategory in GetAll())
            {
                if (subCategory.Name == Name)
                    return subCategory;
            }
            return null;
        }

        public List<string> GetForCategoryAsString(Category category)
        {
            List<SubCategory> all = GetAll();
            List<string> result = new List<string>();
            foreach (SubCategory subCategory in all)
            {
                if (subCategory.Category.Id == category.Id)
                    result.Add(subCategory.Name);
            }
            return result;
        }
    }
}
