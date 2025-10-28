'Jason Permann
'Fall 2025
'RCET 3371
'Servo Control with Q@ Board via Serial Port
'

Option Strict On
Option Explicit On
Option Compare Text

Imports System.IO.Ports
Imports System.Reflection


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
        PositionLabel.Text = "Position: " & 1.ToString
        TX_RadioButton.Checked = True
        FreeRun_RadioButton.Checked = False



        For Each port In SerialPort.GetPortNames()
            COMPort_ComboBox.Items.Add(port)
        Next

        'COMPort_ComboBox.Items.Add("COM1")
        'COMPort_ComboBox.Items.Add("COM2")
        'COMPort_ComboBox.Items.Add("COM3")
        'COMPort_ComboBox.Items.Add("COM4")
        'COMPort_ComboBox.Items.Add("COM5")
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

        Catch ex As Exception
            'Show error message if port is invalid
            MessageBox.Show("Error: " & ex.Message)

            Return
        End Try
        ReadTimer.Enabled = True 'Enable Timer to read data

    End Sub

    Private Sub Close_Button_Click(sender As Object, e As EventArgs) Handles Close_Button.Click
        SerialPort1.Close() 'Close Serial Port
        Me.Close()  'Close Form
    End Sub

    Sub TX()
        Try
            Dim handShake As Byte() = New Byte(1) {}
            handShake(0) = &H24 'First byte (send an interupt to the PIC "$")
            Dim temp As String
            If ADCCheckBox.Checked = True Then
                handShake(1) = &H26
            Else
                handShake(1) = &H0
            End If
            SerialPort1.Write(handShake, 0, 2) 'Send 2 bytes of data
            For Each dataByte In handShake
                temp &= $"{CStr(dataByte)},"
            Next
            HandShakeTextBox.Text = temp

        Catch ex As Exception
            'Show error message if port is invalid
            MessageBox.Show("Error: " & ex.Message)

        End Try
        'ReadTimer.Enabled = True 'Enable Timer to read data
    End Sub

    Sub ServoPosition()
        Dim data As Byte() = New Byte(0) {}
        Dim Position = PositionSelect()
        Select Case Position
            Case 1
                data(0) = &H0  'Position  (0000 0000)
            Case 2
                data(0) = &H1  'Position  (0000 0001)
            Case 3
                data(0) = &H2  'Position  (0000 0010)
            Case 4
                data(0) = &H3  'Position  (0010 0000)
            Case 5
                data(0) = &H4  'Position  (0010 1000)
            Case 6
                data(0) = &H5  'Position  (0011 0000)
            Case 7
                data(0) = &H6  'Position  (0011 1000)
            Case 8
                data(0) = &H7  'Position  (0100 0000)
            Case 9
                data(0) = &H8  'Position  (0100 1000)
            Case 10
                data(0) = &H9  'Position  (0101 0000)
            Case 11
                data(0) = &HA  'Position  (0110 0000)
            Case 12
                data(0) = &HB  'Position  (0110 1000)
            Case 13
                data(0) = &HC  'Position  (0111 0000)
            Case 14
                data(0) = &HD  'Position  (0111 1000)
            Case 15
                data(0) = &HE  'Position  (1000 0000)
            Case 16
                data(0) = &HF  'Position  (1000 1000)
            Case 17
                data(0) = &H10  'Position  (1001 0000)
            Case 18
                data(0) = &H11  'Position  (1001 1000)
            Case 19
                data(0) = &H12  'Position  (1010 0000)
            Case 20
                data(0) = &H13  'Position  (1010 1000)
        End Select

        SerialPort1.Write(data, 0, 1) 'Send 1 bytes of data
        TXTextBox.Text = data(0).ToString
    End Sub

    Function PositionSelect() As Integer
        'Get TrackBar Value
        Dim position As Integer
        position = TrackBar1.Value
        'Update Position Label
        PositionLabel.Text = "Position: " & position.ToString
        Return position
    End Function

    Private Sub TX_Button_Click_1(sender As Object, e As EventArgs) Handles TX_Button.Click
        TX()    'Transmit Data
    End Sub

    Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        CheckForIllegalCrossThreadCalls = False
        Dim incomingData As Integer = SerialPort1.BytesToRead
        ReceivedTextBox.Text = incomingData.ToString
    End Sub
    Private Sub ReadTimer_Tick(sender As Object, e As EventArgs) Handles ReadTimer.Tick

        If SerialPort1.BytesToRead > 0 Then
            Dim value(SerialPort1.BytesToRead) As Byte
            Dim temp As String
            SerialPort1.Read(value, 0, SerialPort1.BytesToRead)
            For Each dataByte In value
                temp &= $"{CStr(dataByte)},"
            Next
            DataTextBox.Text = temp


            If value(0) = 36 Then
                ServoPosition() 'Send Servo Position

                Select Case ADCCheckBox.Checked = True
                    Case True
                        Try
                            Dim highByteWeighted As Integer = (value(1) * 4) 'Convert ADRESH to proper 10 byte value
                            Dim lowByteWeighted As Integer = (value(2) \ 64) 'Convert ADRESL to proper 10 byte value
                            HighByteTextBox.Text = highByteWeighted.ToString
                            LowByteTextBox.Text = lowByteWeighted.ToString
                            ADCTimer.Enabled = True 'turn on here so a proper value is known for ADC label
                        Catch ex As Exception
                            MessageBox.Show("Error: Read Buffer Overflow")
                        End Try
                    Case False
                        ADCTimer.Enabled = False 'turn off here so the next tick of ADC timer dosent read a string value
                        HighByteTextBox.Text = "No current data"
                        LowByteTextBox.Text = "No current data"
                        ADCTextBox.Text = "No current data"
                        ADCLabel.Text = "No current data"
                End Select
            Else

            End If

        End If
        'ReadTimer.Enabled = False
    End Sub



    Private Sub ADCTimer_Tick(sender As Object, e As EventArgs) Handles ADCTimer.Tick
        Select Case ADCCheckBox.Checked = True
            Case True
                Dim highByte As Integer = CInt(HighByteTextBox.Text)
                Dim lowByte As Integer = CInt(LowByteTextBox.Text)
                Dim tenByteData As Integer = (highByte + lowByte)
                ADCTextBox.Text = tenByteData.ToString
            Case False
                HighByteTextBox.Text = "No current data"
                LowByteTextBox.Text = "No current data"
                ADCTextBox.Text = "No current data"
                ADCLabel.Text = "No current data"
        End Select
    End Sub

End Class
