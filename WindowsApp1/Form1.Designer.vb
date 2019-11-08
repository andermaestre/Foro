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
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MensajeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.IdMensaje = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Fecha = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Mensaje = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(22, 56)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(100, 20)
        Me.txtUser.TabIndex = 0
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(22, 112)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(100, 20)
        Me.txtPass.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "User"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Pass"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(180, 86)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Iniciar Sesion"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(180, 480)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Misterioso Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosToolStripMenuItem, Me.MensajeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(458, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaToolStripMenuItem, Me.BajaToolStripMenuItem})
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'AltaToolStripMenuItem
        '
        Me.AltaToolStripMenuItem.Name = "AltaToolStripMenuItem"
        Me.AltaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AltaToolStripMenuItem.Text = "Alta"
        '
        'MensajeToolStripMenuItem
        '
        Me.MensajeToolStripMenuItem.Name = "MensajeToolStripMenuItem"
        Me.MensajeToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.MensajeToolStripMenuItem.Text = "Mensaje"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.IdMensaje, Me.Fecha, Me.Mensaje})
        Me.ListView1.Location = New System.Drawing.Point(22, 148)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(412, 309)
        Me.ListView1.TabIndex = 8
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'IdMensaje
        '
        Me.IdMensaje.Text = "IdMensaje"
        Me.IdMensaje.Width = 64
        '
        'Fecha
        '
        Me.Fecha.Text = "Fecha"
        '
        'Mensaje
        '
        Me.Mensaje.Text = "Mensaje"
        Me.Mensaje.Width = 280
        '
        'BajaToolStripMenuItem
        '
        Me.BajaToolStripMenuItem.Name = "BajaToolStripMenuItem"
        Me.BajaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BajaToolStripMenuItem.Text = "Baja"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 528)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MensajeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListView1 As ListView
    Friend WithEvents IdMensaje As ColumnHeader
    Friend WithEvents Fecha As ColumnHeader
    Friend WithEvents Mensaje As ColumnHeader
    Friend WithEvents AltaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BajaToolStripMenuItem As ToolStripMenuItem
End Class
