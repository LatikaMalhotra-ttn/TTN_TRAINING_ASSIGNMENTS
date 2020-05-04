<%--<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Quest_8.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="width:100%;background-color:gold;margin:0px">
    <asp:Label ID="Label1" runat="server" style="font-size:2rem;text-shadow:2px 2px 2px #CCCCCC;padding:10px;font-size:1.5rem;" Text="Sign Up Form:"></asp:Label>
        </div>
   <table runat="server" ID="table1">
       <tr>
           <th>Username:</th>
           <td>
               <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
               <asp:RequiredFieldValidator ErrorMessage="Please enter Username, " ForeColor="Red" ControlToValidate="TextBox2"
                    runat="server" >*</asp:RequiredFieldValidator>
           </td>
       </tr>
       <tr>
           <th>E-mail:</th>
           <td>
               <asp:TextBox ID="TextBox1" runat="server" type="email"></asp:TextBox>
                <asp:RequiredFieldValidator ErrorMessage="Please enter email, " Display="Dynamic" ForeColor="Red"
                    ControlToValidate="TextBox1" runat="server" >*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator runat="server" Display="Dynamic" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                    ControlToValidate="TextBox1" ForeColor="Red" ErrorMessage="Invalid email address." />
           </td>
       </tr>
       <tr>
           <th>Password:</th>
           <td>
               <asp:TextBox ID="TextBox3" runat="server" type="password"></asp:TextBox>
               <asp:RequiredFieldValidator ErrorMessage="Please give password, " ForeColor="Red" ControlToValidate="TextBox3"
                     runat="server" >*</asp:RequiredFieldValidator>
           </td>
       </tr>
       <tr>
           <th>Confirm Password:</th>
           <td>
               <asp:TextBox ID="TextBox4" runat="server" type="password"></asp:TextBox>

               
               <asp:CompareValidator ErrorMessage="Passwords do not match." ForeColor="Red" ControlToCompare="TextBox3"
                    ControlToValidate="TextBox4" runat="server" />
           </td>
       </tr>
       <tr>
           <th>Mobile:</th>
           <td>
               <asp:TextBox ID="TextBox5" runat="server" type="number"></asp:TextBox>
               <asp:RequiredFieldValidator ErrorMessage="please enter your mobile number, " Display="Dynamic" ForeColor="Red"
                    ControlToValidate="TextBox5" runat="server" >*</asp:RequiredFieldValidator>
               <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server"  
                ControlToValidate="TextBox5" ErrorMessage="Please enter correct mobile number"  
                ValidationExpression="[0-9]{10}" ForeColor="Red"></asp:RegularExpressionValidator> 
           </td>
       </tr>
       <tr>
           <th>Gender:</th>
           <td>
               
               <asp:DropDownList ID="DropDownList1" runat="server">
                   <asp:ListItem Value="0" >Unknown</asp:ListItem>
                   <asp:ListItem Value="1">Male</asp:ListItem>
                   <asp:ListItem Value="2">Female</asp:ListItem>
               </asp:DropDownList></td>
           
       </tr>
       <tr>
           <th>Age:</th>
           <td>
               <asp:TextBox ID="TextBox6" runat="server" type="number"></asp:TextBox>
               <asp:RequiredFieldValidator ErrorMessage="Please enter your age, " Display="Dynamic" ForeColor="Red"
                    ControlToValidate="TextBox6" runat="server" >*</asp:RequiredFieldValidator> 
               <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Age should be in between 18-60 only.." ControlToValidate="TextBox6" ForeColor="Red" MaximumValue="60" MinimumValue="18" Display="Dynamic"></asp:RangeValidator>
           </td>
       </tr>
       <tr>
           <td></td>
           <td>
               <asp:Button ID="Button1" Class="btn btn-info" runat="server" Text="Sign Up" OnClick="Button1_Click" />
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red"/>
           <br />
               </td>
       </tr>
   </table>

    
    <asp:Label ID="Label2" runat="server" style="border:1px solid black;margin-left:40px;margin-top:50px;font-size:2rem;text-shadow:2px 2px 2px #CCCCCC;padding:10px;font-size:1.5rem;" ></asp:Label>
