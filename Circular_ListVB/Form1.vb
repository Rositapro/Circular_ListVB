Public Class Form1
    Private list As New List()
    Private Sub UpdateListNodes()
        lstNodes.Items.Clear()
        Dim nodes = list.Display()
        For Each node In nodes
            lstNodes.Items.Add(node)
        Next
    End Sub

    Private Sub ibtnAdd_Click(sender As Object, e As EventArgs) Handles ibtnAdd.Click
        Dim value As Integer
        If Integer.TryParse(txtValue.Text, value) Then
            list.Add(value)
            MessageBox.Show("Node added successfully!")
            txtValue.Clear()
            UpdateListNodes()
        Else
            MessageBox.Show("Please enter a valid integer.")
        End If
    End Sub

    Private Sub ibtnRemove_Click(sender As Object, e As EventArgs) Handles ibtnRemove.Click
        Dim value As Integer
        If Integer.TryParse(txtValue.Text, value) Then
            list.Remove(value)
            txtValue.Clear()
            UpdateListNodes()
        Else
            MessageBox.Show("Please enter a valid integer.")
        End If
    End Sub

    Private Sub ibtnContains_Click(sender As Object, e As EventArgs) Handles ibtnContains.Click
        If list.Contains(Integer.Parse(txtValue.Text)) Then
            MessageBox.Show("Value exists in the linked list")
        Else
            MessageBox.Show("Value does not exist in the linked list")
        End If
    End Sub

    Private Sub ibtnCount_Click(sender As Object, e As EventArgs) Handles ibtnCount.Click
        MessageBox.Show("The linked list contains " & list.Count() & " node(s)")
    End Sub
End Class
