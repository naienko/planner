using System;
using System.Collections.Generic;

namespace Planner
{
    class Program
    {
        static void Main()
        {
            Building BatBuilding = new Building ("212 3rd Ave N") {
                Width = 300,
                Depth = 234,
                Stories = 150
            };
            BatBuilding.Construct();
            BatBuilding.Purchase("Summer Rainault");

            Building Gherkin = new Building ("500 5th Ave S") {
                Width = 130,
                Depth = 130,
                Stories = 125
            };
            Gherkin.Construct();
            Gherkin.Purchase("Delangel Associates");

            Building BongoJava = new Building ("15 Riverfront St") {
                Width = 25,
                Depth = 13,
                Stories = 2
            };
            BongoJava.Construct();
            BongoJava.Purchase("St Cyr Coffee");

            City CentralCity = new City ("Central City", 1842) {
                Mayor = "Barry Allen"
            };

            CentralCity.RegisterBuildings(new List<Building> {
                BatBuilding,
                Gherkin,
            });

            CentralCity.RegisterBuildings(BongoJava);

            Console.WriteLine(CentralCity);
        }
    }
}
