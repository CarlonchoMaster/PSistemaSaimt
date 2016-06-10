﻿<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Principal.Master" CodeBehind="Vehiculo.aspx.vb" Inherits="PresentacionWeb.Vehiculo" %>
<%@ Register assembly="SaimtControlesWeb" namespace="SaimtControlesWeb" tagprefix="cc1" %>
<%@ Register assembly="DevExpress.Web.v16.1, Version=16.1.2.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>


<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    
    <script type="text/javascript">
        function Abrir_ventana(pagina) {
            var opciones = "toolbar=no,location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=yes, width=800, height=500";
            window.open(pagina, "", opciones);
        }
        </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td valign="top">
                <cc1:SaimtASPxRoundPanel ID="SaimtASPxRoundPanel2" runat="server" 
                    HeaderText="Buscar Por " HorizontalAlign="Left" 
                    >
                    <PanelCollection>
<dx:PanelContent runat="server" SupportsDisabledAttribute="True">
    <table>
        <tr>
            <td>
                <cc1:SaimtASPxRadioButtonList ID="rblBuscar" runat="server" 
                    CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                    RepeatDirection="Horizontal" 
                    SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css">
                    <Items>
                        <dx:ListEditItem Text="Cliente" Value="1" />
                        <dx:ListEditItem Text="Num. Placa" Value="2" />
                    </Items>
                </cc1:SaimtASPxRadioButtonList>
            </td>
        </tr>
        <tr>
            <td>
                <cc1:SaimtASPxTextBox ID="txtBuscarSaimt" runat="server" 
                    CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                    SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" 
                    Text="" Width="250px" >
                </cc1:SaimtASPxTextBox>
            </td>
            <td>
                <cc1:SaimtASPxButton ID="btnSaimtBuscar" runat="server" 
                    CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                    HorizontalAlign="Center" ImagePosition="Top" 
                    SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css">
                    <Image Url="~/images/buscar.png">
                    </Image>
                </cc1:SaimtASPxButton>
            </td>
        </tr>
    </table>
                        </dx:PanelContent>
</PanelCollection>
                </cc1:SaimtASPxRoundPanel>
                <cc1:SaimtASPxRoundPanel ID="SaimtASPxRoundPanel4" runat="server" 
                    HeaderText="Listado">
                    <PanelCollection>
<dx:PanelContent runat="server" SupportsDisabledAttribute="True">
    <cc1:SaimtASPxListBox ID="LstListado" runat="server" AutoPostBack="True" 
        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Width="300px">
    </cc1:SaimtASPxListBox>
                        </dx:PanelContent>
</PanelCollection>
                </cc1:SaimtASPxRoundPanel>
            </td>
            <td valign="top">
    <cc1:SaimtASPxRoundPanel ID="rpVehiculos" runat="server" 
        HeaderText="Detalle Vehiculo">
        <PanelCollection>
            <dx:PanelContent runat="server" SupportsDisabledAttribute="True">
               
                <table>
                    <tr>
                        <td class="lbl_left_td">
                            <cc1:SaimtASPxLabel ID="SaimtASPxLabel1" runat="server" 
                                CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                Text="Cliente :">
                            </cc1:SaimtASPxLabel>
                        </td>
                        <td>
                            <cc1:SaimtASPxTextBox ID="txtCliente" runat="server" 
                                CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" 
                                CssPostfix="PlasticBlue" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" 
                                Text="" ClientIDMode="Static" 
                                ClientInstanceName="txtCliente" style="margin-left: 0px" Width="438px">
                            </cc1:SaimtASPxTextBox>
                        </td>
                        <td>
                            <cc1:SaimtASPxButton ID="btnBuscar" runat="server" 
                                CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                HorizontalAlign="Center" ImagePosition="Top" 
                                SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" 
                                SpriteImageUrl="~/images/ver_detalle32.png">
                                <ClientSideEvents Click="function (s, e) {Abrir_ventana('../Consultas/ConsultarPersonaGeneral.aspx');}" />
                                <Image Url="~/images/buscar.png">
                                </Image>
                            </cc1:SaimtASPxButton>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            <cc1:SaimtASPxGridView ID="dgvDatosPersona" runat="server" 
                                AutoGenerateColumns="False" 
                                CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                KeyFieldName="AcuNPlaca" Width="438px">
                                <Columns>
                                    <dx:GridViewDataTextColumn Caption="Tipo Vehiculo" FieldName="tgTipoVeh" 
                                        Name="tgtipoveh" ShowInCustomizationForm="True" VisibleIndex="0">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="N° Placa" FieldName="AcuNPlaca" 
                                        Name="acunplaca" ShowInCustomizationForm="True" VisibleIndex="1">
                                        <DataItemTemplate>
                                            <asp:LinkButton ID="LinkButton1" runat="server" 
                                                CommandArgument='<%# eval("acuNPlaca") %>' onclick="LinkButton1_Click" 
                                                Text='<%# eval("acuNPlaca") %>'></asp:LinkButton>
                                        </DataItemTemplate>
                                    </dx:GridViewDataTextColumn>
                                </Columns>
                                <Images SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css">
                                </Images>
                                <Styles CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" 
                                    CssPostfix="PlasticBlue">
                                </Styles>
                            </cc1:SaimtASPxGridView>
                        </td>
                    </tr>
                </table>
               
            </dx:PanelContent>
        </PanelCollection>
    </cc1:SaimtASPxRoundPanel>
                <cc1:SaimtASPxRoundPanel ID="rpDatosVehiculo" runat="server" 
                    HeaderText="Datos Adicionales">
                    <PanelCollection>
