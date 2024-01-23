Imports MySqlConnector
Imports System.IO
Public Class CRUD
    Dim Cadena As String = "Server=localhost;Database=pruebas;Uid=root;Pwd=0123456789;"
    Protected Conectar As New MySqlConnection(Cadena)
    Public EsCon As Boolean
    Public EMess As String

    Sub Conexion()
        EsCon = False
        While EsCon = False
            Try
                Conectar.Open()
                EsCon = True
                Conectar.Close()
            Catch ex As Exception
                EsCon = False
                EMess = ex.Message
                If MessageBox.Show(EMess, "¿Reintentar conexión?", MessageBoxButtons.YesNo) = vbNo Then
                    End
                End If
            End Try
        End While
    End Sub

    Sub Consulta(ByVal Tabla As DataGridView, ByVal SQL As String)
        Dim DA As New MySqlDataAdapter(SQL, Conectar)
        Dim DT As New DataTable
        Try
            DA.Fill(DT)
            Tabla.DataSource = DT
        Catch ex As Exception
            EMess = ex.Message
            MessageBox.Show(EMess)
        End Try
    End Sub

    Function Rellenar(ByVal SQL As String)
        Dim DT As New DataTable
        Try
            Dim DA As New MySqlDataAdapter(SQL, Conectar)
            DA.Fill(DT)
        Catch ex As Exception
            EMess = ex.Message
            MessageBox.Show(EMess)
        End Try
        Return DT
    End Function

    Sub Operaciones(ByVal Tabla As DataGridView, ByVal SQL As String)
        Conectar.Open()
        Try
            Dim CMD As New MySqlCommand(SQL, Conectar)
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            EMess = ex.Message
            MessageBox.Show(EMess)
        End Try
        Conectar.Close()
    End Sub

    Sub SavImg(ByVal SQL As String, ByVal Imagen As PictureBox)
        Dim MS As New MemoryStream
        Imagen.Image.Save(MS, Imagen.Image.RawFormat)
        Dim Imagenes() As Byte = MS.GetBuffer
        Dim CMD As New MySqlCommand(SQL, Conectar)
        CMD.Parameters.AddWithValue("@Imagen", Imagenes)
        Try
            Conectar.Open()
            CMD.ExecuteNonQuery()
            Conectar.Close()
        Catch ex As Exception
            EMess = ex.Message
            MessageBox.Show(EMess)
            Conectar.Close()
        End Try
    End Sub
End Class
