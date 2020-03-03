<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Ques_5.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
 <style>
table {
  border-collapse: collapse;
  width: 100%;
}

th, td {
  padding: 0px;
  text-align: left;
  border-bottom: 1px solid #ddd;
}

tr:hover {background-color:#f5f5f5;}
ul {
  list-style-type: none;
  margin: 0;
  padding: 0;
  overflow: hidden;
  background-color: #333;
}

li {
  float: left;
}

li a {
  display: block;
  color: white;
  text-align: center;
  padding: 14px 16px;
  text-decoration: none;
}

li a:hover:not(.active) {
  background-color: #111;
  text-decoration:none;
  color:aqua;
}

p {
  background-color: cadetblue;
   display: block;
  color: white;
  text-align: center;
  padding: 14px 16px;
  text-decoration: none;
  margin-bottom:0px;
}
</style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

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

        </div>
    </form>
</body>
</html>
