<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.TBStartSta = New System.Windows.Forms.TextBox
        Me.TBEndSta = New System.Windows.Forms.TextBox
        Me.TBEndTime = New System.Windows.Forms.TextBox
        Me.TBStartTime = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.LBCount = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(96, 184)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 33)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "数据处理"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(242, 183)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 34)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "数据写入"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TBStartSta
        '
        Me.TBStartSta.Location = New System.Drawing.Point(84, 31)
        Me.TBStartSta.Name = "TBStartSta"
        Me.TBStartSta.Size = New System.Drawing.Size(100, 21)
        Me.TBStartSta.TabIndex = 2
        '
        'TBEndSta
        '
        Me.TBEndSta.Location = New System.Drawing.Point(275, 31)
        Me.TBEndSta.Name = "TBEndSta"
        Me.TBEndSta.Size = New System.Drawing.Size(100, 21)
        Me.TBEndSta.TabIndex = 3
        '
        'TBEndTime
        '
        Me.TBEndTime.Location = New System.Drawing.Point(275, 83)
        Me.TBEndTime.Name = "TBEndTime"
        Me.TBEndTime.Size = New System.Drawing.Size(100, 21)
        Me.TBEndTime.TabIndex = 4
        Me.TBEndTime.Text = "·"
        '
        'TBStartTime
        '
        Me.TBStartTime.Location = New System.Drawing.Point(84, 83)
        Me.TBStartTime.Name = "TBStartTime"
        Me.TBStartTime.Size = New System.Drawing.Size(100, 21)
        Me.TBStartTime.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 12)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "TBStartSta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 12)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "TBStartTime"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(214, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "TBEndSta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(216, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 12)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "TBEndTime"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 12)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "LBCount"
        '
        'LBCount
        '
        Me.LBCount.Location = New System.Drawing.Point(84, 141)
        Me.LBCount.Name = "LBCount"
        Me.LBCount.Size = New System.Drawing.Size(100, 21)
        Me.LBCount.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 261)
        Me.Controls.Add(Me.LBCount)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBStartTime)
        Me.Controls.Add(Me.TBEndTime)
        Me.Controls.Add(Me.TBEndSta)
        Me.Controls.Add(Me.TBStartSta)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TBStartSta As System.Windows.Forms.TextBox
    Friend WithEvents TBEndSta As System.Windows.Forms.TextBox
    Friend WithEvents TBEndTime As System.Windows.Forms.TextBox
    Friend WithEvents TBStartTime As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LBCount As System.Windows.Forms.TextBox

End Class
