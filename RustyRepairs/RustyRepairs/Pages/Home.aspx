<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Pages_Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Booking</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" />
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.0.13/css/all.css" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div class="container mt-5">
            <div class="row text-center border-bottom border-dark mb-5">
                <div class="col">
                    <h1><i class="fas fa-car mr-3"></i>Rusty's Repairs!</h1>
                </div>
            </div>

            <div class="row text-center">
                <div class="col">
                    <asp:GridView ID="grdBookings" Width="100%" runat="server">
                        <Columns>
                            <asp:ButtonField Text="Select"  ControlStyle-CssClass="btn btn-outline-info"  CommandName="Select" ItemStyle-Width="100"/>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
            <div class="row mt-5 text-center">
                <div class="col">
                    <asp:Button ID="btnCreateBooking" class="btn btn-outline-success" runat="server" Text="Create New Booking" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
