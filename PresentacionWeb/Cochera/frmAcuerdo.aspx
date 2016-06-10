<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Principal.Master"
    CodeBehind="frmAcuerdo.aspx.vb" Inherits="PresentacionWeb.frmContrato" %>

<%@ Register Assembly="SaimtControlesWeb" Namespace="SaimtControlesWeb" TagPrefix="cc1" %>
<%@ Register Assembly="DevExpress.Web.v16.1, Version=16.1.2.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx" %>


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
            <td style="text-align: center">
                &nbsp;
            </td>
            <td>
                <cc1:SaimtASPxLabel ID="SaimtASPxLabel2" runat="server" Text="ACUERDO" Font-Bold="True"
                    Font-Size="Large" ForeColor="#003399">
                </cc1:SaimtASPxLabel>
            </td>
        </tr>
        <tr>
            <td style="text-align: center" align="center" valign="top" class="TablaBuscar">
                <cc1:SaimtASPxRoundPanel ID="SaimtASPxRoundPanel2" runat="server" HeaderText="Burcar por :"
                    Style="margin-right: 0px">
                    <PanelCollection>
                        <dx:PanelContent ID="PanelContent1" runat="server" SupportsDisabledAttribute="True">
                            <table>
                                <tr>
                                    <td colspan="2">
                                        <cc1:SaimtASPxRadioButtonList ID="rblBuscar" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" RepeatDirection="Horizontal" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                            Width="100%">
                                            <Items>
                                                <dx:ListEditItem Text="Nombre" Value="1" />
                                                <dx:ListEditItem Text="DNI" Value="3" />
                                                <dx:ListEditItem Text="RUC" Value="4" />
                                            </Items>
                                        </cc1:SaimtASPxRadioButtonList>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <cc1:SaimtASPxTextBox ID="txtBuscarSaimt" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                            Text="" Width="250px">
                                        </cc1:SaimtASPxTextBox>
                                    </td>
                                    <td>
                                        <cc1:SaimtASPxButton ID="btnSaimtBuscar" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                            HorizontalAlign="Center" ImagePosition="Top">
                                            <Image Url="~/images/buscar.png">
                                            </Image>
                                        </cc1:SaimtASPxButton>
                                    </td>
                                </tr>
                            </table>
                        </dx:PanelContent>
                    </PanelCollection>
                </cc1:SaimtASPxRoundPanel>
                <cc1:SaimtASPxRoundPanel ID="SaimtASPxRoundPanel3" runat="server" HeaderText="Personas">
                    <PanelCollection>
                        <dx:PanelContent ID="PanelContent2" runat="server" SupportsDisabledAttribute="True">
                            <cc1:SaimtASPxListBox ID="LstListado" runat="server" AutoPostBack="True" Width="300px">
                            </cc1:SaimtASPxListBox>
                        </dx:PanelContent>
                    </PanelCollection>
                </cc1:SaimtASPxRoundPanel>
                <cc1:SaimtASPxRoundPanel ID="SaimtASPxRoundPanel1" runat="server" HeaderText="Acuerdos">
                    <PanelCollection>
                        <dx:PanelContent ID="PanelContent3" runat="server" SupportsDisabledAttribute="True">
                            <cc1:SaimtASPxListBox ID="LstAcuerdos" runat="server" AutoPostBack="True" Width="300px">
                            </cc1:SaimtASPxListBox>
                        </dx:PanelContent>
                    </PanelCollection>
                </cc1:SaimtASPxRoundPanel>
            </td>
            <td>
                <cc1:SaimtASPxRoundPanel ID="rpDatosAcuerdo" runat="server" HeaderText="DATOS DE ACUERDO">
                    <PanelCollection>
                        <dx:PanelContent runat="server" SupportsDisabledAttribute="True">
                            <table>
                                <tr>
                                    <td class="lbl_left_td">
                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel20" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Text="Codigo Acuerdo :">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                    <td>
                                        <cc1:SaimtASPxTextBox ID="txtCodigo" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                            Text="" Width="50px">
                                        </cc1:SaimtASPxTextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="lbl_left_td">
                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel12" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Text="Institución :">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                    <td>
                                        <cc1:SaimtASPxComboBox ID="cboInstitucion" runat="server" AutoPostBack="True" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                            ValueType="System.String" Width="438px">
                                        </cc1:SaimtASPxComboBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="lbl_left_td">
                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel13" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Text="Sede :">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                    <td>
                                        <cc1:SaimtASPxComboBox ID="cboSede" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                            ValueType="System.String" Width="438px">
                                        </cc1:SaimtASPxComboBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="lbl_left_td">
                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel5" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Text="Cliente :">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                    <td>
                                        <cc1:SaimtASPxTextBox ID="txtCliente" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                            Style="margin-left: 0px" Text="" ClientIDMode="Static" ClientInstanceName="txtCliente"
                                            Width="438px">
                                        </cc1:SaimtASPxTextBox>
                                    </td>
                                    <td>
                                        <cc1:SaimtASPxButton ID="btnBuscar" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" HorizontalAlign="Center" ImagePosition="Top" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                            SpriteImageUrl="~/images/ver_detalle32.png">
                                            <Image Url="~/images/buscar.png">
                                            </Image>
                                            <ClientSideEvents Click="function (s, e) {Abrir_ventana('../Consultas/ConsultarPersonaGeneral.aspx');}" />
                                        </cc1:SaimtASPxButton>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="lbl_left_td">
                                        &nbsp;
                                    </td>
                                    <td>
                                        <cc1:SaimtASPxTextBox ID="txtPerId" runat="server" ClientIDMode="Static" ClientVisible="False"
                                            CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue"
                                            EnableClientSideAPI="True" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                            Text="" Width="438px">
                                        </cc1:SaimtASPxTextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="lbl_left_td">
                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel26" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Text="Tipo de Vehículo :">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                    <td>
                                        <cc1:SaimtASPxComboBox ID="cboTipoVehiculo" runat="server" AutoPostBack="True" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                            ValueType="System.String">
                                        </cc1:SaimtASPxComboBox>
                                    </td>
                                </tr>
                                <tr>
                                <td colspan="3" align="center">
                                   <asp:DropDownList ID="ddlImpresoras" runat="server">
                                                    </asp:DropDownList>
                                </td>
                                </tr>
                                <tr>
                                    <td class="lbl_left_td">
                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel15" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Text="Nro de Placa 1 :">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                    <td>
                                        <table>
                                            <tr>
                                                <td>
                                                 
                                                    <cc1:SaimtASPxTextBox ID="txtNumPlaca1" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                        CssPostfix="PlasticBlue" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                                        Text="" Width="170px" MaxLength="6">
                                                    </cc1:SaimtASPxTextBox>
                                                </td>
                                                <td align="right" class="lbl_left_td">
                                                    <cc1:SaimtASPxLabel runat="server" Text="Cod. de Barras :" CssPostfix="PlasticBlue"
                                                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" ID="SaimtASPxLabel18">
                                                    </cc1:SaimtASPxLabel>
                                                </td>
                                                <td>
                                                    <cc1:SaimtASPxTextBox runat="server" Text="" Width="170px" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                                        CssPostfix="PlasticBlue" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                        ID="txtCodBarras1">
                                                    </cc1:SaimtASPxTextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td colspan="3" align="center">
                                                    <asp:Image runat="server" ID="imgCodBarras1" Visible="false" />
                                                    <cc1:SaimtASPxButton ID="btnImprimir" runat="server" 
                                                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text="Imprimir">
                                                    </cc1:SaimtASPxButton>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="lbl_left_td">
                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel23" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Text="Nro de Placa 2 :">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                    <td>
                                        <table>
                                            <tr>
                                                <td>
                                                    <cc1:SaimtASPxTextBox ID="txtNumPlaca2" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                        CssPostfix="PlasticBlue" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                                        Text="" Width="170px" MaxLength="6">
                                                    </cc1:SaimtASPxTextBox>
                                                </td>
                                                <td align="right" class="lbl_left_td">
                                                    <cc1:SaimtASPxLabel ID="SaimtASPxLabel25" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                        CssPostfix="PlasticBlue" Text="Cod. de Barras :">
                                                    </cc1:SaimtASPxLabel>
                                                </td>
                                                <td>
                                                    <cc1:SaimtASPxTextBox ID="txtCodBarras2" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                        CssPostfix="PlasticBlue" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                                        Text="" Width="170px">
                                                    </cc1:SaimtASPxTextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td colspan="3" align="center">
                                                    <asp:Image runat="server" ID="imgCodBarras2" Visible="false" />
                                                    <cc1:SaimtASPxButton ID="btnImprimir2" runat="server" 
                                                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text="Imprimir">
                                                    </cc1:SaimtASPxButton>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="lbl_left_td">
                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel24" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Text="Nro de Placa 3 :">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                    <td>
                                        <table>
                                            <tr>
                                                <td>
                                                    <cc1:SaimtASPxTextBox ID="txtNumPlaca3" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                        CssPostfix="PlasticBlue" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                                        Text="" Width="170px" MaxLength="6">
                                                    </cc1:SaimtASPxTextBox>
                                                </td>
                                                <td class="lbl_left_td">
                                                    <cc1:SaimtASPxLabel ID="SaimtASPxLabel27" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                        CssPostfix="PlasticBlue" Text="Cod. de Barras :">
                                                    </cc1:SaimtASPxLabel>
                                                </td>
                                                <td>
                                                    <cc1:SaimtASPxTextBox ID="txtCodBarras3" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                        CssPostfix="PlasticBlue" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                                        Text="" Width="170px">
                                                    </cc1:SaimtASPxTextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td colspan="3" align="center">
                                                    <asp:Image runat="server" ID="imgCodBarras3" Visible="false" />
                                                    <cc1:SaimtASPxButton ID="btnImprimir3" runat="server" 
                                                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text="Imprimir">
                                                    </cc1:SaimtASPxButton>
                                                </td>
                                            </tr>
                                        </table>
                                </tr>
                                <tr>
                                    <td class="lbl_left_td">
                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel11" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Text="Tarifa :">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                    <td>
                                        <cc1:SaimtASPxComboBox ID="cboTarifa" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                            ValueType="System.String" AutoPostBack="True">
                                        </cc1:SaimtASPxComboBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="lbl_left_td">
                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel22" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Text="Fecha Registro :">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                    <td>
                                        <cc1:SaimtASPxTextBox ID="txtFechaRegistro" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                            Text="" Width="170px">
                                        </cc1:SaimtASPxTextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="lbl_left_td">
                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel4" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Text="Fecha Inicio :">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                    <td>
                                        <cc1:SaimtASPxDateEdit ID="dedFechaInicio" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                            AutoPostBack="True">
                                        </cc1:SaimtASPxDateEdit>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="lbl_left_td">
                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel6" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Text="Fecha Vencimiento :">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                    <td>
                                        <cc1:SaimtASPxDateEdit ID="dedFechaFin" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css">
                                        </cc1:SaimtASPxDateEdit>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="lbl_left_td">
                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel8" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Text=" Hora Inicio :">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                    <td>
                                        <cc1:SaimtASPxDateTime ID="dtHInicio" runat="server">
                                        </cc1:SaimtASPxDateTime>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="lbl_left_td">
                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel10" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Text=" Hora Fin :">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                    <td>
                                        <cc1:SaimtASPxDateTime ID="dtHFin" runat="server">
                                        </cc1:SaimtASPxDateTime>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="lbl_left_td">
                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel9" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Text="Precio :">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                    <td>
                                        <cc1:SaimtASPxTextBox ID="txtPrecio" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                            Text="" Width="170px">
                                            <MaskSettings Mask="&lt;0..9999999g&gt;.&lt;00..99&gt;" ShowHints="True" />
                                        </cc1:SaimtASPxTextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="lbl_left_td">
                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel16" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Text="Nivel :">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                    <td>
                                        <cc1:SaimtASPxComboBox ID="cboNivel" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                            ValueType="System.String">
                                        </cc1:SaimtASPxComboBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="lbl_left_td">
                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel19" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Text="Seleccione Espacio :">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                    <td>
                                        <cc1:SaimtASPxButton ID="btnSelecEspacio" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                            Text="Selecciona el Espacio">
                                        </cc1:SaimtASPxButton>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="lbl_left_td">
                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel17" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Text="Nro de Espacio :">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                    <td>
                                        <cc1:SaimtASPxTextBox ID="txtEspacioSelec" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                            Text="" ClientIDMode="Static" Width="170px">
                                        </cc1:SaimtASPxTextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="lbl_left_td">
                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel21" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Text="Estado Acuerdo :">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                    <td>
                                        <cc1:SaimtASPxComboBox ID="cboAcuerdoEstado" runat="server" 
                                            CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                            SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" 
                                            ValueType="System.String">
                                       </cc1:SaimtASPxComboBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <td>
                                            <table>
                                                <tr>
                                                    <td>
                                                        <cc1:SaimtASPxButton ID="btnNuevo" runat="server" HorizontalAlign="Center" ImagePosition="Top"
                                                            Text="Nuevo" ToolTip="Nuevo Registro">
                                                            <Image Url="~/images/nuevo32.png">
                                                            </Image>
                                                        </cc1:SaimtASPxButton>
                                                    </td>
                                                    <td>
                                                        <cc1:SaimtASPxButton ID="btnEditar" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                            CssPostfix="PlasticBlue" HorizontalAlign="Center" ImagePosition="Top" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                                            Text="Editar">
                                                            <Image Url="~/images/editar32.png">
                                                            </Image>
                                                        </cc1:SaimtASPxButton>
                                                    </td>
                                                    <td>
                                                        <cc1:SaimtASPxButton ID="btnLimpiar" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                            CssPostfix="PlasticBlue" HorizontalAlign="Center" ImagePosition="Top" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                                            Text="Limpiar">
                                                            <Image Url="~/images/limpiar32.png">
                                                            </Image>
                                                        </cc1:SaimtASPxButton>
                                                    </td>
                                                    <td>
                                                        <cc1:SaimtASPxButton ID="btnCancelar" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                            CssPostfix="PlasticBlue" HorizontalAlign="Center" ImagePosition="Top" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                                            Text="Cancelar">
                                                            <Image Url="~/images/cancelar32.png">
                                                            </Image>
                                                        </cc1:SaimtASPxButton>
                                                    </td>
                                                    <td>
                                                        <cc1:SaimtASPxButton ID="btnGuardar" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                            CssPostfix="PlasticBlue" HorizontalAlign="Center" ImagePosition="Top" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                                            Text="Guardar">
                                                            <Image Url="~/images/guardar32(1).png">
                                                            </Image>
                                                            <ClientSideEvents Click="function (s, e) {e.processOnServer = confirm('Desea Guardar?');}" />
                                                        </cc1:SaimtASPxButton>
                                                    </td>
                                                    <td>
                                                        <cc1:SaimtASPxButton ID="btnEliminar" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                            CssPostfix="PlasticBlue" HorizontalAlign="Center" ImagePosition="Top" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                                            Text="Eliminar">
                                                            <Image Url="~/images/eliminar32(1).png">
                                                            </Image>
                                                            <ClientSideEvents Click="function (s, e) {e.processOnServer = confirm('Desea Eliminar?');}" />
                                                        </cc1:SaimtASPxButton>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </td>
                                </tr>
                            </table>
                        </dx:PanelContent>
                    </PanelCollection>
                </cc1:SaimtASPxRoundPanel>
            </td>
        </tr>
        <tr>
            <td style="text-align: center" class="TablaBuscar">
                &nbsp;
            </td>
        </tr>
    </table>
</asp:Content>
