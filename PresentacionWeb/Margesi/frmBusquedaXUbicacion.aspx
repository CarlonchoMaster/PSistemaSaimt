<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="frmBusquedaXUbicacion.aspx.vb" Inherits="PresentacionWeb.frmBusquedaXUbicacion" %>
<%@ Register assembly="SaimtControlesWeb" namespace="SaimtControlesWeb" tagprefix="cc1" %>
<%@ Register assembly="DevExpress.Web.v16.1, Version=16.1.2.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>



<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div align="center">
    <cc1:SaimtASPxRoundPanel ID="SaimtASPxRoundPanel1" runat="server" Width="990px"
        HeaderText="BUSQUEDA POR DIRECCIÓN : Consigna la dirección que deseas buscar">
        <HeaderStyle Font-Bold="True" Font-Size="1.2em" />
        <PanelCollection>
            <dx:PanelContent runat="server" SupportsDisabledAttribute="True">
                <table>
                <tr>
                <td align="right">Departamento :</td>
                <td align="left">
                    
                    <cc1:SaimtASPxTextBox ID="txtDepartamento" runat="server" 
                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text="La Libertad" Width="130px">
                    </cc1:SaimtASPxTextBox>
                    </td>
                <td align="left">Provincia :</td>
                    <td align="left">
                        <cc1:SaimtASPxTextBox ID="txtProvincia" runat="server" 
                            CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                            SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text="Trujillo" 
                            Width="130px">
                        </cc1:SaimtASPxTextBox>
                    </td>
                <td>Distrito : </td>
                <td>
                    <cc1:SaimtASPxComboBox ID="cboDistrito" runat="server" 
                        ClientInstanceName="cboDistrito" 
                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" 
                        ValueType="System.String" Width="130px">
                    </cc1:SaimtASPxComboBox>
                    </td>
                <td></td>
                <td>&nbsp;</td>
                <td>
                    &nbsp;</td>
                </tr>
                <tr>
                <td style="text-align: right">Rubros :</td>
                <td align="left" colspan="3">
                    <cc1:SaimtASPxComboBox ID="cboRubroGrupos" runat="server" 
                        ClientInstanceName="cboRubroGrupos" 
                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" 
                        ValueType="System.String" Width="130px">
                    </cc1:SaimtASPxComboBox>
                    </td>
                <td style="text-align: right">&nbsp;</td>
                <td>
                    &nbsp;</td>
                <td style="text-align: right">&nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                </tr>
                <tr>
                <td style="text-align: right">Calle o parte de Dirección :</td>
                <td colspan="6" align="left">
                    <cc1:SaimtASPxTextBox ID="txtUbicacion" runat="server" 
                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text="" Width="430px">
                    </cc1:SaimtASPxTextBox>
                    </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                </tr>
                <tr>
                <td></td>
                <td colspan="3">
                    Ejemplo: (<span 
                        style="color: rgb(0, 0, 0); font-family: Tahoma; font-size: 12px; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: auto; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: auto; word-spacing: 0px; -webkit-text-stroke-width: 0px; display: inline !important; float: none; background-color: rgb(255, 255, 255);">Jirón 
                    Bolívar, </span>Jirón Bolívar Cdra 05,
                    <span style="color: rgb(0, 0, 0); font-family: Tahoma; font-size: 12px; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: auto; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: auto; word-spacing: 0px; -webkit-text-stroke-width: 0px; display: inline !important; float: none; background-color: rgb(255, 255, 255);">
                    Jirón Bolívar - N° 745</span>)</td>
                <td>
                    
                    &nbsp;</td>
                <td style="text-align: right">&nbsp;</td>
                <td>
                    &nbsp;</td>
                <td style="text-align: right">&nbsp;</td>
                <td>
                    &nbsp;</td>
                </tr>
                <tr>
                <td style="text-align: right">&nbsp;</td>
                  <td colspan="3">                   
                      &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td style="text-align: right">&nbsp;</td>
                <td>
                    &nbsp;</td>
                <td style="text-align: right">&nbsp;</td>
                <td>
                    &nbsp;</td>
                </tr>
                
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td align="right">
                            <cc1:SaimtASPxButton ID="btnLimpiar" runat="server" 
                                CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                HorizontalAlign="Center" 
                                SaimtToolTip="Limpiar;Permite borrar los datos de los controles para una nueva busqueda" 
                                SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" 
                                SpriteImageUrl="~/images/limpiar32.png" Text="Limpiar" 
                                ToolTip="&lt;u&gt;&lt;b&gt;Limpiar&lt;/u&gt;&lt;/b&gt;&lt;br /&gt;Permite borrar los datos de los controles para una nueva busqueda.">
                                <Image Url="~/images/limpiar32.png">
                                </Image>
                            </cc1:SaimtASPxButton>
                        </td>
                        <td align="left" colspan="2">
                            <cc1:SaimtASPxButton ID="btnBuscar" runat="server" 
                                CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                HorizontalAlign="Left" 
                                SaimtToolTip="Buscar Inmueble;Permite realizar una buscaqueda del inmueble mediante los parametros ingresados" 
                                SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" 
                                SpriteImageUrl="~/images/buscar32.png" Text="Buscar" 
                                ToolTip="&lt;u&gt;&lt;b&gt;Buscar Inmueble&lt;/u&gt;&lt;/b&gt;&lt;br /&gt;Permite realizar una buscaqueda del inmueble mediante los parametros ingresados.">
                                <Image Url="~/images/buscar32.png">
                                </Image>
                            </cc1:SaimtASPxButton>
                        </td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                
                </table>
            </dx:PanelContent>
        </PanelCollection>
    </cc1:SaimtASPxRoundPanel>
     <table>
     <tr>
                <td style="font-size:1.2em; font-weight:bold;">Resultados de Busqueda</td>
                </tr>
                <tr>
                <td >
                    <cc1:SaimtASPxGridView ID="gvResultado" runat="server" 
                        AutoGenerateColumns="False" 
                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" 
                        CssPostfix="PlasticBlue" Width="990px" Visible="False">
                        <Columns>
                            <dx:GridViewDataTextColumn Caption="Dirección" ShowInCustomizationForm="True" 
                                VisibleIndex="2" Width="75%" FieldName="inmUbicacion">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataHyperLinkColumn Caption=" " ShowInCustomizationForm="True" 
                                VisibleIndex="3" FieldName="Detalle">
                                <HeaderTemplate>
                                 <div align="center"><img alt="" src="../images/detalle.png" width="32px" height="32px" /></div>
                                </HeaderTemplate>
                            </dx:GridViewDataHyperLinkColumn>
                            <dx:GridViewDataTextColumn Caption="File" FieldName="inmFile" VisibleIndex="1">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="inmId" FieldName="inmId" 
                                VisibleIndex="0" Visible="False">
                            </dx:GridViewDataTextColumn>
                        </Columns>
                        <SettingsText EmptyDataRow="No existen datos para mostrar que coincidan con los parametros de busqueda" />
                        <Images SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css">
                        </Images>
                        <Styles CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" 
                            CssPostfix="PlasticBlue">
                        </Styles>
                    </cc1:SaimtASPxGridView>
                    </td>
                </tr>
                <tr>
                <td align="center">
                    <cc1:SaimtASPxLabel ID="lblResultados" runat="server" 
                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" 
                        CssPostfix="PlasticBlue" Font-Bold="True" Font-Size="1em">
                    </cc1:SaimtASPxLabel>
                    </td>
                </tr>
     </table>
</div>
    
</asp:Content>
