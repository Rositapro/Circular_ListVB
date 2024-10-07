Public Class List
    Private head As Node

    Public Sub New()
        head = Nothing
    End Sub

    Public Sub Add(value As Integer)
        Dim newNode As New Node With {.Value = value}

        If head Is Nothing Then
            head = newNode
            head.NextNode = head
        ElseIf value < head.Value Then
            Dim current As Node = head
            While current.NextNode IsNot head
                current = current.NextNode
            End While
            newNode.NextNode = head
            current.NextNode = newNode
            head = newNode
        Else
            Dim current As Node = head
            While current.NextNode IsNot head AndAlso current.NextNode.Value < value
                current = current.NextNode
            End While
            If current.NextNode.Value = value Then
                Return
            End If
            newNode.NextNode = current.NextNode
            current.NextNode = newNode
        End If
    End Sub

    Public Sub Remove(value As Integer)
        If head Is Nothing Then
            MessageBox.Show("The list is empty, no nodes to remove.")
            Return
        End If

        Dim current As Node = head

        If head.Value = value Then
            If head.NextNode Is head Then
                head = Nothing
            Else
                While current.NextNode IsNot head
                    current = current.NextNode
                End While
                head = head.NextNode
                current.NextNode = head
            End If
            MessageBox.Show("Node removed successfully.")
            Return
        End If

        current = head

        While current.NextNode IsNot head
            If current.NextNode.Value = value Then
                current.NextNode = current.NextNode.NextNode
                MessageBox.Show("Node removed successfully.")
                Return
            End If
            current = current.NextNode
        End While

        MessageBox.Show("Node not found.")
    End Sub

    Public Function Contains(value As Integer) As Boolean
        If head Is Nothing Then
            Return False
        End If

        Dim current As Node = head

        Do
            If current.Value = value Then
                Return True
            End If
            current = current.NextNode
        Loop While current IsNot head

        Return False
    End Function

    Public Function Display() As String()
        If head Is Nothing Then
            MessageBox.Show("The list is empty.")
            Return New String() {}
        End If

        Dim result As New List(Of String)
        Dim current As Node = head

        Do
            result.Add(current.Value.ToString())
            current = current.NextNode
        Loop While current IsNot head

        Return result.ToArray()
    End Function

    Public Function Count() As Integer
        If head Is Nothing Then
            Return 0
        End If

        Dim ncount As Integer = 1
        Dim current As Node = head

        While current.NextNode IsNot head
            ncount += 1
            current = current.NextNode
        End While

        Return ncount
    End Function
End Class

