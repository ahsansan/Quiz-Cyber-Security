Imports System.IO

Public Class MessageBoxForm
    Private answerReports As List(Of Form1.AnswerReport)
    Private questions As List(Of Form1.Question)
    Private currentQuestionIndex As Integer = 0

    ' Konstruktor yang menerima tiga argumen
    Public Sub New(message As String, answerReports As List(Of Form1.AnswerReport), questions As List(Of Form1.Question))
        InitializeComponent()
        lblMessage.Text = message
        Me.answerReports = answerReports
        Me.questions = questions
        DisplayQuestion()
    End Sub

    ' Menampilkan soal dan jawaban
    Private Sub DisplayQuestion()
        ' Ambil pertanyaan dan jawaban
        Dim currentQuestion = questions(currentQuestionIndex)
        lblQuestion.Text = currentQuestion.QuestionText
        explaination.Text = currentQuestion.Explanation
        radioOption1.Text = currentQuestion.Options(0)
        radioOption2.Text = currentQuestion.Options(1)
        radioOption3.Text = currentQuestion.Options(2)
        radioOption4.Text = currentQuestion.Options(3)

        ' Nonaktifkan radio button
        radioOption1.Enabled = False
        radioOption2.Enabled = False
        radioOption3.Enabled = False
        radioOption4.Enabled = False

        ' Warnai jawaban sesuai dengan status benar atau salah
        Dim currentReport = answerReports(currentQuestionIndex)
        Dim selectedAnswer = currentReport.SelectedAnswer
        Dim correctAnswer = currentQuestion.CorrectAnswer

        ' Mengatur warna berdasarkan jawaban yang dipilih dan benar
        Dim radioButtons As RadioButton() = {radioOption1, radioOption2, radioOption3, radioOption4}
        Dim options As String() = currentQuestion.Options

        For i As Integer = 0 To radioButtons.Length - 1
            Dim radioButton = radioButtons(i)
            Dim optionText = options(i)

            If selectedAnswer = optionText Then
                ' Jawaban yang dipilih
                If optionText = correctAnswer Then
                    radioButton.BackColor = Color.FromArgb(&H99, &HFF, &HBB) ' Jawaban benar
                Else
                    radioButton.BackColor = Color.FromArgb(&HFF, &H80, &H80) ' Jawaban salah
                End If
            ElseIf optionText = correctAnswer Then
                ' Jawaban yang benar
                radioButton.BackColor = Color.FromArgb(&H99, &HFF, &HBB)
            Else
                ' Warna default untuk yang tidak dipilih
                radioButton.BackColor = DefaultBackColor
            End If
        Next

        ' Perubahan Page
        currentQ.Text = currentQuestionIndex + 1
        totalQ.Text = questions.Count

        ' Tampilkan gambarnya
        If Not String.IsNullOrEmpty(currentQuestion.Image) Then
            Dim imagePath As String = Path.Combine(Application.StartupPath, currentQuestion.Image)
            If File.Exists(imagePath) Then
                PictureBox1.Image = Image.FromFile(imagePath)
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            Else
                MessageBox.Show($"Image not found: {imagePath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                PictureBox1.Image = Nothing
            End If
        Else
            PictureBox1.Image = Nothing
        End If

        ' Atur status tombol Next dan Previous
        btnPrevious.Enabled = currentQuestionIndex > 0
        btnNext.Enabled = currentQuestionIndex < questions.Count - 1
    End Sub

    ' Tombol Next
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentQuestionIndex < questions.Count - 1 Then
            currentQuestionIndex += 1
            DisplayQuestion()
        End If
    End Sub

    ' Tombol Previous
    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentQuestionIndex > 0 Then
            currentQuestionIndex -= 1
            DisplayQuestion()
        End If
    End Sub

    ' Tombol Re-Test
    Private Sub buttonReTest_Click(sender As Object, e As EventArgs) Handles buttonReTest.Click
        Me.Close()
        ' Reset quiz di Form1
        CType(Me.Owner, Form1).ResetQuiz()
        ' Menampilkan kembali Form1
        CType(Me.Owner, Form1).Show()
    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Dim confirmationResult = MessageBox.Show(
                "Are you sure to close this quiz?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            )

        If confirmationResult = DialogResult.Yes Then
            Me.Close()
            CType(Me.Owner, Form1).Close()
        Else
            Exit Sub
        End If
    End Sub
End Class
