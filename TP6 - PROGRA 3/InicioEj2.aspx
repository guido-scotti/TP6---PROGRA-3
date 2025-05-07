<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InicioEj2.aspx.cs" Inherits="TP6___PROGRA_3.InicioEj2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:HyperLink ID="HyperLink1" NavigateUrl='SeleccionarProductos.aspx' runat="server">Seleccionar Productos</asp:HyperLink>
        <asp:HyperLink ID="HyperLink2" NavigateUrl='EliminarProductos.aspx' runat="server">Eliminar productos</asp:HyperLink>
        <asp:HyperLink ID="HyperLink3" NavigateUrl='ListarProductos.aspx' runat="server">Listar Productos</asp:HyperLink>
    </form>
</body>
</html>
