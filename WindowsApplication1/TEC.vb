Public Class TEC

    Dim cpTimeout As Integer = 2000
    Dim cpBaudRate = 9600
    Dim cpName As String
    Dim cp As IO.Ports.SerialPort = Nothing

    Dim returnStr As String
    Dim Incoming As String

    Dim skipEvent As Boolean = False

    Private Shared exitFlag As Boolean = False


    Private Sub btConnect_Click(sender As Object, e As EventArgs) Handles btConnect.Click

        btConnect.Enabled = False
        cbSerialPorts.Enabled = False
        btList.Enabled = False
        btStop.Enabled = True
        btStartTEC.Enabled = True
        cbTECenable.Enabled = True

        'groupTEC.Enabled = False

        ToolStripStatusLabel1.Text = "Connecting..."
        ToolStripStatusLabel1.ForeColor = Color.Black



        Try
            cp = My.Computer.Ports.OpenSerialPort(cpName)

            With cp
                .ReadTimeout = cpTimeout
                .WriteTimeout = cpTimeout
                .BaudRate = cpBaudRate
                .DataBits = 8
                .Parity = IO.Ports.Parity.None
                .StopBits = IO.Ports.StopBits.One
                .Handshake = IO.Ports.Handshake.None
                .NewLine = vbLf
                .DtrEnable = True
                Threading.Thread.Sleep(1000)
                .DtrEnable = False
            End With

        Catch ex As Exception

            Dim style = MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly Or MsgBoxStyle.ApplicationModal
            Dim message = ex.Message
            Dim title = cpName
            If MsgBox(message, style, title) = MsgBoxResult.Ok Then
                ' Application.Exit()
            End If


        End Try

        If initCheck() = 0 Then
            Timer1.Start()
        Else
            btConnect.Enabled = True
            cbSerialPorts.Enabled = True
            btList.Enabled = True
            btStop.Enabled = False
            btStartTEC.Enabled = False
        End If

    End Sub

    Function initCheck() As Int16
        Dim inBuffer As String = " "

        Timer1.Stop()

        Try
            'cp.DiscardInBuffer()

            'Threading.Thread.Sleep(1000)

            ' cp.DiscardOutBuffer()

            'Threading.Thread.Sleep(1000)
            Do
                inBuffer = cp.ReadLine()
                If inBuffer.EndsWith("sensors" & vbCr) Then
                    Exit Do
                End If
            Loop

            ToolStripStatusLabel1.Text = inBuffer
            If Not inBuffer.Contains("2") Then
                Dim style = MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly Or MsgBoxStyle.ApplicationModal
                Dim message = "Wrong number of devices!"
                If MsgBox(message, style) = MsgBoxResult.Ok Then
                    cp.Close()
                    Return 1
                End If

            End If

        Catch ex As Exception
            Dim style = MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly Or MsgBoxStyle.ApplicationModal
            Dim message = ex.Message
            Dim title = cpName

            If MsgBox(message, style, "Initialization") = MsgBoxResult.Ok Then

                If cp IsNot Nothing Then
                    cp.Close()
                End If
                btConnect.Enabled = True
                btStartTEC.Enabled = False
                Return 1
                'Application.Exit()
            End If
            Return 0
            Timer1.Start()
        End Try
    End Function

    Private Sub btList_Click(sender As Object, e As EventArgs) Handles btList.Click
        cbSerialPorts.Items.Clear()
        Dim spIndex As Integer
        For Each sp As String In My.Computer.Ports.SerialPortNames
            cbSerialPorts.Items.Insert(spIndex, sp)
            spIndex += 1
        Next
        If spIndex > 0 Then cbSerialPorts.Enabled = True
        cbSerialPorts.SelectedIndex = 0
    End Sub

    Private Sub cbSerialPorts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSerialPorts.SelectedIndexChanged
        btConnect.Enabled = True
        cpName = cbSerialPorts.SelectedItem.ToString()
    End Sub

    Private Sub btStop_Click(sender As Object, e As EventArgs) Handles btStop.Click
        Timer1.Stop()
        Timer1.Dispose()
        btStop.Enabled = False
        btConnect.Enabled = True
        cbSerialPorts.Enabled = True

        Dim commandStr As String = "w" & vbCr
        Try
            cp.WriteLine(commandStr)
        Catch ex As Exception
            Dim style = MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly Or MsgBoxStyle.ApplicationModal
            Dim message = ex.Message
            Dim title = cpName
            If MsgBox(message, style, title) = MsgBoxResult.Ok Then
                ' Application.Exit()
            End If
        End Try

        commandStr = "O" & vbCr
        Try
            cp.WriteLine(commandStr)
            Threading.Thread.Sleep(1000)
        Catch ex As Exception
            Dim style = MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly Or MsgBoxStyle.ApplicationModal
            Dim message = ex.Message
            Dim title = cpName
            If MsgBox(message, style, title) = MsgBoxResult.Ok Then
                ' Application.Exit()
            End If
        End Try

        ToolStripStatusLabel1.Text = "TEC Not connected"
        ToolStripStatusLabel1.ForeColor = Color.Black
        'cp.DiscardInBuffer()
        'cp.DiscardInBuffer()
        'cp.Dispose()

        If cp IsNot Nothing Then cp.Close()
        Threading.Thread.Sleep(1000)
        Application.Exit()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        If cp IsNot Nothing Then
            If cp.IsOpen Then
                refreshTEC()
                If Not cbTECenable.Checked Then
                    ToolStripStatusLabel1.Text = "TEC not enabled"
                    ToolStripProgressBar1.Value = 0
                    ToolStripProgressBar1.Enabled = False
                    ToolStripStatusLabel1.ForeColor = Color.Black
                Else
                    ToolStripProgressBar1.Enabled = True
                End If
            End If
        End If

    End Sub
    Function refreshTEC()
        Dim commandStr As String = "k" & vbCr
        Dim Algorithm As String = Nothing
        Dim Setpoint As String = Nothing
        Dim T1 As String = Nothing
        Dim T2 As String = Nothing
        Dim TEC_out As String = Nothing
        Dim Kp As String = Nothing
        Dim Ki As String = Nothing
        Dim Kd As String = Nothing
        Dim Hys_cool As String = Nothing
        Dim Hys_heat As String = Nothing
        Dim TECerror As String = Nothing
        Dim TECrunning As String = Nothing
        Dim TECenabled As String = Nothing
        Dim AT_out As String = Nothing
        Dim ATnoise As String = Nothing
        Dim sensor_error As String = Nothing

        Timer1.Stop()


        Try
        cp.WriteLine(commandStr)

            'Threading.Thread.Sleep(100)

            Algorithm &= cp.ReadLine()

        Catch ex As Exception

            Dim style = MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly Or MsgBoxStyle.ApplicationModal
            Dim message = ex.Message
            Dim title = cpName
            If MsgBox(message, style, title) = MsgBoxResult.Ok Then
                ' Application.Exit()
            End If

        End Try

        If cp.IsOpen Then
            If Algorithm.StartsWith("?") Then
                ToolStripStatusLabel1.Text = "Command " & Algorithm & " not recognized"
                ToolStripStatusLabel1.ForeColor = Color.Red
                cp.DiscardOutBuffer()
                cp.DiscardInBuffer()

                Timer1.Start()
                Exit Function
            ElseIf Algorithm.StartsWith("!") Then

                If Algorithm.Substring(1) = 1 Then
                    ToolStripStatusLabel1.Text = "Sensor T1 disconnected! TEC stopped: to restart, press " & btStartTEC.Text
                    ToolStripStatusLabel1.ForeColor = Color.Red
                    cbTECenable.Enabled = False
                    cp.WriteLine("O" & vbCr)
                    cp.DiscardOutBuffer()
                    cp.DiscardInBuffer()
                    Timer1.Start()
                ElseIf Algorithm.Substring(1) = 2 Then
                    ToolStripStatusLabel1.Text = "Sensor T2 disconnected! TEC stopped: to restart, press" & btStartTEC.Text
                    ToolStripStatusLabel1.ForeColor = Color.Red
                    cbTECenable.Enabled = False
                    cp.WriteLine("O" & vbCr)
                    cp.DiscardOutBuffer()
                    cp.DiscardInBuffer()
                    Timer1.Start()
                Else
                    ToolStripStatusLabel1.Text = "All sensors disconnected! TEC stopped: to restart, press" & btStartTEC.Text
                    ToolStripStatusLabel1.ForeColor = Color.Red
                    cbTECenable.Enabled = False
                    cp.WriteLine("O" & vbCr)
                    cp.DiscardOutBuffer()
                    cp.DiscardInBuffer()
                    Timer1.Start()
                End If

                Timer1.Stop()
                Timer1.Dispose()
                btStop.Enabled = False
                btConnect.Enabled = True
                cbSerialPorts.Enabled = True

                cp.WriteLine("O" & vbCr)

                ToolStripStatusLabel1.Text = "TEC Not connected"
                ToolStripStatusLabel1.ForeColor = Color.Black

                If cp IsNot Nothing Then cp.Close()

                'Application.Exit()

            Else
                Try
                    Setpoint &= cp.ReadLine()
                    T1 &= cp.ReadLine()
                    T2 &= cp.ReadLine()
                    TEC_out &= cp.ReadLine()
                    Kp &= cp.ReadLine()
                    Ki &= cp.ReadLine()
                    Kd &= cp.ReadLine()
                    Hys_cool &= cp.ReadLine()
                    Hys_heat &= cp.ReadLine()
                    TECerror &= cp.ReadLine()
                    TECrunning &= cp.ReadLine()
                    TECenabled = cp.ReadLine()
                    AT_out &= cp.ReadLine()
                    ATnoise &= cp.ReadLine()
                    sensor_error &= cp.ReadLine()

                Catch ex As Exception
                    Dim style = MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly Or MsgBoxStyle.ApplicationModal
                    Dim message = ex.Message
                    Dim title = cpName
                    If MsgBox(message, style, title) = MsgBoxResult.Ok Then
                        ' Application.Exit()
                    End If
                End Try

                Try
                    skipEvent = True
                    Algorithm1.Checked = Convert.ToDecimal(Algorithm) = 0
                    Algorithm2.Checked = Convert.ToDecimal(Algorithm) = 1
                    Algorithm3.Checked = Convert.ToDecimal(Algorithm) = 2


                    NumericHysCool.Value = Convert.ToDouble(Hys_cool)
                    NumericHysHeat.Value = Convert.ToDouble(Hys_heat)

                    GroupAT.Enabled = Algorithm1.Checked
                    GroupPID.Enabled = Not Algorithm3.Checked
                    NumericKp.ReadOnly = Algorithm1.Checked
                    NumericKi.ReadOnly = Algorithm1.Checked
                    NumericKd.ReadOnly = Algorithm1.Checked
                    NumericATnoise.Enabled = Algorithm1.Checked

                    NumericKp.Value = Convert.ToDouble(Kp)
                    NumericKi.Value = Convert.ToDouble(Ki)
                    NumericKd.Value = Convert.ToDouble(Kd)

                    GroupONOFF.Enabled = Algorithm3.Checked

                    numSetpoint.Value = Convert.ToDouble(Setpoint)
                    SensorsT1.Value = Convert.ToDouble(T1)
                    SensorsT2.Value = Convert.ToDouble(T2)
                    ToolStripProgressBar1.Value = Convert.ToDouble(TEC_out)


                    If Convert.ToDecimal(TECerror) > 0 Then
                        ToolStripStatusLabel1.Text = "TEC error! To restart, press " & btStartTEC.Text
                        ToolStripStatusLabel1.ForeColor = Color.Red
                        cbTECenable.Enabled = False
                        cp.WriteLine("O" & vbCr)
                        cp.DiscardOutBuffer()
                        cp.DiscardInBuffer()
                        Timer1.Start()
                    End If
                    If Convert.ToDecimal(sensor_error) > 0 Then
                        ToolStripStatusLabel1.Text = "Sensor error! To restart, press " & btStartTEC.Text
                        ToolStripStatusLabel1.ForeColor = Color.Red
                        cbTECenable.Enabled = False
                        cp.WriteLine("O" & vbCr)
                        cp.DiscardOutBuffer()
                        cp.DiscardInBuffer()
                        Timer1.Start()
                    End If

                    cbTECenable.Checked = Convert.ToBoolean(Convert.ToInt16(TECenabled))

                    NumericATnoise.Value = Convert.ToDouble(ATnoise)

                    If Algorithm1.Checked Then
                        If (Convert.ToInt16(AT_out) = 1) Then
                            ToolStripStatusLabel1.Text = "Autotune OK"
                            ToolStripStatusLabel1.ForeColor = Color.Green
                        Else
                            ToolStripStatusLabel1.Text = "Autotune tuning..."
                            ToolStripStatusLabel1.ForeColor = Color.OrangeRed
                        End If
                    Else
                        ToolStripStatusLabel1.Text = "Autotune disabled"
                        ToolStripStatusLabel1.ForeColor = Color.Gray
                    End If
                Catch ex As Exception
                    Dim style = MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly Or MsgBoxStyle.ApplicationModal
                    Dim message = ex.Message
                    Dim title = cpName
                    If MsgBox(message, style, title & " Get status") = MsgBoxResult.Ok Then
                        ' Application.Exit()
                    End If
                End Try
                skipEvent = False
            End If



            ' If Convert.ToDecimal(TECrunning) = 0 Then
            'groupTEC.Enabled = False
            'ToolStripStatusLabel1.Text = "TEC idle"
            'ToolStripStatusLabel1.ForeColor = Color.Black
            'Else
            '   groupTEC.Enabled = True

            'End If

        End If

        Timer1.Start()

    End Function

    Private Sub numSetpoint_ValueChanged(sender As Object, e As EventArgs) Handles numSetpoint.ValueChanged
        If skipEvent Then Exit Sub
        Dim commandStr As String = "s " & numSetpoint.Value.ToString() & vbCr
        Timer1.Stop()

        Try
            cp.WriteLine(commandStr)
        Catch ex As Exception

        End Try

        Timer1.Start()

    End Sub

    Private Sub btStartTEC_Click(sender As Object, e As EventArgs) Handles btStartTEC.Click

        cbTECenable.Enabled = True

        Dim commandStr As String = "r" & vbCr
        Timer1.Stop()
        Try
            cp.WriteLine(commandStr)
        Catch

        Finally

        End Try

        Timer1.Start()
    End Sub

    Private Sub Algorithm1_CheckedChanged(sender As Object, e As EventArgs) Handles Algorithm1.CheckedChanged, Algorithm2.CheckedChanged, Algorithm3.CheckedChanged
        If skipEvent Then Exit Sub
        Dim value As Int16 = 0

        If Algorithm1.Checked Then value = 0
        If Algorithm2.Checked Then value = 1
        If Algorithm3.Checked Then value = 2

        Dim commandStr As String = "a " & value.ToString & vbCr

        Timer1.Stop()

        Try
            cp.WriteLine(commandStr)
        Catch

        Finally

        End Try

        Timer1.Start()
    End Sub

    Private Sub NumericKp_ValueChanged(sender As Object, e As EventArgs) Handles NumericKp.ValueChanged
        If skipEvent Then Exit Sub
        Dim commandStr As String = "p " & NumericKp.Value.ToString() & vbCr
        Timer1.Stop()

        Try
            cp.WriteLine(commandStr)
        Catch ex As Exception

        End Try
        Timer1.Start()

    End Sub

    Private Sub NumericKi_ValueChanged(sender As Object, e As EventArgs) Handles NumericKi.ValueChanged
        If skipEvent Then Exit Sub
        Dim commandStr As String = "i " & NumericKi.Value.ToString() & vbCr
        Timer1.Stop()

        Try
            cp.WriteLine(commandStr)
        Catch ex As Exception

        End Try
        Timer1.Start()

    End Sub

    Private Sub NumericKd_ValueChanged(sender As Object, e As EventArgs) Handles NumericKd.ValueChanged
        If skipEvent Then Exit Sub
        Dim commandStr As String = "d " & NumericKd.Value.ToString() & vbCr
        Timer1.Stop()

        Try
            cp.WriteLine(commandStr)
        Catch ex As Exception

        End Try
        Timer1.Start()

    End Sub

    Private Sub NumericATnoise_ValueChanged(sender As Object, e As EventArgs) Handles NumericATnoise.ValueChanged
        If skipEvent Then Exit Sub
        Dim commandStr As String = "n " & NumericATnoise.Value.ToString() & vbCr
        Timer1.Stop()

        Try
            cp.WriteLine(commandStr)
        Catch ex As Exception

        End Try
        Timer1.Start()
    End Sub

    Private Sub NumericHysCool_ValueChanged(sender As Object, e As EventArgs) Handles NumericHysCool.ValueChanged
        If skipEvent Then Exit Sub
        Dim commandStr As String = "c " & NumericHysCool.Value.ToString() & vbCr
        Timer1.Stop()

        Try
            cp.WriteLine(commandStr)
        Catch ex As Exception

        End Try
        Timer1.Start()
    End Sub

    Private Sub NumericHysHeat_ValueChanged(sender As Object, e As EventArgs) Handles NumericHysHeat.ValueChanged
        If skipEvent Then Exit Sub
        Dim commandStr As String = "h " & NumericHysHeat.Value.ToString() & vbCr
        Timer1.Stop()

        Try
            cp.WriteLine(commandStr)
        Catch ex As Exception

        End Try
        Timer1.Start()
    End Sub

    Private Sub cbTECenable_CheckedChanged(sender As Object, e As EventArgs) Handles cbTECenable.CheckedChanged
        If skipEvent Then Exit Sub
        Dim commandStr As String = "e " & Convert.ToString(Convert.ToInt16(cbTECenable.Checked)) & vbCr
        Timer1.Stop()


        Try
            cp.WriteLine(commandStr)
        Catch ex As Exception

        End Try

        Timer1.Start()
    End Sub
End Class
