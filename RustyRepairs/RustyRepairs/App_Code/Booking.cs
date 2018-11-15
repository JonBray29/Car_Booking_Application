using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RustyRepairs.App_Code
{
    public class Booking
    {
        public int BookingID { get; set; }
        public int CustomerID { get; set; }
        public int VehicleID { get; set; }
        public string PaymentMethod { get; set; }
        public string Time { get; set; }
        public string Date { get; set; }

        public Booking(int bookingID, int customerID, int vehicleID, string paymentMethod,
            string time, string date)
        {
            this.BookingID = bookingID;
            this.CustomerID = customerID;
            this.VehicleID = vehicleID;
            this.PaymentMethod = paymentMethod;
            this.Time = time;
            this.Date = date;
        }
    }
}