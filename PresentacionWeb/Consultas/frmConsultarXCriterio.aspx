<%@ Page Title="..:: Consultor de Inmuebles ::.." Language="vb" AutoEventWireup="false"
    MasterPageFile="~/Site.Master" CodeBehind="frmConsultarXCriterio.aspx.vb" Inherits="PresentacionWeb.frmConsultarXCriterio" meta:resourcekey="PageResource1" %>

<%@ Register Assembly="DevExpress.Web.v16.1, Version=16.1.2.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx" %>

<%@ Register Assembly="SaimtControlesWeb" Namespace="SaimtControlesWeb" TagPrefix="cc1" %>




<%@ Register Assembly="DevExpress.Xpo.v16.1, Version=16.1.2.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Xpo" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <link href="../Styles/estilos.css" media="all" type="text/css" rel="Stylesheet" />
    <style type="text/css">
        .templateTable
        {
            border-collapse: collapse;
            width: 100%;
            background-color: #FFFFFF;
        }
        .templateTable td
        {
            border: solid 1px #C2D4DA;
            padding: 3px;
            color: #000000;
        }
        .templateTable td.value
        {
            font-weight: bold;
        }
        .style1
        {
            width: 28px;
        }
        </style>
    <script type="text/javascript">
	// <![CDATA[
        function ShowLoginWindow(parametro) {
            pcInmueble.SetContentUrl("frmInmueble.aspx?id=" + parametro.toString());
            pcInmueble.Show();
        }        
	// ]]> 
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table width="990">
        <tr>
            <td width="100%">
                  
                <cc1:SaimtASPxPanel ID="SaimtASPxPanel11" runat="server" BackColor="WhiteSmoke" Border-BorderColor="#B8B8B8"
                                Border-BorderStyle="Solid" Border-BorderWidth="1px" 
                                CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                meta:resourcekey="SaimtASPxPanel11Resource1" Width="990px">
                                <PanelCollection>
                                    <dx:PanelContent ID="PanelContent10" runat="server" 
                                        SupportsDisabledAttribute="True" 
                                        meta:resourcekey="PanelContent10Resource1">
                                        <table cellspacing="3" cellpadding="3" width="100%">
                                            <tr>
                                                <td style="text-align: right">
                                                    Departamento :</td>
                                                <td>
                                                    <cc1:SaimtASPxTextBox ID="txtDepartamento" runat="server" 
                                                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                                        meta:resourceKey="txtLocalizacionResource1" 
                                                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text="" 
                                                        Width="170px">
                                                    </cc1:SaimtASPxTextBox>
                                                </td>
                                                <td style="text-align: center">Provincia :</td>
                                                <td style="text-align: center" colspan="5" >
                                                    <cc1:SaimtASPxTextBox ID="txtProvincia" runat="server" 
                                                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                                        meta:resourceKey="txtLocalizacionResource1" 
                                                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text="" 
                                                        Width="200px">
                                                    </cc1:SaimtASPxTextBox>
                                                </td>
                                                    
                                                <td style="text-align: right">
                                                    Distrito:</td>
                                                <td>
                                                    <cc1:SaimtASPxTextBox ID="txtDistrito" runat="server" 
                                                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                                        meta:resourceKey="txtLocalizacionResource1" 
                                                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text="" 
                                                        Width="150px">
                                                    </cc1:SaimtASPxTextBox>
                                                </td>
                                                
                                            </tr>
                                            <tr>
                                                <td style="text-align: right">
                                                    Localización :</td>
                                                <td>
                                                    <cc1:SaimtASPxComboBox ID="cboLocalizacion" runat="server" 
                                                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                                        meta:resourcekey="cboLocalizacionResource1" 
                                                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" 
                                                        ValueType="System.String" >
                                                    </cc1:SaimtASPxComboBox>
                                                </td>
                                                <td>
                                                    <cc1:SaimtASPxTextBox ID="txtLocalizacion" runat="server" 
                                                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                                        meta:resourcekey="txtLocalizacionResource1" 
                                                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text="" Width="100%" 
                                                        >
                                                    </cc1:SaimtASPxTextBox>
                                                </td>
                                                
                                                <td colspan="2">
                                                    <cc1:SaimtASPxComboBox ID="cboTipoNro" runat="server" 
                                                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                                        meta:resourceKey="cboTipoNroResource1" 
                                                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" 
                                                        ValueType="System.String" Width="100px">
                                                    </cc1:SaimtASPxComboBox>
                                                </td>
                                                <td colspan="2">
                                                    <cc1:SaimtASPxTextBox ID="txtNroUbicacion" runat="server" 
                                                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                                        meta:resourcekey="txtLocalizacion0Resource1" 
                                                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text="" 
                                                        Width="80px" >
                                                    </cc1:SaimtASPxTextBox>
                                                </td>
                                                <td class="style1">
                                                    <cc1:SaimtASPxComboBox ID="cboTipoSubNro" runat="server" 
                                                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                                        meta:resourcekey="cboTipoSubNroResource1" 
                                                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" 
                                                        ValueType="System.String" Width="110px">
                                                    </cc1:SaimtASPxComboBox>
                                                </td>
                                                <td colspan="2">
                                                    <cc1:SaimtASPxTextBox ID="txtSubNro" runat="server" 
                                                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                                        meta:resourceKey="txtLocalizacion1Resource1" 
                                                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text="" 
                                                        Width="200px">
                                                    </cc1:SaimtASPxTextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="text-align: right">
                                                    &nbsp;</td>
                                                <td>
                                                    <cc1:SaimtASPxComboBox ID="cboSubDistritos" runat="server" 
                                                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                                        meta:resourceKey="cboSubDistritosResource1" 
                                                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" 
                                                        ValueType="System.String" OnSelectedIndexChanged="cboSubDistritos_SelectedIndexChanged" AutoPostBack="true">
                                                    </cc1:SaimtASPxComboBox>
                                                </td>
                                                <td>
                                                    <cc1:SaimtASPxTextBox ID="txtsubdistritoText" runat="server" 
                                                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                                        meta:resourceKey="txtLocalizacion2Resource1" 
                                                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text="" 
                                                        Width="100%">
                                                    </cc1:SaimtASPxTextBox>
                                                    <cc1:SaimtASPxComboBox ID="txtsubdistritoscbo" runat="server" 
                                                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                                        meta:resourceKey="cboTipoNroResource1" 
                                                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" 
                                                        ValueType="System.String" Width="100px">
                                                    </cc1:SaimtASPxComboBox>
                                                </td>
                                                <td>
                                                    Etapa :</td>
                                                <td colspan="2">
                                                    <cc1:SaimtASPxTextBox ID="txtEtapa" runat="server" 
                                                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                                        meta:resourceKey="txtEtapaResource1" 
                                                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text="" 
                                                        Width="50px">
                                                    </cc1:SaimtASPxTextBox>
                                                </td>
                                                <td>
                                                    Fase :</td>
                                                <td class="style1">
                                                    <cc1:SaimtASPxTextBox ID="txtFase" runat="server" 
                                                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                                        meta:resourceKey="txtFaseResource1" 
                                                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text="" 
                                                        Width="50px">
                                                    </cc1:SaimtASPxTextBox>
                                                </td>
                                                <td>
                                                    Sector :</td>
                                                <td>
                                                    <cc1:SaimtASPxTextBox ID="txtSector" runat="server" 
                                                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                                        meta:resourceKey="txtFaseResource1" 
                                                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text="" 
                                                        Width="150px">
                                                    </cc1:SaimtASPxTextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="text-align: right">
                                                    Rubros :</td>
                                                <td>
                                                    <cc1:SaimtASPxComboBox ID="cboRubroGrupos" runat="server" 
                                                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" 
                                                        ValueType="System.String" OnSelectedIndexChanged ="cboRubroGrupos_SelectedIndexChanged" AutoPostBack="true">
                                                    </cc1:SaimtASPxComboBox>
                                                </td>
                                                <td>
                                                    <cc1:SaimtASPxComboBox ID="cboRubro" runat="server" 
                                                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" 
                                                        ValueType="System.String" Width="100%">
                                                    </cc1:SaimtASPxComboBox>
                                                </td>
                                                <td style="text-align: right">
                                                    Adicional :
                                                </td>
                                                <td style="text-align: right" colspan="3">
                                                    <cc1:SaimtASPxTextBox ID="txtBarrio" runat="server" 
                                                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text="">
                                                    </cc1:SaimtASPxTextBox>
                                                </td>
                                                <td style="text-align: right">
                                                    &nbsp;</td>
                                                <td>
                                                    Barrio :</td>
                                                
                                                <td>
                                                    <cc1:SaimtASPxTextBox ID="txtdireccionAdicional" runat="server" 
                                                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text="" 
                                                        Width="150px">
                                                    </cc1:SaimtASPxTextBox>
                                                </td>
                                                
                                            </tr>
                                        </table>
                                    </dx:PanelContent>
                                </PanelCollection>
                                <Border BorderColor="#B8B8B8" BorderStyle="Solid" BorderWidth="1px"></Border>
                            </cc1:SaimtASPxPanel></td>
        </tr>
        <tr>
            <td align="center" width="100%">
                <cc1:SaimtASPxButton ID="btnBuscarInmuebles" runat="server" ImagePosition="Right"
                    Text="Buscar" Width="100px" 
                    CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                    meta:resourcekey="btnBuscarInmueblesResource1" 
                    SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css">
                    <Image Url="~/iconos/buscar32x32.png">
                    </Image>
                </cc1:SaimtASPxButton>
            </td>
        </tr>
        <tr>
            <td width="100%">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td width="100%">
                <cc1:SaimtASPxDataView ID="dvInmuebles" runat="server" ColumnCount="1"  CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                    CssPostfix="PlasticBlue" RowPerPage="5" Width="100%"
                    EmptyDataText="No Se Encontraron Resultados" 
                    LoadingPanelText="Cargando..." 
                    SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" 
                    Visible="False"    >
                    <ItemTemplate>
                        <table class="templateTable" width="100%">
                            <tr>
                                <td>
                                    <cc1:SaimtASPxLabel ID="SaimtASPxLabel1" runat="server" 
                                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                        meta:resourcekey="SaimtASPxLabel1Resource1" Text='<%# Eval("InmFile") %>'>
                                    </cc1:SaimtASPxLabel>
                                </td>
                                <td class="value">
                                    <cc1:SaimtASPxLabel ID="SaimtASPxLabel4" runat="server" 
                                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                        meta:resourcekey="SaimtASPxLabel1Resource1" Text='<%# Eval("tgRubro") %>'>
                                    </cc1:SaimtASPxLabel>
                                </td>
                                <td>
                                    <cc1:SaimtASPxLabel ID="SaimtASPxLabel3" runat="server" 
                                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                        meta:resourcekey="SaimtASPxLabel3Resource1" Text='<%# Eval("InmUbicacion") %>'>
                                    </cc1:SaimtASPxLabel>
                                </td>
                                <td class="value">
                                    <cc1:SaimtASPxLabel ID="SaimtASPxLabel5" runat="server" 
                                        Text='<%# Eval("tgDistrito") %>' 
                                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                        meta:resourcekey="SaimtASPxLabel3Resource1">
                                    </cc1:SaimtASPxLabel>
                                </td>
                                <td class="value">
                                    <cc1:SaimtASPxLabel ID="SaimtASPxLabel2" runat="server" 
                                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                        meta:resourcekey="SaimtASPxLabel2Resource1" Text='<%# Eval("ImnId") %>'>
                                    </cc1:SaimtASPxLabel>
                                </td>
                                <td class="value">
                                    &nbsp;</td>
                                <td class="value">
                                    &nbsp;</td>
                            </tr>
                        </table>
                    </ItemTemplate>
                    <PagerStyle ForeColor="White" />
                    <EmptyDataTemplate>
                        <table class="templateTable" width="100%">
                            <tr>
                                <td align="center" style="font-weight: bolder">
                                    No Se Encontraron Resultados
                                </td>
                            </tr>
                        </table>
                    </EmptyDataTemplate>
                </cc1:SaimtASPxDataView>
            </td>
        </tr>
    </table>
    <div style="position: absolute; left: 88%; font-weight: bolder; top: 105px; height: auto; width: auto;">
        <cc1:SaimtASPxHyperLink ID="hlBajarManualMargesi" runat="server" 
            Text="Descargar Manual de Ayuda" Font-Bold="True" ForeColor="#3F5496" 
            NavigateUrl="~/archivos/Manual_Margesi.pdf" Target="_blank" 
            CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
            meta:resourcekey="hlBajarManualMargesiResource1">
        </cc1:SaimtASPxHyperLink>
    </div>
    <cc1:SaimtASPxPopupControl ID="pcInmueble" HeaderText="Inmueble Margesi" runat="server"
        Height="700px" Modal="True" ClientInstanceName="pcInmueble" PopupHorizontalAlign="WindowCenter"
        PopupVerticalAlign="WindowCenter" Width="1100px" 
        EnableClientSideAPI="True" AllowDragging="True" AllowResize="True" 
        ShowPageScrollbarWhenModal="True" 
        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
        meta:resourcekey="pcInmuebleResource1" 
        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css">
    </cc1:SaimtASPxPopupControl>
</asp:Content>
