<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Ques_7.WebForm1" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div>

             <asp:Panel ID="Panel1" runat="server">
             <asp:Label ID="Label2" style="font-size: 1.5rem;margin:5px; font-weight: bold " runat="server" Text="Details of Employees are as follows:-"></asp:Label>
             
            <br />
            <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal">
            <AlternatingRowStyle BackColor="#F7F7F7" />
            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
            <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
            <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
            <SortedAscendingCellStyle BackColor="#F4F4FD" />
            <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
            <SortedDescendingCellStyle BackColor="#D8D8F0" />
            <SortedDescendingHeaderStyle BackColor="#3E3277" />
            </asp:GridView>
            <br />

             <asp:Label ID="Label4" style="font-size: 1.5rem;margin:5px; font-weight: bold " runat="server" Text="Employee Id From whuch you want to transfer money: "></asp:Label>
             <asp:TextBox ID="TextBox2" type="number" runat="server"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="Please enter Employee Id in first box" ForeColor="Red"></asp:RequiredFieldValidator>
                 <br /><br />
             <asp:Label ID="Label3" style="font-size: 1.5rem;margin:5px; font-weight: bold " runat="server" Text="Employee Id to whom you want to transfer money: "></asp:Label>
             <asp:TextBox ID="TextBox1" type="number" runat="server"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox1" ErrorMessage="Please enter Employee Id in second box" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
                 <br />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click1" />

                 <br />

            <br />
                 </asp:Panel>
             <asp:Panel ID="Panel2" runat="server">
            <asp:Label ID="Label5" style="font-size: 1.5rem;margin:5px; font-weight: bold " runat="server" Text="Label" Visible="False"></asp:Label>
                 
                 <br />
                 
            <br />
            <asp:GridView ID="GridView2" runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" Visible="False">
            <AlternatingRowStyle BackColor="#F7F7F7" />
            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
            <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
            <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
            <SortedAscendingCellStyle BackColor="#F4F4FD" />
            <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
            <SortedDescendingCellStyle BackColor="#D8D8F0" />
            <SortedDescendingHeaderStyle BackColor="#3E3277" />
            </asp:GridView>
            <br />
             </asp:Panel>
        
       
            <br />
            <br />
            <br />
            
        </div>
    </form>
</body>
</html>
