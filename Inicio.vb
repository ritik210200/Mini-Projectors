Imports System.IO
Public Class Inicio
    Dim CDB As New CRUD
    Dim DataHour As String
    'Consultas SQL
    Dim SQL As String
    'Public vID As Integer = 0

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CDB.Conexion()
        FormProp()
        PSELECT()
    End Sub

    Sub FormProp()
        Text = My.Application.Info.Title & " | Inicio"
        BackColor = SystemColors.ActiveCaption
        RabGuard.Checked = True
        TxBID.Enabled = False
        'DTPHora.Format = DateTimePickerFormat.Custom
        DTPHora.CustomFormat = "yyyy/MM/dd" & " " & DateTimePickerFormat.Time
    End Sub

    Sub PSELECT()
        SQL = "SELECT * FROM Programas"
        CDB.Consulta(DGVDatos, SQL)
        CellZ()
    End Sub

    Sub CellE()
        If DGVDatos.RowCount() > 0 Then
            Try
                TxBID.Text = DGVDatos.CurrentRow.Cells(0).Value
                TxBProgr.Text = DGVDatos.CurrentRow.Cells(1).Value
                TxBWSite.Text = DGVDatos.CurrentRow.Cells(2).Value
                ChBInsta.Checked = DGVDatos.CurrentRow.Cells(3).Value
                DTPHora.Text = DGVDatos.CurrentRow.Cells(4).Value
                PBxLogo.Image = DGVDatos.CurrentRow.Cells(5).FormattedValue
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            Limpiar()
        End If
    End Sub

    Sub CellZ()
        If CDB.EsCon = True Then
            Try
                DGVDatos.Columns(0).Width = 50
                DGVDatos.Columns(0).HeaderText = "ID"
                DGVDatos.Columns(1).Width = 150
                DGVDatos.Columns(1).HeaderText = "Programa"
                DGVDatos.Columns(2).Width = 300
                DGVDatos.Columns(2).HeaderText = "WebSite"
                DGVDatos.Columns(3).Width = 60
                DGVDatos.Columns(3).HeaderText = "Instalado"
                DGVDatos.Columns(4).Width = 200
                DGVDatos.Columns(4).HeaderText = "Fecha y Hora"
                DGVDatos.Columns(5).Width = 200
                DGVDatos.Columns(5).HeaderText = "Logo"
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ButGuAct_Click(sender As Object, e As EventArgs) Handles ButGuAct.Click
        If TxBProgr.Text = "" Then
            TxBProgr.Focus()
        Else
            If JO <> True Then
                If MessageBox.Show("No ha seleccionado una imagen... ¿Desea escoger una?", "Falta agregar imagen", MessageBoxButtons.OKCancel) = vbOK Then
                    ButSPict_Click(sender, e)
                Else
                    TxBProgr.Focus()
                End If
            Else
                Select Case ButGuAct.Text
                    Case "Guardar"
                        PINSERT()
                    Case "Actualizar"
                        PUPDATE()
                    Case ""
                        MessageBox.Show("Error inesperado. La operación no es posible actualemnte", "Ooopppsss...!!!")
                        TxBProgr.Focus()
                End Select
                CDB.SavImg(SQL, PBxLogo)
                ButLimpi_Click(sender, e)
            End If
        End If
    End Sub

    Sub PINSERT()
        DataHour = Year(DTPHora.Value) & "/" & Month(DTPHora.Value) & "/" & DateAndTime.Day(DTPHora.Value) & " " & Hour(DTPHora.Value) & ":" & Minute(DTPHora.Value) & ":" & Second(DTPHora.Value)
        SQL = "INSERT INTO Programas (Programa, WebSite, Instalado, Fecha_Hora, Imagen) VALUES ('" & TxBProgr.Text & "', '" & TxBWSite.Text & "', " & ChBInsta.CheckState & ", '" & DataHour & "', @Imagen)"
    End Sub

    Sub PUPDATE()
        If TxBID.Text = "" Then
            MessageBox.Show("Operación no válida")
            TxBProgr.Focus()
        Else
            DataHour = Year(DTPHora.Value) & "/" & Month(DTPHora.Value) & "/" & DateAndTime.Day(DTPHora.Value) & " " & Hour(DTPHora.Value) & ":" & Minute(DTPHora.Value) & ":" & Second(DTPHora.Value)
            SQL = "UPDATE Programas SET Programa='" & TxBProgr.Text & "', WebSite='" & TxBWSite.Text & "', Instalado=" & ChBInsta.CheckState & ", Fecha_Hora='" & DataHour & "', Imagen=@Imagen WHERE (ID=" & TxBID.Text & ")"
        End If
    End Sub

    Private Sub ButElimi_Click(sender As Object, e As EventArgs) Handles ButElimi.Click
        If TxBID.Text = "" Then
            MessageBox.Show("Operación no válida")
            TxBProgr.Focus()
        Else
            PDELETE()
            ButLimpi_Click(sender, e)
        End If
    End Sub

    Sub PDELETE()
        SQL = "DELETE FROM Programas WHERE (ID=" & TxBID.Text & ")"
        CDB.SavImg(SQL, PBxLogo)
        'CDB.Operaciones(DGVDatos, SQL)
    End Sub

    Private Sub ButLimpi_Click(sender As Object, e As EventArgs) Handles ButLimpi.Click
        Limpiar()
        PSELECT()
        TxBProgr.Focus()
    End Sub

    Sub Limpiar()
        TxBID.Clear()
        TxBProgr.Clear()
        TxBWSite.Clear()
        ChBInsta.Checked = False
        PBxLogo.Image = Nothing
        JO = False
        DTPHora.Text = Today & " " & TimeOfDay
        'DTPHora.ResetText()
    End Sub

    Private Sub DGVDatos_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DGVDatos.CellEnter
        If RaBActEl.Checked = True Then
            CellE()
        End If
    End Sub

    Private Sub RabGuard_CheckedChanged(sender As Object, e As EventArgs) Handles RabGuard.CheckedChanged
        Limpiar()
        ButGuAct.Text = "Guardar"
        ButElimi.Visible = False
        TxBProgr.Focus()
    End Sub

    Private Sub RaBActEl_CheckedChanged(sender As Object, e As EventArgs) Handles RaBActEl.CheckedChanged
        Limpiar()
        ButGuAct.Text = "Actualizar"
        ButElimi.Visible = True
        CellE()
    End Sub

    Dim JO As Boolean
    Private Sub ButSPict_Click(sender As Object, e As EventArgs) Handles ButSPict.Click
        Dim OpenFile As New OpenFileDialog
        OpenFile.Filter = "Imagenes JPG|*.jpg|Imagenes JPEG|*.jpeg|Imagenes PNG|*.png"
        OpenFile.Title = "Seleccionar imagen"
        OpenFile.FilterIndex = 1
        OpenFile.RestoreDirectory = True
        If OpenFile.ShowDialog() = DialogResult.OK Then
            PBxLogo.Image = Image.FromFile(OpenFile.FileName)
            JO = True
        End If
    End Sub
End Class
