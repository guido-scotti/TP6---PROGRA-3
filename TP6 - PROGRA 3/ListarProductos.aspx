<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListarProductos.aspx.cs" Inherits="TP6___PROGRA_3.ListarProductos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 40px">
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="20pt" Text="Productos seleccionados por el usuario:"></asp:Label>
        </div>
        <asp:GridView ID="gridProductos" runat="server" AutoGenerateColumns="False" Font-Bold="True" Font-Names="Bahnschrift" Font-Size="Medium" Width="933px" AllowPaging="True" PageSize="14">
            <Columns>
                <asp:TemplateField HeaderText="ID de producto">
                    <ItemTemplate>
                        <asp:Label ID="lbl_idProd" runat="server" Text='<%# Bind("IdProducto") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Nombre de producto">
                    <ItemTemplate>
                        <asp:Label ID="lbl_nombreProducto" runat="server" Text='<%# Bind("NombreProducto") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Id Proveedor">
                    <ItemTemplate>
                        <asp:Label ID="lbl_idProveedor" runat="server" Text='<%# Bind("IdProveedor") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Precio Unitario">
                    <ItemTemplate>
                        <asp:Label ID="lbl_precioUnitario" runat="server" Text='<%# Bind("precioUnitario") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <HeaderStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        </asp:GridView>

        <div style="margin-left: 40px">
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
&nbsp;&nbsp;&nbsp;
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='InicioEj2.aspx'>Volver al incio</asp:HyperLink>

    </form>
</body>
</html>
