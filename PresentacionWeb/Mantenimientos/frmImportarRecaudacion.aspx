<%@ Page Title="..:: Importar Recaudación ::.." Language="vb" AutoEventWireup="false"
    MasterPageFile="~/Principal.Master" CodeBehind="frmImportarRecaudacion.aspx.vb"
    Inherits="PresentacionWeb.frmImportarRec" %>

<%@ Register Assembly="DevExpress.Web.v16.1, Version=16.1.2.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register Assembly="SaimtControlesWeb" Namespace="SaimtControlesWeb" TagPrefix="cc1" %>







<%@ Register Assembly="DevExpress.Web.ASPxScheduler.v16.1, Version=16.1.2.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxScheduler" TagPrefix="dxwschs" %>
<%@ Register Assembly="DevExpress.Web.ASPxScheduler.v16.1, Version=16.1.2.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxScheduler.Controls" TagPrefix="dxwschsc" %>
<%@ Register Assembly="DevExpress.XtraScheduler.v16.1.Core, Version=16.1.2.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.XtraScheduler" TagPrefix="cc2" %>

<%@ Register Assembly="DevExpress.Web.ASPxTreeList.v16.1, Version=16.1.2.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxTreeList" TagPrefix="dx" %>



<asp:Content ID="hcontenido" ContentPlaceHolderID="HeadContent" runat="server">
    <script type="text/javascript">
    // <![CDATA[
        function habilitarCargarArchivo() {
            btnCargarArchivo.SetEnabled(uploadImportarRecaudacion.GetText(0) != "");
        }    
    // ]]> 
    </script>
