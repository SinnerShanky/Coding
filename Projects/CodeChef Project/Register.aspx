<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" Theme="SkinFile" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="maincontent" Runat="Server">
    <p>
            User ID:
            <asp:TextBox ID="user" runat="server" OnTextChanged="user_TextChanged" SkinID="redSkin"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ID="uitr" ControlToValidate="user" ErrorMessage="Please enter user"/>
        
        </p>
        <p>
            Password:
            <asp:TextBox ID="pass" runat="server" Height="21px" OnTextChanged="pass_TextChanged" SkinID="blueColor"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ID="askud" ControlToValidate="pass" ErrorMessage="Please enter pass"/>
        </p>
    
        <div style="margin-left: 80px">
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Submit" runat="server" Text="Register" SkinId="button" OnClick="Submit_Click" />
    </div>
    
</asp:Content>

