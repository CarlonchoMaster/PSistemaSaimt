﻿<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Principal.Master"
    CodeBehind="frmCajaDiario.aspx.vb" Inherits="PresentacionWeb.frmCajaDiario" %>

<%@ Register Assembly="SaimtControlesWeb" Namespace="SaimtControlesWeb" TagPrefix="cc1" %>
<%@ Register Assembly="DevExpress.Web.v16.1, Version=16.1.2.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .btnConfirmarOculto
        {
            position: absolute;
            left: -1px;
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
    <table>
        <tr>
            <td align="center">
                <cc1:SaimtASPxLabel ID="SaimtASPxLabel36" runat="server" Font-Bold="True" Font-Size="45px"
                    Style="text-align: center" Text="SALIDA DE VEHICULOS">
                </cc1:SaimtASPxLabel>
            </td>
        </tr>
        <tr>
            <td align="center">
                <cc1:SaimtASPxImage ID="SaimtASPxImage2" runat="server" Height="64px" ImageAlign="Top"
                    ImageUrl="~/images/imagen.png" Width="329px">
                </cc1:SaimtASPxImage>
            </td>
        </tr>
        <tr>
            <td class="style33" valign="top">
                <cc1:SaimtASPxRoundPanel ID="SaimtASPxRoundPanel1" runat="server" HeaderText="" Height="104px"
                    Width="840px">
                    <PanelCollection>
                        <dx:PanelContent ID="PanelContent1" runat="server" SupportsDisabledAttribute="True">
                            <table width="100%">
                                <tr>
                                    <td colspan="2" align="center">
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
                                    <td valign="top" class="style55">
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
                                    <td valign="top">
                                        <cc1:SaimtASPxTextBox ID="txtPlacaVehiculo" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Font-Bold="True" Font-Size="70px" Height="103px" HorizontalAlign="Center"
                                            SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text="" Width="100%">
                                            <ClientSideEvents KeyPress="function(s, e) {
                                                 if (e.htmlEvent.keyCode == 13) {
	                                                /*alert(s.GetValue());*/
                                                    btnConfirmar.Click();
                                                }
                                            }" />
                                            <ValidationSettings ValidateOnLeave="False">
                                            </ValidationSettings>
                                        </cc1:SaimtASPxTextBox>
                                        <cc1:SaimtASPxButton ID="btnConfirmar" runat="server" ClientInstanceName="btnConfirmar"
                                            CssClass="btnConfirmarOculto" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                            Text="Confirmar">
                                        </cc1:SaimtASPxButton>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style22">
                                        &nbsp;
                                    </td>
                                    <td class="style55">
                                        <table width="100%">
                                            <tr>
                                                <td align="center" colspan="3">
                                                    <cc1:SaimtASPxLabel ID="lblMensajeAcuerdo" runat="server" 
                                                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                                        Font-Bold="True" Font-Size="13px" ForeColor="#336699">
                                                    </cc1:SaimtASPxLabel>
                                                    &nbsp;
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style22">
                                        &nbsp;
                                    </td>
                                    <td align="center">
                                        <br />
                                        <cc1:SaimtASPxLabel ID="lblMensajeExito" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Font-Bold="True" Font-Size="13px" ForeColor="Black">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                </tr>
                            </table>
                        </dx:PanelContent>
                    </PanelCollection>
                </cc1:SaimtASPxRoundPanel>
            </td>
        </tr>
        <tr>
            <td align="center">
                <cc1:SaimtASPxRoundPanel ID="rpnInfEntradaSalida" runat="server" HeaderText="" Height="116px"
                    Width="585px">
                    <PanelCollection>
                        <dx:PanelContent ID="PanelContent2" runat="server" SupportsDisabledAttribute="True">
                            <table>
                                <tr>
                                    <td colspan="4" align="center">
                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel43" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Font-Bold="True" Font-Size="30px" ForeColor="#990000"
                                            Style="text-align: left" Text="INFORMACION DE ENTRADA Y SALIDA">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="lbl_left_td">
                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel37" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" ForeColor="Black" Text="HORA DE INGRESO :">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                    <td class="style48">
                                        <cc1:SaimtASPxTextBox ID="txtHoraIngreso" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Height="16px" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                            Text="" Width="127px">
                                        </cc1:SaimtASPxTextBox>
                                    </td>
                                    <td class="lbl_left_td">
                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel9" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" ForeColor="Black" Text="MONTO A PAGAR :">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                    <td class="style49">
                                        <cc1:SaimtASPxTextBox ID="txtMontoPagar" ClientInstanceName="txtMontoPagar" runat="server"
                                            CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue"
                                            Height="16px" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text=""
                                            Width="107px" ReadOnly="True">
                                            <MaskSettings Mask="&lt;0..9999999g&gt;.&lt;00..99&gt;" ShowHints="True" />
                                        </cc1:SaimtASPxTextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="lbl_left_td">
                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel38" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" ForeColor="Black" Text="HORA DE SALIDA :">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                    <td class="style51">
                                        <cc1:SaimtASPxTextBox ID="txtHoraSalida" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Height="16px" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                            Text="" Width="127px">
                                        </cc1:SaimtASPxTextBox>
                                    </td>
                                    <td class="lbl_left_td">
                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel15" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" ForeColor="Black" Text="PAGA CON :">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                    <td class="style39">
                                        <cc1:SaimtASPxTextBox ID="txtPagaCon" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Height="16px" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                            Text="" Width="107px">
                                            <ClientSideEvents ValueChanged="function(s, e) {                                                                                              
                                                    txtVuelto.SetValue(s.GetValue() - txtMontoPagar.GetValue());           
                                                    txtVuelto.toFixed(2);                                   
                                            }" />
                                            <MaskSettings AllowMouseWheel="False" Mask="&lt;0..9999999g&gt;.&lt;00..99&gt;" 
                                                ShowHints="True" />
                                        </cc1:SaimtASPxTextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="lbl_left_td">
                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel39" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" ForeColor="Black" Text="TIEMPO TRANSCURRIDO :">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                    <td class="style41">
                                        <cc1:SaimtASPxTextBox ID="txtTiempoTranscurrido" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Height="16px" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                            Text="" Width="127px">
                                        </cc1:SaimtASPxTextBox>
                                    </td>
                                    <td class="lbl_left_td">
                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel16" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" ForeColor="Black" Text="VUELTO :">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                    <td class="style42">
                                        <cc1:SaimtASPxTextBox ID="txtVuelto" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Height="16px" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                            Text="" Width="107px" ClientInstanceName="txtVuelto" ReadOnly="True">
                                        </cc1:SaimtASPxTextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="lbl_left_td">
                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel40" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" ForeColor="Black" Text="HORAS CONTABILIZADAS :">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                    <td class="style52">
                                        <cc1:SaimtASPxTextBox ID="txtHorasContabilizadas" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Height="16px" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                            Text="" Width="127px">
                                        </cc1:SaimtASPxTextBox>
                                    </td>
                                    <td class="style52">
                                    </td>
                                    <td align="center">
                                        <cc1:SaimtASPxButton ID="btnConfirmarSalida" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                            Text="Confirmar">
                                        </cc1:SaimtASPxButton>
                                    </td>
                                </tr>
                            </table>
                        </dx:PanelContent>
                    </PanelCollection>
                </cc1:SaimtASPxRoundPanel>
            </td>
        </tr>
    </table>
</asp:Content>