</asp:Content>
<asp:Content ID="mContenido" ContentPlaceHolderID="MainContent" runat="server">
    <cc1:SaimtASPxPageControl ID="SaimtASPxPageControl1" runat="server" ActiveTabIndex="1"
        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue"
        SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" Width="100%">
        <TabPages>
            <dx:TabPage Text="Mostrar Recaudación">
                <ContentCollection>
                    <dx:ContentControl runat="server" SupportsDisabledAttribute="True">
                        <div id="div_criterios_mostrar_recaudacion" class="with100por">
                            <table>
                                <tr>
                                    <td class="txtCriterios">
                                        Seleccione el Agente Recaudador :
                                    </td>
                                    <td>
                                        <cc1:SaimtASPxRadioButtonList ID="rdbCriteriosMostrarRecaudacion" runat="server"
                                            RepeatDirection="Horizontal" CssClass="rdbCriteriosRecaudacion" ItemSpacing="28px"
                                            SelectedIndex="2">
                                            <Items>
                                                <dx:ListEditItem Text="Caja Trujillo" Value="02" />
                                                <dx:ListEditItem Text="SATT" Value="01" />
                                                <dx:ListEditItem Text="Todos" Value="00" Selected="True" />
                                            </Items>
                                        </cc1:SaimtASPxRadioButtonList>
                                    </td>
                                </tr>
                            </table>
                        </div>
                        <div id="div_grid_mostrar_recaudacion" class="with100por">
                            <dx:ASPxGridViewExporter ID="gveExportarGridRecaudacion" runat="server" GridViewID="dgvMostrarRecaudacion">
                            </dx:ASPxGridViewExporter>
                            <cc1:SaimtASPxGridView ID="dgvMostrarRecaudacion" runat="server" AutoGenerateColumns="False"
                                CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue"
                                KeyFieldName="KeyGridRecaudacionWEB" Width="100%" DataSourceID="odsMostrarRecaudacion">
                                <SettingsBehavior AllowSort="False" AllowFocusedRow="True"></SettingsBehavior>
                                <Settings ShowFooter="True"></Settings>
                                <SettingsDetail ShowDetailRow="True"></SettingsDetail>
                                <TotalSummary>
                                    <dx:ASPxSummaryItem FieldName="RecNeto" SummaryType="Sum" />
                                </TotalSummary>
                                <Columns>
                                    <dx:GridViewDataTextColumn Caption="Cod. Recaudación" FieldName="RecId" ShowInCustomizationForm="True"
                                        VisibleIndex="0">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="Fecha Pago" FieldName="RecFecPago" ShowInCustomizationForm="True"
                                        VisibleIndex="1">
                                        <PropertiesTextEdit DisplayFormatString="dd/MM/yyyy">
                                        </PropertiesTextEdit>
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="Nro. Orden" FieldName="RecNroOrden" ShowInCustomizationForm="True"
                                        VisibleIndex="2">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="Cod. Concepto" FieldName="ConId" ShowInCustomizationForm="True"
                                        VisibleIndex="3">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="Recibo" FieldName="RecNro" ShowInCustomizationForm="True"
                                        VisibleIndex="5">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="Tipo Doc." FieldName="TgNombreTipoDoc" ShowInCustomizationForm="True"
                                        VisibleIndex="6">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="Nro. Doc." FieldName="PerNroDoc" ShowInCustomizationForm="True"
                                        VisibleIndex="7">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="Persona" FieldName="PerNombre" ShowInCustomizationForm="True"
                                        VisibleIndex="8">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="Monto" FieldName="RecMonto" ShowInCustomizationForm="True"
                                        VisibleIndex="9">
                                        <PropertiesTextEdit DisplayFormatString="n2">
                                        </PropertiesTextEdit>
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="Concepto" FieldName="ConNombre" ShowInCustomizationForm="True"
                                        VisibleIndex="4">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="% Concepto" FieldName="ConPorcentaje" ShowInCustomizationForm="True"
                                        VisibleIndex="10">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="Total Ing." FieldName="RecTotalIng" ShowInCustomizationForm="True"
                                        VisibleIndex="11">
                                        <PropertiesTextEdit DisplayFormatString="n2">
                                        </PropertiesTextEdit>
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="Comisión" FieldName="RecVComision" ShowInCustomizationForm="True"
                                        VisibleIndex="12">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="% Comisión" FieldName="RecComision" ShowInCustomizationForm="True"
                                        VisibleIndex="13">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="Neto" FieldName="RecNeto" ShowInCustomizationForm="True"
                                        VisibleIndex="14">
                                        <PropertiesTextEdit DisplayFormatString="n2">
                                        </PropertiesTextEdit>
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="Fec. Registro" FieldName="RecFechaReg" ShowInCustomizationForm="True"
                                        VisibleIndex="15">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="Usuario" FieldName="UsuId" ShowInCustomizationForm="True"
                                        VisibleIndex="16">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="Recaudador" FieldName="TgNombreRecaudador" ShowInCustomizationForm="True"
                                        VisibleIndex="17">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="TgRecaudadorId" FieldName="TgRecaudadorId" ShowInCustomizationForm="True"
                                        Visible="False" VisibleIndex="18">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="Key" FieldName="KeyGridRecaudacionWEB" Name="Key"
                                        ShowInCustomizationForm="True" Visible="False" VisibleIndex="20">
                                        <PropertiesTextEdit ClientInstanceName="Key">
                                        </PropertiesTextEdit>
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="Fec. Liquidación" FieldName="RecFechaLiquidacion"
                                        ShowInCustomizationForm="True" VisibleIndex="19">
                                        <PropertiesTextEdit DisplayFormatString="dd/MM/yyyy">
                                        </PropertiesTextEdit>
                                    </dx:GridViewDataTextColumn>
                                </Columns>
                                <SettingsBehavior AllowFocusedRow="True" AllowSelectByRowClick="True" AllowSelectSingleRowOnly="True"
                                    AllowSort="False" />
                                <Settings ShowFooter="True" />
                                <SettingsDetail ShowDetailRow="True" ExportMode="All" />
                                <Images>
                                    <DetailCollapsedButton Height="16px" Url="~/images/collapsed.png" Width="16px">
                                    </DetailCollapsedButton>
                                    <DetailCollapsedButtonRtl Height="16px" Url="~/images/collapsed.png" Width="16px">
                                    </DetailCollapsedButtonRtl>
                                    <DetailExpandedButton Height="16px" Url="~/images/expanded.png" Width="16px">
                                    </DetailExpandedButton>
                                    <DetailExpandedButtonRtl Height="16px" Url="~/images/expanded.png" Width="16px">
                                    </DetailExpandedButtonRtl>
                                </Images>
                                <Styles CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue">
                                </Styles>
                                <Templates>
                                    <DetailRow>
                                        <table class="with100por">
                                            <tr>
                                                <td>
                                                    <table class="with100por">
                                                        <tr>
                                                            <td class="lbl_left_td" width="150px">
                                                                <cc1:SaimtASPxLabel ID="lblFechaLiquidacion" runat="server" Text="Fecha de Liquidación : ">
                                                                </cc1:SaimtASPxLabel>
                                                            </td>
                                                            <td width="180px">
                                                                <cc1:SaimtASPxDateEdit ID="dtpFechaLiquidacion" runat="server">
                                                                    <CalendarProperties ShowClearButton="False" ShowTodayButton="False"></CalendarProperties>
                                                                </cc1:SaimtASPxDateEdit>
                                                            </td>
                                                            <td>
                                                                <cc1:SaimtASPxButton ID="btnGuardarFechaLiquidación" runat="server" SaimtToolTip="Actualizar;Actualizar la Fecha de Liquidación de la Recaudación Seleccionada."
                                                                    ImagePosition="Top" Width="20px" OnClick="btnGuardarFechaLiquidación_Click">
                                                                    <Image Url="~/images/update16.png">
                                                                    </Image>
                                                                </cc1:SaimtASPxButton>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <cc1:SaimtASPxGridView ID="dgvRecaudacionDetalle" runat="server" AutoGenerateColumns="False"
                                                        CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue"
                                                        DataSourceID="odsRecaudacionDetalle" KeyFieldName="KeyGridRecaudacionDetalleWEB"
                                                        OnBeforePerformDataSelect="dgvRecaudacionDetalle_BeforePerformDataSelect" OnRowDeleting="dgvRecaudacionDetalle_RowDeleting"
                                                        OnRowValidating="dgvRecaudacionDetalle_RowValidating">
                                                        <TotalSummary>
                                                            <dx:ASPxSummaryItem FieldName="RecDMonto" SummaryType="Sum" />
                                                        </TotalSummary>
                                                        <Columns>
                                                            <dx:GridViewCommandColumn VisibleIndex="0" Name="ColEdicion">
                                                                <NewButton Text="Agregar" Visible="True">
                                                                </NewButton>
                                                                <DeleteButton Text="Eliminar" Visible="True">
                                                                </DeleteButton>
                                                            </dx:GridViewCommandColumn>
                                                            <dx:GridViewDataTextColumn Caption="Cod. Concepto" FieldName="ConId" Name="ConId"
                                                                VisibleIndex="2">
                                                            </dx:GridViewDataTextColumn>
                                                            <dx:GridViewDataTextColumn Caption="Concepto" FieldName="ConNombre" VisibleIndex="3">
                                                            </dx:GridViewDataTextColumn>
                                                            <dx:GridViewDataTextColumn Caption="Monto Depositado" FieldName="RecDMonto" VisibleIndex="4">
                                                                <PropertiesTextEdit DisplayFormatString="n2"></PropertiesTextEdit>
                                                            </dx:GridViewDataTextColumn>
                                                            <dx:GridViewDataTextColumn Caption="% SAIMT" FieldName="ConPorcentaje" VisibleIndex="5">
                                                            </dx:GridViewDataTextColumn>
                                                            <dx:GridViewDataTextColumn Caption="Ing. SAIMT" FieldName="RecDTotalIng" VisibleIndex="6">
                                                                <PropertiesTextEdit DisplayFormatString="n2"></PropertiesTextEdit>
                                                            </dx:GridViewDataTextColumn>
                                                            <dx:GridViewDataTextColumn Caption="Cod. Recaudación" FieldName="RecId" Name="RecId"
                                                                VisibleIndex="1">
                                                            </dx:GridViewDataTextColumn>
                                                            <dx:GridViewDataTextColumn Caption="Fecha Pago" FieldName="RecFecPago" VisibleIndex="7">
                                                                <PropertiesTextEdit DisplayFormatString="dd/MM/yyyy"></PropertiesTextEdit>
                                                            </dx:GridViewDataTextColumn>
                                                            <dx:GridViewDataTextColumn Caption="TgRecaudadorId" FieldName="TgRecaudadorId" Visible="False"
                                                                VisibleIndex="9">
                                                            </dx:GridViewDataTextColumn>
                                                            <dx:GridViewDataTextColumn Caption="KeyGridRecaudacionDetalleWEB" FieldName="KeyGridRecaudacionDetalleWEB"
                                                                Visible="False" VisibleIndex="10">
                                                            </dx:GridViewDataTextColumn>
                                                            <dx:GridViewDataTextColumn Caption="Fecha Liquidación" FieldName="RecDFechaLiquidacion"
                                                                VisibleIndex="8">
                                                                <PropertiesTextEdit DisplayFormatString="dd/MM/yyyy"></PropertiesTextEdit>
                                                            </dx:GridViewDataTextColumn>
                                                        </Columns>
                                                        <SettingsBehavior ConfirmDelete="True" />
                                                        <Settings ShowFooter="True" />
                                                        <SettingsText CommandCancel="Cancelar" CommandUpdate="Guardar" ConfirmDelete="Desea Eliminar la Fila Seleccionada ?" />
                                                        <Styles CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue">
                                                        </Styles>
                                                        <Templates>
                                                            <EditForm>
                                                                <table class="with100por">
                                                                    <tr>
                                                                        <td class="lbl_left_td">
                                                                            <cc1:SaimtASPxLabel ID="SaimtASPxLabel1" runat="server" Text="Concepto :">
                                                                            </cc1:SaimtASPxLabel>
                                                                        </td>
                                                                        <td>
                                                                            <cc1:SaimtASPxComboBox ID="cboConceptoDetalle" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                                                CssPostfix="PlasticBlue" DataSourceID="odsConceptos" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                                                                TextField="ConNombre" ValueField="ConIdProcentaje" ValueType="System.String"
                                                                                Width="288px" TextFormatString="{0}">
                                                                                <Columns>
                                                                                    <dx:ListBoxColumn Caption="Concepto" FieldName="ConIdConNombre" Width="450px" />
                                                                                    <dx:ListBoxColumn Caption="Grupo" FieldName="ConGrupo" Width="200px" />
                                                                                </Columns>
                                                                            </cc1:SaimtASPxComboBox>
                                                                        </td>
                                                                        <td class="lbl_left_td">
                                                                            <cc1:SaimtASPxLabel ID="SaimtASPxLabel2" runat="server" Text="Monto Depositado :">
                                                                            </cc1:SaimtASPxLabel>
                                                                        </td>
                                                                        <td>
                                                                            <cc1:SaimtASPxTextBox ID="txtMontoDepositadoDetalle" runat="server" Width="100px">
                                                                            </cc1:SaimtASPxTextBox>
                                                                        </td>
                                                                        <td width="420px" rowspan="3">
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td class="lbl_left_td">
                                                                            <cc1:SaimtASPxLabel ID="SaimtASPxLabel3" runat="server" Text="Fecha de Liquidación :">
                                                                            </cc1:SaimtASPxLabel>
                                                                        </td>
                                                                        <td colspan="3">
                                                                            <cc1:SaimtASPxDateEdit ID="dtpFechaLiquidacion" runat="server" Width="288px">
                                                                            </cc1:SaimtASPxDateEdit>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td colspan="4">
                                                                            <table class="with100por">
                                                                                <tr>
                                                                                    <td class="lbl_left_td">
                                                                                        <dx:ASPxGridViewTemplateReplacement ID="btnGuardar" runat="server" ReplacementType="EditFormUpdateButton" />
                                                                                        &nbsp;
                                                                                    </td>
                                                                                    <td class="lbl_left_td" width="55px">
                                                                                        <dx:ASPxGridViewTemplateReplacement ID="btnCancelar" runat="server" ReplacementType="EditFormCancelButton" />
                                                                                    </td>
                                                                                </tr>
                                                                            </table>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                                <asp:ObjectDataSource ID="odsConceptos" runat="server" OldValuesParameterFormatString="original_{0}"
                                                                    SelectMethod="conceptoListarXAñoXTgGrupo" TypeName="ReglasNegocio.ReglasWebBL">
                                                                    <SelectParameters>
                                                                        <asp:SessionParameter Name="KeyGridRecaudacionWEB" SessionField="KeyGridRecaudacionWEB"
                                                                            Type="String" />
                                                                    </SelectParameters>
                                                                </asp:ObjectDataSource>
                                                            </EditForm>
                                                        </Templates>
                                                    </cc1:SaimtASPxGridView>
                                                </td>
                                            </tr>
                                        </table>
                                    </DetailRow>
                                </Templates>
                            </cc1:SaimtASPxGridView>
                            <asp:ObjectDataSource ID="odsRecaudacionDetalle" runat="server" DeleteMethod="recaudaciondetalleEliminarWEB"
                                InsertMethod="recaudaciondetalleGuardarWEB" OnDeleting="odsRecaudacionDetalle_Deleting"
                                OnInserting="odsRecaudacionDetalle_Inserting" SelectMethod="mostrarDetalleRecaudacionXRecId_XFecPago_XRecaudadora_WEB"
                                TypeName="ReglasNegocio.ReglasWebBL">
                                <InsertParameters>
                                    <asp:Parameter Name="KeyGridRecaudacionWEB" Type="String" />
                                    <asp:Parameter Name="asConcepto" Type="String" />
                                    <asp:Parameter Name="asMonto" Type="Decimal" />
                                    <asp:Parameter Name="adtFechaLiquidacion" Type="String" />
                                </InsertParameters>
                                <SelectParameters>
                                    <asp:SessionParameter Name="KeyGridRecaudacionWEB" SessionField="KeyGridRecaudacionWEB"
                                        Type="String" />
                                </SelectParameters>
                            </asp:ObjectDataSource>
                            <asp:ObjectDataSource ID="odsMostrarRecaudacion" runat="server" OldValuesParameterFormatString="original_{0}"
                                SelectMethod="recaudacionListarXFecPago_XRecaudadora_WEB" TypeName="ReglasNegocio.ReglasWebBL">
                                <SelectParameters>
                                    <asp:ControlParameter ControlID="calFechaMostrarRecaudacion" Name="adFechaPago" PropertyName="SelectedDate"
                                        Type="DateTime" />
                                    <asp:ControlParameter ControlID="rdbCriteriosMostrarRecaudacion" Name="asRecaudadorId"
                                        PropertyName="Value" Type="String" />
                                </SelectParameters>
                            </asp:ObjectDataSource>
                        </div>
                        <br />
                        <div id="div_calendario_opcion_eliminar_mostrar_recaudacion" class="with100por">
                            <div id="div_calendario_mostrar_recaudacion">
                                <cc1:SaimtASPxCalendar ID="calFechaMostrarRecaudacion" runat="server" Columns="4"
                                    CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue"
                                    SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" ClearButtonText="Limpiar"
                                    TodayButtonText="Día Actual" ShowClearButton="False" AutoPostBack="True">
                                </cc1:SaimtASPxCalendar>
                            </div>
                            <div id="div_opcion_eliminar_mostrar_recaudacion">
                                <br />
                                <table class="with100por" border="0">
                                    <tr>
                                        <td width="50%" align="right">
                                            <cc1:SaimtASPxButton ID="btnEliminar" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                CssPostfix="PlasticBlue" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                                ImagePosition="Top" Text="Eliminar" SpriteImageUrl="~/images/ver_detalle32.png"
                                                Width="112px" SaimtToolTip="Eliminar;Eliminar las Recaudaciones Mostrados junto a su Detalle"
                                                ToolTip="&lt;u&gt;&lt;b&gt;Eliminar&lt;/u&gt;&lt;/b&gt;&lt;br /&gt;Eliminar las Recaudaciones Mostrados junto a su Detalle.">
                                                <ClientSideEvents Click="function (s, e) {e.processOnServer = confirm('Desea Eliminar las Recaudaciones?');}">
                                                </ClientSideEvents>
                                                <Image Url="~/images/eliminar32.png">
                                                </Image>
                                            </cc1:SaimtASPxButton>
                                        </td>
                                        <td align="left">
                                            <cc1:SaimtASPxButton ID="btnExportar" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                CssPostfix="PlasticBlue" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                                ImagePosition="Top" Text="Exportar" Width="112px" UseSubmitBehavior="False" SaimtToolTip="Exportar;Exportar Filas a Excel">
                                                <Image Url="~/images/exportar_excel32.png">
                                                </Image>
                                            </cc1:SaimtASPxButton>
                                        </td>
                                    </tr>
                                </table>
                            </div>
                        </div>
                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>
            <dx:TabPage Text="Importar Recaudación">
                <ContentCollection>
                    <dx:ContentControl runat="server" SupportsDisabledAttribute="True">
                        <div id="div_criterios_importar_recaudacion" class="with100por">
                            <table class="with100por">
                                <tr>
                                    <td class="txtCriterios" width="245px">
                                        Selecciona la Entidad Recaudadora :
                                    </td>
                                    <td colspan="2">
                                        <cc1:SaimtASPxRadioButtonList ID="rdbCriteriosImportarRecaudacion" runat="server"
                                            RepeatDirection="Horizontal" CssClass="rdbCriteriosRecaudacion" ItemSpacing="28px"
                                            SelectedIndex="0" AutoPostBack="True">
                                            <Items>
                                                <dx:ListEditItem Text="Caja Trujillo" Value="02" Selected="True" />
                                                <dx:ListEditItem Text="SATT" Value="01" />
                                            </Items>
                                        </cc1:SaimtASPxRadioButtonList>
                                    </td>
                                </tr>
                                <%-- 
                                <tr>
                                    <td>
                                        &nbsp;
                                    </td>
                                    <td width="160px">
                                        <asp:ScriptManager ID="smScriptManager" runat="server">
                                        </asp:ScriptManager>
                                        <asp:UpdatePanel ID="upCaptcha" runat="server" UpdateMode="Conditional">
                                            <ContentTemplate>
                                                <cc1:SaimtASPxBinaryImage ID="imgCaptcha" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                                    CssPostfix="PlasticBlue">
                                                </cc1:SaimtASPxBinaryImage>
                                            </ContentTemplate>
                                            <Triggers>
                                                <asp:AsyncPostBackTrigger ControlID="linkActualizarCaptcha" EventName="Click" />
                                            </Triggers>
                                        </asp:UpdatePanel>
                                    </td>
                                    <td>
                                        <asp:LinkButton ID="linkActualizarCaptcha" runat="server" Font-Bold="True">Actualizar Imagen</asp:LinkButton>
                                    </td>
                                </tr>                                
                                <tr>
                                    <td class="txtCriterios">
                                        Ingrese los caracteres :
                                    </td>
                                    <td colspan="2">
                                        <cc1:SaimtASPxTextBox ID="txtCaptcha" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                            Text="" Width="148px">
                                            <ValidationSettings CausesValidation="True">
                                                <RequiredField ErrorText="Ingrese los Caracteres" IsRequired="True" />
                                                <RequiredField IsRequired="True" ErrorText="Ingrese los Caracteres"></RequiredField>
                                            </ValidationSettings>
                                        </cc1:SaimtASPxTextBox>
                                        <asp:LinkButton ID="linkCaptcha" runat="server" CssClass="linkVerificarCaptcha">Verificar</asp:LinkButton>
                                    </td>
                                </tr>
                                --%>
                            </table>
                        </div>
                        <div class="with100por">
                            <table class="with100por">
                                <tr>
                                    <td width="360px">
                                        <cc1:SaimtASPxUploadControl ID="uploadImportarRecaudacion" runat="server" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css"
                                            CssPostfix="PlasticBlue" ShowProgressPanel="True" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css"
                                            Width="350px" ClientInstanceName="uploadImportarRecaudacion">
                                            <ClientSideEvents TextChanged="function(s, e) { habilitarCargarArchivo(); }"></ClientSideEvents>
                                            <ValidationSettings AllowedFileExtensions=".xls, .xlsx" NotAllowedFileExtensionErrorText="El Archivo Seleccionado no es Excel">
                                            </ValidationSettings>
                                            <BrowseButton Text="Seleccionar Archivo...">
                                            </BrowseButton>
                                        </cc1:SaimtASPxUploadControl>
                                    </td>
                                    <td>
                                        <cc1:SaimtASPxButton ID="btnCargarArchivo" ClientInstanceName="btnCargarArchivo"
                                            runat="server" Text="Cargar Archivo" Width="150px" ClientEnabled="False">
                                        </cc1:SaimtASPxButton>
                                    </td>
                                </tr>
                            </table>
                        </div>
                        <div id="div_grid_importar_recaudacion" class="with100por">
                            <table>
                                <tr>
                                    <td>
                                        <cc1:SaimtASPxLabel ID="lblMsgErrorImportarRecaudacion" runat="server" CssClass="lbl_msg_error"
                                            Visible="False">
                                        </cc1:SaimtASPxLabel>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <cc1:SaimtASPxGridView ID="dgvImportarRecaudacion" runat="server" AutoGenerateColumns="False"
                                            CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue">
                                            <Columns>
                                                <dx:GridViewDataTextColumn Caption="tlc1" FieldName="tlc1" ShowInCustomizationForm="True"
                                                    VisibleIndex="0">
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn Caption="tlc2" FieldName="tlc2" ShowInCustomizationForm="True"
                                                    VisibleIndex="1">
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn Caption="tlc3" FieldName="tlc3" ShowInCustomizationForm="True"
                                                    VisibleIndex="2">
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn Caption="tlc4" FieldName="tlc4" ShowInCustomizationForm="True"
                                                    VisibleIndex="3">
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn Caption="tlc5" FieldName="tlc5" ShowInCustomizationForm="True"
                                                    VisibleIndex="4">
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn Caption="tlc6" FieldName="tlc6" ShowInCustomizationForm="True"
                                                    VisibleIndex="5">
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn Caption="tlc7" FieldName="tlc7" ShowInCustomizationForm="True"
                                                    VisibleIndex="6">
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn Caption="tlc8" FieldName="tlc8" ShowInCustomizationForm="True"
                                                    VisibleIndex="7">
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn Caption="tlc9" FieldName="tlc9" ShowInCustomizationForm="True"
                                                    VisibleIndex="8">
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn Caption="tlc10" FieldName="tlc10" ShowInCustomizationForm="True"
                                                    VisibleIndex="9">
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn Caption="tlc11" FieldName="tlc11" ShowInCustomizationForm="True"
                                                    VisibleIndex="10">
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn Caption="tlc12" FieldName="tlc12" ShowInCustomizationForm="True"
                                                    VisibleIndex="11">
                                                </dx:GridViewDataTextColumn>
                                            </Columns>
                                            <SettingsBehavior AllowSort="False" />
                                            <SettingsBehavior AllowSort="False"></SettingsBehavior>
                                            <Styles CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue">
                                            </Styles>
                                        </cc1:SaimtASPxGridView>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center">
                                        <cc1:SaimtASPxButton ID="btnGuardarImportacionRecaudacion" runat="server" Enabled="False"
                                            ImagePosition="Top" Text="Guardar" Width="112px">
                                            <Image Url="~/images/guardar32.png">
                                            </Image>
                                            <ClientSideEvents Click="function (s, e) {e.processOnServer = confirm('Esta Seguro de Importar los Datos Mostrados?');}">
                                            </ClientSideEvents>
                                        </cc1:SaimtASPxButton>
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>
        </TabPages>
    </cc1:SaimtASPxPageControl>
</asp:Content>
