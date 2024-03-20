Public Class cToken
    Public kind As Integer
    Public spelling As String = ""
    Public Sub New(ByVal kind As Integer, ByVal spelling As String)
        Me.kind = kind
        Me.spelling = spelling
    End Sub
    Public Shared UNKNOWN As Integer = 0
    Public Shared EOF As Integer = 1
    Public Shared DIGIT As Integer = 2
    Public Shared OPERA As Integer = 3
    Public Shared OPEN_PAREN As Integer = 4
    Public Shared CLOSE_PAREN As Integer = 5
    Public Shared MATH_FUNCTION As Integer = 6
    Public Shared FLOAT As Integer = 7
    Public Overrides Function ToString() As String
        Dim tokenType As String
        Select Case kind
            Case cToken.UNKNOWN
                tokenType = "UNKNOWN"
            Case cToken.EOF
                tokenType = "EOF"
            Case cToken.DIGIT
                tokenType = "DIGIT"
            Case cToken.OPERA
                tokenType = "OPERATOR"
            Case cToken.OPEN_PAREN
                tokenType = "OPEN_PAREN"
            Case cToken.CLOSE_PAREN
                tokenType = "CLOSE_PAREN"
            Case cToken.MATH_FUNCTION
                tokenType = "MATH_FUNCTION"
            Case cToken.FLOAT
                tokenType = "FLOAT"
            Case Else
                tokenType = "UNKNOWN"
        End Select

        Return $"Token Type: {tokenType}, Spelling: {spelling}"
    End Function
End Class
