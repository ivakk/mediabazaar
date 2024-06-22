using MP_EntityLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP_BusinessLogic.InterfacesLL
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetById(int id);
        List<Product> GetBySearch(string search);
        bool Create(Product product);
        bool Update(Product product);
        bool Delete(int id);

        public Dictionary<string, int> GetTotalStockQuantity();
        public Dictionary<string, decimal> GetTotalStockValue();
        public Dictionary<string, (int Store, int Warehouse)> GetWarehouseStoreQuantities();
        public Dictionary<string, (int Store, int Warehouse)> GetWarehouseStoreQuantitiesByCategoryAndBrand(string category, string brand);
        public Dictionary<string, decimal> GetTotalStockValueByCategoryAndBrand(string category, string brand);
        public Dictionary<string, int> GetTotalStockQuantityByCategoryAndBrand(string category, string brand);
    }
}
