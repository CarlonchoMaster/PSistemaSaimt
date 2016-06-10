﻿<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="frmBusquedaXRubro.aspx.vb" Inherits="PresentacionWeb.frmBusquedaXRubro" %>
<%@ Register assembly="SaimtControlesWeb" namespace="SaimtControlesWeb" tagprefix="cc1" %>
<%@ Register assembly="DevExpress.Web.v16.1, Version=16.1.2.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>



<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <script type="text/javascript">
    function OnProvinciaChanged(cboDepartamento) {
        cboProvincia.PerformCallback(cboDepartamento.GetValue().toString());
        
    }
    function OnDistritoChanged(cboProvincia) {
        cboDistrito.PerformCallback(cboProvincia.GetValue().toString());

    }

    function onSubDistritoChanged(cboSubDistritos) {
        txtsubdistritoscbo.PerformCallback(cboSubDistritos.GetValue().toString());
        
    }
    
</script>
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
                <td></td>
                <td>
                    
                    <cc1:SaimtASPxRadioButtonList ID="rbtipodireccion" runat="server" 
                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css">
                        <Items>
                            <dx:ListEditItem Text="Finca Inscrita" Value="0" />
                            <dx:ListEditItem Text="Ubicación Margesí" Value="1" />
                        </Items>
                    </cc1:SaimtASPxRadioButtonList>
                    
                    </td>
                <td>&nbsp;</td>
                <td>
                    &nbsp;</td>
                <td></td>
                <td></td>
                <td></td>
                </tr>
                <tr>
                <td style="text-align: right">Departamento</td>
                <td>
                    <cc1:SaimtASPxComboBox ID="cboDepartamento" runat="server" 
                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" 
                        ValueType="System.String" Width="130px">
                        <ClientSideEvents SelectedIndexChanged="function(s, e) { OnProvinciaChanged(s); }" />
                    </cc1:SaimtASPxComboBox>
                    </td>
                <td style="text-align: right">Provincia</td>
                <td>
                    <cc1:SaimtASPxComboBox ID="cboProvincia" runat="server" 
                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" 
                        ValueType="System.String" Width="130px" ClientInstanceName="cboProvincia">
                        <ClientSideEvents SelectedIndexChanged="function(s, e) { OnDistritoChanged(s); }" />
                    </cc1:SaimtASPxComboBox>
                    </td>
                <td style="text-align: right">Distrito</td>
                <td>
                    <cc1:SaimtASPxComboBox ID="cboDistrito" runat="server" 
                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" 
                        ValueType="System.String" Width="130px" ClientInstanceName="cboDistrito">
                    </cc1:SaimtASPxComboBox>
                    </td>
                <td>Sector<cc1:SaimtASPxTextBox ID="txtSector" runat="server" 
                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text="" 
                        Width="75px">
                    </cc1:SaimtASPxTextBox>
                    </td>
                </tr>
                <tr>
                <td style="text-align: right">Localización</td>
                <td>
                    <cc1:SaimtASPxComboBox ID="cboLocalizacion" runat="server" 
                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" 
                        ValueType="System.String" Width="130px">
                    </cc1:SaimtASPxComboBox>
                    </td>
                <td>
                    <cc1:SaimtASPxTextBox ID="txtLocalizacion" runat="server" 
                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text="">
                    </cc1:SaimtASPxTextBox>
                    </td>
                <td>
                    <cc1:SaimtASPxComboBox ID="cboTipoNro" runat="server" 
                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" 
                        ValueType="System.String" Width="130px">
                    </cc1:SaimtASPxComboBox>
                    </td>
                <td>
                    <cc1:SaimtASPxTextBox ID="txtNroUbicacion" runat="server" 
                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text="" 
                        Width="75px">
                    </cc1:SaimtASPxTextBox>
                    </td>
                <td>
                    <cc1:SaimtASPxComboBox ID="cboTipoSubNro" runat="server" 
                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" 
                        ValueType="System.String" Width="130px">
                    </cc1:SaimtASPxComboBox>
                    </td>
                <td>
                    <cc1:SaimtASPxTextBox ID="txtSubNro" runat="server" 
                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text="">
                    </cc1:SaimtASPxTextBox>
                    </td>
                </tr>
                <tr>
                <td></td>
                <td>
                    <cc1:SaimtASPxComboBox ID="cboSubDistritos" runat="server" 
                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" 
                        ValueType="System.String" Width="130px" 
                        ClientInstanceName="cboSubDistritos">
                        <ClientSideEvents SelectedIndexChanged="function(s, e) {
	onSubDistritoChanged(s);
}" />
                    </cc1:SaimtASPxComboBox>
                    </td>
                <td>
                    
                    <cc1:SaimtASPxTextBox ID="txtsubdistritoText" runat="server" 
                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text="">
                    </cc1:SaimtASPxTextBox>
                    
                    <cc1:SaimtASPxComboBox ID="txtsubdistritoscbo" runat="server" 
                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" 
                        ValueType="System.String" 
                        ClientInstanceName="txtsubdistritoscbo" Visible="False">
                    </cc1:SaimtASPxComboBox>
                    
                    </td>
                <td style="text-align: right">Etapa</td>
                <td>
                    <cc1:SaimtASPxTextBox ID="txtEtapa" runat="server" 
                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text="" 
                        Width="75px">
                    </cc1:SaimtASPxTextBox>
                    </td>
                <td style="text-align: right">Fase</td>
                <td>
                    <cc1:SaimtASPxTextBox ID="txtFase" runat="server" 
                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text="" 
                        Width="50px">
                    </cc1:SaimtASPxTextBox>
                    </td>
                </tr>
                <tr>
                <td style="text-align: right">Rubros</td>
                <td><cc1:SaimtASPxComboBox ID="cboRubroGrupos" runat="server" Width="130px" 
                        ReadOnly="True"></cc1:SaimtASPxComboBox></td>
                <td>
                    <cc1:SaimtASPxComboBox ID="cboRubro" runat="server" 
                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" 
                        ValueType="System.String" Width="130px">
                    </cc1:SaimtASPxComboBox>
                    </td>
                <td style="text-align: right">Barrio</td>
                <td>
                    <cc1:SaimtASPxTextBox ID="txtBarrio" runat="server" 
                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text="" 
                        Width="75px">
                    </cc1:SaimtASPxTextBox>
                    </td>
                <td style="text-align: right">Adicional</td>
                <td>
                    <cc1:SaimtASPxTextBox ID="txtdireccionAdicional" runat="server" 
                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text="">
                    </cc1:SaimtASPxTextBox>
                    </td>
                </tr>
                
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
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
                        <td>
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
                                VisibleIndex="0" Width="75%" FieldName="inmUbicacion">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataHyperLinkColumn Caption=" " ShowInCustomizationForm="True" 
                                VisibleIndex="1" FieldName="Detalle">
                                <HeaderTemplate>
                                 <div align="center"><img alt="" src="../images/detalle.png" width="32px" height="32px" /></div>
                                </HeaderTemplate>
                            </dx:GridViewDataHyperLinkColumn>
                            <dx:GridViewDataHyperLinkColumn Caption=" " ShowInCustomizationForm="True" 
                                VisibleIndex="2" FieldName="Ficha">
                                <HeaderTemplate>
                                    <div align="center"><img alt="" src="../images/ficha.png" /></div>
                                </HeaderTemplate>
                            </dx:GridViewDataHyperLinkColumn>
                            <dx:GridViewDataTextColumn Caption="inmId" FieldName="inmId" Visible="False" 
                                VisibleIndex="3">
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
