Imports System.IO

Public Class Form1
    ' Struktur data untuk pertanyaan dan jawaban
    Private questions As List(Of Question)
    Private currentQuestionIndex As Integer = 0
    Private correctAnswers As Integer = 0
    Private questionsAnswered As Integer = 0
    Private totalAnswers As Integer = 0

    ' Struktur untuk menyimpan pertanyaan dan jawabannya
    Public Structure Question
        Dim QuestionText As String
        Dim Options As String()
        Dim CorrectAnswer As String
        Dim Explanation As String
        Dim Image As String
    End Structure

    Public Structure AnswerReport
        Dim QuestionIndex As Integer
        Dim SelectedAnswer As String
        Dim IsCorrect As Boolean
        Dim CorrectAnswer As String
    End Structure

    Private answerReports As New List(Of AnswerReport)

    ' Konstanta
    Private Const VALIDATION_ERROR_TITLE As String = "Validation Error"
    Private Const NO_ANSWER_SELECTED_MESSAGE As String = "Please select an answer before proceeding."

    ' Enum Untuk Skor
    Public Enum ScoreType
        Excellent
        Good
        NeedsImprovement
    End Enum

    Private Function GetScoreType(correctAnswers As Integer) As ScoreType
        Select Case correctAnswers
            Case 5
                Return ScoreType.Excellent
            Case 3 To 4
                Return ScoreType.Good
            Case Else
                Return ScoreType.NeedsImprovement
        End Select
    End Function

    ' Menyiapkan array pertanyaan
    Private Sub InitializeQuestions()
        questions = New List(Of Question) From {
            New Question With {
                .QuestionText = "What is phishing?",
                .Options = New String() {"Scamming via email", "Hacking into systems", "Guessing passwords", "Encrypting data"},
                .CorrectAnswer = "Scamming via email", ' Jawaban benar berupa teks
                .Explanation = "Phishing is a type of fraud that involves sending fake emails to steal personal information.",
                .Image = "Images/Volly-ILCS.jpeg"
            },
            New Question With {
                .QuestionText = "Which one is a secure password?",
                .Options = New String() {"12345", "password123", "My$ecureP@ssw0rd", "qwerty"},
                .CorrectAnswer = "My$ecureP@ssw0rd", ' Jawaban benar berupa teks
                .Explanation = "Phishing is a type of fraud that involves sending fake emails to steal personal information.",
                .Image = "Images/schooby.jpg"
            },
            New Question With {
                .QuestionText = "What is a firewall?",
                .Options = New String() {"A type of computer virus", "A network security device", "A password manager", "A malware scanner"},
                .CorrectAnswer = "A network security device", ' Jawaban benar berupa teks
                .Explanation = "Phishing is a type of fraud that involves sending fake emails to steal personal information.",
                .Image = "Images/mario-fucek.jpg"
            }
        }
    End Sub

    ' Fungsi untuk memuat pertanyaan berikutnya
    Private Sub LoadNextQuestion()
        If currentQuestionIndex < questions.Count Then
            ' Ambil pertanyaan dan jawabannya
            Dim currentQuestion = questions(currentQuestionIndex)
            lblQuestion.Text = currentQuestion.QuestionText
            radioOption1.Text = currentQuestion.Options(0)
            radioOption2.Text = currentQuestion.Options(1)
            radioOption3.Text = currentQuestion.Options(2)
            radioOption4.Text = currentQuestion.Options(3)

            ' Menampilkan gambar?
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

            ' Reset pilihan radio button
            radioOption1.Checked = False
            radioOption2.Checked = False
            radioOption3.Checked = False
            radioOption4.Checked = False

            ' Update progress bar
            progressBar.Value = (currentQuestionIndex + 1) * 100 / questions.Count
            currentQ.Text = currentQuestionIndex + 1

            ' Ganti Caption Button
            If currentQuestionIndex = questions.Count - 1 Then
                btnNext.Text = "Check Result"
            Else
                btnNext.Text = "Next"
            End If
            If currentQuestionIndex = 0 Then
                btnPrevious.Enabled = False
            Else
                btnPrevious.Enabled = True
            End If
        Else
            Dim confirmationResult = MessageBox.Show(
                "You are about to complete the quiz. Do you want to proceed to the results?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            )

            If confirmationResult = DialogResult.Yes Then
                Me.Hide() ' Sembunyikan Form1, jangan ditutup
                Dim scoreType As ScoreType = GetScoreType(correctAnswers)
                Dim resultMessage As String = $"Quiz Completed!{Environment.NewLine}" &
                                  $"Your Score: {correctAnswers}/5{Environment.NewLine}" &
                                  $"Score Type: {scoreType.ToString()}"
                ' Kirim data laporan ke MessageBoxForm
                Dim resultMessageBox As New MessageBoxForm(resultMessage, answerReports, questions)
                resultMessageBox.Owner = Me ' Set parent form ke Form1
                resultMessageBox.ShowDialog()
            Else
                ' Jika pengguna memilih No, jangan lanjutkan ke hasil
                Exit Sub
            End If
        End If
    End Sub

    ' Reset Quiz
    Public Sub ResetQuiz()
        currentQuestionIndex = 0

        ' Reset AnswerReport
        answerReports.Clear()

        ' Jika ada pertanyaan, atur ulang tampilan pertanyaan pertama
        If currentQuestionIndex < questions.Count Then
            Dim currentQuestion = questions(currentQuestionIndex)
            lblQuestion.Text = currentQuestion.QuestionText
            radioOption1.Text = currentQuestion.Options(0)
            radioOption2.Text = currentQuestion.Options(1)
            radioOption3.Text = currentQuestion.Options(2)
            radioOption4.Text = currentQuestion.Options(3)

            'Reset Gambar
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

            ' Reset skor dan progres
            correctAnswers = 0
            questionsAnswered = 0
            totalAnswers = 0
            progressBar.Value = (currentQuestionIndex + 1) * 100 / questions.Count

            ' Reset pilihan radio button
            radioOption1.Checked = False
            radioOption2.Checked = False
            radioOption3.Checked = False
            radioOption4.Checked = False
        End If

        ' Ganti Caption Button
        If currentQuestionIndex = questions.Count - 1 Then
            btnNext.Text = "Check Result"
        Else
            btnNext.Text = "Next"
        End If
        If currentQuestionIndex = 0 Then
            btnPrevious.Enabled = False
        Else
            btnPrevious.Enabled = True
        End If

        currentQ.Text = currentQuestionIndex + 1
        totalQ.Text = questions.Count
    End Sub

    ' Cek jawaban dan simpan laporan
    Private Function CheckAnswer() As Boolean
        Dim currentQuestion = questions(currentQuestionIndex)
        Dim selectedAnswerText As String = ""

        ' Tentukan jawaban yang dipilih
        If radioOption1.Checked Then
            selectedAnswerText = radioOption1.Text
        ElseIf radioOption2.Checked Then
            selectedAnswerText = radioOption2.Text
        ElseIf radioOption3.Checked Then
            selectedAnswerText = radioOption3.Text
        ElseIf radioOption4.Checked Then
            selectedAnswerText = radioOption4.Text
        End If

        ' Validasi jika tidak ada jawaban yang dipilih
        If String.IsNullOrEmpty(selectedAnswerText) Then
            MessageBox.Show(NO_ANSWER_SELECTED_MESSAGE, VALIDATION_ERROR_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        ' Cek apakah jawaban benar
        Dim isCorrect As Boolean = selectedAnswerText = currentQuestion.CorrectAnswer

        ' Simpan hasil jawaban
        answerReports.Add(New AnswerReport With {
            .QuestionIndex = currentQuestionIndex,
            .SelectedAnswer = selectedAnswerText,
            .IsCorrect = isCorrect,
            .CorrectAnswer = currentQuestion.CorrectAnswer
        })

        ' Update skor dan progres
        If isCorrect Then
            correctAnswers += 1
        End If
        questionsAnswered += 1
        totalAnswers += 1

        Return True
    End Function

    ' Event handler ketika tombol "Next" diklik
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ' Cek jawaban pengguna
        If Not CheckAnswer() Then
            Return ' Jika jawaban belum dipilih, hentikan proses
        End If

        ' Lanjutkan ke pertanyaan berikutnya
        currentQuestionIndex += 1
        LoadNextQuestion()
    End Sub

    ' Event handler ketika tombol "Previous" diklik
    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentQuestionIndex > 0 Then
            ' Hapus AnswerReport untuk pertanyaan sebelumnya
            answerReports.RemoveAll(Function(report) report.QuestionIndex = currentQuestionIndex - 1)

            ' Kembali ke pertanyaan sebelumnya
            currentQuestionIndex -= 1
            LoadNextQuestion()
        End If
    End Sub

    ' Form load event
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inisialisasi pertanyaan
        InitializeQuestions()
        ResetQuiz()
        LoadNextQuestion()
    End Sub
End Class
