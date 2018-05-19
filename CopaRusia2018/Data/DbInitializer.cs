using CopaRusia2018.Models;
using System;
using System.Linq;

namespace CopaRusia2018.Data
{
    public static class DbInitializer
    {
        public static void Initialize(WorldCupContext context)
        {
            context.Database.EnsureCreated();
            // Look for any countries.
            if (context.Countries.Any())
            {
                return; // DB has been seeded
            }
            //            var countries = new Country[]
            //            {
            //            new
            //            Country{ CountryID=1, Name ="Rusia", Continent = Continent.Europe, Foundation=DateTime.Parse("2005-09-01"), Players =new List<Player>()},
            //            new
            //            Country{ CountryID=2, Name ="Argentina", Continent = Continent.America, Foundation=DateTime.Parse("2005-09-01"), Players =new List<Player>()},
            //            new
            //            Country{ CountryID=3, Name ="Brasil", Continent = Continent.America, Foundation=DateTime.Parse("2005-09-01"), Players =new List<Player>()},
            //            new
            //            Country{ CountryID=4, Name ="Alemania", Continent = Continent.Europe, Foundation=DateTime.Parse("2005-09-01"), Players =new List<Player>()},
            //            new
            //            Country{ CountryID=5, Name ="Nigeria", Continent = Continent.Africa, Foundation=DateTime.Parse("2005-09-01"), Players =new List<Player>()},
            //            new
            //            Country{ CountryID=6, Name ="USA", Continent = Continent.America, Foundation=DateTime.Parse("2005-09-01"), Players =new List<Player>()},
            //            new
            //            Country{ CountryID=7, Name ="Mexico", Continent = Continent.America, Foundation=DateTime.Parse("2005-09-01"), Players =new List<Player>()},
            //            new
            //            Country{ CountryID=8, Name ="Francia", Continent = Continent.Europe, Foundation=DateTime.Parse("2005-09-01"), Players =new List<Player>()}
            //};

            //SIN PLAYERS

            //            var countries = new Country[]
            //{
            //                        new
            //                        Country{ ID=1, Name ="Rusia", Continent = Continent.Europe, Foundation=DateTime.Parse("2005-09-01")},
            //                        new
            //                        Country{ ID=2, Name ="Argentina", Continent = Continent.America, Foundation=DateTime.Parse("2005-09-01")},
            //                        new
            //                        Country{ ID=3, Name ="Brasil", Continent = Continent.America, Foundation=DateTime.Parse("2005-09-01")},
            //                        new
            //                        Country{ ID=4, Name ="Alemania", Continent = Continent.Europe, Foundation=DateTime.Parse("2005-09-01")},
            //                        new
            //                        Country{ ID=5, Name ="Nigeria", Continent = Continent.Africa, Foundation=DateTime.Parse("2005-09-01")},
            //                        new
            //                        Country{ ID=6, Name ="USA", Continent = Continent.America, Foundation=DateTime.Parse("2005-09-01")},
            //                        new
            //                        Country{ ID=7, Name ="Mexico", Continent = Continent.America, Foundation=DateTime.Parse("2005-09-01")},
            //                        new
            //                        Country{ ID=8, Name ="Francia", Continent = Continent.Europe, Foundation=DateTime.Parse("2005-09-01")}
            //};

            //sin COUNTRY ID
            //            var countries = new Country[]
            //{
            //                        new
            //                        Country{Name ="Rusia",Continent = Continent.Europe, Foundation=DateTime.Parse("2005-09-01")},
            //                        new
            //                        Country{Name ="Argentina", Continent = Continent.America, Foundation=DateTime.Parse("2005-09-01")},
            //                        new
            //                        Country{Name ="Brasil", Continent = Continent.America, Foundation=DateTime.Parse("2005-09-01")},
            //                        new
            //                        Country{Name ="Alemania", Continent = Continent.Europe, Foundation=DateTime.Parse("2005-09-01")},
            //                        new
            //                        Country{Name ="Nigeria", Continent = Continent.Africa, Foundation=DateTime.Parse("2005-09-01")},
            //                        new
            //                        Country{Name ="USA", Continent = Continent.America, Foundation=DateTime.Parse("2005-09-01")},
            //                        new
            //                        Country{Name ="Mexico", Continent = Continent.America, Foundation=DateTime.Parse("2005-09-01")},
            //                        new
            //                        Country{Name ="Francia", Continent = Continent.Europe, Foundation=DateTime.Parse("2005-09-01")}
            //};

            var countries = new Country[]
{
                        new Country{Name ="Rusia",Continent = "Europe",Foundation=DateTime.Parse("2005-09-01")},
                        new Country{Name ="Mexico",Continent = "America",Foundation=DateTime.Parse("2005-09-01")},
                        new Country{Name ="Alemania",Continent = "Europe",Foundation=DateTime.Parse("2005-09-01")}
};


            foreach (Country s in countries)
            {
                context.Countries.Add(s);
            }
            context.SaveChanges();
           
        }
    }
}
