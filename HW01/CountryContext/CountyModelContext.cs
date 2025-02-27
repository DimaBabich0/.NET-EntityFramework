using CountryModel;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

namespace CountryModelContext
{
    public class CountryContext : DbContext
    {
        public CountryContext()
        {
            if (Database.EnsureCreated())
            {
                Continent con1 = new Continent { Name = "North America" };
                Continent con2 = new Continent { Name = "Europe" };
                Continent con3 = new Continent { Name = "Africa" };
                Continents?.Add(con1);
                Continents?.Add(con2);
                Continents?.Add(con3);

                Countries?.Add(new Country
                {
                    Name = "Canada",
                    Capital = "Ottawa",
                    Population = 38014184,
                    Area = 9984670,
                    Continent = con1
                });
                Countries?.Add(new Country
                {
                    Name = "Ukraine",
                    Capital = "Kyiv",
                    Population = 33443000,
                    Area = 603628,
                    Continent = con2
                });
                Countries?.Add(new Country
                {
                    Name = "Morocco",
                    Capital = "Rabat",
                    Population = 37493183,
                    Area = 446550,
                    Continent = con3
                });
                SaveChanges();
            }
        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Continent> Continents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(@"Server=DESKTOP-REVRHUK;Database=CountryDB;Integrated Security=SSPI;TrustServerCertificate=true");
        }
    }
}
