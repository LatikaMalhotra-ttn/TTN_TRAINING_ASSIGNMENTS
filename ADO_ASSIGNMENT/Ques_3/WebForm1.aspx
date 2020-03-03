<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Ques_3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
table {
  border-collapse: collapse;
  width: 100%;
}

th, td {
  text-align: left;
  padding: 8px;
}

tr:nth-child(even) {background-color: #f2f2f2;}
</style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:Label ID="Label1" runat="server" style="text-shadow:2px 2px 2px #CCCCCC;color:red;font-size:1.5rem;" Text="Executereader, ExecuteNonQuery And ExecuteScaler are shown below:-"></asp:Label>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label2" style="text-shadow:2px 2px 2px #CCCCCC;font-size:1.5rem;" runat="server" Text="Use of Execute reader:"></asp:Label>
                        

                    </td>
                    <td>
                        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                            <AlternatingRowStyle BackColor="White" />
                            <EditRowStyle BackColor="#2461BF" />
                            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#EFF3FB" />
                            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#F5F7FB" />
                            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                            <SortedDescendingCellStyle BackColor="#E9EBEF" />
                            <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" style="text-shadow:2px 2px 2px #CCCCCC;font-size:1.5rem;" runat="server" Text="Use of ExecuteNonQuery:"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label6" style="text-shadow:2px 2px 2px #CCCCCC;font-size:1.5rem;" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>

                        <asp:Label ID="Label4" style="text-shadow:2px 2px 2px #CCCCCC;font-size:1.5rem;" runat="server" Text="Use of ExecuteScaler:"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label5" style="text-shadow:2px 2px 2px #CCCCCC;font-size:1.5rem;" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
