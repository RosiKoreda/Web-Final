using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using System.Linq;
using SportsStore.Models.ViewModels;

namespace SportsStore.Controllers {
    public class HomeController : Controller {
        private IHaberRepository repository;
        public int PageSize = 4;
        private readonly HaberDbContext _db;
        public HomeController(IHaberRepository repo, HaberDbContext db) {
            repository = repo;
            _db = db;
        }
       
        public IActionResult HaberDetay(long id)
        {
            var item = _db.Habers.Find(id);            
            return View(item);
        }
        public ViewResult Index(string category, int haberPage = 1)
            => View(new HabersListViewModel {
                Habers = repository.Habers
                    .Where(h => category == null || h.Category == category)
                    .OrderBy(h => h.HaberID)
                    .Skip((haberPage - 1) * PageSize),
                    
                PagingInfo = new PagingInfo {
                    CurrentPage = haberPage,
                    ItemsPerPage = PageSize,
                    TotalItems = category == null ?
                        repository.Habers.Count() :
                        repository.Habers.Where(e =>
                            e.Category == category).Count()
                },
                CurrentCategory = category
            });
    }
}
