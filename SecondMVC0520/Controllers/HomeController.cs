using Microsoft.AspNetCore.Mvc;
using SecondMVC0520.DBModels;
using SecondMVC0520.Models;
using SecondMVC0520.Repos;
using SecondMVC0520.Service;
using System.Diagnostics;

namespace SecondMVC0520.Controllers
{
    public class HomeController : Controller
    {
        //注入HomeServices
        private readonly ILogger<HomeController> _logger;
        private readonly HomeServices _homeServices;
        private readonly PrivacyServices _privacyServices;

        public HomeController(ILogger<HomeController> logger, HomeServices homeServices, PrivacyServices privacyServices)
        //public HomeController(ILogger<HomeController> logger, HomeServices homeServices)
        {
            _logger = logger;
            _homeServices = homeServices;
            _privacyServices = privacyServices;
        }

        public IActionResult Index()
        {
            var list = _homeServices.GetBookInfos();
            return View(list);
            //return View();
        }

        public IActionResult Privacy()
        {
            var list2 = _privacyServices.GetNewBookInfos();
            return View(list2);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}