<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Default3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="maincontent" Runat="Server">
    <br />
    <asp:AdRotator ID="AdRotator1" runat="server" AdvertisementFile="XMLFile2.xml" />
    <br />
    <asp:LinkButton ID="QuickSubmit" runat="server" OnClick="LinkButton1_Click">Quick Submit</asp:LinkButton>
</asp:Content>

