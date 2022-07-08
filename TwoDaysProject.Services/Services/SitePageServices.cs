using Microsoft.EntityFrameworkCore;
using TwoDaysProject.Database;
using TwoDaysProject.Entities.Management;
using TwoDaysProject.Services.ServiceManagers;

namespace TwoDaysProject.Services.Services
{
    public class SitePageServices : ISitePageManager
    {
        private readonly CustomDbContext _context;
        public SitePageServices(CustomDbContext context)
        {
            _context = context;
        }
        public IEnumerable<SitePage> GetSitePages()
        {
            return _context.SitePages;
        }
        public SitePage GetSitePageById(int Id)
        {
            return _context.SitePages.Find(Id);
        }
        public void SaveSitePage(SitePage sitePage)
        {
            _context.SitePages.Add(sitePage);
            _context.SaveChanges();
        }
        public void UpdateSitePage(SitePage sitePage)
        {
            _context.Entry(sitePage).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
