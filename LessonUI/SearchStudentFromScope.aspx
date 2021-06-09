<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchStudentFromScope.aspx.cs" Inherits="LessonUI.SearchStudentFromScope" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <center>
            <div>
                学号：
                <asp:TextBox ID="Min" runat="server"></asp:TextBox>
                到:
                <asp:TextBox ID="Max" runat="server"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Text="查找" OnClick="Button1_Click" />
            </div>
        </center>
    </form>
</body>
</html>
