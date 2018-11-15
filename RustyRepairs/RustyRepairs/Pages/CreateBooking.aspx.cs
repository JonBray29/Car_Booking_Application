using RustyRepairs.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_CreateBooking : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.btnBack.Click += BtnBack_Click;
        this.btnCreate.Click += BtnCreate_Click;
    }

    private void BtnCreate_Click(object sender, EventArgs e)
    {
        List<Customer> customers = Utilities.ReadCustomers();
        Customer randomCustomer = customers[Utilities.RandomNumber(customers.Count)];

        List<Booking> bookings = Utilities.ReadBookings();
        List<Vehicle> vehicles = Utilities.ReadVehicles();
        Vehicle newVehicle = new Vehicle(vehicles.Count + 1, randomCustomer.CustomerID, this.txtVehicleMake.Text, this.txtVehicleModel.Text, this.txtVehicleRegistration.Text,
            this.txtCarColour.Text, this.txtCarNotes.Text);

        Utilities.AddVehicle(newVehicle);

        Booking booking = new Booking(bookings.Count + 1, randomCustomer.CustomerID, newVehicle.VehicleID, this.txtCarNotes.Text, this.txtTime.Text, this.txtDate.Text);
        Utilities.AddBooking(booking);
        Response.Redirect("~/Pages/Home.aspx");
    }

    private void BtnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Pages/Home.aspx");
    }
}