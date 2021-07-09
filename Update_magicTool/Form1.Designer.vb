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
        Me.Pokemon_PictureBox = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.updateResult_Label = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Done_Label = New System.Windows.Forms.Label()
        CType(Me.Pokemon_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "檢查狀態:"
        '
        'checkState_Label
        '
        Me.checkState_Label.AutoSize = True
        Me.checkState_Label.Location = New System.Drawing.Point(88, 24)
        Me.checkState_Label.Name = "checkState_Label"
        Me.checkState_Label.Size = New System.Drawing.Size(29, 12)
        Me.checkState_Label.TabIndex = 1
        Me.checkState_Label.Text = "失敗"
        '
        'Done_ProgressBar
        '
        Me.Done_ProgressBar.Location = New System.Drawing.Point(29, 171)
        Me.Done_ProgressBar.Name = "Done_ProgressBar"
        Me.Done_ProgressBar.Size = New System.Drawing.Size(350, 23)
        Me.Done_ProgressBar.TabIndex = 2
        '
        'Done_Button
        '
        Me.Done_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Done_Button.Location = New System.Drawing.Point(320, 200)
        Me.Done_Button.Name = "Done_Button"
        Me.Done_Button.Size = New System.Drawing.Size(56, 27)
        Me.Done_Button.TabIndex = 4
        Me.Done_Button.Text = "DONE"
        Me.Done_Button.UseVisualStyleBackColor = True
        '
        'Pokemon_PictureBox
        '
        Me.Pokemon_PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Pokemon_PictureBox.Image = CType(resources.GetObject("Pokemon_PictureBox.Image"), System.Drawing.Image)
        Me.Pokemon_PictureBox.InitialImage = Nothing
        Me.Pokemon_PictureBox.Location = New System.Drawing.Point(29, 78)
        Me.Pokemon_PictureBox.Name = "Pokemon_PictureBox"
        Me.Pokemon_PictureBox.Size = New System.Drawing.Size(55, 46)
        Me.Pokemon_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pokemon_PictureBox.TabIndex = 5
        Me.Pokemon_PictureBox.TabStop = False
        Me.Pokemon_PictureBox.Visible = False
        '
        'Timer1
        '
        '
        'updateResult_Label
        '
        Me.updateResult_Label.AutoSize = True
        Me.updateResult_Label.Location = New System.Drawing.Point(3, 0)
        Me.updateResult_Label.Name = "updateResult_Label"
        Me.updateResult_Label.Size = New System.Drawing.Size(65, 12)
        Me.updateResult_Label.TabIndex = 6
        Me.updateResult_Label.Text = "結果輸出處"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.updateResult_Label)
        Me.Panel1.Location = New System.Drawing.Point(89, 39)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(287, 85)
        Me.Panel1.TabIndex = 7
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
        'Update_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 233)
        Me.ControlBox = False
        Me.Controls.Add(Me.Done_Label)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Pokemon_PictureBox)
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
        CType(Me.Pokemon_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents checkState_Label As Label
    Friend WithEvents Done_ProgressBar As ProgressBar
    Friend WithEvents Done_Button As Button
    Friend WithEvents Pokemon_PictureBox As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents updateResult_Label As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Done_Label As Label
End Class
