<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainForm.aspx.cs" Inherits="libra.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Menu ID="Menu1" runat="server" OnMenuItemClick="Menu1_MenuItemClick">
            <Items>
                <asp:MenuItem Text="Справочники" Value="sprav">
                    <asp:MenuItem Text="Авторы" Value="avt"></asp:MenuItem>
                    <asp:MenuItem Text="Книги" Value="books"></asp:MenuItem>
                    <asp:MenuItem Text="Студенты" Value="stud"></asp:MenuItem>
                </asp:MenuItem>
                <asp:MenuItem Text="Действия" Value="action">
                    <asp:MenuItem Text="Выдать книгу" Value="vyd"></asp:MenuItem>
                    <asp:MenuItem Text="Возврат книги" Value="vozvr"></asp:MenuItem>
                    <asp:MenuItem Text="Отчеты" Value="otch"></asp:MenuItem>
                </asp:MenuItem>
                <asp:MenuItem Text="Об авторе" Value="about"></asp:MenuItem>
                <asp:MenuItem Text="Помощь" Value="help"></asp:MenuItem>
                <asp:MenuItem Text="Выход" Value="exit"></asp:MenuItem>
            </Items>
        </asp:Menu>
    </form>
</body>
</html>
