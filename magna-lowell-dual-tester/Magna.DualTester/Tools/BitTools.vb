Public Class BitTools
    Public Shared Function FlipBit(value As Integer, bittoflip As Byte) As Integer
        Dim x = Math.Pow(2, bittoflip)
        Dim i As UInteger = CUInt(Math.Pow(2, bittoflip))
        If CBool(value And i) Then
            Return CInt(value And Not i)
        Else
            Return CInt(value Or i)
        End If
    End Function

    Public Shared Function GetPowOf2(power As Integer) As Integer
        If power > 31 Or power < 0 Then
            Throw New Exception("power must be less than 31 and less than 0")
        End If
        Return CInt(Math.Pow(2, power))
    End Function

    Public Shared Function CheckBitValue(value As Integer, bit As Byte) As Boolean
        Dim x = CInt(Math.Pow(2, bit))
        Return CBool(value And x)
    End Function

    Public Shared Function SetBitTo(value As Integer, bit As Byte, i As Boolean) As Integer
        If i Then
            Return SetBit(value, bit)
        Else
            Return ClearBit(value, bit)
        End If
    End Function
    Public Shared Function SetBit(value As Integer, bit As Byte) As Integer
        Dim x = CInt(Math.Pow(2, bit))
        Return value Or x
    End Function
    Public Shared Function ClearBit(value As Integer, bit As Byte) As Integer
        Dim x = CInt(Math.Pow(2, bit))
        Return value And (Not x)
    End Function
End Class
