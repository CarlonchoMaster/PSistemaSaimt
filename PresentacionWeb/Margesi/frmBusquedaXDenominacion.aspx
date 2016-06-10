<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="frmBusquedaXDenominacion.aspx.vb" Inherits="PresentacionWeb.frmBusquedaXDenominacion" %>
<%@ Register assembly="SaimtControlesWeb" namespace="SaimtControlesWeb" tagprefix="cc1" %>
<%@ Register assembly="DevExpress.Web.v16.1, Version=16.1.2.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>


<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<div align="center">
    <cc1:SaimtASPxRoundPanel ID="SaimtASPxRoundPanel1" runat="server" 
        
        HeaderText="BÚSQUEDA POR DENOMINACIÓN: Consigna el nombre conocido del inmueble a buscar" 
        Width="990px">
        <HeaderStyle Font-Bold="True" Font-Size="1.2em" />
        <PanelCollection>
<dx:PanelContent ID="PanelContent1" runat="server" SupportsDisabledAttribute="True">
<table>
<tr>
<td>
    <cc1:SaimtASPxComboBox ID="SaimtASPxComboBox1" runat="server">
    </cc1:SaimtASPxComboBox>
</td>
<td>
    <cc1:SaimtASPxTextBox ID="SaimtASPxTextBox1" runat="server">
    </cc1:SaimtASPxTextBox>
</td>
<td>Rubros</td>
<td>
    <cc1:SaimtASPxComboBox ID="SaimtASPxComboBox2" runat="server">
    </cc1:SaimtASPxComboBox>
</td>
<td>
    <cc1:SaimtASPxComboBox ID="SaimtASPxComboBox3" runat="server">
    </cc1:SaimtASPxComboBox>
</td>
<td>
    <cc1:SaimtASPxButton ID="SaimtASPxButton1" runat="server" 
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
    <cc1:SaimtASPxButton ID="SaimtASPxButton2" runat="server" 
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
                    
                    <cc1:SaimtASPxGridView ID="SaimtASPxGridView1" runat="server" 
                        AutoGenerateColumns="False" 
                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" 
                        CssPostfix="PlasticBlue" Width="990px">
                        <Columns>
                            <dx:GridViewDataTextColumn Caption="Dirección" ShowInCustomizationForm="True" 
                                VisibleIndex="0" Width="75%">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataHyperLinkColumn Caption=" " ShowInCustomizationForm="True" 
                                VisibleIndex="1">
                                <HeaderTemplate>
                                 <div align="center"><img alt="" src="../images/detalle.png" width="32px" height="32px" /></div>
                                </HeaderTemplate>
                            </dx:GridViewDataHyperLinkColumn>
                            <dx:GridViewDataHyperLinkColumn Caption=" " ShowInCustomizationForm="True" 
                                VisibleIndex="2">
                                <HeaderTemplate>
                                    <div align="center"><img alt="" src="../images/ficha.png" /></div>
                                </HeaderTemplate>
                            </dx:GridViewDataHyperLinkColumn>
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
                    <cc1:SaimtASPxLabel ID="SaimtASPxLabel1" runat="server" 
                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" 
                        CssPostfix="PlasticBlue" Font-Bold="True" Font-Size="1em">
                    </cc1:SaimtASPxLabel>
                    </td>
                </tr>
     </table>
   
</div>
</asp:Content>
