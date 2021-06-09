<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserLogin.aspx.cs" Inherits="LessonUI.UserLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <center>
        <div id = "Login">
            <div id =" "LoginTitle"><p>管理员登录</p></div>
            <div style ="margin-top:50px">
                <asp:Label ID="lblUserName" runat="server" Text="用户"></asp:Label>
                <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                <br/>
                <asp:Label ID="lblPwd" runat="server" Text="密码"></asp:Label>
                <asp:TextBox ID="txtPwd" runat="server"></asp:TextBox>
                <br/>
                <asp:Button ID="BtnLogin" runat="server" Text="登录" OnClick="BtnLogin_Click" />
                <br/>
                管理员:<asp:RadioButton ID="RadioButton1" runat="server" GroupName="Class"></asp:RadioButton>
                学生:<asp:RadioButton ID="RadioButton2" runat="server" GroupName="Class"></asp:RadioButton>
                教师:<asp:RadioButton ID="RadioButton3" runat="server" GroupName="Class"></asp:RadioButton>
        </div>
            </center>
    </form>
</body>
</html>
