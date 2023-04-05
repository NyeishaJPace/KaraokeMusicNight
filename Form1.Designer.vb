<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TotalCostButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.HoursTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SongsRadioComboBox = New System.Windows.Forms.ComboBox()
        Me.TotalCostLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(347, 453)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(443, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(332, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Karaoke Music Night"
        '
        'TotalCostButton
        '
        Me.TotalCostButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalCostButton.Location = New System.Drawing.Point(435, 288)
        Me.TotalCostButton.Name = "TotalCostButton"
        Me.TotalCostButton.Size = New System.Drawing.Size(141, 42)
        Me.TotalCostButton.TabIndex = 2
        Me.TotalCostButton.Text = "Total Cost"
        Me.TotalCostButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(634, 288)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(141, 42)
        Me.ClearButton.TabIndex = 3
        Me.ClearButton.Text = "Clear Form"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'HoursTextBox
        '
        Me.HoursTextBox.Location = New System.Drawing.Point(576, 233)
        Me.HoursTextBox.Name = "HoursTextBox"
        Me.HoursTextBox.Size = New System.Drawing.Size(33, 20)
        Me.HoursTextBox.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(470, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(267, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Hourly Rental of Karaoke Room:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(446, 392)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(241, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Total Cost of Karaoke Night -"
        '
        'SongsRadioComboBox
        '
        Me.SongsRadioComboBox.FormattingEnabled = True
        Me.SongsRadioComboBox.Location = New System.Drawing.Point(435, 102)
        Me.SongsRadioComboBox.Name = "SongsRadioComboBox"
        Me.SongsRadioComboBox.Size = New System.Drawing.Size(360, 21)
        Me.SongsRadioComboBox.TabIndex = 7
        Me.SongsRadioComboBox.Text = "Customize your Night"
        '
        'TotalCostLabel
        '
        Me.TotalCostLabel.AutoSize = True
        Me.TotalCostLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalCostLabel.ForeColor = System.Drawing.Color.White
        Me.TotalCostLabel.Location = New System.Drawing.Point(693, 396)
        Me.TotalCostLabel.Name = "TotalCostLabel"
        Me.TotalCostLabel.Size = New System.Drawing.Size(55, 16)
        Me.TotalCostLabel.TabIndex = 8
        Me.TotalCostLabel.Text = "Label4"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(857, 454)
        Me.Controls.Add(Me.TotalCostLabel)
        Me.Controls.Add(Me.SongsRadioComboBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.HoursTextBox)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.TotalCostButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TotalCostButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents HoursTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents SongsRadioComboBox As ComboBox
    Friend WithEvents TotalCostLabel As Label
End Class
