'Jason Permann
'Fall 2025
'RCET 3371
'Servo Control with Q@ Board via Serial Port
'

Option Strict On
Option Explicit On
Option Compare Text

Imports System.IO.Ports


Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect()   'Connect to Serial Port
        SetDefaults()
    End Sub

    'TrackBar Scroll Event
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        PositionSelect()   'Update Position Label
        TX()    'Transmit Data
    End Sub

    Sub SetDefaults()
        'set TrackBar defaults
        TrackBar1.Value = 1
        PositionLabel.Text = 1.ToString
    End Sub


    Sub Connect()
        SerialPort1.Close()
        SerialPort1.BaudRate = 9600 'Q@ Board Default
        SerialPort1.Parity = IO.Ports.Parity.None   'No Parity
        SerialPort1.StopBits = IO.Ports.StopBits.One    '1 Stop Bit
        SerialPort1.DataBits = 8    '8 Data Bits
        SerialPort1.PortName = "COM5" 'Change to your COM Port

        SerialPort1.Open()  'Open Serial Port
        If SerialPort1.IsOpen Then  'Check if Serial Port is open
            MessageBox.Show("Connected to " & SerialPort1.PortName) 'Show message if connected
        End If
        SerialPort1.Close() 'Close Serial Port
    End Sub

    Private Sub Close_Button_Click(sender As Object, e As EventArgs) Handles Close_Button.Click
        SerialPort1.Close() 'Close Serial Port
        Me.Close()  'Close Form
    End Sub

    Sub TX()
        SerialPort1.Close()
        SerialPort1.BaudRate = 9600 'Q@ Board Default
        SerialPort1.Parity = IO.Ports.Parity.None   'No Parity
        SerialPort1.StopBits = IO.Ports.StopBits.One    '1 Stop Bit
        SerialPort1.DataBits = 8    '8 Data Bits
        SerialPort1.PortName = "COM5" 'Change to your COM Port
        SerialPort1.Open()  'Open Serial Port
        Dim data As Byte() = New Byte(1) {}
        data(0) = &H24 'First byte (send an interupt to the PIC "$")
        Dim Position = PositionSelect() 'Increase count for case statement
        Select Case Position
            Case 1
                data(1) = &H5   'Position  (0000 0101)
            Case 2
                data(1) = &H6   'Position  (0000 0110)
            Case 3
                data(1) = &H7   'Position  (0000 0111)
            Case 4
                data(1) = &H8   'Position  (0000 1000)
            Case 5
                data(1) = &H9   'Position  (0000 1001)
            Case 6
                data(1) = &HA   'Position  (0000 1010)
            Case 7
                data(1) = &HB   'Position  (0000 1011)
            Case 8
                data(1) = &HC   'Position  (0000 1100)
            Case 9
                data(1) = &HD   'Position  (0000 1101)
            Case 10
                data(1) = &HE   'Position  (0000 1110)
            Case 11
                data(1) = &HF   'Position  (0000 1111)
            Case 12
                data(1) = &H10  'Position  (0001 0000)
            Case 13
                data(1) = &H11  'Position  (0001 0001)
            Case 14
                data(1) = &H12  'Position  (0001 0010)
            Case 15
                data(1) = &H13  'Position  (0001 0011)
            Case 16
                data(1) = &H14  'Position  (0001 0100)
            Case 17
                data(1) = &H15  'Position  (0001 0101)
            Case 18
                data(1) = &H16  'Position  (0001 0110)
            Case 19
                data(1) = &H17  'Position  (0001 0111)
            Case 20
                data(1) = &H18  'Position  (0001 1000)
        End Select

        SerialPort1.Write(data, 0, 2) 'Send 2 bytes of data
        SerialPort1.Close() 'Close Serial Port
    End Sub

    Function PositionSelect() As Integer
        'Get TrackBar Value
        Dim position As Integer
        position = TrackBar1.Value
        'Update Position Label
        PositionLabel.Text = position.ToString
        Return position
    End Function

End Class
