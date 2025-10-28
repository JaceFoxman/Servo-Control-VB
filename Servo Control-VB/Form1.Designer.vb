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
        Me.HighByteTextBox = New System.Windows.Forms.TextBox()
        Me.ADCLabel = New System.Windows.Forms.Label()
        Me.ADCCheckBox = New System.Windows.Forms.CheckBox()
        Me.ADCTimer = New System.Windows.Forms.Timer(Me.components)
        Me.LowByteTextBox = New System.Windows.Forms.TextBox()
        Me.LowByteLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ADCTextBox = New System.Windows.Forms.TextBox()
        Me.RX_CharactersLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.VoltageLabel = New System.Windows.Forms.Label()
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
        Me.ReceivedTextBox.Location = New System.Drawing.Point(620, 50)
        Me.ReceivedTextBox.Name = "ReceivedTextBox"
        Me.ReceivedTextBox.Size = New System.Drawing.Size(162, 26)
        Me.ReceivedTextBox.TabIndex = 8
        Me.ReceivedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DataTextBox
        '
        Me.DataTextBox.Location = New System.Drawing.Point(616, 109)
        Me.DataTextBox.Name = "DataTextBox"
        Me.DataTextBox.Size = New System.Drawing.Size(172, 26)
        Me.DataTextBox.TabIndex = 9
        Me.DataTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'StatusLabel
        '
        Me.StatusLabel.Location = New System.Drawing.Point(642, 24)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(128, 23)
        Me.StatusLabel.TabIndex = 10
        Me.StatusLabel.Text = "Bytes Recived"
        '
        'TXTextBox
        '
        Me.TXTextBox.Location = New System.Drawing.Point(12, 221)
        Me.TXTextBox.Name = "TXTextBox"
        Me.TXTextBox.Size = New System.Drawing.Size(158, 26)
        Me.TXTextBox.TabIndex = 11
        Me.TXTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'HandShakeTextBox
        '
        Me.HandShakeTextBox.Location = New System.Drawing.Point(12, 164)
        Me.HandShakeTextBox.Name = "HandShakeTextBox"
        Me.HandShakeTextBox.Size = New System.Drawing.Size(158, 26)
        Me.HandShakeTextBox.TabIndex = 12
        Me.HandShakeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXLabel
        '
        Me.TXLabel.Location = New System.Drawing.Point(14, 138)
        Me.TXLabel.Name = "TXLabel"
        Me.TXLabel.Size = New System.Drawing.Size(152, 23)
        Me.TXLabel.TabIndex = 13
        Me.TXLabel.Text = "Transmit Characters"
        '
        'ServoDataLabel
        '
        Me.ServoDataLabel.Location = New System.Drawing.Point(45, 195)
        Me.ServoDataLabel.Name = "ServoDataLabel"
        Me.ServoDataLabel.Size = New System.Drawing.Size(100, 23)
        Me.ServoDataLabel.TabIndex = 14
        Me.ServoDataLabel.Text = "Servo Data"
        '
        'ReadTimer
        '
        Me.ReadTimer.Interval = 500
        '
        'HighByteTextBox
        '
        Me.HighByteTextBox.Location = New System.Drawing.Point(616, 164)
        Me.HighByteTextBox.Name = "HighByteTextBox"
        Me.HighByteTextBox.Size = New System.Drawing.Size(172, 26)
        Me.HighByteTextBox.TabIndex = 15
        Me.HighByteTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ADCLabel
        '
        Me.ADCLabel.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ADCLabel.Location = New System.Drawing.Point(325, 83)
        Me.ADCLabel.Name = "ADCLabel"
        Me.ADCLabel.Size = New System.Drawing.Size(172, 23)
        Me.ADCLabel.TabIndex = 16
        Me.ADCLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ADCCheckBox
        '
        Me.ADCCheckBox.AutoSize = True
        Me.ADCCheckBox.Location = New System.Drawing.Point(49, 253)
        Me.ADCCheckBox.Name = "ADCCheckBox"
        Me.ADCCheckBox.Size = New System.Drawing.Size(69, 24)
        Me.ADCCheckBox.TabIndex = 17
        Me.ADCCheckBox.Text = "ADC"
        Me.ADCCheckBox.UseVisualStyleBackColor = True
        '
        'ADCTimer
        '
        Me.ADCTimer.Interval = 500
        '
        'LowByteTextBox
        '
        Me.LowByteTextBox.Location = New System.Drawing.Point(616, 221)
        Me.LowByteTextBox.Name = "LowByteTextBox"
        Me.LowByteTextBox.Size = New System.Drawing.Size(172, 26)
        Me.LowByteTextBox.TabIndex = 18
        Me.LowByteTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LowByteLabel
        '
        Me.LowByteLabel.Location = New System.Drawing.Point(622, 195)
        Me.LowByteLabel.Name = "LowByteLabel"
        Me.LowByteLabel.Size = New System.Drawing.Size(166, 23)
        Me.LowByteLabel.TabIndex = 19
        Me.LowByteLabel.Text = "ADRESL (Low Byte) "
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(616, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 23)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "ADRESH (High Byte) "
        '
        'ADCTextBox
        '
        Me.ADCTextBox.Location = New System.Drawing.Point(325, 154)
        Me.ADCTextBox.Name = "ADCTextBox"
        Me.ADCTextBox.Size = New System.Drawing.Size(172, 26)
        Me.ADCTextBox.TabIndex = 21
        Me.ADCTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RX_CharactersLabel
        '
        Me.RX_CharactersLabel.Location = New System.Drawing.Point(632, 83)
        Me.RX_CharactersLabel.Name = "RX_CharactersLabel"
        Me.RX_CharactersLabel.Size = New System.Drawing.Size(150, 23)
        Me.RX_CharactersLabel.TabIndex = 22
        Me.RX_CharactersLabel.Text = "Recived Characters"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(355, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 23)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "10 Byte Data"
        '
        'VoltageLabel
        '
        Me.VoltageLabel.Location = New System.Drawing.Point(371, 58)
        Me.VoltageLabel.Name = "VoltageLabel"
        Me.VoltageLabel.Size = New System.Drawing.Size(67, 23)
        Me.VoltageLabel.TabIndex = 24
        Me.VoltageLabel.Text = "Voltage"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.VoltageLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RX_CharactersLabel)
        Me.Controls.Add(Me.ADCTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LowByteLabel)
        Me.Controls.Add(Me.LowByteTextBox)
        Me.Controls.Add(Me.ADCCheckBox)
        Me.Controls.Add(Me.ADCLabel)
        Me.Controls.Add(Me.HighByteTextBox)
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
    Friend WithEvents HighByteTextBox As TextBox
    Friend WithEvents ADCLabel As Label
    Friend WithEvents ADCCheckBox As CheckBox
    Friend WithEvents ADCTimer As Timer
    Friend WithEvents LowByteTextBox As TextBox
    Friend WithEvents LowByteLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ADCTextBox As TextBox
    Friend WithEvents RX_CharactersLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents VoltageLabel As Label
End Class
