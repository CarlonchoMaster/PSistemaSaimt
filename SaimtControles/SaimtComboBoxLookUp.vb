Imports DevExpress.XtraEditors

Public Class SaimtComboBoxLookUp
    Inherits LookUpEdit

    Public Overrides Property EditValue As Object
        Get
            Return IIf(String.IsNullOrEmpty(MyBase.EditValue), Nothing, MyBase.EditValue)
            'Return ""
        End Get
        Set(ByVal value As Object)
            MyBase.EditValue = value
        End Set
    End Property

    Public Sub New()
        Me.Properties.NullText = ""
    End Sub

    Public Enum Entidades
        TablaGeneral
        Ubigeo
        Ninguno
        proPaNroCuota
        abonDetNroCuota
        Concepto
        ConceptoGrupos
        JerCargoDestino
        JerAreaDestino
        JerInstitucionDestino
        TipoDocumentoSTD
        PersonaDestino
        Horarios
        Sucursales
        HorariosAsistencia
        InmCampoActualiza
        InmCampoActualizacion
        ProcedientoSTD
        Partida
        Procesos
        SubProcesos
        Procedientos
    End Enum

    Public Sub mColumnas(ByVal aeEntidad As Entidades)
        Select Case aeEntidad
            Case Entidades.TablaGeneral
                Me.Properties.Columns.Clear()
                Me.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TgNombre", "Nombre")})
                Exit Select
            Case Entidades.ProcedientoSTD
                Me.Properties.Columns.Clear()
                Me.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProcNombre", "Nombre")})
                Exit Select
            Case Entidades.Ubigeo
                Me.Properties.Columns.Clear()
                Me.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UbgNombre", "Nombre")})
                Exit Select
            Case Entidades.proPaNroCuota
                Me.Properties.Columns.Clear()
                Me.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProPaNroCuota", "Nro Cuota")})
                Exit Select
            Case Entidades.abonDetNroCuota
                Me.Properties.Columns.Clear()
                Me.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AbonDetNroCuota", "Nro Cuota")})
                Exit Select
            Case Entidades.Concepto
                Me.Properties.Columns.Clear()
                Me.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ConIdConNombre", "Concepto")})
                Exit Select
            Case Entidades.ConceptoGrupos
                Me.Properties.Columns.Clear()
                Me.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ConIdConNombre", "Concepto"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ConGrupo", "Grupo")})
                Exit Select

            Case Entidades.JerCargoDestino
                Me.Properties.Columns.Clear()
                Me.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CargoDestino", "Nombre Cargo")})
                Exit Select

            Case Entidades.JerAreaDestino
                Me.Properties.Columns.Clear()
                Me.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AreaDestino", "Nombre Area")})
                Exit Select

            Case Entidades.JerInstitucionDestino
                Me.Properties.Columns.Clear()
                Me.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TipoDocumento", "Nombre Institucion")})
                Exit Select
            Case Entidades.TipoDocumentoSTD
                Me.Properties.Columns.Clear()
                Me.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TgNombre", "Documento")})
                Exit Select

            Case Entidades.PersonaDestino
                Me.Properties.Columns.Clear()
                Me.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PerNombreCompleto", "Destinos")})
                Exit Select

            Case Entidades.Horarios
                Me.Properties.Columns.Clear()
                Me.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("HorDescripcion", "Horario")})
                Exit Select

            Case Entidades.Sucursales
                Me.Properties.Columns.Clear()
                Me.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Sucursal", "Sucursal")})
                Exit Select

            Case Entidades.HorariosAsistencia
                Me.Properties.Columns.Clear()
                Me.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre")})
                Exit Select
            Case Entidades.InmCampoActualiza
                Me.Properties.Columns.Clear()
                Me.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("InmUpdDetCampoText", "Nombre")})
                Exit Select
            Case Entidades.InmCampoActualizacion
                Me.Properties.Columns.Clear()
                Me.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("_InmUpdDetValorNew", "Nombre")})
                Exit Select
            Case Entidades.Partida
                Me.Properties.Columns.Clear()
                Me.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PartDato", "Nombre")})
                Exit Select
            Case Entidades.Procesos
                Me.Properties.Columns.Clear()
                Me.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProcNombre", "Proceso")})
                Exit Select
            Case Entidades.SubProcesos
                Me.Properties.Columns.Clear()
                Me.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubProcNombre", "SubProceso")})
                Exit Select
            Case Entidades.Procedientos
                Me.Properties.Columns.Clear()
                Me.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProcdNombre", "Procedimientos")})
                Exit Select
        End Select
    End Sub
End Class
