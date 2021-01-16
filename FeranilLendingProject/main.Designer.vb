<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnOnboarding = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnUsers = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLoan = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblTotalCollection = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEnterCode = New System.Windows.Forms.Button()
        Me.lblTimeAndDate = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSettings
        '
        Me.btnSettings.BackgroundImage = Global.FeranilLendingProject.My.Resources.Resources.Users__4_
        Me.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSettings.Location = New System.Drawing.Point(16, 248)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(155, 52)
        Me.btnSettings.TabIndex = 5
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'btnOnboarding
        '
        Me.btnOnboarding.BackgroundImage = Global.FeranilLendingProject.My.Resources.Resources.Users__3_
        Me.btnOnboarding.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOnboarding.Location = New System.Drawing.Point(14, 16)
        Me.btnOnboarding.Name = "btnOnboarding"
        Me.btnOnboarding.Size = New System.Drawing.Size(155, 52)
        Me.btnOnboarding.TabIndex = 4
        Me.btnOnboarding.UseVisualStyleBackColor = True
        '
        'btnReports
        '
        Me.btnReports.BackgroundImage = Global.FeranilLendingProject.My.Resources.Resources.Users__2_
        Me.btnReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReports.Location = New System.Drawing.Point(14, 190)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(157, 52)
        Me.btnReports.TabIndex = 3
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'btnUsers
        '
        Me.btnUsers.BackgroundImage = Global.FeranilLendingProject.My.Resources.Resources.Users__1_
        Me.btnUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUsers.Location = New System.Drawing.Point(14, 132)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.Size = New System.Drawing.Size(155, 52)
        Me.btnUsers.TabIndex = 2
        Me.btnUsers.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnLoan)
        Me.Panel1.Controls.Add(Me.btnReports)
        Me.Panel1.Controls.Add(Me.btnSettings)
        Me.Panel1.Controls.Add(Me.btnUsers)
        Me.Panel1.Controls.Add(Me.btnOnboarding)
        Me.Panel1.Location = New System.Drawing.Point(21, 169)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(180, 548)
        Me.Panel1.TabIndex = 4
        '
        'btnLoan
        '
        Me.btnLoan.BackgroundImage = Global.FeranilLendingProject.My.Resources.Resources.Users__6_
        Me.btnLoan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLoan.Location = New System.Drawing.Point(14, 74)
        Me.btnLoan.Name = "btnLoan"
        Me.btnLoan.Size = New System.Drawing.Size(155, 52)
        Me.btnLoan.TabIndex = 6
        Me.btnLoan.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(207, 294)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1032, 423)
        Me.DataGridView1.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblTotalCollection)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.btnEnterCode)
        Me.Panel2.Controls.Add(Me.lblTimeAndDate)
        Me.Panel2.Location = New System.Drawing.Point(207, 169)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1032, 119)
        Me.Panel2.TabIndex = 7
        '
        'lblTotalCollection
        '
        Me.lblTotalCollection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalCollection.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCollection.ForeColor = System.Drawing.Color.Red
        Me.lblTotalCollection.Location = New System.Drawing.Point(161, 16)
        Me.lblTotalCollection.Name = "lblTotalCollection"
        Me.lblTotalCollection.Size = New System.Drawing.Size(172, 37)
        Me.lblTotalCollection.TabIndex = 2
        Me.lblTotalCollection.Text = "12,350.00"
        Me.lblTotalCollection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Total Collection: "
        '
        'btnEnterCode
        '
        Me.btnEnterCode.BackgroundImage = Global.FeranilLendingProject.My.Resources.Resources.Users__5_
        Me.btnEnterCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEnterCode.Location = New System.Drawing.Point(167, 56)
        Me.btnEnterCode.Name = "btnEnterCode"
        Me.btnEnterCode.Size = New System.Drawing.Size(155, 52)
        Me.btnEnterCode.TabIndex = 1
        Me.btnEnterCode.UseVisualStyleBackColor = True
        '
        'lblTimeAndDate
        '
        Me.lblTimeAndDate.AutoSize = True
        Me.lblTimeAndDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeAndDate.Location = New System.Drawing.Point(843, 7)
        Me.lblTimeAndDate.Name = "lblTimeAndDate"
        Me.lblTimeAndDate.Size = New System.Drawing.Size(182, 20)
        Me.lblTimeAndDate.TabIndex = 0
        Me.lblTimeAndDate.Text = "yyyy-MM-dd hh:mm:ss"
        '
        'Timer1
        '
        '
        'main
        '
        Me.AcceptButton = Me.btnEnterCode
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FeranilLendingProject.My.Resources.Resources.Lending_Management_System
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1264, 729)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.DoubleBuffered = True
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lending Management System"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnUsers As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnOnboarding As Button
    Friend WithEvents btnSettings As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnEnterCode As Button
    Friend WithEvents lblTimeAndDate As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblTotalCollection As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLoan As Button
End Class
