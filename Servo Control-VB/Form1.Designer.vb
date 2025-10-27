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
        Me.components = New System.ComponentModel.Container()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Close_Button = New System.Windows.Forms.Button()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.PositionLabel = New System.Windows.Forms.Label()
        Me.COMPort_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Connect_Button = New System.Windows.Forms.Button()
        Me.TX_Button = New System.Windows.Forms.Button()
        Me.FreeRun_RadioButton = New System.Windows.Forms.RadioButton()
        Me.TX_GroupBox = New System.Windows.Forms.GroupBox()
        Me.TX_RadioButton = New System.Windows.Forms.RadioButton()
        Me.ReceivedTextBox = New System.Windows.Forms.TextBox()
        Me.DataTextBox = New System.Windows.Forms.TextBox()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.TXTextBox = New System.Windows.Forms.TextBox()
        Me.HandShakeTextBox = New System.Windows.Forms.TextBox()
        Me.TXLabel = New System.Windows.Forms.Label()
        Me.ServoDataLabel = New System.Windows.Forms.Label()
        Me.ReadTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TX_GroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM5"
        '
        'Close_Button
        '
        Me.Close_Button.BackColor = System.Drawing.Color.IndianRed
        Me.Close_Button.ForeColor = System.Drawing.Color.Black
        Me.Close_Button.Location = New System.Drawing.Point(630, 317)
        Me.Close_Button.Name = "Close_Button"
        Me.Close_Button.Size = New System.Drawing.Size(158, 121)
        Me.Close_Button.TabIndex = 0
        Me.Close_Button.Text = "CLOSE"
        Me.Close_Button.UseVisualStyleBackColor = False
        '
        'TrackBar1
        '
        Me.TrackBar1.BackColor = System.Drawing.Color.Indigo
        Me.TrackBar1.Location = New System.Drawing.Point(262, 196)
        Me.TrackBar1.Maximum = 20
        Me.TrackBar1.Minimum = 1
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(296, 69)
        Me.TrackBar1.TabIndex = 1
        Me.TrackBar1.Value = 5
        '
        'PositionLabel
        '
        Me.PositionLabel.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.PositionLabel.Location = New System.Drawing.Point(355, 275)
        Me.PositionLabel.Name = "PositionLabel"
        Me.PositionLabel.Size = New System.Drawing.Size(100, 23)
        Me.PositionLabel.TabIndex = 2
        '
        'COMPort_ComboBox
        '
        Me.COMPort_ComboBox.FormattingEnabled = True
        Me.COMPort_ComboBox.Location = New System.Drawing.Point(12, 12)
        Me.COMPort_ComboBox.Name = "COMPort_ComboBox"
        Me.COMPort_ComboBox.Size = New System.Drawing.Size(133, 28)
        Me.COMPort_ComboBox.TabIndex = 3
        '
        'Connect_Button
        '
        Me.Connect_Button.BackColor = System.Drawing.Color.Green
        Me.Connect_Button.ForeColor = System.Drawing.Color.GhostWhite
        Me.Connect_Button.Location = New System.Drawing.Point(12, 46)
        Me.Connect_Button.Name = "Connect_Button"
        Me.Connect_Button.Size = New System.Drawing.Size(136, 35)
        Me.Connect_Button.TabIndex = 4
        Me.Connect_Button.Text = "Connect"
        Me.Connect_Button.UseVisualStyleBackColor = False
        '
        'TX_Button
        '
        Me.TX_Button.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TX_Button.Location = New System.Drawing.Point(325, 317)
        Me.TX_Button.Name = "TX_Button"
        Me.TX_Button.Size = New System.Drawing.Size(158, 121)
        Me.TX_Button.TabIndex = 5
        Me.TX_Button.Text = "Transmit"
        Me.TX_Button.UseVisualStyleBackColor = False
        '
        'FreeRun_RadioButton
        '
        Me.FreeRun_RadioButton.AutoSize = True
        Me.FreeRun_RadioButton.Location = New System.Drawing.Point(6, 48)
        Me.FreeRun_RadioButton.Name = "FreeRun_RadioButton"
        Me.FreeRun_RadioButton.Size = New System.Drawing.Size(101, 24)
        Me.FreeRun_RadioButton.TabIndex = 6
        Me.FreeRun_RadioButton.TabStop = True
        Me.FreeRun_RadioButton.Text = "Free Run"
        Me.FreeRun_RadioButton.UseVisualStyleBackColor = True
        '
        'TX_GroupBox
        '
        Me.TX_GroupBox.Controls.Add(Me.TX_RadioButton)
        Me.TX_GroupBox.Controls.Add(Me.FreeRun_RadioButton)
        Me.TX_GroupBox.Location = New System.Drawing.Point(12, 317)
        Me.TX_GroupBox.Name = "TX_GroupBox"
        Me.TX_GroupBox.Size = New System.Drawing.Size(223, 121)
        Me.TX_GroupBox.TabIndex = 7
        Me.TX_GroupBox.TabStop = False
        Me.TX_GroupBox.Text = "TX Function Select"
        '
        'TX_RadioButton
        '
        Me.TX_RadioButton.AutoSize = True
        Me.TX_RadioButton.Location = New System.Drawing.Point(6, 78)
        Me.TX_RadioButton.Name = "TX_RadioButton"
        Me.TX_RadioButton.Size = New System.Drawing.Size(130, 24)
        Me.TX_RadioButton.TabIndex = 7
        Me.TX_RadioButton.TabStop = True
        Me.TX_RadioButton.Text = "Transmit Only"
        Me.TX_RadioButton.UseVisualStyleBackColor = True
        '
        'ReceivedTextBox
        '
        Me.ReceivedTextBox.Location = New System.Drawing.Point(630, 14)
        Me.ReceivedTextBox.Name = "ReceivedTextBox"
        Me.ReceivedTextBox.Size = New System.Drawing.Size(158, 26)
        Me.ReceivedTextBox.TabIndex = 8
        '
        'DataTextBox
        '
        Me.DataTextBox.Location = New System.Drawing.Point(630, 93)
        Me.DataTextBox.Name = "DataTextBox"
        Me.DataTextBox.Size = New System.Drawing.Size(158, 26)
        Me.DataTextBox.TabIndex = 9
        '
        'StatusLabel
        '
        Me.StatusLabel.Location = New System.Drawing.Point(630, 70)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(171, 23)
        Me.StatusLabel.TabIndex = 10
        '
        'TXTextBox
        '
        Me.TXTextBox.Location = New System.Drawing.Point(12, 239)
        Me.TXTextBox.Name = "TXTextBox"
        Me.TXTextBox.Size = New System.Drawing.Size(158, 26)
        Me.TXTextBox.TabIndex = 11
        '
        'HandShakeTextBox
        '
        Me.HandShakeTextBox.Location = New System.Drawing.Point(12, 164)
        Me.HandShakeTextBox.Name = "HandShakeTextBox"
        Me.HandShakeTextBox.Size = New System.Drawing.Size(158, 26)
        Me.HandShakeTextBox.TabIndex = 12
        '
        'TXLabel
        '
        Me.TXLabel.Location = New System.Drawing.Point(48, 138)
        Me.TXLabel.Name = "TXLabel"
        Me.TXLabel.Size = New System.Drawing.Size(100, 23)
        Me.TXLabel.TabIndex = 13
        Me.TXLabel.Text = "Transmit"
        '
        'ServoDataLabel
        '
        Me.ServoDataLabel.Location = New System.Drawing.Point(35, 213)
        Me.ServoDataLabel.Name = "ServoDataLabel"
        Me.ServoDataLabel.Size = New System.Drawing.Size(100, 23)
        Me.ServoDataLabel.TabIndex = 14
        Me.ServoDataLabel.Text = "Servo Data"
        '
        'ReadTimer
        '
        Me.ReadTimer.Interval = 50
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ServoDataLabel)
        Me.Controls.Add(Me.TXLabel)
        Me.Controls.Add(Me.HandShakeTextBox)
        Me.Controls.Add(Me.TXTextBox)
        Me.Controls.Add(Me.StatusLabel)
        Me.Controls.Add(Me.DataTextBox)
        Me.Controls.Add(Me.ReceivedTextBox)
        Me.Controls.Add(Me.TX_GroupBox)
        Me.Controls.Add(Me.TX_Button)
        Me.Controls.Add(Me.Connect_Button)
        Me.Controls.Add(Me.COMPort_ComboBox)
        Me.Controls.Add(Me.PositionLabel)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.Close_Button)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TX_GroupBox.ResumeLayout(False)
        Me.TX_GroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Close_Button As Button
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents PositionLabel As Label
    Friend WithEvents COMPort_ComboBox As ComboBox
    Friend WithEvents Connect_Button As Button
    Friend WithEvents TX_Button As Button
    Friend WithEvents FreeRun_RadioButton As RadioButton
    Friend WithEvents TX_GroupBox As GroupBox
    Friend WithEvents TX_RadioButton As RadioButton
    Friend WithEvents ReceivedTextBox As TextBox
    Friend WithEvents DataTextBox As TextBox
    Friend WithEvents StatusLabel As Label
    Friend WithEvents TXTextBox As TextBox
    Friend WithEvents HandShakeTextBox As TextBox
    Friend WithEvents TXLabel As Label
    Friend WithEvents ServoDataLabel As Label
    Friend WithEvents ReadTimer As Timer
End Class
