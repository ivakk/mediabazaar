using MP_DataAccess.DALManagers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP_EntityLibrary
{
    
    public class Product
    {
        public int Id { get; private set; }
        public Category Category { get; private set; }
        public SubCategory SubCategory { get; private set; }
        public Brand Brand { get; private set; }
        public string Model { get; private set; }
        public string Desciption { get; private set; }
        public decimal Price { get; private set; }
        public int WarehouseQuantity { get; private set; }


        public Product(int id)
        {
            
        }

        public Product(int id, Category category, SubCategory subCategory, Brand brand, string model, string desciption, decimal price, int warehouseQuantity)
        {
            Id = id;
            Category = category;
            SubCategory = subCategory;
            Brand = brand;
            Model = model;
            Desciption = desciption;
            Price = price;
            WarehouseQuantity = warehouseQuantity;
        }

        public Product()
        {

        }

        public string GetObjectString()
        {
            return Id.ToString() + Category.Name + Brand.Name + SubCategory.Name +Model + Price.ToString();
        }
    }
}
