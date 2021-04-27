Public Class frmWebView
    Private Sub frmWebView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtURL.Text = "https://www.google.co.th"
    End Sub

    Private Sub txtURL_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtURL.KeyPress
        '// Press ENTER
        If Asc(e.KeyChar) = 13 Then
            '// No beep
            e.Handled = True
            Try
                '// Or --> WebView21.CoreWebView2.Navigate(txtURL.Text)
                WebView21.Source = New Uri(txtURL.Text)
            Catch ex As UriFormatException
                MessageBox.Show("The URL must be fully styled, such as the prefix. http[s]://")
            Catch ex As Exception
                MessageBox.Show("Error: {ex}")
            End Try
        End If
    End Sub
End Class
