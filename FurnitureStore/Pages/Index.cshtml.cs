using FurnitureStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FurnitureStore.Pages
{
    public class IndexModel : PageModel
    {
        public List<Category> Categories = new List<Category>();

        private readonly IDbService _dbService;

        public IndexModel(IDbService dbService)
        {
            _dbService = dbService;
        }

        public void OnGet()
        {
            Categories = _dbService.GetAllCategory();
        }
    }
}