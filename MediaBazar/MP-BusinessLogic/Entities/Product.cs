using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
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
        public int WarehouseQuantity { get;  set; }
        public int StoreQuantity { get; set; }
        public string UPCcode { get; set; }
        public decimal Weight { get; set;}
        public decimal Height { get; set;}
        public decimal Width { get; set;}



        public Product(int id)
        {
            
        }

        public Product(int id, Category category, SubCategory subCategory, Brand brand, string model, string desciption, decimal price, int warehouseQuantity, string upccode, int storequantity, decimal weight, decimal height, decimal width)
        {
            Id = id;
            Category = category;
            SubCategory = subCategory;
            Brand = brand;
            Model = model;
            Desciption = desciption;
            Price = price;
            WarehouseQuantity = warehouseQuantity;
            UPCcode = upccode;
            StoreQuantity = storequantity;
            Weight = weight;
            Height = height;
            Width = width;
        }

        public Product()
        {

        }

        public string GetObjectString()
        {
            return Id.ToString() + Category.Name + Brand.Name + SubCategory.Name + Model + Price.ToString();
        }
        public bool IsBelowThreshold(int threshold)
        {
            return StoreQuantity < threshold;
        }
        public void IncreaseStoreQuantity(int quantity)
        {
            StoreQuantity += quantity;
        }

        public void DecreaseWarehouseQuantity(int quantity)
        {
            WarehouseQuantity -= quantity;
        }
    }
}
