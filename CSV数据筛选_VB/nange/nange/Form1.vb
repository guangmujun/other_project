Imports System.IO
Imports System.Text

Public Class Form1


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim myfile As New FileStream("F:\\20160411.csv", FileMode.Open)

        Dim osta As String = TBStartSta.Text
        Dim dsta As String = TBEndSta.Text
        Dim stime As String = TBStartTime.Text
        Dim etime As String = TBEndTime.Text
        Dim count As Integer = 0

        Dim mystreamr As New StreamReader(myfile, Encoding.Default)
        While mystreamr.EndOfStream = False
            Dim value As String = mystreamr.ReadLine()
            Dim cvalue() As String = value.Split(",")
            If cvalue(2) = osta And cvalue(6) = dsta And cvalue(3) >= stime And cvalue(3) <= etime Then
                count += 1
            End If

        End While
        LBCount.Text = count
        mystreamr.Close()
        myfile.Close()

        MsgBox("第1阶段处理完成！")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim myfile As New FileStream("F:\\20160411.csv", FileMode.Open)
        Dim wfile As New FileStream("F:\\newfile.csv", FileMode.Create)
        Dim osta As String = TBStartSta.Text
        Dim dsta As String = TBEndSta.Text
        Dim stime As String = TBStartTime.Text
        Dim etime As String = TBEndTime.Text
        Dim mystreamr As New StreamReader(myfile, Encoding.Default)
        Dim wstream As New StreamWriter(wfile, Encoding.Default)

        While mystreamr.EndOfStream = False
            Dim value As String = mystreamr.ReadLine()
            Dim cvalue() As String = value.Split(",")

            If cvalue(2) = osta And cvalue(6) = dsta And cvalue(3) >= stime And cvalue(3) <= etime Then

                wstream.WriteLine(value)
            End If
        End While

        mystreamr.Close()
        myfile.Close()
        wstream.Close()
        wfile.Close()

        MsgBox("第2阶段处理完成！")

    End Sub



End Class
