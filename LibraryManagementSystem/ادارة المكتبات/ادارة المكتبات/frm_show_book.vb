Imports System.Data.OleDb
Public Class frm_show_book
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
    Private Sub frm_show_book_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getbook()
    End Sub
End Class