<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Principal.Master"
    CodeBehind="frmPersona.aspx.vb" Inherits="PresentacionWeb.frmPersona" ValidateRequest="false" %>

<%@ Register Assembly="SaimtControlesWeb" Namespace="SaimtControlesWeb" TagPrefix="cc1" %>
<%@ Register Assembly="DevExpress.Web.v16.1, Version=16.1.2.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx" %>


<%@ Register Assembly="DevExpress.Web.v16.1, Version=16.1.2.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <script type="text/javascript">
    // <![CDATA[
        function OnProvinciaChanged(cboDepartamento) {
            cboProvincia.PerformCallback(cboDepartamento.GetValue().toString());
        }
        function OnDistritoChanged(cboProvincia) {
            cboDistrito.PerformCallback(cboProvincia.GetValue().toString());
        }

        //   function OnTipoContactoChanged(cboTipoContacto) {
        //         cboTipoContacto.PerformCallback(cbTipoContacto.GetValue().toString());
        //  }

        function validarLetras(s, e) {
            var i = 0;
            var cadena = "";
            while (s.GetValue().length > i) {
                if (s.GetValue().charAt(i) != "0" && s.GetValue().charAt(i) != "1" && s.GetValue().charAt(i) != "2" &&
                s.GetValue().charAt(i) != "3" && s.GetValue().charAt(i) != "4" && s.GetValue().charAt(i) != "5" &&
                s.GetValue().charAt(i) != "6" && s.GetValue().charAt(i) != "7" && s.GetValue().charAt(i) != "8" &&
                s.GetValue().charAt(i) != "9"
                )
                    cadena += s.GetValue()[i];
                i++;
            }
            s.SetValue(cadena);
        }
        
     
    // ]]> 
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td valign="top">
                <cc1:SaimtASPxRoundPanel ID="SaimtASPxRoundPanel3" runat="server" HeaderText="Burcar por :"
                    Width="300px">
                    <PanelCollection>
                        <dx:PanelContent ID="PanelContent3" runat="server" SupportsDisabledAttribute="True"
                            CssClass="lbl_left_td">
                            <cc1:SaimtASPxRadioButtonList ID="rblBuscar" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                CssPostfix="PlasticBlue" RepeatDirection="Horizontal" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                Width="100%">
                                <Items>
                                    <dx:ListEditItem Text="DNI" Value="11" />
                                    <dx:ListEditItem Text="RUC" Value="16" />
                                    <dx:ListEditItem Text="NyA/R" Value="0" />
                                </Items>
                            </cc1:SaimtASPxRadioButtonList>
                            <table width="270px" style="width: 278px">
                                <tr>
                                    <td class="style36">
                                        <cc1:SaimtASPxTextBox ID="txtBuscarSaimt" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Height="16px" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                            Text="" Width="230px">
                                        </cc1:SaimtASPxTextBox>
                                    </td>
                                    <td>
                                        <cc1:SaimtASPxButton ID="btnSaimtBuscar" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Height="16px" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                            Text="..." Width="20px">
                                        </cc1:SaimtASPxButton>
                                    </td>
                                </tr>
                            </table>
                        </dx:PanelContent>
                    </PanelCollection>
                </cc1:SaimtASPxRoundPanel>
                <cc1:SaimtASPxRoundPanel ID="SaimtASPxRoundPanel4" runat="server" HeaderText="Listado"
                    Width="300px">
                    <PanelCollection>
                        <dx:PanelContent runat="server" SupportsDisabledAttribute="True">
                            <cc1:SaimtASPxListBox runat="server" AutoPostBack="True" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                CssPostfix="PlasticBlue" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                Width="100%" ID="LstListado" Height="510px">
                            </cc1:SaimtASPxListBox>
                        </dx:PanelContent>
                    </PanelCollection>
                </cc1:SaimtASPxRoundPanel>
            </td>
            <td rowspan="2" valign="top">
                <cc1:SaimtASPxRoundPanel ID="rpDatos" runat="server" HeaderText="REGISTRAR PERSONAS"
                    Font-Size="X-Large">
                    <PanelCollection>
                        <dx:PanelContent runat="server" SupportsDisabledAttribute="True">
                            <table>
                                <tr>
                                    <td colspan="4" class="lbl_right_td">
                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel2" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Text="DATOS PERSONALES">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="lbl_left_td">
                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel17" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Text="Cod. Persona :">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                    <td>
                                        <cc1:SaimtASPxTextBox ID="txtCodigo" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                            Text="" Width="150px">
                                        </cc1:SaimtASPxTextBox>
                                    </td>
                                    <td align="right" class="lbl_left_td">
                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel3" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Text="Tipo Persona :">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                    <td>
                                        <cc1:SaimtASPxComboBox ID="cboTipoPersona" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Height="21px" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                            ValueType="System.String" Width="150px" Style="margin-left: 0px">
                                        </cc1:SaimtASPxComboBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="lbl_left_td">
                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel4" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Text="Tipo Documento :">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                    <td>
                                        <cc1:SaimtASPxComboBox runat="server" ValueType="System.String" Width="150px" Height="16px"
                                            SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" CssPostfix="PlasticBlue"
                                            CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" ID="cboTipoDocumento">
                                        </cc1:SaimtASPxComboBox>
                                    </td>
                                    <td align="right" class="lbl_left_td">
                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel8" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Text="N° de Doc :">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                    <td>
                                        <cc1:SaimtASPxTextBox ID="txtNroDocumento" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Height="16px" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                            Text="" Width="150px">
                                        </cc1:SaimtASPxTextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="lbl_left_td">
                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel5" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Text="Nombre o Razón :">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                    <td colspan="3">
                                        <cc1:SaimtASPxTextBox ID="txtNombreRazon" ClientInstanceName="txtNombreRazon" runat="server"
                                            CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue"
                                            Height="16px" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text=""
                                            Width="390px">
                                            <ClientSideEvents KeyUp="function(s, e) {
	validarLetras(s,e);
}" />
                                        </cc1:SaimtASPxTextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="lbl_left_td">
                                        <cc1:SaimtASPxLabel runat="server" Text="Apellido Paterno :" CssPostfix="PlasticBlue"
                                            CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" ID="SaimtASPxLabel6">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                    <td colspan="3">
                                        <cc1:SaimtASPxTextBox runat="server" Text="" Width="390px" Height="16px" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                            CssPostfix="PlasticBlue" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            ID="txtApePaterno">
                                        </cc1:SaimtASPxTextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="lbl_left_td">
                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel7" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Text="Apellido Materno :">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                    <td colspan="3">
                                        <cc1:SaimtASPxTextBox ID="txtApeMaterno" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                            Text="" Width="390px">
                                        </cc1:SaimtASPxTextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="4">
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="4" class="lbl_right_td">
                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel9" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Text="DOMICILIO FISCAL" Width="100%">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="lbl_left_td">
                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel10" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Text="Departamento :">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                    <td colspan="3">
                                        <cc1:SaimtASPxComboBox ID="cboDepartamento" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                            ValueType="System.String">
                                            <ClientSideEvents SelectedIndexChanged="function(s, e) { OnProvinciaChanged(s); }" />
                                        </cc1:SaimtASPxComboBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="lbl_left_td">
                                        <cc1:SaimtASPxLabel runat="server" Text="Provincia :" CssPostfix="PlasticBlue" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            ID="SaimtASPxLabel11">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                    <td colspan="3">
                                        <cc1:SaimtASPxComboBox runat="server" ValueType="System.String" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                            CssPostfix="PlasticBlue" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            ID="cboProvincia" ClientInstanceName="cboProvincia" OnCallback="cboProvincia_Callback">
                                            <ClientSideEvents SelectedIndexChanged="function(s, e) { OnDistritoChanged(s); }">
                                            </ClientSideEvents>
                                        </cc1:SaimtASPxComboBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="lbl_left_td">
                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel12" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Text="Distrito :">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                    <td colspan="3">
                                        <cc1:SaimtASPxComboBox ID="cboDistrito" runat="server" ClientInstanceName="cboDistrito"
                                            CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue"
                                            OnCallback="cboDistrito_Callback" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                            ValueType="System.String">
                                        </cc1:SaimtASPxComboBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="lbl_left_td">
                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel13" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Text="Dirección :">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                    <td colspan="3">
                                        <cc1:SaimtASPxTextBox ID="txtDireccion" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Height="16px" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                            Text="" Width="390px">
                                        </cc1:SaimtASPxTextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="4">
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="4" class="lbl_right_td">
                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel14" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Text="DATOS ADICIONALES" Width="100%">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="lbl_left_td">
                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel16" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Text="Tipo :">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                    <td colspan="3">
                                        <cc1:SaimtASPxComboBox ID="cbTipoContacto" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Height="16px" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                            ValueType="System.String" Width="390px">
                                            <%--<ClientSideEvents SelectedIndexChanged="function(s, e) { OnTipoContactoChanged(s); }" />--%>
                                        </cc1:SaimtASPxComboBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="lbl_left_td">
                                        <cc1:SaimtASPxLabel ID="SaimtASPxLabel15" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Text="Descripción :">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                    <td colspan="3">
                                        <cc1:SaimtASPxTextBox ID="txtDescripcion" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" Height="16px" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                            Text="" Width="390px">
                                        </cc1:SaimtASPxTextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                    </td>
                                    <td>
                                        <table>
                                            <tr>
                                                <td>
                                                    <cc1:SaimtASPxButton ID="btnAgregar" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                        CssPostfix="PlasticBlue" Height="10px" HorizontalAlign="Center" ImagePosition="Top"
                                                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" SpriteImageUrl="~/images/ver_detalle32.png"
                                                        Width="10px">
                                                        <Image Url="~/images/agregar16.png">
                                                        </Image>
                                                    </cc1:SaimtASPxButton>
                                                </td>
                                                <td>
                                                    <cc1:SaimtASPxButton ID="btnQuitar" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                        CssPostfix="PlasticBlue" Height="10px" HorizontalAlign="Center" ImagePosition="Top"
                                                        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" SpriteImageUrl="~/images/ver_detalle32.png"
                                                        Width="10px">
                                                        <ClientSideEvents Click="function (s, e) {e.processOnServer = confirm('Desea Eliminar Dato?');}" />
                                                        <Image Url="~/images/remover16.png">
                                                        </Image>
                                                    </cc1:SaimtASPxButton>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                    <tr>
                                        <td>
                                        </td>
                                        <td colspan="3">
                                            <cc1:SaimtASPxGridView ID="dgvDatosAdicionales" runat="server" KeyFieldName="ContactoId"
                                                AutoGenerateColumns="False" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                CssPostfix="PlasticBlue" Width="390px">
                                                <Columns>
                                                    <dx:GridViewDataTextColumn Caption="ContactoId" FieldName="ContactoId" Name="colContactoId"
                                                        ShowInCustomizationForm="True" Visible="False" VisibleIndex="1">
                                                    </dx:GridViewDataTextColumn>
                                                    <dx:GridViewDataTextColumn Caption="Contacto" FieldName="Contacto" Name="colContacto"
                                                        ShowInCustomizationForm="True" VisibleIndex="2">
                                                    </dx:GridViewDataTextColumn>
                                                    <dx:GridViewDataTextColumn Caption="Descripcion" FieldName="Descripcion" Name="colDescripcion"
                                                        ShowInCustomizationForm="True" VisibleIndex="3">
                                                    </dx:GridViewDataTextColumn>
                                                </Columns>
                                                <SettingsBehavior AllowFocusedRow="True" AllowSelectByRowClick="True" AllowSelectSingleRowOnly="True" />
                                                <Images SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css">
                                                </Images>
                                                <Styles CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue">
                                                </Styles>
                                            </cc1:SaimtASPxGridView>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="lbl_left_td">
                                            <cc1:SaimtASPxLabel ID="SaimtASPxLabel18" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                CssPostfix="PlasticBlue" Text="Estado :">
                                            </cc1:SaimtASPxLabel>
                                        </td>
                                        <td colspan="3">
                                            <cc1:SaimtASPxCheckBox ID="chkActivo" runat="server" CheckState="Unchecked" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                CssPostfix="PlasticBlue" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                                Text="Activo">
                                            </cc1:SaimtASPxCheckBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            &nbsp;
                                        </td>
                                        <td colspan="3">
                                            <table align="left">
                                                <tr>
                                                    <td>
                                                        <cc1:SaimtASPxButton ID="btnNuevo" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                            CssPostfix="PlasticBlue" Height="40px" HorizontalAlign="Center" ImagePosition="Top"
                                                            SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text="Nuevo" ToolTip="Nuevo Registro"
                                                            Width="47px">
                                                            <Image Url="~/images/nuevo32.png">
                                                            </Image>
                                                        </cc1:SaimtASPxButton>
                                                    </td>
                                                    <td>
                                                        <cc1:SaimtASPxButton ID="btnEditar" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                            CssPostfix="PlasticBlue" Height="40px" HorizontalAlign="Center" ImagePosition="Top"
                                                            SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text="Editar" Width="48px">
                                                            <Image Url="~/images/editar32.png">
                                                            </Image>
                                                        </cc1:SaimtASPxButton>
                                                    </td>
                                                    <td>
                                                        <cc1:SaimtASPxButton ID="btnLimpiar" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                            CssPostfix="PlasticBlue" Height="40px" HorizontalAlign="Center" ImagePosition="Top"
                                                            SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text="Limpiar" Width="48px">
                                                            <Image Url="~/images/limpiar32.png">
                                                            </Image>
                                                        </cc1:SaimtASPxButton>
                                                    </td>
                                                    <td>
                                                        <cc1:SaimtASPxButton ID="btnCancelar" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                            CssPostfix="PlasticBlue" Height="40px" HorizontalAlign="Center" ImagePosition="Top"
                                                            SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text="Cancelar" Width="48px">
                                                            <Image Url="~/images/cancelar32.png">
                                                            </Image>
                                                        </cc1:SaimtASPxButton>
                                                    </td>
                                                    <td>
                                                        <cc1:SaimtASPxButton ID="btnGuardar" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                            CssPostfix="PlasticBlue" Height="40px" HorizontalAlign="Center" ImagePosition="Top"
                                                            SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text="Guardar" Width="48px">
                                                            <ClientSideEvents Click="function (s, e) {e.processOnServer = confirm('Desea Guardar?');}" />
                                                            <Image Url="~/images/guardar32(1).png">
                                                            </Image>
                                                        </cc1:SaimtASPxButton>
                                                    </td>
                                                    <td>
                                                        <cc1:SaimtASPxButton ID="btnEliminar" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                            CssPostfix="PlasticBlue" Height="40px" HorizontalAlign="Center" ImagePosition="Top"
                                                            SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Text="Eliminar" Width="48px">
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
        <tr>
            <td valign="top">
                &nbsp;
            </td>
        </tr>
    </table>
</asp:Content>
