﻿Imports System.Diagnostics
Imports System.Security
Imports System.ComponentModel
Imports System.IO


Public Class Update_Form

    ''' <summary>
    ''' 應用程式
    ''' </summary>
    Dim p() As Process
    Dim bmp As Bitmap
    ''' <summary>
    ''' 資料夾[更新]的路徑
    ''' </summary>
    Dim updateFolder_path As String = "M:\DESIGN\BACK UP\yc_tian\Tool Application\Tool update folder\更新" 'Application.StartupPath
    'Dim updateTool_path As String = "\\Yc-tian\共用文件夾\software\gg\更新" 'Application.StartupPath
    Public Const main_app_name As String = "WindowsApp1"
    Dim chkNewVer As New CheckNewVersion($"{updateFolder_path}\ToolVersion.txt", "CheckNewVersion_WindowsApp1") '建立CheckNewVersion類別
    'Dim chkNewVer As New CheckNewVersion("\\Yc-tian\共用文件夾\software\gg\更新\ToolVersion.txt", "CheckNewVersion_WindowsApp1") '建立CheckNewVersion類別
    ''' <summary>
    ''' 更新資料夾裡的子資料夾名稱
    ''' </summary>
    Dim updateFolder_name As String

    'Dim updateResult_bol As Boolean = True '更新結果2文字 當覆蓋檔案成功時就輸出一行文字

    ''' <summary>
    ''' 更新資料夾裡的檔案數量
    ''' </summary>
    Dim updatefile_count As Integer
    ''' <summary>
    ''' '更新資料夾裡檔案的結果
    ''' </summary>
    Dim updatefile_result As Boolean

    Enum Check_File_Type
        is_folder
        is_not_folder
    End Enum

    Private Sub Update_Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        bmp = New Bitmap(Pokemon_PictureBox.Image)
        Try
            updateResult_Label.Text = ""
            Done_Label.Text = "0%"
        Catch ee As Exception
            Console.WriteLine((ee.Message))
        End Try
    End Sub

    Private Sub Update_Form_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        p = Process.GetProcessesByName($"{main_app_name}")
        If p.Count > 0 Then
            checkState_Label.Text = "失敗-主程式未關閉-請先關閉主程式"
            checkState_Label.ForeColor = Color.Red
        Else
            checkState_Label.Text = "成功-主程式已關閉-"
            checkState_Label.ForeColor = Color.Green
            updating() '更新中
        End If
    End Sub

    Private Function updating()

        Try
            Me.Text = "當前版本:" & chkNewVer.GetToolVersion
            chkNewVer.CheckNewVersion()

            Select Case chkNewVer.GetCheckConsequence '取得更新結果
                Case 0 'nothing
                    Me.Text = "<更新>目前為最新版本:ver." & chkNewVer.GetToolVersion
                    Return updatefile_result = False
                Case 1 '有更新

                    Me.Text = "<更新>目前為舊版本號碼:ver." & chkNewVer.GetToolVersion

                    '自動更新一些檔案
                    'Dim program_Name As String = Path.GetFileName(Process.GetCurrentProcess().MainModule.FileName) '程式(EXE)的名稱

                    Dim result_msgbox As DialogResult
                    result_msgbox = MsgBox("目前為舊版本，是否要開始覆蓋?", vbYesNo, "提醒")

                    If result_msgbox = DialogResult.Yes Then

                        '針對 資料夾內 的[檔案]類型 ----------------------------------------------------
                        For Each select_file In Directory.GetFiles(updateFolder_path)
                            If Copy_file_and_paste(select_file, Check_File_Type.is_not_folder) = True Then
                                updateResult_Label.Text += select_file & "  <覆蓋成功>" & vbCrLf
                            Else
                                updateResult_Label.Text += select_file & "  <覆蓋失敗>" & vbCrLf
                            End If
                        Next
                        '----------------------------------------------------針對 資料夾內 的[檔案]類型 

                        '針對 資料夾內 的[資料夾]類型 ----------------------------------------------------
                        For Each select_file In Directory.GetDirectories(updateFolder_path)
                            For Each file_in_folder In Directory.GetFileSystemEntries(select_file)
                                If Copy_file_and_paste(file_in_folder, Check_File_Type.is_folder) = True Then
                                    updateResult_Label.Text += file_in_folder & "  <覆蓋成功>" & vbCrLf
                                Else
                                    updateResult_Label.Text += file_in_folder & "  <覆蓋失敗>" & vbCrLf
                                End If
                            Next
                        Next
                        '----------------------------------------------------針對 資料夾內 的[資料夾]類型 
                        Done_Msg()
                        Return updatefile_result = True
                    Else
                        MsgBox("本次不更新")
                        Return updatefile_result = False
                    End If


                Case 2 '更新失敗
                    Me.Text = "更新失敗"
                    MsgBox("更新失敗", MsgBoxStyle.Critical)
                    Return updatefile_result = False
            End Select
        Catch

        End Try

    End Function


    Private Function Copy_file_and_paste(myfile As String, pathIsFolder As Check_File_Type) As Boolean
        If pathIsFolder = Check_File_Type.is_folder Then
            Try
                If myfile <> "" Then
                    If Not Directory.Exists(Application.StartupPath & "\" & updateFolder_name) Then
                        Directory.CreateDirectory(Application.StartupPath & "\" & updateFolder_name) '建立新資料夾
                    End If
                    FileCopy(myfile, Application.StartupPath & "\" & updateFolder_name & "\" & Path.GetFileName(myfile))
                    updatefile_count += 1
                    Return True
                End If
            Catch ex As Exception
                Return False
            End Try
        ElseIf pathIsFolder = Check_File_Type.is_not_folder Then
            Try
                FileCopy(myfile, Application.StartupPath & "\" & Path.GetFileName(myfile))
                updatefile_count += 1
                Return True
            Catch ex As Exception
                Return False
            End Try
        End If
    End Function

    Private Sub Done_Msg()
        For i As Double = 1 To updatefile_count
            Done_ProgressBar.Value += (100 / updatefile_count)
            Me.Refresh()
            Done_Label.Text = Done_ProgressBar.Value & "%"
        Next

        If Done_ProgressBar.Value <> 100 Then
            Done_ProgressBar.Value = 100
            Done_Label.Text = Done_ProgressBar.Value & "%"
        End If
    End Sub



    Private Sub Done_Button_Click(sender As Object, e As EventArgs) Handles Done_Button.Click
        If updatefile_result Then
            Process.Start($"{Application.StartupPath}\{main_app_name}.exe")
            'update_p = Process.GetProcessesByName("Update_magicTool")
        End If
        Me.Close()
    End Sub


End Class