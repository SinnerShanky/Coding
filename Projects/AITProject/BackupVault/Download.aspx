<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Download.aspx.cs" Inherits="Download" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <link href="Download.css" rel="stylesheet"  type="text/css" media="screen" />
        <title> Download </title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div id="download">
        <asp:Button ID="find" runat="server" Text="Find Files" OnClick="find_Click" />   
     <asp:Label ID="lbl_Mssg12" runat="server"  ></asp:Label>
    <asp:TreeView ID="TreeView" runat="server" CollapseImageUrl="~/minus.png" ExpandImageUrl="~/plus.png" OnSelectedNodeChanged="TreeView_SelectedNodeChanged">
         <ParentNodeStyle BackColor="Lavender"/>         
            <HoverNodeStyle BackColor="Black" />
            <SelectedNodeStyle ForeColor="Black" BackColor="Aqua"/>
            <NodeStyle  />
    </asp:TreeView>
   


</div>



</asp:Content>

