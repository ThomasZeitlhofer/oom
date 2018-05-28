using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Newtonsoft.Json;
using System.IO;

namespace OOM_Task4
{
    public class Videogame : Schnittstelle
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

        #region Schnittstelle

        public string Gamename => Name;

        #endregion  

    }

    public class Movie : Schnittstelle
    {
        private string m_name;
        private string m_genre;
        private decimal m_price;

        public Movie(string name, string genre, decimal price)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Name is empty or invalid!");
            if (string.IsNullOrWhiteSpace(genre)) throw new ArgumentException("Genre ist empty or invalid!");

            Name = name;
            Genre = genre;
            Price = price;
        }

        public string Name { get; }

        public string Genre { get; }

        public decimal Price { get; }

        #region Schnittstelle

        public string Gamename => Name;

        #endregion

    }

    public interface Schnittstelle
    {
        string Gamename { get; }
    }
    

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var game1 = new Videogame("Metal Gear Solid", "Stealth", 50);
            var game2 = new Videogame("Super Mario", "Jump'n'Run", 60);
            var movie1 = new Movie("Star Wars", "SciFi", 30);
            var movie2 = new Movie("Isle of Dogs", "SciFi", 20);

            string s1 = JsonConvert.SerializeObject(game1);
            string s2 = JsonConvert.SerializeObject(game2);
            string s3 = JsonConvert.SerializeObject(movie1);
            string s4 = JsonConvert.SerializeObject(movie2);

            Console.WriteLine(s1);
            Console.WriteLine(s3);

            File.WriteAllText(@"C:\Users\Public\movie1.json", JsonConvert.SerializeObject(movie1));

            var desgame1 = JsonConvert.DeserializeObject(s1);
            var desmovie1 = JsonConvert.DeserializeObject(s3);

            Console.WriteLine(desgame1);
            Console.WriteLine(desmovie1);
            
            var filemovie1 = JsonConvert.DeserializeObject<Movie>(File.ReadAllText(@"C:\Users\Public\movie1.json"));

            Console.WriteLine(filemovie1);
            
            Console.WriteLine("Thank you!\n");
        }
    }
}
