<%@ Page Title="" Language="C#" Theme="SkinFile" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"  CodeFile="Submission.aspx.cs" Inherits="_Default" ValidateRequest="false"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="maincontent" Runat="Server">
    <br />
Select Language:
        <asp:DropDownList ID="LanguageSelection" runat="server" OnSelectedIndexChanged="LanguageSelection_SelectedIndexChanged">
            <asp:ListItem>C</asp:ListItem>
            <asp:ListItem>C++</asp:ListItem>
            <asp:ListItem>JAVA</asp:ListItem>
        </asp:DropDownList>
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Problem Id:
    
    <asp:TextBox ID="TextBox1" runat="server" Width="60px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="sajkd" runat="server" ControlToValidate="TextBox1" ErrorMessage="Required Field"/>
    
&nbsp;<p>

            <asp:TextBox ID="Code" runat="server" Height="182px" Width="334px" TextMode="MultiLine"></asp:TextBox>
        </p>
        <p style="margin-left: 40px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Submit" runat="server"  SkinId="button" Text="Submit" OnClick="Submit_Click" />
        </p>
        <asp:Label ID="Output" runat="server" Text=""></asp:Label>
</asp:Content>

