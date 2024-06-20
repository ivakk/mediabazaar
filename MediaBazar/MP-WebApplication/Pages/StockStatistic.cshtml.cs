using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MP_BusinessLogic.InterfacesLL;
using MP_EntityLibrary;
using System.Collections.Generic;
using System.Linq;

namespace MP_WebApplication.Pages
{
    public class StockStatisticModel : PageModel
    {
        private readonly IProductService productService;
        private readonly ICategoryService categoryService;
        private readonly IBrandService brandService;

        public StockStatisticModel(IProductService productService, ICategoryService categoryService, IBrandService brandService)
        {
            this.productService = productService;
            this.categoryService = categoryService;
            this.brandService = brandService;
        }

        public List<Category> Categories { get; set; }
        public List<Brand> Brands { get; set; }
        public string DiagramType { get; set; }
        public string[] ProductModels { get; set; }
        public int[] StockQuantities { get; set; }
        public decimal[] StockValues { get; set; }
        public int[] StoreQuantities { get; set; }
        public int[] WarehouseQuantities { get; set; }

        /* To be removed*/
        public Dictionary<string, int> TotalStockQuantity { get; set; }
        public Dictionary<string, decimal> TotalStockValue { get; set; }
        public Dictionary<string, (int Store, int Warehouse)> WarehouseStoreQuantities { get; set; }


        public void OnGet(string category = null, string brand = null, string diagramType = null)
        {
            TotalStockQuantity = productService.GetTotalStockQuantity();
            TotalStockValue = productService.GetTotalStockValue();
            WarehouseStoreQuantities = productService.GetWarehouseStoreQuantities();

            ProductModels = TotalStockQuantity.Keys.ToArray();
            StockQuantities = TotalStockQuantity.Values.ToArray();
            StockValues = TotalStockValue.Values.ToArray();
            StoreQuantities = WarehouseStoreQuantities.Values.Select(q => q.Store).ToArray();
            WarehouseQuantities = WarehouseStoreQuantities.Values.Select(q => q.Warehouse).ToArray();


            Categories = categoryService.GetAll();
            Brands = brandService.GetAll();
            DiagramType = diagramType;

            if (!string.IsNullOrEmpty(category) && !string.IsNullOrEmpty(brand) && !string.IsNullOrEmpty(diagramType))
            {
                switch (diagramType)
                {
                    case "TotalStockQuantity":
                        var totalStockQuantity = productService.GetTotalStockQuantityByCategoryAndBrand(category, brand);
                        ProductModels = totalStockQuantity.Keys.ToArray();
                        StockQuantities = totalStockQuantity.Values.ToArray();
                        break;

                    case "TotalStockValue":
                        var totalStockValue = productService.GetTotalStockValueByCategoryAndBrand(category, brand);
                        ProductModels = totalStockValue.Keys.ToArray();
                        StockValues = totalStockValue.Values.ToArray();
                        break;

                    case "WarehouseStoreQuantities":
                        var warehouseStoreQuantities = productService.GetWarehouseStoreQuantitiesByCategoryAndBrand(category, brand);
                        ProductModels = warehouseStoreQuantities.Keys.ToArray();
                        StoreQuantities = warehouseStoreQuantities.Values.Select(q => q.Store).ToArray();
                        WarehouseQuantities = warehouseStoreQuantities.Values.Select(q => q.Warehouse).ToArray();
                        break;
                }
            }
        }
    }
}
