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
        Me.chkSpare_31 = New System.Windows.Forms.CheckBox()
        Me.chkSpare_30 = New System.Windows.Forms.CheckBox()
        Me.chkSpare_29 = New System.Windows.Forms.CheckBox()
        Me.chkSpare_28 = New System.Windows.Forms.CheckBox()
        Me.chkSpare_27 = New System.Windows.Forms.CheckBox()
        Me.chkSpare_26 = New System.Windows.Forms.CheckBox()
        Me.chkSpare_25 = New System.Windows.Forms.CheckBox()
        Me.chkSpare_24 = New System.Windows.Forms.CheckBox()
        Me.chkChildPrereqNOK = New System.Windows.Forms.CheckBox()
        Me.chkToteMaxCycles = New System.Windows.Forms.CheckBox()
        Me.chkWrongPartForModel = New System.Windows.Forms.CheckBox()
        Me.chkNotRequired = New System.Windows.Forms.CheckBox()
        Me.chkWrongPartForSeparation = New System.Windows.Forms.CheckBox()
        Me.chkPartSeparatedOkay = New System.Windows.Forms.CheckBox()
        Me.chkRecievedSNStatus = New System.Windows.Forms.CheckBox()
        Me.chkMasterSNRFIDready = New System.Windows.Forms.CheckBox()
        Me.chkPrereqNotMet = New System.Windows.Forms.CheckBox()
        Me.chkInvalidPacket = New System.Windows.Forms.CheckBox()
        Me.chkConfigError = New System.Windows.Forms.CheckBox()
        Me.chkPartAlreadyRan = New System.Windows.Forms.CheckBox()
        Me.chkServerError = New System.Windows.Forms.CheckBox()
        Me.chkChildNotFound = New System.Windows.Forms.CheckBox()
        Me.chkPartNotFound = New System.Windows.Forms.CheckBox()
        Me.chkIncorrectPNmarg = New System.Windows.Forms.CheckBox()
        Me.chkChiledRejectedSubSys = New System.Windows.Forms.CheckBox()
        Me.chkParentRejected = New System.Windows.Forms.CheckBox()
        Me.chkChildContained = New System.Windows.Forms.CheckBox()
        Me.chkParentContained = New System.Windows.Forms.CheckBox()
        Me.chkChildPrevMarg = New System.Windows.Forms.CheckBox()
        Me.chkPartDivorced = New System.Windows.Forms.CheckBox()
        Me.chkPartMarried = New System.Windows.Forms.CheckBox()
        Me.chkPartOkay = New System.Windows.Forms.CheckBox()
        Me.rdoTnT2000 = New System.Windows.Forms.RadioButton()
        Me.grpConnect.SuspendLayout()
        Me.grpRead.SuspendLayout()
        Me.grpeFlexHeader.SuspendLayout()
        Me.pnleFlexHeader.SuspendLayout()
        Me.pnleFlexData.SuspendLayout()
        Me.grpeFlexData.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(170, 190)
        Me.btnConnect.Margin = New System.Windows.Forms.Padding(6)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(230, 52)
        Me.btnConnect.TabIndex = 4
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'txtHostname
        '
        Me.txtHostname.Location = New System.Drawing.Point(136, 88)
        Me.txtHostname.Margin = New System.Windows.Forms.Padding(6)
        Me.txtHostname.Name = "txtHostname"
        Me.txtHostname.Size = New System.Drawing.Size(260, 31)
        Me.txtHostname.TabIndex = 2
        '
        'lblHostnamePrompt
        '
        Me.lblHostnamePrompt.AutoSize = True
        Me.lblHostnamePrompt.Location = New System.Drawing.Point(14, 94)
        Me.lblHostnamePrompt.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblHostnamePrompt.Name = "lblHostnamePrompt"
        Me.lblHostnamePrompt.Size = New System.Drawing.Size(109, 25)
        Me.lblHostnamePrompt.TabIndex = 9
        Me.lblHostnamePrompt.Text = "Hostname"
        '
        'lblPortPrompt
        '
        Me.lblPortPrompt.AutoSize = True
        Me.lblPortPrompt.Location = New System.Drawing.Point(72, 144)
        Me.lblPortPrompt.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblPortPrompt.Name = "lblPortPrompt"
        Me.lblPortPrompt.Size = New System.Drawing.Size(51, 25)
        Me.lblPortPrompt.TabIndex = 10
        Me.lblPortPrompt.Text = "Port"
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(136, 138)
        Me.txtPort.Margin = New System.Windows.Forms.Padding(6)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(260, 31)
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
        Me.grpConnect.Location = New System.Drawing.Point(24, 23)
        Me.grpConnect.Margin = New System.Windows.Forms.Padding(6)
        Me.grpConnect.Name = "grpConnect"
        Me.grpConnect.Padding = New System.Windows.Forms.Padding(6)
        Me.grpConnect.Size = New System.Drawing.Size(418, 319)
        Me.grpConnect.TabIndex = 5
        Me.grpConnect.TabStop = False
        Me.grpConnect.Text = "Connection Configuration"
        '
        'lblDeviceType
        '
        Me.lblDeviceType.AutoSize = True
        Me.lblDeviceType.Location = New System.Drawing.Point(42, 42)
        Me.lblDeviceType.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblDeviceType.Name = "lblDeviceType"
        Me.lblDeviceType.Size = New System.Drawing.Size(78, 25)
        Me.lblDeviceType.TabIndex = 8
        Me.lblDeviceType.Text = "Device"
        '
        'comboDeviceType
        '
        Me.comboDeviceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboDeviceType.FormattingEnabled = True
        Me.comboDeviceType.Items.AddRange(New Object() {"Rockwell TCP/IP", "EtherNetIP Server - Explicit", "Siemens TCP/IP"})
        Me.comboDeviceType.Location = New System.Drawing.Point(136, 37)
        Me.comboDeviceType.Margin = New System.Windows.Forms.Padding(6)
        Me.comboDeviceType.Name = "comboDeviceType"
        Me.comboDeviceType.Size = New System.Drawing.Size(260, 33)
        Me.comboDeviceType.TabIndex = 1
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Enabled = False
        Me.btnDisconnect.Location = New System.Drawing.Point(170, 252)
        Me.btnDisconnect.Margin = New System.Windows.Forms.Padding(6)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(230, 52)
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
        Me.txtReadBuffer.Location = New System.Drawing.Point(12, 37)
        Me.txtReadBuffer.Margin = New System.Windows.Forms.Padding(6)
        Me.txtReadBuffer.Multiline = True
        Me.txtReadBuffer.Name = "txtReadBuffer"
        Me.txtReadBuffer.ReadOnly = True
        Me.txtReadBuffer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtReadBuffer.Size = New System.Drawing.Size(948, 267)
        Me.txtReadBuffer.TabIndex = 11
        '
        'grpRead
        '
        Me.grpRead.Controls.Add(Me.txtReadBuffer)
        Me.grpRead.Location = New System.Drawing.Point(450, 23)
        Me.grpRead.Margin = New System.Windows.Forms.Padding(6)
        Me.grpRead.Name = "grpRead"
        Me.grpRead.Padding = New System.Windows.Forms.Padding(6)
        Me.grpRead.Size = New System.Drawing.Size(976, 319)
        Me.grpRead.TabIndex = 10
        Me.grpRead.TabStop = False
        Me.grpRead.Text = "Recieved Data"
        Me.grpRead.Visible = False
        '
        'btnSendData
        '
        Me.btnSendData.Location = New System.Drawing.Point(1212, 890)
        Me.btnSendData.Margin = New System.Windows.Forms.Padding(6)
        Me.btnSendData.Name = "btnSendData"
        Me.btnSendData.Size = New System.Drawing.Size(214, 52)
        Me.btnSendData.TabIndex = 11
        Me.btnSendData.Text = "Send Data"
        Me.btnSendData.UseVisualStyleBackColor = True
        Me.btnSendData.Visible = False
        '
        'txtHeaderDeviceType
        '
        Me.txtHeaderDeviceType.Location = New System.Drawing.Point(178, 37)
        Me.txtHeaderDeviceType.Margin = New System.Windows.Forms.Padding(6)
        Me.txtHeaderDeviceType.Name = "txtHeaderDeviceType"
        Me.txtHeaderDeviceType.Size = New System.Drawing.Size(132, 31)
        Me.txtHeaderDeviceType.TabIndex = 13
        Me.txtHeaderDeviceType.Text = "4"
        '
        'lblHeaderDeviceType
        '
        Me.lblHeaderDeviceType.AutoSize = True
        Me.lblHeaderDeviceType.Location = New System.Drawing.Point(22, 42)
        Me.lblHeaderDeviceType.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblHeaderDeviceType.Name = "lblHeaderDeviceType"
        Me.lblHeaderDeviceType.Size = New System.Drawing.Size(132, 25)
        Me.lblHeaderDeviceType.TabIndex = 14
        Me.lblHeaderDeviceType.Text = "Device Type"
        '
        'grpeFlexHeader
        '
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
        Me.grpeFlexHeader.Location = New System.Drawing.Point(22, 6)
        Me.grpeFlexHeader.Margin = New System.Windows.Forms.Padding(6)
        Me.grpeFlexHeader.Name = "grpeFlexHeader"
        Me.grpeFlexHeader.Padding = New System.Windows.Forms.Padding(6)
        Me.grpeFlexHeader.Size = New System.Drawing.Size(334, 706)
        Me.grpeFlexHeader.TabIndex = 15
        Me.grpeFlexHeader.TabStop = False
        Me.grpeFlexHeader.Text = "eFlex Header"
        Me.grpeFlexHeader.Visible = False
        '
        'chkHeaderSeperate
        '
        Me.chkHeaderSeperate.AutoSize = True
        Me.chkHeaderSeperate.Location = New System.Drawing.Point(36, 637)
        Me.chkHeaderSeperate.Margin = New System.Windows.Forms.Padding(6)
        Me.chkHeaderSeperate.Name = "chkHeaderSeperate"
        Me.chkHeaderSeperate.Size = New System.Drawing.Size(257, 54)
        Me.chkHeaderSeperate.TabIndex = 18
        Me.chkHeaderSeperate.Text = "Send seperate header" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and data packets"
        Me.chkHeaderSeperate.UseVisualStyleBackColor = True
        '
        'txtSoftware_07
        '
        Me.txtSoftware_07.Location = New System.Drawing.Point(178, 487)
        Me.txtSoftware_07.Margin = New System.Windows.Forms.Padding(6)
        Me.txtSoftware_07.MaxLength = 1
        Me.txtSoftware_07.Name = "txtSoftware_07"
        Me.txtSoftware_07.Size = New System.Drawing.Size(132, 31)
        Me.txtSoftware_07.TabIndex = 36
        Me.txtSoftware_07.Text = "Y"
        '
        'txtPacketLength
        '
        Me.txtPacketLength.Location = New System.Drawing.Point(178, 585)
        Me.txtPacketLength.Margin = New System.Windows.Forms.Padding(6)
        Me.txtPacketLength.Name = "txtPacketLength"
        Me.txtPacketLength.Size = New System.Drawing.Size(132, 31)
        Me.txtPacketLength.TabIndex = 22
        Me.txtPacketLength.Text = "0"
        '
        'lblSoftware_07
        '
        Me.lblSoftware_07.AutoSize = True
        Me.lblSoftware_07.Location = New System.Drawing.Point(22, 492)
        Me.lblSoftware_07.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblSoftware_07.Name = "lblSoftware_07"
        Me.lblSoftware_07.Size = New System.Drawing.Size(120, 25)
        Me.lblSoftware_07.TabIndex = 37
        Me.lblSoftware_07.Text = "Software_7"
        '
        'txtSoftware_06
        '
        Me.txtSoftware_06.Location = New System.Drawing.Point(178, 437)
        Me.txtSoftware_06.Margin = New System.Windows.Forms.Padding(6)
        Me.txtSoftware_06.MaxLength = 1
        Me.txtSoftware_06.Name = "txtSoftware_06"
        Me.txtSoftware_06.Size = New System.Drawing.Size(132, 31)
        Me.txtSoftware_06.TabIndex = 34
        Me.txtSoftware_06.Text = "T"
        '
        'lblPacketLength
        '
        Me.lblPacketLength.AutoSize = True
        Me.lblPacketLength.Location = New System.Drawing.Point(22, 590)
        Me.lblPacketLength.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblPacketLength.Name = "lblPacketLength"
        Me.lblPacketLength.Size = New System.Drawing.Size(150, 25)
        Me.lblPacketLength.TabIndex = 23
        Me.lblPacketLength.Text = "Packet Length"
        '
        'lblSoftware_06
        '
        Me.lblSoftware_06.AutoSize = True
        Me.lblSoftware_06.Location = New System.Drawing.Point(22, 442)
        Me.lblSoftware_06.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblSoftware_06.Name = "lblSoftware_06"
        Me.lblSoftware_06.Size = New System.Drawing.Size(120, 25)
        Me.lblSoftware_06.TabIndex = 35
        Me.lblSoftware_06.Text = "Software_6"
        '
        'txtSoftware_05
        '
        Me.txtSoftware_05.Location = New System.Drawing.Point(178, 387)
        Me.txtSoftware_05.Margin = New System.Windows.Forms.Padding(6)
        Me.txtSoftware_05.MaxLength = 1
        Me.txtSoftware_05.Name = "txtSoftware_05"
        Me.txtSoftware_05.Size = New System.Drawing.Size(132, 31)
        Me.txtSoftware_05.TabIndex = 32
        Me.txtSoftware_05.Text = "I"
        '
        'txtPacketType
        '
        Me.txtPacketType.Location = New System.Drawing.Point(178, 537)
        Me.txtPacketType.Margin = New System.Windows.Forms.Padding(6)
        Me.txtPacketType.Name = "txtPacketType"
        Me.txtPacketType.Size = New System.Drawing.Size(132, 31)
        Me.txtPacketType.TabIndex = 20
        Me.txtPacketType.Text = "2000"
        '
        'lblSoftware_05
        '
        Me.lblSoftware_05.AutoSize = True
        Me.lblSoftware_05.Location = New System.Drawing.Point(22, 392)
        Me.lblSoftware_05.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblSoftware_05.Name = "lblSoftware_05"
        Me.lblSoftware_05.Size = New System.Drawing.Size(120, 25)
        Me.lblSoftware_05.TabIndex = 33
        Me.lblSoftware_05.Text = "Software_5"
        '
        'txtStationID
        '
        Me.txtStationID.Location = New System.Drawing.Point(178, 87)
        Me.txtStationID.Margin = New System.Windows.Forms.Padding(6)
        Me.txtStationID.Name = "txtStationID"
        Me.txtStationID.Size = New System.Drawing.Size(132, 31)
        Me.txtStationID.TabIndex = 16
        Me.txtStationID.Text = "2017"
        '
        'txtSoftware_04
        '
        Me.txtSoftware_04.Location = New System.Drawing.Point(178, 337)
        Me.txtSoftware_04.Margin = New System.Windows.Forms.Padding(6)
        Me.txtSoftware_04.MaxLength = 1
        Me.txtSoftware_04.Name = "txtSoftware_04"
        Me.txtSoftware_04.Size = New System.Drawing.Size(132, 31)
        Me.txtSoftware_04.TabIndex = 30
        Me.txtSoftware_04.Text = "L"
        '
        'lblPacketType
        '
        Me.lblPacketType.AutoSize = True
        Me.lblPacketType.Location = New System.Drawing.Point(22, 542)
        Me.lblPacketType.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblPacketType.Name = "lblPacketType"
        Me.lblPacketType.Size = New System.Drawing.Size(132, 25)
        Me.lblPacketType.TabIndex = 21
        Me.lblPacketType.Text = "Packet Type"
        '
        'lblSoftware_04
        '
        Me.lblSoftware_04.AutoSize = True
        Me.lblSoftware_04.Location = New System.Drawing.Point(22, 342)
        Me.lblSoftware_04.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblSoftware_04.Name = "lblSoftware_04"
        Me.lblSoftware_04.Size = New System.Drawing.Size(120, 25)
        Me.lblSoftware_04.TabIndex = 31
        Me.lblSoftware_04.Text = "Software_4"
        '
        'lblStationID
        '
        Me.lblStationID.AutoSize = True
        Me.lblStationID.Location = New System.Drawing.Point(22, 92)
        Me.lblStationID.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblStationID.Name = "lblStationID"
        Me.lblStationID.Size = New System.Drawing.Size(105, 25)
        Me.lblStationID.TabIndex = 17
        Me.lblStationID.Text = "Station ID"
        '
        'txtSoftware_00
        '
        Me.txtSoftware_00.Location = New System.Drawing.Point(178, 137)
        Me.txtSoftware_00.Margin = New System.Windows.Forms.Padding(6)
        Me.txtSoftware_00.MaxLength = 1
        Me.txtSoftware_00.Name = "txtSoftware_00"
        Me.txtSoftware_00.Size = New System.Drawing.Size(132, 31)
        Me.txtSoftware_00.TabIndex = 18
        Me.txtSoftware_00.Text = "E"
        '
        'lblSoftware_00
        '
        Me.lblSoftware_00.AutoSize = True
        Me.lblSoftware_00.Location = New System.Drawing.Point(22, 142)
        Me.lblSoftware_00.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblSoftware_00.Name = "lblSoftware_00"
        Me.lblSoftware_00.Size = New System.Drawing.Size(120, 25)
        Me.lblSoftware_00.TabIndex = 19
        Me.lblSoftware_00.Text = "Software_0"
        '
        'txtSoftware_03
        '
        Me.txtSoftware_03.Location = New System.Drawing.Point(178, 287)
        Me.txtSoftware_03.Margin = New System.Windows.Forms.Padding(6)
        Me.txtSoftware_03.MaxLength = 1
        Me.txtSoftware_03.Name = "txtSoftware_03"
        Me.txtSoftware_03.Size = New System.Drawing.Size(132, 31)
        Me.txtSoftware_03.TabIndex = 28
        Me.txtSoftware_03.Text = "A"
        '
        'lblSoftware_01
        '
        Me.lblSoftware_01.AutoSize = True
        Me.lblSoftware_01.Location = New System.Drawing.Point(22, 192)
        Me.lblSoftware_01.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblSoftware_01.Name = "lblSoftware_01"
        Me.lblSoftware_01.Size = New System.Drawing.Size(120, 25)
        Me.lblSoftware_01.TabIndex = 25
        Me.lblSoftware_01.Text = "Software_1"
        '
        'txtSoftware_01
        '
        Me.txtSoftware_01.Location = New System.Drawing.Point(178, 187)
        Me.txtSoftware_01.Margin = New System.Windows.Forms.Padding(6)
        Me.txtSoftware_01.MaxLength = 1
        Me.txtSoftware_01.Name = "txtSoftware_01"
        Me.txtSoftware_01.Size = New System.Drawing.Size(132, 31)
        Me.txtSoftware_01.TabIndex = 24
        Me.txtSoftware_01.Text = "Q"
        '
        'lblSoftware_03
        '
        Me.lblSoftware_03.AutoSize = True
        Me.lblSoftware_03.Location = New System.Drawing.Point(22, 292)
        Me.lblSoftware_03.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblSoftware_03.Name = "lblSoftware_03"
        Me.lblSoftware_03.Size = New System.Drawing.Size(120, 25)
        Me.lblSoftware_03.TabIndex = 29
        Me.lblSoftware_03.Text = "Software_3"
        '
        'lblSoftware_02
        '
        Me.lblSoftware_02.AutoSize = True
        Me.lblSoftware_02.Location = New System.Drawing.Point(22, 242)
        Me.lblSoftware_02.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblSoftware_02.Name = "lblSoftware_02"
        Me.lblSoftware_02.Size = New System.Drawing.Size(120, 25)
        Me.lblSoftware_02.TabIndex = 27
        Me.lblSoftware_02.Text = "Software_2"
        '
        'txtSoftware_02
        '
        Me.txtSoftware_02.Location = New System.Drawing.Point(178, 237)
        Me.txtSoftware_02.Margin = New System.Windows.Forms.Padding(6)
        Me.txtSoftware_02.MaxLength = 1
        Me.txtSoftware_02.Name = "txtSoftware_02"
        Me.txtSoftware_02.Size = New System.Drawing.Size(132, 31)
        Me.txtSoftware_02.TabIndex = 26
        Me.txtSoftware_02.Text = "U"
        '
        'pnleFlexHeader
        '
        Me.pnleFlexHeader.AutoScroll = True
        Me.pnleFlexHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnleFlexHeader.Controls.Add(Me.grpeFlexHeader)
        Me.pnleFlexHeader.Location = New System.Drawing.Point(24, 346)
        Me.pnleFlexHeader.Margin = New System.Windows.Forms.Padding(6)
        Me.pnleFlexHeader.Name = "pnleFlexHeader"
        Me.pnleFlexHeader.Size = New System.Drawing.Size(416, 537)
        Me.pnleFlexHeader.TabIndex = 16
        Me.pnleFlexHeader.Visible = False
        '
        'pnleFlexData
        '
        Me.pnleFlexData.AutoScroll = True
        Me.pnleFlexData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnleFlexData.Controls.Add(Me.grpeFlexData)
        Me.pnleFlexData.Location = New System.Drawing.Point(450, 346)
        Me.pnleFlexData.Margin = New System.Windows.Forms.Padding(6)
        Me.pnleFlexData.Name = "pnleFlexData"
        Me.pnleFlexData.Size = New System.Drawing.Size(974, 537)
        Me.pnleFlexData.TabIndex = 17
        Me.pnleFlexData.Visible = False
        '
        'grpeFlexData
        '
        Me.grpeFlexData.Controls.Add(Me.chkSpare_31)
        Me.grpeFlexData.Controls.Add(Me.chkSpare_30)
        Me.grpeFlexData.Controls.Add(Me.chkSpare_29)
        Me.grpeFlexData.Controls.Add(Me.chkSpare_28)
        Me.grpeFlexData.Controls.Add(Me.chkSpare_27)
        Me.grpeFlexData.Controls.Add(Me.chkSpare_26)
        Me.grpeFlexData.Controls.Add(Me.chkSpare_25)
        Me.grpeFlexData.Controls.Add(Me.chkSpare_24)
        Me.grpeFlexData.Controls.Add(Me.chkChildPrereqNOK)
        Me.grpeFlexData.Controls.Add(Me.chkToteMaxCycles)
        Me.grpeFlexData.Controls.Add(Me.chkWrongPartForModel)
        Me.grpeFlexData.Controls.Add(Me.chkNotRequired)
        Me.grpeFlexData.Controls.Add(Me.chkWrongPartForSeparation)
        Me.grpeFlexData.Controls.Add(Me.chkPartSeparatedOkay)
        Me.grpeFlexData.Controls.Add(Me.chkRecievedSNStatus)
        Me.grpeFlexData.Controls.Add(Me.chkMasterSNRFIDready)
        Me.grpeFlexData.Controls.Add(Me.chkPrereqNotMet)
        Me.grpeFlexData.Controls.Add(Me.chkInvalidPacket)
        Me.grpeFlexData.Controls.Add(Me.chkConfigError)
        Me.grpeFlexData.Controls.Add(Me.chkPartAlreadyRan)
        Me.grpeFlexData.Controls.Add(Me.chkServerError)
        Me.grpeFlexData.Controls.Add(Me.chkChildNotFound)
        Me.grpeFlexData.Controls.Add(Me.chkPartNotFound)
        Me.grpeFlexData.Controls.Add(Me.chkIncorrectPNmarg)
        Me.grpeFlexData.Controls.Add(Me.chkChiledRejectedSubSys)
        Me.grpeFlexData.Controls.Add(Me.chkParentRejected)
        Me.grpeFlexData.Controls.Add(Me.chkChildContained)
        Me.grpeFlexData.Controls.Add(Me.chkParentContained)
        Me.grpeFlexData.Controls.Add(Me.chkChildPrevMarg)
        Me.grpeFlexData.Controls.Add(Me.chkPartDivorced)
        Me.grpeFlexData.Controls.Add(Me.chkPartMarried)
        Me.grpeFlexData.Controls.Add(Me.chkPartOkay)
        Me.grpeFlexData.Controls.Add(Me.rdoTnT2000)
        Me.grpeFlexData.Location = New System.Drawing.Point(10, 6)
        Me.grpeFlexData.Margin = New System.Windows.Forms.Padding(6)
        Me.grpeFlexData.Name = "grpeFlexData"
        Me.grpeFlexData.Padding = New System.Windows.Forms.Padding(6)
        Me.grpeFlexData.Size = New System.Drawing.Size(920, 621)
        Me.grpeFlexData.TabIndex = 15
        Me.grpeFlexData.TabStop = False
        Me.grpeFlexData.Text = "Data to Write"
        Me.grpeFlexData.Visible = False
        '
        'chkSpare_31
        '
        Me.chkSpare_31.AutoSize = True
        Me.chkSpare_31.Location = New System.Drawing.Point(726, 540)
        Me.chkSpare_31.Margin = New System.Windows.Forms.Padding(6)
        Me.chkSpare_31.Name = "chkSpare_31"
        Me.chkSpare_31.Size = New System.Drawing.Size(137, 29)
        Me.chkSpare_31.TabIndex = 34
        Me.chkSpare_31.Text = "Spare_31"
        Me.chkSpare_31.UseVisualStyleBackColor = True
        '
        'chkSpare_30
        '
        Me.chkSpare_30.AutoSize = True
        Me.chkSpare_30.Location = New System.Drawing.Point(726, 477)
        Me.chkSpare_30.Margin = New System.Windows.Forms.Padding(6)
        Me.chkSpare_30.Name = "chkSpare_30"
        Me.chkSpare_30.Size = New System.Drawing.Size(137, 29)
        Me.chkSpare_30.TabIndex = 33
        Me.chkSpare_30.Text = "Spare_30"
        Me.chkSpare_30.UseVisualStyleBackColor = True
        '
        'chkSpare_29
        '
        Me.chkSpare_29.AutoSize = True
        Me.chkSpare_29.Location = New System.Drawing.Point(726, 413)
        Me.chkSpare_29.Margin = New System.Windows.Forms.Padding(6)
        Me.chkSpare_29.Name = "chkSpare_29"
        Me.chkSpare_29.Size = New System.Drawing.Size(137, 29)
        Me.chkSpare_29.TabIndex = 32
        Me.chkSpare_29.Text = "Spare_29"
        Me.chkSpare_29.UseVisualStyleBackColor = True
        '
        'chkSpare_28
        '
        Me.chkSpare_28.AutoSize = True
        Me.chkSpare_28.Location = New System.Drawing.Point(726, 350)
        Me.chkSpare_28.Margin = New System.Windows.Forms.Padding(6)
        Me.chkSpare_28.Name = "chkSpare_28"
        Me.chkSpare_28.Size = New System.Drawing.Size(137, 29)
        Me.chkSpare_28.TabIndex = 31
        Me.chkSpare_28.Text = "Spare_28"
        Me.chkSpare_28.UseVisualStyleBackColor = True
        '
        'chkSpare_27
        '
        Me.chkSpare_27.AutoSize = True
        Me.chkSpare_27.Location = New System.Drawing.Point(726, 287)
        Me.chkSpare_27.Margin = New System.Windows.Forms.Padding(6)
        Me.chkSpare_27.Name = "chkSpare_27"
        Me.chkSpare_27.Size = New System.Drawing.Size(137, 29)
        Me.chkSpare_27.TabIndex = 30
        Me.chkSpare_27.Text = "Spare_27"
        Me.chkSpare_27.UseVisualStyleBackColor = True
        '
        'chkSpare_26
        '
        Me.chkSpare_26.AutoSize = True
        Me.chkSpare_26.Location = New System.Drawing.Point(726, 223)
        Me.chkSpare_26.Margin = New System.Windows.Forms.Padding(6)
        Me.chkSpare_26.Name = "chkSpare_26"
        Me.chkSpare_26.Size = New System.Drawing.Size(137, 29)
        Me.chkSpare_26.TabIndex = 29
        Me.chkSpare_26.Text = "Spare_26"
        Me.chkSpare_26.UseVisualStyleBackColor = True
        '
        'chkSpare_25
        '
        Me.chkSpare_25.AutoSize = True
        Me.chkSpare_25.Location = New System.Drawing.Point(726, 160)
        Me.chkSpare_25.Margin = New System.Windows.Forms.Padding(6)
        Me.chkSpare_25.Name = "chkSpare_25"
        Me.chkSpare_25.Size = New System.Drawing.Size(137, 29)
        Me.chkSpare_25.TabIndex = 28
        Me.chkSpare_25.Text = "Spare_25"
        Me.chkSpare_25.UseVisualStyleBackColor = True
        '
        'chkSpare_24
        '
        Me.chkSpare_24.AutoSize = True
        Me.chkSpare_24.Location = New System.Drawing.Point(726, 98)
        Me.chkSpare_24.Margin = New System.Windows.Forms.Padding(6)
        Me.chkSpare_24.Name = "chkSpare_24"
        Me.chkSpare_24.Size = New System.Drawing.Size(137, 29)
        Me.chkSpare_24.TabIndex = 27
        Me.chkSpare_24.Text = "Spare_24"
        Me.chkSpare_24.UseVisualStyleBackColor = True
        '
        'chkChildPrereqNOK
        '
        Me.chkChildPrereqNOK.AutoSize = True
        Me.chkChildPrereqNOK.Location = New System.Drawing.Point(488, 540)
        Me.chkChildPrereqNOK.Margin = New System.Windows.Forms.Padding(6)
        Me.chkChildPrereqNOK.Name = "chkChildPrereqNOK"
        Me.chkChildPrereqNOK.Size = New System.Drawing.Size(214, 29)
        Me.chkChildPrereqNOK.TabIndex = 26
        Me.chkChildPrereqNOK.Text = "Child Prereq NOK"
        Me.chkChildPrereqNOK.UseVisualStyleBackColor = True
        '
        'chkToteMaxCycles
        '
        Me.chkToteMaxCycles.AutoSize = True
        Me.chkToteMaxCycles.Location = New System.Drawing.Point(488, 477)
        Me.chkToteMaxCycles.Margin = New System.Windows.Forms.Padding(6)
        Me.chkToteMaxCycles.Name = "chkToteMaxCycles"
        Me.chkToteMaxCycles.Size = New System.Drawing.Size(205, 29)
        Me.chkToteMaxCycles.TabIndex = 25
        Me.chkToteMaxCycles.Text = "Tote Max Cycles"
        Me.chkToteMaxCycles.UseVisualStyleBackColor = True
        '
        'chkWrongPartForModel
        '
        Me.chkWrongPartForModel.AutoSize = True
        Me.chkWrongPartForModel.Location = New System.Drawing.Point(488, 400)
        Me.chkWrongPartForModel.Margin = New System.Windows.Forms.Padding(6)
        Me.chkWrongPartForModel.Name = "chkWrongPartForModel"
        Me.chkWrongPartForModel.Size = New System.Drawing.Size(190, 54)
        Me.chkWrongPartForModel.TabIndex = 24
        Me.chkWrongPartForModel.Text = "Wrong Part For" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Model"
        Me.chkWrongPartForModel.UseVisualStyleBackColor = True
        '
        'chkNotRequired
        '
        Me.chkNotRequired.AutoSize = True
        Me.chkNotRequired.Location = New System.Drawing.Point(488, 350)
        Me.chkNotRequired.Margin = New System.Windows.Forms.Padding(6)
        Me.chkNotRequired.Name = "chkNotRequired"
        Me.chkNotRequired.Size = New System.Drawing.Size(170, 29)
        Me.chkNotRequired.TabIndex = 23
        Me.chkNotRequired.Text = "Not Required"
        Me.chkNotRequired.UseVisualStyleBackColor = True
        '
        'chkWrongPartForSeparation
        '
        Me.chkWrongPartForSeparation.AutoSize = True
        Me.chkWrongPartForSeparation.Location = New System.Drawing.Point(488, 273)
        Me.chkWrongPartForSeparation.Margin = New System.Windows.Forms.Padding(6)
        Me.chkWrongPartForSeparation.Name = "chkWrongPartForSeparation"
        Me.chkWrongPartForSeparation.Size = New System.Drawing.Size(190, 54)
        Me.chkWrongPartForSeparation.TabIndex = 22
        Me.chkWrongPartForSeparation.Text = "Wrong Part For" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Separation"
        Me.chkWrongPartForSeparation.UseVisualStyleBackColor = True
        '
        'chkPartSeparatedOkay
        '
        Me.chkPartSeparatedOkay.AutoSize = True
        Me.chkPartSeparatedOkay.Location = New System.Drawing.Point(488, 210)
        Me.chkPartSeparatedOkay.Margin = New System.Windows.Forms.Padding(6)
        Me.chkPartSeparatedOkay.Name = "chkPartSeparatedOkay"
        Me.chkPartSeparatedOkay.Size = New System.Drawing.Size(188, 54)
        Me.chkPartSeparatedOkay.TabIndex = 21
        Me.chkPartSeparatedOkay.Text = "Part Separated" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Okay"
        Me.chkPartSeparatedOkay.UseVisualStyleBackColor = True
        '
        'chkRecievedSNStatus
        '
        Me.chkRecievedSNStatus.AutoSize = True
        Me.chkRecievedSNStatus.Location = New System.Drawing.Point(488, 146)
        Me.chkRecievedSNStatus.Margin = New System.Windows.Forms.Padding(6)
        Me.chkRecievedSNStatus.Name = "chkRecievedSNStatus"
        Me.chkRecievedSNStatus.Size = New System.Drawing.Size(169, 54)
        Me.chkRecievedSNStatus.TabIndex = 20
        Me.chkRecievedSNStatus.Text = "Recieved SN" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Status"
        Me.chkRecievedSNStatus.UseVisualStyleBackColor = True
        '
        'chkMasterSNRFIDready
        '
        Me.chkMasterSNRFIDready.AutoSize = True
        Me.chkMasterSNRFIDready.Location = New System.Drawing.Point(488, 85)
        Me.chkMasterSNRFIDready.Margin = New System.Windows.Forms.Padding(6)
        Me.chkMasterSNRFIDready.Name = "chkMasterSNRFIDready"
        Me.chkMasterSNRFIDready.Size = New System.Drawing.Size(199, 54)
        Me.chkMasterSNRFIDready.TabIndex = 19
        Me.chkMasterSNRFIDready.Text = "Master SN RFID" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "data ready"
        Me.chkMasterSNRFIDready.UseVisualStyleBackColor = True
        '
        'chkPrereqNotMet
        '
        Me.chkPrereqNotMet.AutoSize = True
        Me.chkPrereqNotMet.Location = New System.Drawing.Point(250, 540)
        Me.chkPrereqNotMet.Margin = New System.Windows.Forms.Padding(6)
        Me.chkPrereqNotMet.Name = "chkPrereqNotMet"
        Me.chkPrereqNotMet.Size = New System.Drawing.Size(189, 29)
        Me.chkPrereqNotMet.TabIndex = 18
        Me.chkPrereqNotMet.Text = "Prereq Not Met"
        Me.chkPrereqNotMet.UseVisualStyleBackColor = True
        '
        'chkInvalidPacket
        '
        Me.chkInvalidPacket.AutoSize = True
        Me.chkInvalidPacket.Location = New System.Drawing.Point(250, 477)
        Me.chkInvalidPacket.Margin = New System.Windows.Forms.Padding(6)
        Me.chkInvalidPacket.Name = "chkInvalidPacket"
        Me.chkInvalidPacket.Size = New System.Drawing.Size(178, 29)
        Me.chkInvalidPacket.TabIndex = 17
        Me.chkInvalidPacket.Text = "Invalid Packet"
        Me.chkInvalidPacket.UseVisualStyleBackColor = True
        '
        'chkConfigError
        '
        Me.chkConfigError.AutoSize = True
        Me.chkConfigError.Location = New System.Drawing.Point(250, 413)
        Me.chkConfigError.Margin = New System.Windows.Forms.Padding(6)
        Me.chkConfigError.Name = "chkConfigError"
        Me.chkConfigError.Size = New System.Drawing.Size(159, 29)
        Me.chkConfigError.TabIndex = 16
        Me.chkConfigError.Text = "Config Error"
        Me.chkConfigError.UseVisualStyleBackColor = True
        '
        'chkPartAlreadyRan
        '
        Me.chkPartAlreadyRan.AutoSize = True
        Me.chkPartAlreadyRan.Location = New System.Drawing.Point(250, 350)
        Me.chkPartAlreadyRan.Margin = New System.Windows.Forms.Padding(6)
        Me.chkPartAlreadyRan.Name = "chkPartAlreadyRan"
        Me.chkPartAlreadyRan.Size = New System.Drawing.Size(207, 29)
        Me.chkPartAlreadyRan.TabIndex = 15
        Me.chkPartAlreadyRan.Text = "Part Already Ran"
        Me.chkPartAlreadyRan.UseVisualStyleBackColor = True
        '
        'chkServerError
        '
        Me.chkServerError.AutoSize = True
        Me.chkServerError.Location = New System.Drawing.Point(250, 287)
        Me.chkServerError.Margin = New System.Windows.Forms.Padding(6)
        Me.chkServerError.Name = "chkServerError"
        Me.chkServerError.Size = New System.Drawing.Size(160, 29)
        Me.chkServerError.TabIndex = 14
        Me.chkServerError.Text = "Server Error"
        Me.chkServerError.UseVisualStyleBackColor = True
        '
        'chkChildNotFound
        '
        Me.chkChildNotFound.AutoSize = True
        Me.chkChildNotFound.Location = New System.Drawing.Point(250, 223)
        Me.chkChildNotFound.Margin = New System.Windows.Forms.Padding(6)
        Me.chkChildNotFound.Name = "chkChildNotFound"
        Me.chkChildNotFound.Size = New System.Drawing.Size(199, 29)
        Me.chkChildNotFound.TabIndex = 13
        Me.chkChildNotFound.Text = "Child Not Found"
        Me.chkChildNotFound.UseVisualStyleBackColor = True
        '
        'chkPartNotFound
        '
        Me.chkPartNotFound.AutoSize = True
        Me.chkPartNotFound.Location = New System.Drawing.Point(250, 160)
        Me.chkPartNotFound.Margin = New System.Windows.Forms.Padding(6)
        Me.chkPartNotFound.Name = "chkPartNotFound"
        Me.chkPartNotFound.Size = New System.Drawing.Size(189, 29)
        Me.chkPartNotFound.TabIndex = 12
        Me.chkPartNotFound.Text = "Part Not Found"
        Me.chkPartNotFound.UseVisualStyleBackColor = True
        '
        'chkIncorrectPNmarg
        '
        Me.chkIncorrectPNmarg.AutoSize = True
        Me.chkIncorrectPNmarg.Location = New System.Drawing.Point(250, 85)
        Me.chkIncorrectPNmarg.Margin = New System.Windows.Forms.Padding(6)
        Me.chkIncorrectPNmarg.Name = "chkIncorrectPNmarg"
        Me.chkIncorrectPNmarg.Size = New System.Drawing.Size(193, 54)
        Me.chkIncorrectPNmarg.TabIndex = 11
        Me.chkIncorrectPNmarg.Text = "Incorrect PN for" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Marriage"
        Me.chkIncorrectPNmarg.UseVisualStyleBackColor = True
        '
        'chkChiledRejectedSubSys
        '
        Me.chkChiledRejectedSubSys.AutoSize = True
        Me.chkChiledRejectedSubSys.Location = New System.Drawing.Point(12, 527)
        Me.chkChiledRejectedSubSys.Margin = New System.Windows.Forms.Padding(6)
        Me.chkChiledRejectedSubSys.Name = "chkChiledRejectedSubSys"
        Me.chkChiledRejectedSubSys.Size = New System.Drawing.Size(196, 54)
        Me.chkChiledRejectedSubSys.TabIndex = 10
        Me.chkChiledRejectedSubSys.Text = "Chiled Rejected" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "At SubSystem"
        Me.chkChiledRejectedSubSys.UseVisualStyleBackColor = True
        '
        'chkParentRejected
        '
        Me.chkParentRejected.AutoSize = True
        Me.chkParentRejected.Location = New System.Drawing.Point(12, 477)
        Me.chkParentRejected.Margin = New System.Windows.Forms.Padding(6)
        Me.chkParentRejected.Name = "chkParentRejected"
        Me.chkParentRejected.Size = New System.Drawing.Size(198, 29)
        Me.chkParentRejected.TabIndex = 9
        Me.chkParentRejected.Text = "Parent Rejected"
        Me.chkParentRejected.UseVisualStyleBackColor = True
        '
        'chkChildContained
        '
        Me.chkChildContained.AutoSize = True
        Me.chkChildContained.Location = New System.Drawing.Point(12, 413)
        Me.chkChildContained.Margin = New System.Windows.Forms.Padding(6)
        Me.chkChildContained.Name = "chkChildContained"
        Me.chkChildContained.Size = New System.Drawing.Size(197, 29)
        Me.chkChildContained.TabIndex = 8
        Me.chkChildContained.Text = "Child Contained"
        Me.chkChildContained.UseVisualStyleBackColor = True
        '
        'chkParentContained
        '
        Me.chkParentContained.AutoSize = True
        Me.chkParentContained.Location = New System.Drawing.Point(12, 350)
        Me.chkParentContained.Margin = New System.Windows.Forms.Padding(6)
        Me.chkParentContained.Name = "chkParentContained"
        Me.chkParentContained.Size = New System.Drawing.Size(211, 29)
        Me.chkParentContained.TabIndex = 7
        Me.chkParentContained.Text = "Parent Contained"
        Me.chkParentContained.UseVisualStyleBackColor = True
        '
        'chkChildPrevMarg
        '
        Me.chkChildPrevMarg.AutoSize = True
        Me.chkChildPrevMarg.Location = New System.Drawing.Point(12, 273)
        Me.chkChildPrevMarg.Margin = New System.Windows.Forms.Padding(6)
        Me.chkChildPrevMarg.Name = "chkChildPrevMarg"
        Me.chkChildPrevMarg.Size = New System.Drawing.Size(199, 54)
        Me.chkChildPrevMarg.TabIndex = 6
        Me.chkChildPrevMarg.Text = "Child Previously" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Married"
        Me.chkChildPrevMarg.UseVisualStyleBackColor = True
        '
        'chkPartDivorced
        '
        Me.chkPartDivorced.AutoSize = True
        Me.chkPartDivorced.Location = New System.Drawing.Point(12, 223)
        Me.chkPartDivorced.Margin = New System.Windows.Forms.Padding(6)
        Me.chkPartDivorced.Name = "chkPartDivorced"
        Me.chkPartDivorced.Size = New System.Drawing.Size(174, 29)
        Me.chkPartDivorced.TabIndex = 5
        Me.chkPartDivorced.Text = "Part Divorced"
        Me.chkPartDivorced.UseVisualStyleBackColor = True
        '
        'chkPartMarried
        '
        Me.chkPartMarried.AutoSize = True
        Me.chkPartMarried.Location = New System.Drawing.Point(12, 160)
        Me.chkPartMarried.Margin = New System.Windows.Forms.Padding(6)
        Me.chkPartMarried.Name = "chkPartMarried"
        Me.chkPartMarried.Size = New System.Drawing.Size(162, 29)
        Me.chkPartMarried.TabIndex = 4
        Me.chkPartMarried.Text = "Part Married"
        Me.chkPartMarried.UseVisualStyleBackColor = True
        '
        'chkPartOkay
        '
        Me.chkPartOkay.AutoSize = True
        Me.chkPartOkay.Location = New System.Drawing.Point(12, 98)
        Me.chkPartOkay.Margin = New System.Windows.Forms.Padding(6)
        Me.chkPartOkay.Name = "chkPartOkay"
        Me.chkPartOkay.Size = New System.Drawing.Size(139, 29)
        Me.chkPartOkay.TabIndex = 3
        Me.chkPartOkay.Text = "Part Okay"
        Me.chkPartOkay.UseVisualStyleBackColor = True
        '
        'rdoTnT2000
        '
        Me.rdoTnT2000.AutoSize = True
        Me.rdoTnT2000.Checked = True
        Me.rdoTnT2000.Location = New System.Drawing.Point(12, 40)
        Me.rdoTnT2000.Margin = New System.Windows.Forms.Padding(6)
        Me.rdoTnT2000.Name = "rdoTnT2000"
        Me.rdoTnT2000.Size = New System.Drawing.Size(149, 29)
        Me.rdoTnT2000.TabIndex = 0
        Me.rdoTnT2000.TabStop = True
        Me.rdoTnT2000.Text = "Part Status"
        Me.rdoTnT2000.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1466, 958)
        Me.Controls.Add(Me.pnleFlexData)
        Me.Controls.Add(Me.btnSendData)
        Me.Controls.Add(Me.pnleFlexHeader)
        Me.Controls.Add(Me.grpRead)
        Me.Controls.Add(Me.grpConnect)
        Me.Margin = New System.Windows.Forms.Padding(6)
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
        Me.grpeFlexData.ResumeLayout(False)
        Me.grpeFlexData.PerformLayout()
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
    Friend WithEvents rdoTnT2000 As System.Windows.Forms.RadioButton
    Friend WithEvents chkSpare_31 As System.Windows.Forms.CheckBox
    Friend WithEvents chkSpare_30 As System.Windows.Forms.CheckBox
    Friend WithEvents chkSpare_29 As System.Windows.Forms.CheckBox
    Friend WithEvents chkSpare_28 As System.Windows.Forms.CheckBox
    Friend WithEvents chkSpare_27 As System.Windows.Forms.CheckBox
    Friend WithEvents chkSpare_26 As System.Windows.Forms.CheckBox
    Friend WithEvents chkSpare_25 As System.Windows.Forms.CheckBox
    Friend WithEvents chkSpare_24 As System.Windows.Forms.CheckBox
    Friend WithEvents chkChildPrereqNOK As System.Windows.Forms.CheckBox
    Friend WithEvents chkToteMaxCycles As System.Windows.Forms.CheckBox
    Friend WithEvents chkWrongPartForModel As System.Windows.Forms.CheckBox
    Friend WithEvents chkNotRequired As System.Windows.Forms.CheckBox
    Friend WithEvents chkWrongPartForSeparation As System.Windows.Forms.CheckBox
    Friend WithEvents chkPartSeparatedOkay As System.Windows.Forms.CheckBox
    Friend WithEvents chkRecievedSNStatus As System.Windows.Forms.CheckBox
    Friend WithEvents chkMasterSNRFIDready As System.Windows.Forms.CheckBox
    Friend WithEvents chkPrereqNotMet As System.Windows.Forms.CheckBox
    Friend WithEvents chkInvalidPacket As System.Windows.Forms.CheckBox
    Friend WithEvents chkConfigError As System.Windows.Forms.CheckBox
    Friend WithEvents chkPartAlreadyRan As System.Windows.Forms.CheckBox
    Friend WithEvents chkServerError As System.Windows.Forms.CheckBox
    Friend WithEvents chkChildNotFound As System.Windows.Forms.CheckBox
    Friend WithEvents chkPartNotFound As System.Windows.Forms.CheckBox
    Friend WithEvents chkIncorrectPNmarg As System.Windows.Forms.CheckBox
    Friend WithEvents chkChiledRejectedSubSys As System.Windows.Forms.CheckBox
    Friend WithEvents chkParentRejected As System.Windows.Forms.CheckBox
    Friend WithEvents chkChildContained As System.Windows.Forms.CheckBox
    Friend WithEvents chkParentContained As System.Windows.Forms.CheckBox
    Friend WithEvents chkChildPrevMarg As System.Windows.Forms.CheckBox
    Friend WithEvents chkPartDivorced As System.Windows.Forms.CheckBox
    Friend WithEvents chkPartMarried As System.Windows.Forms.CheckBox
    Friend WithEvents chkPartOkay As System.Windows.Forms.CheckBox
    Friend WithEvents chkHeaderSeperate As System.Windows.Forms.CheckBox

End Class
