<%@ Page Title="" Language="C#" MasterPageFile="~/mantenimiento/segunda.Master" AutoEventWireup="true" CodeBehind="Agregar.aspx.cs" Inherits="CrudMonolito.mantenimiento.Agregar" %>

<asp:Content runat="server" ID="Content2" ContentPlaceHolderID="ContentPlaceHolderHeader">
    
    <a href="Listar.aspx">Productos</a>
    <form id="form1" runat="server">
        <div>
            <h2>Agregar Producto</h2>
            <asp:Label ID="Label1" runat="server" Text="Nombre del Producto"></asp:Label>
            <asp:TextBox ID="txtNombreProducto" runat="server" ></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Cantidad"></asp:Label>
            <asp:TextBox ID="txtCantidad" runat="server" TextMode="Number"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Proveedor"></asp:Label>
            <asp:DropDownList ID="ddl_proveedor" runat="server"></asp:DropDownList>
            <br />
            <asp:Label ID="lblResultado" runat="server" Text=""></asp:Label>
        </div>
        <asp:Button ID="btn_agregar_productos" runat="server" Text="Cargar Producto" OnClick="btn_guardar_Click" />
    </form>
</asp:Content>
<asp:Content runat="server" ID="ContentScripts" ContentPlaceHolderID="ContentPlaceHolderScripts">
</asp:Content>