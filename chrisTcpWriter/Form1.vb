'------------------------------------- I M P O R T   N A M E S P A C E S -------------------------------------

' Import namespaces that Server/PlcListener will use
Imports System.Net          ' Namespace provides a programming interface for many network protocols
Imports System.Net.Sockets          ' Namespace provides managed implementation of Winsock

' Allow for Marshaling Structures (Struct to Byte())
Imports System.Runtime.InteropServices
Imports System.Text

'-------------------------------------------------------------------------------------------------------------
'-------------------------------------------------------------------------------------------------------------


Public Class frmMain

    ' Declarations of Scope: Global to frmMain
    Dim plcClients As New TcpClient         ' Provide TCP Client connections as "plcClients"
    Dim plcClientStream As NetworkStream            ' Provide the stream of data for network access as "plcClientStream"
    Dim userPort As Integer            ' Used to contain user defined PORT
    Dim userHostname As String          ' Used to contain user defined HOST
    Dim connected As Boolean            ' Global connection state
    Dim connectionType As Integer           ' 0:Rockwell TCP/IP, 1:EtherNetIP-Explicit

    ' ETHERNET IP
    Dim enetConnectionManagerTrigger As Boolean         ' Used to trigger "Connection Manager" once EtherNetIP session has started, and session handle recieved
    Dim enetSessionHandle(3) As Byte            ' Unique ession handle that PLC returns, is required for all future messages on active session
    Dim enetConnectionID(3) As Byte         ' Unique connection ID (CID) that is required for all "CONNECTED" messaging
    Dim enetSenderContext() As Byte = {&H65, &H46, &H6C, &H65, &H78, &H30, &H30, &H31}
    Dim enetSendRequestService() As Byte = {&H4C}        ' Request Service: "Read Tag"
    Dim enetSendRequestPathSize() As Byte = {&H6}           ' Total size (in words) of Request Path: 6 words, 12 bytes
    Dim enetSendRequestPath() As Byte = {&H91, &HA, &H54, &H48, &H45, &H49, &H4E, &H54, &H45, &H47, &H45, &H52}          ' Path: SERVICE NUMBER(0x91), LENGTH OF TAG NAME(10), TAG//ASCII(THEINTEGER)
    Dim enetSendRequestData() As Byte = {&HD0, &H7}           ' Number of elements to read: 1

    ' EtherNetIP "Connection Manager: Forward_Open" Outgoing Message
    Public Structure EtherNetIP_ConnectionManagerOutgoing
        ' Encapsulated Header
        Public command() As Byte
        Public length() As Byte
        Public sessionHandle() As Byte
        Public successStatus() As Byte
        Public senderContext() As Byte
        Public options() As Byte
        ' Encapsulated Data
        Public interfaceHandle() As Byte
        Public timeout() As Byte
        Public itemCount() As Byte
        Public nullAddressItem() As Byte
        Public nullAddressItemLength() As Byte
        Public unconnectedDataItem() As Byte
        Public unconnectedDataItemLength() As Byte
        Public service() As Byte
        Public pathSize() As Byte
        Public classPathSegment() As Byte
        Public classType() As Byte
        Public instancePathSegment() As Byte
        Public InstanceType() As Byte
        Public actualTimeOut() As Byte
        Public OtoT_NetworkConnID() As Byte
        Public TtoO_NetworkConnID() As Byte
        Public connSerialNumber() As Byte
        Public vendorID() As Byte
        Public originatorSerialNumber() As Byte
        Public connTimoutMultiplier() As Byte
        Public RESERVED() As Byte
        Public OtoT_RPI() As Byte
        Public OtoT_ConnParameters() As Byte
        Public TtoO_RPI() As Byte
        Public TtoO_ConnParameters() As Byte
        Public transportType() As Byte
        Public connPathSize() As Byte
        Public port() As Byte
        Public linkAddress() As Byte
        Public messageRouterPath() As Byte
        Public instancePath() As Byte
        Public pathType() As Byte
        Public connPoint() As Byte
    End Structure

    ' EtherNetIP "SendUnitData" Outgoing Message
    Public Structure EtherNetIP_SendUnitDataOutgoing
        ' Encapsulated Header
        Public command() As Byte
        Public length() As Byte
        Public sessionHandle() As Byte
        Public successStatus() As Byte
        Public senderContext() As Byte
        Public options() As Byte
        ' Encapsulated Data
        Public interfaceHandle() As Byte
        Public timeout() As Byte
        Public addressItemCount() As Byte
        Public addressItemType() As Byte
        Public addressItemDataLength() As Byte
        Public addressItemData() As Byte
        Public dataItemType() As Byte
        Public dataItemDataLength() As Byte
        Public sequenceCount() As Byte
        Public requestService() As Byte         ' "Multiple Service Packet" = {&H0A}
        Public requestPathSize() As Byte            ' Size (in words) of "Request Path" = {&H02}
        Public requestPath() As Byte            ' Logical Segment: Class 0x02, Instance 01 (Message Router) = {&H20, &H2, &H24, &H1}
        Public requestData_NumberServicesIncluded() As Byte         ' Number of services included in "Multiple Service Packet"
        Public requestData_OffsetsPerService() As Byte          ' Offsets for each service (two byte offset value per service), from start of "requestData"
        Public requestData_FirstService() As Byte           ' First service parameters
    End Structure

    ' eFlex Header Structure
    Public Structure eFlexHeader
        Public deviceType As UShort ' Byte: (0,1)
        Public spare0 As Byte   ' Byte: (2)
        Public spare1 As Byte   ' Byte: (3)
        Public spare2 As Byte   ' Byte: (4)
        Public spare3 As Byte   ' Byte: (5)
        Public spare4 As Byte   ' Byte: (6)
        Public spare5 As Byte   ' Byte: (7)
        Public stationID As UShort  ' Byte: (8,9)
        Public footprintID As UShort    ' Byte: (10,11)
        Public softwareName_00 As Byte  ' Byte: (12)
        Public softwareName_01 As Byte  ' Byte: (13)
        Public softwareName_02 As Byte  ' Byte: (14)
        Public softwareName_03 As Byte  ' Byte: (15)
        Public softwareName_04 As Byte  ' Byte: (16)
        Public softwareName_05 As Byte  ' Byte: (17)
        Public softwareName_06 As Byte  ' Byte: (18)
        Public softwareName_07 As Byte  ' Byte: (19)
        Public stationIndex As Byte ' Byte: (20)
        Public shortDescription_00 As Byte  ' Byte: (21)
        Public shortDescription_01 As Byte  ' Byte: (22)
        Public shortDescription_02 As Byte  ' Byte: (23)
        Public shortDescription_03 As Byte  ' Byte: (24)
        Public shortDescription_04 As Byte  ' Byte: (25)
        Public shortDescription_05 As Byte  ' Byte: (26)
        Public shortDescription_06 As Byte  ' Byte: (27)
        Public shortDescription_07 As Byte  ' Byte: (28)
        Public shortDescription_08 As Byte  ' Byte: (29)
        Public shortDescription_09 As Byte  ' Byte: (30)
        Public shortDescription_10 As Byte  ' Byte: (31)
        Public bufferedDuration As UInteger ' Byte: (32,35)
        Public packetID As UShort   ' Byte: (36,37)
        Public numberPackets As UShort  ' Byte: (38,39)
        Public lengthPacket As UInteger ' Byte: (40,43)
    End Structure


    '------------------------------------- C O N N E C T   T O   C L I E N T -------------------------------------

    ' User clicked "Connect" button. Open a new TCP client socket at user defined IP & Port 
    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click

        ' Make sure user defined connection settings are valid, try to connect
        If userHostname = "" Then
            invalidHost()           ' Invalid Hostname detected
        Else
            If userPort > 1024 And userPort < 65536 Then
                connect()           ' Connect to client
                'connectedThread()           ' Start new thread to monitor NetworkStream
            Else
                invalidPort()           ' Invalid Port detected
            End If
        End If

    End Sub


    '------------------------------------- D I S C O N N E C T   F R O M   C L I E N T -------------------------------------

    ' User clicked "Disconnect" button. Disconnect current TcpClient
    Private Sub btnDisconnect_Click(sender As Object, e As EventArgs) Handles btnDisconnect.Click
        disconnect()            ' Disconnect client
        updateUI(connected)         ' Update UI based on connection status
    End Sub


    '------------------------------------- M O N I T O R   N E T W O R K - S T R E A M -------------------------------------

    ' NetworkStream Timer Ticked Event (I would prefer to multithread the network stream "checkread", but until I can figure that out, this will have to do)
    Private Sub tmrNetworkStream_Tick(sender As Object, e As EventArgs) Handles tmrNetworkStream.Tick

        ' Check if "new data received"
        If plcClientStream.DataAvailable Then

            ' Read from NetworkStream
            Dim myReadBuffer(plcClients.ReceiveBufferSize) As Byte          ' Declare memory area for data to be read from NetworkStream, of size of data in NetworkStream
            plcClientStream.Read(myReadBuffer, 0, CInt(plcClients.ReceiveBufferSize))           ' Read data from NetworkStream

            ' Update User Interface
            txtReadBuffer.Text = ""           ' Initialize Read Data Display

            Dim myReadBufferString As String = ""           ' Initialize read buffer string
            Dim x As Integer = 0            ' Initialize "For Loop"

            For x = 0 To plcClients.ReceiveBufferSize          ' Loop through read buffer data, proceed to concatenate
                If x = 0 Then           ' If First Byte
                    myReadBufferString = myReadBuffer(x)
                Else
                    myReadBufferString = myReadBufferString & ", " & myReadBuffer(x)
                End If
            Next

            txtReadBuffer.Text = myReadBufferString         ' Display final string

            ' If using EtherNetIP-Explicit, pick apart packet recieved
            If comboDeviceType.SelectedIndex = 1 Then
                ' Find Session Command Type
                Select Case myReadBuffer(0)
                    Case &H65            ' (0x65): Register Session Response, contains session handle
                        Dim i As Byte           ' "For Loop" indexer
                        For i = 0 To 3
                            enetSessionHandle(i) = myReadBuffer(i + 4)          ' Store "Session Handle"
                        Next

                        ' If we received type: 0x65 and still need to start the connection manager, send connection manager packet
                        If enetConnectionManagerTrigger Then
                            ' Build "Connection Manager" Packet
                            Dim enetCMPacket As EtherNetIP_ConnectionManagerOutgoing

                            ' Encapsulated Header
                            enetCMPacket.command = {&H6F, &H0}
                            enetCMPacket.length = {&H42, &H0}
                            enetCMPacket.sessionHandle = {enetSessionHandle(0), enetSessionHandle(1), enetSessionHandle(2), enetSessionHandle(3)}
                            enetCMPacket.successStatus = {&H0, &H0, &H0, &H0}
                            enetCMPacket.senderContext = {enetSenderContext(0), enetSenderContext(1), enetSenderContext(2), enetSenderContext(3), _
                                                          enetSenderContext(4), enetSenderContext(5), enetSenderContext(6), enetSenderContext(7)}
                            enetCMPacket.options = {&H0, &H0, &H0, &H0}
                            ' Encapsulated Data
                            enetCMPacket.interfaceHandle = {&H0, &H0, &H0, &H0}
                            enetCMPacket.timeout = {&H5, &H0}
                            enetCMPacket.itemCount = {&H2, &H0}
                            enetCMPacket.nullAddressItem = {&H0, &H0}
                            enetCMPacket.nullAddressItemLength = {&H0, &H0}
                            enetCMPacket.unconnectedDataItem = {&HB2, &H0}
                            enetCMPacket.unconnectedDataItemLength = {&H32, &H0}
                            enetCMPacket.service = {&H54}
                            enetCMPacket.pathSize = {&H2}
                            enetCMPacket.classPathSegment = {&H20}
                            enetCMPacket.classType = {&H6}
                            enetCMPacket.instancePathSegment = {&H24}
                            enetCMPacket.InstanceType = {&H1}
                            enetCMPacket.actualTimeOut = {&H0, &HFA}
                            enetCMPacket.OtoT_NetworkConnID = {&H0, &H0, &H0, &H0}
                            enetCMPacket.TtoO_NetworkConnID = {&H1, &H0, &H0, &H20}
                            enetCMPacket.connSerialNumber = {&HDB, &HE5}
                            enetCMPacket.vendorID = {&H41, &H53}
                            enetCMPacket.originatorSerialNumber = {&H1, &H2, &H4, &H8}
                            enetCMPacket.connTimoutMultiplier = {&H2}
                            enetCMPacket.RESERVED = {&H0, &H0, &H0}
                            enetCMPacket.OtoT_RPI = {&H80, &H84, &H1E, &H0}
                            enetCMPacket.OtoT_ConnParameters = {&HF4, &H43}
                            enetCMPacket.TtoO_RPI = {&H80, &H84, &H1E, &H0}
                            enetCMPacket.TtoO_ConnParameters = {&HF4, &H43}
                            enetCMPacket.transportType = {&HA3}
                            enetCMPacket.connPathSize = {&H4}
                            enetCMPacket.port = {&H1}
                            enetCMPacket.linkAddress = {&H0}
                            enetCMPacket.messageRouterPath = {&H20, &H2}
                            enetCMPacket.instancePath = {&H24, &H1}
                            enetCMPacket.pathType = {&H2C}
                            enetCMPacket.connPoint = {&H1}

                            ' Create Buffer
                            Dim enetCMBuffer() As Byte = {enetCMPacket.command(0), enetCMPacket.command(1), enetCMPacket.length(0), enetCMPacket.length(1), _
                                                            enetCMPacket.sessionHandle(0), enetCMPacket.sessionHandle(1), enetCMPacket.sessionHandle(2), enetCMPacket.sessionHandle(3), _
                                                            enetCMPacket.successStatus(0), enetCMPacket.successStatus(1), enetCMPacket.successStatus(2), enetCMPacket.successStatus(3), _
                                                            enetCMPacket.senderContext(0), enetCMPacket.senderContext(1), enetCMPacket.senderContext(2), enetCMPacket.senderContext(3), _
                                                            enetCMPacket.senderContext(4), enetCMPacket.senderContext(5), enetCMPacket.senderContext(6), enetCMPacket.senderContext(7), _
                                                            enetCMPacket.options(0), enetCMPacket.options(1), enetCMPacket.options(2), enetCMPacket.options(3), _
                                                            enetCMPacket.interfaceHandle(0), enetCMPacket.interfaceHandle(1), enetCMPacket.interfaceHandle(2), enetCMPacket.interfaceHandle(3), _
                                                            enetCMPacket.timeout(0), enetCMPacket.timeout(1), enetCMPacket.itemCount(0), enetCMPacket.itemCount(1), _
                                                            enetCMPacket.nullAddressItem(0), enetCMPacket.nullAddressItem(1), enetCMPacket.nullAddressItemLength(0), enetCMPacket.nullAddressItemLength(1), _
                                                            enetCMPacket.unconnectedDataItem(0), enetCMPacket.unconnectedDataItem(1), enetCMPacket.unconnectedDataItemLength(0), enetCMPacket.unconnectedDataItemLength(1), _
                                                            enetCMPacket.service(0), enetCMPacket.pathSize(0), enetCMPacket.classPathSegment(0), enetCMPacket.classType(0), _
                                                            enetCMPacket.instancePathSegment(0), enetCMPacket.InstanceType(0), enetCMPacket.actualTimeOut(0), enetCMPacket.actualTimeOut(1), _
                                                            enetCMPacket.OtoT_NetworkConnID(0), enetCMPacket.OtoT_NetworkConnID(1), enetCMPacket.OtoT_NetworkConnID(2), enetCMPacket.OtoT_NetworkConnID(3), _
                                                            enetCMPacket.TtoO_NetworkConnID(0), enetCMPacket.TtoO_NetworkConnID(1), enetCMPacket.TtoO_NetworkConnID(2), enetCMPacket.TtoO_NetworkConnID(3), _
                                                            enetCMPacket.connSerialNumber(0), enetCMPacket.connSerialNumber(1), enetCMPacket.vendorID(0), enetCMPacket.vendorID(1), _
                                                            enetCMPacket.originatorSerialNumber(0), enetCMPacket.originatorSerialNumber(1), enetCMPacket.originatorSerialNumber(2), enetCMPacket.originatorSerialNumber(3), _
                                                            enetCMPacket.connTimoutMultiplier(0), enetCMPacket.RESERVED(0), enetCMPacket.RESERVED(1), enetCMPacket.RESERVED(2), _
                                                            enetCMPacket.OtoT_RPI(0), enetCMPacket.OtoT_RPI(1), enetCMPacket.OtoT_RPI(2), enetCMPacket.OtoT_RPI(3), _
                                                            enetCMPacket.OtoT_ConnParameters(0), enetCMPacket.OtoT_ConnParameters(1), enetCMPacket.TtoO_RPI(0), enetCMPacket.TtoO_RPI(1), _
                                                            enetCMPacket.TtoO_RPI(2), enetCMPacket.TtoO_RPI(3), enetCMPacket.TtoO_ConnParameters(0), enetCMPacket.TtoO_ConnParameters(1), _
                                                            enetCMPacket.transportType(0), enetCMPacket.connPathSize(0), enetCMPacket.port(0), enetCMPacket.linkAddress(0), _
                                                            enetCMPacket.messageRouterPath(0), enetCMPacket.messageRouterPath(1), enetCMPacket.instancePath(0), enetCMPacket.instancePath(1), _
                                                            enetCMPacket.pathType(0), enetCMPacket.connPoint(0)}

                            ' Write "Connection Manager" to network
                            plcClientStream.Write(enetCMBuffer, 0, 90)

                            ' Reset "Connection Manager" Trigger
                            enetConnectionManagerTrigger = False

                        End If

                    Case &H6F           ' (0x6f): Send RR Data
                        ' Check if connection manager response service, extract "Connection ID"
                        If myReadBuffer(40) = &HD4 Then         ' (0xd4): Connection Manager "Forward_Open" response
                            Dim j As Byte           ' "For Loop" indexer
                            For j = 0 To 3
                                enetConnectionID(j) = myReadBuffer(j + 44)          ' Store "Session Handle"
                            Next
                        End If
                End Select
            End If

        End If
    End Sub


    '------------------------------------- W R I T E   D A T A -------------------------------------

    Private Sub btnSendData_Click(sender As Object, e As EventArgs) Handles btnSendData.Click
        Select Case connectionType
            Case 0          ' Rockwell TCP/IP

                ' Declare eFlex TNT Header Structure
                Dim header As eFlexHeader

                ' Build eFlex TNT Header Structure
                header.deviceType = CInt(txtHeaderDeviceType.Text)
                header.spare0 = 0
                header.spare1 = 0
                header.spare2 = 0
                header.spare3 = 0
                header.spare4 = 0
                header.spare5 = 0
                header.stationID = CInt(txtStationID.Text)
                header.footprintID = 0
                header.softwareName_00 = Asc(txtSoftware_00.Text)
                header.softwareName_01 = Asc(txtSoftware_01.Text)
                header.softwareName_02 = Asc(txtSoftware_02.Text)
                header.softwareName_03 = Asc(txtSoftware_03.Text)
                header.softwareName_04 = Asc(txtSoftware_04.Text)
                header.softwareName_05 = Asc(txtSoftware_05.Text)
                header.softwareName_06 = Asc(txtSoftware_06.Text)
                header.softwareName_07 = Asc(txtSoftware_07.Text)
                header.stationIndex = 0
                header.shortDescription_00 = 0
                header.shortDescription_01 = 0
                header.shortDescription_02 = 0
                header.shortDescription_03 = 0
                header.shortDescription_04 = 0
                header.shortDescription_05 = 0
                header.shortDescription_06 = 0
                header.shortDescription_07 = 0
                header.shortDescription_08 = 0
                header.shortDescription_09 = 0
                header.shortDescription_10 = 0
                header.bufferedDuration = 0
                header.packetID = CInt(txtPacketType.Text)
                header.numberPackets = CInt(txtPacketCount.Text)
                header.lengthPacket = CInt(txtPacketLength.Text)

                ' Marshaling "headerTnT" Structure (to Byte array)
                Dim headerBytes() As Byte           ' Must convert "header Structure" to "Byte Array" for writing data to network
                Dim headerPtr As IntPtr = Marshal.AllocHGlobal(Marshal.SizeOf(header))
                ReDim headerBytes(Marshal.SizeOf(header) - 1)
                Marshal.StructureToPtr(header, headerPtr, False)
                Marshal.Copy(headerPtr, headerBytes, 0, Marshal.SizeOf(header))
                Marshal.FreeHGlobal(headerPtr)

                ' Declare Part Status Bits (32)
                Dim partStatusDataBits(3) As Byte

                partStatusDataBits(0) = 0

                partStatusDataBits(1) = 0

                partStatusDataBits(2) = 0

                partStatusDataBits(3) = 0

                ' Part Status "SN Echo" (44 Bytes)
                Dim partStatusSNEcho(43) As Byte
                Dim i As SByte
                For i = 0 To 43
                    partStatusSNEcho(i) = 0         ' Fill with zeros for now (temporary)
                Next

                ' Part Status Packet Buffer
                Dim partStatusBuffer() As Byte
                'ReDim partStatusBuffer()
                ReDim partStatusBuffer(CInt(txtPacketLength.Text) + 44 - 1)
                Buffer.BlockCopy(headerBytes, 0, partStatusBuffer, 0, 44)           ' Write HEADER
                If (CInt(txtPacketLength.Text)) > (44 + 4) Then
                    Buffer.BlockCopy(partStatusDataBits, 0, partStatusBuffer, 44, 4)            ' Write STATUS 
                    If (CInt(txtPacketLength.Text)) > (44 + 4 + 44) Then
                        Buffer.BlockCopy(partStatusSNEcho, 0, partStatusBuffer, 48, 44)         ' Write SERIAL NUMBER ECHO
                    End If
                End If

                If chkHeaderSeperate.Checked Then
                    ' Write TCP data to network
                    plcClientStream.Write(partStatusBuffer, 0, 44)          ' Send Header
                    plcClientStream.Write(partStatusBuffer, 44, CInt(txtPacketLength.Text))         ' Send Payload
                Else
                    ' Write TCP data to network
                    plcClientStream.Write(partStatusBuffer, 0, CInt(txtPacketLength.Text) + 44)         ' Send header and payload together
                End If

            Case 1          ' Rockwell EtherNetIP - Explicit
                Dim enetMSPacket As EtherNetIP_SendUnitDataOutgoing
                ' Encapsulated Header
                enetMSPacket.command = {&H70, &H0}
                enetMSPacket.length = {&H30, &H0}           ' Length of "Command Specific Data"
                enetMSPacket.sessionHandle = {enetSessionHandle(0), enetSessionHandle(1), enetSessionHandle(2), enetSessionHandle(3)}
                enetMSPacket.successStatus = {&H0, &H0, &H0, &H0}
                enetMSPacket.senderContext = {enetSenderContext(0), enetSenderContext(1), enetSenderContext(2), enetSenderContext(3), _
                                              enetSenderContext(4), enetSenderContext(5), enetSenderContext(6), enetSenderContext(7)}
                enetMSPacket.options = {&H0, &H0, &H0, &H0}
                ' Encapsulated Data
                enetMSPacket.interfaceHandle = {&H0, &H0, &H0, &H0}         ' Always {0,0,0,0} for type: CIP
                enetMSPacket.timeout = {&H0, &H0}           ' Always {0,0} for "SendUnitData" service
                enetMSPacket.addressItemCount = {&H2, &H0}          ' Number of items in "CPF" (Always 2 for "SendUnitData")
                enetMSPacket.addressItemType = {&HA1, &H0}           ' Always {&HA1,&H0} for "Connected Address Item"
                enetMSPacket.addressItemDataLength = {&H4, &H0}         ' Length of "addressItemData" (in bytes)
                enetMSPacket.addressItemData = {enetConnectionID(0), enetConnectionID(1), enetConnectionID(2), enetConnectionID(3)}           ' Contains "CONNECTION ID"
                enetMSPacket.dataItemType = {&HB1, &H0}          ' Always {&HB1,&H0} for "Connected Data Item"
                enetMSPacket.dataItemDataLength = {&H1C, &H0}            ' Length of "CIP" data
                enetMSPacket.sequenceCount = {&H0, &H0}
                enetMSPacket.requestService = {&HA}         ' Multiple Service Request: 0x0A
                enetMSPacket.requestPathSize = {&H2}            ' Request Path Size: 2 Words
                enetMSPacket.requestPath = {&H20, &H2, &H24, &H1}           ' Logical Segment: Class 0x02, Instance 01 (Message Router)
                enetMSPacket.requestData_NumberServicesIncluded = {&H1, &H0}            ' Number of services included in "MSP"
                enetMSPacket.requestData_OffsetsPerService = {&H4, &H0}         ' Start location of service from begining of "requestData" (in bytes)
                enetMSPacket.requestData_FirstService = {enetSendRequestService(0), enetSendRequestPathSize(0), enetSendRequestPath(0), enetSendRequestPath(1), _
                                                         enetSendRequestPath(2), enetSendRequestPath(3), enetSendRequestPath(4), enetSendRequestPath(5), _
                                                         enetSendRequestPath(6), enetSendRequestPath(7), enetSendRequestPath(8), enetSendRequestPath(9), _
                                                         enetSendRequestPath(10), enetSendRequestPath(11), enetSendRequestData(0), enetSendRequestData(1)}

                ' Create Buffer
                Dim enetMSPBuffer() As Byte = {enetMSPacket.command(0), enetMSPacket.command(1), enetMSPacket.length(0), enetMSPacket.length(1), _
                                               enetMSPacket.sessionHandle(0), enetMSPacket.sessionHandle(1), enetMSPacket.sessionHandle(2), enetMSPacket.sessionHandle(3), _
                                               enetMSPacket.successStatus(0), enetMSPacket.successStatus(1), enetMSPacket.successStatus(2), enetMSPacket.successStatus(3), _
                                               enetMSPacket.senderContext(0), enetMSPacket.senderContext(1), enetMSPacket.senderContext(2), enetMSPacket.senderContext(3), _
                                               enetMSPacket.senderContext(4), enetMSPacket.senderContext(5), enetMSPacket.senderContext(6), enetMSPacket.senderContext(7), _
                                               enetMSPacket.options(0), enetMSPacket.options(1), enetMSPacket.options(2), enetMSPacket.options(3), _
                                               enetMSPacket.interfaceHandle(0), enetMSPacket.interfaceHandle(1), enetMSPacket.interfaceHandle(2), enetMSPacket.interfaceHandle(3), _
                                               enetMSPacket.timeout(0), enetMSPacket.timeout(1), enetMSPacket.addressItemCount(0), enetMSPacket.addressItemCount(1), _
                                               enetMSPacket.addressItemType(0), enetMSPacket.addressItemType(1), enetMSPacket.addressItemDataLength(0), enetMSPacket.addressItemDataLength(1), _
                                               enetMSPacket.addressItemData(0), enetMSPacket.addressItemData(1), enetMSPacket.addressItemData(2), enetMSPacket.addressItemData(3), _
                                               enetMSPacket.dataItemType(0), enetMSPacket.dataItemType(1), enetMSPacket.dataItemDataLength(0), enetMSPacket.dataItemDataLength(1), _
                                               enetMSPacket.sequenceCount(0), enetMSPacket.sequenceCount(1), enetMSPacket.requestService(0), enetMSPacket.requestPathSize(0), _
                                               enetMSPacket.requestPath(0), enetMSPacket.requestPath(1), enetMSPacket.requestPath(2), enetMSPacket.requestPath(3), _
                                               enetMSPacket.requestData_NumberServicesIncluded(0), enetMSPacket.requestData_NumberServicesIncluded(1), enetMSPacket.requestData_OffsetsPerService(0), enetMSPacket.requestData_OffsetsPerService(1), _
                                               enetMSPacket.requestData_FirstService(0), enetMSPacket.requestData_FirstService(1), enetMSPacket.requestData_FirstService(2), enetMSPacket.requestData_FirstService(3), _
                                               enetMSPacket.requestData_FirstService(4), enetMSPacket.requestData_FirstService(5), enetMSPacket.requestData_FirstService(6), enetMSPacket.requestData_FirstService(7), _
                                               enetMSPacket.requestData_FirstService(8), enetMSPacket.requestData_FirstService(9), enetMSPacket.requestData_FirstService(10), enetMSPacket.requestData_FirstService(11), _
                                               enetMSPacket.requestData_FirstService(12), enetMSPacket.requestData_FirstService(13), enetMSPacket.requestData_FirstService(14), enetMSPacket.requestData_FirstService(15)}

                ' Write Explicit Data to EtherNetIP Network
                plcClientStream.Write(enetMSPBuffer, 0, 72)

            Case 2          ' Siemens TCP/IP

                ' Declare eFlex TNT Header Structure
                Dim header As eFlexHeader

                ' Build eFlex TNT Header Structure
                header.deviceType = CInt(txtHeaderDeviceType.Text)
                header.spare0 = 0
                header.spare1 = 0
                header.spare2 = 0
                header.spare3 = 0
                header.spare4 = 0
                header.spare5 = 0
                header.stationID = CInt(txtStationID.Text)
                header.footprintID = 0
                header.softwareName_00 = Asc(txtSoftware_00.Text)
                header.softwareName_01 = Asc(txtSoftware_01.Text)
                header.softwareName_02 = Asc(txtSoftware_02.Text)
                header.softwareName_03 = Asc(txtSoftware_03.Text)
                header.softwareName_04 = Asc(txtSoftware_04.Text)
                header.softwareName_05 = Asc(txtSoftware_05.Text)
                header.softwareName_06 = Asc(txtSoftware_06.Text)
                header.softwareName_07 = Asc(txtSoftware_07.Text)
                header.stationIndex = 0
                header.shortDescription_00 = 0
                header.shortDescription_01 = 0
                header.shortDescription_02 = 0
                header.shortDescription_03 = 0
                header.shortDescription_04 = 0
                header.shortDescription_05 = 0
                header.shortDescription_06 = 0
                header.shortDescription_07 = 0
                header.shortDescription_08 = 0
                header.shortDescription_09 = 0
                header.shortDescription_10 = 0
                header.bufferedDuration = 0
                header.packetID = CInt(txtPacketType.Text)
                header.numberPackets = CInt(txtPacketCount.Text)
                header.lengthPacket = CInt(txtPacketLength.Text)



                ' Marshaling "headerTnT" Structure (to Byte array)
                Dim headerBytes() As Byte           ' Must convert "header Structure" to "Byte Array" for writing data to network
                Dim headerPtr As IntPtr = Marshal.AllocHGlobal(Marshal.SizeOf(header))
                ReDim headerBytes(Marshal.SizeOf(header) - 1)

                ' --- Convert from little, to big endian ---
                ' Device type
                Dim bytes(2) As Byte
                bytes = BitConverter.GetBytes(header.deviceType)
                Array.Reverse(bytes)
                Buffer.BlockCopy(bytes, 0, headerBytes, 0, 2)

                ' Spare Bytes
                ReDim bytes(1)
                bytes = BitConverter.GetBytes(header.spare0)
                Buffer.BlockCopy(bytes, 0, headerBytes, 2, 1)
                bytes = BitConverter.GetBytes(header.spare1)
                Buffer.BlockCopy(bytes, 0, headerBytes, 3, 1)
                bytes = BitConverter.GetBytes(header.spare2)
                Buffer.BlockCopy(bytes, 0, headerBytes, 4, 1)
                bytes = BitConverter.GetBytes(header.spare3)
                Buffer.BlockCopy(bytes, 0, headerBytes, 5, 1)
                bytes = BitConverter.GetBytes(header.spare4)
                Buffer.BlockCopy(bytes, 0, headerBytes, 6, 1)
                bytes = BitConverter.GetBytes(header.spare5)
                Buffer.BlockCopy(bytes, 0, headerBytes, 7, 1)

                ' StationID
                ReDim bytes(2)
                bytes = BitConverter.GetBytes(header.stationID)
                Array.Reverse(bytes)
                Buffer.BlockCopy(bytes, 0, headerBytes, 8, 2)

                ' FootprintID
                ReDim bytes(2)
                bytes = BitConverter.GetBytes(header.footprintID)
                Array.Reverse(bytes)
                Buffer.BlockCopy(bytes, 0, headerBytes, 10, 2)

                ' Software Bytes
                ReDim bytes(1)
                bytes = BitConverter.GetBytes(header.softwareName_00)
                Buffer.BlockCopy(bytes, 0, headerBytes, 12, 1)
                bytes = BitConverter.GetBytes(header.softwareName_01)
                Buffer.BlockCopy(bytes, 0, headerBytes, 13, 1)
                bytes = BitConverter.GetBytes(header.softwareName_02)
                Buffer.BlockCopy(bytes, 0, headerBytes, 14, 1)
                bytes = BitConverter.GetBytes(header.softwareName_03)
                Buffer.BlockCopy(bytes, 0, headerBytes, 15, 1)
                bytes = BitConverter.GetBytes(header.softwareName_04)
                Buffer.BlockCopy(bytes, 0, headerBytes, 16, 1)
                bytes = BitConverter.GetBytes(header.softwareName_05)
                Buffer.BlockCopy(bytes, 0, headerBytes, 17, 1)
                bytes = BitConverter.GetBytes(header.softwareName_06)
                Buffer.BlockCopy(bytes, 0, headerBytes, 18, 1)
                bytes = BitConverter.GetBytes(header.softwareName_07)
                Buffer.BlockCopy(bytes, 0, headerBytes, 19, 1)

                ' Station Index
                ReDim bytes(1)
                bytes = BitConverter.GetBytes(header.stationIndex)
                Buffer.BlockCopy(bytes, 0, headerBytes, 20, 1)

                ' Short Description Bytes
                ReDim bytes(1)
                bytes = BitConverter.GetBytes(header.shortDescription_00)
                Buffer.BlockCopy(bytes, 0, headerBytes, 21, 1)
                bytes = BitConverter.GetBytes(header.shortDescription_01)
                Buffer.BlockCopy(bytes, 0, headerBytes, 22, 1)
                bytes = BitConverter.GetBytes(header.shortDescription_02)
                Buffer.BlockCopy(bytes, 0, headerBytes, 23, 1)
                bytes = BitConverter.GetBytes(header.shortDescription_03)
                Buffer.BlockCopy(bytes, 0, headerBytes, 24, 1)
                bytes = BitConverter.GetBytes(header.shortDescription_04)
                Buffer.BlockCopy(bytes, 0, headerBytes, 25, 1)
                bytes = BitConverter.GetBytes(header.shortDescription_05)
                Buffer.BlockCopy(bytes, 0, headerBytes, 26, 1)
                bytes = BitConverter.GetBytes(header.shortDescription_06)
                Buffer.BlockCopy(bytes, 0, headerBytes, 27, 1)
                bytes = BitConverter.GetBytes(header.shortDescription_07)
                Buffer.BlockCopy(bytes, 0, headerBytes, 28, 1)
                bytes = BitConverter.GetBytes(header.shortDescription_08)
                Buffer.BlockCopy(bytes, 0, headerBytes, 29, 1)
                bytes = BitConverter.GetBytes(header.shortDescription_09)
                Buffer.BlockCopy(bytes, 0, headerBytes, 30, 1)
                bytes = BitConverter.GetBytes(header.shortDescription_10)
                Buffer.BlockCopy(bytes, 0, headerBytes, 31, 1)

                ' Buffered Duration Bytes
                ReDim bytes(4)
                bytes = BitConverter.GetBytes(header.bufferedDuration)
                Array.Reverse(bytes)
                Buffer.BlockCopy(bytes, 0, headerBytes, 32, 4)

                ' PacketID
                ReDim bytes(2)
                bytes = BitConverter.GetBytes(header.packetID)
                Array.Reverse(bytes)
                Buffer.BlockCopy(bytes, 0, headerBytes, 36, 2)

                ' Number of Packets
                ReDim bytes(2)
                bytes = BitConverter.GetBytes(header.numberPackets)
                Array.Reverse(bytes)
                Buffer.BlockCopy(bytes, 0, headerBytes, 38, 2)

                ' Packet Legnth
                ReDim bytes(4)
                bytes = BitConverter.GetBytes(header.lengthPacket)
                Array.Reverse(bytes)
                Buffer.BlockCopy(bytes, 0, headerBytes, 40, 4)


                ' --- Populate Payload Data ---
                ' Declare Part Status Bits (32)
                Dim partStatusDataBits(3) As Byte

                partStatusDataBits(0) = 0

                partStatusDataBits(1) = 0

                partStatusDataBits(2) = 0

                partStatusDataBits(3) = 0

                ' Part Status "SN Echo" (44 Bytes)
                Dim partStatusSNEcho(43) As Byte
                Dim i As SByte
                For i = 0 To 43
                    partStatusSNEcho(i) = 0         ' Fill with zeros for now (temporary)
                Next

                ' Part Status Packet Buffer
                Dim partStatusBuffer() As Byte
                'ReDim partStatusBuffer()
                ReDim partStatusBuffer(CInt(txtPacketLength.Text) + 44 - 1)
                Buffer.BlockCopy(headerBytes, 0, partStatusBuffer, 0, 44)           ' Write HEADER
                If (CInt(txtPacketLength.Text)) > (44 + 4) Then
                    Buffer.BlockCopy(partStatusDataBits, 0, partStatusBuffer, 44, 4)            ' Write STATUS 
                    If (CInt(txtPacketLength.Text)) > (44 + 4 + 44) Then
                        Buffer.BlockCopy(partStatusSNEcho, 0, partStatusBuffer, 48, 44)         ' Write SERIAL NUMBER ECHO
                    End If
                End If

                If chkHeaderSeperate.Checked Then
                    ' Write TCP data to network
                    plcClientStream.Write(partStatusBuffer, 0, 44)          ' Send Header
                    plcClientStream.Write(partStatusBuffer, 44, CInt(txtPacketLength.Text))         ' Send Payload
                Else
                    ' Write TCP data to network
                    plcClientStream.Write(partStatusBuffer, 0, CInt(txtPacketLength.Text) + 44)         ' Send header and payload together
                End If

        End Select

    End Sub


    '------------------------------------- C O L L E C T   U S E R   I N P U T -------------------------------------

    ' User is changing connection type
    Private Sub comboDeviceType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboDeviceType.SelectedIndexChanged
        If comboDeviceType.SelectedIndex = 0 Then
            ' User has chosen "Rockwell TCP"
            connectionType = 0
            txtPort.Text = ""
            txtPort.BackColor = Color.White
            txtPort.ReadOnly = False         ' Allow user to make changes to communication settings
        ElseIf comboDeviceType.SelectedIndex = 1 Then
            ' User has chosen "EtherNetIP Server - Explicit Messaging"
            connectionType = 1
            txtPort.Text = 44818            ' Ethernet IP - Explicit Messaging TCP port
            txtPort.BackColor = Color.LightGray            ' Grey-Out "Port" textbox
            txtPort.ReadOnly = True         ' Allow user to make changes to communication settings
        ElseIf comboDeviceType.SelectedIndex = 2 Then
            ' User has chosen "Siemens TCP"
            connectionType = 2
            txtPort.Text = ""
            txtPort.BackColor = Color.White
            txtPort.ReadOnly = False
        End If
    End Sub

    ' User is entering a Hostname
    Private Sub txtHostname_TextChanged(sender As Object, e As EventArgs) Handles txtHostname.TextChanged
        userHostname = txtHostname.Text         ' Assign user defined hostname to form memory
    End Sub

    ' User is entering a Port Number
    Private Sub txtPort_TextChanged(sender As Object, e As EventArgs) Handles txtPort.TextChanged
        If Not Integer.TryParse(txtPort.Text, userPort) And (txtPort.Text <> "") Then
            invalidPort()           ' Invalid Port detected
        End If
    End Sub


    '------------------------------------- M I S C E L L A N E O U S -------------------------------------

    ' Form Load
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Initialize "Device Type" combo box to: "Rockwell TCP/IP"
        comboDeviceType.SelectedIndex = 0

        ' Initialize TcpClient RevieveBufferSize
        plcClients.ReceiveBufferSize = 1024

    End Sub


    '------------------------------------- S U B R O U T I N E   A R E A -------------------------------------
    '-------------------------------------------------------------------------------------------------------------

    '----- MULTITHREADING TEST -----
    '' Subroutine to handle multithreading once connected
    'Private Sub connectedThread()
    '    Dim thread As System.Threading.Thread           ' Declare a thread type
    '    thread = New System.Threading.Thread(AddressOf readSocketData)         ' New thread at "Private Sub connect()"
    '    thread.Start()          ' Start our new thread
    'End Sub

    '' Subroutine to handle NetworkStream thread
    'Private Sub readSocketData()
    '    Dim plcClientStream As NetworkStream = plcClients.GetStream()            ' Provide the stream of data for network access as "plcClientStream"
    '    MessageBox.Show("Monitoring NetworkStream")
    '    While connected
    '        If plcClientStream.CanRead Then         ' NetworkStream supports reading
    '            Dim myReadBuffer(462) As Byte
    '            Dim myReadSize As Integer = 0

    '            Do
    '                myReadSize = plcClientStream.Read(myReadBuffer, 0, myReadBuffer.Length)
    '            Loop While plcClientStream.DataAvailable

    '            tempval = tempval + myReadSize

    '        End If
    '    End While
    '    MessageBox.Show("Disconnected, no longer monitoring NetworkStream")
    'End Sub
    '-------------------------------

    ' Subroutine to handle outgoing connection requests
    Private Sub connect()
        ' Required TRY/CATCH/END TRY. This "Tries" to create a connection.
        ' If the TCP Client can NOT connect, an exception would throw. We need to catch it.
        Try
            ' Assign our TCP Client to a new socket for the new connection request
            plcClients = New TcpClient(userHostname, userPort)            ' (hostname As String, port As Integer)
            plcClientStream = plcClients.GetStream()            ' Provide the stream of data for network access as "plcClientStream"

            ' Assign global connection bit, update user display settings
            If plcClients.Connected Then
                connected = True            ' Set connection bit
                tmrNetworkStream.Start()            ' Start monitoring NetworkStream
            End If

            updateUI(connected)         ' Update UI based on connection status

        Catch sockException As SocketException
            connected = False           ' Reset connection bit

            ' Let user know TCP Client could not connect
            MessageBox.Show("Could not establish connection. Please check your settings, interfaces, cables, etc! " & vbCrLf _
                            & vbCrLf _
                            & "SocketException:" & vbCrLf _
                            & sockException.ToString)
        End Try

        ' Define "Received Buffer Size"
        plcClients.ReceiveBufferSize = 1024

        ' If using EtherNetIP-Explicit, initiate session
        If connectionType = 1 Then
            ' "Register Session" packet is required to open an EtherNetIP session after making TCP connection. Server will respond with "Session Handle".
            ' Command: (0x0065) = Register Session
            ' Length: (0x0004) = Length of data section ("Command Specific Data")
            ' Session Handle: (0x00000000) = Unique "ID" for session, must be zero when initiating connection. Server will respond with handle for future packets
            ' Status: (0x00000000) = Status of controller, must be zero "Success"
            ' Sender Context: (0x65466c6578303031) = "eFlex001", Unique ID from client, used to manage multiple sessions from same client. Server will echo the client sender context
            ' Options: (0x00000000) = Must be zero
            ' Protocol Version: (0x0001) = Must be one
            ' Option Flags: (0x0000) = reserved
            Dim registerSession() As Byte = {&H65, &H0, &H4, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, enetSenderContext(0), enetSenderContext(1), enetSenderContext(2), enetSenderContext(3), _
                                  enetSenderContext(4), enetSenderContext(5), enetSenderContext(6), enetSenderContext(7), &H0, &H0, &H0, &H0, &H1, &H0, &H0, &H0}

            ' Write Data to Network
            plcClientStream.Write(registerSession, 0, 28)
            enetConnectionManagerTrigger = True          ' Trigger connection manager packet

        End If

    End Sub

    ' Subroutine to handle disconnect requests
    Private Sub disconnect()
        If connected Then
            plcClients.Close()          ' Request that the TCP connection be closed
            connected = False           ' Reset connection bit
            tmrNetworkStream.Stop()            ' Stop monitoring NetworkStream
        End If
    End Sub

    ' Subroutine to handle UI changes based on connection status
    Private Sub updateUI(ByVal connectionStatus As Boolean)

        If connectionStatus = True Then            ' If connected, update UI to reflect this
            btnConnect.Enabled = False         ' Disable "Connect" button
            btnDisconnect.Enabled = True            ' Enable "Disconnect" button
            btnDisconnect.Focus()           ' Assign focus to "Disconnect" button
            btnConnect.Text = "Connected"           ' Let user know that they are connected by changing display text of "Connect" button
            txtHostname.BackColor = Color.LightGreen           ' Grey-Out "Hostname" textbox
            txtPort.BackColor = Color.LightGreen           ' Grey-Out "Port" textbox
            txtHostname.ReadOnly = True         ' Do not allow user to make changes to communication settings
            txtPort.ReadOnly = True         ' Do not allow user to make changes to communication settings
            grpRead.Visible = True          ' Display Recieved Data UI
            comboDeviceType.Enabled = False         ' Dissalow changes to "Device Type" while connected
            btnSendData.Visible = True      ' Connected, allow user to write data
            ' Determine what portions of UI to display
            Select Case comboDeviceType.SelectedIndex
                Case 0          ' Rockwell TCP/IP
                    grpeFlexHeader.Visible = True           ' Since using RockwellTCP/IP device type, make header config available
                    pnleFlexHeader.Visible = True           ' Since using RockwellTCP/IP device type, make header config available
                    grpeFlexData.Visible = True           ' Since using RockwellTCP/IP device type, make data config available
                    pnleFlexData.Visible = True           ' Since using RockwellTCP/IP device type, make data config available
                Case 1          ' Rockwell EtherNetIP
                    grpeFlexHeader.Visible = False           ' Since using RockwellTCP/IP device type, make header config available
                    pnleFlexHeader.Visible = False           ' Since using RockwellTCP/IP device type, make header config available
                    grpeFlexData.Visible = False           ' Since using RockwellTCP/IP device type, make data config available
                    pnleFlexData.Visible = False           ' Since using RockwellTCP/IP device type, make data config available
                Case 2
                    grpeFlexHeader.Visible = True
                    pnleFlexHeader.Visible = True
                    grpeFlexData.Visible = True
                    pnleFlexData.Visible = True
            End Select

        Else            ' If not connected, update UI to reflect this
            btnConnect.Enabled = True         ' Disable "Connect" button
            btnDisconnect.Enabled = False            ' Enable "Disconnect" button
            btnConnect.Focus()           ' Assign focus to "Disconnect" button
            btnConnect.Text = "Connect"         ' Let user know that they can try to connect again by resetting display text of "Connect" button
            txtHostname.BackColor = Color.White          ' Grey-Out "Hostname" textbox
            txtPort.BackColor = Color.White            ' Grey-Out "Port" textbox
            txtHostname.ReadOnly = False         ' Allow user to make changes to communication settings
            txtPort.ReadOnly = False         ' Allow user to make changes to communication settings
            grpRead.Visible = False          ' Hide Recieved Data UI
            txtReadBuffer.Text = ""         ' Clear "Recieved Data" UI
            comboDeviceType.Enabled = True         ' Allow changes to "Device Type" while NOT connected
            grpeFlexHeader.Visible = False           ' Since NOT using RockwellTCP/IP device type, disable header config
            pnleFlexHeader.Visible = False           ' Since NOT using RockwellTCP/IP device type, disable header config
            grpeFlexData.Visible = False           ' Since NOT using RockwellTCP/IP device type, disable data config
            pnleFlexData.Visible = False           ' Since NOT using RockwellTCP/IP device type, disable data config
            btnSendData.Visible = False      ' NOT connected, DO NOT allow user to write data
            ' UI changes where EtherNetIP is selected
            If connectionType = 1 Then
                txtPort.Text = 44818            ' Ethernet IP - Explicit Messaging TCP port
                txtPort.BackColor = Color.LightGray            ' Grey-Out "Port" textbox
                txtPort.ReadOnly = True         ' Allow user to make changes to communication settings
            End If
        End If

    End Sub

    ' Subroutine to handle "Invalid Port Specified"
    Private Sub invalidPort()
        txtPort.Text = ""           ' Clear Entry
        MessageBox.Show("Please enter a valid port number: 1025 - 65535")           ' Alert user of fault 
        txtPort.Focus()         ' Place cursor in textbox
    End Sub

    ' Subroutine to handle "Invalid Hostname Specified"
    Private Sub invalidHost()
        txtHostname.Text = ""           ' Clear Entry
        MessageBox.Show("Invalid Hostname Specified")           ' Alert user of fault 
        txtHostname.Focus()         ' Place cursor in textbox
    End Sub

End Class
