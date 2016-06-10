<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmInmueble.aspx.vb" Inherits="PresentacionWeb.frmInmueble" Title="..:: Detalle Inmueble ::.." %>

<%@ Register Assembly="SaimtControlesWeb" Namespace="SaimtControlesWeb" TagPrefix="cc1" %>
<%@ Register Assembly="DevExpress.Web.v16.1, Version=16.1.2.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx" %>




<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Styles/estilos.css" media="all" type="text/css" rel="Stylesheet" />
    <style type="text/css">
        .templateTable
        {
            border-collapse: collapse;
            width: 100%;
        }
        .templateTable td
        {
            border: solid 1px #C2D4DA;
            padding: 6px;
        }
        .templateTable td.value
        {
            font-weight: bold;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table width="100%">
            <tr>
                <td>
                    <cc1:SaimtASPxRoundPanel ID="SaimtASPxRoundPanel1" runat="server" HeaderText="Datos Básicos"
                        Width="100%">
                        <PanelCollection>
                            <dx:PanelContent ID="PanelContent1" runat="server" SupportsDisabledAttribute="True">
                                <table width="100%">
                                    <tr>
                                        <td>
                                            <table width="100%" cellspacing="0">
                                                <tr>
                                                    <td class="tdLabel"> <!-- width="24px">-->
                                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel1" runat="server" Text="N° : ">
                                                        </cc1:SaimtASPxLabel>
                                                    </td>
                                                    <td> <!-- width="35px">-->
                                                        <cc1:SaimtASPxLabel ID="lblNroInmueble" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                            CssPostfix="PlasticBlue" Text="000000">
                                                        </cc1:SaimtASPxLabel>
                                                    </td>
                                                    <td class="tdLabel"> <!-- width="60px">-->
                                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel4" runat="server" Text="N° File :">
                                                        </cc1:SaimtASPxLabel>
                                                    </td>
                                                    <td> <!-- width="60px">-->
                                                        <cc1:SaimtASPxTextBox ID="txtNroFile" runat="server" Width="60px">
                                                        </cc1:SaimtASPxTextBox>
                                                    </td>
                                                    <td class="tdLabel"> <!-- width="100px"> -->
                                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel2" runat="server" Text="Denominación :">
                                                        </cc1:SaimtASPxLabel>
                                                    </td>
                                                    <td> <!-- width="300px"> -->
                                                        <cc1:SaimtASPxTextBox ID="txtDenominacion" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                            CssPostfix="PlasticBlue" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                                            Width="100%">
                                                        </cc1:SaimtASPxTextBox>
                                                    </td>
                                                    <td class="tdLabel"> <!-- width="90px">-->
                                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel3" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                            CssPostfix="PlasticBlue" Text="Tipo Unidad :">
                                                        </cc1:SaimtASPxLabel>
                                                    </td>
                                                    <td class="tdLabel"> <!-- width="200px">-->
                                                        <cc1:SaimtASPxTextBox ID="txtTipoUnidad" runat="server" 
                                                            CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                                            SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Width="100%">
                                                        </cc1:SaimtASPxTextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table width="100%" cellspacing="0">
                                                <tr>
                                                    <td class="tdLabel"> <!-- width="95px"> -->
                                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel5" runat="server" Text="Finca Inscrita :">
                                                        </cc1:SaimtASPxLabel>
                                                    </td>
                                                    <td width="60%"><!-- width="527px"> -->
                                                        <cc1:SaimtASPxTextBox ID="txtFincaInscrita" runat="server" Height="16px" 
                                                            Width="100%">
                                                        </cc1:SaimtASPxTextBox>
                                                    </td>
                                                    <td class="tdLabel"> <!-- width="60px"> -->
                                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel6" runat="server" Text="Estado :">
                                                        </cc1:SaimtASPxLabel>
                                                    </td>
                                                    <td> <!-- width="187px"> -->
                                                        <cc1:SaimtASPxTextBox ID="txtEstadoInmueble" runat="server" 
                                                            CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                                            SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Width="100%">
                                                        </cc1:SaimtASPxTextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table width="100%" cellspacing="0">
                                                <tr>
                                                    <td class="tdLabel">
                                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel7" runat="server" Text="Inmueble Principal :">
                                                        </cc1:SaimtASPxLabel>
                                                    </td>
                                                    <td>
                                                        <cc1:SaimtASPxTextBox ID="txtInmueblePrincipal" runat="server" Width="100%">
                                                        </cc1:SaimtASPxTextBox>
                                                    </td>
                                                    <td class="tdLabel">
                                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel8" runat="server" 
                                                            Text="Fecha Registro Margesí :">
                                                        </cc1:SaimtASPxLabel>
                                                    </td>
                                                    <td>
                                                        <cc1:SaimtASPxTextBox ID="txtFechaRegistroMargesi" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                            CssPostfix="PlasticBlue" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                                            Width="100%">
                                                        </cc1:SaimtASPxTextBox>
                                                    </td>
                                                    <td class="tdLabel">
                                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel9" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                            CssPostfix="PlasticBlue" Text="N° Ant. de File :">
                                                        </cc1:SaimtASPxLabel>
                                                    </td>
                                                    <td>
                                                        <cc1:SaimtASPxTextBox ID="txtNroFileAnterior" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                            CssPostfix="PlasticBlue" 
                                                            SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Width="100%">
                                                        </cc1:SaimtASPxTextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                </table>
                            </dx:PanelContent>
                        </PanelCollection>
                    </cc1:SaimtASPxRoundPanel>
                </td>
                <td rowspan="2" valign="top" align="center">
                    <table>
                        <tr>
                            <td>
                                <cc1:SaimtASPxBinaryImage ID="imgPrincipal" runat="server" Height="220px" 
                                    Width="220px">
                                    <EmptyImage Url="~/images/sinImagenPrincipal.png">
                                    </EmptyImage>
                                </cc1:SaimtASPxBinaryImage>
                            </td>
                        </tr>
                        <tr>
                            <td align="center">
                                <cc1:SaimtASPxHyperLink runat="server" Text="Ver Galeria Archivos" CssPostfix="PlasticBlue"
                                    CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" 
                                    ID="SaimtASPxHyperLink1" Visible="False">
                                </cc1:SaimtASPxHyperLink>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    <cc1:SaimtASPxRoundPanel ID="SaimtASPxRoundPanel2" runat="server" 
                        HeaderText="Ubicación" Width="100%">
                        <PanelCollection>
                            <dx:PanelContent runat="server" SupportsDisabledAttribute="True">
                                <table width="100%">
                                    <tr>
                                        <td class="tdLabel"> <!-- width="105px">-->
                                            <cc1:SaimtASPxLabel ID="SaimtASPxLabel10" runat="server" Text="Departamento :">
                                            </cc1:SaimtASPxLabel>
                                        </td>
                                        <td> <!-- width="190px"> -->
                                            <cc1:SaimtASPxTextBox ID="txtDepartamento" runat="server" 
                                                CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                                SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css">
                                            </cc1:SaimtASPxTextBox>
                                        </td>
                                        <td class="tdLabel"><!-- width="100px"> -->
                                            <cc1:SaimtASPxLabel ID="SaimtASPxLabel11" runat="server" Text="Provincia :" 
                                                Wrap="False">
                                            </cc1:SaimtASPxLabel>
                                        </td>
                                        <td> <!-- width="140px">-->
                                            <cc1:SaimtASPxTextBox ID="txtProvincia" runat="server" 
                                                CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                                SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Width="100%">
                                            </cc1:SaimtASPxTextBox>
                                        </td>
                                        <td colspan="2" class="tdLabel"> <!-- width="80px"> -->
                                            <cc1:SaimtASPxLabel ID="SaimtASPxLabel12" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                CssPostfix="PlasticBlue" Text="Distrito :">
                                            </cc1:SaimtASPxLabel>
                                        </td>
                                        <td colspan="2"> <!-- width="334px"> -->
                                            <cc1:SaimtASPxTextBox ID="txtDistrito" runat="server" 
                                                CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                                SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Width="100%">
                                            </cc1:SaimtASPxTextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="tdLabel">
                                            <cc1:SaimtASPxLabel ID="SaimtASPxLabel13" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                CssPostfix="PlasticBlue" Text="Vía :">
                                            </cc1:SaimtASPxLabel>
                                        </td>
                                        <td>
                                            <cc1:SaimtASPxTextBox ID="txtDirVia" runat="server" 
                                                CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                                SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css">
                                            </cc1:SaimtASPxTextBox>
                                        </td>
                                        <td class="tdLabel">
                                            <cc1:SaimtASPxLabel ID="SaimtASPxLabel14" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                CssPostfix="PlasticBlue" Text="Número :">
                                            </cc1:SaimtASPxLabel>
                                        </td>
                                        <td>
                                            <cc1:SaimtASPxTextBox ID="txtDirNumero" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                CssPostfix="PlasticBlue" 
                                                SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Width="100%">
                                            </cc1:SaimtASPxTextBox>
                                        </td>
                                        <td class="tdLabel"> <!-- width="80px"> -->
                                            <cc1:SaimtASPxLabel ID="SaimtASPxLabel15" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                CssPostfix="PlasticBlue" Text="Lote :">
                                            </cc1:SaimtASPxLabel>
                                        </td>
                                        <td> <!-- width="90px"> -->
                                            <cc1:SaimtASPxTextBox ID="txtDirLote" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                CssPostfix="PlasticBlue" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                                Width="100%">
                                            </cc1:SaimtASPxTextBox>
                                        </td>
                                        <td class="tdLabel"> <!-- width="80px"> -->
                                            <cc1:SaimtASPxLabel ID="SaimtASPxLabel16" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                CssPostfix="PlasticBlue" Text="Etapa :">
                                            </cc1:SaimtASPxLabel>
                                        </td>
                                        <td>
                                            <cc1:SaimtASPxTextBox ID="txtDirEtapa" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                CssPostfix="PlasticBlue" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                                Width="100%">
                                            </cc1:SaimtASPxTextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="tdLabel">
                                            <cc1:SaimtASPxLabel ID="SaimtASPxLabel17" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                CssPostfix="PlasticBlue" Text="Localización :">
                                            </cc1:SaimtASPxLabel>
                                        </td>
                                        <td>
                                            <cc1:SaimtASPxTextBox ID="txtDirLocalizacion" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                CssPostfix="PlasticBlue" 
                                                SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css">
                                            </cc1:SaimtASPxTextBox>
                                        </td>
                                        <td class="tdLabel">
                                            <cc1:SaimtASPxLabel ID="SaimtASPxLabel18" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                CssPostfix="PlasticBlue" Text="Manzana :">
                                            </cc1:SaimtASPxLabel>
                                        </td>
                                        <td>
                                            <cc1:SaimtASPxTextBox ID="txtDirManzana" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                CssPostfix="PlasticBlue" 
                                                SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Width="100%">
                                            </cc1:SaimtASPxTextBox>
                                        </td>
                                        <td class="tdLabel">
                                            <cc1:SaimtASPxLabel ID="SaimtASPxLabel19" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                CssPostfix="PlasticBlue" Text="Sub-Lote :">
                                            </cc1:SaimtASPxLabel>
                                        </td>
                                        <td>
                                            <cc1:SaimtASPxTextBox ID="txtDirSubLote" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                CssPostfix="PlasticBlue" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                                Width="100%">
                                            </cc1:SaimtASPxTextBox>
                                        </td>
                                        <td class="tdLabel"> <!-- width="80px"> -->
                                            <cc1:SaimtASPxLabel ID="SaimtASPxLabel20" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                CssPostfix="PlasticBlue" Text="Fase :">
                                            </cc1:SaimtASPxLabel>
                                        </td>
                                        <td>
                                            <cc1:SaimtASPxTextBox ID="txtDirFase" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                CssPostfix="PlasticBlue" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                                Width="100%">
                                            </cc1:SaimtASPxTextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="tdLabel">
                                            <cc1:SaimtASPxLabel ID="SaimtASPxLabel21" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                CssPostfix="PlasticBlue" Text="Referencia :">
                                            </cc1:SaimtASPxLabel>
                                        </td>
                                        <td>
                                            <cc1:SaimtASPxTextBox ID="txtDirReferencia" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                CssPostfix="PlasticBlue" 
                                                SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css">
                                            </cc1:SaimtASPxTextBox>
                                        </td>
                                        <td class="tdLabel">
                                            <cc1:SaimtASPxLabel ID="SaimtASPxLabel22" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                CssPostfix="PlasticBlue" Text="N° Interior :">
                                            </cc1:SaimtASPxLabel>
                                        </td>
                                        <td>
                                            <cc1:SaimtASPxTextBox ID="txtDirNroInterior" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                CssPostfix="PlasticBlue" 
                                                SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Width="100%">
                                            </cc1:SaimtASPxTextBox>
                                        </td>
                                        <td>
                                            &nbsp;
                                        </td>
                                        <td colspan="2" class="tdLabelLeft">
                                            <cc1:SaimtASPxCheckBox ID="chkDirActiva" runat="server" CheckState="Unchecked"
                                                CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue"
                                                SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" 
                                                Text="Dirección Activa">
                                            </cc1:SaimtASPxCheckBox>
                                        </td>
                                        <td>
                                        </td>
                                    </tr>
                                </table>
                            </dx:PanelContent>
                        </PanelCollection>
                    </cc1:SaimtASPxRoundPanel>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <cc1:SaimtASPxRoundPanel ID="SaimtASPxRoundPanel3" runat="server" HeaderText="Perfil del Inmueble"
                        Width="100%" Visible="False">
                        <PanelCollection>
                            <dx:PanelContent ID="PanelContent2" runat="server" SupportsDisabledAttribute="True">
                                <cc1:SaimtASPxPageControl ID="SaimtASPxPageControl1" runat="server" ActiveTabIndex="0"
                                    TabPosition="Left" Width="100%">
                                    <TabPages>
                                        <dx:TabPage Text="Información Legal">
                                            <TabImage Url="~/iconos/informacion.png">
                                            </TabImage>
                                            <TabStyle Height="25px" HorizontalAlign="Left">
                                            </TabStyle>
                                            <ContentCollection>
                                                <dx:ContentControl ID="ContentControl1" runat="server" SupportsDisabledAttribute="True">
                                                    <table width="100%">
                                                        <tr>
                                                            <td>
                                                                <table bgcolor="WhiteSmoke" width="100%" cellspacing="0">
                                                                    <tr>
                                                                        <td class="tdLabel" width="60px">
                                                                            <cc1:SaimtASPxLabel ID="SaimtASPxLabel23" runat="server" Text="Rubros :">
                                                                            </cc1:SaimtASPxLabel>
                                                                        </td>
                                                                        <td width="190px">
                                                                            <cc1:SaimtASPxTextBox ID="txtRubroGrupo" runat="server" 
                                                                                CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                                                                SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Width="100%" 
                                                                                Text="">
                                                                            </cc1:SaimtASPxTextBox>
                                                                        </td>
                                                                        <td class="tdLabel" width="80px">
                                                                            <cc1:SaimtASPxLabel ID="SaimtASPxLabel24" runat="server" Text="Específico :">
                                                                            </cc1:SaimtASPxLabel>
                                                                        </td>
                                                                        <td width="190px">
                                                                            <cc1:SaimtASPxTextBox ID="txtRubroEspecifico" runat="server" 
                                                                                CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                                                                SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Width="100%" 
                                                                                Text="">
                                                                            </cc1:SaimtASPxTextBox>
                                                                        </td>
                                                                        <td class="tdLabelLeft">
                                                                            <cc1:SaimtASPxCheckBox ID="chkDisponibilidad" runat="server" 
                                                                                Text="Disponibilidad">
                                                                            </cc1:SaimtASPxCheckBox>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                <table bgcolor="WhiteSmoke" width="100%" cellspacing="0">
                                                                    <tr>
                                                                        <td class="tdLabel" width="185px">
                                                                            <cc1:SaimtASPxLabel ID="SaimtASPxLabel25" runat="server" 
                                                                                Text="Doc. Acredita la propiedad :">
                                                                            </cc1:SaimtASPxLabel>
                                                                        </td>
                                                                        <td colspan="3">
                                                                            <cc1:SaimtASPxTextBox ID="txtDocAcredita" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                                                CssPostfix="PlasticBlue" 
                                                                                SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Width="100%" 
                                                                                Text="">
                                                                            </cc1:SaimtASPxTextBox>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td class="tdLabel">
                                                                            <cc1:SaimtASPxLabel ID="SaimtASPxLabel26" runat="server" 
                                                                                Text="Situación Legal :">
                                                                            </cc1:SaimtASPxLabel>
                                                                        </td>
                                                                        <td width="270px">
                                                                            <cc1:SaimtASPxTextBox ID="txtSituacionLegal" runat="server" 
                                                                                CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                                                                SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Width="100%" 
                                                                                Text="">
                                                                            </cc1:SaimtASPxTextBox>
                                                                        </td>
                                                                        <td class="tdLabel" width="165px">
                                                                            <cc1:SaimtASPxLabel ID="SaimtASPxLabel28" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                                                CssPostfix="PlasticBlue" Text="Situación :">
                                                                            </cc1:SaimtASPxLabel>
                                                                        </td>
                                                                        <td>
                                                                            <cc1:SaimtASPxTextBox ID="txtSituacion" runat="server" 
                                                                                CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                                                                SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Width="100%" 
                                                                                Text="">
                                                                            </cc1:SaimtASPxTextBox>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td class="tdLabel">
                                                                            <cc1:SaimtASPxLabel ID="SaimtASPxLabel27" runat="server" 
                                                                                Text="Partida Electrónica :">
                                                                            </cc1:SaimtASPxLabel>
                                                                        </td>
                                                                        <td>
                                                                            <cc1:SaimtASPxTextBox ID="txtPartidaElectronica" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                                                CssPostfix="PlasticBlue" 
                                                                                SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Width="100%" 
                                                                                Text="">
                                                                            </cc1:SaimtASPxTextBox>
                                                                        </td>
                                                                        <td class="tdLabel">
                                                                            <cc1:SaimtASPxLabel ID="SaimtASPxLabel31" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                                                CssPostfix="PlasticBlue" Text="Asiento :">
                                                                            </cc1:SaimtASPxLabel>
                                                                        </td>
                                                                        <td>
                                                                            <cc1:SaimtASPxTextBox ID="txtAsiento" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                                                CssPostfix="PlasticBlue" 
                                                                                SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Width="100%" 
                                                                                Text="">
                                                                            </cc1:SaimtASPxTextBox>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                        </td>
                                                                        <td class="tdLabelLeft">
                                                                            <cc1:SaimtASPxCheckBox ID="chkInmuebleActivo" runat="server" CheckState="Unchecked"
                                                                                CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue"
                                                                                SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" 
                                                                                Text="Inmueble Activo">
                                                                            </cc1:SaimtASPxCheckBox>
                                                                        </td>
                                                                        <td class="tdLabel">
                                                                            <cc1:SaimtASPxLabel ID="SaimtASPxLabel29" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                                                CssPostfix="PlasticBlue" Text="Estado Saneamiento :">
                                                                            </cc1:SaimtASPxLabel>
                                                                        </td>
                                                                        <td>
                                                                            <cc1:SaimtASPxTextBox ID="txtEstadoSaneamiento" runat="server" 
                                                                                CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                                                                SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Width="100%" 
                                                                                Text="">
                                                                            </cc1:SaimtASPxTextBox>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="tdLabelLeft">
                                                                <cc1:SaimtASPxLabel ID="SaimtASPxLabel30" runat="server" 
                                                                    Text="Observación Legal :">
                                                                </cc1:SaimtASPxLabel>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                <cc1:SaimtASPxMemo ID="txtObservacionLegal" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                                    CssPostfix="PlasticBlue" Height="70px" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                                                    Width="100%">
                                                                </cc1:SaimtASPxMemo>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </dx:ContentControl>
                                            </ContentCollection>
                                        </dx:TabPage>
                                        <dx:TabPage Text="Información Técnica">
                                            <TabImage Url="~/iconos/fichatecnica.png">
                                            </TabImage>
                                            <TabStyle Height="25px" HorizontalAlign="Left">
                                            </TabStyle>
                                            <ContentCollection>
                                                <dx:ContentControl ID="ContentControl2" runat="server" SupportsDisabledAttribute="True">
                                                    <table width="100%">
                                                        <tr>
                                                            <td>
                                                                <cc1:SaimtASPxRoundPanel runat="server" HeaderText="Valor de Predio" 
                                                                    SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" 
                                                                    CssPostfix="PlasticBlue" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" 
                                                                    ID="SaimtASPxRoundPanel4" Width="100%"><PanelCollection>
<dx:PanelContent runat="server" SupportsDisabledAttribute="True">
                                                                            <table width="100%">
                                                                                <tr>
                                                                                    <td class="tdLabel" width="120px">
                                                                                        <cc1:SaimtASPxLabel runat="server" Text="Area (m2) :" CssPostfix="PlasticBlue" 
                                                                                            CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" ID="SaimtASPxLabel32"></cc1:SaimtASPxLabel>

                                                                                    </td>
                                                                                    <td width="155px">
                                                                                        <cc1:SaimtASPxTextBox runat="server" Width="100%" 
                                                                                            SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" 
                                                                                            CssPostfix="PlasticBlue" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" 
                                                                                            ID="txtPredArea" Text=""></cc1:SaimtASPxTextBox>

                                                                                    </td>
                                                                                    <td class="tdLabel" width="160px">
                                                                                        <cc1:SaimtASPxLabel runat="server" Text="Arancel X M2 :" 
                                                                                            CssPostfix="PlasticBlue" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" 
                                                                                            ID="SaimtASPxLabel33"></cc1:SaimtASPxLabel>

                                                                                    </td>
                                                                                    <td width="170px">
                                                                                        <cc1:SaimtASPxTextBox runat="server" Width="100%" 
                                                                                            SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" 
                                                                                            CssPostfix="PlasticBlue" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" 
                                                                                            ID="txtPredArancel" Text=""></cc1:SaimtASPxTextBox>

                                                                                    </td>
                                                                                    <td class="tdLabel" width="205px">
                                                                                        <cc1:SaimtASPxLabel runat="server" Text="Valor Arancelario del Terreno :" 
                                                                                            CssPostfix="PlasticBlue" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" 
                                                                                            ID="SaimtASPxLabel34"></cc1:SaimtASPxLabel>

                                                                                    </td>
                                                                                    <td>
                                                                                        <cc1:SaimtASPxTextBox runat="server" Width="100%" 
                                                                                            SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" 
                                                                                            CssPostfix="PlasticBlue" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" 
                                                                                            ID="txtPredValorArancelario" Text=""></cc1:SaimtASPxTextBox>

                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td class="tdLabel">
                                                                                        <cc1:SaimtASPxLabel runat="server" Text="A. Techada (m2) :" 
                                                                                            CssPostfix="PlasticBlue" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" 
                                                                                            ID="SaimtASPxLabel35"></cc1:SaimtASPxLabel>

                                                                                    </td>
                                                                                    <td>
                                                                                        <cc1:SaimtASPxTextBox runat="server" Width="100%" 
                                                                                            SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" 
                                                                                            CssPostfix="PlasticBlue" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" 
                                                                                            ID="txtPredAreaTechada" Text=""></cc1:SaimtASPxTextBox>

                                                                                    </td>
                                                                                    <td class="tdLabel">
                                                                                        <cc1:SaimtASPxLabel runat="server" Text="Val. Construcción x m2 :" 
                                                                                            CssPostfix="PlasticBlue" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" 
                                                                                            ID="SaimtASPxLabel36"></cc1:SaimtASPxLabel>

                                                                                    </td>
                                                                                    <td>
                                                                                        <cc1:SaimtASPxTextBox runat="server" Width="100%" 
                                                                                            SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" 
                                                                                            CssPostfix="PlasticBlue" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" 
                                                                                            ID="txtPredValorConstruccion" Text=""></cc1:SaimtASPxTextBox>

                                                                                    </td>
                                                                                    <td class="tdLabel">
                                                                                        <cc1:SaimtASPxLabel runat="server" Text="Valor Total de la Construcción :" 
                                                                                            CssPostfix="PlasticBlue" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" 
                                                                                            ID="SaimtASPxLabel37"></cc1:SaimtASPxLabel>

                                                                                    </td>
                                                                                    <td>
                                                                                        <cc1:SaimtASPxTextBox runat="server" Width="100%" 
                                                                                            SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" 
                                                                                            CssPostfix="PlasticBlue" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" 
                                                                                            ID="txtPredValorTotalConstruccion" Text=""></cc1:SaimtASPxTextBox>

                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td class="tdLabel">
                                                                                        <cc1:SaimtASPxLabel runat="server" Text="Fecha Tasación :" 
                                                                                            CssPostfix="PlasticBlue" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" 
                                                                                            ID="SaimtASPxLabel38"></cc1:SaimtASPxLabel>

                                                                                    </td>
                                                                                    <td>
                                                                                        <cc1:SaimtASPxTextBox ID="txtFechaTasacion" runat="server" 
                                                                                            CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                                                                            SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text="" 
                                                                                            Width="100%">
                                                                                        </cc1:SaimtASPxTextBox>

                                                                                    </td>
                                                                                    <td>
                                                                                    </td>
                                                                                    <td class="tdLabelLeft">
                                                                                        <cc1:SaimtASPxCheckBox runat="server" CheckState="Unchecked" 
                                                                                            Text="Predio Activo" 
                                                                                            SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" 
                                                                                            CssPostfix="PlasticBlue" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" 
                                                                                            ID="chkPredActivo"></cc1:SaimtASPxCheckBox>

                                                                                    </td>
                                                                                    <td class="tdLabel">
                                                                                        <cc1:SaimtASPxLabel runat="server" Text="Valor Total :" 
                                                                                            CssPostfix="PlasticBlue" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" 
                                                                                            ID="SaimtASPxLabel39"></cc1:SaimtASPxLabel>

                                                                                    </td>
                                                                                    <td>
                                                                                        <cc1:SaimtASPxTextBox runat="server" Width="100%" 
                                                                                            SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" 
                                                                                            CssPostfix="PlasticBlue" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" 
                                                                                            ID="txtPredValorTotal" Text=""></cc1:SaimtASPxTextBox>

                                                                                    </td>
                                                                                </tr>
                                                                            </table>
                                                                        </dx:PanelContent>
</PanelCollection>
</cc1:SaimtASPxRoundPanel>

                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                <table>
                                                                    <tr>
                                                                        <td class="tdLabel" width="160px">
                                                                            <cc1:SaimtASPxLabel runat="server" Text="Estado de Conservación :" 
                                                                                CssPostfix="PlasticBlue" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" 
                                                                                ID="SaimtASPxLabel40"></cc1:SaimtASPxLabel>

                                                                        </td>
                                                                        <td width="150px">
                                                                            <cc1:SaimtASPxTextBox runat="server" 
                                                                                SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" 
                                                                                CssPostfix="PlasticBlue" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" 
                                                                                ID="txtEstadoConservacion" Text="" Width="100%"></cc1:SaimtASPxTextBox>

                                                                        </td>
                                                                        <td class="tdLabel" width="85px">
                                                                            <cc1:SaimtASPxLabel runat="server" Text="N° de Pisos :" 
                                                                                CssPostfix="PlasticBlue" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" 
                                                                                ID="SaimtASPxLabel41"></cc1:SaimtASPxLabel>

                                                                        </td>
                                                                        <td width="50px">
                                                                            <cc1:SaimtASPxTextBox runat="server" Width="50px" 
                                                                                SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" 
                                                                                CssPostfix="PlasticBlue" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" 
                                                                                ID="txtNroPisos" Text=""></cc1:SaimtASPxTextBox>

                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="tdLabelLeft">
                                                                <cc1:SaimtASPxLabel ID="SaimtASPxLabel48" runat="server" 
                                                                    CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                                                    Text="Observación Técnica :">
                                                                </cc1:SaimtASPxLabel>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                <cc1:SaimtASPxMemo ID="txtObservacionTecnica" runat="server" Width="100%" 
                                                                    Height="60px">
                                                                </cc1:SaimtASPxMemo>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </dx:ContentControl>
                                            </ContentCollection>
                                        </dx:TabPage>
                                        <dx:TabPage Text="Archivos">
                                            <TabImage Url="~/iconos/archivo1.png">
                                            </TabImage>
                                            <TabStyle Height="25px" HorizontalAlign="Left">
                                            </TabStyle>
                                            <ContentCollection>
                                                <dx:ContentControl ID="ContentControl3" runat="server" SupportsDisabledAttribute="True">
                                                    <cc1:SaimtASPxGridView ID="dgvArchivos" runat="server" 
                                                        AutoGenerateColumns="False" Width="100%">
                                                        <Columns>
                                                            <dx:GridViewDataTextColumn Caption="Nombre" ShowInCustomizationForm="True" 
                                                                VisibleIndex="1" FieldName="inmArchNombre">
                                                            </dx:GridViewDataTextColumn>
                                                            <dx:GridViewDataTextColumn Caption="Descripción" ShowInCustomizationForm="True" 
                                                                VisibleIndex="2" FieldName="inmArchDescripcion">
                                                            </dx:GridViewDataTextColumn>
                                                            <dx:GridViewDataTextColumn Caption="Tipo Archivo" ShowInCustomizationForm="True"
                                                                VisibleIndex="3">
                                                            </dx:GridViewDataTextColumn>
                                                            <dx:GridViewDataTextColumn Caption="Extensión" ShowInCustomizationForm="True" 
                                                                VisibleIndex="4">
                                                            </dx:GridViewDataTextColumn>
                                                            <dx:GridViewDataHyperLinkColumn Caption="Acción" ShowInCustomizationForm="True" 
                                                                VisibleIndex="5">
                                                            </dx:GridViewDataHyperLinkColumn>
                                                            <dx:GridViewDataHyperLinkColumn Caption="Vista Previa" ShowInCustomizationForm="True"
                                                                VisibleIndex="6">
                                                            </dx:GridViewDataHyperLinkColumn>
                                                            <dx:GridViewDataTextColumn Caption="Id" FieldName="inmArchId" 
                                                                ShowInCustomizationForm="True" Visible="False" VisibleIndex="0">
                                                            </dx:GridViewDataTextColumn>
                                                        </Columns>

<Images SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"></Images>

                                                        <Styles CssPostfix="PlasticBlue" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css">
                                                        </Styles>
                                                    </cc1:SaimtASPxGridView>
                                                </dx:ContentControl>
                                            </ContentCollection>
                                        </dx:TabPage>
                                        <dx:TabPage Text="Divisiones">
                                            <TabImage Url="~/iconos/divisiones16.png">
                                            </TabImage>
                                            <TabStyle Height="25px" HorizontalAlign="Left">
                                            </TabStyle>
                                            <ContentCollection>
                                                <dx:ContentControl ID="ContentControl4" runat="server" SupportsDisabledAttribute="True">
                                                    <!-- Codigo para el CardView -->
                                                    <table>
                                                        <tr>
                                                            <td>
                                                                <cc1:SaimtASPxDataView ID="SaimtASPxDataView1" runat="server" ColumnCount="2">
                                                                    <ItemTemplate>
                                                                        <table border="1">
                                                                            <tr>
                                                                                <td rowspan="6">
                                                                                    <cc1:SaimtASPxBinaryImage ID="SaimtASPxBinaryImage1" runat="server">
                                                                                    </cc1:SaimtASPxBinaryImage>
                                                                                </td>
                                                                                <td>
                                                                                    <cc1:SaimtASPxLabel ID="SaimtASPxLabel42" runat="server" Text="N° File">
                                                                                    </cc1:SaimtASPxLabel>
                                                                                </td>
                                                                                <td>
                                                                                    <cc1:SaimtASPxTextBox ID="SaimtASPxTextBox26" runat="server" Width="120px">
                                                                                    </cc1:SaimtASPxTextBox>
                                                                                </td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td>
                                                                                    <cc1:SaimtASPxLabel ID="SaimtASPxLabel43" runat="server" Text="Distrito">
                                                                                    </cc1:SaimtASPxLabel>
                                                                                </td>
                                                                                <td>
                                                                                    <cc1:SaimtASPxTextBox ID="SaimtASPxTextBox27" runat="server">
                                                                                    </cc1:SaimtASPxTextBox>
                                                                                </td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td>
                                                                                    <cc1:SaimtASPxLabel ID="SaimtASPxLabel44" runat="server" Text="Rubro">
                                                                                    </cc1:SaimtASPxLabel>
                                                                                </td>
                                                                                <td>
                                                                                    <cc1:SaimtASPxTextBox ID="SaimtASPxTextBox28" runat="server">
                                                                                    </cc1:SaimtASPxTextBox>
                                                                                </td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td>
                                                                                    <cc1:SaimtASPxLabel ID="SaimtASPxLabel45" runat="server" Text="Ubicación">
                                                                                    </cc1:SaimtASPxLabel>
                                                                                </td>
                                                                                <td>
                                                                                    <cc1:SaimtASPxTextBox ID="SaimtASPxTextBox29" runat="server">
                                                                                    </cc1:SaimtASPxTextBox>
                                                                                </td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td>
                                                                                    <cc1:SaimtASPxLabel ID="SaimtASPxLabel46" runat="server" Text="Denominación">
                                                                                    </cc1:SaimtASPxLabel>
                                                                                </td>
                                                                                <td>
                                                                                    <cc1:SaimtASPxTextBox ID="SaimtASPxTextBox30" runat="server">
                                                                                    </cc1:SaimtASPxTextBox>
                                                                                </td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td>
                                                                                    <cc1:SaimtASPxLabel ID="SaimtASPxLabel47" runat="server" Text="Ant. N° File">
                                                                                    </cc1:SaimtASPxLabel>
                                                                                </td>
                                                                                <td>
                                                                                    <cc1:SaimtASPxTextBox ID="SaimtASPxTextBox31" runat="server">
                                                                                    </cc1:SaimtASPxTextBox>
                                                                                </td>
                                                                            </tr>
                                                                        </table>
                                                                    </ItemTemplate>
                                                                </cc1:SaimtASPxDataView>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </dx:ContentControl>
                                            </ContentCollection>
                                        </dx:TabPage>
                                    </TabPages>
                                </cc1:SaimtASPxPageControl>
                            </dx:PanelContent>
                        </PanelCollection>
                    </cc1:SaimtASPxRoundPanel>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
