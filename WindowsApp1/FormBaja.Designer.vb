<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBaja
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtIdUser = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(208, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "E-Mail"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(208, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Apellido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(208, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "DNI"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Id Usuario"
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(211, 174)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(100, 20)
        Me.txtMail.TabIndex = 17
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(211, 104)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(100, 20)
        Me.txtApellido.TabIndex = 16
        '
        'txtDni
        '
        Me.txtDni.Location = New System.Drawing.Point(211, 37)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(100, 20)
        Me.txtDni.TabIndex = 15
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(24, 174)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(100, 20)
        Me.txtPass.TabIndex = 14
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(24, 104)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 13
        '
        'txtIdUser
        '
        Me.txtIdUser.Location = New System.Drawing.Point(24, 37)
        Me.txtIdUser.Name = "txtIdUser"
        Me.txtIdUser.Size = New System.Drawing.Size(100, 20)
        Me.txtIdUser.TabIndex = 12
        '
        'FormBaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 299)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMail)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtDni)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtIdUser)
        Me.Name = "FormBaja"
        Me.Text = "FormBaja"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMail As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtDni As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtIdUser As TextBox
End Class
