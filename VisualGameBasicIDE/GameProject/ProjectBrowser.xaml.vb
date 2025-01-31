Public Class ProjectBrowser
    Private Sub Tab_New_MouseDown(sender As Object, e As MouseButtonEventArgs)
        CreateButton.Content = "New"
    End Sub

    Private Sub Tab_Exsisting_MouseDown(sender As Object, e As MouseButtonEventArgs)
        CreateButton.Content = "Open"
    End Sub

    Private Sub Tab_Recent_MouseDown(sender As Object, e As MouseButtonEventArgs)
        CreateButton.Content = "Open"
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As RoutedEventArgs)
        Me.Close()
    End Sub
End Class
