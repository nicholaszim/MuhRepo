<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="SAPNETWFtask.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
    <h3 style="width: 182px">My Resume</h3>
        <table id="contact" cellspacing="0">
            <tr>
                <td>First Name:</td>
                <td>
                    <asp:Label ID="LabelName2" runat="server" Width="100px"></asp:Label></td> 
            </tr>
            <tr>
                <td>Last Name:</td>
                <td><asp:Label ID="LabelLName2" runat="server" Width="100px"></asp:Label></td> 
            </tr>
            <tr>
                <td>Email:</td>
                <td><asp:Label ID="LabelEmail2" runat="server" Width="100px"></asp:Label></td> 
            </tr>
            <tr>
                <td>Work Experience:</td>
                <td><asp:Label ID="LabelWE2" runat="server" Width="100px"></asp:Label></td> 
            </tr>
            <tr>
                <td>Education:</td>
                <td><asp:Label ID="LabelEdu2" runat="server" Width="100px"></asp:Label></td> 
            </tr>
            <tr>
                <td>Foreign Languages:</td>
                <td>
                    <asp:CheckBoxList ID="CheckBoxListFl2" runat="server">
                        <asp:ListItem>English</asp:ListItem>
                        <asp:ListItem>German</asp:ListItem>
                        <asp:ListItem>Russian</asp:ListItem>
                        <asp:ListItem>Ukrainian</asp:ListItem>
                        <asp:ListItem>Spanish</asp:ListItem>
                        <asp:ListItem>Italian</asp:ListItem>
                    </asp:CheckBoxList>&nbsp;</td> 
            </tr>
            </table>
    </form>
</body>
</html>
