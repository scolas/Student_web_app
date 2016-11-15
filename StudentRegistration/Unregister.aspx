<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Unregister.aspx.cs" Inherits="Unregister" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 167px;
        }
        .auto-style3 {
            width: 167px;
            height: 30px;
        }
        .auto-style4 {
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Unregister For course</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label1" runat="server" Text="Student id"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtStudentId" runat="server"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
                </td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblCourses" runat="server" Text="Select Course"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddCourse" runat="server">
                    </asp:DropDownList>
                    <asp:Button ID="Button2" runat="server" Text="Unregister" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    <div>
        <asp:Label ID="lblStat" runat="server" Text="Label"></asp:Label>
    </div>
    </form>
</body>
</html>
