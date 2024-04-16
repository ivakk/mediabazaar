using MP_DataAccess.DALManagers;
using MP_EntityLibrary;

namespace MP_BusinessLogic.Services
{
    public class ProductService
    {
        ProductDALManager dalManager = new ProductDALManager();
        public List<Product> GetAll()
        {
            return (List<Product>)dalManager.GetAll();
        }
        public Product GetById(int id)
        {
            return (Product)dalManager.Get(id);
        }

        public List<Product> GetBySearch(string search)
        {
            List<Product> result = new List<Product>();
            foreach (Product product in GetAll())
            {
                if (product.GetObjectString().Contains(search))
                {
                    result.Add(product);
                }
            }
            return result;
        }
        public void Create(Product product)
        {
            dalManager.Create(product);
        }
        public void Update(Product product)
        {
            dalManager.Update(product);
        }
        public void Delete(int id)
        {
            dalManager.Delete(id);
        }

    }
}
