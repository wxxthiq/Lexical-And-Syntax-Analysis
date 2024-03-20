Public Class Form1

    Dim nextToken As cToken
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles expressionLabel.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles resultsLabel.Click

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstResults.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtProgram.TextChanged

    End Sub

    Private Sub lexicalButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lexicalButton.Click
        Dim scanner As cScanner = New cScanner
        Dim currentToken As cToken

        lstResults.Items.Clear()
        Try
            currentToken = scanner.scan
            While currentToken.kind <> cToken.EOF
                lstResults.Items.Add(currentToken.ToString)
                currentToken = scanner.scan
            End While
        Catch ex As Exception
            lstResults.Items.Add("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub syntaxButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles syntaxButton.Click
        lstResults.Items.Clear()
        syntaxError = False
        scanner = New cScanner
        nextToken = scanner.scan
        parse_program()

        If syntaxError Then
            lstResults.Items.Add("Syntax Error!")
        Else
            lstResults.Items.Add("Syntax Correct!")
        End If

    End Sub


    Private Sub parse_program()
        parse_expression()
        If nextToken.kind <> cToken.EOF Then
            syntaxError = True
        End If
    End Sub

    Private Sub parse_expression()
        parse_term()
        parse_expression_prime()
    End Sub

    Private Sub parse_expression_prime()
        Select Case nextToken.kind
            Case cToken.OPERA
                acceptToken(cToken.OPERA)
                parse_term()
                parse_expression_prime()
            Case Else
                ' Epsilon production is here
        End Select
    End Sub



    Private Sub parse_math_function()
        Select Case nextToken.spelling
            Case "square"
                acceptToken(cToken.MATH_FUNCTION)
                acceptToken(cToken.OPEN_PAREN)
                parse_number()
                acceptToken(cToken.CLOSE_PAREN)
            Case "root"
                acceptToken(cToken.MATH_FUNCTION)
                acceptToken(cToken.OPEN_PAREN)
                parse_number()
                acceptToken(cToken.CLOSE_PAREN)
            Case Else
                syntaxError = True
        End Select
    End Sub

    Private Sub parse_number()
        If nextToken.kind = cToken.DIGIT OrElse nextToken.kind = cToken.FLOAT Then
            acceptToken(nextToken.kind)
        Else
            syntaxError = True
        End If
    End Sub

    Private Sub parse_term()
        Select Case nextToken.kind
            Case cToken.DIGIT, cToken.FLOAT
                parse_number()
            Case cToken.OPEN_PAREN
                acceptToken(cToken.OPEN_PAREN)
                parse_expression()
                acceptToken(cToken.CLOSE_PAREN)
            Case cToken.MATH_FUNCTION
                parse_math_function()
            Case Else
                syntaxError = True
        End Select
    End Sub

    Private Sub acceptToken(ByVal k As Integer)
        If nextToken.kind = k Then
            lstResults.Items.Add(nextToken.ToString)
            nextToken = scanner.scan
        Else
            syntaxError = True
        End If
    End Sub

End Class
