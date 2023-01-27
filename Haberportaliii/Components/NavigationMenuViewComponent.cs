using Microsoft.AspNetCore.Mvc;
using System.Linq;
using SportsStore.Models;

namespace SportsStore.Components {

    public class NavigationMenuViewComponent : ViewComponent {
        private IHaberRepository repository;

        public NavigationMenuViewComponent(IHaberRepository repo) {
            repository = repo;
        }

        public IViewComponentResult Invoke() {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(repository.Habers
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
