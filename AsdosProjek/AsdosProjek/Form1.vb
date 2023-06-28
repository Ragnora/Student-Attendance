Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rs As New ADODB.Recordset

        rs = jalankanSQL("select * from logintbl where username = '" & tuser.Text & "'")

        If rs.RecordCount = 0 Then
            MsgBox("Username Salah!", vbCritical + vbOKOnly, "error")
            tuser.Focus()
            Exit Sub
        End If

        rs = jalankanSQL("select * from logintbl where username = '" & tuser.Text & "' AND password = '" & tpassword.Text & "'")

        If rs.RecordCount = 0 Then
            MsgBox("Password Salah!", vbCritical + vbOKOnly, "Error")
            tuser.Focus()
            Exit Sub
        Else
            Form2.Show()
            Me.Hide()
            tuser.Text = ""
            tpassword.Text = ""
            MsgBox("Login Berhasil!", vbInformation + vbOKOnly, "Informasi")
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            tpassword.UseSystemPasswordChar = False
        Else
            CheckBox1.Checked = True
            tpassword.UseSystemPasswordChar = True
        End If
    End Sub
End Class
