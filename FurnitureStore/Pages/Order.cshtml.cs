using FurnitureStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FurnitureStore.Pages
{
	public class OrderModel : PageModel
    {
		public Product Product;

		private readonly IDbService _dbService;

		public OrderModel(IDbService dbService)
		{
			_dbService = dbService;
		}

		public void OnGet(int id)
		{
			Product = _dbService.GetProductById(id);
		}

		public IActionResult OnPost(int id, int number, string adress)
		{
			Product = _dbService.GetProductById(id);
			_dbService.AddOrder(new Order { ProductId = Product.Id, OrderPrice = Product.Price*number, Number = number, Time = DateTime.UtcNow, Adress = adress });
			return RedirectToPage("Index");
		}
	}
}