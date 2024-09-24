<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ملفToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.اغلاقToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.الكتبToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.اضافةكتابToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ادارةالكتبToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ملفToolStripMenuItem, Me.الكتبToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(990, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ملفToolStripMenuItem
        '
        Me.ملفToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.اغلاقToolStripMenuItem})
        Me.ملفToolStripMenuItem.Name = "ملفToolStripMenuItem"
        Me.ملفToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.ملفToolStripMenuItem.Text = "ملف"
        '
        'اغلاقToolStripMenuItem
        '
        Me.اغلاقToolStripMenuItem.Name = "اغلاقToolStripMenuItem"
        Me.اغلاقToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.اغلاقToolStripMenuItem.Text = "اغلاق"
        '
        'الكتبToolStripMenuItem
        '
        Me.الكتبToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.اضافةكتابToolStripMenuItem, Me.ادارةالكتبToolStripMenuItem})
        Me.الكتبToolStripMenuItem.Name = "الكتبToolStripMenuItem"
        Me.الكتبToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.الكتبToolStripMenuItem.Text = "الكتب"
        '
        'اضافةكتابToolStripMenuItem
        '
        Me.اضافةكتابToolStripMenuItem.Name = "اضافةكتابToolStripMenuItem"
        Me.اضافةكتابToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.اضافةكتابToolStripMenuItem.Text = "اضافة كتاب"
        '
        'ادارةالكتبToolStripMenuItem
        '
        Me.ادارةالكتبToolStripMenuItem.Name = "ادارةالكتبToolStripMenuItem"
        Me.ادارةالكتبToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ادارةالكتبToolStripMenuItem.Text = "ادارة الكتب"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "Form2"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "Form2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ملفToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents اغلاقToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents الكتبToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents اضافةكتابToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ادارةالكتبToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
