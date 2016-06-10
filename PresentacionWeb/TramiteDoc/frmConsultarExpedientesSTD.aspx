﻿<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/PrincipalTra.Master" CodeBehind="frmConsultarExpedientesSTD.aspx.vb" Inherits="PresentacionWeb.frmConsultarExpedientesSTD" %>
<%@ Register assembly="SaimtControlesWeb" namespace="SaimtControlesWeb" tagprefix="cc1" %>
<%@ Register assembly="DevExpress.Web.v16.1, Version=16.1.2.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>



<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div align="center">
    <cc1:SaimtASPxRoundPanel ID="SaimtASPxRoundPanel1" runat="server" Width="990px"
        HeaderText="Módulo Consultas">
        <HeaderStyle Font-Bold="True" Font-Size="1.2em" />
        <PanelCollection>
            <dx:PanelContent runat="server" SupportsDisabledAttribute="True">
                <table>
                <tr>
                <td align="right">
                    <cc1:SaimtASPxLabel ID="lblNroExpediente" runat="server" 
                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                        Text="Nro Expediente">
                    </cc1:SaimtASPxLabel>
                    </td>
                <td align="left">
                    
                    <cc1:SaimtASPxTextBox ID="txtNroExpediente" runat="server" 
                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text="" 
                        Width="200px">
                    </cc1:SaimtASPxTextBox>
                    </td>
                <td align="left">
                    <cc1:SaimtASPxLabel ID="lblcboAño" runat="server" 
                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                        Text="Año ">
                    </cc1:SaimtASPxLabel>
                    </td>
                    <td align="left">
                        <cc1:SaimtASPxComboBox ID="cboAño" runat="server" ClientInstanceName="cboCampo" 
                            CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                            SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" 
                            ValueType="System.String" Width="150px">
                        </cc1:SaimtASPxComboBox>
                    </td>
                <td>
                    <cc1:SaimtASPxLabel ID="lblDependencia" runat="server" 
                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                        Text="Institucion">
                    </cc1:SaimtASPxLabel>
                    </td>
                <td>
                    <cc1:SaimtASPxComboBox ID="cboDependencia" runat="server" 
                        ClientInstanceName="cboCampo" 
                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" 
                        ValueType="System.String" Width="150px">
                        <Items>
                            <dx:ListEditItem Text="SAIMT" Value="SAIMT" />
                            <dx:ListEditItem Text="MPT" Value="MPT" />
                        </Items>
                    </cc1:SaimtASPxComboBox>
                    </td>
                <td>
                    &nbsp;</td>
                <td style="margin-left: 40px">
                    &nbsp;</td>
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
                
                </table>
            </dx:PanelContent>
        </PanelCollection>
    </cc1:SaimtASPxRoundPanel>
        <cc1:SaimtASPxRoundPanel ID="SaimtASPxRoundPanel2" runat="server" Width="990px" 
            HeaderText="DATOS GENERALES">
       
                        
            <PanelCollection>
<dx:PanelContent runat="server" SupportsDisabledAttribute="True">
     <table width="99%"><tr><td width="125">
                            Fecha de Ingreso :</td><td width="20%">
                                <cc1:SaimtASPxLabel ID="lblFechaIngreso" runat="server" 
                                    CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                    Text="   ">
                                </cc1:SaimtASPxLabel>
                            </td>
                            <td>
                                Interesado</td>
                            <td width="25%">
                                      <cc1:SaimtASPxLabel ID="lblInteresado" runat="server" 
                                    CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                    Text="   ">
                                </cc1:SaimtASPxLabel></td>
                            <td>
                                Documento</td>
                            <td width="25%">
                               <cc1:SaimtASPxLabel ID="lblDocumento" runat="server" 
                                    CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                    Text="   ">
                                </cc1:SaimtASPxLabel></td>
                            </tr>
                            <tr>
                                <td width="125">
                                    Dirección :</td>
                                <td colspan="3">
                                     <cc1:SaimtASPxLabel ID="lblDireccion" runat="server" 
                                    CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                    Text="   ">
                                </cc1:SaimtASPxLabel></td>
                                <td>
                                    Observación</td>
                                <td width="25%">
                                  <cc1:SaimtASPxLabel ID="lblObservacion" runat="server" 
                                    CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                    Text="   ">
                                </cc1:SaimtASPxLabel></td>
                            </tr>
                            </table></dx:PanelContent>
