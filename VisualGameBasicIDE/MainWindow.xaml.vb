Class MainWindow
    Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Dim projectBrowser As New ProjectBrowser
        If projectBrowser.ShowDialog() = False Then
            Application.Current.Shutdown()
        Else

        End If
    End Sub


End Class
