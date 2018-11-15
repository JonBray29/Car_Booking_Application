using RustyRepairs.App_Code;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.grdBookings.SelectedIndexChanged += GrdBookings_SelectedIndexChanged;
        this.grdBookings.RowDataBound += GrdBookings_RowDataBound;
        this.btnCreateBooking.Click += BtnCreateBooking_Click1;

        if (!IsPostBack)
        {
            this.bindToGrid();
        }
    }

    private void BtnCreateBooking_Click1(object sender, EventArgs e)
    {
        Response.Redirect("~/Pages/CreateBooking.aspx");
    }

    private void GrdBookings_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes["onmouseover"] = "this.style.backgroundColor='silver';";
            e.Row.Attributes["onmouseout"] = "this.style.backgroundColor='white';";
        }
    }

    private void GrdBookings_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["bookingID"] = this.grdBookings.SelectedRow.Cells[1].Text;
        Response.Redirect("~/Pages/UpdateBooking.aspx");
    }

    private void bindToGrid()
    {
        List<Booking> bookings = Utilities.ReadBookings();

        DataTable table = new DataTable();
        table.Columns.Add("Booking ID", typeof(string));
        table.Columns.Add("Customer ID", typeof(string));
        table.Columns.Add("Name", typeof(string));
        table.Columns.Add("Vehicle ID", typeof(string));
        table.Columns.Add("Vehicle Make", typeof(string));
        table.Columns.Add("Vehicle Model", typeof(string));
        table.Columns.Add("Date", typeof(string));
        table.Columns.Add("Time", typeof(string));

        for (int i = 0; i < bookings.Count; i++)
        {
            Booking booking = bookings[i];
            Customer customer = Utilities.GetCustomerFromCustomerID(booking.CustomerID);
            Vehicle vehicle = Utilities.GetVehicleFromVehicleID(booking.VehicleID);

            if (booking != null && customer != null && vehicle != null)
            {
                table.Rows.Add(booking.BookingID, booking.CustomerID, customer.FirstName + " " + customer.LastName, vehicle.VehicleID, vehicle.Make, vehicle.Model, booking.Date,
                    booking.Time);
            }
        }

        this.grdBookings.DataSource = table;
        this.grdBookings.DataBind();
    }

    private void alert(string message)
    {
        ClientScript.RegisterStartupScript(this.GetType(), "myalert", string.Format("alert('{0}');", message), true);
    }
}