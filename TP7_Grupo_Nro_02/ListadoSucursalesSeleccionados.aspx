﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListadoSucursalesSeleccionados.aspx.cs" Inherits="TP7_Grupo_Nro_02.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Listado sucursales</title>
    <link rel="stylesheet"  type="text/css" href="./Styles/main.css" />
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style4"></td>
                <td class="auto-style3">
                    <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" Font-Size="14pt" NavigateUrl="~/SeleccionarSucursales.aspx">Listado de Sucursales</asp:HyperLink>
                    <br />
                    <br />
                </td>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:HyperLink ID="HyperLink2" runat="server" Font-Bold="True" Font-Size="14pt" NavigateUrl="~/ListadoSucursalesSeleccionados.aspx">Mostrar Sucursales Seleccionadas</asp:HyperLink>
                    <br />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style4"></td>
                <td class="auto-style3" style="font-weight: bold; font-size: 25pt;">Mostrar Sucursales Seleccionadas<br />
                    <br /></td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    &nbsp;</td>
                <td class="auto-style2">
                    &nbsp;</td>
            </tr>
        </table>
       <table class="auto-style5">
    <tr>
        <td class="auto-style4"></td>
    </tr>
    <tr>
        <td>
            <asp:GridView ID="GridView1" runat="server" Height="131px" Width="229px">
            </asp:GridView>
        </td>
    </tr>
</table>
    </form>
</body>
</html>
