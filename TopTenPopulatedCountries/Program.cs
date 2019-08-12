using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopTenPopulatedCountries;

namespace Pluralsight.BegCShCollections.TopTenPops
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\c775434\Documents\TopTenPopulatedCountries\TopTenPopulatedCountries\Pop by Largest Final.csv";
            CsvReader reader = new CsvReader(filePath);

            Country[] countries = reader.ReadFirstNCountries(10);

            foreach (Country country in countries)
            {
                Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            }
        }
    }
}


