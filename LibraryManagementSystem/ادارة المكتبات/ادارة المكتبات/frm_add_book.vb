Imports System.Data.OleDb
Public Class frm_add_book
    Dim dt As New DataTable
    Sub getbook()
        adapter = New OleDbDataAdapter("select * from tb_book", con)
        adapter.Fill(dt)
        Me.DataGridView1.DataSource = dt
        dt.Constraints.Add("prim", dt.Columns("id"), True)
        Me.DataGridView1.Columns(0).HeaderText = "الرقم"
        Me.DataGridView1.Columns(1).HeaderText = "اسم الكتاب"
        Me.DataGridView1.Columns(2).HeaderText = "المؤلف"
        Me.DataGridView1.Columns(3).HeaderText = "رقم المؤلف"
        Me.DataGridView1.Columns(4).HeaderText = "دار النشر"
        Me.DataGridView1.Columns(5).HeaderText = "التصنيف"
        Me.DataGridView1.Columns(6).HeaderText = "تاريخ النشر"
        Me.DataGridView1.Columns(7).HeaderText = "عدد الصفحات"
        Me.DataGridView1.Columns(8).HeaderText = "السعر"


    End Sub
    Sub clear()
        txt_num_of_page.Clear()
        txt_publisher_number.Clear()
        txtcategory.ResetText()
        txtdar.Clear()
        txtdate_publish.ResetText()
        txtid.Clear()
        txtname.Clear()
        txtprice.Clear()
        txtpublisher.Clear()
        txtid.Enabled = True
    End Sub
    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub frm_add_book_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getbook()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Try
            Dim row As DataRow = dt.NewRow
            row(0) = Val(txtid.Text)
            row(1) = txtname.Text
            row(2) = txtpublisher.Text
            row(3) = Val(txt_publisher_number.Text)
            row(4) = txtdar.Text
            row(5) = txtcategory.Text
            row(6) = txtdate_publish.Text
            row(7) = txt_num_of_page.Text
            row(8) = txtprice.Text
            dt.Rows.Add(row)
            cmdb = New OleDbCommandBuilder(adapter)
            adapter.Update(dt)
            dt.AcceptChanges()
            MsgBox("تمت الاضافة بنجاح")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


       
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        clear()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim row As DataRow = dt.Rows.Find(Val(txtid.Text))
        If row IsNot Nothing Then
            row.Delete()
            cmdb = New OleDbCommandBuilder(adapter)
            adapter.Update(dt)
            dt.AcceptChanges()
            MsgBox("تمت عملية الحذف بنجاح")

        Else
            MsgBox("الرقم المبحوث عنه غير موجود")
        End If
    End Sub

    Private Sub txtid_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtid.Validated
        Dim row As DataRow = dt.Rows.Find(Val(txtid.Text))
        If row IsNot Nothing Then
            txtid.Text = row(0)
            txtid.Enabled = False
            txtname.Text = row(1)
            txtpublisher.Text = row(2)
            txt_publisher_number.Text = row(3)
            txtdar.Text = row(4)
            txtcategory.Text = row(5)
            txtdate_publish.Text = row(6)
            txt_num_of_page.Text = row(7)
            txtprice.Text = row(8)
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim mo As Integer = Val(txtid.Text)


        Try
            Dim row As DataRow = dt.Rows.Find(mo)

            row(1) = txtname.Text
            row(2) = txtpublisher.Text
            row(3) = Val(txt_publisher_number.Text)
            row(4) = txtdar.Text
            row(5) = txtcategory.Text
            row(6) = txtdate_publish.Text
            row(7) = txt_num_of_page.Text
            row(8) = txtprice.Text

            cmdb = New OleDbCommandBuilder(adapter)
            adapter.Update(dt)
            dt.AcceptChanges()
            MsgBox("تمت عملية التعديل بنجاح")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class