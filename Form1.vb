

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add items to ComboBox1
        TotalCostLabel.Text = ""
        SplashKaraoke.ShowDialog()
        SongsRadioComboBox.Items.Add("Number of Songs ($2.99 per song)")
        SongsRadioComboBox.Items.Add("Hours in Private Karaoke Booth ($8.99 per hour)")
    End Sub

    Private Sub TotalCostButton_Click(sender As Object, e As EventArgs) Handles TotalCostButton.Click
        ' Validate input
        Dim numSongs As Integer
        If Not Integer.TryParse(HoursTextBox.Text, numSongs) Then
            MessageBox.Show("Please enter a valid number of songs.")
            Return
        End If

        ' Calculate cost
        Dim cost As Decimal
        If SongsRadioComboBox.SelectedIndex = 0 Then
            cost = numSongs * 2.99
        ElseIf SongsRadioComboBox.SelectedIndex = 1 Then
            Dim numHours As Integer
            If Not Integer.TryParse(HoursTextBox.Text, numHours) Then
                MessageBox.Show("Please enter a valid number of hours.")
                Return
            End If
            cost = numHours * 8.99
        End If

        ' Display total cost
        TotalCostLabel.Text = "Total Cost: $" & cost.ToString("0.00")
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ' Reset form
        SongsRadioComboBox.SelectedIndex = -1
        HoursTextBox.Clear()
        TotalCostLabel.Text = ""
    End Sub
End Class
