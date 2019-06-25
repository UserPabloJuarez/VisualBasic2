Module funcionesdb
    Public conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=semana1_Datos.accdb;Persist Security Info=False")
    Public cmd As New OleDb.OleDbCommand
    Public dr As OleDb.OleDbDataReader

    Public Sub conectarse()

        Try
            conn.Open()
            MsgBox("Conexion exitosa")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub consultar(ByRef identificacion As String)
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        If identificacion <> "" Then
            cmd.CommandText = "SELECT ape_alum, nom_alum, fec_nac, dni_alum, casado FROM Datos_Básicos WHERE codigo_alum =" + identificacion
        Else
            cmd.CommandText = "SELECT ape_alum, nom_alum, fec_nac, dni_alum, casado FROM Datos_Básicos"

        End If

        Try

            dr = cmd.ExecuteReader()

            If dr.HasRows Then
                While dr.Read()
                    MsgBox(dr(0).ToString + " " + dr(1).ToString + " " + dr(2).ToString + " " + dr(3).ToString + " " + dr(4).ToString)
                End While
            Else
                MsgBox("No existe registros para la consulta")
            End If

            dr.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

End Module
