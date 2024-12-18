Public Class MessageBoxForm
    Private answerReports As List(Of Form1.AnswerReport) ' Gunakan Form1.AnswerReport

    Public Sub New(message As String, answerReports As List(Of Form1.AnswerReport))
        InitializeComponent()
        lblMessage.Text = message
        Me.answerReports = answerReports
        DisplayResults()
    End Sub

    Private Sub DisplayResults()
        Dim resultText As String = ""

        For Each report As Form1.AnswerReport In answerReports
            resultText &= $"Question {report.QuestionIndex + 1}: {report.SelectedAnswer} - "
            If report.IsCorrect Then
                resultText &= "Correct"
            Else
                resultText &= $"Incorrect (Correct answer: {report.CorrectAnswer})"
            End If
            resultText &= vbCrLf
        Next

        Label1.Text = resultText
    End Sub

    ' Tampilkan form di tengah-tengah parent form
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)

        ' Menyelaraskan form dengan parent form
        Dim parentForm As Form = Me.Owner
        Me.StartPosition = FormStartPosition.CenterParent
        Me.Top = parentForm.Top + (parentForm.Height - Me.Height) / 2
        Me.Left = parentForm.Left + (parentForm.Width - Me.Width) / 2
    End Sub

    Private Sub buttonReTest_Click(sender As Object, e As EventArgs) Handles buttonReTest.Click
        Me.Close()
        ' Reset quiz di Form1
        CType(Me.Owner, Form1).ResetQuiz()
        ' Menampilkan kembali Form1
        CType(Me.Owner, Form1).Show()
    End Sub
End Class
