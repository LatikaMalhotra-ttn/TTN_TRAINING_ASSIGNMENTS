<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Ques_3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
    <style>
        td {
            border-bottom: 1px solid #ddd;
            margin:10px;
        }
        tr:hover {background-color: #f5f5f5;}
        tr:nth-child(even) {background-color: #F5F5DC;}
    </style>
    
</head>
<body>
    <form id="form1" runat="server" >
        <div style=" color:aquamarine; background-color:whitesmoke;align-items:center;margin:auto">
        <asp:Label runat="server" style="width:100%;font-size:2.5rem;margin:5px; font-weight:bold;text-align:center; color:aquamarine; background-color:whitesmoke">Employee Form: </asp:Label>
       </div>
            <asp:Panel ID="Panel1" runat="server" style="overflow-x:auto;">
            <table style="width:100%">
                <tr>
                    <td  >
                        <asp:Label runat="server"  style=" font-size: 1.5rem; margin: 5px; font-weight: bold ">Username:</asp:Label>
                    </td>
                    <td >
                        <asp:TextBox runat="server" style="margin:5px; " Columns="45" ID="TextBox1" ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Please Enter Name" BorderColor="Black" BorderWidth="1px" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td >
                        <asp:Label runat="server" style="font-size:1.5rem;margin:5px; font-weight:bold">Gender:</asp:Label>
                    </td>
                    <td >
                        
                            <asp:DropDownList ID="DropDownList1" runat="server" style="margin:5px">


                                <asp:ListItem Value="0" Selected="true">Unknown</asp:ListItem>
                                <asp:ListItem Value="1">Male</asp:ListItem>
                                <asp:ListItem Value="2">Female</asp:ListItem>


                            </asp:DropDownList>
                        
                    </td>
                </tr>
                 <tr>
                    <td  >
                        <asp:Label runat="server"  style="font-size: 1.5rem;margin:5px; font-weight: bold ">Salary:</asp:Label>
                    </td>
                    <td >
                        <asp:TextBox runat="server" style="margin:5px; " Columns="15" ID="TextBox2" ></asp:TextBox>
                        <asp:RangeValidator ID="RangeValidator2" runat="server" BorderColor="Black" BorderWidth="1px" ErrorMessage="Please enter correct salary" ForeColor="Red" MaximumValue="99999" MinimumValue="0" ControlToValidate="TextBox2"></asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td >
                        
                    </td>
                    <td >
                        
                        <asp:Button ID="Button1" runat="server" Text="Submit" type="button" class="btn btn-primary" style="margin:5px" OnClick="Button1_Click"/>
                        
                    </td>
                </tr>
                </table>
                </asp:Panel>
                
                    
                        <br /><br />
                        <asp:Label ID="Label1" style="font-size: 1.5rem;margin:5px; font-weight: bold " runat="server"></asp:Label><br /><br />
                                      
                        <asp:GridView ID="GridView1" runat="server" CellPadding="4" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px">
                            <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                            <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                            <RowStyle BackColor="White" ForeColor="#330099" />
                            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                            <SortedAscendingCellStyle BackColor="#FEFCEB" />
                            <SortedAscendingHeaderStyle BackColor="#AF0101" />
                            <SortedDescendingCellStyle BackColor="#F6F0C0" />
                            <SortedDescendingHeaderStyle BackColor="#7E0000" />
                        </asp:GridView><br /><br />
                
                
            
      
        
    </form>
</body>
</html>
