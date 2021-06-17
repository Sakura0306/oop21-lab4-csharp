using System;
using Lab4.Interfaces;

namespace Lab4.Models
{
    public class Human
    {
        public decimal Cash { get; set; }
        public IDevice Phone { get; set; }

        public bool InstallApplication(Application application)
        {
            if (application.Paid) {
                if (this.Cash >= application.Price) {
                    return Phone.InstallApplication(application);
                }
            } else {
                return false;
            }
            return Phone.InstallApplication(application);
        }

        public void InstallBrandApplication(Application application) {
            if (application.Paid) {
                if (this.Cash >= application.Price) {
                    Phone.InstallBrandApplication(application);
                }
            } else {
                Console.WriteLine("Something went wrong");
            }
            Phone.InstallBrandApplication(application);
        }
    }
}