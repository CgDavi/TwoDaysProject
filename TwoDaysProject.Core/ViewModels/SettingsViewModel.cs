using TwoDaysProject.Entities.Management;

namespace TwoDaysProject.Core.ViewModels
{
    public class SettingsViewModel
    {
        public IEnumerable<SitePage>? SitePages { get; set; }
        public GeneralConfig? GeneralConfig { get; set; }
        public string? ApiKey { get; set; }
    }
}
