<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListarSucursal.aspx.cs" Inherits="LayerOfView.ListarSucursal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 94%;
        }
        .auto-style2 {
            width: 299px;
        }
        .auto-style3 {
            width: 307px;
        }
        .auto-style4 {
            width: 130px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:HyperLink ID="hlAddBranch" runat="server" NavigateUrl="~/AgregarSucursal.aspx">Agregar Sucursal</asp:HyperLink>
                    </td>
                    <td class="auto-style3">
                        <asp:HyperLink ID="hlListBranch" runat="server" NavigateUrl="~/ListarSucursal.aspx">Listado de Sucursales</asp:HyperLink>
                    </td>
                    <td class="auto-style4">
                        <asp:HyperLink ID="hlDeleteBranch" runat="server" NavigateUrl="~/EliminarSucursal.aspx">Eliminar Sucursal</asp:HyperLink>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <h3 style="margin-top:30px;">Listado Sucursales</h3>
                    </td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td style="margin-top:10px;" class="auto-style2">Busqueda ingrese ID sucursal:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtIdBranch" runat="server" TextMode="Number" Width="280px" /></td>
                    <td class="auto-style4">
                        <asp:Button ID="btnFilter" Text="Filtrar" runat="server" OnClick="btnFilter_Click" /></td>
                    <td>
                        <asp:Button ID="btnViewAll" Text="Mostrar todos" runat="server" OnClick="btnViewAll_Click" /></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>
                        <asp:Label ID="lbMessage" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                </table>
        </div>
                        <asp:GridView ID="grdTable" runat="server"></asp:GridView>
    </form>
</body>
</html>
