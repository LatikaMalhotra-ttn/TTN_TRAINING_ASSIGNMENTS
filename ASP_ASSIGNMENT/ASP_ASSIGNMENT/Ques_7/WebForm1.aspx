<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Ques_7.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server" BackColor="#99D7FF" style="margin:auto" Width="486px">
                <asp:Button ID="Button1" class="btn btn-info" style="margin-left:20px; margin-top:20px;" runat="server" Text="Button 1" onclick="Button1_Click" CommandName="Button1" oncommand="CommandButton_Click" />  

                <br /><br />

                <asp:Button ID="PrintButton" class="btn btn-info" style="margin-left:20px;" runat="server" Text="Button 2" oncommand="CommandButton_Click" CommandName="Print"/>

                <br /><br />
                <asp:Button ID="DeletButton" class="btn btn-info" style="margin-left:20px;" runat="server" Text="Button 3" oncommand="CommandButton_Click" CommandName="Delete"/>

                <br /><br />
                <asp:Button ID="Top10Button" class="btn btn-info" style="margin-left:20px;" runat="server" Text="Button 4" oncommand="CommandButton_Click" CommandName="Show" CommandArgument="Top10"/>

                <br /><br />
                <asp:Button ID="Bottom10Button" class="btn btn-info"  style="margin-left:20px;" runat="server" Text="Button 5" oncommand="CommandButton_Click" CommandName="Show" CommandArgument="Bottom10" OnClick="Bottom10Button_Click"/>
        
                <br /><br />
                <asp:Label ID="Label2" class="btn btn-info" style="margin-left:20px;color:aqua;background-color:whitesmoke;border:1px solid black" runat="server"></asp:Label>
            
                <br /><br />
                <asp:Label ID="OutputLabel" class="btn btn-info"  style="margin-bottom:10px;margin-left:20px;color:aqua;background-color:whitesmoke;border:1px solid black" runat="server"></asp:Label>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
