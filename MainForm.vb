Imports Civ3Win.WindowManager
Public Class MainForm
    Private Sub Button_Load_Click(sender As Object, e As EventArgs) Handles Button_Load.Click
        If InsertWindow(GameForm.MainPanel.Handle) = True Then
            FitWindowContent()
            GameForm.Show()
        Else
            MsgBox("Error")
        End If
    End Sub
End Class