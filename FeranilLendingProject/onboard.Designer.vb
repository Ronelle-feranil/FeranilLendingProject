<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class onboard
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
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"", "Ronelle", "Feranil", "ronelleadnag", "Birthplace?", "Calapan City", "YES", "YES", "YES", "YES"}, -1)
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(744, 93)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(84, 29)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(744, 58)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(84, 29)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear Fields"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem2})
        Me.ListView1.Location = New System.Drawing.Point(21, 306)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(857, 231)
        Me.ListView1.TabIndex = 8
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(744, 24)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(84, 29)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"", "Male", "Female"})
        Me.ComboBox1.Location = New System.Drawing.Point(419, 29)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(228, 21)
        Me.ComboBox1.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(339, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Gender:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(97, 29)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(211, 20)
        Me.TextBox3.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "First Name:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(97, 107)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(211, 20)
        Me.TextBox2.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Contact Number:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(857, 138)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Borrower Details"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(419, 58)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(228, 21)
        Me.ComboBox2.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(339, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Marital Status:"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(97, 55)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(211, 20)
        Me.TextBox4.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Last Name:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(97, 81)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(211, 20)
        Me.TextBox1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Address:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Controls.Add(Me.TextBox5)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TextBox6)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 226)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(857, 74)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search Criteria"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.ForeColor = System.Drawing.Color.Red
        Me.Panel1.Location = New System.Drawing.Point(324, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(179, 50)
        Me.Panel1.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(54, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(121, 39)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Just fill in search criteria " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and search result will " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "update automatically"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "NOTE:"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(97, 45)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(211, 20)
        Me.TextBox5.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Last Name:"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(97, 19)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(211, 20)
        Me.TextBox6.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "First Name:"
        '
        'onboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FeranilLendingProject.My.Resources.Resources.User_Management__1_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(900, 550)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "onboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "onboard"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents btnSave As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
End Class
