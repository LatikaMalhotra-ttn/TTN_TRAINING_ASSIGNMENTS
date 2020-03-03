<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Quest_8.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <asp:Panel ID="Panel1" runat="server" style="margin-top:100px;margin:auto;background-color:antiquewhite;padding:10px;border-radius:10px" Height="100%" Width="300px">
        <div style="padding:10px;border-bottom:1px dotted #C8C6C6">
            
            <asp:Label ID="Label1" style="font-size:1.5rem;text-decoration:underline;text-align:center;color:slateblue;font-weight:bold" runat="server" Text="Registration form"></asp:Label>
        </div>
        <div style="padding:10px;border-bottom:1px dotted #C8C6C6">
            <asp:Label ID="Label2" runat="server" Text="New User:" style="font-size:1.5rem;color:dimgrey;"></asp:Label><br />
            <asp:Button ID="Button1" runat="server" class="btn btn-primary" Text="Sign Up" OnClick="Button1_Click1" />
            
            
        </div>
        <div style="padding:10px;border-bottom:1px dotted #C8C6C6">
            <asp:Label ID="Label3" runat="server" Text="Already registered Users:" style="font-size:1.5rem;color:dimgrey;"></asp:Label><br />
            <asp:Button ID="Button2" class="btn btn-success" runat="server" Text="Login" OnClick="Button2_Click1" />
        </div>
    </asp:Panel>
    
    
</asp:Content>
