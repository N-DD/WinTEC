<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TEC
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
        Me.cbSerialPorts = New System.Windows.Forms.ComboBox()
        Me.btList = New System.Windows.Forms.Button()
        Me.btConnect = New System.Windows.Forms.Button()
        Me.numSetpoint = New System.Windows.Forms.NumericUpDown()
        Me.groupTEC = New System.Windows.Forms.GroupBox()
        Me.GroupONOFF = New System.Windows.Forms.GroupBox()
        Me.NumericHysHeat = New System.Windows.Forms.NumericUpDown()
        Me.NumericHysCool = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.GroupAT = New System.Windows.Forms.GroupBox()
        Me.NumericATnoise = New System.Windows.Forms.NumericUpDown()
        Me.ATnoise = New System.Windows.Forms.Label()
        Me.GroupPID = New System.Windows.Forms.GroupBox()
        Me.NumericKd = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumericKi = New System.Windows.Forms.NumericUpDown()
        Me.NumericKp = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Algorithm3 = New System.Windows.Forms.RadioButton()
        Me.Algorithm2 = New System.Windows.Forms.RadioButton()
        Me.Algorithm1 = New System.Windows.Forms.RadioButton()
        Me.SensorsT2 = New System.Windows.Forms.NumericUpDown()
        Me.SensorsT1 = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btStop = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btStartTEC = New System.Windows.Forms.Button()
        Me.cbTECenable = New System.Windows.Forms.CheckBox()
        CType(Me.numSetpoint, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupTEC.SuspendLayout()
        Me.GroupONOFF.SuspendLayout()
        CType(Me.NumericHysHeat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericHysCool, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupAT.SuspendLayout()
        CType(Me.NumericATnoise, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPID.SuspendLayout()
        CType(Me.NumericKd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericKi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericKp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SensorsT2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SensorsT1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbSerialPorts
        '
        Me.cbSerialPorts.Enabled = False
        Me.cbSerialPorts.FormattingEnabled = True
        Me.cbSerialPorts.Location = New System.Drawing.Point(12, 12)
        Me.cbSerialPorts.Name = "cbSerialPorts"
        Me.cbSerialPorts.Size = New System.Drawing.Size(75, 21)
        Me.cbSerialPorts.TabIndex = 1
        '
        'btList
        '
        Me.btList.Location = New System.Drawing.Point(101, 12)
        Me.btList.Name = "btList"
        Me.btList.Size = New System.Drawing.Size(75, 23)
        Me.btList.TabIndex = 2
        Me.btList.Text = "Refresh"
        Me.btList.UseVisualStyleBackColor = True
        '
        'btConnect
        '
        Me.btConnect.Enabled = False
        Me.btConnect.Location = New System.Drawing.Point(12, 39)
        Me.btConnect.Name = "btConnect"
        Me.btConnect.Size = New System.Drawing.Size(75, 23)
        Me.btConnect.TabIndex = 3
        Me.btConnect.Text = "Connect"
        Me.btConnect.UseVisualStyleBackColor = True
        '
        'numSetpoint
        '
        Me.numSetpoint.DecimalPlaces = 1
        Me.numSetpoint.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numSetpoint.Location = New System.Drawing.Point(58, 14)
        Me.numSetpoint.Maximum = New Decimal(New Integer() {40, 0, 0, 0})
        Me.numSetpoint.Minimum = New Decimal(New Integer() {40, 0, 0, -2147483648})
        Me.numSetpoint.Name = "numSetpoint"
        Me.numSetpoint.Size = New System.Drawing.Size(50, 20)
        Me.numSetpoint.TabIndex = 5
        Me.numSetpoint.Tag = "Setpoint in C"
        Me.numSetpoint.Value = New Decimal(New Integer() {10, 0, 0, -2147483648})
        '
        'groupTEC
        '
        Me.groupTEC.Controls.Add(Me.GroupONOFF)
        Me.groupTEC.Controls.Add(Me.StatusStrip1)
        Me.groupTEC.Controls.Add(Me.GroupAT)
        Me.groupTEC.Controls.Add(Me.GroupPID)
        Me.groupTEC.Controls.Add(Me.GroupBox1)
        Me.groupTEC.Controls.Add(Me.SensorsT2)
        Me.groupTEC.Controls.Add(Me.SensorsT1)
        Me.groupTEC.Controls.Add(Me.Label1)
        Me.groupTEC.Controls.Add(Me.numSetpoint)
        Me.groupTEC.Controls.Add(Me.GroupBox2)
        Me.groupTEC.Location = New System.Drawing.Point(17, 70)
        Me.groupTEC.Name = "groupTEC"
        Me.groupTEC.Size = New System.Drawing.Size(247, 300)
        Me.groupTEC.TabIndex = 6
        Me.groupTEC.TabStop = False
        Me.groupTEC.Text = "TEC"
        '
        'GroupONOFF
        '
        Me.GroupONOFF.Controls.Add(Me.NumericHysHeat)
        Me.GroupONOFF.Controls.Add(Me.NumericHysCool)
        Me.GroupONOFF.Controls.Add(Me.Label8)
        Me.GroupONOFF.Controls.Add(Me.Label7)
        Me.GroupONOFF.Location = New System.Drawing.Point(137, 171)
        Me.GroupONOFF.Name = "GroupONOFF"
        Me.GroupONOFF.Size = New System.Drawing.Size(94, 77)
        Me.GroupONOFF.TabIndex = 22
        Me.GroupONOFF.TabStop = False
        Me.GroupONOFF.Text = "ON/OFF"
        '
        'NumericHysHeat
        '
        Me.NumericHysHeat.DecimalPlaces = 1
        Me.NumericHysHeat.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericHysHeat.Location = New System.Drawing.Point(36, 45)
        Me.NumericHysHeat.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.NumericHysHeat.Minimum = New Decimal(New Integer() {50, 0, 0, -2147483648})
        Me.NumericHysHeat.Name = "NumericHysHeat"
        Me.NumericHysHeat.Size = New System.Drawing.Size(50, 20)
        Me.NumericHysHeat.TabIndex = 7
        Me.NumericHysHeat.Tag = "ON/OFF heating hysteresis"
        '
        'NumericHysCool
        '
        Me.NumericHysCool.DecimalPlaces = 1
        Me.NumericHysCool.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericHysCool.Location = New System.Drawing.Point(36, 19)
        Me.NumericHysCool.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.NumericHysCool.Minimum = New Decimal(New Integer() {50, 0, 0, -2147483648})
        Me.NumericHysCool.Name = "NumericHysCool"
        Me.NumericHysCool.Size = New System.Drawing.Size(50, 20)
        Me.NumericHysCool.TabIndex = 7
        Me.NumericHysCool.Tag = "ON/OFF cooling hysteresis"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Hh"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(21, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Hc"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(3, 253)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(241, 44)
        Me.StatusStrip1.TabIndex = 21
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(98, 39)
        Me.ToolStripStatusLabel1.Text = "TEC not connected"
        Me.ToolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripProgressBar1.AutoSize = False
        Me.ToolStripProgressBar1.Maximum = 255
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(120, 38)
        Me.ToolStripProgressBar1.Step = 1
        '
        'GroupAT
        '
        Me.GroupAT.Controls.Add(Me.NumericATnoise)
        Me.GroupAT.Controls.Add(Me.ATnoise)
        Me.GroupAT.Location = New System.Drawing.Point(132, 108)
        Me.GroupAT.Name = "GroupAT"
        Me.GroupAT.Size = New System.Drawing.Size(100, 55)
        Me.GroupAT.TabIndex = 20
        Me.GroupAT.TabStop = False
        Me.GroupAT.Text = "Autotune"
        '
        'NumericATnoise
        '
        Me.NumericATnoise.DecimalPlaces = 1
        Me.NumericATnoise.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericATnoise.Location = New System.Drawing.Point(41, 21)
        Me.NumericATnoise.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumericATnoise.Name = "NumericATnoise"
        Me.NumericATnoise.Size = New System.Drawing.Size(50, 20)
        Me.NumericATnoise.TabIndex = 5
        Me.NumericATnoise.Tag = "Noise level for autotune"
        '
        'ATnoise
        '
        Me.ATnoise.AutoSize = True
        Me.ATnoise.Location = New System.Drawing.Point(9, 23)
        Me.ATnoise.Name = "ATnoise"
        Me.ATnoise.Size = New System.Drawing.Size(34, 13)
        Me.ATnoise.TabIndex = 6
        Me.ATnoise.Text = "Noise"
        '
        'GroupPID
        '
        Me.GroupPID.Controls.Add(Me.NumericKd)
        Me.GroupPID.Controls.Add(Me.Label6)
        Me.GroupPID.Controls.Add(Me.Label3)
        Me.GroupPID.Controls.Add(Me.Label2)
        Me.GroupPID.Controls.Add(Me.NumericKi)
        Me.GroupPID.Controls.Add(Me.NumericKp)
        Me.GroupPID.Location = New System.Drawing.Point(12, 129)
        Me.GroupPID.Name = "GroupPID"
        Me.GroupPID.Size = New System.Drawing.Size(114, 119)
        Me.GroupPID.TabIndex = 19
        Me.GroupPID.TabStop = False
        Me.GroupPID.Text = "PID"
        '
        'NumericKd
        '
        Me.NumericKd.DecimalPlaces = 1
        Me.NumericKd.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericKd.Location = New System.Drawing.Point(49, 87)
        Me.NumericKd.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.NumericKd.Name = "NumericKd"
        Me.NumericKd.ReadOnly = True
        Me.NumericKd.Size = New System.Drawing.Size(50, 20)
        Me.NumericKd.TabIndex = 7
        Me.NumericKd.Tag = "Derivative gain"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Kd"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Ki"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Kp"
        '
        'NumericKi
        '
        Me.NumericKi.DecimalPlaces = 1
        Me.NumericKi.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericKi.Location = New System.Drawing.Point(49, 54)
        Me.NumericKi.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.NumericKi.Name = "NumericKi"
        Me.NumericKi.ReadOnly = True
        Me.NumericKi.Size = New System.Drawing.Size(50, 20)
        Me.NumericKi.TabIndex = 7
        Me.NumericKi.Tag = "Integral gain"
        '
        'NumericKp
        '
        Me.NumericKp.DecimalPlaces = 1
        Me.NumericKp.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericKp.Location = New System.Drawing.Point(49, 21)
        Me.NumericKp.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.NumericKp.Name = "NumericKp"
        Me.NumericKp.ReadOnly = True
        Me.NumericKp.Size = New System.Drawing.Size(50, 20)
        Me.NumericKp.TabIndex = 7
        Me.NumericKp.Tag = "Proportional gain"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Algorithm3)
        Me.GroupBox1.Controls.Add(Me.Algorithm2)
        Me.GroupBox1.Controls.Add(Me.Algorithm1)
        Me.GroupBox1.Location = New System.Drawing.Point(132, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(104, 93)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Algorithm"
        '
        'Algorithm3
        '
        Me.Algorithm3.AutoSize = True
        Me.Algorithm3.Location = New System.Drawing.Point(8, 69)
        Me.Algorithm3.Name = "Algorithm3"
        Me.Algorithm3.Size = New System.Drawing.Size(66, 17)
        Me.Algorithm3.TabIndex = 10
        Me.Algorithm3.Text = "ON/OFF"
        Me.Algorithm3.UseVisualStyleBackColor = True
        '
        'Algorithm2
        '
        Me.Algorithm2.AutoSize = True
        Me.Algorithm2.Location = New System.Drawing.Point(8, 46)
        Me.Algorithm2.Name = "Algorithm2"
        Me.Algorithm2.Size = New System.Drawing.Size(43, 17)
        Me.Algorithm2.TabIndex = 9
        Me.Algorithm2.Text = "PID"
        Me.Algorithm2.UseVisualStyleBackColor = True
        '
        'Algorithm1
        '
        Me.Algorithm1.AutoSize = True
        Me.Algorithm1.Checked = True
        Me.Algorithm1.Location = New System.Drawing.Point(8, 22)
        Me.Algorithm1.Name = "Algorithm1"
        Me.Algorithm1.Size = New System.Drawing.Size(68, 17)
        Me.Algorithm1.TabIndex = 8
        Me.Algorithm1.TabStop = True
        Me.Algorithm1.Text = "Autotune"
        Me.Algorithm1.UseVisualStyleBackColor = True
        '
        'SensorsT2
        '
        Me.SensorsT2.DecimalPlaces = 1
        Me.SensorsT2.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.SensorsT2.Location = New System.Drawing.Point(57, 83)
        Me.SensorsT2.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.SensorsT2.Name = "SensorsT2"
        Me.SensorsT2.ReadOnly = True
        Me.SensorsT2.Size = New System.Drawing.Size(50, 20)
        Me.SensorsT2.TabIndex = 7
        Me.SensorsT2.Tag = "External temperature"
        '
        'SensorsT1
        '
        Me.SensorsT1.DecimalPlaces = 1
        Me.SensorsT1.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.SensorsT1.Location = New System.Drawing.Point(57, 57)
        Me.SensorsT1.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.SensorsT1.Name = "SensorsT1"
        Me.SensorsT1.ReadOnly = True
        Me.SensorsT1.Size = New System.Drawing.Size(50, 20)
        Me.SensorsT1.TabIndex = 7
        Me.SensorsT1.Tag = "Sensor temperature"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Setpoint"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 39)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(114, 84)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sensors"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "T2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "T1"
        '
        'btStop
        '
        Me.btStop.Enabled = False
        Me.btStop.Location = New System.Drawing.Point(188, 39)
        Me.btStop.Name = "btStop"
        Me.btStop.Size = New System.Drawing.Size(75, 23)
        Me.btStop.TabIndex = 0
        Me.btStop.Text = "Stop"
        Me.btStop.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'btStartTEC
        '
        Me.btStartTEC.Enabled = False
        Me.btStartTEC.Location = New System.Drawing.Point(188, 12)
        Me.btStartTEC.Name = "btStartTEC"
        Me.btStartTEC.Size = New System.Drawing.Size(75, 23)
        Me.btStartTEC.TabIndex = 3
        Me.btStartTEC.Text = "Start TEC"
        Me.btStartTEC.UseVisualStyleBackColor = True
        '
        'cbTECenable
        '
        Me.cbTECenable.AutoSize = True
        Me.cbTECenable.Enabled = False
        Me.cbTECenable.Location = New System.Drawing.Point(94, 42)
        Me.cbTECenable.Name = "cbTECenable"
        Me.cbTECenable.Size = New System.Drawing.Size(83, 17)
        Me.cbTECenable.TabIndex = 7
        Me.cbTECenable.Text = "Enable TEC"
        Me.cbTECenable.UseVisualStyleBackColor = True
        '
        'TEC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(287, 373)
        Me.Controls.Add(Me.cbTECenable)
        Me.Controls.Add(Me.btStop)
        Me.Controls.Add(Me.btStartTEC)
        Me.Controls.Add(Me.btConnect)
        Me.Controls.Add(Me.btList)
        Me.Controls.Add(Me.cbSerialPorts)
        Me.Controls.Add(Me.groupTEC)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(295, 400)
        Me.MinimumSize = New System.Drawing.Size(295, 400)
        Me.Name = "TEC"
        Me.Text = "WinTEC"
        CType(Me.numSetpoint, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupTEC.ResumeLayout(False)
        Me.groupTEC.PerformLayout()
        Me.GroupONOFF.ResumeLayout(False)
        Me.GroupONOFF.PerformLayout()
        CType(Me.NumericHysHeat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericHysCool, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupAT.ResumeLayout(False)
        Me.GroupAT.PerformLayout()
        CType(Me.NumericATnoise, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPID.ResumeLayout(False)
        Me.GroupPID.PerformLayout()
        CType(Me.NumericKd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericKi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericKp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SensorsT2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SensorsT1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbSerialPorts As ComboBox
    Friend WithEvents btList As Button
    Friend WithEvents btConnect As Button
    Friend WithEvents numSetpoint As NumericUpDown
    Friend WithEvents groupTEC As GroupBox
    Friend WithEvents SensorsT2 As NumericUpDown
    Friend WithEvents SensorsT1 As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents btStop As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Algorithm1 As RadioButton
    Friend WithEvents Algorithm3 As RadioButton
    Friend WithEvents Algorithm2 As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents NumericKp As NumericUpDown
    Friend WithEvents NumericKi As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents NumericKd As NumericUpDown
    Friend WithEvents GroupPID As GroupBox
    Friend WithEvents GroupAT As GroupBox
    Friend WithEvents NumericATnoise As NumericUpDown
    Friend WithEvents ATnoise As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents GroupONOFF As GroupBox
    Friend WithEvents NumericHysHeat As NumericUpDown
    Friend WithEvents NumericHysCool As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btStartTEC As Button
    Friend WithEvents cbTECenable As CheckBox
End Class
