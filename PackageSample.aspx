<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PackageSample.aspx.cs" Inherits="WebApp2.PackageSample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>
        <style type="text/css">
        .auto-style1 {
            width: 600px;
            height: 400px;
        }
    </style>
    </title>
    </head>
<body>
    <form id="form1" runat="server">
        <div display: flex>
       
                 <asp:Label ID="Label1" runat="server" Text="5 ημέρες Ρώμη"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="500€"></asp:Label>
           
            <br />
            <br />
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/About.aspx">Δείτε Περισσότερα</asp:HyperLink>
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
                 <asp:Image ID="Image1" runat="server" Height="400px" Width="600px" src="/../images/rome.jpg" />
        </div>
        <div>

                 <asp:Label ID="Label3" runat="server" Text="4 ημέρες Βουδαπέστη"></asp:Label>
            <br />
            <asp:Label ID="Label4" runat="server" Text="300€"></asp:Label>
           
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Δείτε Περισσότερα" Width="187px" />
         
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         
                 <asp:Image ID="Image2" runat="server" Height="400px" Width="600px" src="/../images/budapest.jpg"/>
        </div>
        <div>

                 <asp:Label ID="Label5" runat="server" Text="3 ημέρες Βιέννη"></asp:Label>
            <br />
            <asp:Label ID="Label6" runat="server" Text="450€"></asp:Label>
           
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" Text="Δείτε Περισσότερα" Width="187px" />
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 <asp:Image ID="Image4" runat="server" Height="400px" Width="600px" src="/../images/vienna.jpg"/>
        </div>
    </form>
</body>
</html>
