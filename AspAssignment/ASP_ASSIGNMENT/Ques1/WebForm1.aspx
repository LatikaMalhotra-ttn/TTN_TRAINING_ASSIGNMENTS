<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Ques1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Panel ID="Panel1" runat="server">
            
        </asp:Panel>
        <div>
            
            
            <asp:Panel ID="Panel2" runat="server" style="border:1px solid black;background-color:aquamarine;padding:10px">
            <asp:Label ID="Label1" runat="server" style="color:darkred;font-size:1.5rem;font-weight:bold;text-decoration:underline" Text="Page life Cycle Events happen in following order:-" ></asp:Label><br />
            <asp:Label ID="Label2" runat="server" style="color:indianred" ></asp:Label><br />
            <asp:Label ID="Label3" runat="server" style="color:indianred" ></asp:Label><br />
            <asp:Label ID="Label4" runat="server" style="color:indianred"></asp:Label><br />
            <asp:Label ID="Label5" runat="server" style="color:indianred"></asp:Label><br />

            <asp:Label ID="Label6" runat="server" style="color:indianred"></asp:Label> <br />
            <asp:Label ID="Label7" runat="server" style="color:indianred"></asp:Label><br />
            <asp:Label ID="Label8" runat="server" style="color:indianred"></asp:Label><br />
            </asp:Panel>
            

        </div>
    </form>
</body>
</html>
