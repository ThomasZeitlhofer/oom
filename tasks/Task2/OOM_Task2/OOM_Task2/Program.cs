using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOM_Task2
{
    public class Videogame
    {
        private string g_name;
        private string g_genre;
        private decimal g_price;

        public Videogame(string name, string genre, decimal price)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Name is empty or invalid!");
            if (string.IsNullOrWhiteSpace(genre)) throw new ArgumentException("Genre ist empty or invalid!");

            g_name = name;
            g_genre = genre;
            SetPrice(price);
        }
        
        public string Name
        {
            get
            {
                return g_name;
            }
        }

        public string Genre
        {
            get
            {
                return g_genre;
            }
        }

        public decimal Price
        {
            get
            {
                return g_price;
            }
            private set
            {
                if (g_price < 0) throw new ArgumentException("Price is invalid!");

                g_price = value;
            }
        }

        public void SetPrice(decimal newprice)
        {
            if (newprice < 0) throw new ArgumentException("Price is invalid!");

            g_price = newprice;
        }

    }
    

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Videogame God_of_War = new Videogame("God of War", "Action", 50);
            Videogame Metal_Gear_Solid = new Videogame("Metal Gear Solid", "Stealth", 30);
            Videogame Europa_Universalis = new Videogame("Europa Universalis", "Strategy", 20);

            Console.WriteLine(God_of_War.Name);
            Console.WriteLine(God_of_War.Genre);

            Console.WriteLine(Metal_Gear_Solid.Name);
            Console.WriteLine(Metal_Gear_Solid.Genre);
            Console.WriteLine(Metal_Gear_Solid.Price);

            Metal_Gear_Solid.SetPrice(60);

            Console.WriteLine(Metal_Gear_Solid.Price);

            Metal_Gear_Solid.SetPrice(10);

            Console.WriteLine(Metal_Gear_Solid.Price);

            Console.WriteLine("Thank you!\n");
        }
    }
}
