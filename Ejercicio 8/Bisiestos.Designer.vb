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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDia = New System.Windows.Forms.TextBox()
        Me.txtMes = New System.Windows.Forms.TextBox()
        Me.txtAño = New System.Windows.Forms.TextBox()
        Me.cmdValidar = New System.Windows.Forms.Button()
        Me.LblResultado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 57)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese día, mes y año de una fecha para determinar si se trata de una fecha vali" &
    "da o no."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Día"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Mes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Año"
        '
        'txtDia
        '
        Me.txtDia.Location = New System.Drawing.Point(65, 136)
        Me.txtDia.Name = "txtDia"
        Me.txtDia.Size = New System.Drawing.Size(100, 20)
        Me.txtDia.TabIndex = 4
        '
        'txtMes
        '
        Me.txtMes.Location = New System.Drawing.Point(65, 165)
        Me.txtMes.Name = "txtMes"
        Me.txtMes.Size = New System.Drawing.Size(100, 20)
        Me.txtMes.TabIndex = 5
        '
        'txtAño
        '
        Me.txtAño.Location = New System.Drawing.Point(65, 200)
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(100, 20)
        Me.txtAño.TabIndex = 6
        '
        'cmdValidar
        '
        Me.cmdValidar.Location = New System.Drawing.Point(171, 198)
        Me.cmdValidar.Name = "cmdValidar"
        Me.cmdValidar.Size = New System.Drawing.Size(89, 23)
        Me.cmdValidar.TabIndex = 7
        Me.cmdValidar.Text = "Validar"
        Me.cmdValidar.UseVisualStyleBackColor = True
        '
        'LblResultado
        '
        Me.LblResultado.AutoSize = True
        Me.LblResultado.Location = New System.Drawing.Point(15, 266)
        Me.LblResultado.Name = "LblResultado"
        Me.LblResultado.Size = New System.Drawing.Size(118, 13)
        Me.LblResultado.TabIndex = 9
        Me.LblResultado.Text = "Resultado:  _________"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(272, 345)
        Me.Controls.Add(Me.LblResultado)
        Me.Controls.Add(Me.cmdValidar)
        Me.Controls.Add(Me.txtAño)
        Me.Controls.Add(Me.txtMes)
        Me.Controls.Add(Me.txtDia)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDia As TextBox
    Friend WithEvents txtMes As TextBox
    Friend WithEvents txtAño As TextBox
    Friend WithEvents cmdValidar As Button
    Friend WithEvents LblResultado As Label
End Class
