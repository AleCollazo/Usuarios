<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AñadirUsuario.aspx.cs" Inherits="WebApplication3.AñadirUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <ul >
        <li><p>
            <asp:label runat="server" text="Nick"></asp:label>
            <asp:textbox runat="server" ID="tbxNick"></asp:textbox>
        </p></li>
        <li><p>
            <asp:label runat="server" text="Nombre"></asp:label>
            <asp:textbox runat="server" ID="tbxNombre"></asp:textbox>
        </p></li>
        <li><p>
            <asp:label runat="server" text="Apellidos"></asp:label>
            <asp:textbox runat="server" ID="tbxApellidos"></asp:textbox>
        </p></li>
        <li><p>
            <asp:label runat="server" text="email"></asp:label>
            <asp:textbox runat="server" ID="tbxEmail" TextMode="Email"></asp:textbox>
        </p></li>
        <li><p>
            <asp:label runat="server" text="Dirección"></asp:label>
            <asp:textbox runat="server" ID="tbxDireccion" ></asp:textbox>
        </p><li>
        <li><p>
            <asp:label runat="server" text="Teléfono"></asp:label>
            <asp:textbox runat="server" ID="tbxTelefono" textMode="Number"></asp:textbox>
        </p></li>
        <asp:Button ID="btnAñadir" runat="server" Text="Añadir" OnClick="btnAñadir_Click" />
    </ul>
</asp:Content>
