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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        lblQuestion = New Label()
        radioOption1 = New RadioButton()
        radioOption2 = New RadioButton()
        radioOption3 = New RadioButton()
        radioOption4 = New RadioButton()
        btnNext = New Button()
        progressBar = New ProgressBar()
        groupBoxOptions = New GroupBox()
        btnPrevious = New Button()
        titleApp = New Label()
        currentQ = New Label()
        lblOf = New Label()
        totalQ = New Label()
        PictureBox1 = New PictureBox()
        groupBoxOptions.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblQuestion
        ' 
        lblQuestion.AutoSize = True
        lblQuestion.Location = New Point(68, 470)
        lblQuestion.Name = "lblQuestion"
        lblQuestion.Size = New Size(133, 21)
        lblQuestion.TabIndex = 0
        lblQuestion.Text = "What is phishing?"
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
        ' btnNext
        ' 
        btnNext.Location = New Point(626, 700)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(102, 31)
        btnNext.TabIndex = 5
        btnNext.Text = "Next"
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' progressBar
        ' 
        progressBar.Location = New Point(65, 759)
        progressBar.Name = "progressBar"
        progressBar.Size = New Size(663, 31)
        progressBar.TabIndex = 6
        ' 
        ' groupBoxOptions
        ' 
        groupBoxOptions.Controls.Add(radioOption1)
        groupBoxOptions.Controls.Add(radioOption2)
        groupBoxOptions.Controls.Add(radioOption3)
        groupBoxOptions.Controls.Add(radioOption4)
        groupBoxOptions.Location = New Point(68, 511)
        groupBoxOptions.Name = "groupBoxOptions"
        groupBoxOptions.Size = New Size(660, 163)
        groupBoxOptions.TabIndex = 7
        groupBoxOptions.TabStop = False
        groupBoxOptions.Text = "Choose an answer"
        ' 
        ' btnPrevious
        ' 
        btnPrevious.Location = New Point(68, 700)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(102, 31)
        btnPrevious.TabIndex = 8
        btnPrevious.Text = "Prev"
        btnPrevious.UseVisualStyleBackColor = True
        ' 
        ' titleApp
        ' 
        titleApp.AutoSize = True
        titleApp.Font = New Font("Segoe UI", 17F, FontStyle.Bold Or FontStyle.Underline)
        titleApp.Location = New Point(258, 25)
        titleApp.Name = "titleApp"
        titleApp.Size = New Size(305, 42)
        titleApp.TabIndex = 9
        titleApp.Text = "Cyber Security Quiz"
        ' 
        ' currentQ
        ' 
        currentQ.AutoSize = True
        currentQ.Font = New Font("Segoe UI", 8.861538F, FontStyle.Bold)
        currentQ.Location = New Point(366, 705)
        currentQ.Name = "currentQ"
        currentQ.Size = New Size(20, 21)
        currentQ.TabIndex = 10
        currentQ.Text = "C"
        currentQ.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblOf
        ' 
        lblOf.AutoSize = True
        lblOf.Location = New Point(389, 705)
        lblOf.Name = "lblOf"
        lblOf.Size = New Size(24, 21)
        lblOf.TabIndex = 11
        lblOf.Text = "of"
        ' 
        ' totalQ
        ' 
        totalQ.AutoSize = True
        totalQ.Font = New Font("Segoe UI", 8.861538F, FontStyle.Bold)
        totalQ.Location = New Point(416, 705)
        totalQ.Name = "totalQ"
        totalQ.Size = New Size(19, 21)
        totalQ.TabIndex = 12
        totalQ.Text = "T"
        totalQ.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(68, 94)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(645, 352)
        PictureBox1.TabIndex = 13
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(795, 823)
        Controls.Add(PictureBox1)
        Controls.Add(totalQ)
        Controls.Add(lblOf)
        Controls.Add(currentQ)
        Controls.Add(titleApp)
        Controls.Add(btnPrevious)
        Controls.Add(groupBoxOptions)
        Controls.Add(progressBar)
        Controls.Add(btnNext)
        Controls.Add(lblQuestion)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Cyber Security Quiz"
        groupBoxOptions.ResumeLayout(False)
        groupBoxOptions.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblQuestion As Label
    Friend WithEvents radioOption1 As RadioButton
    Friend WithEvents radioOption2 As RadioButton
    Friend WithEvents radioOption3 As RadioButton
    Friend WithEvents radioOption4 As RadioButton
    Friend WithEvents btnNext As Button
    Friend WithEvents progressBar As ProgressBar
    Friend WithEvents groupBoxOptions As GroupBox
    Friend WithEvents btnPrevious As Button
    Friend WithEvents titleApp As Label
    Friend WithEvents currentQ As Label
    Friend WithEvents lblOf As Label
    Friend WithEvents totalQ As Label
    Friend WithEvents PictureBox1 As PictureBox

End Class
