<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.components = New System.ComponentModel.Container()
        Me.BtnBuscarPuertos = New System.Windows.Forms.Button()
        Me.BtnConectar = New System.Windows.Forms.Button()
        Me.BtnEnviarDatos = New System.Windows.Forms.Button()
        Me.CboPuertos = New System.Windows.Forms.ComboBox()
        Me.LblDatosRecibidos = New System.Windows.Forms.Label()
        Me.TxtEnviarDatos = New System.Windows.Forms.TextBox()
        Me.SpPuerto = New System.IO.Ports.SerialPort(Me.components)
        Me.TxtDatosRecibidos = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnBuscarPuertos
        '
        Me.BtnBuscarPuertos.Location = New System.Drawing.Point(17, 39)
        Me.BtnBuscarPuertos.Name = "BtnBuscarPuertos"
        Me.BtnBuscarPuertos.Size = New System.Drawing.Size(114, 23)
        Me.BtnBuscarPuertos.TabIndex = 0
        Me.BtnBuscarPuertos.Text = "BUSCAR PUERTOS"
        Me.BtnBuscarPuertos.UseVisualStyleBackColor = True
        '
        'BtnConectar
        '
        Me.BtnConectar.Location = New System.Drawing.Point(349, 39)
        Me.BtnConectar.Name = "BtnConectar"
        Me.BtnConectar.Size = New System.Drawing.Size(125, 23)
        Me.BtnConectar.TabIndex = 1
        Me.BtnConectar.Text = "CONECTAR"
        Me.BtnConectar.UseVisualStyleBackColor = True
        '
        'BtnEnviarDatos
        '
        Me.BtnEnviarDatos.Location = New System.Drawing.Point(17, 126)
        Me.BtnEnviarDatos.Name = "BtnEnviarDatos"
        Me.BtnEnviarDatos.Size = New System.Drawing.Size(75, 23)
        Me.BtnEnviarDatos.TabIndex = 2
        Me.BtnEnviarDatos.Text = "ENVIAR DATOS"
        Me.BtnEnviarDatos.UseVisualStyleBackColor = True
        '
        'CboPuertos
        '
        Me.CboPuertos.FormattingEnabled = True
        Me.CboPuertos.Location = New System.Drawing.Point(150, 41)
        Me.CboPuertos.Name = "CboPuertos"
        Me.CboPuertos.Size = New System.Drawing.Size(183, 21)
        Me.CboPuertos.TabIndex = 3
        '
        'LblDatosRecibidos
        '
        Me.LblDatosRecibidos.AutoSize = True
        Me.LblDatosRecibidos.Location = New System.Drawing.Point(14, 203)
        Me.LblDatosRecibidos.Name = "LblDatosRecibidos"
        Me.LblDatosRecibidos.Size = New System.Drawing.Size(105, 13)
        Me.LblDatosRecibidos.TabIndex = 4
        Me.LblDatosRecibidos.Text = "DATOS RECIBIDOS"
        '
        'TxtEnviarDatos
        '
        Me.TxtEnviarDatos.Location = New System.Drawing.Point(150, 126)
        Me.TxtEnviarDatos.Name = "TxtEnviarDatos"
        Me.TxtEnviarDatos.Size = New System.Drawing.Size(324, 20)
        Me.TxtEnviarDatos.TabIndex = 5
        '
        'SpPuerto
        '
        '
        'TxtDatosRecibidos
        '
        Me.TxtDatosRecibidos.Location = New System.Drawing.Point(150, 200)
        Me.TxtDatosRecibidos.Name = "TxtDatosRecibidos"
        Me.TxtDatosRecibidos.Size = New System.Drawing.Size(324, 20)
        Me.TxtDatosRecibidos.TabIndex = 6
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 286)
        Me.Controls.Add(Me.TxtDatosRecibidos)
        Me.Controls.Add(Me.TxtEnviarDatos)
        Me.Controls.Add(Me.LblDatosRecibidos)
        Me.Controls.Add(Me.CboPuertos)
        Me.Controls.Add(Me.BtnEnviarDatos)
        Me.Controls.Add(Me.BtnConectar)
        Me.Controls.Add(Me.BtnBuscarPuertos)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnBuscarPuertos As Button
    Friend WithEvents BtnConectar As Button
    Friend WithEvents BtnEnviarDatos As Button
    Friend WithEvents CboPuertos As ComboBox
    Friend WithEvents LblDatosRecibidos As Label
    Friend WithEvents TxtEnviarDatos As TextBox
    Friend WithEvents SpPuerto As IO.Ports.SerialPort
    Friend WithEvents TxtDatosRecibidos As TextBox
End Class
