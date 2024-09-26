<%@ Page Title="" Language="C#" MasterPageFile="~/mantenimiento/segunda.Master" AutoEventWireup="true" CodeBehind="Listar.aspx.cs" Inherits="CrudMonolito.mantenimiento.WebForm1" %>
<asp:Content runat="server" ID="Content2" ContentPlaceHolderID="ContentPlaceHolderHeader">
 
    <h2>Lista de Productos</h2>
    <form id="form1" runat="server">
        <asp:DropDownList ID="ddl_busqueda" runat="server">
            <asp:ListItem Text="Nombre" Value="N"></asp:ListItem>
            <asp:ListItem Text="Cantidad" Value="C"></asp:ListItem>
            <asp:ListItem Text="Proveedor" Value="P"></asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox ID="txt_busqueda" runat="server" OnTextChanged="text_changed_Buscar" AutoPostBack="True"/>
        <asp:GridView ID="gvProductos" runat="server" AutoGenerateColumns="False" OnRowCommand="gvProductos_RowCommand" OnRowDeleting="gvProductos_RowDeleting" DataKeyNames="pro_id">
            <Columns>
                <asp:TemplateField HeaderText="Proveedor ID">
                    <ItemTemplate>
                        <asp:Label ID="prov_id" runat="server" Text='<%# Eval("prov_id") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Nombre del Producto">
                    <ItemTemplate>
                        <asp:Label ID="pro_nombre" runat="server" Text='<%# Eval("pro_nombre") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Cantidad">
                    <ItemTemplate>
                        <asp:Label ID="pro_cantidad" runat="server" Text='<%# Eval("pro_cantidad") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
               
                <asp:TemplateField HeaderText="Acción">
                    <ItemTemplate>
                        <asp:Button ID="btnEditar" runat="server" CommandName="Editar" CommandArgument='<%# Eval("pro_id") %>' Text="Editar" CssClass="btn btn-primary" />
                        <asp:Button ID="btnEliminar" runat="server" CommandName="Borrar" CommandArgument='<%# Eval("pro_id") %>' Text="Eliminar" CssClass="btn btn-danger" OnClientClick="return confirm('¿Estás seguro que deseas eliminar este producto?');" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </form>
</asp:Content>
