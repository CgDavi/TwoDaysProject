using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using TwoDaysProject.Core.ViewModels;
using TwoDaysProject.Entities.Management;
using TwoDaysProject.Services.ServiceManagers;

namespace TwoDaysProject.Core.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISitePageManager _sitePageManager;

        public HomeController(ILogger<HomeController> logger, ISitePageManager sitePageManager)
        {
            _logger = logger;
            _sitePageManager = sitePageManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}