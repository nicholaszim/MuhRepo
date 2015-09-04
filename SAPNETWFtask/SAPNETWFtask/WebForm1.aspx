<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="SAPNETWFtask.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="width: 74px; height: 27px">
    <form id="form1" runat="server"> 
        <h3 style="width: 182px">My Resume</h3>
        <table id="contact" cellspacing="0">
            <tr>
                <td>First Name:</td>
                <td><asp:TextBox ID="FNameTB" runat="server" /></td> 
            </tr>
            <tr>
                <td>Last Name:</td>
                <td><asp:TextBox ID="LNameTB" runat="server" /></td> 
            </tr>
            <tr>
                <td>Email:</td>
                <td><asp:TextBox ID="Email" runat="server" /></td> 
            </tr>
            <tr>
                <td>Work Experience:</td>
                <td><asp:TextBox ID="WorkingExp" runat="server" /></td> 
            </tr>
            <tr>
                <td>Education:</td>
                <td><asp:TextBox ID="Education" runat="server" /></td> 
            </tr>
            <tr>
                <td>Foreign Languages:</td>
                <td>
                    <asp:CheckBoxList ID="CheckBoxListFl" runat="server">
                        <asp:ListItem>English</asp:ListItem>
                        <asp:ListItem>German</asp:ListItem>
                        <asp:ListItem>Russian</asp:ListItem>
                        <asp:ListItem>Ukrainian</asp:ListItem>
                        <asp:ListItem>Spanish</asp:ListItem>
                        <asp:ListItem>Italian</asp:ListItem>
                    </asp:CheckBoxList>&nbsp;</td> 
            </tr>
            <tr>
                <td>Display Entered Data</td>
                <td>
                    <asp:Button ID="ButtonDisplay" runat="server" Text="Display" OnClick="ButtonDisplay_Click" /></td> 
            </tr>
            </table>
        </form>
    </body>
</html>
