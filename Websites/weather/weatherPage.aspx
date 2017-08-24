<%@ Page Language="C#" AutoEventWireup="true" CodeFile="weatherPage.aspx.cs" Inherits="weatherPage"  %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class ="div-left">
            <asp:Label ID="Label1" runat="server" Text="Latitude"></asp:Label><br />
            <asp:TextBox ID="txtLatitude" runat="server"></asp:TextBox>
        </div> 
        <div class ="div-right">
            <asp:Label ID="Label6" runat="server" Text="Longitude"></asp:Label><br />
            <asp:TextBox ID="txtLongitude" runat="server"></asp:TextBox>
        <br />
            <asp:Button ID="submitButton" runat="server" Text="Submit" OnClick="submitButton_Click" />

        </div>
        <asp:Label ID="Label12" runat="server" Text=""></asp:Label>
        <asp:Label ID="Label11" runat="server" Text="Weather Icon"></asp:Label>
        <br />

        <asp:Label ID="Label2" runat="server" Text="max. temperature: "></asp:Label>
        <asp:Label ID="Label3" runat="server" Text=""></asp:Label><br />

        <asp:Label ID="Label4" runat="server" Text="min. temperature: "></asp:Label>
        <asp:Label ID="Label5" runat="server" Text=""></asp:Label><br />

        <%--<asp:Label ID="Label7" runat="server" Text="dew point: "></asp:Label>
        <asp:Label ID="Label8" runat="server" Text=""></asp:Label><br />--%>

        <asp:Label ID="Label9" runat="server" Text="12 hour pp: "></asp:Label>
        <asp:Label ID="Label10" runat="server" Text=""></asp:Label><br />

        
    </div>
    </form>
</body>
</html>
