<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Update_Form
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Update_Form))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.checkState_Label = New System.Windows.Forms.Label()
        Me.Done_ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.Done_Button = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.updateResult_Label = New System.Windows.Forms.Label()
        Me.Done_Label = New System.Windows.Forms.Label()
        Me.updateResult_TextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "檢查狀態:"
        '
        'checkState_Label
        '
        Me.checkState_Label.AutoSize = True
        Me.checkState_Label.Location = New System.Drawing.Point(77, 24)
        Me.checkState_Label.Name = "checkState_Label"
        Me.checkState_Label.Size = New System.Drawing.Size(29, 12)
        Me.checkState_Label.TabIndex = 1
        Me.checkState_Label.Text = "失敗"
        '
        'Done_ProgressBar
        '
        Me.Done_ProgressBar.Location = New System.Drawing.Point(31, 171)
        Me.Done_ProgressBar.Name = "Done_ProgressBar"
        Me.Done_ProgressBar.Size = New System.Drawing.Size(364, 23)
        Me.Done_ProgressBar.TabIndex = 2
        '
        'Done_Button
        '
        Me.Done_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Done_Button.Location = New System.Drawing.Point(339, 200)
        Me.Done_Button.Name = "Done_Button"
        Me.Done_Button.Size = New System.Drawing.Size(56, 27)
        Me.Done_Button.TabIndex = 4
        Me.Done_Button.Text = "DONE"
        Me.Done_Button.UseVisualStyleBackColor = True
        '
        'updateResult_Label
        '
        Me.updateResult_Label.AutoSize = True
        Me.updateResult_Label.Location = New System.Drawing.Point(6, 57)
        Me.updateResult_Label.Name = "updateResult_Label"
        Me.updateResult_Label.Size = New System.Drawing.Size(65, 12)
        Me.updateResult_Label.TabIndex = 6
        Me.updateResult_Label.Text = "結果輸出處"
        Me.updateResult_Label.Visible = False
        '
        'Done_Label
        '
        Me.Done_Label.AutoSize = True
        Me.Done_Label.Location = New System.Drawing.Point(29, 156)
        Me.Done_Label.Name = "Done_Label"
        Me.Done_Label.Size = New System.Drawing.Size(29, 12)
        Me.Done_Label.TabIndex = 8
        Me.Done_Label.Text = "失敗"
        '
        'updateResult_TextBox
        '
        Me.updateResult_TextBox.Location = New System.Drawing.Point(74, 47)
        Me.updateResult_TextBox.Multiline = True
        Me.updateResult_TextBox.Name = "updateResult_TextBox"
        Me.updateResult_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.updateResult_TextBox.Size = New System.Drawing.Size(321, 99)
        Me.updateResult_TextBox.TabIndex = 9
        '
        'Update_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(407, 233)
        Me.ControlBox = False
        Me.Controls.Add(Me.updateResult_TextBox)
        Me.Controls.Add(Me.updateResult_Label)
        Me.Controls.Add(Me.Done_Label)
        Me.Controls.Add(Me.Done_Button)
        Me.Controls.Add(Me.Done_ProgressBar)
        Me.Controls.Add(Me.checkState_Label)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Update_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "更新"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents checkState_Label As Label
    Friend WithEvents Done_ProgressBar As ProgressBar
    Friend WithEvents Done_Button As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents updateResult_Label As Label
    Friend WithEvents Done_Label As Label
    Friend WithEvents updateResult_TextBox As TextBox
End Class
