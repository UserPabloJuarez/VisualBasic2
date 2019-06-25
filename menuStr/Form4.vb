Public Class Form4

    Dim StrBufferEntrada As String
    Dim StrBufferSalida As String

    Private Delegate Sub DelegadoAcceso(ByVal AddText As String)

    Private Sub AccesoFormPrincipal(ByVal TextForm As String)
        StrBufferEntrada = TextForm
        '---------------------------------------
        '---------------------------------------
        TxtDatosRecibidos.Text = StrBufferEntrada
        '---------------------------------------
        '---------------------------------------
        Module1.CreaArchivo()
        lblEstatusEnvio.Text = "Peso enviado al Servidor " & vbCrLf & "Código de muestra: " & CodigoMuestra
        DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
        lblMessage2.Text = "EScanear otra muestra o capture el peso para el siguiente Método"
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StrBufferEntrada = ""
        StrBufferSalida = ""
        BtnConectar.Enabled = False
        BtnEnviarDatos.Enabled = False



    End Sub

    Private Sub BtnBuscarPuertos_Click(sender As Object, e As EventArgs) Handles BtnBuscarPuertos.Click
        CboPuertos.Items.Clear()

        For Each PuertoDisponible As String In My.Computer.Ports.SerialPortNames
            CboPuertos.Items.Add(PuertoDisponible)
        Next

        If CboPuertos.Items.Count > 0 Then
            CboPuertos.Text = CboPuertos.Items(0)
            MessageBox.Show("SELECCIONAR EL PUERTO DE TRBAJO")
            BtnConectar.Enabled = True
        Else
            MessageBox.Show("NINGUN PUERTO ENCONTRADO")
            BtnConectar.Enabled = False
            BtnEnviarDatos.Enabled = False
            CboPuertos.Items.Clear()
        End If

    End Sub

    Private Sub BtnConectar_Click(sender As Object, e As EventArgs) Handles BtnConectar.Click
        If BtnConectar.Text = "CONECTAR" Then

            Try

                With SpPuerto
                    .BaudRate = 9600
                    .DataBits = 8
                    .Parity = IO.Ports.Parity.None
                    .StopBits = IO.Ports.StopBits.One
                    .PortName = CboPuertos.Text
                    .Open()
                End With

                BtnConectar.Text = "DESCONECTAR"
                BtnEnviarDatos.Enabled = vbTrue

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)

            End Try
        ElseIf BtnConectar.Text = "DESCONECTAR" Then
            BtnConectar.Text = "CONECTAR"
            BtnEnviarDatos.Enabled = False
            SpPuerto.Close()


        End If
    End Sub

    Private Sub BtnEnviarDatos_Click(sender As Object, e As EventArgs) Handles BtnEnviarDatos.Click
        SpPuerto.DiscardInBuffer()
        StrBufferSalida = TxtEnviarDatos.Text
        SpPuerto.Write(StrBufferSalida)

    End Sub

    Private Sub DATO(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SpPuerto.DataReceived
        StrBufferEntrada = SpPuerto.ReadExisting
        MessageBox.Show(StrBufferEntrada)
        TxtDatosRecibidos.Text = StrBufferEntrada
    End Sub
End Class