Public Class Tuple
    Public A As Integer
    Public B As Integer
    Public C As Integer
    Public D As Integer
    Public neighbor() As Tuple
    Public Sub New(ByVal _a As Integer, ByVal _b As Integer)
        A = _a
        B = _b
    End Sub
    Public Sub LinkNeighbor(ByRef neighborT As Tuple, ByVal index As Integer)
        neighbor(index) = neighborT
    End Sub
    Public Sub SetD(ByVal _d As Integer)
        D = _d
    End Sub
End Class