using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MP_BusinessLogic.InterfacesLL;

namespace MP_WebApplication.Pages
{
    public class StockStatisticModel : PageModel
    {
        private readonly IProductService productService;

        public StockStatisticModel(IProductService productService)
        {
            this.productService = productService;
        }

        public Dictionary<string, int> TotalStockQuantity { get; set; }
        public Dictionary<string, decimal> TotalStockValue { get; set; }
        public Dictionary<string, (int Store, int Warehouse)> WarehouseStoreQuantities { get; set; }
        public string[] ProductModels { get; set; }
        public int[] StockQuantities { get; set; }
        public decimal[] StockValues { get; set; }
        public int[] StoreQuantities { get; set; }
        public int[] WarehouseQuantities { get; set; }

        public void OnGet()
        {
            TotalStockQuantity = productService.GetTotalStockQuantity();
            TotalStockValue = productService.GetTotalStockValue();
            WarehouseStoreQuantities = productService.GetWarehouseStoreQuantities();

            ProductModels = TotalStockQuantity.Keys.ToArray();
            StockQuantities = TotalStockQuantity.Values.ToArray();
            StockValues = TotalStockValue.Values.ToArray();
            StoreQuantities = WarehouseStoreQuantities.Values.Select(q => q.Store).ToArray();
            WarehouseQuantities = WarehouseStoreQuantities.Values.Select(q => q.Warehouse).ToArray();
        }
    }
}