</PanelCollection>
       
                        
        </cc1:SaimtASPxRoundPanel>
    <br/>


     <table>
     <tr>
                <td style="font-size:1.2em; font-weight:bold; text-align:left;">Lista de Expedientes</td>
                </tr>
                <tr>
                <td >
                    <cc1:SaimtASPxGridView ID="gvResultado" runat="server" 
                        AutoGenerateColumns="False"   AllowPaging="True" 
                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" 
                        CssPostfix="PlasticBlue" Width="990px" Visible="False" KeyFieldName="docId" >
                        <Columns>
                            <dx:GridViewDataTextColumn Caption="Flujo" FieldName="docId" 
                                VisibleIndex="10">                                  
                               
                                                 <DataItemTemplate>
                                                   <asp:LinkButton ID="linkSeleccionMov" runat="server" 
                                                         CommandArgument='<%# Eval("docId") + Eval("parte") %>' onclick="linkSeleccionMov_Click">Seleccione</asp:LinkButton>
                                                 </DataItemTemplate>                                    
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Fecha Derivado" FieldName="fechaderivado" 
                                VisibleIndex="9">
                            </dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="derivado" Caption="Derivado" VisibleIndex="8"></dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Interesado" 
                                VisibleIndex="7" FieldName="interesado" Width="25%">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Fecha" FieldName="fecha" 
                                VisibleIndex="5">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Folio" FieldName="folio" 
                                ShowInCustomizationForm="True" VisibleIndex="4" >
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Dependencia" FieldName="dependencia" 
                                ShowInCustomizationForm="True" VisibleIndex="6">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Nro Registro" FieldName="nroReg" 
                                ShowInCustomizationForm="True" VisibleIndex="2" Width="25%">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Procedimiento" FieldName="procedimiento" 
                                VisibleIndex="3" Width="35%">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Parte" FieldName="parte" 
                                VisibleIndex="1">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="docId" FieldName="docId" 
                                ShowInCustomizationForm="True" Visible="False" VisibleIndex="0">
                            </dx:GridViewDataTextColumn>
                        </Columns>
                        <SettingsText EmptyDataRow="No existen datos para mostrar que coincidan con los parametros de busqueda" />
                        <Images SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css">
                        </Images>
                        <Styles CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" 
                            CssPostfix="PlasticBlue">
                        </Styles>
                        <StylesEditors>
                            <Focused BackColor="#99CCFF">
                            </Focused>
                        </StylesEditors>
                    </cc1:SaimtASPxGridView>
                    </td>
                </tr>
                <tr>
                <td align="center" style="font-size:1.2em; font-weight:bold; text-align:left;">
                    
                    <cc1:SaimtASPxLabel ID="lblResultadoDet" runat="server">
                    </cc1:SaimtASPxLabel>
                    
                    </td>
                </tr>
                <tr>
                <td align="center">
                    <cc1:SaimtASPxGridView ID="gvResultadoDet" runat="server" 
                        AutoGenerateColumns="False"   AllowPaging="True" 
                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" 
                        CssPostfix="PlasticBlue" Width="990px" Visible="False">
                        <Columns>
                          <dx:GridViewDataTextColumn Caption="Item" FieldName="item" 
                                VisibleIndex="0">
                            </dx:GridViewDataTextColumn>
                               <dx:GridViewDataTextColumn Caption="Fecha Recibido" FieldName="movFechaRec" 
                                ShowInCustomizationForm="True" VisibleIndex="1" >
                            </dx:GridViewDataTextColumn>
                              <dx:GridViewDataTextColumn Caption="Remitente" FieldName="persona" 
                                ShowInCustomizationForm="True" VisibleIndex="2" Width="25%">
                            </dx:GridViewDataTextColumn>
                               <dx:GridViewDataTextColumn Caption="Cargo Remitente" FieldName="dependencia" 
                                ShowInCustomizationForm="True" VisibleIndex="3" Width="35%">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Estado" FieldName="resultado" 
                                VisibleIndex="4">
                            </dx:GridViewDataTextColumn>
                               <dx:GridViewDataTextColumn Caption="Fecha Contestado" FieldName="movFechaEnv" 
                                VisibleIndex="5">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="personaPara" Caption="Destinatario" VisibleIndex="6"></dx:GridViewDataTextColumn>
                       
                            <dx:GridViewDataTextColumn Caption="Cargo Destinatario" 
                                VisibleIndex="7" FieldName="dependenciaPara" Width="25%">
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
