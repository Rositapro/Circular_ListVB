Public Class Node
    ' Propiedad para el valor
    Public Property Value As Integer
    ' Propiedad para la referencia al siguiente nodo
    Public Property NextNode As Node

    ' Constructor por defecto
    Public Sub New()
        Value = 0
        NextNode = Nothing
    End Sub

    ' Constructor con parámetro para establecer el valor
    Public Sub New(value As Integer)
        Me.Value = value
        NextNode = Nothing
    End Sub
End Class
