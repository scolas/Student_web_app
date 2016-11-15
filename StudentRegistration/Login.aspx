
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="usernamelb" runat="server" Text="User Name"></asp:Label>
      <asp:textbox ID="usernameID" runat="server" ></asp:textbox>
        <br />
        <asp:Label ID="passwordlb" runat="server" Text="Password"></asp:Label>
        <asp:textbox ID="PasswordID" runat="server" Height="18px" Width="143px" ></asp:textbox>
        <br />
        <br />
        <asp:Button ID="Loginbtn" runat="server" Text="Login" OnClick="Loginbtn_Click" />
    </div>
        <asp:Label ID="SessionId" runat="server" text="Session"></asp:Label>
        <br />
        <asp:Label ID="lblStatus" runat="server" Text="Status"></asp:Label>
        <br />
    </form>
</body>
</html>
