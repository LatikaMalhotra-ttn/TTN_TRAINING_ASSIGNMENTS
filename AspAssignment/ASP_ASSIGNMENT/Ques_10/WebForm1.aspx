<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Ques_10.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:Panel ID="Panel1" runat="server">
                <asp:Label ID="Label2" runat="server" Text="Label">Enter number:</asp:Label>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label1" runat="server" Text="Label">Enter quotent:</asp:Label>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <br />
                <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
                <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            
            </asp:Panel>
            
        </div>
    </form>
</body>
</html>
