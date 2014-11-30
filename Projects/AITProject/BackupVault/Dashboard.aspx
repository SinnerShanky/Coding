<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Dashboard.aspx.cs" Inherits="Dashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title> User Dashboard</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="left" style="width:45%;text-align:center;float:left">
        <img src="upload.png" style="width:200px;height:200px"/><br />
        &nbsp;
        <asp:Button ID="upload" runat="server" onclick="upload_Click" Text="Upload"/>
    </div>
    <div id="right" style="float:right;width:45%;text-align:center;vertical-align:top">
        <img src="download.png" style="width:200px;height:200px" /><br />
        &nbsp;
        <asp:Button ID="download" runat="server" OnClick="download_Click" Text="Download" />
    </div>
</asp:Content>


