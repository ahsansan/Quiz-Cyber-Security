Public Class Form1
    ' Struktur data untuk pertanyaan dan jawaban
    Private questions As List(Of Question)
    Private currentQuestionIndex As Integer = 0
    Private correctAnswers As Integer = 0
    Private questionsAnswered As Integer = 0
    Private totalAnswers As Integer = 0

    ' Struktur untuk menyimpan pertanyaan dan jawabannya
    Private Structure Question
        Dim QuestionText As String
        Dim Options As String()
        Dim CorrectAnswer As Integer ' Indeks jawaban yang benar (0, 1, 2, 3)
    End Structure

    Public Structure AnswerReport
        Dim QuestionIndex As Integer
        Dim SelectedAnswer As String
        Dim IsCorrect As Boolean
        Dim CorrectAnswer As String
    End Structure

    Private answerReports As New List(Of AnswerReport)

    ' Menyiapkan array pertanyaan
    Private Sub InitializeQuestions()
        questions = New List(Of Question) From {
            New Question With {
                .QuestionText = "What is phishing?",
                .Options = New String() {"Scamming via email", "Hacking into systems", "Guessing passwords", "Encrypting data"},
                .CorrectAnswer = 0
            },
            New Question With {
                .QuestionText = "Which one is a secure password?",
                .Options = New String() {"12345", "password123", "My$ecureP@ssw0rd", "qwerty"},
                .CorrectAnswer = 2
            },
            New Question With {
                .QuestionText = "What is a firewall?",
                .Options = New String() {"A type of computer virus", "A network security device", "A password manager", "A malware scanner"},
                .CorrectAnswer = 1
            },
            New Question With {
                .QuestionText = "What does two-factor authentication (2FA) provide?",
                .Options = New String() {"Stronger encryption", "An additional layer of security", "A replacement for passwords", "Anonymous browsing"},
                .CorrectAnswer = 1
            },
            New Question With {
                .QuestionText = "Which of the following is an example of malware?",
                .Options = New String() {"Firewall", "Antivirus software", "Trojan horse", "VPN"},
                .CorrectAnswer = 2
            },
            New Question With {
                .QuestionText = "What is the purpose of a VPN?",
                .Options = New String() {"To encrypt internet traffic", "To replace antivirus software", "To improve computer speed", "To hide your IP address"},
                .CorrectAnswer = 3
            },
            New Question With {
                .QuestionText = "What is ransomware?",
                .Options = New String() {"Software that encrypts data for ransom", "A network security device", "A method of phishing", "An encryption algorithm"},
                .CorrectAnswer = 0
            },
            New Question With {
                .QuestionText = "Which of the following helps prevent brute-force attacks?",
                .Options = New String() {"Using strong passwords", "Turning off the firewall", "Opening all ports", "Implementing account lockout policies"},
                .CorrectAnswer = 3
            },
            New Question With {
                .QuestionText = "What is social engineering?",
                .Options = New String() {"Manipulating people to gain confidential information", "Developing secure applications", "Encrypting data for privacy", "Analyzing network traffic"},
                .CorrectAnswer = 0
            },
            New Question With {
                .QuestionText = "What is the main goal of ethical hacking?",
                .Options = New String() {"To steal data", "To improve system security", "To spread malware", "To identify vulnerabilities in systems"},
                .CorrectAnswer = 3
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
            Me.Hide() ' Sembunyikan Form1, jangan ditutup
            ' Kirim data laporan ke MessageBoxForm
            Dim resultMessageBox As New MessageBoxForm($"Quiz Completed! Your Score: {correctAnswers}/{questions.Count}", answerReports)
            resultMessageBox.Owner = Me ' Set parent form ke Form1
            resultMessageBox.ShowDialog()
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
        Dim selectedAnswer As Integer = -1
        Dim selectedAnswerText As String = ""

        ' Tentukan jawaban yang dipilih
        If radioOption1.Checked Then
            selectedAnswer = 0
            selectedAnswerText = radioOption1.Text
        ElseIf radioOption2.Checked Then
            selectedAnswer = 1
            selectedAnswerText = radioOption2.Text
        ElseIf radioOption3.Checked Then
            selectedAnswer = 2
            selectedAnswerText = radioOption3.Text
        ElseIf radioOption4.Checked Then
            selectedAnswer = 3
            selectedAnswerText = radioOption4.Text
        End If

        ' Validasi jika tidak ada jawaban yang dipilih
        If selectedAnswer = -1 Then
            MessageBox.Show("Please select an answer before proceeding.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        ' Cek apakah jawaban benar
        Dim isCorrect As Boolean = selectedAnswer = currentQuestion.CorrectAnswer

        ' Simpan hasil jawaban
        answerReports.Add(New AnswerReport With {
        .QuestionIndex = currentQuestionIndex,
        .SelectedAnswer = selectedAnswerText,
        .IsCorrect = isCorrect,
        .CorrectAnswer = currentQuestion.Options(currentQuestion.CorrectAnswer)
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
        'CheckAnswer()
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
