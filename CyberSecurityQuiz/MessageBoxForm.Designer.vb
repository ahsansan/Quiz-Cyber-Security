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
        lblMessage = New Label()
        buttonReTest = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' lblMessage
        ' 
        lblMessage.AutoSize = True
        lblMessage.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        lblMessage.Location = New Point(15, 20)
        lblMessage.Name = "lblMessage"
        lblMessage.Size = New Size(0, 26)
        lblMessage.TabIndex = 0
        ' 
        ' buttonReTest
        ' 
        buttonReTest.Location = New Point(328, 428)
        buttonReTest.Name = "buttonReTest"
        buttonReTest.Size = New Size(102, 31)
        buttonReTest.TabIndex = 1
        buttonReTest.Text = "Re Test"
        buttonReTest.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(15, 60)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 21)
        Label1.TabIndex = 2
        Label1.Text = "Result"
        ' 
        ' MessageBoxForm
        ' 
        ClientSize = New Size(773, 471)
        ControlBox = False
        Controls.Add(Label1)
        Controls.Add(buttonReTest)
        Controls.Add(lblMessage)
        MaximizeBox = False
        MinimizeBox = False
        Name = "MessageBoxForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "Result"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblMessage As Label
    Friend WithEvents buttonReTest As Button
    Friend WithEvents Label1 As Label
End Class
