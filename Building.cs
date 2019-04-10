using System;

namespace Planner
{
    public class Building
    {
		//some private fields to be filled either with hardcode (_designer) or via methods on the class
		private string _designer = "Panya";

		private DateTime _dateConstructed;

		private string _address;

		private string _owner;

		// some public fields to be filled by Building.(field) when the class is invoked in a program
		public int Stories { get; set; }

		public double Width { get; set; }

		public double Depth { get; set; }

		public double Volume {
			get {
				return Width * Depth * (3 * Stories);
			}
		}

		//some public methods on the class
		public Building (string address) {
			// private _address originates as empty -- this constructor requires the end-user to send as parameter when creating Building class object
			_address = address;
		}

		public Building Construct() {
			// private _dateConstructed originates as empty -- this constructor method grabs the current datetime and stores it when creating Buliding class object
			_dateConstructed = DateTime.Now;
			return this;
		}

		public Building Purchase( string purchaser ) {
			// private _owner originates as empty -- this constructor method takes a variable when creating Building class object
			_owner = purchaser;
			return this;
		}

		public override string ToString() {
			//overload means to use the same method name twice
			//override is a keyword that allows using the same method name twice -- it adds a new function to the method
			//@ symbol declares permission to put line breaks in string (see `` in JS)
			return $@"
{_address}
-----------------------
Designed by {_designer}
Constructed on {_dateConstructed}
Owned by {_owner}
{Volume} cubic meters of space.";
		}
    }
}