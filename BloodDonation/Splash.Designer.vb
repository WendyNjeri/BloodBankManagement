<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Splash
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Splash))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Blood1 = New System.Windows.Forms.PictureBox()
        Me.MyProgress = New System.Windows.Forms.ProgressBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.PercentageLbl = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.Blood1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(158, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(97, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(196, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Blood  Donation  System"
        '
        'Blood1
        '
        Me.Blood1.ErrorImage = Nothing
        Me.Blood1.Image = CType(resources.GetObject("Blood1.Image"), System.Drawing.Image)
        Me.Blood1.InitialImage = CType(resources.GetObject("Blood1.InitialImage"), System.Drawing.Image)
        Me.Blood1.Location = New System.Drawing.Point(123, 3)
        Me.Blood1.Name = "Blood1"
        Me.Blood1.Size = New System.Drawing.Size(140, 136)
        Me.Blood1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Blood1.TabIndex = 4
        Me.Blood1.TabStop = False
        '
        'MyProgress
        '
        Me.MyProgress.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MyProgress.ForeColor = System.Drawing.Color.Red
        Me.MyProgress.Location = New System.Drawing.Point(0, 248)
        Me.MyProgress.Name = "MyProgress"
        Me.MyProgress.Size = New System.Drawing.Size(430, 10)
        Me.MyProgress.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(2, 227)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Loading.... "
        '
        'Timer1
        '
        '
        'PercentageLbl
        '
        Me.PercentageLbl.AutoSize = True
        Me.PercentageLbl.BackColor = System.Drawing.SystemColors.Desktop
        Me.PercentageLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PercentageLbl.Location = New System.Drawing.Point(120, 227)
        Me.PercentageLbl.Name = "PercentageLbl"
        Me.PercentageLbl.Size = New System.Drawing.Size(22, 18)
        Me.PercentageLbl.TabIndex = 7
        Me.PercentageLbl.Text = "%"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(148, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "%"
        '
        'Splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(435, 261)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PercentageLbl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MyProgress)
        Me.Controls.Add(Me.Blood1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Splash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.Blood1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Blood1 As System.Windows.Forms.PictureBox
    Friend WithEvents MyProgress As System.Windows.Forms.ProgressBar
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PercentageLbl As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
