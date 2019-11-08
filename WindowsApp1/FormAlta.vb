Imports System.Data.SqlClient

Public Class FormAlta
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim c As SqlConnection = New SqlConnection("Data Source=SEGUNDO150;Initial Catalog=DaniDB;Integrated Security=True")
        Dim cons As SqlCommand = New SqlCommand()
        Dim id, pw, nm, ap, dni, em As SqlParameter


        c.Open()

        cons.Connection = c

        cons.CommandText = "INSERT INTO Foro.Usuarios (idusuario, palabrapaso, Nombre, Apellido, dni, email) VALUES (@id, @pw, @nm, @ap, @dni, @em)"
        cons.CommandType = CommandType.Text

        id = New SqlParameter()
        id.ParameterName = "@id"
        id.Value = txtIdUser.Text
        id.Direction = ParameterDirection.Input

        pw = New SqlParameter()
        pw.ParameterName = "@pw"
        pw.Value = txtIdUser.Text
        pw.Direction = ParameterDirection.Input

        nm = New SqlParameter()
        nm.ParameterName = "@nm"
        nm.Value = txtIdUser.Text
        nm.Direction = ParameterDirection.Input

        ap = New SqlParameter()
        ap.ParameterName = "@ap"
        ap.Value = txtIdUser.Text
        ap.Direction = ParameterDirection.Input

        dni = New SqlParameter()
        dni.ParameterName = "@dni"
        dni.Value = txtIdUser.Text
        dni.Direction = ParameterDirection.Input

        em = New SqlParameter()
        em.ParameterName = "@em"
        em.Value = txtIdUser.Text
        em.Direction = ParameterDirection.Input

        cons.Parameters.Add(id)
        cons.Parameters.Add(pw)
        cons.Parameters.Add(nm)
        cons.Parameters.Add(ap)
        cons.Parameters.Add(dni)
        cons.Parameters.Add(em)

        cons.ExecuteNonQuery()

        c.Close()


    End Sub
End Class