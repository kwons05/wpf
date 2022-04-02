using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class ViewModel
    {
        public ViewModel()
        {
            this.Countries = new List<Country>();
            this.Countries.Add(new Country { Name = "Germany", Continent = "Europe" });
            this.Countries.Add(new Country { Name = "United Kingdom", Continent = "Europe" });
            this.Countries.Add(new Country { Name = "France", Continent = "Europe" });
            this.Countries.Add(new Country { Name = "USA", Continent = "North America" });
            this.Countries.Add(new Country { Name = "Canada", Continent = "North America" });
        }

        public IList<Country> Countries { get; private set; }
    }

    public class Country
    {
        public string Name { get; set; }
        public string Continent { get; set; }
    }
}
