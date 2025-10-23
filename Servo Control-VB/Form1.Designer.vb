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
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Connect_Button.Size = New System.Drawing.Size(133, 35)
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TX_Button)
        Me.Controls.Add(Me.Connect_Button)
        Me.Controls.Add(Me.COMPort_ComboBox)
        Me.Controls.Add(Me.PositionLabel)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.Close_Button)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
