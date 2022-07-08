using TwoDaysProject.Entities.Management;
using TwoDaysProject.Services.ApiServices.NewsApi.Dto;

namespace TwoDaysProject.Core.ViewModels
{
    public class SitePageViewModel
    {
        public IEnumerable<SitePage>? SitePages { get; set; }
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Category { get; set; }
        public SitePage? SitePage { get; set; }
        public NewsApiDto Data { get; set; }
    }
}
