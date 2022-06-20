<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EliminarSucursal.aspx.cs" Inherits="LayerOfView.EliminarSucursal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 169px;
        }
        .auto-style3 {
            width: 288px;
        }
        .auto-style5 {
            width: 169px;
            height: 38px;
        }
        .auto-style6 {
            width: 288px;
            height: 38px;
        }
        .auto-style7 {
            height: 38px;
        }
        .auto-style8 {
            width: 169px;
            height: 35px;
        }
        .auto-style9 {
            width: 288px;
            height: 35px;
        }
        .auto-style10 {
            height: 35px;
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
                        <asp:HyperLink ID="lhListBranch" runat="server" NavigateUrl="~/ListarSucursal.aspx">Listado Sucursales</asp:HyperLink>
                    </td>
                    <td>
                        <asp:HyperLink ID="hlDeleteSucursal" runat="server" NavigateUrl="~/EliminarSucursal.aspx">Eliminar Sucursal</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <h3 style="margin-top:30px;">Eliminar sucursales</h3>
                    </td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <p>Ingrese ID Sucursal: </p>
                    </td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtIdBranch" TextMode="Number" runat="server" Width="280px" /></td>
                    <td class="auto-style7">
                        <asp:Button ID="btnDelete" Text="Eliminar" runat="server" OnClick="btnDelete_Click" /></td>
                </tr>
                <tr>
                    <td class="auto-style8">
                    </td>
                    <td class="auto-style9"></td>
                    <td class="auto-style10"></td>
                </tr>
            </table>
        </div>
        <p>
                        <asp:Label ID="lbMessage" runat="server" ForeColor="Red"></asp:Label>
                    </p>
    </form>
</body>
</html>
