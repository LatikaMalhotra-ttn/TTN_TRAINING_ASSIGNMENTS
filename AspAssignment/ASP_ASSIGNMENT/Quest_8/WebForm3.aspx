<%--<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="Quest_8.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="width:100%;background-color:gold;margin:0px">
    <asp:Label ID="Label1" runat="server" style="font-size:2rem;text-shadow:2px 2px 2px #CCCCCC;padding:10px;font-size:1.5rem;" Text="Login Form:"></asp:Label>
    </div>
        <table runat="server" ID="table12">
        <tr>
            <th>UserName:</th>
            <td style="padding:8px"><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ErrorMessage="Required" Display="Dynamic" ForeColor="Red"
                    ControlToValidate="TextBox1" runat="server" />
                </td>
        </tr>
        <tr>
            <th>Password:</th>
            <td style="padding:8px"><asp:TextBox ID="TextBox2" runat="server" type="password"></asp:TextBox>
                <asp:RequiredFieldValidator ErrorMessage="Required" Display="Dynamic" ForeColor="Red"
                    ControlToValidate="TextBox2" runat="server" />
            </td>

        </tr>
        <tr>
            <td style="padding:8px"></td>
            <td style="padding:8px">
                <asp:Button ID="Button1" Class="btn btn-info" runat="server" Text="LogIn" OnClick="Button1_Click" />
            </td>
        </tr>
    </table>
    <asp:Label ID="Label2" runat="server" style="border:1px solid black;margin-left:40px;margin-top:50px;font-size:2rem;text-shadow:2px 2px 2px #CCCCCC;padding:10px;font-size:1.5rem;" Visible="False" ></asp:Label>


    <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Visible="False">
        <AlternatingRowStyle BackColor="White" />
        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F8FAFA" />
        <SortedAscendingHeaderStyle BackColor="#246B61" />
        <SortedDescendingCellStyle BackColor="#D4DFE1" />
        <SortedDescendingHeaderStyle BackColor="#15524A" />
    </asp:GridView>


</asp:Content>--%>















<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="Quest_8.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="width:100%;background-color:gold;margin:0px">
    <asp:Label ID="Label1" runat="server" style="font-size:2rem;text-shadow:2px 2px 2px #CCCCCC;padding:10px;font-size:1.5rem;" Text="Login Form:"></asp:Label>
    </div>
        <table runat="server" ID="table12">
        <tr>
            <th>UserName:</th>
            <td style="padding:8px"><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ErrorMessage="Required" Display="Dynamic" ForeColor="Red"
                    ControlToValidate="TextBox1" runat="server" />
                </td>
        </tr>
        <tr>
            <th>Password:</th>
            <td style="padding:8px"><asp:TextBox ID="TextBox2" runat="server" type="password"></asp:TextBox>
                <asp:RequiredFieldValidator ErrorMessage="Required" Display="Dynamic" ForeColor="Red"
                    ControlToValidate="TextBox2" runat="server" />
            </td>

        </tr>
        <tr>
            <td style="padding:8px"></td>
            <td style="padding:8px">
                <asp:Button ID="Button1" Class="btn btn-info" runat="server" Text="LogIn" OnClick="Button1_Click" />
            </td>
        </tr>
    </table>
    <asp:Label ID="Label2" runat="server" style="border:1px solid black;margin-left:40px;margin-top:50px;font-size:2rem;text-shadow:2px 2px 2px #CCCCCC;padding:10px;font-size:1.5rem;" Visible="False" ></asp:Label>


    <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Visible="False">
        <AlternatingRowStyle BackColor="White" />
        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F8FAFA" />
        <SortedAscendingHeaderStyle BackColor="#246B61" />
        <SortedDescendingCellStyle BackColor="#D4DFE1" />
        <SortedDescendingHeaderStyle BackColor="#15524A" />
    </asp:GridView>


</asp:Content>
