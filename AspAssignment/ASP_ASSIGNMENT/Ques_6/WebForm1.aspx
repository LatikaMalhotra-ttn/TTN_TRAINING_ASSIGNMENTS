<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Ques_6.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label2" runat="server" style="text-shadow:2px 2px 2px #CCCCCC;margin-left:35%;font-size:1.5rem;color:aquamarine" Text="View State is mentained in below textbox:-"></asp:Label><br/><br />
            
            <asp:Panel ID="Panel2" runat="server" BackColor="#EEE6E5" style="margin:auto;padding-bottom:10px ; padding-top:10px"  Width="486px" >
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                &nbsp;&nbsp;
                <asp:Button ID="ButtonCheck" runat="server" OnClick="ButtonCheck_Click" Text="Button" />
            </asp:Panel>
            <br />
            <asp:Label ID="Label4" runat="server" style="text-shadow:2px 2px 2px #CCCCCC;margin-left:33%;font-size:1.5rem;color:aquamarine" Text="Session State is mentained in below textbox:-"></asp:Label><br/><br />
            
            <asp:Panel ID="Panel4" runat="server" BackColor="#EEE6E5" style="margin:auto;padding-bottom:10px ; padding-top:10px"  Width="486px" >
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox8" runat="server" ViewStateMode="Disabled"></asp:TextBox>
                &nbsp;&nbsp;
                <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="Button" />
            </asp:Panel>

            <br />
            <asp:Label ID="Label3" runat="server" style="color:aquamarine;text-shadow:2px 2px 2px #CCCCCC;margin-left:32%;font-size:1.5rem;" Text="Application State is mentained in below textbox:-"></asp:Label><br/><br />
            
            <asp:Panel ID="Panel3" runat="server" BackColor="#EEE6E5" style="margin:auto;padding-bottom:10px ; padding-top:10px;"  Width="486px" >
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox3" runat="server" ViewStateMode="Disabled"></asp:TextBox>
                &nbsp;&nbsp;
                <asp:Button ID="Button10" runat="server" OnClick="Button10_Click" Text="Button" />
            </asp:Panel>
        </div>
    </form>
</body>
</html>
