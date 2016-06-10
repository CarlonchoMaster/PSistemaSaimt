<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Principal.Master"
    CodeBehind="frmRegistroDiario.aspx.vb" Inherits="PresentacionWeb.frmRegistroDiario" %>

<%@ Register Assembly="SaimtControlesWeb" Namespace="SaimtControlesWeb" TagPrefix="cc1" %>
<%@ Register Assembly="DevExpress.Web.v16.1, Version=16.1.2.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .btnConfirmarOculto
        {
            position: absolute;
            left: 0;
            top: 0;
            z-index: -10;
        }
    </style>
    <script type="text/javascript">
        function Abrir_ventana(pagina) {
            var opciones = "toolbar=no,location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=yes, width=800, height=500";
            window.open(pagina + "?NivelId=" + cboNivel.GetValue(), "", opciones);
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table align="center" width="100%">
        <tr>
            <td colspan="2" align="center">
                <cc1:SaimtASPxLabel ID="SaimtASPxLabel36" runat="server" Font-Bold="True" Font-Size="45px"
                    Style="text-align: center" Text="REGISTRO DE VEHICULOS">
                </cc1:SaimtASPxLabel>
            </td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <cc1:SaimtASPxImage ID="SaimtASPxImage2" runat="server" Height="64px" ImageAlign="Top"
                    ImageUrl="~/images/imagen.png" Width="329px">
                </cc1:SaimtASPxImage>
            </td>
        </tr>
        <tr>
            <td valign="top" align="center">
                <cc1:SaimtASPxRoundPanel ID="SaimtASPxRoundPanel1" runat="server" HeaderText="" Height="104px"
                    Width="928px">
                    <PanelCollection>
                        <dx:PanelContent runat="server" SupportsDisabledAttribute="True">
                            <table class="with100por">
                                <tr>
                                    <td colspan="3" align="center">
                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel41" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Font-Bold="True" Font-Size="45px" ForeColor="#990000"
                                            Style="text-align: left" Text="CONTROL VEHICULAR">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        &nbsp;
                                    </td>
                                    <td valign="top">
                                        &nbsp;
                                    </td>
                                    <td valign="top">
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center">
                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel28" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Font-Bold="False" Font-Size="40px" ForeColor="#000099"
                                            Style="text-align: center" Text="INGRESE">
                                        </cc1:SaimtASPxLabel>
                                        <br />
                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel42" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Font-Bold="False" Font-Size="40px" ForeColor="#000099"
                                            Style="text-align: center" Text="PLACA">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                    <td valign="top" align="center">
                                        <cc1:SaimtASPxTextBox ID="txtPlacaVehiculo" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Font-Bold="True" Font-Size="70px" Height="103px" HorizontalAlign="Center"
                                            SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text="" Width="100%"
                                            MaxLength="6">
                                            <ClientSideEvents KeyPress="function(s, e) {
                                                 if (e.htmlEvent.keyCode == 13) {
	                                                /*alert(s.GetValue());*/
                                                    btnConfirmar.Click();
                                                }
                                            }" />
                                            <ClientSideEvents KeyPress="function(s, e) {
                                                 if (e.htmlEvent.keyCode == 13) {
	                                                /*alert(s.GetValue());*/
                                                    btnConfirmar.Click();
                                                }
                                            }"></ClientSideEvents>
                                            <ValidationSettings ValidateOnLeave="False">
                                            </ValidationSettings>
                                        </cc1:SaimtASPxTextBox>
                                        <cc1:SaimtASPxButton ID="btnConfirmar" runat="server" ClientInstanceName="btnConfirmar"
                                            CssClass="btnConfirmarOculto" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                            Text="Confirmar">
                                        </cc1:SaimtASPxButton>
                                        <asp:ScriptManager ID="ScriptManager1" runat="server">
                                        </asp:ScriptManager>
                                    </td>
                                    <td valign="top" align="center">
                                        <cc1:SaimtASPxRadioButtonList ID="rblTipoVehiculos" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                            Font-Size="25px">
                                        </cc1:SaimtASPxRadioButtonList>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style22">
                                        &nbsp;
                                    </td>
                                    <td class="style21" colspan="2">
                                        <asp:UpdatePanel ID="upPanelAsignarEspacio" runat="server">
                                            <ContentTemplate>
                                                <table class="style53">
                                                    <tr>
                                                        <td align="center">
                                                            <cc1:SaimtASPxComboBox ID="cboNivel" runat="server" ClientInstanceName="cboNivel"
                                                                CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue"
                                                                SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" ValueType="System.String"
                                                                Font-Size="30px">
                                                            </cc1:SaimtASPxComboBox>
                                                        </td>
                                                        <td>
                                                            <cc1:SaimtASPxButton ID="btnSelecEspacio" runat="server" AutoPostBack="False" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                                CssPostfix="PlasticBlue" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                                                Text="Selecciona el Espacio" UseSubmitBehavior="False" Font-Size="30px">
                                                                <ClientSideEvents Click="function (s, e) {Abrir_ventana('../Consultas/ConsultarEspaciosXNivel.aspx');}" />
                                                            </cc1:SaimtASPxButton>
                                                        </td>
                                                        <td align="center">
                                                            <cc1:SaimtASPxTextBox ID="txtEspacioSelec" runat="server" ClientIDMode="Static" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                                CssPostfix="PlasticBlue" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                                                Text="" Width="170px" Font-Size="30px" HorizontalAlign="Center">
                                                            </cc1:SaimtASPxTextBox>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                        <table width="100%">
                                            <tr>
                                                <td align="center" colspan="3">
                                                    <cc1:SaimtASPxButton ID="btnGuardar" runat="server" Text="Guardar">
                                                    </cc1:SaimtASPxButton>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style22">
                                        &nbsp;
                                    </td>
                                    <td colspan="2" align="center">
                                        <cc1:SaimtASPxLabel ID="lblAbonadoCliente" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Font-Bold="True" Font-Size="Larger" ForeColor="Red">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style22">
                                        &nbsp;
                                    </td>
                                    <td colspan="2" align="center">
                                        <cc1:SaimtASPxLabel ID="lblIngresoSalida" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Font-Bold="True" Font-Size="X-Large" ForeColor="#009933">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style22">
                                        &nbsp;
                                    </td>
                                    <td colspan="2" align="center">
                                        &nbsp;<cc1:SaimtASPxLabel ID="lblMensajeUbicacion" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Font-Bold="True" ForeColor="Blue">
                                        </cc1:SaimtASPxLabel>
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style22">
                                        &nbsp;
                                    </td>
                                    <td colspan="2" align="center">
                                        <br />
                                        <cc1:SaimtASPxLabel ID="lblMensajeExito" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Font-Bold="True" Font-Size="13px" ForeColor="Black">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style22">
                                        &nbsp;
                                    </td>
                                    <td colspan="2" align="center">
                                        <cc1:SaimtASPxHyperLink ID="hlRealizarNuevoAcuerdo" runat="server" 
                                            Font-Bold="True" NavigateUrl="~/Cochera/frmAcuerdo.aspx" 
                                            Text="Realizar Nuevo Acuerdo">
                                        </cc1:SaimtASPxHyperLink>
                                        &nbsp; o
                                        <asp:LinkButton ID="hlRealizarRegistroDiario" runat="server" Visible="False">Hora Fraccion</asp:LinkButton>
                                    </td>
                                </tr>
                            </table>
                        </dx:PanelContent>
                    </PanelCollection>
                </cc1:SaimtASPxRoundPanel>
            </td>
        </tr>
        <tr>
            <td class="style33">
                &nbsp;
            </td>
            <td class="style9">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="style33">
                &nbsp;
            </td>
            <td class="style9">
                &nbsp;
            </td>
        </tr>
    </table>
</asp:Content>
