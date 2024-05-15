﻿using MP_EntityLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP_BusinessLogic.InterfacesLL
{
    public interface ISubCategoryService
    {
        List<SubCategory> GetAll();
        List<SubCategory> GetForCategory(Category category);
        SubCategory GetByName(string Name);
        List<string> GetForCategoryAsString(Category category);
    }
}
