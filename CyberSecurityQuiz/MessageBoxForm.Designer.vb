<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MessageBoxForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MessageBoxForm))
        lblMessage = New Label()
        buttonReTest = New Button()
        radioOption1 = New RadioButton()
        radioOption2 = New RadioButton()
        radioOption3 = New RadioButton()
        radioOption4 = New RadioButton()
        groupBoxOptions = New GroupBox()
        totalQ = New Label()
        lblOf = New Label()
        currentQ = New Label()
        btnPrevious = New Button()
        btnNext = New Button()
        lblQuestion = New Label()
        gExplaination = New GroupBox()
        explaination = New Label()
        exitBtn = New Button()
        PictureBox1 = New PictureBox()
        groupBoxOptions.SuspendLayout()
        gExplaination.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblMessage
        ' 
        lblMessage.AutoSize = True
        lblMessage.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold)
        lblMessage.Location = New Point(45, 20)
        lblMessage.Name = "lblMessage"
        lblMessage.Size = New Size(0, 26)
        lblMessage.TabIndex = 0
        ' 
        ' buttonReTest
        ' 
        buttonReTest.Location = New Point(189, 922)
        buttonReTest.Name = "buttonReTest"
        buttonReTest.Size = New Size(102, 31)
        buttonReTest.TabIndex = 1
        buttonReTest.Text = "Re Test"
        buttonReTest.UseVisualStyleBackColor = True
        ' 
        ' radioOption1
        ' 
        radioOption1.AutoSize = True
        radioOption1.Location = New Point(20, 30)
        radioOption1.Name = "radioOption1"
        radioOption1.Size = New Size(171, 25)
        radioOption1.TabIndex = 1
        radioOption1.TabStop = True
        radioOption1.Text = "Scamming via email"
        radioOption1.UseVisualStyleBackColor = True
        ' 
        ' radioOption2
        ' 
        radioOption2.AutoSize = True
        radioOption2.Location = New Point(20, 60)
        radioOption2.Name = "radioOption2"
        radioOption2.Size = New Size(178, 25)
        radioOption2.TabIndex = 2
        radioOption2.TabStop = True
        radioOption2.Text = "Hacking into systems"
        radioOption2.UseVisualStyleBackColor = True
        ' 
        ' radioOption3
        ' 
        radioOption3.AutoSize = True
        radioOption3.Location = New Point(20, 90)
        radioOption3.Name = "radioOption3"
        radioOption3.Size = New Size(173, 25)
        radioOption3.TabIndex = 3
        radioOption3.TabStop = True
        radioOption3.Text = "Guessing passwords"
        radioOption3.UseVisualStyleBackColor = True
        ' 
        ' radioOption4
        ' 
        radioOption4.AutoSize = True
        radioOption4.Location = New Point(20, 120)
        radioOption4.Name = "radioOption4"
        radioOption4.Size = New Size(139, 25)
        radioOption4.TabIndex = 4
        radioOption4.TabStop = True
        radioOption4.Text = "Encrypting data"
        radioOption4.UseVisualStyleBackColor = True
        ' 
        ' groupBoxOptions
        ' 
        groupBoxOptions.Controls.Add(radioOption1)
        groupBoxOptions.Controls.Add(radioOption2)
        groupBoxOptions.Controls.Add(radioOption3)
        groupBoxOptions.Controls.Add(radioOption4)
        groupBoxOptions.Location = New Point(51, 467)
        groupBoxOptions.Name = "groupBoxOptions"
        groupBoxOptions.Size = New Size(660, 163)
        groupBoxOptions.TabIndex = 8
        groupBoxOptions.TabStop = False
        groupBoxOptions.Text = "Your answer"
        ' 
        ' totalQ
        ' 
        totalQ.AutoSize = True
        totalQ.Font = New Font("Segoe UI", 8.861538F, FontStyle.Bold)
        totalQ.Location = New Point(394, 865)
        totalQ.Name = "totalQ"
        totalQ.Size = New Size(19, 21)
        totalQ.TabIndex = 17
        totalQ.Text = "T"
        totalQ.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblOf
        ' 
        lblOf.AutoSize = True
        lblOf.Location = New Point(367, 865)
        lblOf.Name = "lblOf"
        lblOf.Size = New Size(24, 21)
        lblOf.TabIndex = 16
        lblOf.Text = "of"
        ' 
        ' currentQ
        ' 
        currentQ.AutoSize = True
        currentQ.Font = New Font("Segoe UI", 8.861538F, FontStyle.Bold)
        currentQ.Location = New Point(345, 865)
        currentQ.Name = "currentQ"
        currentQ.Size = New Size(20, 21)
        currentQ.TabIndex = 15
        currentQ.Text = "C"
        currentQ.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' btnPrevious
        ' 
        btnPrevious.Location = New Point(51, 860)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(102, 31)
        btnPrevious.TabIndex = 14
        btnPrevious.Text = "Prev"
        btnPrevious.UseVisualStyleBackColor = True
        ' 
        ' btnNext
        ' 
        btnNext.Location = New Point(609, 860)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(102, 31)
        btnNext.TabIndex = 13
        btnNext.Text = "Next"
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' lblQuestion
        ' 
        lblQuestion.AutoSize = True
        lblQuestion.Location = New Point(55, 431)
        lblQuestion.Name = "lblQuestion"
        lblQuestion.Size = New Size(133, 21)
        lblQuestion.TabIndex = 18
        lblQuestion.Text = "What is phishing?"
        ' 
        ' gExplaination
        ' 
        gExplaination.Controls.Add(explaination)
        gExplaination.Location = New Point(55, 653)
        gExplaination.Name = "gExplaination"
        gExplaination.Size = New Size(656, 177)
        gExplaination.TabIndex = 20
        gExplaination.TabStop = False
        gExplaination.Text = "Explaination"
        ' 
        ' explaination
        ' 
        explaination.Location = New Point(11, 25)
        explaination.Name = "explaination"
        explaination.Size = New Size(634, 130)
        explaination.TabIndex = 0
        explaination.Text = "Explaination"
        ' 
        ' exitBtn
        ' 
        exitBtn.Location = New Point(461, 922)
        exitBtn.Name = "exitBtn"
        exitBtn.Size = New Size(102, 31)
        exitBtn.TabIndex = 21
        exitBtn.Text = "Exit Quiz"
        exitBtn.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(139, 122)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(480, 283)
        PictureBox1.TabIndex = 22
        PictureBox1.TabStop = False
        ' 
        ' MessageBoxForm
        ' 
        ClientSize = New Size(757, 976)
        ControlBox = False
        Controls.Add(PictureBox1)
        Controls.Add(exitBtn)
        Controls.Add(gExplaination)
        Controls.Add(lblQuestion)
        Controls.Add(totalQ)
        Controls.Add(lblOf)
        Controls.Add(currentQ)
        Controls.Add(btnPrevious)
        Controls.Add(btnNext)
        Controls.Add(groupBoxOptions)
        Controls.Add(buttonReTest)
        Controls.Add(lblMessage)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "MessageBoxForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "Result"
        groupBoxOptions.ResumeLayout(False)
        groupBoxOptions.PerformLayout()
        gExplaination.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblMessage As Label
    Friend WithEvents buttonReTest As Button
    Friend WithEvents radioOption1 As RadioButton
    Friend WithEvents radioOption2 As RadioButton
    Friend WithEvents radioOption3 As RadioButton
    Friend WithEvents radioOption4 As RadioButton
    Friend WithEvents groupBoxOptions As GroupBox
    Friend WithEvents totalQ As Label
    Friend WithEvents lblOf As Label
    Friend WithEvents currentQ As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents lblQuestion As Label
    Friend WithEvents gExplaination As GroupBox
    Friend WithEvents explaination As Label
    Friend WithEvents exitBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
