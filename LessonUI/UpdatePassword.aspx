<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdatePassword.aspx.cs" Inherits="LessonUI.UpdatePassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="密码"></asp:Label>
            <asp:TextBox ID="txtPwd" runat="server"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="新密码"></asp:Label>
            <asp:TextBox ID="txtNewPwd" runat="server"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" Text="重复密码"></asp:Label>
            <asp:TextBox ID="txtRePwd" runat="server"></asp:TextBox>
            <asp:Button ID="btnSave" runat="server" Text="Button" OnClick="btnSave_Click" />
        </div>
    </form>
</body>
</html>
