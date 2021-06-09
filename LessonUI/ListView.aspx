<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListView.aspx.cs" Inherits="LessonUI.ListView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
            <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource2" style="text-align: center">
                <AlternatingItemTemplate>
                    <tr style="background-color: #FAFAD2;color: #284775;">
                        <%--<td>
                            <asp:Label ID="IDLabel" runat="server" Text='<%# Eval("ID") %>' />
                        </td>--%>
                        <td>
                            <asp:Label ID="StuNumLabel" runat="server" Text='<%# Eval("StuNum") %>' />
                        </td>
                        <td>
                            <asp:Label ID="StuNameLabel" runat="server" Text='<%# Eval("StuName") %>' />
                        </td>
                        <td>
                            <asp:Label ID="StuClassLabel" runat="server" Text='<%# Eval("StuClass") %>' />
                        </td>
                        <td>
                            <asp:Label ID="SubjectLabel" runat="server" Text='<%# Eval("Subject") %>' />
                        </td>
                        <td>
                            <asp:Label ID="StuAgeLabel" runat="server" Text='<%# Eval("StuAge") %>' />
                        </td>
                        <td>
                            <asp:Label ID="StuPhoneLabel" runat="server" Text='<%# Eval("StuPhone") %>' />
                        </td>
                        <td>
                            <asp:Label ID="StuGenderLabel" runat="server" Text='<%# Eval("StuGender") %>' />
                        </td>
                    </tr>
                </AlternatingItemTemplate>
                <EditItemTemplate>
                    <tr style="background-color: #FFCC66;color: #000080;">
                        <td>
                            <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="更新" />
                            <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="取消" />
                        </td>
                       <%-- <td>
                            <asp:Label ID="IDLabel1" runat="server" Text='<%# Eval("ID") %>' />
                        </td>--%>
                        <td>
                            <asp:TextBox ID="StuNumTextBox" runat="server" Text='<%# Bind("StuNum") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="StuNameTextBox" runat="server" Text='<%# Bind("StuName") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="StuClassTextBox" runat="server" Text='<%# Bind("StuClass") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="SubjectTextBox" runat="server" Text='<%# Bind("Subject") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="StuAgeTextBox" runat="server" Text='<%# Bind("StuAge") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="StuPhoneTextBox" runat="server" Text='<%# Bind("StuPhone") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="StuGenderTextBox" runat="server" Text='<%# Bind("StuGender") %>' />
                        </td>
                    </tr>
                </EditItemTemplate>
                <EmptyDataTemplate>
                    <table runat="server" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                        <tr>
                            <td>未返回数据。</td>
                        </tr>
                    </table>
                </EmptyDataTemplate>
                <InsertItemTemplate>
                    <tr style="">
                        <td>
                            <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="插入" />
                            <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="清除" />
                        </td>
                        <td>&nbsp;</td>
                        <td>
                            <asp:TextBox ID="StuNumTextBox" runat="server" Text='<%# Bind("StuNum") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="StuNameTextBox" runat="server" Text='<%# Bind("StuName") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="StuClassTextBox" runat="server" Text='<%# Bind("StuClass") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="SubjectTextBox" runat="server" Text='<%# Bind("Subject") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="StuAgeTextBox" runat="server" Text='<%# Bind("StuAge") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="StuPhoneTextBox" runat="server" Text='<%# Bind("StuPhone") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="StuGenderTextBox" runat="server" Text='<%# Bind("StuGender") %>' />
                        </td>
                    </tr>
                </InsertItemTemplate>
                <ItemTemplate>
                    <tr style="background-color: #FFFBD6;color: #333333;">
                        <%--<td>
                            <asp:Label ID="IDLabel" runat="server" Text='<%# Eval("ID") %>' />
                        </td>--%>
                        <td>
                            <asp:Label ID="StuNumLabel" runat="server" Text='<%# Eval("StuNum") %>' />
                        </td>
                        <td>
                            <asp:Label ID="StuNameLabel" runat="server" Text='<%# Eval("StuName") %>' />
                        </td>
                        <td>
                            <asp:Label ID="StuClassLabel" runat="server" Text='<%# Eval("StuClass") %>' />
                        </td>
                        <td>
                            <asp:Label ID="SubjectLabel" runat="server" Text='<%# Eval("Subject") %>' />
                        </td>
                        <td>
                            <asp:Label ID="StuAgeLabel" runat="server" Text='<%# Eval("StuAge") %>' />
                        </td>
                        <td>
                            <asp:Label ID="StuPhoneLabel" runat="server" Text='<%# Eval("StuPhone") %>' />
                        </td>
                        <td>
                            <asp:Label ID="StuGenderLabel" runat="server" Text='<%# Eval("StuGender") %>' />
                        </td>
                    </tr>
                </ItemTemplate>
                <LayoutTemplate>
                    <table runat="server">
                        <tr runat="server">
                            <td runat="server">
                                <table id="itemPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                                    <tr runat="server" style="background-color: #FFFBD6;color: #333333;">
                                        <%--<th runat="server">ID</th>--%>
                                        <th runat="server">学号</th>
                                        <th runat="server">名字</th>
                                        <th runat="server">班级</th>
                                        <th runat="server">专业</th>
                                        <th runat="server">年龄</th>
                                        <th runat="server">电话</th>
                                        <th runat="server">性别</th>
                                    </tr>
                                    <tr id="itemPlaceholder" runat="server">
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr runat="server">
                            <td runat="server" style="text-align: center;background-color: #FFCC66;font-family: Verdana, Arial, Helvetica, sans-serif;color: #333333;">
                                <asp:DataPager ID="DataPager1" runat="server">
                                    <Fields>
                                        <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowLastPageButton="True" />
                                    </Fields>
                                </asp:DataPager>
                            </td>
                        </tr>
                    </table>
                </LayoutTemplate>
                <SelectedItemTemplate>
                    <tr style="background-color: #FFCC66;font-weight: bold;color: #000080;">
                        <td>
                            <asp:Label ID="IDLabel" runat="server" Text='<%# Eval("ID") %>' />
                        </td>
                        <td>
                            <asp:Label ID="StuNumLabel" runat="server" Text='<%# Eval("StuNum") %>' />
                        </td>
                        <td>
                            <asp:Label ID="StuNameLabel" runat="server" Text='<%# Eval("StuName") %>' />
                        </td>
                        <td>
                            <asp:Label ID="StuClassLabel" runat="server" Text='<%# Eval("StuClass") %>' />
                        </td>
                        <td>
                            <asp:Label ID="SubjectLabel" runat="server" Text='<%# Eval("Subject") %>' />
                        </td>
                        <td>
                            <asp:Label ID="StuAgeLabel" runat="server" Text='<%# Eval("StuAge") %>' />
                        </td>
                        <td>
                            <asp:Label ID="StuPhoneLabel" runat="server" Text='<%# Eval("StuPhone") %>' />
                        </td>
                        <td>
                            <asp:Label ID="StuGenderLabel" runat="server" Text='<%# Eval("StuGender") %>' />
                        </td>
                    </tr>
                </SelectedItemTemplate>
            </asp:ListView>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="Data Source=localhost;Initial Catalog=note;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [ID], [StuNum], [StuName], [StuClass], [Subject], [StuAge], [StuPhone], [StuGender] FROM [Student]"></asp:SqlDataSource>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
                </center>
        </div>
    </form>
</body>
</html>
