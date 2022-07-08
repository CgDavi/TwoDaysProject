using TwoDaysProject.Entities.Management;

namespace TwoDaysProject.Services.ServiceManagers
{
    public interface ISettingsManager
    {
        public GeneralConfig GetGeneralConfig();
        public void UpdateGeneralConfig(GeneralConfig generalConfig);
    }
}
