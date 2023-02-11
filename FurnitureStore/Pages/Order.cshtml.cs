using FurnitureStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace FurnitureStore.Pages
{
	public class OrderModel : PageModel
	{
		[BindProperty]
		public InputModel Input { get; set; }
		public Product Product { get; set; }

		private readonly IDbService _dbService;

		public OrderModel(IDbService dbService)
		{
			_dbService = dbService;
		}

		public void OnGet(int id)
		{
			Product = _dbService.GetProductById(id);
		}

		public IActionResult OnPost(int id)
		{
			if (!ModelState.IsValid)
			{
				OnGet(id);
				return Page();
			}

			Product = _dbService.GetProductById(id);
			_dbService.AddOrder(new Order
			{
				ProductId = Product.Id,
				OrderPrice = Product.Price * Input.Number,
				Number = Input.Number,
				Time = DateTime.UtcNow,
				Adress = Input.Adress
			});
			return RedirectToPage("Index");
		}

		public class InputModel
		{
			[Required]
			[Display(Name = "Количество:")]
			[Range(0, 100)]
			public int Number { get; set; }

			[Required]
			[Display(Name = "Адресс:")]
			public string Adress { get; set; }
		}
	}
}