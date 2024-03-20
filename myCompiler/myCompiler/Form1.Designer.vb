<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        expressionLabel = New Label()
        resultsLabel = New Label()
        lstResults = New ListBox()
        txtProgram = New TextBox()
        lexicalButton = New Button()
        syntaxButton = New Button()
        SuspendLayout()
        ' 
        ' expressionLabel
        ' 
        expressionLabel.AutoSize = True
        expressionLabel.Location = New Point(92, 75)
        expressionLabel.Name = "expressionLabel"
        expressionLabel.Size = New Size(79, 20)
        expressionLabel.TabIndex = 0
        expressionLabel.Text = "Expression"
        ' 
        ' resultsLabel
        ' 
        resultsLabel.AutoSize = True
        resultsLabel.Location = New Point(92, 164)
        resultsLabel.Name = "resultsLabel"
        resultsLabel.Size = New Size(55, 20)
        resultsLabel.TabIndex = 1
        resultsLabel.Text = "Results"
        ' 
        ' lstResults
        ' 
        lstResults.FormattingEnabled = True
        lstResults.ItemHeight = 20
        lstResults.Location = New Point(209, 123)
        lstResults.Name = "lstResults"
        lstResults.Size = New Size(522, 264)
        lstResults.TabIndex = 2
        ' 
        ' txtProgram
        ' 
        txtProgram.Location = New Point(212, 75)
        txtProgram.Name = "txtProgram"
        txtProgram.Size = New Size(519, 27)
        txtProgram.TabIndex = 3
        ' 
        ' lexicalButton
        ' 
        lexicalButton.Location = New Point(221, 423)
        lexicalButton.Name = "lexicalButton"
        lexicalButton.Size = New Size(164, 29)
        lexicalButton.TabIndex = 4
        lexicalButton.Text = "Lexical Analysis"
        lexicalButton.UseVisualStyleBackColor = True
        ' 
        ' syntaxButton
        ' 
        syntaxButton.Location = New Point(448, 423)
        syntaxButton.Name = "syntaxButton"
        syntaxButton.Size = New Size(164, 29)
        syntaxButton.TabIndex = 5
        syntaxButton.Text = "Syntax Analysis"
        syntaxButton.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1141, 569)
        Controls.Add(syntaxButton)
        Controls.Add(lexicalButton)
        Controls.Add(txtProgram)
        Controls.Add(lstResults)
        Controls.Add(resultsLabel)
        Controls.Add(expressionLabel)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents expressionLabel As Label
    Friend WithEvents resultsLabel As Label
    Friend WithEvents lstResults As ListBox
    Friend WithEvents txtProgram As TextBox
    Friend WithEvents lexicalButton As Button
    Friend WithEvents syntaxButton As Button
End Class
