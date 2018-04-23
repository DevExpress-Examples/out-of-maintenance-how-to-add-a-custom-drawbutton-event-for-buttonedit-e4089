Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.Utils.Drawing
Imports System.Drawing
Imports DevExpress.Utils

Namespace CustomDrawButtonEvent

	Public Class DrawButtonEventArgs
		Public Sub New(ByVal info As EditorButtonObjectInfoArgs)
			Me.info = info
			handled_Renamed = False
		End Sub

		Private info As EditorButtonObjectInfoArgs
		Private handled_Renamed As Boolean


		Public Property Handled() As Boolean
			Get
				Return handled_Renamed
			End Get
			Set(ByVal value As Boolean)
				If handled_Renamed <> value Then
					handled_Renamed = value
				End If
			End Set
		End Property
		Public Property State() As ObjectState
			Get
				Return info.State
			End Get
			Set(ByVal value As ObjectState)
				If info.State <> value Then
					info.State = value
				End If
			End Set
		End Property

		Public ReadOnly Property Appearance() As AppearanceObject
			Get
				Return info.Appearance
			End Get
		End Property
		Public ReadOnly Property Index() As Integer
			Get
				Return info.Button.Index
			End Get
		End Property
		Public ReadOnly Property Caption() As String
			Get
				Return info.Button.Caption
			End Get
		End Property
		Public ReadOnly Property Graphics() As Graphics
			Get
				Return info.Graphics
			End Get
		End Property
		Public ReadOnly Property Cache() As GraphicsCache
			Get
				Return info.Cache
			End Get
		End Property
		Public ReadOnly Property Bounds() As Rectangle
			Get
				Return info.Bounds
			End Get
		End Property
		Public ReadOnly Property Image() As Image
			Get
				Return info.Button.Image
			End Get
		End Property
		Public ReadOnly Property Kind() As ButtonPredefines
			Get
				Return info.Button.Kind
			End Get
		End Property
		Public ReadOnly Property ImageLocation() As ImageLocation
			Get
				Return info.Button.ImageLocation
			End Get
		End Property
	End Class

End Namespace
