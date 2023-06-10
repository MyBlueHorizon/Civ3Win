Public Class WindowManager
    Declare Auto Function SetParent Lib "user32" (ByVal hWndChild As IntPtr, ByVal hWndNewParent As IntPtr) As IntPtr
    Declare Auto Function FindWindow Lib "user32" (ByVal lpClassName As String, ByVal lpWindowName As String) As IntPtr
    Public Shared OriginWindow As IntPtr
    Public Shared Function InsertWindow(AppHandles)
        Try
            OriginWindow = FindWindow("JackalClass", "Sid Meier's Civilization III: Complete")
            SetParent(OriginWindow, AppHandles)
            Return True
        Catch ex As ArgumentException
            Return False
        End Try
    End Function
    Public Shared Function FitWindowContent()
        Try
            GameForm.Text = "Sid Meier's Civilization III: Complete"
            GameForm.MainPanel.Size = New Size(1024, 768)
            Return True
        Catch ex As ArgumentException
            Return False
        End Try
    End Function
End Class
