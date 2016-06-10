<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmResumenInm.aspx.vb" Inherits="PresentacionWeb.frmResumenInm" %>

<%@ Register assembly="SaimtControlesWeb" namespace="SaimtControlesWeb" tagprefix="cc1" %>
<%@ Register assembly="DevExpress.Web.v16.1, Version=16.1.2.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
<img src="../images/headerazulsmall.png" />
    <cc1:SaimtASPxRoundPanel ID="SaimtASPxRoundPanel1" runat="server" 
        HeaderText="Resumen del Inmueble" Width="600px">
        <PanelCollection>
<dx:PanelContent runat="server" SupportsDisabledAttribute="True">
<table>
<tr>
<td rowspan="2">Código Margesí MPT</td>
<td>File N°</td>
    <td>
        <cc1:SaimtASPxTextBox ID="SaimtASPxTextBox1" runat="server" 
            CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
            SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text="" 
            Width="75px">
        </cc1:SaimtASPxTextBox>
    </td>
    <td>
        Ejido Disponible</td>
</tr>
<tr>
<td>Rubro</td>
    <td>
        <cc1:SaimtASPxTextBox ID="SaimtASPxTextBox2" runat="server" 
            CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
            SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text="" 
            Width="150px">
        </cc1:SaimtASPxTextBox>
    </td>
    <td>
        <cc1:SaimtASPxTextBox ID="SaimtASPxTextBox5" runat="server" 
            CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
            SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text="">
        </cc1:SaimtASPxTextBox>
    </td>
</tr>
<tr>
<td colspan="3">Denominación</td>
    <td rowspan="5">
        <cc1:SaimtASPxBinaryImage ID="SaimtASPxBinaryImage1" runat="server" 
            CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue">
        </cc1:SaimtASPxBinaryImage>
    </td>
</tr>
<tr>
<td colspan="3">
    <cc1:SaimtASPxTextBox ID="SaimtASPxTextBox3" runat="server" 
        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text="">
    </cc1:SaimtASPxTextBox>
    </td>
</tr>
<tr>
<td colspan="3">Ubicación</td>
</tr>
<tr>
<td colspan="3">
    <cc1:SaimtASPxMemo ID="SaimtASPxMemo1" runat="server" 
        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
        Rows="5" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css">
    </cc1:SaimtASPxMemo>
    </td>
</tr>
<tr>
<td colspan="3">Estado de Saneamiento</td>
</tr>
<tr>
<td colspan="3">
    <cc1:SaimtASPxTextBox ID="SaimtASPxTextBox4" runat="server" 
        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text="">
    </cc1:SaimtASPxTextBox>
    </td>
    <td>
        <cc1:SaimtASPxHyperLink ID="SaimtASPxHyperLink1" runat="server" 
            CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue">
        </cc1:SaimtASPxHyperLink>
    </td>
</tr>
</table>
</dx:PanelContent>
</PanelCollection>
    </cc1:SaimtASPxRoundPanel>
    </form>
    
</body>
</html>
