<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateStudent.aspx.cs" Inherits="LessonUI.UpdateStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblId" runat="server" Text="Id" Visible="False"></asp:Label>
            <asp:Label ID="Label1" runat="server" Text="学号"></asp:Label>
            <asp:TextBox ID="txtStuNum" runat="server"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="姓名"></asp:Label>
            <asp:TextBox ID="txtStuName" runat="server"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" Text="班级"></asp:Label>
            <asp:TextBox ID="txtStuClass" runat="server"></asp:TextBox>
            <asp:Label ID="Label4" runat="server" Text="专业"></asp:Label>
            <asp:TextBox ID="txtSubject" runat="server"></asp:TextBox>
            <asp:Label ID="Label5" runat="server" Text="年龄"></asp:Label>
            <asp:TextBox ID="txtStuAge" runat="server"></asp:TextBox>
            <asp:Label ID="Label6" runat="server" Text="电话"></asp:Label>
            <asp:TextBox ID="txtStuPhone" runat="server"></asp:TextBox>
            <asp:Label ID="Label7" runat="server" Text="性别"></asp:Label>
            男<asp:RadioButton ID="rbMale" runat="server" GroupName="Gender" />
            女<asp:RadioButton ID="rbFemale" runat="server" GroupName="Gender" />
            <asp:Button ID="btnSave" runat="server" Text="保存" OnClick="btnSave_Click" />
            <asp:Button ID="btnClear" runat="server" Text="清除" OnClick="btnClear_Click"/>
        </div>
    </form>
</body>
</html>
