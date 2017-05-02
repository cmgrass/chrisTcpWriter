<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.txtHostname = New System.Windows.Forms.TextBox()
        Me.lblHostnamePrompt = New System.Windows.Forms.Label()
        Me.lblPortPrompt = New System.Windows.Forms.Label()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.grpConnect = New System.Windows.Forms.GroupBox()
        Me.lblDeviceType = New System.Windows.Forms.Label()
        Me.comboDeviceType = New System.Windows.Forms.ComboBox()
        Me.btnDisconnect = New System.Windows.Forms.Button()
        Me.tmrNetworkStream = New System.Windows.Forms.Timer(Me.components)
        Me.txtReadBuffer = New System.Windows.Forms.TextBox()
        Me.grpRead = New System.Windows.Forms.GroupBox()
        Me.btnSendData = New System.Windows.Forms.Button()
        Me.txtHeaderDeviceType = New System.Windows.Forms.TextBox()
        Me.lblHeaderDeviceType = New System.Windows.Forms.Label()
        Me.grpeFlexHeader = New System.Windows.Forms.GroupBox()
        Me.txtPacketCount = New System.Windows.Forms.TextBox()
        Me.lblPacketCnt = New System.Windows.Forms.Label()
        Me.chkHeaderSeperate = New System.Windows.Forms.CheckBox()
        Me.txtSoftware_07 = New System.Windows.Forms.TextBox()
        Me.txtPacketLength = New System.Windows.Forms.TextBox()
        Me.lblSoftware_07 = New System.Windows.Forms.Label()
        Me.txtSoftware_06 = New System.Windows.Forms.TextBox()
        Me.lblPacketLength = New System.Windows.Forms.Label()
        Me.lblSoftware_06 = New System.Windows.Forms.Label()
        Me.txtSoftware_05 = New System.Windows.Forms.TextBox()
        Me.txtPacketType = New System.Windows.Forms.TextBox()
        Me.lblSoftware_05 = New System.Windows.Forms.Label()
        Me.txtStationID = New System.Windows.Forms.TextBox()
        Me.txtSoftware_04 = New System.Windows.Forms.TextBox()
        Me.lblPacketType = New System.Windows.Forms.Label()
        Me.lblSoftware_04 = New System.Windows.Forms.Label()
        Me.lblStationID = New System.Windows.Forms.Label()
        Me.txtSoftware_00 = New System.Windows.Forms.TextBox()
        Me.lblSoftware_00 = New System.Windows.Forms.Label()
        Me.txtSoftware_03 = New System.Windows.Forms.TextBox()
        Me.lblSoftware_01 = New System.Windows.Forms.Label()
        Me.txtSoftware_01 = New System.Windows.Forms.TextBox()
        Me.lblSoftware_03 = New System.Windows.Forms.Label()
        Me.lblSoftware_02 = New System.Windows.Forms.Label()
        Me.txtSoftware_02 = New System.Windows.Forms.TextBox()
        Me.pnleFlexHeader = New System.Windows.Forms.Panel()
        Me.pnleFlexData = New System.Windows.Forms.Panel()
        Me.grpeFlexData = New System.Windows.Forms.GroupBox()
        Me.grpConnect.SuspendLayout()
        Me.grpRead.SuspendLayout()
        Me.grpeFlexHeader.SuspendLayout()
        Me.pnleFlexHeader.SuspendLayout()
        Me.pnleFlexData.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(85, 99)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(115, 27)
        Me.btnConnect.TabIndex = 4
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'txtHostname
        '
        Me.txtHostname.Location = New System.Drawing.Point(68, 46)
        Me.txtHostname.Name = "txtHostname"
        Me.txtHostname.Size = New System.Drawing.Size(132, 20)
        Me.txtHostname.TabIndex = 2
        '
        'lblHostnamePrompt
        '
        Me.lblHostnamePrompt.AutoSize = True
        Me.lblHostnamePrompt.Location = New System.Drawing.Point(7, 49)
        Me.lblHostnamePrompt.Name = "lblHostnamePrompt"
        Me.lblHostnamePrompt.Size = New System.Drawing.Size(55, 13)
        Me.lblHostnamePrompt.TabIndex = 9
        Me.lblHostnamePrompt.Text = "Hostname"
        '
        'lblPortPrompt
        '
        Me.lblPortPrompt.AutoSize = True
        Me.lblPortPrompt.Location = New System.Drawing.Point(36, 75)
        Me.lblPortPrompt.Name = "lblPortPrompt"
        Me.lblPortPrompt.Size = New System.Drawing.Size(26, 13)
        Me.lblPortPrompt.TabIndex = 10
        Me.lblPortPrompt.Text = "Port"
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(68, 72)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(132, 20)
        Me.txtPort.TabIndex = 3
        '
        'grpConnect
        '
        Me.grpConnect.Controls.Add(Me.lblDeviceType)
        Me.grpConnect.Controls.Add(Me.comboDeviceType)
        Me.grpConnect.Controls.Add(Me.btnDisconnect)
        Me.grpConnect.Controls.Add(Me.txtHostname)
        Me.grpConnect.Controls.Add(Me.lblPortPrompt)
        Me.grpConnect.Controls.Add(Me.btnConnect)
        Me.grpConnect.Controls.Add(Me.txtPort)
        Me.grpConnect.Controls.Add(Me.lblHostnamePrompt)
        Me.grpConnect.Location = New System.Drawing.Point(12, 12)
        Me.grpConnect.Name = "grpConnect"
        Me.grpConnect.Size = New System.Drawing.Size(209, 166)
        Me.grpConnect.TabIndex = 5
        Me.grpConnect.TabStop = False
        Me.grpConnect.Text = "Connection Configuration"
        '
        'lblDeviceType
        '
        Me.lblDeviceType.AutoSize = True
        Me.lblDeviceType.Location = New System.Drawing.Point(21, 22)
        Me.lblDeviceType.Name = "lblDeviceType"
        Me.lblDeviceType.Size = New System.Drawing.Size(41, 13)
        Me.lblDeviceType.TabIndex = 8
        Me.lblDeviceType.Text = "Device"
        '
        'comboDeviceType
        '
        Me.comboDeviceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboDeviceType.FormattingEnabled = True
        Me.comboDeviceType.Items.AddRange(New Object() {"Rockwell TCP/IP", "EtherNetIP Server - Explicit", "Siemens TCP/IP"})
        Me.comboDeviceType.Location = New System.Drawing.Point(68, 19)
        Me.comboDeviceType.Name = "comboDeviceType"
        Me.comboDeviceType.Size = New System.Drawing.Size(132, 21)
        Me.comboDeviceType.TabIndex = 1
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Enabled = False
        Me.btnDisconnect.Location = New System.Drawing.Point(85, 131)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(115, 27)
        Me.btnDisconnect.TabIndex = 5
        Me.btnDisconnect.Text = "Disconnect"
        Me.btnDisconnect.UseVisualStyleBackColor = True
        '
        'tmrNetworkStream
        '
        Me.tmrNetworkStream.Interval = 10
        '
        'txtReadBuffer
        '
        Me.txtReadBuffer.Location = New System.Drawing.Point(6, 19)
        Me.txtReadBuffer.Multiline = True
        Me.txtReadBuffer.Name = "txtReadBuffer"
        Me.txtReadBuffer.ReadOnly = True
        Me.txtReadBuffer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtReadBuffer.Size = New System.Drawing.Size(476, 141)
        Me.txtReadBuffer.TabIndex = 11
        '
        'grpRead
        '
        Me.grpRead.Controls.Add(Me.txtReadBuffer)
        Me.grpRead.Location = New System.Drawing.Point(225, 12)
        Me.grpRead.Name = "grpRead"
        Me.grpRead.Size = New System.Drawing.Size(488, 166)
        Me.grpRead.TabIndex = 10
        Me.grpRead.TabStop = False
        Me.grpRead.Text = "Recieved Data"
        Me.grpRead.Visible = False
        '
        'btnSendData
        '
        Me.btnSendData.Location = New System.Drawing.Point(606, 463)
        Me.btnSendData.Name = "btnSendData"
        Me.btnSendData.Size = New System.Drawing.Size(107, 27)
        Me.btnSendData.TabIndex = 11
        Me.btnSendData.Text = "Send Data"
        Me.btnSendData.UseVisualStyleBackColor = True
        Me.btnSendData.Visible = False
        '
        'txtHeaderDeviceType
        '
        Me.txtHeaderDeviceType.Location = New System.Drawing.Point(89, 19)
        Me.txtHeaderDeviceType.Name = "txtHeaderDeviceType"
        Me.txtHeaderDeviceType.Size = New System.Drawing.Size(68, 20)
        Me.txtHeaderDeviceType.TabIndex = 13
        Me.txtHeaderDeviceType.Text = "2"
        '
        'lblHeaderDeviceType
        '
        Me.lblHeaderDeviceType.AutoSize = True
        Me.lblHeaderDeviceType.Location = New System.Drawing.Point(11, 22)
        Me.lblHeaderDeviceType.Name = "lblHeaderDeviceType"
        Me.lblHeaderDeviceType.Size = New System.Drawing.Size(68, 13)
        Me.lblHeaderDeviceType.TabIndex = 14
        Me.lblHeaderDeviceType.Text = "Device Type"
        '
        'grpeFlexHeader
        '
        Me.grpeFlexHeader.Controls.Add(Me.txtPacketCount)
        Me.grpeFlexHeader.Controls.Add(Me.lblPacketCnt)
        Me.grpeFlexHeader.Controls.Add(Me.chkHeaderSeperate)
        Me.grpeFlexHeader.Controls.Add(Me.txtSoftware_07)
        Me.grpeFlexHeader.Controls.Add(Me.txtPacketLength)
        Me.grpeFlexHeader.Controls.Add(Me.lblSoftware_07)
        Me.grpeFlexHeader.Controls.Add(Me.txtHeaderDeviceType)
        Me.grpeFlexHeader.Controls.Add(Me.txtSoftware_06)
        Me.grpeFlexHeader.Controls.Add(Me.lblPacketLength)
        Me.grpeFlexHeader.Controls.Add(Me.lblSoftware_06)
        Me.grpeFlexHeader.Controls.Add(Me.lblHeaderDeviceType)
        Me.grpeFlexHeader.Controls.Add(Me.txtSoftware_05)
        Me.grpeFlexHeader.Controls.Add(Me.txtPacketType)
        Me.grpeFlexHeader.Controls.Add(Me.lblSoftware_05)
        Me.grpeFlexHeader.Controls.Add(Me.txtStationID)
        Me.grpeFlexHeader.Controls.Add(Me.txtSoftware_04)
        Me.grpeFlexHeader.Controls.Add(Me.lblPacketType)
        Me.grpeFlexHeader.Controls.Add(Me.lblSoftware_04)
        Me.grpeFlexHeader.Controls.Add(Me.lblStationID)
        Me.grpeFlexHeader.Controls.Add(Me.txtSoftware_00)
        Me.grpeFlexHeader.Controls.Add(Me.lblSoftware_00)
        Me.grpeFlexHeader.Controls.Add(Me.txtSoftware_03)
        Me.grpeFlexHeader.Controls.Add(Me.lblSoftware_01)
        Me.grpeFlexHeader.Controls.Add(Me.txtSoftware_01)
        Me.grpeFlexHeader.Controls.Add(Me.lblSoftware_03)
        Me.grpeFlexHeader.Controls.Add(Me.lblSoftware_02)
        Me.grpeFlexHeader.Controls.Add(Me.txtSoftware_02)
        Me.grpeFlexHeader.Location = New System.Drawing.Point(11, 3)
        Me.grpeFlexHeader.Name = "grpeFlexHeader"
        Me.grpeFlexHeader.Size = New System.Drawing.Size(167, 392)
        Me.grpeFlexHeader.TabIndex = 15
        Me.grpeFlexHeader.TabStop = False
        Me.grpeFlexHeader.Text = "eFlex Header"
        Me.grpeFlexHeader.Visible = False
        '
        'txtPacketCount
        '
        Me.txtPacketCount.Location = New System.Drawing.Point(89, 305)
        Me.txtPacketCount.Name = "txtPacketCount"
        Me.txtPacketCount.Size = New System.Drawing.Size(68, 20)
        Me.txtPacketCount.TabIndex = 38
        Me.txtPacketCount.Text = "1"
        '
        'lblPacketCnt
        '
        Me.lblPacketCnt.AutoSize = True
        Me.lblPacketCnt.Location = New System.Drawing.Point(11, 308)
        Me.lblPacketCnt.Name = "lblPacketCnt"
        Me.lblPacketCnt.Size = New System.Drawing.Size(72, 13)
        Me.lblPacketCnt.TabIndex = 39
        Me.lblPacketCnt.Text = "Packet Count"
        '
        'chkHeaderSeperate
        '
        Me.chkHeaderSeperate.AutoSize = True
        Me.chkHeaderSeperate.Location = New System.Drawing.Point(18, 357)
        Me.chkHeaderSeperate.Name = "chkHeaderSeperate"
        Me.chkHeaderSeperate.Size = New System.Drawing.Size(131, 30)
        Me.chkHeaderSeperate.TabIndex = 18
        Me.chkHeaderSeperate.Text = "Send seperate header" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and data packets"
        Me.chkHeaderSeperate.UseVisualStyleBackColor = True
        '
        'txtSoftware_07
        '
        Me.txtSoftware_07.Location = New System.Drawing.Point(89, 253)
        Me.txtSoftware_07.MaxLength = 1
        Me.txtSoftware_07.Name = "txtSoftware_07"
        Me.txtSoftware_07.Size = New System.Drawing.Size(68, 20)
        Me.txtSoftware_07.TabIndex = 36
        Me.txtSoftware_07.Text = "Y"
        '
        'txtPacketLength
        '
        Me.txtPacketLength.Location = New System.Drawing.Point(89, 331)
        Me.txtPacketLength.Name = "txtPacketLength"
        Me.txtPacketLength.Size = New System.Drawing.Size(68, 20)
        Me.txtPacketLength.TabIndex = 22
        Me.txtPacketLength.Text = "2790"
        '
        'lblSoftware_07
        '
        Me.lblSoftware_07.AutoSize = True
        Me.lblSoftware_07.Location = New System.Drawing.Point(11, 256)
        Me.lblSoftware_07.Name = "lblSoftware_07"
        Me.lblSoftware_07.Size = New System.Drawing.Size(61, 13)
        Me.lblSoftware_07.TabIndex = 37
        Me.lblSoftware_07.Text = "Software_7"
        '
        'txtSoftware_06
        '
        Me.txtSoftware_06.Location = New System.Drawing.Point(89, 227)
        Me.txtSoftware_06.MaxLength = 1
        Me.txtSoftware_06.Name = "txtSoftware_06"
        Me.txtSoftware_06.Size = New System.Drawing.Size(68, 20)
        Me.txtSoftware_06.TabIndex = 34
        Me.txtSoftware_06.Text = "T"
        '
        'lblPacketLength
        '
        Me.lblPacketLength.AutoSize = True
        Me.lblPacketLength.Location = New System.Drawing.Point(11, 334)
        Me.lblPacketLength.Name = "lblPacketLength"
        Me.lblPacketLength.Size = New System.Drawing.Size(77, 13)
        Me.lblPacketLength.TabIndex = 23
        Me.lblPacketLength.Text = "Packet Length"
        '
        'lblSoftware_06
        '
        Me.lblSoftware_06.AutoSize = True
        Me.lblSoftware_06.Location = New System.Drawing.Point(11, 230)
        Me.lblSoftware_06.Name = "lblSoftware_06"
        Me.lblSoftware_06.Size = New System.Drawing.Size(61, 13)
        Me.lblSoftware_06.TabIndex = 35
        Me.lblSoftware_06.Text = "Software_6"
        '
        'txtSoftware_05
        '
        Me.txtSoftware_05.Location = New System.Drawing.Point(89, 201)
        Me.txtSoftware_05.MaxLength = 1
        Me.txtSoftware_05.Name = "txtSoftware_05"
        Me.txtSoftware_05.Size = New System.Drawing.Size(68, 20)
        Me.txtSoftware_05.TabIndex = 32
        Me.txtSoftware_05.Text = "I"
        '
        'txtPacketType
        '
        Me.txtPacketType.Location = New System.Drawing.Point(89, 279)
        Me.txtPacketType.Name = "txtPacketType"
        Me.txtPacketType.Size = New System.Drawing.Size(68, 20)
        Me.txtPacketType.TabIndex = 20
        Me.txtPacketType.Text = "2034"
        '
        'lblSoftware_05
        '
        Me.lblSoftware_05.AutoSize = True
        Me.lblSoftware_05.Location = New System.Drawing.Point(11, 204)
        Me.lblSoftware_05.Name = "lblSoftware_05"
        Me.lblSoftware_05.Size = New System.Drawing.Size(61, 13)
        Me.lblSoftware_05.TabIndex = 33
        Me.lblSoftware_05.Text = "Software_5"
        '
        'txtStationID
        '
        Me.txtStationID.Location = New System.Drawing.Point(89, 45)
        Me.txtStationID.Name = "txtStationID"
        Me.txtStationID.Size = New System.Drawing.Size(68, 20)
        Me.txtStationID.TabIndex = 16
        Me.txtStationID.Text = "2017"
        '
        'txtSoftware_04
        '
        Me.txtSoftware_04.Location = New System.Drawing.Point(89, 175)
        Me.txtSoftware_04.MaxLength = 1
        Me.txtSoftware_04.Name = "txtSoftware_04"
        Me.txtSoftware_04.Size = New System.Drawing.Size(68, 20)
        Me.txtSoftware_04.TabIndex = 30
        Me.txtSoftware_04.Text = "L"
        '
        'lblPacketType
        '
        Me.lblPacketType.AutoSize = True
        Me.lblPacketType.Location = New System.Drawing.Point(11, 282)
        Me.lblPacketType.Name = "lblPacketType"
        Me.lblPacketType.Size = New System.Drawing.Size(68, 13)
        Me.lblPacketType.TabIndex = 21
        Me.lblPacketType.Text = "Packet Type"
        '
        'lblSoftware_04
        '
        Me.lblSoftware_04.AutoSize = True
        Me.lblSoftware_04.Location = New System.Drawing.Point(11, 178)
        Me.lblSoftware_04.Name = "lblSoftware_04"
        Me.lblSoftware_04.Size = New System.Drawing.Size(61, 13)
        Me.lblSoftware_04.TabIndex = 31
        Me.lblSoftware_04.Text = "Software_4"
        '
        'lblStationID
        '
        Me.lblStationID.AutoSize = True
        Me.lblStationID.Location = New System.Drawing.Point(11, 48)
        Me.lblStationID.Name = "lblStationID"
        Me.lblStationID.Size = New System.Drawing.Size(54, 13)
        Me.lblStationID.TabIndex = 17
        Me.lblStationID.Text = "Station ID"
        '
        'txtSoftware_00
        '
        Me.txtSoftware_00.Location = New System.Drawing.Point(89, 71)
        Me.txtSoftware_00.MaxLength = 1
        Me.txtSoftware_00.Name = "txtSoftware_00"
        Me.txtSoftware_00.Size = New System.Drawing.Size(68, 20)
        Me.txtSoftware_00.TabIndex = 18
        Me.txtSoftware_00.Text = "E"
        '
        'lblSoftware_00
        '
        Me.lblSoftware_00.AutoSize = True
        Me.lblSoftware_00.Location = New System.Drawing.Point(11, 74)
        Me.lblSoftware_00.Name = "lblSoftware_00"
        Me.lblSoftware_00.Size = New System.Drawing.Size(61, 13)
        Me.lblSoftware_00.TabIndex = 19
        Me.lblSoftware_00.Text = "Software_0"
        '
        'txtSoftware_03
        '
        Me.txtSoftware_03.Location = New System.Drawing.Point(89, 149)
        Me.txtSoftware_03.MaxLength = 1
        Me.txtSoftware_03.Name = "txtSoftware_03"
        Me.txtSoftware_03.Size = New System.Drawing.Size(68, 20)
        Me.txtSoftware_03.TabIndex = 28
        Me.txtSoftware_03.Text = "A"
        '
        'lblSoftware_01
        '
        Me.lblSoftware_01.AutoSize = True
        Me.lblSoftware_01.Location = New System.Drawing.Point(11, 100)
        Me.lblSoftware_01.Name = "lblSoftware_01"
        Me.lblSoftware_01.Size = New System.Drawing.Size(61, 13)
        Me.lblSoftware_01.TabIndex = 25
        Me.lblSoftware_01.Text = "Software_1"
        '
        'txtSoftware_01
        '
        Me.txtSoftware_01.Location = New System.Drawing.Point(89, 97)
        Me.txtSoftware_01.MaxLength = 1
        Me.txtSoftware_01.Name = "txtSoftware_01"
        Me.txtSoftware_01.Size = New System.Drawing.Size(68, 20)
        Me.txtSoftware_01.TabIndex = 24
        Me.txtSoftware_01.Text = "Q"
        '
        'lblSoftware_03
        '
        Me.lblSoftware_03.AutoSize = True
        Me.lblSoftware_03.Location = New System.Drawing.Point(11, 152)
        Me.lblSoftware_03.Name = "lblSoftware_03"
        Me.lblSoftware_03.Size = New System.Drawing.Size(61, 13)
        Me.lblSoftware_03.TabIndex = 29
        Me.lblSoftware_03.Text = "Software_3"
        '
        'lblSoftware_02
        '
        Me.lblSoftware_02.AutoSize = True
        Me.lblSoftware_02.Location = New System.Drawing.Point(11, 126)
        Me.lblSoftware_02.Name = "lblSoftware_02"
        Me.lblSoftware_02.Size = New System.Drawing.Size(61, 13)
        Me.lblSoftware_02.TabIndex = 27
        Me.lblSoftware_02.Text = "Software_2"
        '
        'txtSoftware_02
        '
        Me.txtSoftware_02.Location = New System.Drawing.Point(89, 123)
        Me.txtSoftware_02.MaxLength = 1
        Me.txtSoftware_02.Name = "txtSoftware_02"
        Me.txtSoftware_02.Size = New System.Drawing.Size(68, 20)
        Me.txtSoftware_02.TabIndex = 26
        Me.txtSoftware_02.Text = "U"
        '
        'pnleFlexHeader
        '
        Me.pnleFlexHeader.AutoScroll = True
        Me.pnleFlexHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnleFlexHeader.Controls.Add(Me.grpeFlexHeader)
        Me.pnleFlexHeader.Location = New System.Drawing.Point(12, 180)
        Me.pnleFlexHeader.Name = "pnleFlexHeader"
        Me.pnleFlexHeader.Size = New System.Drawing.Size(209, 280)
        Me.pnleFlexHeader.TabIndex = 16
        Me.pnleFlexHeader.Visible = False
        '
        'pnleFlexData
        '
        Me.pnleFlexData.AutoScroll = True
        Me.pnleFlexData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnleFlexData.Controls.Add(Me.grpeFlexData)
        Me.pnleFlexData.Location = New System.Drawing.Point(225, 180)
        Me.pnleFlexData.Name = "pnleFlexData"
        Me.pnleFlexData.Size = New System.Drawing.Size(488, 280)
        Me.pnleFlexData.TabIndex = 17
        Me.pnleFlexData.Visible = False
        '
        'grpeFlexData
        '
        Me.grpeFlexData.Location = New System.Drawing.Point(5, 3)
        Me.grpeFlexData.Name = "grpeFlexData"
        Me.grpeFlexData.Size = New System.Drawing.Size(460, 323)
        Me.grpeFlexData.TabIndex = 15
        Me.grpeFlexData.TabStop = False
        Me.grpeFlexData.Text = "Data to Write"
        Me.grpeFlexData.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 496)
        Me.Controls.Add(Me.pnleFlexData)
        Me.Controls.Add(Me.btnSendData)
        Me.Controls.Add(Me.pnleFlexHeader)
        Me.Controls.Add(Me.grpRead)
        Me.Controls.Add(Me.grpConnect)
        Me.Name = "frmMain"
        Me.Text = "Christopher's TnT Server Simulator"
        Me.grpConnect.ResumeLayout(False)
        Me.grpConnect.PerformLayout()
        Me.grpRead.ResumeLayout(False)
        Me.grpRead.PerformLayout()
        Me.grpeFlexHeader.ResumeLayout(False)
        Me.grpeFlexHeader.PerformLayout()
        Me.pnleFlexHeader.ResumeLayout(False)
        Me.pnleFlexData.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents txtHostname As System.Windows.Forms.TextBox
    Friend WithEvents lblHostnamePrompt As System.Windows.Forms.Label
    Friend WithEvents lblPortPrompt As System.Windows.Forms.Label
    Friend WithEvents txtPort As System.Windows.Forms.TextBox
    Friend WithEvents grpConnect As System.Windows.Forms.GroupBox
    Friend WithEvents btnDisconnect As System.Windows.Forms.Button
    Friend WithEvents lblDeviceType As System.Windows.Forms.Label
    Friend WithEvents comboDeviceType As System.Windows.Forms.ComboBox
    Friend WithEvents tmrNetworkStream As System.Windows.Forms.Timer
    Friend WithEvents txtReadBuffer As System.Windows.Forms.TextBox
    Friend WithEvents grpRead As System.Windows.Forms.GroupBox
    Friend WithEvents btnSendData As System.Windows.Forms.Button
    Friend WithEvents txtHeaderDeviceType As System.Windows.Forms.TextBox
    Friend WithEvents lblHeaderDeviceType As System.Windows.Forms.Label
    Friend WithEvents grpeFlexHeader As System.Windows.Forms.GroupBox
    Friend WithEvents txtPacketLength As System.Windows.Forms.TextBox
    Friend WithEvents lblPacketLength As System.Windows.Forms.Label
    Friend WithEvents txtPacketType As System.Windows.Forms.TextBox
    Friend WithEvents txtStationID As System.Windows.Forms.TextBox
    Friend WithEvents lblPacketType As System.Windows.Forms.Label
    Friend WithEvents lblStationID As System.Windows.Forms.Label
    Friend WithEvents txtSoftware_00 As System.Windows.Forms.TextBox
    Friend WithEvents lblSoftware_00 As System.Windows.Forms.Label
    Friend WithEvents txtSoftware_04 As System.Windows.Forms.TextBox
    Friend WithEvents lblSoftware_04 As System.Windows.Forms.Label
    Friend WithEvents txtSoftware_03 As System.Windows.Forms.TextBox
    Friend WithEvents lblSoftware_03 As System.Windows.Forms.Label
    Friend WithEvents txtSoftware_02 As System.Windows.Forms.TextBox
    Friend WithEvents lblSoftware_02 As System.Windows.Forms.Label
    Friend WithEvents txtSoftware_01 As System.Windows.Forms.TextBox
    Friend WithEvents lblSoftware_01 As System.Windows.Forms.Label
    Friend WithEvents pnleFlexHeader As System.Windows.Forms.Panel
    Friend WithEvents txtSoftware_07 As System.Windows.Forms.TextBox
    Friend WithEvents lblSoftware_07 As System.Windows.Forms.Label
    Friend WithEvents txtSoftware_06 As System.Windows.Forms.TextBox
    Friend WithEvents lblSoftware_06 As System.Windows.Forms.Label
    Friend WithEvents txtSoftware_05 As System.Windows.Forms.TextBox
    Friend WithEvents lblSoftware_05 As System.Windows.Forms.Label
    Friend WithEvents pnleFlexData As System.Windows.Forms.Panel
    Friend WithEvents grpeFlexData As System.Windows.Forms.GroupBox
    Friend WithEvents chkHeaderSeperate As System.Windows.Forms.CheckBox
    Friend WithEvents txtPacketCount As TextBox
    Friend WithEvents lblPacketCnt As Label
End Class
