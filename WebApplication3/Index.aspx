<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebApplication3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
            <asp:TextBox ID="tbxNombre" runat="server"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Apellidos"></asp:Label>
            <asp:TextBox ID="tbxApellidos" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Edad"></asp:Label>
            <asp:TextBox ID="tbxEdad" runat="server" TextMode="Number"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button2" runat="server" Text="Añadir" OnClick="Button2_Click" />
        </p>
        <p>
            <asp:ListBox ID="lbxPersonas" runat="server"></asp:ListBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Mostrar" OnClick="Button1_Click" />
        </p>
    </form>
</body>
</html>
