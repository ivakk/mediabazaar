using MP_BusinessLogic.InterfacesDal;
using MP_BusinessLogic.InterfacesLL;
using MP_EntityLibrary;

namespace MP_BusinessLogic.Services
{
    public class ProductService : IProductService
    {
        IProductDalManager controller;

        public ProductService(IProductDalManager controller)
        {
            this.controller = controller;
        }
        public List<Product> GetAll()
        {
            return controller.GetAll();
        }
        public Product GetById(int id)
        {
            return controller.GetById(id);
        }

        public List<Product> GetBySearch(string search)
        {
            return controller.GetBySearch(search);
            //List<Product> result = new List<Product>();
            //foreach (Product product in GetAll())
            //{
            //    if (product.GetObjectString().Contains(search))
            //    {
            //        result.Add(product);
            //    }
            //}
            //return result;
        }
        public bool Create(Product product)
        {
            return controller.Create(product);
            //dalManager.Create(product);
        }
        public bool Update(Product product)
        {
            return controller.Update(product);
            //dalManager.Update(product);
        }
        public bool Delete(int id)
        {
            return controller.Delete(id);
            //dalManager.Delete(id);
        }

        public Dictionary<string, int> GetTotalStockQuantity()
        {
            return controller.GetTotalStockQuantity();
        }

        public Dictionary<string, decimal> GetTotalStockValue()
        {
            return controller.GetTotalStockValue();
        }

        public Dictionary<string, (int Store, int Warehouse)> GetWarehouseStoreQuantities() { return controller.GetWarehouseStoreQuantities(); }

        public Dictionary<string, (int Store, int Warehouse)> GetWarehouseStoreQuantitiesByCategoryAndBrand(string category, string brand) { return controller.GetWarehouseStoreQuantitiesByCategoryAndBrand(category, brand); }
        public Dictionary<string, decimal> GetTotalStockValueByCategoryAndBrand(string category, string brand) { return controller.GetTotalStockValueByCategoryAndBrand(category, brand); }
        public Dictionary<string, int> GetTotalStockQuantityByCategoryAndBrand(string category, string brand) { return controller.GetTotalStockQuantityByCategoryAndBrand(category, brand); }

        //ProductDALManager dalManager = new ProductDALManager();
        //public List<Product> GetAll()
        //{
        //    return (List<Product>)dalManager.GetAll();
        //}
        //public Product GetById(int id)
        //{
        //    return (Product)dalManager.Get(id);
        //}

        //public List<Product> GetBySearch(string search)
        //{
        //    List<Product> result = new List<Product>();
        //    foreach (Product product in GetAll())
        //    {
        //        if (product.GetObjectString().Contains(search))
        //        {
        //            result.Add(product);
        //        }
        //    }
        //    return result;
        //}
        //public void Create(Product product)
        //{
        //    dalManager.Create(product);
        //}
        //public void Update(Product product)
        //{
        //    dalManager.Update(product);
        //}
        //public void Delete(int id)
        //{
        //    dalManager.Delete(id);
        //}
    }
}
