using System;
using System.Data.Entity;
using System.Linq;

namespace LazyLoading
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //N+1 Problem

            var nPlusOneProblem = new LazyLoadingContext();

            foreach (var cityobj in nPlusOneProblem.Cities)
            {
                Console.WriteLine("{0}\t{1}", cityobj.CityId, cityobj.CityName);

                foreach (var areaobj in cityobj.Areas)
                {
                    Console.WriteLine(areaobj.AreaName);
                }
            }

            Console.WriteLine();

            Console.WriteLine();

            //Eager Loading

            var eagerLoading = new LazyLoadingContext();

            var location = eagerLoading.Cities.Include(c => c.Areas).ToList();

            foreach (var areaNames in location)
            {
                Console.WriteLine("City: {0}", areaNames.CityName);

                foreach (var areaobj in areaNames.Areas)
                {
                    Console.WriteLine("Area: {0}", areaobj.AreaName);
                }
            }

        }
    }
}
