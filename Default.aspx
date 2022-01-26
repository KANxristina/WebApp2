<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApp2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Timer ID="Timer1" runat="server" OnTick="Timer1_Tick" Interval="2000">
            </asp:Timer>
            <asp:Image ID="Image1" runat="server" Height="500px" Width="1000px" />+
            
        </ContentTemplate>
    </asp:UpdatePanel>
 
   
     
    
    </asp:Content>
