using RustyRepairs.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_UpdateBooking : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.txtNotes.Attributes.Add("readonly", "readonly");
        this.txtDate.Attributes.Add("readonly", "readonly");
        this.txtTime.Attributes.Add("readonly", "readonly");

        this.btnUpdate.Click += BtnUpdate_Click;
        this.btnBack.Click += BtnBack_Click;
        this.btnDelete.Click += BtnDelete_Click;

        Booking booking = Utilities.GetBookingFromBookingID(int.Parse(Session["bookingID"].ToString()));
        Customer customer = Utilities.GetCustomerFromCustomerID(booking.CustomerID);
        Vehicle vehicle = Utilities.GetVehicleFromVehicleID(booking.VehicleID);

        this.txtCustNum.Text = customer.CustomerID.ToString();
        this.txtFirstName.Text = customer.FirstName;
        this.txtLastName.Text = customer.LastName;
        this.txtVehicleMake.Text = vehicle.Make;
        this.txtVehicleModel.Text = vehicle.Model;
        this.txtVehicleRegistration.Text = vehicle.Registration;
        if (!IsPostBack)
        {
            this.txtNotes.Text = vehicle.Notes;
            this.txtDate.Text = booking.Date;
            this.txtTime.Text = booking.Time;
        }
    }

    private void BtnDelete_Click(object sender, EventArgs e)
    {
        Booking booking = Utilities.GetBookingFromBookingID(int.Parse(Session["bookingID"].ToString()));
        Utilities.RemoveBooking(booking);
        Response.Redirect("~/Pages/Home.aspx");
    }

    private void BtnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Pages/Home.aspx");
    }

    private void BtnUpdate_Click(object sender, EventArgs e)
    {
        if (this.btnUpdate.Text == "Save")
        {
            this.btnUpdate.Text = "Update";

            //Update booking
            Booking booking = Utilities.GetBookingFromBookingID(int.Parse(Session["bookingID"].ToString()));
            booking.Date = this.txtDate.Text;
            booking.Time = this.txtTime.Text;

            Vehicle vehicle = Utilities.GetVehicleFromVehicleID(booking.VehicleID);
            vehicle.Notes = this.txtNotes.Text;

            Utilities.UpdateVehicle(vehicle);
            Utilities.UpdateBooking(booking);

            this.txtNotes.Attributes.Add("readonly", "readonly");
            this.txtDate.Attributes.Add("readonly", "readonly");
            this.txtTime.Attributes.Add("readonly", "readonly");

            Response.Redirect(Request.Url.AbsolutePath);
        }
        else
        {
            this.btnUpdate.Text = "Save";

            this.txtNotes.Attributes.Remove("readonly");
            this.txtDate.Attributes.Remove("readonly");
            this.txtTime.Attributes.Remove("readonly");
        }
    }
}