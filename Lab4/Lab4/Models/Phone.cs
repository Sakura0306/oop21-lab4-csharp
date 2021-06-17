using System;
using System.Collections.Generic;
using Lab4.Interfaces;

namespace Lab4.Models
{
    public class Phone : IDevice
    {
        public List<Brands> Brands { get; set; }
        public string Model { get; set; }
        public OS OperatingSystem { get; set; }
        private List<Application> _installedApplications;

        public Phone() {
            _installedApplications = new List<Application>();
        }

        public bool InstallApplication(Application application) {
            if (_installedApplications.Contains(application)) {
                Application found = _installedApplications[_installedApplications.IndexOf(application)];
                if (found.Version >= application.Version) {
                    return false;
                } else {
                    _installedApplications.Remove(found);
                    _installedApplications.Add(application);
                    return true;
                }
            }

            if (application.SupportedOS == OperatingSystem) {
                _installedApplications.Add(application);
                return true;
            }
            return false;
        }

        public void InstallBrandApplication(Application application) {
            if (application.SupportedOS == this.OperatingSystem) {
                InstallApplication(application);
            } else {
                Console.WriteLine("Not supported OS");
            }
        }
    }
}