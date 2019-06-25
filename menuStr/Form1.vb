Public Class Form1
    Private Sub Form2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Form2ToolStripMenuItem.Click

        Form2.ShowDialog()

    End Sub

    Private Sub Form3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Form3ToolStripMenuItem.Click

        Form3.ShowDialog()

    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click

        MsgBox("Ha dado clic en nuevo")

    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click

        MsgBox("Ha dado clic en cerrar")

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click

        Me.Close()


    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        conectarse()
        llenaGrid()


        Dim var As String
        var = "Variable sin cambiar"

        porReferencia(var)

        MsgBox(var)

    End Sub

    Private Sub llenaGrid()
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim strSql As String = "SELECT codigo_alum, ape_alum, nom_alum, fec_nac, dni_alum, casado FROM Datos_Básicos"
        Dim adp As New OleDb.OleDbDataAdapter(strSql, conn)

        ds.Tables.Add("tabla")
        adp.Fill(ds.Tables("tabla"))

        Me.DataGridView1.DataSource = ds.Tables("tabla")

        Me.DataGridView1.Columns(0).HeaderText = "IDENTIFICACION"

    End Sub


    Private Sub porValor(ByVal variable As String)
        MsgBox(variable)

        variable = "Variable cambiada"

        MsgBox(variable)
    End Sub

    Private Sub porReferencia(ByRef variable As String)
        MsgBox(variable)

        variable = "Variable cambiada"

        MsgBox(variable)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Soy el botón")
    End Sub

    Private Sub CheckBox1_Click(sender As Object, e As EventArgs) Handles CheckBox1.Click
        MsgBox("Soy el Checkbox")
    End Sub

    Private Sub RadioButton1_Click(sender As Object, e As EventArgs) Handles RadioButton1.Click
        MsgBox("Soy el radioButon")
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        menuStr(e)
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim codigo_alum As String
        codigo_alum = TextBox2.Text
        consultar(codigo_alum)
    End Sub


End Class