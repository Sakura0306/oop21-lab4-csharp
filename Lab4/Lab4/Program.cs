using System;
using Lab4.Models;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            var phone = new Phone();
            phone.OperatingSystem = OS.Android;
            var human = new Human();
            human.Cash = 0.5m;
            human.Phone = phone;
            var application = new Application(OS.iOS, false, "first", 0.1, "boryc");
            var application2 = new Application(OS.Android, true, "second", 1.1, "baka", 0.99m);
            var application3 = new Application(OS.iOS, true, "third", 1.3, "aquateam", 2.99m);
            var application4 = new Application(OS.Android, false, "fourth", 1.0, "barsa");
            var application5 = new Application(OS.Android, false, "fifth", 2.6, "wrongteam");
            var application6 = new Application(OS.iOS, true, "sixth", 2.1, "unknown", 0.49m);
            var application7 = new Application(OS.iOS, false, "seventh", 3.6, "nobody");
            var application8 = new Application(OS.iOS, false, "eigth", 1.3, "mamaraka");
            var application9 = new Application(OS.Android, true, "ninth", 0.3, "neverfinish", 10.99m);
            var application10 = new Application(OS.iOS, false, "tenth", 1.0, "fteam");
            try{
                human.InstallApplication(application4);
                human.InstallApplication(application9);
                human.InstallApplication(application2);
            }
            catch (Exception e){
                Console.WriteLine("There was a problem installing the app");
            }
            try {
                human.InstallApplication(application);
            } catch (Exception e) {
                Console.WriteLine("Unsupported OS");
            }

            human.InstallBrandApplication(application);
            human.InstallBrandApplication(application4);
        }
    }
}