﻿<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Principal.Master" CodeBehind="frmExtorno.aspx.vb" Inherits="PresentacionWeb.frmExtorno" %>
<%@ Register assembly="DevExpress.Web.v16.1, Version=16.1.2.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<%@ Register assembly="SaimtControlesWeb" namespace="SaimtControlesWeb" tagprefix="cc1" %>


<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
        <td></td>
            <td>
                <cc1:SaimtASPxLabel runat="server" Text="EXTORNO" CssPostfix="PlasticBlue" 
                    CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" 
                    ID="SaimtASPxLabel16" Font-Bold="True" Font-Size="Large" 
                    ForeColor="#003399"></cc1:SaimtASPxLabel>

            </td>
        </tr>
        <tr>
        <td valign="top">
                <cc1:SaimtASPxRoundPanel ID="SaimtASPxRoundPanel3" runat="server" 
                    HeaderText="Buscar por Número de Placa" HorizontalAlign="Left" 
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
                        <dx:ListEditItem Text="Num. de Placa" Value="1" />
                        <dx:ListEditItem Text="Num. Ticket" Value="2" />
                    </Items>
                </cc1:SaimtASPxRadioButtonList>
            </td>
        </tr>
        <tr>
            <td>
                <cc1:SaimtASPxTextBox ID="txtBuscarSaimt" runat="server" 
                    CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                    SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text="" 
                    Width="250px">
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
<dx:PanelContent ID="PanelContent3" runat="server" SupportsDisabledAttribute="True">
    <cc1:SaimtASPxListBox ID="LstListado" runat="server" AutoPostBack="True" 
        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Width="300px">
    </cc1:SaimtASPxListBox>
                        </dx:PanelContent>
</PanelCollection>
                </cc1:SaimtASPxRoundPanel>
                </td>
            <td valign="top">
                <cc1:SaimtASPxRoundPanel ID="rpDatos" runat="server" 
                    HeaderText="NUMERO DE TICKET">
                    <PanelCollection>
<dx:PanelContent ID="PanelContent1" runat="server" SupportsDisabledAttribute="True">
    <table>
        <tr>
            <td class="lbl_left_td">
                <cc1:SaimtASPxLabel ID="SaimtASPxLabel10" runat="server" 
                    CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                    Text="Nro Ticket :">
                </cc1:SaimtASPxLabel>
            </td>
            <td>
                <cc1:SaimtASPxTextBox ID="txtDiarioId" runat="server" 
                    CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                    SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" 
                    style="margin-left: 0px" Text="" Width="400px">
                </cc1:SaimtASPxTextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
                        </dx:PanelContent>
</PanelCollection>
                </cc1:SaimtASPxRoundPanel>
                <cc1:SaimtASPxRoundPanel ID="rpDetalleTicket" runat="server" 
                    HeaderText="DETALLE DE TICKET">
                    <PanelCollection>
<dx:PanelContent ID="PanelContent2" runat="server" SupportsDisabledAttribute="True">
    <cc1:SaimtASPxGridView ID="dgvDatosTicket" runat="server" 
        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" 
        CssPostfix="PlasticBlue" Width="520px" AutoGenerateColumns="False" 
        >
        <Columns>
            <dx:GridViewDataTextColumn FieldName="diaFIngreso" 
                ShowInCustomizationForm="True" VisibleIndex="2" Caption="Fecha Ingreso">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="diarioId" 
                ShowInCustomizationForm="True" VisibleIndex="0" Caption="Codigo">
            </dx:GridViewDataTextColumn>
        </Columns>
<Images SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"></Images>

        <Styles CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" 
            CssPostfix="PlasticBlue">
        </Styles>
    </cc1:SaimtASPxGridView>
                        </dx:PanelContent>
</PanelCollection>
                </cc1:SaimtASPxRoundPanel>
            </td>
        </tr>
        <tr>
        <td></td>
            <td align="center">
                
                            <cc1:SaimtASPxButton ID="btnExtornar" runat="server" 
                                HorizontalAlign="Center" ImagePosition="Top" Text="Extornar" 
                                VerticalAlign="Top">
                                <Image Url="~/images/eliminar32(1).png">
                                </Image>
                            </cc1:SaimtASPxButton>
                       
                   
            </td>
        </tr>
        </table>
</asp:Content>
