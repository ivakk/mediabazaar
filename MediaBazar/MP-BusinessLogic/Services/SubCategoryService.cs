using MP_BusinessLogic.InterfacesDal;
using MP_BusinessLogic.InterfacesLL;
using MP_EntityLibrary;

namespace MP_BusinessLogic.Services
{
    public class SubCategoryService : ISubCategoryService
    {
        ISubCategoryDalManager controller;

        public SubCategoryService(ISubCategoryDalManager controller)
        {
            this.controller = controller;
        }


        public List<SubCategory> GetAll()
        {
            return controller.GetAll();
        }

        public List<SubCategory> GetForCategory(Category category)
        {
            return controller.GetForCategory(category);
        }
        public SubCategory GetByName(string Name)
        {
            return controller.GetByName(Name);
        }

        public List<string> GetForCategoryAsString(Category category)
        {
            return controller.GetForCategoryAsString(category);
        }


        //private SubCategoryDALManager dalManager = new SubCategoryDALManager();
        //public List<SubCategory> GetAll()
        //{
        //    return (List<SubCategory>)dalManager.GetAll();
        //}

        //public List<SubCategory> GetForCategory(Category category)
        //{
        //    List<SubCategory> all = GetAll();
        //    List<SubCategory> result = new List<SubCategory>();
        //    foreach (SubCategory subCategory in all)
        //    {
        //        if (subCategory.Category.Id == category.Id)
        //            result.Add(subCategory);
        //    }
        //    return result;
        //}
        //public SubCategory GetByName(string Name)
        //{
        //    foreach (SubCategory subCategory in GetAll())
        //    {
        //        if (subCategory.Name == Name)
        //            return subCategory;
        //    }
        //    return null;
        //}

        //public List<string> GetForCategoryAsString(Category category)
        //{
        //    List<SubCategory> all = GetAll();
        //    List<string> result = new List<string>();
        //    foreach (SubCategory subCategory in all)
        //    {
        //        if (subCategory.Category.Id == category.Id)
        //            result.Add(subCategory.Name);
        //    }
        //    return result;
        //}
    }
}
