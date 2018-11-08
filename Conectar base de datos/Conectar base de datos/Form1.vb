Imports MySql.Data.MySqlClient


Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim MySqlCon As New MySqlConnection("datasource=localhost;port=3306;username=root;password='';database=sindelen_proy;SslMode=none")
        Try

            MySqlCon.Open()
            MsgBox("Conexion Realizada")
            MySqlCon.Close()
        Catch ex As Exception
            MsgBox("Conexion Faliida")
            MySqlCon.Close()

        End Try

    End Sub
End Class
