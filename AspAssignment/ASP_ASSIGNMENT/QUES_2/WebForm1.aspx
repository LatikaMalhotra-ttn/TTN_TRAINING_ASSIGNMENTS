
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="PracticalQues.Calculator" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title></title>
</head>
<body>
     <form id="form1" runat="server">
        <div>

            <asp:Label ID="Label1" runat="server" style="text-shadow:2px 2px 2px #CCCCCC;margin-left:40%;font-size:1.5rem;" Text="BASIC CALCULATOR"></asp:Label>
            <br /><br /><br />
            <asp:Panel ID="Panel1" runat="server" BackColor="#99D7FF" style="margin:auto" Height="506px" Width="486px">
                &nbsp;&nbsp;&nbsp;&nbsp;<br />&nbsp;&nbsp;
                <asp:TextBox ID="output" onkeydown="return false" runat="server" Font-Bold="True" Font-Size="XLarge" Height="53px" Width="450px" OnTextChanged="output_TextChanged" ReadOnly="True" ToolTip="please click button to enter operator or operand">0</asp:TextBox>
                <br />
                &nbsp;&nbsp;&nbsp;<br />&nbsp;&nbsp;
                <asp:Button ID="clear" runat="server" Height="56px" style="margin-top:0px" Text="C" Width="106px" CommandName="clear" OnCommand="btn_click" />
                &nbsp;
                <asp:Button ID="delete" runat="server" Height="56px" style="margin-right:3px" Text="Del" Width="106px" CommandName="delete" OnCommand="btn_click" />
                &nbsp;
                <asp:Button ID="mod" runat="server" Height="56px" Text="%" Width="106px" CommandName="mod" OnCommand="btn_click" />
                &nbsp;
                <asp:Button ID="divide" runat="server" Height="56px" Text="/" Width="106px" CommandName="divide" OnCommand="btn_click" />
                <br />
                <br />
                &nbsp;&nbsp;
                <asp:Button ID="seven" runat="server" Height="56px" Text="7" Width="106px" CommandName="seven" OnCommand="btn_click" />
                &nbsp;
                <asp:Button ID="eight" runat="server" Height="56px" Text="8" Width="106px" CommandName="eight" OnCommand="btn_click" />
                &nbsp;
                <asp:Button ID="nine" runat="server" Height="56px" Text="9" Width="106px" CommandName="nine" OnCommand="btn_click" />
                 &nbsp;
                <asp:Button ID="multiply" runat="server" Height="56px" Text="x" Width="106px" CommandName="multiply" OnCommand="btn_click" />
                <br />
                <br />
                &nbsp;&nbsp;
                <asp:Button ID="four" runat="server" Height="56px" Text="4" Width="106px" CommandName="four" OnCommand="btn_click" />
                &nbsp;
                <asp:Button ID="five" runat="server" Height="56px" Text="5" Width="106px" CommandName="five" OnCommand="btn_click" />
                &nbsp;
                <asp:Button ID="six" runat="server" CommandName="six" Height="56px" OnCommand="btn_click" Text="6" Width="106px" />
                &nbsp;
                <asp:Button ID="minus" runat="server" Height="56px" Text="-" Width="106px" CommandName="minus" OnCommand="btn_click" />
                <br />
                <br />
                &nbsp;&nbsp;
                <asp:Button ID="one" runat="server" Height="56px" Text="1" Width="106px" CommandName="one" OnCommand="btn_click" />
                &nbsp;
                <asp:Button ID="two" runat="server" Height="56px" Text="2" Width="106px" CommandName="two" OnCommand="btn_click" />
                &nbsp;
                <asp:Button ID="three" runat="server" Height="56px" Text="3" Width="106px" CommandName="three" OnCommand="btn_click" />
                &nbsp;
                <asp:Button ID="plus" runat="server" Height="56px" Text="+" Width="106px" CommandName="plus" OnCommand="btn_click" />
                <br />
                <br />
                &nbsp;&nbsp;
                <asp:Button ID="zero" runat="server" Height="56px" Text="0" Width="221px" CommandName="zero" OnCommand="btn_click" />
                &nbsp;
                <asp:Button ID="dot" runat="server" Height="56px" Text="." Width="106px" CommandName="dot" OnCommand="btn_click" />
                &nbsp;
                <asp:Button ID="equal" runat="server" Height="56px" Text="=" Width="106px" CommandName="equal" OnCommand="btn_click" />
                <br />

                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                
            </asp:Panel><br />
            <asp:Label ID="Label2" runat="server" style="text-shadow:2px 2px 2px #CCCCCC;margin-left:35%;font-size:1.5rem;" Text="View State is mentained in below textbox:-"></asp:Label><br/><br />
            
            <asp:Panel ID="Panel2" runat="server" BackColor="#99D7FF" style="margin:auto;padding-bottom:10px ; padding-top:10px"  Width="486px" >
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                &nbsp;&nbsp;
                <asp:Button ID="ButtonCheck" runat="server" OnClick="ButtonCheck_Click" Text="Button" />
            </asp:Panel>
            <br />
            <asp:Label ID="Label4" runat="server" style="text-shadow:2px 2px 2px #CCCCCC;margin-left:35%;font-size:1.5rem;" Text="Session State is mentained in below textbox:-"></asp:Label><br/><br />
            
            <asp:Panel ID="Panel4" runat="server" BackColor="#99D7FF" style="margin:auto;padding-bottom:10px ; padding-top:10px"  Width="486px" >
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox8" runat="server" ViewStateMode="Disabled"></asp:TextBox>
                &nbsp;&nbsp;
                <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="Button" />
            </asp:Panel>

            <br />
            <asp:Label ID="Label3" runat="server" style="text-shadow:2px 2px 2px #CCCCCC;margin-left:30%;font-size:1.5rem;" Text="Application State is mentained in below textbox:-"></asp:Label><br/><br />
            
            <asp:Panel ID="Panel3" runat="server" BackColor="#99D7FF" style="margin:auto;padding-bottom:10px ; padding-top:10px"  Width="486px" >
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox3" runat="server" ViewStateMode="Disabled"></asp:TextBox>
                &nbsp;&nbsp;
                <asp:Button ID="Button10" runat="server" OnClick="Button10_Click" Text="Button" />
            </asp:Panel>
        </div>
    </form>
</body>
</html>