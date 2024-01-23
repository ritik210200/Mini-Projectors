<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Me.PanOpers = New System.Windows.Forms.Panel()
        Me.RaBActEl = New System.Windows.Forms.RadioButton()
        Me.RabGuard = New System.Windows.Forms.RadioButton()
        Me.PanDatos = New System.Windows.Forms.Panel()
        Me.ButSPict = New System.Windows.Forms.Button()
        Me.PBxLogo = New System.Windows.Forms.PictureBox()
        Me.TxBID = New System.Windows.Forms.TextBox()
        Me.ButLimpi = New System.Windows.Forms.Button()
        Me.ButElimi = New System.Windows.Forms.Button()
        Me.ButGuAct = New System.Windows.Forms.Button()
        Me.DTPHora = New System.Windows.Forms.DateTimePicker()
        Me.LabHora = New System.Windows.Forms.Label()
        Me.LabLogo = New System.Windows.Forms.Label()
        Me.ChBInsta = New System.Windows.Forms.CheckBox()
        Me.TxBWSite = New System.Windows.Forms.TextBox()
        Me.LabWSite = New System.Windows.Forms.Label()
        Me.TxBProgr = New System.Windows.Forms.TextBox()
        Me.LabProgr = New System.Windows.Forms.Label()
        Me.DGVDatos = New System.Windows.Forms.DataGridView()
        Me.OFDCarga = New System.Windows.Forms.OpenFileDialog()
        Me.PanOpers.SuspendLayout()
        Me.PanDatos.SuspendLayout()
        CType(Me.PBxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanOpers
        '
        Me.PanOpers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanOpers.Controls.Add(Me.RaBActEl)
        Me.PanOpers.Controls.Add(Me.RabGuard)
        Me.PanOpers.Location = New System.Drawing.Point(12, 12)
        Me.PanOpers.Name = "PanOpers"
        Me.PanOpers.Size = New System.Drawing.Size(200, 40)
        Me.PanOpers.TabIndex = 1
        '
        'RaBActEl
        '
        Me.RaBActEl.AutoSize = True
        Me.RaBActEl.Location = New System.Drawing.Point(79, 10)
        Me.RaBActEl.Name = "RaBActEl"
        Me.RaBActEl.Size = New System.Drawing.Size(112, 17)
        Me.RaBActEl.TabIndex = 1
        Me.RaBActEl.TabStop = True
        Me.RaBActEl.Text = "Actualizar/Eliminar"
        Me.RaBActEl.UseVisualStyleBackColor = True
        '
        'RabGuard
        '
        Me.RabGuard.AutoSize = True
        Me.RabGuard.Location = New System.Drawing.Point(10, 10)
        Me.RabGuard.Name = "RabGuard"
        Me.RabGuard.Size = New System.Drawing.Size(63, 17)
        Me.RabGuard.TabIndex = 0
        Me.RabGuard.TabStop = True
        Me.RabGuard.Text = "Guardar"
        Me.RabGuard.UseVisualStyleBackColor = True
        '
        'PanDatos
        '
        Me.PanDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanDatos.Controls.Add(Me.ButSPict)
        Me.PanDatos.Controls.Add(Me.PBxLogo)
        Me.PanDatos.Controls.Add(Me.TxBID)
        Me.PanDatos.Controls.Add(Me.ButLimpi)
        Me.PanDatos.Controls.Add(Me.ButElimi)
        Me.PanDatos.Controls.Add(Me.ButGuAct)
        Me.PanDatos.Controls.Add(Me.DTPHora)
        Me.PanDatos.Controls.Add(Me.LabHora)
        Me.PanDatos.Controls.Add(Me.LabLogo)
        Me.PanDatos.Controls.Add(Me.ChBInsta)
        Me.PanDatos.Controls.Add(Me.TxBWSite)
        Me.PanDatos.Controls.Add(Me.LabWSite)
        Me.PanDatos.Controls.Add(Me.TxBProgr)
        Me.PanDatos.Controls.Add(Me.LabProgr)
        Me.PanDatos.Location = New System.Drawing.Point(12, 12)
        Me.PanDatos.Name = "PanDatos"
        Me.PanDatos.Size = New System.Drawing.Size(556, 230)
        Me.PanDatos.TabIndex = 0
        '
        'ButSPict
        '
        Me.ButSPict.Location = New System.Drawing.Point(441, 45)
        Me.ButSPict.Name = "ButSPict"
        Me.ButSPict.Size = New System.Drawing.Size(80, 25)
        Me.ButSPict.TabIndex = 17
        Me.ButSPict.Text = "Seleccionar"
        Me.ButSPict.UseVisualStyleBackColor = True
        '
        'PBxLogo
        '
        Me.PBxLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PBxLogo.Location = New System.Drawing.Point(285, 45)
        Me.PBxLogo.Name = "PBxLogo"
        Me.PBxLogo.Size = New System.Drawing.Size(150, 121)
        Me.PBxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBxLogo.TabIndex = 7
        Me.PBxLogo.TabStop = False
        '
        'TxBID
        '
        Me.TxBID.Location = New System.Drawing.Point(313, 94)
        Me.TxBID.Name = "TxBID"
        Me.TxBID.Size = New System.Drawing.Size(100, 20)
        Me.TxBID.TabIndex = 16
        '
        'ButLimpi
        '
        Me.ButLimpi.Location = New System.Drawing.Point(460, 200)
        Me.ButLimpi.Name = "ButLimpi"
        Me.ButLimpi.Size = New System.Drawing.Size(80, 25)
        Me.ButLimpi.TabIndex = 15
        Me.ButLimpi.Text = "Limpiar"
        Me.ButLimpi.UseVisualStyleBackColor = True
        '
        'ButElimi
        '
        Me.ButElimi.Location = New System.Drawing.Point(285, 200)
        Me.ButElimi.Name = "ButElimi"
        Me.ButElimi.Size = New System.Drawing.Size(80, 25)
        Me.ButElimi.TabIndex = 14
        Me.ButElimi.Text = "Eliminar"
        Me.ButElimi.UseVisualStyleBackColor = True
        '
        'ButGuAct
        '
        Me.ButGuAct.Location = New System.Drawing.Point(79, 200)
        Me.ButGuAct.Name = "ButGuAct"
        Me.ButGuAct.Size = New System.Drawing.Size(80, 25)
        Me.ButGuAct.TabIndex = 13
        Me.ButGuAct.UseVisualStyleBackColor = True
        '
        'DTPHora
        '
        Me.DTPHora.CustomFormat = ""
        Me.DTPHora.Location = New System.Drawing.Point(79, 146)
        Me.DTPHora.Name = "DTPHora"
        Me.DTPHora.Size = New System.Drawing.Size(200, 20)
        Me.DTPHora.TabIndex = 11
        Me.DTPHora.Value = New Date(1996, 12, 12, 0, 0, 0, 0)
        '
        'LabHora
        '
        Me.LabHora.AutoSize = True
        Me.LabHora.Location = New System.Drawing.Point(7, 152)
        Me.LabHora.Name = "LabHora"
        Me.LabHora.Size = New System.Drawing.Size(71, 13)
        Me.LabHora.TabIndex = 10
        Me.LabHora.Text = "Fecha y Hora"
        '
        'LabLogo
        '
        Me.LabLogo.AutoSize = True
        Me.LabLogo.Location = New System.Drawing.Point(282, 29)
        Me.LabLogo.Name = "LabLogo"
        Me.LabLogo.Size = New System.Drawing.Size(31, 13)
        Me.LabLogo.TabIndex = 6
        Me.LabLogo.Text = "Logo"
        '
        'ChBInsta
        '
        Me.ChBInsta.AutoSize = True
        Me.ChBInsta.Location = New System.Drawing.Point(79, 97)
        Me.ChBInsta.Name = "ChBInsta"
        Me.ChBInsta.Size = New System.Drawing.Size(69, 17)
        Me.ChBInsta.TabIndex = 5
        Me.ChBInsta.Text = "Instalado"
        Me.ChBInsta.UseVisualStyleBackColor = True
        '
        'TxBWSite
        '
        Me.TxBWSite.Location = New System.Drawing.Point(79, 71)
        Me.TxBWSite.MaxLength = 2000
        Me.TxBWSite.Name = "TxBWSite"
        Me.TxBWSite.Size = New System.Drawing.Size(200, 20)
        Me.TxBWSite.TabIndex = 3
        '
        'LabWSite
        '
        Me.LabWSite.AutoSize = True
        Me.LabWSite.Location = New System.Drawing.Point(7, 74)
        Me.LabWSite.Name = "LabWSite"
        Me.LabWSite.Size = New System.Drawing.Size(48, 13)
        Me.LabWSite.TabIndex = 2
        Me.LabWSite.Text = "WebSite"
        '
        'TxBProgr
        '
        Me.TxBProgr.Location = New System.Drawing.Point(79, 45)
        Me.TxBProgr.MaxLength = 1000
        Me.TxBProgr.Name = "TxBProgr"
        Me.TxBProgr.Size = New System.Drawing.Size(200, 20)
        Me.TxBProgr.TabIndex = 1
        '
        'LabProgr
        '
        Me.LabProgr.AutoSize = True
        Me.LabProgr.Location = New System.Drawing.Point(7, 48)
        Me.LabProgr.Name = "LabProgr"
        Me.LabProgr.Size = New System.Drawing.Size(52, 13)
        Me.LabProgr.TabIndex = 0
        Me.LabProgr.Text = "Programa"
        '
        'DGVDatos
        '
        Me.DGVDatos.AllowUserToAddRows = False
        Me.DGVDatos.AllowUserToDeleteRows = False
        Me.DGVDatos.AllowUserToOrderColumns = True
        Me.DGVDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVDatos.Location = New System.Drawing.Point(12, 248)
        Me.DGVDatos.Name = "DGVDatos"
        Me.DGVDatos.ReadOnly = True
        Me.DGVDatos.Size = New System.Drawing.Size(556, 297)
        Me.DGVDatos.TabIndex = 2
        '
        'OFDCarga
        '
        Me.OFDCarga.FileName = "OpenFileDialog1"
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 557)
        Me.Controls.Add(Me.DGVDatos)
        Me.Controls.Add(Me.PanOpers)
        Me.Controls.Add(Me.PanDatos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        Me.PanOpers.ResumeLayout(False)
        Me.PanOpers.PerformLayout()
        Me.PanDatos.ResumeLayout(False)
        Me.PanDatos.PerformLayout()
        CType(Me.PBxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanOpers As Panel
    Friend WithEvents RaBActEl As RadioButton
    Friend WithEvents RabGuard As RadioButton
    Friend WithEvents PanDatos As Panel
    Friend WithEvents DTPHora As DateTimePicker
    Friend WithEvents LabHora As Label
    Friend WithEvents PBxLogo As PictureBox
    Friend WithEvents LabLogo As Label
    Friend WithEvents ChBInsta As CheckBox
    Friend WithEvents TxBWSite As TextBox
    Friend WithEvents LabWSite As Label
    Friend WithEvents TxBProgr As TextBox
    Friend WithEvents LabProgr As Label
    Friend WithEvents ButLimpi As Button
    Friend WithEvents ButElimi As Button
    Friend WithEvents ButGuAct As Button
    Friend WithEvents DGVDatos As DataGridView
    Friend WithEvents TxBID As TextBox
    Friend WithEvents ButSPict As Button
    Friend WithEvents OFDCarga As OpenFileDialog
End Class
