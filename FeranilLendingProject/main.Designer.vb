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
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnOnboarding = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnUsers = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSettings
        '
        Me.btnSettings.BackgroundImage = Global.FeranilLendingProject.My.Resources.Resources.Users__4_
        Me.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSettings.Location = New System.Drawing.Point(21, 374)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(155, 52)
        Me.btnSettings.TabIndex = 3
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'btnOnboarding
        '
        Me.btnOnboarding.BackgroundImage = Global.FeranilLendingProject.My.Resources.Resources.Users__3_
        Me.btnOnboarding.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOnboarding.Location = New System.Drawing.Point(21, 305)
        Me.btnOnboarding.Name = "btnOnboarding"
        Me.btnOnboarding.Size = New System.Drawing.Size(155, 52)
        Me.btnOnboarding.TabIndex = 2
        Me.btnOnboarding.UseVisualStyleBackColor = True
        '
        'btnReports
        '
        Me.btnReports.BackgroundImage = Global.FeranilLendingProject.My.Resources.Resources.Users__2_
        Me.btnReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReports.Location = New System.Drawing.Point(21, 238)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(157, 52)
        Me.btnReports.TabIndex = 1
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'btnUsers
        '
        Me.btnUsers.BackgroundImage = Global.FeranilLendingProject.My.Resources.Resources.Users__1_
        Me.btnUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUsers.Location = New System.Drawing.Point(21, 180)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.Size = New System.Drawing.Size(155, 52)
        Me.btnUsers.TabIndex = 0
        Me.btnUsers.UseVisualStyleBackColor = True
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FeranilLendingProject.My.Resources.Resources.Lending_Management_System
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1264, 729)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.btnOnboarding)
        Me.Controls.Add(Me.btnReports)
        Me.Controls.Add(Me.btnUsers)
        Me.DoubleBuffered = True
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lending Management System"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnUsers As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnOnboarding As Button
    Friend WithEvents btnSettings As Button
End Class
