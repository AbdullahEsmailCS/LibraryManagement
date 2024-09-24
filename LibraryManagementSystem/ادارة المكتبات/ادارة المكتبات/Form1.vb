Imports System.Data.OleDb
Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try

            If TextBox1.Text = "" And TextBox2.Text = "" Then
                MsgBox(" الرجاء ادخال البيانات")
            Else
                cmd = New OleDbCommand("select * from tb_users where usr=@user and password=@pw", con)
                cmd.Parameters.Add(New OleDbParameter("@user", OleDbType.LongVarChar)).Value = TextBox1.Text
                cmd.Parameters.Add(New OleDbParameter("@pw", OleDbType.LongVarChar)).Value = TextBox2.Text
                con.Open()
                Dim dr As OleDbDataReader = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    Dim frm As New Form2
                    frm.Show()
                    Me.Hide()
                Else
                    MsgBox("بيانات غير صحيحة")
                End If
                dr.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            con.Close()
        End Try
    End Sub
End Class
