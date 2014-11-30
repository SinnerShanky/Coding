<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <link href="Home.css" rel="stylesheet"  type="text/css" media="screen" />
        <title> Home </title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="SignIn" style="float:left;width:40%;align-content:center">
    
        <asp:Label ID="signin" runat="server"><h1 style="text-align:center">Sign In</h1></asp:Label>
        <asp:Table ID="tbl_SignIN" runat="server" HorizontalAlign="Center" >
        <asp:TableRow>
            <asp:TableCell><asp:Label ID="lbl_Uname" runat="server" Text="Enter Username" > </asp:Label></asp:TableCell>
            <asp:TableCell><asp:textbox ID="txt_Uname" runat="server" cssClass="textbox"/> </asp:TableCell></asp:TableRow><asp:TableRow>
            <asp:TableCell><asp:Label ID="lbl_Pass" runat="server" Text="Enter Password" > </asp:Label></asp:TableCell><asp:TableCell><asp:textbox  cssClass="textbox" ID="txt_Pass" runat="server" TextMode="Password"/> </asp:TableCell></asp:TableRow><asp:TableRow>
               <asp:TableCell>&nbsp;</asp:TableCell><asp:TableCell> <asp:LinkButton id="lbtn_Pass" runat="server" Text="ForgotPassword" OnClick="lbtn_Pass_Click"></asp:LinkButton> </asp:TableCell></asp:TableRow><asp:TableRow>
            <asp:TableCell>&nbsp;</asp:TableCell><asp:TableCell><asp:Button ID="btn_Login" runat="server" Text="Login" OnClick="btn_Login_Click" /></asp:TableCell>
        </asp:TableRow>



        <asp:TableRow>
            <asp:TableCell>&nbsp;</asp:TableCell><asp:TableCell> <asp:Label ID="lbl_mssg" runat="server"></asp:Label> </asp:TableCell></asp:TableRow></asp:Table><asp:Table ID="tbl_forgot" runat="server" Visible="false" HorizontalAlign="Center">
            <asp:TableRow>
                <asp:TableCell> <asp:Label ID="lbl_uname2" runat="server" Text="Enter Username"></asp:Label> </asp:TableCell><asp:TableCell> <asp:TextBox cssClass="textbox" ID="txt_uname2" runat="server" ></asp:TextBox></asp:TableCell></asp:TableRow><%--<asp:TableRow>
            <%--    <asp:TableCell> <asp:Label ID="lbl_qz" runat="server" Text="Security Question"></asp:Label> </asp:TableCell>
                    <asp:TableCell> <asp:Label ID="lbl_qz2" runat="server"></asp:Label> </asp:TableCell>
            </asp:TableRow>
             <asp:TableRow>
                <asp:TableCell> <asp:Label ID="lbl_ans" runat="server" Text="Enter Answer"></asp:Label> </asp:TableCell>
                    <asp:TableCell> <asp:Textbox ID="txt_ans12"  runat="server"></asp:Textbox> </asp:TableCell>
            </asp:TableRow>--%><asp:TableRow>
                <asp:TableCell> <asp:Label ID="lbl_newPass" runat="server" Text="Enter New Password"></asp:Label></asp:TableCell><asp:TableCell> <asp:TextBox ID="txt_newPass" runat="server"  cssClass="textbox" TextMode="Password"></asp:TextBox></asp:TableCell></asp:TableRow><asp:TableRow>
                <asp:TableCell> <asp:Label ID="lbl_again" runat="server" Text="Re-enter Password"></asp:Label></asp:TableCell><asp:TableCell> <asp:TextBox cssClass="textbox" ID="txt_again" runat="server" TextMode="Password"></asp:TextBox></asp:TableCell></asp:TableRow><asp:TableRow>
            <asp:TableCell>&nbsp;</asp:TableCell><asp:TableCell><asp:Button ID="btn_again" runat="server" Text="Submit" OnClick="btn_again_Click" /></asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>&nbsp;</asp:TableCell><asp:TableCell><asp:Button ID="btn_login2" runat="server" Text="Login" OnClick="btn_login2_Click" /></asp:TableCell>
        </asp:TableRow>

         <asp:TableRow>
            <asp:TableCell>&nbsp;</asp:TableCell><asp:TableCell> <asp:Label ID="lbl_mssg2" runat="server"></asp:Label> </asp:TableCell></asp:TableRow></asp:Table></div><%-- <div style="align-content:center;width:10%;left:50%;">
            <hr style="width:1px;height:500px" />
    </div>--%><div id="SignUP" style="float:right;vertical-align:top;width:40%;align-content:center" >
        <asp:Label ID="sigup" runat="server"><h1 style="text-align:center">Sign Up</h1></asp:Label><asp:Table ID="tbl_SignUP" runat="server" HorizontalAlign="Center">

         <asp:TableRow>
               <asp:TableCell><asp:Label ID="lbl_Name" runat="server" Text="Enter Name"></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txt_Name" runat="server" cssClass="textbox" ></asp:TextBox></asp:TableCell></asp:TableRow><asp:TableRow>
            <asp:TableCell> <asp:Label ID="lbl_DOB" runat="server" Text="Enter Date of Birth"></asp:Label></asp:TableCell><asp:TableCell> <asp:TextBox ID="txt_DOB" cssClass="textbox" runat="server" TextMode="Date" ></asp:TextBox></asp:TableCell></asp:TableRow><asp:TableRow>
            <asp:TableCell> <asp:Label ID="lbl_gen" runat="server" Text="Select Gender"></asp:Label></asp:TableCell><asp:TableCell> <asp:RadioButtonList ID="rdb_gen" runat="server" RepeatDirection="Horizontal" CssClass="dropdownlist">
                                <asp:ListItem Text="Male" Value="M"> </asp:ListItem>
                                <asp:ListItem Text="Female" Value="F"></asp:ListItem>
                            </asp:RadioButtonList>
        </asp:TableCell></asp:TableRow><asp:TableRow>
            <asp:TableCell> <asp:Label ID="lbl_email" runat="server" Text="Enter Email"></asp:Label></asp:TableCell><asp:TableCell> <asp:TextBox  cssClass="textbox" ID="txt_email" runat="server" TextMode="Email" ></asp:TextBox></asp:TableCell></asp:TableRow><asp:TableRow>           
            <asp:TableCell> <asp:Label ID="lbl_Phone" runat="server" Text="Enter Phone"></asp:Label></asp:TableCell><asp:TableCell> <asp:TextBox ID="txt_Phone" cssClass="textbox" runat="server"  ></asp:TextBox></asp:TableCell></asp:TableRow><asp:TableRow>
            <asp:TableCell> <asp:Label ID="lbl_Uname1" runat="server" Text="Enter UserName"></asp:Label></asp:TableCell><asp:TableCell> <asp:TextBox ID="txt_Uname1" cssClass="textbox" runat="server" ></asp:TextBox></asp:TableCell></asp:TableRow><asp:TableRow>
            <asp:TableCell> <asp:Button ID="btn_chk" runat="server" Text="Check" OnClick="btn_chk_Click"/> </asp:TableCell><asp:TableCell>   <asp:Label ID="lbl_chk" cssClass="textbox" runat="server" Text="Check Username"></asp:Label> </asp:TableCell></asp:TableRow><asp:TableRow>
            <asp:TableCell> <asp:Label ID="lbl_Pass1" runat="server" Text="Enter Password"></asp:Label></asp:TableCell><asp:TableCell> <asp:TextBox ID="txt_Pass1"  cssClass="textbox"  runat="server" TextMode="Password"></asp:TextBox></asp:TableCell></asp:TableRow><asp:TableRow>
            <asp:TableCell> <asp:Label ID="lbl_Repass" runat="server" Text="Re-enter Password"></asp:Label></asp:TableCell><asp:TableCell> <asp:TextBox ID="txt_Repass1" cssClass="textbox"    runat="server" TextMode="Password"></asp:TextBox></asp:TableCell></asp:TableRow><asp:TableRow>
            <asp:TableCell> <asp:Label ID="lbl_Qz" runat="server" Text="Choose Security Question"></asp:Label></asp:TableCell><asp:TableCell> <asp:DropDownList ID="ddl_SecretQz"  cssClass="textbox" runat="server" ></asp:DropDownList></asp:TableCell></asp:TableRow><asp:TableRow>
            <asp:TableCell> <asp:Label ID="lbl_Ans" runat="server" Text="Enter Answer"></asp:Label></asp:TableCell><asp:TableCell> <asp:TextBox ID="txt_Ans" cssClass="textbox" runat="server" ></asp:TextBox></asp:TableCell></asp:TableRow><asp:TableRow>
            <asp:TableCell> &nbsp; </asp:TableCell><asp:TableCell> <asp:Button ID="btn_SignUp" runat="server" Text="Sign UP" OnClick="btn_SignUp_Click" /></asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell> &nbsp; </asp:TableCell><asp:TableCell> <asp:Label ID="lbl_mssg3" runat="server" > </asp:Label></asp:TableCell></asp:TableRow></asp:Table></div></asp:Content>