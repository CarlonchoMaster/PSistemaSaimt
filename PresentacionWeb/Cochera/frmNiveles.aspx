<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Principal.Master"
    CodeBehind="frmNiveles.aspx.vb" Inherits="PresentacionWeb.frmNiveles" %>

<%@ Register Assembly="SaimtControlesWeb" Namespace="SaimtControlesWeb" TagPrefix="cc1" %>
<%@ Register Assembly="DevExpress.Web.v16.1, Version=16.1.2.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx" %>


<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td>
            </td>
            <td>
                <cc1:SaimtASPxLabel ID="SaimtASPxLabel2" runat="server" Text="NIVELES" Font-Bold="True"
                    Font-Size="Large" ForeColor="#003399">
                </cc1:SaimtASPxLabel>
                </td>
        </tr>
        <tr>
            <td valign="top">
                <cc1:SaimtASPxRoundPanel ID="SaimtASPxRoundPanel3" runat="server" 
                    HeaderText="Burcar por :">
                    <PanelCollection>
<dx:PanelContent ID="PanelContent3" runat="server" SupportsDisabledAttribute="True">
  
    
                        <table border="0" cellpadding="0" cellspacing="1">
                            <tr>
                                <td>
                                    <cc1:SaimtASPxTextBox ID="txtBuscarSaimt" runat="server" 
                                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" 
                                        Text="" ToolTip="algo" Width="255px">
                                    </cc1:SaimtASPxTextBox>
                                </td>
                                <td>
                                    <cc1:SaimtASPxButton ID="btnSaimtBuscar" runat="server" 
                                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" 
                                        HorizontalAlign="Center" VerticalAlign="Top">
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
<dx:PanelContent ID="PanelContent4" runat="server" SupportsDisabledAttribute="True">
    <cc1:SaimtASPxListBox ID="LstListado" runat="server"
        AutoPostBack="True" Width="300px">
    </cc1:SaimtASPxListBox>
                        </dx:PanelContent>
</PanelCollection>
                </cc1:SaimtASPxRoundPanel>
                </td>
            <td valign="top">
                <cc1:SaimtASPxRoundPanel ID="rpDatos" runat="server" HeaderText="DATOS DE NIVELES"
                    >
                    <PanelCollection>
                        <dx:PanelContent ID="PanelContent1" runat="server" SupportsDisabledAttribute="True">
                            <table>
                                <tr>
                                    <td class="lbl_left_td">
                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel11" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Text="Codigo :">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                    <td>
                                        <cc1:SaimtASPxTextBox ID="txtCodigo" runat="server" 
                                            CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                            SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text="" Width="50px" 
                                            >
                                        </cc1:SaimtASPxTextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="lbl_left_td">
                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel12" runat="server" 
                                            CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                            Text="Institución :">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                    <td>
                                        <cc1:SaimtASPxComboBox ID="cboInstitucion" runat="server" AutoPostBack="True" 
                                            CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                            SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" 
                                            ValueType="System.String" Width="438px">
                                        </cc1:SaimtASPxComboBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="lbl_left_td">
                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel13" runat="server" 
                                            CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                            Text="Sede :">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                    <td>
                                        <cc1:SaimtASPxComboBox ID="cboSede" runat="server" 
                                            CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                            SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" 
                                            ValueType="System.String" Width="438px" AutoPostBack="True">
                                        </cc1:SaimtASPxComboBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="lbl_left_td">
                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel5" runat="server" 
                                            CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                            Text="Nombre :">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                    <td>
                                        <cc1:SaimtASPxTextBox ID="txtNombre" runat="server" 
                                            CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                            SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" 
                                            Style="margin-left: 0px" Text="" Width="438px">
                                        </cc1:SaimtASPxTextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="lbl_left_td">
                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel6" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Text="Nro Piso :">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                    <td>
                                        <cc1:SaimtASPxComboBox ID="cboNroPiso" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                            ValueType="System.String">
                                        </cc1:SaimtASPxComboBox>
                                        <cc1:SaimtASPxTextBox ID="txtCodigo0" runat="server" 
                                            CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                            SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text="" 
                                            Width="50px">
                                        </cc1:SaimtASPxTextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="lbl_left_td">
                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel7" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Text="Espacios Asignados :">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                   
                                </tr>
                                <tr>
                                    <td class="lbl_left_td">
                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel8" runat="server" 
                                            CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                            Text="Desde">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                    <td>
                                        <table>
                                            <tr>
                                                <td>
                                                    <cc1:SaimtASPxSpinner ID="spnDesde" runat="server" 
                                                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css">
                                                    </cc1:SaimtASPxSpinner>
                                                </td>
                                                <td class="lbl_left_td">
                                                    <cc1:SaimtASPxLabel ID="SaimtASPxLabel9" runat="server" 
                                                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                                        Text="Hasta">
                                                    </cc1:SaimtASPxLabel>
                                                </td>
                                                <td>
                                                    <cc1:SaimtASPxSpinner ID="spnHasta" runat="server" 
                                                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css">
                                                    </cc1:SaimtASPxSpinner>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="lbl_left_td">
                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel10" runat="server" 
                                            CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                            Text="Estado Nivel :">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                    <td>
                                        <cc1:SaimtASPxCheckBox ID="chbEstadoNivel" runat="server" 
                                            CheckState="Unchecked" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" 
                                            CssPostfix="PlasticBlue" 
                                            SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text="Activo">
                                        </cc1:SaimtASPxCheckBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                    </td>
                                    <td>
                                        <table>
                                            <tr>
                                                <td>
                                                    <cc1:SaimtASPxButton ID="btnNuevo" runat="server" 
                                                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" 
                                                        HorizontalAlign="Center" ImagePosition="Top" 
                                                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text="Nuevo" 
                                                        ToolTip="Nuevo Registro">
                                                        <Image Url="~/images/nuevo32.png">
                                                        </Image>
                                                    </cc1:SaimtASPxButton>
                                                </td>
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
                                                        <ClientSideEvents Click="function (s, e) {e.processOnServer = confirm('Desea Guardar?');}" />
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
                                                        <ClientSideEvents Click="function (s, e) {e.processOnServer = confirm('Desea Eliminar?');}" />
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
        </table>
</asp:Content>
