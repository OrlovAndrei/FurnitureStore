using FurnitureStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FurnitureStore.Pages
{
    public class ProductsModel : PageModel
    {
		public List<Product> Products = new List<Product>();
		public string CategoryName;

		private readonly IDbService _dbService;

		public ProductsModel(IDbService dbService)
		{
			_dbService = dbService;
		}

		public void OnGet(string name)
        {
			Products = _dbService.GetAllProductsByCategory(name);
			CategoryName = name;
        }
    }
}