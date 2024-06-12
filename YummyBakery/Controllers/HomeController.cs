using Microsoft.AspNetCore.Mvc;
using YummyBakery.Models;
using YummyBakery.ViewModels;

namespace YummyBakery.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        public IActionResult Index()
        {
            var piesOfTheWeek = _pieRepository.PiesOfTheWeek;
            var homeViewModel = new HomeViewModel(piesOfTheWeek);
            return View(homeViewModel); 
        }
    }
}
