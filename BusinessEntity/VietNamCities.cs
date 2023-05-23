using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntity
{
    public class VietNamCities
    {
        public static List<City> getAllCities()
        {
            string json = System.IO.File.ReadAllText("vn_cities.json");

            var cities = JsonConvert.DeserializeObject<List<City>>(json);
            cities.Sort();
            return cities;

        }
        public class City : IComparable<City>
        {
            public string name { get; set; }

            public int CompareTo(City other)
            {
               return name.CompareTo(other.name);
            }
        }

        private VietNamCities() { }

    }
    public class GlobalCountries
    {
        private GlobalCountries() { }
        public static List<Country> getAllCCountries()
        {
            string json = System.IO.File.ReadAllText("countries.json");

            var cities = JsonConvert.DeserializeObject<List<Country>>(json);
            cities.Sort();
            return cities;

        }

        public class Country : IComparable<Country>
        {
            public string name { get; set; }

            public string code { get; set; }

            public int CompareTo(Country other)
            {
                return code.CompareTo(other.code);
            }
        }
    }
}
