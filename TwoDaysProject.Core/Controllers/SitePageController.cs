using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using TwoDaysProject.Core.ViewModels;
using TwoDaysProject.Entities.Management;
using TwoDaysProject.Services.ApiServices.NewsApi;
using TwoDaysProject.Services.ServiceManagers;

namespace TwoDaysProject.Core.Controllers
{
    public class SitePageController : Controller
    {
        private readonly ILogger<SitePageController> _logger;
        private readonly ISitePageManager _sitePageManager;
        private readonly INewsApiManager _apiManager;
        private readonly ISettingsManager _settingsManager;

        public SitePageController(ILogger<SitePageController> logger, ISitePageManager sitePageManager, INewsApiManager apiManager, ISettingsManager settingsManager)
        {
            _logger = logger;
            _sitePageManager = sitePageManager;
            _apiManager = apiManager;
            _settingsManager = settingsManager;
        }

        public IActionResult Index()
        {
            var model = new SettingsViewModel();
            model.SitePages = _sitePageManager.GetSitePages();
            model.GeneralConfig = _settingsManager.GetGeneralConfig();
            model.ApiKey = model.GeneralConfig.ApiKey;
            return View(model);
        }
        [HttpPost]
        public IActionResult UpdateApiKey(SettingsViewModel model)
        {
            model.GeneralConfig = _settingsManager.GetGeneralConfig();
            model.GeneralConfig.ApiKey = model.ApiKey;
            _settingsManager.UpdateGeneralConfig(model.GeneralConfig);
            return RedirectToAction("Index");
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(SitePageViewModel model)
        {
            var sitePage = new SitePage();
            sitePage.Title = model.Title;
            sitePage.Category = model.Category;
            _sitePageManager.SaveSitePage(sitePage);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int Id)
        {
            var model = new SitePageViewModel();
            model.SitePage = _sitePageManager.GetSitePageById(Id);
            model.Id = model.SitePage.Id;
            model.Title = model.SitePage?.Title;
            model.Category = model.SitePage?.Category;
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(SitePageViewModel model)
        {
            var sitePage = _sitePageManager.GetSitePageById(model.Id);
            sitePage.Title = model.Title;
            sitePage.Category = model.Category;
            _sitePageManager.UpdateSitePage(sitePage);
            return RedirectToAction("Index");
        }
        public IActionResult Details(int Id)
        {
            var model = new SitePageViewModel();
            model.SitePage = _sitePageManager.GetSitePageById(Id);
            model.GeneralConfig = _settingsManager.GetGeneralConfig();
            model.Data = _apiManager.GetArticles(model.GeneralConfig?.ApiKey, model.SitePage?.Category);
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}