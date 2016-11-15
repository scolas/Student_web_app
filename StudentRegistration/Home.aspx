<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="lblTime" runat="server" text="Server Time"></asp:Label>
        <asp:button ID="btnGetTime" runat="server" text="Get Time" OnClick="btnGetTime_Click" />
        <asp:Label ID="SessionId" runat="server" text="Session"></asp:Label>



        <h2>Welcome to University Application</h2>
        <asp:Label ID="lblSessionID" runat="server" text="Server Time"></asp:Label>
           <br />
           <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Register.aspx">Register</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/StudentsEnrolled.aspx">Enrollment</asp:HyperLink>
        <br />
             <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Login.aspx">Login</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/Transcript.aspx">Transcript</asp:HyperLink>
        <br />    
        <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/Unregister.aspx">Unregister</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="~/Logout.aspx">Logout</asp:HyperLink>
    </div>
    </form>
</body>
</html>
