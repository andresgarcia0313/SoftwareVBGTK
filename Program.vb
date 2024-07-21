Imports Gtk

Public Class Program
    Public Shared Sub Main(args As String())
        Application.Init()
        Dim win As New MainWindow()
        win.ShowAll()
        Application.Run()
    End Sub
End Class
