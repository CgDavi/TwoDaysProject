using Microsoft.AspNetCore.Mvc;
using TwoDaysProject.Core.ViewModels;
using TwoDaysProject.Services.ServiceManagers;

namespace TwoDaysProject.Web.ViewComponents.MainMenuViewComponent
{
    public class MainMenuViewComponent : ViewComponent
    {
        private IHttpContextAccessor _httpContextAccessor;
        private readonly ISitePageManager _sitePageManager;
        public MainMenuViewComponent(IHttpContextAccessor httpContextAccessor, ISitePageManager sitePageManager)
        {
            _httpContextAccessor = httpContextAccessor;
            _sitePageManager = sitePageManager;
        }
        public IViewComponentResult Invoke()
        {
            var user = _httpContextAccessor.HttpContext?.User;
            var model = new MainMenuViewModel();
            model.SitePages = _sitePageManager.GetSitePages();
            return View(model);
        }
    }
}
