<%@ Page Title="" Language="C#" Theme="SkinFile" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ProblemList.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="maincontent" Runat="Server">
    
                <br />
        <!--<asp:Label ID="Problems" runat="server" Text=""></asp:Label>-->
                
    <br />
    <asp:GridView runat="server" ID="grid1" SkinID="grid" AutoGenerateColumns="true" >
    </asp:GridView>
        <br />
        <br />
                      
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                      
        <asp:Button ID="submit" runat="server" Text="Submit" SkinId="button" OnClick="submit_Click" />
            
    
</asp:Content>

