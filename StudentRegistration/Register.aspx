<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 70px;
        }
        .auto-style3 {
            width: 70px;
            height: 23px;
        }
        .auto-style4 {
            width: 70px;
            height: 26px;
        }
        .auto-style5 {
            height: 26px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

         </div>

        <h1>Registration</h1>
        <br />
        <h2>Hello Scott</h2>
    <div>
      <asp:Label ID="SessionId" runat="server" text="Session"></asp:Label>
        <table class="auto-style1">

            <tr>
                <td class="auto-style4"><asp:Label ID="Label2" runat="server" Text="Courses"></asp:Label></td>
                <td class="auto-style5"><asp:DropDownList ID="listCourseOffered" runat="server"  AutoPostBack="True" ></asp:DropDownList></td>
                
            </tr>


            <tr>
                <td class="auto-style2">Student ID</td>
                <td>
                    <asp:TextBox ID="txtStudentID" runat="server" name="Sudent id"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
                </td>
            </tr>

            <tr>
                <td class="auto-style3"><asp:Label ID="c1" runat="server" Text="Label">Lable</asp:Label></td>
                <td>&nbsp;</td>
              
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
