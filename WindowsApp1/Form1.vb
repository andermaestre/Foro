Imports System.Data.SqlClient
Public Class Form1
    Dim c As SqlConnection = New SqlConnection("Data Source=SEGUNDO150;Initial Catalog=DaniDB;Integrated Security=True")
    Dim user, pass, user2, pass2, idBaja As SqlParameter
    Dim cons As SqlCommand = New SqlCommand()
    Dim consId As SqlCommand = New SqlCommand()
    Dim dr As SqlDataReader

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        c.Open()

        cons.Connection = c
        cons.CommandText = "SELECT IdMensaje, Fecha, Mensaje FROM Foro.Mensajes LEFT JOIN Foro.Usuarios ON Foro.Mensajes.idusuario = Foro.Usuarios.idusuario WHERE palabrapaso = @pw AND Foro.Usuarios.Idusuario = @us"
        cons.CommandType = CommandType.Text

        user = New SqlParameter()
        user.ParameterName = "@us"
        user.Value = txtUser.Text
        user.Direction = ParameterDirection.Input

        pass = New SqlParameter()
        pass.ParameterName = "@pw"
        pass.Value = txtPass.Text
        pass.Direction = ParameterDirection.Input

        cons.Parameters.Add(user)
        cons.Parameters.Add(pass)

        dr = cons.ExecuteReader()

        If dr.Read() Then
            If Not IsDBNull(dr("idmensaje")) Then

                LlenarLista(dr)

            End If
        Else
            MsgBox("No hay resultados")
        End If
        dr.Close()
        c.Close()
    End Sub

    Private Sub LlenarLista(dr As SqlDataReader)
        Do
            Dim it As ListViewItem = ListView1.Items.Add(dr("IdMensaje"))
            If Not IsDBNull(dr("Fecha")) Then
                it.SubItems.Add(dr("Fecha"))
            Else
                it.SubItems.Add("null")
            End If
            it.SubItems.Add(dr("Mensaje"))
        Loop While dr.Read
    End Sub

    Private Sub AltaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem.Click
        Dim f As New FormAlta
        f.Show()
    End Sub

    Private Sub BajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajaToolStripMenuItem.Click
        c.Open()

        consId.Connection = c
        consId.CommandText = "SELECT @idbaja=idusuario FROM Foro.Usuarios  WHERE palabrapaso = @pw AND Foro.Usuarios.Idusuario = @us "
        consId.CommandType = CommandType.Text

        user2 = New SqlParameter()
        user2.ParameterName = "@us"
        user2.Value = txtUser.Text
        user2.Direction = ParameterDirection.Input

        pass2 = New SqlParameter()
        pass2.ParameterName = "@pw"
        pass2.Value = txtPass.Text
        pass2.Direction = ParameterDirection.Input

        idBaja = New SqlParameter()
        idBaja.ParameterName = "@idbaja"
        idBaja.Direction = ParameterDirection.Output

        consId.Parameters.Add(user2)
        consId.Parameters.Add(pass2)
        consId.Parameters.Add(idBaja)

        consId.ExecuteNonQuery()
        idParaBaja = consId.Parameters("@idbaja").Value
        c.Close()

        Dim f As New FormBaja
        f.Show()

    End Sub


End Class
