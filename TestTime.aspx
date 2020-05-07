<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestTime.aspx.cs" Inherits="TestTime.TestTime" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: left;
        }
    </style>
</head>

<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
        <div>
            <asp:Label ID="lblTimeOfDay" runat="server" Text=""></asp:Label>
            <br />
            <asp:RadioButton ID="MaleButton" runat="server" Text="Male" AutoPostBack="True" GroupName="Gender" OnCheckedChanged="MaleButton_CheckedChanged" />
            <asp:RadioButton ID="FemaleButton" runat="server"  Text="Female" GroupName="Gender"/>
            <asp:RadioButton ID="UnknownButton" runat="server" Text="Unknown" GroupName="Gender" />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Gender?" OnClick="Button1_Click" />
        </div>
        <asp:Label ID="lblGender" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <asp:TextBox ID="txtSearch" runat="server" AutoPostBack="True" OnTextChanged="txtSearch_TextChanged"></asp:TextBox>
      
        <asp:Button ID="GetProduct" runat="server" Text="Get Product" OnClick="GetProduct_Click" />
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        
        <br />
       <table style="border: 1px solid black; font-family:Arial">
    <tr>
        <td>
            Employee Name
        </td>
        <td>
            <asp:TextBox ID="txtEmployeeName" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
        </td>
    </tr>        
    <tr>
        <td>
            Gender
        </td>
        <td>
            <asp:DropDownList ID="ddlGender" runat="server">
               <asp:ListItem>--Select Gender--</asp:ListItem>
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr> 
    <tr>
        <td>
            Salary
        </td>
        <td>
            <asp:TextBox ID="txtSalary" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
        </td>
    </tr>       
    <tr>
        <td colspan="2">
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            <asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click" />
        </td>
    </tr>          
    <tr>
        <td colspan="2">
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
        </td>
    </tr>  
</table>
        
        </div>
        
    </form>
  
</body>
</html>
