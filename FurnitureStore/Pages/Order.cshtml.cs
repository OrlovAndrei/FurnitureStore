using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FurnitureStore.Pages
{
    public class OrderModel : PageModel
    {
		private readonly IDbService _dbService;

		public OrderModel(IDbService dbService)
		{
			_dbService = dbService;
		}

		public void OnGet()
        {

        }
    }
}
