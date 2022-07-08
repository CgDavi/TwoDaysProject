using Microsoft.EntityFrameworkCore;
using TwoDaysProject.Database;
using TwoDaysProject.Entities.Management;
using TwoDaysProject.Services.ServiceManagers;

namespace TwoDaysProject.Services.Services
{
    public class SettingsServices : ISettingsManager
    {
        private readonly CustomDbContext _context;
        public SettingsServices(CustomDbContext context)
        {
            _context = context;
        }
        public GeneralConfig GetGeneralConfig()
        {
            return _context.GeneralConfigs.FirstOrDefault();
        }
        public void UpdateGeneralConfig(GeneralConfig generalConfig)
        {
            _context.Entry(generalConfig).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
