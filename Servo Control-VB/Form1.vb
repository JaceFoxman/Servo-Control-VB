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
        SetDefaults()
    End Sub

    'Connect Button Click Event
    Private Sub Connect_Button_Click(sender As Object, e As EventArgs) Handles Connect_Button.Click
        Select Case COMPort_ComboBox.Text <> ""  'Wait for COM Port Selection
            Case True
                Connect()   'Connect to Serial Port
            Case False
                MessageBox.Show("Please select a COM Port")
        End Select

    End Sub

    'TrackBar Scroll Event
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Select Case TX_RadioButton.Checked = True
            Case True
                PositionSelect()   'Update Position Label
            Case False
                PositionSelect()   'Update Position Label
                TX()    'Transmit Data
        End Select


    End Sub

    Sub SetDefaults()
        'set TrackBar defaults
        TrackBar1.Value = 1
        PositionLabel.Text = "Position:" & 1.ToString
        TX_RadioButton.Checked = True
        FreeRun_RadioButton.Checked = False

        COMPort_ComboBox.Items.Add("COM1")
        COMPort_ComboBox.Items.Add("COM2")
        COMPort_ComboBox.Items.Add("COM3")
        COMPort_ComboBox.Items.Add("COM4")
        COMPort_ComboBox.Items.Add("COM5")
    End Sub

    'when Free Run is selected disable TX Button
    Private Sub FreeRun_RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles FreeRun_RadioButton.CheckedChanged
        Select Case FreeRun_RadioButton.Checked
            Case True
                TX_Button.Enabled = False
            Case False
                TX_Button.Enabled = True
        End Select
    End Sub

    Private Sub TX_RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles TX_RadioButton.CheckedChanged
        Select Case TX_RadioButton.Checked
            Case True
                TX_Button.Enabled = True
            Case False
                TX_Button.Enabled = False
        End Select
    End Sub


    Sub Connect()

        Try
            Dim comPort As String = COMPort_ComboBox.Text
            SerialPort1.Close()
            SerialPort1.BaudRate = 9600 'Q@ Board Default
            SerialPort1.Parity = IO.Ports.Parity.None   'No Parity
            SerialPort1.StopBits = IO.Ports.StopBits.One    '1 Stop Bit
            SerialPort1.DataBits = 8    '8 Data Bits
            SerialPort1.PortName = comPort 'Change to your COM Port


            SerialPort1.Open()  'Open Serial Port
            If SerialPort1.IsOpen Then  'Check if Serial Port is open
                MessageBox.Show("Connected to " & SerialPort1.PortName) 'Show message if connected
            End If
            SerialPort1.Close() 'Close Serial Port
        Catch ex As Exception
            'Show error message if port is invalid
            MessageBox.Show("Error: " & ex.Message)
            Return
        End Try
    End Sub

    Private Sub Close_Button_Click(sender As Object, e As EventArgs) Handles Close_Button.Click
        SerialPort1.Close() 'Close Serial Port
        Me.Close()  'Close Form
    End Sub

    Sub TX()
        Try
            Dim comPort As String = COMPort_ComboBox.Text
            SerialPort1.Close()
            SerialPort1.BaudRate = 9600 'Q@ Board Default
            SerialPort1.Parity = IO.Ports.Parity.None   'No Parity
            SerialPort1.StopBits = IO.Ports.StopBits.One    '1 Stop Bit
            SerialPort1.DataBits = 8    '8 Data Bits
            SerialPort1.PortName = comPort 'Change to your COM Port
            SerialPort1.Open()  'Open Serial Port
            Dim data As Byte() = New Byte(1) {}
            data(0) = &H24 'First byte (send an interupt to the PIC "$")
            Dim Position = PositionSelect() 'Increase count for case statement
            Select Case Position
                Case 1
                    data(1) = &H8   'Position  (0000 1000)
                Case 2
                    data(1) = &H10  'Position  (0001 0000)
                Case 3
                    data(1) = &H18  'Position  (0001 1000)
                Case 4
                    data(1) = &H20  'Position  (0010 0000)
                Case 5
                    data(1) = &H28  'Position  (0010 1000)
                Case 6
                    data(1) = &H30  'Position  (0011 0000)
                Case 7
                    data(1) = &H38  'Position  (0011 1000)
                Case 8
                    data(1) = &H40  'Position  (0100 0000)
                Case 9
                    data(1) = &H48  'Position  (0100 1000)
                Case 10
                    data(1) = &H50  'Position  (0101 0000)
                Case 11
                    data(1) = &H60  'Position  (0110 0000)
                Case 12
                    data(1) = &H68  'Position  (0110 1000)
                Case 13
                    data(1) = &H70  'Position  (0111 0000)
                Case 14
                    data(1) = &H78  'Position  (0111 1000)
                Case 15
                    data(1) = &H80  'Position  (1000 0000)
                Case 16
                    data(1) = &H88  'Position  (1000 1000)
                Case 17
                    data(1) = &H90  'Position  (1001 0000)
                Case 18
                    data(1) = &H98  'Position  (1001 1000)
                Case 19
                    data(1) = &HA0  'Position  (1010 0000)
                Case 20
                    data(1) = &H18  'Position  (1010 1000)
            End Select

            SerialPort1.Write(data, 0, 2) 'Send 2 bytes of data
            SerialPort1.Close() 'Close Serial Port

        Catch ex As Exception
            'Show error message if port is invalid
            MessageBox.Show("Error: " & ex.Message)
        Return
        End Try
    End Sub

    Function PositionSelect() As Integer
        'Get TrackBar Value
        Dim position As Integer
        position = TrackBar1.Value
        'Update Position Label
        PositionLabel.Text = "Position:" & position.ToString
        Return position
    End Function

    Private Sub TX_Button_Click_1(sender As Object, e As EventArgs) Handles TX_Button.Click
        TX()    'Transmit Data
    End Sub
End Class
