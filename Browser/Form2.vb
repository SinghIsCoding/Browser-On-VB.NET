Imports MySql.Data.MySqlClient

Public Class Form2

    Dim connection As New MySqlConnection("server=localhost;userid=root;password=proggobird;database=browser")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim COMMAND As New MySqlCommand("Insert INTO `user`(`first_name`,`last_name`,`email_id`,`country`,`province`,`DOB`,`password`,`username`) VALUES (@fln,@adds,@brd,@kk,@rks,@bts,@ll,@ks)", connection)

        COMMAND.Parameters.Add("@fln", MySqlDbType.VarChar).Value = TextBox1.Text
        COMMAND.Parameters.Add("@adds", MySqlDbType.VarChar).Value = TextBox2.Text
        COMMAND.Parameters.Add("@brd", MySqlDbType.VarChar).Value = TextBox3.Text
        COMMAND.Parameters.Add("@kk", MySqlDbType.VarChar).Value = TextBox4.Text
        COMMAND.Parameters.Add("@rks", MySqlDbType.VarChar).Value = TextBox5.Text
        COMMAND.Parameters.Add("@bts", MySqlDbType.Date).Value = DateTimePicker1.Value
        COMMAND.Parameters.Add("@ll", MySqlDbType.VarChar).Value = TextBox7.Text
        COMMAND.Parameters.Add("@ks", MySqlDbType.VarChar).Value = TextBox8.Text

        connection.Open()


        If COMMAND.ExecuteNonQuery() = 1 Then

            MessageBox.Show("Data Inserted")
        Else
            MessageBox.Show("ERROR")

        End If
        connection.Close()



    End Sub
End Class