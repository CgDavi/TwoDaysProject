using TwoDaysProject.Entities.Common;

namespace TwoDaysProject.Entities.Management
{
    public class SitePage : BaseEntity
    {
        public string? Title { get; set; }
        public int ResultsNumber { get; set; }
    }
}
