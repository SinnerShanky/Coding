<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Logout.aspx.cs" Inherits="Feedback" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title> Log Out </title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <div>
            <h1>You have logged out </h1>
            <br />
            <br />
            
            <h3> To login click 
            <asp:HyperLink ID="HPL_here" runat="server" NavigateUrl="~/Home.aspx"> <b><u> here </u></b>  </asp:HyperLink>
            </h3>
        </div>
</asp:Content>

