using TwoDaysProject.Entities.Management;

namespace TwoDaysProject.Services.ServiceManagers
{
    public interface ISitePageManager
    {
        public IEnumerable<SitePage> GetSitePages();
        public SitePage GetSitePageById(int Id);
        public void SaveSitePage(SitePage sitePage);
        public void UpdateSitePage(SitePage sitePage);
    }
}
