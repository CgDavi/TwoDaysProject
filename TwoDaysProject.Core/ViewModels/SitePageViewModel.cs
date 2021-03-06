using TwoDaysProject.Entities.Management;
using TwoDaysProject.Services.ApiServices.NewsApi.Dto;

namespace TwoDaysProject.Core.ViewModels
{
    public class SitePageViewModel
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public SitePage? SitePage { get; set; }
        public NewsApiDto? Data { get; set; }
        public string? ApiKey { get; set; }
        public int ResultsNumber { get; set; }
        public GeneralConfig? GeneralConfig { get; set; }
    }
}
