﻿Imports Magna.DualTester.Plc.Core.PlcStrings
Imports System.Runtime.InteropServices

Namespace TesterApi
    <StructLayout(LayoutKind.Sequential)> Public Class Udt_Manual_Operators
        Public Clamps As Integer 'Bit 0=Fixture Release,Bit 1=FixtureLock,Bit 2=Bezel Clamp Adv,Bit 3=Bezel Clamp Ret,Bit 4=Connector6 Release,Bit 5=Connector6 Lock ,Bit 6=Part Vacuum On,Bit 7=Connector10 Release,Bit 8=Connector10 Lock
        Public Tooling As Integer
        Public Defog As Integer '	Decimal	Bit0=on	Read/Write	4	0
        Public MirrrorActuator As Integer '	Decimal	Bit0=Up,Bit1=Down,Bit2=Inboard,Bit3=Outboard	Read/Write	5	0
        Public TurnSignal As Integer '	Decimal	Bit0=on	Read/Write	6	0
        Public Gi As Integer '	Decimal	Bit0=on	Read/Write	7	0
        Public Pfold As Integer '	Decimal	Biit0= extend,Bit1=Retract	Read/Write	8	0
        Public MemoryCr As Integer '	Decimal	Bit0=on	Read/Write	9	0
        Public CameraItems As Integer '	Decimal	Bit0=on	Read/Write	11	0
        Public GlassPull As Integer '	Decimal	Bit0=on	Read/Write	11	0
        Public ColorCmds As Integer '	Decimal	Bit0=on	Read/Write	11	0
        Public BZI As Integer
        Public GroundCheck As Integer
        Public Pcode As New PlcString_82 '	Decimal	Bit0=on	Read/Write	11	0
        Public JoyStick As Integer
        Public PullTest As Integer
        Public TrapDoorProbe As Integer
        Public Ec As Integer
        Public CargoLamp As Integer
        Public Oats As Integer
    End Class
End Namespace