<dx:PanelContent runat="server" SupportsDisabledAttribute="True">
    <table>
        <tr>
            <td class="lbl_left_td">
                Placa :</td>
            <td>
                <cc1:SaimtASPxTextBox ID="txtNPlaca" runat="server" 
                    CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                    SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text="" Width="170px" 
                   >
                </cc1:SaimtASPxTextBox>
            </td>
        </tr>
        <tr>
            <td class="lbl_left_td">
                <cc1:SaimtASPxLabel ID="SaimtASPxLabel4" runat="server" 
                    CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                    Text="Caracteristica :">
                </cc1:SaimtASPxLabel>
            </td>
            <td>
                <cc1:SaimtASPxComboBox ID="cboCaracteristica" runat="server" 
                    CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                    SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" 
                    ValueType="System.String">
                </cc1:SaimtASPxComboBox>
            </td>
        </tr>
        <tr>
            <td class="lbl_left_td">
                <cc1:SaimtASPxLabel ID="SaimtASPxLabel5" runat="server" 
                    CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                    Text="Descripción :">
                </cc1:SaimtASPxLabel>
            </td>
            <td>
                <cc1:SaimtASPxTextBox ID="txtDescripcion" runat="server" 
                    CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                    SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text="" Width="360px" 
                    >
                </cc1:SaimtASPxTextBox>
            </td>
            <td>
                <cc1:SaimtASPxButton ID="btnAddCaracterisca" runat="server" 
                    CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                    HorizontalAlign="Center" ImagePosition="Top" 
                    SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" 
                    SpriteImageUrl="~/images/ver_detalle32.png">
                    <Image Url="~/images/agregar16.png">
                    </Image>
                </cc1:SaimtASPxButton>
            </td>
            <td>
                <cc1:SaimtASPxButton ID="btnQuitar" runat="server" 
                    CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                    HorizontalAlign="Center" ImagePosition="Top" 
                    SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" 
                    SpriteImageUrl="~/images/ver_detalle32.png">
                    <ClientSideEvents Click="function (s, e) {e.processOnServer = confirm('Desea Eliminar las Recaudaciones?');}" />
                    <Image Url="~/images/remover16.png">
                    </Image>
                </cc1:SaimtASPxButton>
            </td>
        </tr>
        <tr>
        <td></td>
            <td>
                <cc1:SaimtASPxGridView ID="dgvDatosDetvehiculo" runat="server" 
                    AutoGenerateColumns="False" 
                    CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" 
                    CssPostfix="PlasticBlue" Width="360px">
                    <Columns>
                        <dx:GridViewDataTextColumn FieldName="tgCaracVehId" Name="coltgCaracVehId" 
                            ShowInCustomizationForm="True" Visible="False" VisibleIndex="0">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="Caracteristica" FieldName="tgCaracVeh" 
                            Name="coltgCaracVeh" ShowInCustomizationForm="True" VisibleIndex="1">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="Descripcion" FieldName="VehDetCarac" 
                            Name="colVehDetCarac" ShowInCustomizationForm="True" VisibleIndex="2">
                        </dx:GridViewDataTextColumn>
                    </Columns>
                    <Images SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css">
                    </Images>
                    <Styles CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" 
                        CssPostfix="PlasticBlue">
                    </Styles>
                </cc1:SaimtASPxGridView>
            </td>
        </tr>
        
        <tr>
        
        <td></td>
            <td>
                <table valing="left">
                    <tr>
                    
                        <td>
                            <cc1:SaimtASPxButton ID="btnEditar" runat="server" 
                                CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                HorizontalAlign="Center" ImagePosition="Top" 
                                SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text="Editar" 
                                >
                                <Image Url="~/images/editar32.png">
                                </Image>
                            </cc1:SaimtASPxButton>
                        </td>
                        <td>
                            <cc1:SaimtASPxButton ID="btnLimpiar" runat="server" 
                                CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                HorizontalAlign="Center" ImagePosition="Top" 
                                SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text="Limpiar" 
                                >
                                <Image Url="~/images/limpiar32.png">
                                </Image>
                            </cc1:SaimtASPxButton>
                        </td>
                        <td>
                            <cc1:SaimtASPxButton ID="btnCancelar" runat="server" 
                                CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                HorizontalAlign="Center" ImagePosition="Top" 
                                SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text="Cancelar" 
                                >
                                <Image Url="~/images/cancelar32.png">
                                </Image>
                            </cc1:SaimtASPxButton>
                        </td>
                        <td>
                            <cc1:SaimtASPxButton ID="btnGuardar" runat="server" 
                                CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                HorizontalAlign="Center" ImagePosition="Top" 
                                SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text="Guardar" 
                                >
                                <Image Url="~/images/guardar32(1).png">
                                </Image>
                            </cc1:SaimtASPxButton>
                        </td>
                        <td>
                            <cc1:SaimtASPxButton ID="btnEliminar" runat="server" 
                                CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                HorizontalAlign="Center" ImagePosition="Top" 
                                SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text="Eliminar" 
                                >
                                <Image Url="~/images/eliminar32(1).png">
                                </Image>
                            </cc1:SaimtASPxButton>
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
        </tr>
        <tr>
            <td valign="top">
                &nbsp;</td>
        </tr>
        </table>
</asp:Content>
