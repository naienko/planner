using System;
using System.Collections.Generic;
using System.Text;

namespace Planner
{
	public class City {
		private string _name;

		private int _yearEstablished;

		public List<Building> Buildings { get; private set; } = new List<Building>();

		public string Mayor { get; set; }

		public City (string name, int year) {
			_name = name;
			_yearEstablished = year;
		}

		//overloaded method below -- allows to pass in more than one building at a time
		public void RegisterBuildings (List<Building> buildings) {
			Buildings.AddRange(buildings);
		}

		public void RegisterBuildings (Building buildings) {
			Buildings.Add(buildings);
		}

		public override string ToString() {
			StringBuilder output = new StringBuilder($@"
{_name.ToUpper()}
Mayor: {Mayor}
Year Founded: {_yearEstablished}

Buildings:
");
				Buildings.ForEach(b => output.Append($"{b}\n"));
				return output.ToString();
			}
    }
}
