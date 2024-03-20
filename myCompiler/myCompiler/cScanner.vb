Public Class cScanner
    Private currentChar As Char = Form1.txtProgram.Text(0)
    Private currentSpelling As String
    Private currentIndex As Integer = 0
    Private currentKind As Integer

    Private Sub takeIt()
        currentSpelling &= currentChar
        currentIndex += 1
        If currentIndex < Form1.txtProgram.Text.Length Then
            currentChar = Form1.txtProgram.Text(currentIndex)
        Else
            currentChar = ""
        End If
    End Sub
    Public Function scan() As cToken
        While Char.IsWhiteSpace(currentChar)
            takeIt()
        End While
        currentSpelling = ""
        currentKind = scanToken()
        Return New cToken(currentKind, currentSpelling)
    End Function
    Private Function scanToken() As Integer
        Dim state As Integer = 1

        If currentIndex = Form1.txtProgram.Text.Length Then
            Return cToken.EOF
        End If

        If Char.IsLetter(currentChar) Then
            takeIt()
            state = 2
            While Char.IsLetterOrDigit(currentChar)
                takeIt()
            End While
            Select Case currentSpelling
                Case "square", "root"
                    Return cToken.MATH_FUNCTION
                Case Else
                    Return cToken.UNKNOWN
            End Select
        ElseIf Char.IsDigit(currentChar) Then
            takeIt()
            state = 3
            While Char.IsDigit(currentChar)
                takeIt()
            End While
            If currentChar = "." Then
                takeIt()
                state = 4
                While Char.IsDigit(currentChar)
                    takeIt()
                End While
                Return cToken.FLOAT
            Else
                Return cToken.DIGIT
            End If
        ElseIf currentChar = "+" OrElse currentChar = "-" OrElse currentChar = "*" OrElse currentChar = "/" Then
            takeIt()
            Return cToken.OPERA
        ElseIf currentChar = "(" Then
            takeIt()
            Return cToken.OPEN_PAREN
        ElseIf currentChar = ")" Then
            takeIt()
            Return cToken.CLOSE_PAREN
        Else
            takeIt()
            Return cToken.UNKNOWN
        End If

        Select Case state
            Case 2
                Return cToken.UNKNOWN
            Case 3
                Return cToken.DIGIT
            Case 4
                Return cToken.FLOAT
            Case Else
                Return cToken.UNKNOWN
        End Select
    End Function
End Class
