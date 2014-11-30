<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" Theme="SkinFile" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="maincontent" Runat="Server">
    <p>
            User ID:
            <asp:TextBox ID="user" runat="server" SkinID="redSkin"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ID="neww" ControlToValidate="user" ErrorMessage="Please enter user"/>
        </p>
        <p>
            Password:
            <asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator1" ControlToValidate="password" ErrorMessage="Please enter pass"/>
        </p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" SkinId="button" Text="Login" OnClick="Submit_Click" />
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Register" runat="server" SkinId="button" Text="Register" OnClick="Register_Click" CausesValidation="false"/>
</asp:Content>

