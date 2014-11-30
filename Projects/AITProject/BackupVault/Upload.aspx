<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Upload.aspx.cs" Inherits="Upload" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link rel="stylesheet" href="Upload.css" type="text/css" media="screen" />
    <title> Upload </title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="upload">
    <asp:Label ID="lbl_disp" runat="server" Text="Welcome" ></asp:Label>

    <asp:Table ID="tbl_upload" runat="server">
        <asp:TableRow>
            <asp:TableCell><asp:Label ID="lbl_fname" runat="server" Text="File Name"></asp:Label></asp:TableCell>
            <asp:TableCell><asp:TextBox   CssClass="textbox" ID="txt_fname" runat="server" ></asp:TextBox></asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell><asp:Label ID="lbl_ftype" runat="server" Text="File Type"></asp:Label></asp:TableCell>
            <asp:TableCell><asp:DropDownList ID="ddl_ftype" runat="server"></asp:DropDownList></asp:TableCell>
        </asp:TableRow>


        <asp:TableRow>
            <asp:TableCell><asp:Label ID="lbl_file" runat="server" Text="Choose File"></asp:Label></asp:TableCell>
            <asp:TableCell><asp:FileUpload ID="txt_file" runat="server" /></asp:TableCell>
        </asp:TableRow>
        
        <asp:TableRow>
            <asp:TableCell>&nbsp;</asp:TableCell>
            <asp:TableCell><asp:Button ID="btn_submit" runat="server" Text="Submit" OnClick="btn_submit_Click"/></asp:TableCell>
        </asp:TableRow>

          <asp:TableRow>
            <asp:TableCell>&nbsp;</asp:TableCell>
            <asp:TableCell><asp:Label ID="lbl_mssg" runat="server" /></asp:TableCell></asp:TableRow></asp:Table></div></asp:Content>