</asp:Content>--%>




















<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Quest_8.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="width:100%;background-color:gold;margin:0px">
    <asp:Label ID="Label1" runat="server" style="font-size:2rem;text-shadow:2px 2px 2px #CCCCCC;padding:10px;font-size:1.5rem;" Text="Sign Up Form:"></asp:Label>
        </div>
   <table runat="server" ID="table1">
       <tr>
           <th>Username:</th>
           <td>
               <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
               <asp:RequiredFieldValidator ErrorMessage="Please enter Username, " ForeColor="Red" ControlToValidate="TextBox2"
                    runat="server" >*</asp:RequiredFieldValidator>
           </td>
       </tr>
       <tr>
           <th>E-mail:</th>
           <td>
               <asp:TextBox ID="TextBox1" runat="server" type="email"></asp:TextBox>
                <asp:RequiredFieldValidator ErrorMessage="Please enter email, " Display="Dynamic" ForeColor="Red"
                    ControlToValidate="TextBox1" runat="server" >*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator runat="server" Display="Dynamic" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                    ControlToValidate="TextBox1" ForeColor="Red" ErrorMessage="Invalid email address." />
           </td>
       </tr>
       <tr>
           <th>Password:</th>
           <td>
               <asp:TextBox ID="TextBox3" runat="server" type="password"></asp:TextBox>
               <asp:RequiredFieldValidator ErrorMessage="Please give password, " ForeColor="Red" ControlToValidate="TextBox3"
                     runat="server" >*</asp:RequiredFieldValidator>
           </td>
       </tr>
       <tr>
           <th>Confirm Password:</th>
           <td>
               <asp:TextBox ID="TextBox4" runat="server" type="password"></asp:TextBox>

               
               <asp:CompareValidator ErrorMessage="Passwords do not match." ForeColor="Red" ControlToCompare="TextBox3"
                    ControlToValidate="TextBox4" runat="server" />
           </td>
       </tr>
       <tr>
           <th>Mobile:</th>
           <td>
               <asp:TextBox ID="TextBox5" runat="server" type="number"></asp:TextBox>
               <asp:RequiredFieldValidator ErrorMessage="please enter your mobile number, " Display="Dynamic" ForeColor="Red"
                    ControlToValidate="TextBox5" runat="server" >*</asp:RequiredFieldValidator>
               <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server"  
ControlToValidate="TextBox5" ErrorMessage="Enter correct mobile number"  
ValidationExpression="[0-9]{10}" ForeColor="Red"></asp:RegularExpressionValidator> 
           </td>
       </tr>
       <tr>
           <th>Gender:</th>
           <td>
               
               <asp:DropDownList ID="DropDownList1" runat="server">
                   <asp:ListItem Value="0" >Unknown</asp:ListItem>
                   <asp:ListItem Value="1">Male</asp:ListItem>
                   <asp:ListItem Value="2">Female</asp:ListItem>
               </asp:DropDownList></td>
           
       </tr>
       <tr>
           <th>Age:</th>
           <td>
               <asp:TextBox ID="TextBox6" runat="server" type="number"></asp:TextBox>
               <asp:RequiredFieldValidator ErrorMessage="Please enter your age, " Display="Dynamic" ForeColor="Red"
                    ControlToValidate="TextBox6" runat="server" >*</asp:RequiredFieldValidator> 
               <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Age should be in between 18-60 only.." ControlToValidate="TextBox6" ForeColor="Red" MaximumValue="60" MinimumValue="18" Display="Dynamic"></asp:RangeValidator>
           </td>
       </tr>
       <tr>
           <td></td>
           <td>
               <asp:Button ID="Button1" Class="btn btn-info" runat="server" Text="Sign Up" OnClick="Button1_Click" />
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red"/>
           <br />
               </td>
       </tr>
   </table>

    
    <asp:Label ID="Label2" runat="server" style="border:1px solid black;margin-left:40px;margin-top:50px;font-size:2rem;text-shadow:2px 2px 2px #CCCCCC;padding:10px;font-size:1.5rem;" ></asp:Label>
</asp:Content>
