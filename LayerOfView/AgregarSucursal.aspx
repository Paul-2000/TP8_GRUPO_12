<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarSucursal.aspx.cs" Inherits="LayerOfView.AgregarSucursal" %>

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
            width: 301px;
        }
        .auto-style3 {
            width: 320px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:HyperLink ID="hlAddBranchOffices" runat="server" NavigateUrl="~/AgregarSucursal.aspx">Agregar Sucursales</asp:HyperLink>
                    </td>
                    <td class="auto-style3">
                        <asp:HyperLink ID="hlListBranchOffices" runat="server" NavigateUrl="~/ListarSucursal.aspx">Listado de Sucursales</asp:HyperLink>
                    </td>
                    <td>
                        <asp:HyperLink ID="hlDeleteBranchOffice" runat="server" NavigateUrl="~/EliminarSucursal.aspx.cs">Eliminar Sucursal</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <h1 style="margin-top:30px">GRUPO N° 12</h1>
                    </td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <h4>Agregar Sucursal</h4>
                    </td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Nombre Sucursal</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtBranchName" runat="server" ValidationGroup="GroupOne" ></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="rfvBranchName" runat="server" ControlToValidate="txtBranchName" ErrorMessage="Debe ingresar un Nombre para la sucursal" ForeColor="Red" ValidationGroup="GroupOne">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Descripción</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtBranchDescription" runat="server" ValidationGroup="GroupOne" /></td>
                    <td>
                        <asp:RequiredFieldValidator ID="rfvBranchDescription" runat="server" ControlToValidate="txtBranchDescription" ErrorMessage="Debe ingresar una descripción para la sucursal" ForeColor="Red" ValidationGroup="GroupOne">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Provincia</td>
                    <td class="auto-style3">
                        <asp:DropDownList ID="ddlBranchProvince" runat="server" AutoPostBack="True" ValidationGroup="GroupOne"></asp:DropDownList></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Dirección</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtBranchAddress" runat="server" ValidationGroup="GroupOne" /></td>
                    <td>
                        <asp:RequiredFieldValidator ID="rfvBranchAddress" runat="server" ControlToValidate="txtBranchAddress" ErrorMessage="Debe ingresar una dirección para la sucursal" ForeColor="Red" ValidationGroup="GroupOne">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>
                        <asp:Label ID="lbResult" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:Button ID="btnAccept" Text="Aceptar" runat="server" ValidationGroup="GroupOne" OnClick="btnAccept_Click" /></td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        <asp:ValidationSummary ID="vsValidations" runat="server" ShowMessageBox="True" ShowSummary="False" ValidationGroup="GroupOne" />
    </form>
</body>
</html>
