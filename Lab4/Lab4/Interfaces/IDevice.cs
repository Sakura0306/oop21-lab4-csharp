using Lab4.Models;

namespace Lab4.Interfaces
{
    public interface IDevice
    {
        bool InstallApplication(Application application);
        void InstallBrandApplication(Application application);
    }
}