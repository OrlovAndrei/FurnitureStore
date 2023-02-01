using FurnitureStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FurnitureStore.Pages
{
    public class IndexModel : PageModel
    {
        public List<Category> Categories = new List<Category>();

        private readonly ILogger<IndexModel> _logger;
        private readonly IDbService _dbService;

        public IndexModel(ILogger<IndexModel> logger, IDbService dbService)
        {
            _logger = logger;
            _dbService = dbService;
        }

        public void OnGet()
        {
            Categories = _dbService.GetAllCategory();
        }
    }
}