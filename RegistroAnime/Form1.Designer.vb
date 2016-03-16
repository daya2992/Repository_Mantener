<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.cbxVNo = New System.Windows.Forms.CheckBox()
        Me.cbxVSi = New System.Windows.Forms.CheckBox()
        Me.cbxDNo = New System.Windows.Forms.CheckBox()
        Me.cbxDSi = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnExaminar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.grpx = New System.Windows.Forms.GroupBox()
        Me.grxp1 = New System.Windows.Forms.GroupBox()
        Me.dgvGrilla = New System.Windows.Forms.DataGridView()
        Me.btnReporte = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.txtNombre = New RMCCustomControls.TextBorder()
        Me.txtTemporadas = New RMCCustomControls.TextBorder()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpx.SuspendLayout()
        Me.grxp1.SuspendLayout()
        CType(Me.dgvGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(373, 259)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(106, 32)
        Me.btnEliminar.TabIndex = 31
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(266, 259)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(101, 32)
        Me.btnModificar.TabIndex = 30
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(153, 259)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(107, 32)
        Me.btnRegistrar.TabIndex = 29
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'cbxVNo
        '
        Me.cbxVNo.AutoSize = True
        Me.cbxVNo.Location = New System.Drawing.Point(104, 53)
        Me.cbxVNo.Name = "cbxVNo"
        Me.cbxVNo.Size = New System.Drawing.Size(40, 17)
        Me.cbxVNo.TabIndex = 27
        Me.cbxVNo.Text = "No"
        Me.cbxVNo.UseVisualStyleBackColor = True
        '
        'cbxVSi
        '
        Me.cbxVSi.AutoSize = True
        Me.cbxVSi.Location = New System.Drawing.Point(104, 18)
        Me.cbxVSi.Name = "cbxVSi"
        Me.cbxVSi.Size = New System.Drawing.Size(35, 17)
        Me.cbxVSi.TabIndex = 26
        Me.cbxVSi.Text = "Si"
        Me.cbxVSi.UseVisualStyleBackColor = True
        '
        'cbxDNo
        '
        Me.cbxDNo.AutoSize = True
        Me.cbxDNo.Location = New System.Drawing.Point(104, 60)
        Me.cbxDNo.Name = "cbxDNo"
        Me.cbxDNo.Size = New System.Drawing.Size(40, 17)
        Me.cbxDNo.TabIndex = 25
        Me.cbxDNo.Text = "No"
        Me.cbxDNo.UseVisualStyleBackColor = True
        '
        'cbxDSi
        '
        Me.cbxDSi.AutoSize = True
        Me.cbxDSi.BackColor = System.Drawing.Color.Transparent
        Me.cbxDSi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxDSi.ForeColor = System.Drawing.Color.Black
        Me.cbxDSi.Location = New System.Drawing.Point(104, 25)
        Me.cbxDSi.Name = "cbxDSi"
        Me.cbxDSi.Size = New System.Drawing.Size(35, 17)
        Me.cbxDSi.TabIndex = 24
        Me.cbxDSi.Text = "Si"
        Me.cbxDSi.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "TEMPORADAS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "ANIME"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(34, 81)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(50, 13)
        Me.lblCodigo.TabIndex = 16
        Me.lblCodigo.Text = "lblCodigo"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(545, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(273, 189)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'btnExaminar
        '
        Me.btnExaminar.Location = New System.Drawing.Point(579, 259)
        Me.btnExaminar.Name = "btnExaminar"
        Me.btnExaminar.Size = New System.Drawing.Size(215, 29)
        Me.btnExaminar.TabIndex = 33
        Me.btnExaminar.Text = "Examinar"
        Me.btnExaminar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(313, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(227, 20)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "MANTENIMIENTO ANIMES"
        '
        'grpx
        '
        Me.grpx.Controls.Add(Me.cbxDNo)
        Me.grpx.Controls.Add(Me.cbxDSi)
        Me.grpx.Location = New System.Drawing.Point(289, 52)
        Me.grpx.Name = "grpx"
        Me.grpx.Size = New System.Drawing.Size(186, 94)
        Me.grpx.TabIndex = 36
        Me.grpx.TabStop = False
        Me.grpx.Text = "DESCARGADOS"
        '
        'grxp1
        '
        Me.grxp1.Controls.Add(Me.cbxVSi)
        Me.grxp1.Controls.Add(Me.cbxVNo)
        Me.grxp1.Location = New System.Drawing.Point(289, 152)
        Me.grxp1.Name = "grxp1"
        Me.grxp1.Size = New System.Drawing.Size(186, 95)
        Me.grxp1.TabIndex = 37
        Me.grxp1.TabStop = False
        Me.grxp1.Text = "VISTO"
        '
        'dgvGrilla
        '
        Me.dgvGrilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGrilla.Location = New System.Drawing.Point(35, 297)
        Me.dgvGrilla.Name = "dgvGrilla"
        Me.dgvGrilla.Size = New System.Drawing.Size(823, 316)
        Me.dgvGrilla.TabIndex = 28
        '
        'btnReporte
        '
        Me.btnReporte.Location = New System.Drawing.Point(403, 619)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(122, 30)
        Me.btnReporte.TabIndex = 38
        Me.btnReporte.Text = "REPORTE"
        Me.btnReporte.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "CODIGO"
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(37, 259)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(110, 32)
        Me.btnNuevo.TabIndex = 40
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.Transparent
        Me.txtNombre.BorderColor = System.Drawing.Color.Transparent
        Me.txtNombre.Location = New System.Drawing.Point(35, 132)
        Me.txtNombre.Multiline = False
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(137, 22)
        Me.txtNombre.TabIndex = 46
        Me.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtNombre.UseSystemPasswordChar = False
        '
        'txtTemporadas
        '
        Me.txtTemporadas.BackColor = System.Drawing.Color.Transparent
        Me.txtTemporadas.BorderColor = System.Drawing.Color.Transparent
        Me.txtTemporadas.Location = New System.Drawing.Point(37, 205)
        Me.txtTemporadas.Multiline = False
        Me.txtTemporadas.Name = "txtTemporadas"
        Me.txtTemporadas.Size = New System.Drawing.Size(137, 22)
        Me.txtTemporadas.TabIndex = 47
        Me.txtTemporadas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtTemporadas.UseSystemPasswordChar = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(890, 661)
        Me.Controls.Add(Me.txtTemporadas)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnReporte)
        Me.Controls.Add(Me.grxp1)
        Me.Controls.Add(Me.grpx)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnExaminar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.dgvGrilla)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblCodigo)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpx.ResumeLayout(False)
        Me.grpx.PerformLayout()
        Me.grxp1.ResumeLayout(False)
        Me.grxp1.PerformLayout()
        CType(Me.dgvGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents cbxVNo As System.Windows.Forms.CheckBox
    Friend WithEvents cbxVSi As System.Windows.Forms.CheckBox
    Friend WithEvents cbxDNo As System.Windows.Forms.CheckBox
    Friend WithEvents cbxDSi As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnExaminar As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents grpx As System.Windows.Forms.GroupBox
    Friend WithEvents grxp1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvGrilla As System.Windows.Forms.DataGridView
    Friend WithEvents btnReporte As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents txtNombre As RMCCustomControls.TextBorder
    Friend WithEvents txtTemporadas As RMCCustomControls.TextBorder

End Class
