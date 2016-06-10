﻿<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/PrincipalTra.Master" CodeBehind="frmBusquedaExpedientesSTD.aspx.vb" Inherits="PresentacionWeb.frmBusquedaExpedientesSTD" %>
<%@ Register assembly="SaimtControlesWeb" namespace="SaimtControlesWeb" tagprefix="cc1" %>
<%@ Register assembly="DevExpress.Web.v16.1, Version=16.1.2.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>



<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div align="center">
    <cc1:SaimtASPxRoundPanel ID="SaimtASPxRoundPanel1" runat="server" Width="990px"
        HeaderText="Módulo Búsqueda">
        <HeaderStyle Font-Bold="True" Font-Size="1.2em" />
        <PanelCollection>
            <dx:PanelContent runat="server" SupportsDisabledAttribute="True">
                <table>
                <tr>
                <td align="right">
                    <cc1:SaimtASPxLabel ID="lbldtFechaInicio" runat="server" 
                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                        Text="Fecha de Inicio">
                    </cc1:SaimtASPxLabel>
                    </td>
                <td align="left">
                    
                    <cc1:SaimtASPxDateEdit ID="dtFechaInicio" runat="server" 
                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Width="100px">
                    </cc1:SaimtASPxDateEdit>
                    </td>
                <td align="left">
                    <cc1:SaimtASPxLabel ID="lbldtFechaFin" runat="server" 
                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                        Text="Fecha de Final ">
                    </cc1:SaimtASPxLabel>
                    </td>
                    <td align="left">
                        <cc1:SaimtASPxDateEdit ID="dtFechaFin" runat="server" 
                            CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                            SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Width="100px">
                        </cc1:SaimtASPxDateEdit>
                    </td>
                <td>&nbsp;<cc1:SaimtASPxLabel ID="lblcboCampo" runat="server" 
                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                        Text=" Campo ">
                    </cc1:SaimtASPxLabel>
                    </td>
                <td>
                    <cc1:SaimtASPxComboBox ID="cboCampo" runat="server" 
                        ClientInstanceName="cboCampo" 
                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" 
                        ValueType="System.String" Width="150px">
                    </cc1:SaimtASPxComboBox>
                    </td>
                <td>
                    <cc1:SaimtASPxLabel ID="lblcboCriterio" runat="server" 
                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                        Text="Criterio ">
                    </cc1:SaimtASPxLabel>
                    </td>
                <td style="margin-left: 40px">
                    <cc1:SaimtASPxTextBox ID="cboCriterio" runat="server" 
                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text="" 
                        Width="200px">
                    </cc1:SaimtASPxTextBox>
                    </td>
                <td style="margin-left: 40px">
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
                </tr>
                
                    <tr>
                        <td align="right" colspan="2">
                            &nbsp;</td>
                        <td align="left">
                            &nbsp;</td>
                        <td align="left">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td style="margin-left: 40px">
                            &nbsp;</td>
                        <td style="margin-left: 40px">
                            &nbsp;</td>
                    </tr>
                
                </table>
            </dx:PanelContent>
        </PanelCollection>
    </cc1:SaimtASPxRoundPanel>
     <table>
     <tr>
                <td style="font-size:1.2em; font-weight:bold; text-align:left;">Lista de Expedientes</td>
                </tr>
                <tr>
                <td >
                    <cc1:SaimtASPxGridView ID="gvResultado" runat="server" 
                        AutoGenerateColumns="False"   AllowPaging="True" 
                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" 
                        CssPostfix="PlasticBlue" Width="990px" Visible="False">
                        <Columns>
                           <dx:GridViewDataTextColumn Caption="docId" FieldName="docId" 
                                VisibleIndex="0" Visible="False">
                            </dx:GridViewDataTextColumn>
                               <dx:GridViewDataTextColumn Caption="Expediente" FieldName="expediente" 
                                ShowInCustomizationForm="True" VisibleIndex="1" Width="27%">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Expendiente MPT" FieldName="expedienteMpt" 
                                VisibleIndex="2">
                            </dx:GridViewDataTextColumn>
                              <dx:GridViewDataTextColumn Caption="Fecha de Exp" FieldName="fechaExp" 
                                VisibleIndex="3">
                            </dx:GridViewDataTextColumn>
                                  <dx:GridViewDataTextColumn Caption="Procedimiento" FieldName="procedimiento" 
                                ShowInCustomizationForm="True" VisibleIndex="4" Width="35%">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Interesado" FieldName="interesado" 
                                ShowInCustomizationForm="True" VisibleIndex="5" Width="28%">
                            </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Dependencia" FieldName="dependencia" 
                                VisibleIndex="6">
                            </dx:GridViewDataTextColumn>
                              <dx:GridViewDataTextColumn Caption="Área" FieldName="area" VisibleIndex="7">
                            </dx:GridViewDataTextColumn>
                                                    <dx:GridViewDataTextColumn Caption="Observación" 
                                VisibleIndex="8" FieldName="observacion" Width="25%">
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
