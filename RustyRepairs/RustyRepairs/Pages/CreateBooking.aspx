<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CreateBooking.aspx.cs" Inherits="Pages_CreateBooking" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Create Booking</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" />
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.0.13/css/all.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-5">
            <div class="row text-center border-bottom border-dark mb-5">
                <div class="col">
                    <h1><i class="fas fa-car mr-3"></i>Rusty's Repairs!</h1>
                </div>
            </div>
            <div class="input-group mb-3">
                <div class="input-group-prepend">
                    <span class="input-group-text">Vehicle Registration</span>
                </div>
                <asp:TextBox runat="server" ID="txtVehicleRegistration" class="form-control" aria-label="Default" aria-describedby="inputGroup-sizing-default" ReadOnly="False" />
            </div>
            <div class="input-group mb-3">
                <div class="input-group-prepend">
                    <span class="input-group-text">Vehicle Make</span>
                </div>
                <asp:TextBox runat="server" ID="txtVehicleMake" class="form-control" aria-label="Default" aria-describedby="inputGroup-sizing-default" ReadOnly="False" />
            </div>
            <div class="input-group mb-3">
                <div class="input-group-prepend">
                    <span class="input-group-text">Vehicle Model</span>
                </div>
                <asp:TextBox runat="server" ID="txtVehicleModel" class="form-control" aria-label="Default" aria-describedby="inputGroup-sizing-default" ReadOnly="False" />
            </div>
            <div class="input-group mb-3">
                <div class="input-group-prepend">
                    <span class="input-group-text">Vehicle Colour</span>
                </div>
                <asp:TextBox runat="server" ID="txtCarColour" class="form-control" aria-label="Default" aria-describedby="inputGroup-sizing-default" ReadOnly="False" />
            </div>
            <div class="input-group mb-3">
                <div class="input-group-prepend">
                    <span class="input-group-text">Vehicle Notes</span>
                </div>
                <asp:TextBox runat="server" ID="txtCarNotes" class="form-control" aria-label="Default" aria-describedby="inputGroup-sizing-default" ReadOnly="False" TextMode="MultiLine" />
            </div>
            <div class="input-group mb-3">
                <div class="input-group-prepend">
                    <span class="input-group-text">Payment Method</span>
                </div>
                <asp:TextBox runat="server" ID="txtPaymentMethod" class="form-control" aria-label="Default" aria-describedby="inputGroup-sizing-default" ReadOnly="False" TextMode="MultiLine" />
            </div>
            <div class="input-group mb-3">
                <div class="input-group-prepend">
                    <span class="input-group-text" id="">Date and Time</span>
                </div>
                <asp:TextBox runat="server" ID="txtDate" class="form-control" TextMode="Date" />
                <asp:TextBox runat="server" ID="txtTime" class="form-control" TextMode="Time" />
            </div>
            <div class="row mt-5 text-center">
                <div class="col">
                    <asp:Button runat="server" Text="Back" ID="btnBack" class="btn btn-outline-danger"></asp:Button>
                </div>
                <div class="col">
                    <asp:Button runat="server" Text="Create" ID="btnCreate" class="btn btn-outline-success"></asp:Button>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
