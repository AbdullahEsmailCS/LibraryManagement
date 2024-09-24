Imports System.Data.OleDb
Module Module1
    Public con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ABDULLAH ISMAIL\Documents\Visual Studio 2010\Projects\ادارة المكتبات\ادارة المكتبات\bin\Debug\db\db_books.accdb")
    Public cmd As OleDbCommand
    Public adapter As OleDbDataAdapter
    Public cmdb As OleDbCommandBuilder
    Public ds As New DataSet

End Module
