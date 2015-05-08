Public Class OpenPlex

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles Settings.Click

    End Sub

    Private Sub Hijack_Click(sender As Object, e As EventArgs) Handles Hijack.Click

    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click

    End Sub

    Private Sub WinPlex_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub

    'Minimize on Form Minimize
    Protected Overrides Sub OnResize(ByVal e As System.EventArgs)
        Dim min As Boolean = False

        'if minimized button was pressed
        If Me.WindowState = FormWindowState.Minimized = True Then
            min = True

            'undo minimize
            Me.WindowState = FormWindowState.Normal
        End If

        If min Then
            Me.Hide()
        End If


    End Sub

    'When notify icon was pressed
    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Process.Start("C:\Program Files\PlexConnect-master\PlexConnect.pyw")
    End Sub

    Private Sub lblVersion_Click(sender As Object, e As EventArgs) Handles lblVersion.Click

    End Sub

    Private Sub lblStop_Click(sender As Object, e As EventArgs) Handles lblStop.Click
        For Each P As Process In System.Diagnostics.Process.GetProcessesByName("pythonw")
            P.Kill()
        Next
    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        For Each P As Process In System.Diagnostics.Process.GetProcessesByName("pythonw")
            P.Kill()
        Next
        Process.Start("C:\Program Files\PlexConnect-master\PlexConnect.pyw")
    End Sub

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        Process.Start("C:\Program Files\PlexConnect-master\PlexConnect.py")
    End Sub

    Private Sub btnShutdown_Click(sender As Object, e As EventArgs) Handles btnShutdown.Click
        For Each P As Process In System.Diagnostics.Process.GetProcessesByName("pythonw")
            P.Kill()
        Next
        Me.Close()
    End Sub

    Private Sub ToolStripStatusLabel3_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel3.Click
        Process.Start("http://alturl.com/j8xdb")
    End Sub
End Class
