using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RustyRepairs.App_Code
{
    public class Vehicle
    {
        public int VehicleID{ get; set; }
        public int CustomerID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Registration { get; set; }
        public string Colour { get; set; }
        public string Notes { get; set; }

        public Vehicle(int vehicleID, int customerID, string make, string model, string registration, string colour, string notes)
        {
            this.VehicleID = vehicleID;
            this.CustomerID = customerID;
            this.Make = make;
            this.Model = model;
            this.Registration = registration;
            this.Colour = colour;
            this.Notes = notes;
        }
    }
}
