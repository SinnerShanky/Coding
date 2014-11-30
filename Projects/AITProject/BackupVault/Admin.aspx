<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="Admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="Admin.css"rel="stylesheet"  type="text/css" media="screen" />
    <title> Admin Dashboard </title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="head" style="width:100%">
    <asp:LinkButton ID="lbtn_viewUsers" runat="server" Text="User Details" OnClick="lbtn_viewUsers_Click"></asp:LinkButton>
    <asp:LinkButton ID="lbtn_Folder" runat="server" Text="Folder Details" OnClick="lbtn_Folder_Click"></asp:LinkButton>
    <asp:LinkButton ID="lbtn_qz" runat="server" Text="Security Question Details" OnClick="lbtn_qz_Click"></asp:LinkButton>
        <br />
        <br />
        <br />
    </div>


    <div id="admin1" style="width:50%;float:left;vertical-align:central;text-align:center">

    <asp:GridView runat="server" ID="gv_view" Visible="false">
    </asp:GridView>

    </div>

    <div id="admin2" style="float:right;width:50%;vertical-align:central;text-align:center;">
    
    <asp:Label runat="server" ID="lbl_add_fol"  Visible="false"></asp:Label>
    <asp:TextBox runat="server" ID="txt_add_fol" Visible="false" CssClass="textbox"></asp:TextBox> <br />
    <asp:Button runat="server" ID="btn_add_fol"  Visible="false" OnClick ="btn_add_fol_Click" /> 

    <asp:Label runat="server" ID="lbl_add_QZ"  Visible="false"></asp:Label>
    <asp:TextBox runat="server" ID="txt_add_QZ" Visible="false" CssClass="textbox"></asp:TextBox> <br />
    <asp:Button runat="server" ID="btn_add_QZ"  Visible="false" OnClick="btn_add_QZ_Click" /> 

     
    <asp:Label runat="server" ID="lbl_mssg" Visible="true"></asp:Label>





    </div>

</asp:Content>

