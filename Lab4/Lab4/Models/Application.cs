using Lab4.Models;

namespace Lab4.Models
{
    public class Application
    {
        public OS SupportedOS;
        public bool Paid;
        public string Name;
        public double Version;
        public string Author;
        public decimal Price;

        protected Application() { 
        }

        public Application(OS SupportedOS , bool Paid, string Name, double Version, string Author, decimal Price = 0.0m) {
            this.SupportedOS = SupportedOS;
            this.Paid = Paid;
            this.Name = Name;
            this.Version = Version;
            this.Author = Author;
            if (Paid == false && Price > 0.0m)
                this.Price = 0.0m;
            else
                this.Price = Price;
        }
    }
}