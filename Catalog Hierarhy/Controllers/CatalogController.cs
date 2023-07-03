using Microsoft.AspNetCore.Mvc;
using Catalog_Hierarhy.Models;
using Microsoft.EntityFrameworkCore;

namespace Catalog_Hierarhy.Controllers
{
    public class CatalogController : Controller
    {
        private readonly AppDbContext _context;

        public CatalogController(AppDbContext context)
        {
            _context = context;
        }

        [Route("{**path}")]
        public async Task<IActionResult> Index(string path)
        {
            CatalogViewModel viewModel = new CatalogViewModel();
            if(path ==null)
                return View("Views/Home/Index.cshtml");

            viewModel.Name = path.Split('/').LastOrDefault("");
            viewModel.Path += path;
            viewModel.Id = _context.Catalogs.FirstOrDefault(x => x.Name == viewModel.Name)?.Id;
            viewModel.Children = await _context.Catalogs.Where(x => x.ParentId == viewModel.Id).ToListAsync();

            return View(viewModel);
        }
    }
}
