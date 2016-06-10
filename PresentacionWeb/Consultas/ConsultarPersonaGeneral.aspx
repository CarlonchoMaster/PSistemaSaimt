﻿<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ConsultarPersonaGeneral.aspx.vb"
    Inherits="PresentacionWeb.ConsultarPersonaGeneral" %>

<%@ Register Assembly="SaimtControlesWeb" Namespace="SaimtControlesWeb" TagPrefix="cc1" %>
<%@ Register Assembly="DevExpress.Web.v16.1, Version=16.1.2.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
        }
        .style3
        {
            width: 304px;
        }
    </style>
    <script type="text/javascript">
    // <![CDATA[
        var keyValue;
        function Seleccionar(element, key) {
            location.href = "../Cochera/frmAcuerdo.aspx?idper="+key;

//            callbackPanel.SetContentHtml("");
//            popup.ShowAtElement(element);
//            keyValue = key;
        }
//        function popup_Shown(s, e) {
//            callbackPanel.PerformCallback(keyValue);
//        }
    // ]]> 
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <cc1:SaimtASPxRoundPanel ID="SaimtASPxRoundPanel1" runat="server" Height="111px"
            Width="417px">
            <PanelCollection>
                <dx:PanelContent runat="server" SupportsDisabledAttribute="True">
                    <table class="style1">
                        <tr>
                            <td class="style2">
                                <cc1:SaimtASPxLabel ID="SaimtASPxLabel1" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                    CssPostfix="PlasticBlue" Text="Buscar :">
                                </cc1:SaimtASPxLabel>
                            </td>
                            <td class="style3">
                                <cc1:SaimtASPxTextBox ID="txtbuscar" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                    CssPostfix="PlasticBlue" Height="20px" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                    Text="" Width="100%">
                                </cc1:SaimtASPxTextBox>
                            </td>
                            <td>
                                <cc1:SaimtASPxButton ID="btnBuscar" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                    CssPostfix="PlasticBlue" Height="16px" HorizontalAlign="Center" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                    VerticalAlign="Top" Width="16px">
                                    <Image Url="~/images/buscar.png">
                                    </Image>
                                </cc1:SaimtASPxButton>
                            </td>
                        </tr>
                        <tr>
                            <td class="style2" colspan="3">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style2" colspan="3">
                                <cc1:SaimtASPxGridView ID="dgvResultado" ClientInstanceName="grid" runat="server" KeyFieldName="perId" AutoGenerateColumns="False"
                                    CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue"
                                    Style="margin-right: 0px" Width="100%">
                                    <Columns>
                                        <dx:GridViewDataTextColumn FieldName="perId" ShowInCustomizationForm="True" VisibleIndex="1">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn FieldName="persona" ShowInCustomizationForm="True" VisibleIndex="2">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn FieldName="tipoPersona" ShowInCustomizationForm="True"
                                            VisibleIndex="3">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn FieldName="tipoDocumento" ShowInCustomizationForm="True"
                                            VisibleIndex="4">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn FieldName="numeroDocumento" ShowInCustomizationForm="True"
                                            VisibleIndex="5">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn FieldName="direccion" ShowInCustomizationForm="True" VisibleIndex="6">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataColumn Caption="Seleccionar" VisibleIndex="8" Width="15%">
                                            <DataItemTemplate>                                               
                                                <a href="javascript:close();" onclick="window.opener.document.getElementById('txtCliente_I').value='<%# Eval("persona") %>';window.opener.document.getElementById('txtPerId_I').value='<%# Eval("perId") %>';">Seleccionar</a>
                                                </DataItemTemplate>
                                        </dx:GridViewDataColumn>
                                    </Columns>
                                    <SettingsBehavior AllowSelectSingleRowOnly="True" />
                                    <SettingsText CommandSelect="Seleccionar" />

<Images SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"></Images>

                                    <Styles CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue">
                                    </Styles>
                                </cc1:SaimtASPxGridView>
                            </td>
                        </tr>
                    </table>
                </dx:PanelContent>
            </PanelCollection>
        </cc1:SaimtASPxRoundPanel>
    </div>
    </form>
</body>
</html>