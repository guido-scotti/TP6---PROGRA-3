<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InicioEj2.aspx.cs" Inherits="TP6___PROGRA_3.InicioEj2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:HyperLink ID="HyperLink1" NavigateUrl='SeleccionarProductos.aspx' runat="server">Seleccionar Productos</asp:HyperLink>
        </div>
        <div>
            <asp:linkButton ID="linkButton" NavigateUrl='EliminarProductos.aspx' runat="server" OnClick="linkButton_Click">Eliminar productos</asp:linkButton>
        </div>
        <div>
            <asp:HyperLink ID="HyperLink3" NavigateUrl='ListarProductos.aspx' runat="server">Listar Productos</asp:HyperLink>
        </div>
    </form>
</body>
</html>
