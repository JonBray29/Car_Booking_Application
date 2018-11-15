using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace RustyRepairs.App_Code
{
    public class Utilities
    {
        public static List<Booking> ReadBookings()
        {
            using (StreamReader sr = new StreamReader(System.Web.Hosting.HostingEnvironment.MapPath(@"~/JSON/bookings.json")))
            {
                return JsonConvert.DeserializeObject<List<Booking>>(sr.ReadToEnd());
            }
        }

        public static Booking GetBookingFromBookingID(int id)
        {
            List<Booking> bookings = ReadBookings();
            foreach (Booking booking in bookings)
            {
                if (booking.BookingID == id)
                {
                    return booking;
                }
            }
            return null;
        }

        public static void AddBooking(Booking booking)
        {
            List<Booking> bookings = ReadBookings();
            bookings.Add(booking);
            SaveBookings(bookings);
        }

        public static void UpdateBooking(Booking booking)
        {
            List<Booking> bookings = ReadBookings();
            Booking toUpdate = null;
            for (int i = 0; i < bookings.Count; i++)
            {
                toUpdate = bookings[i];
                if (toUpdate.BookingID == booking.BookingID)
                    break;
            }

            bookings.Remove(toUpdate);
            bookings.Add(booking);
            SaveBookings(bookings);
        }

        public static void RemoveBooking(Booking booking)
        {
            List<Booking> bookings = ReadBookings();
            Booking toUpdate = null;
            for (int i = 0; i < bookings.Count; i++)
            {
                toUpdate = bookings[i];
                if (toUpdate.BookingID == booking.BookingID)
                    break;
            }

            bookings.Remove(toUpdate);
            SaveBookings(bookings);
        }

        public static void SaveBookings(List<Booking> bookings)
        {
            string updatedCustomerData = JsonConvert.SerializeObject(bookings, Formatting.Indented);
            File.WriteAllText(System.Web.Hosting.HostingEnvironment.MapPath(@"~/JSON/bookings.json"), updatedCustomerData);
        }

        public static List<Customer> ReadCustomers()
        {
            using (StreamReader sr = new StreamReader(System.Web.Hosting.HostingEnvironment.MapPath(@"~/JSON/customers.json")))
            {
                return JsonConvert.DeserializeObject<List<Customer>>(sr.ReadToEnd());
            }
        }

        public static Customer GetCustomerFromCustomerID(int id)
        {
            List<Customer> customers = ReadCustomers();
            foreach (Customer cust in customers)
            {
                if (cust.CustomerID == id)
                    return cust;
            }
            return null;
        }

        public static List<Vehicle> ReadVehicles()
        {
            using (StreamReader sr = new StreamReader(System.Web.Hosting.HostingEnvironment.MapPath(@"~/JSON/vehicles.json")))
            {
                return JsonConvert.DeserializeObject<List<Vehicle>>(sr.ReadToEnd());
            }
        }

        public static void AddVehicle(Vehicle vehicle)
        {
            List<Vehicle> vehicles = ReadVehicles();
            vehicles.Add(vehicle);
            SaveVehicles(vehicles);
        }

        public static void UpdateVehicle(Vehicle vehicle)
        {
            List<Vehicle> vehicles = ReadVehicles();
            Vehicle toUpdate = null;
            for (int i = 0; i < vehicles.Count; i++)
            {
                toUpdate = vehicles[i];
                if (toUpdate.VehicleID == vehicle.VehicleID)
                    break;
            }

            vehicles.Remove(toUpdate);
            vehicles.Add(vehicle);
            SaveVehicles(vehicles);
        }

        public static void SaveVehicles(List<Vehicle> vehicles)
        {
            string updatedCustomerData = JsonConvert.SerializeObject(vehicles, Formatting.Indented);
            File.WriteAllText(System.Web.Hosting.HostingEnvironment.MapPath(@"~/JSON/vehicles.json"), updatedCustomerData);
        }

        public static Vehicle GetVehicleFromVehicleID(int id)
        {
            List<Vehicle> vehicles = ReadVehicles();
            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle.VehicleID == id)
                    return vehicle;
            }
            return null;
        }

        public static List<Vehicle> GetVehiclesFromCustomerID(int id)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            List<Vehicle> allVehicles = ReadVehicles();
            foreach (Vehicle vehicle in allVehicles)
            {
                if (vehicle.CustomerID == id)
                {
                    vehicles.Add(vehicle);
                }
            }

            return vehicles;
        }

        private static object objLock = new object();
        private static Random rnd = new Random();
        public static int RandomNumber(int max)
        {
            lock (objLock)
                return rnd.Next(max);
        }
    }
}