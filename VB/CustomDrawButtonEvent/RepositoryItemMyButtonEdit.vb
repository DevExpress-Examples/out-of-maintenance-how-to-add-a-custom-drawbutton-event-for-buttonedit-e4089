Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Registrator
Imports System.ComponentModel
Imports DevExpress.XtraEditors.ViewInfo

Namespace CustomDrawButtonEvent
	Public Class RepositoryItemMyButtonEdit
		Inherits RepositoryItemButtonEdit

		Shared Sub New()
			Register()
		End Sub

		Public Sub New()
		End Sub

		Friend Const EditorName As String = "MyButtonEdit"

		Public Shared Sub Register()
            EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(EditorName, GetType(MyButtonEdit), GetType(RepositoryItemMyButtonEdit), GetType(ButtonEditViewInfo), New CustomButtonEditPainter(), True, 0, GetType(DevExpress.Accessibility.ButtonEditAccessible)))

		End Sub

		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return EditorName
			End Get

		End Property

        Private Shared ReadOnly drawButtonField As Object = New Object()

        <Description("Occurs when custom editor buttons are being drawn."), Category(CategoryName.Events)> _
        Public Custom Event DrawButton As DrawButtonEventHandler
            AddHandler(ByVal value As DrawButtonEventHandler)
                Me.Events.AddHandler(drawButtonField, value)
            End AddHandler
            RemoveHandler(ByVal value As DrawButtonEventHandler)
                Me.Events.RemoveHandler(drawButtonField, value)
            End RemoveHandler
            RaiseEvent(ByVal sender As Object, ByVal e As DrawButtonEventArgs)
            End RaiseEvent
        End Event


        Protected Friend Overridable Sub RaiseDrawButtonEvent(ByVal e As DrawButtonEventArgs)
            Dim handler As DrawButtonEventHandler = CType(Me.Events(drawButtonField), DrawButtonEventHandler)
            If handler IsNot Nothing Then
                handler(GetEventSender(), e)
            End If

        End Sub

        Public Overrides Sub Assign(ByVal item As RepositoryItem)
            Dim source As RepositoryItemMyButtonEdit = TryCast(item, RepositoryItemMyButtonEdit)
            BeginUpdate()
            Try
                MyBase.Assign(item)
                If source Is Nothing Then
                    Return
                End If
            Finally
                EndUpdate()
            End Try
            Events.AddHandler(drawButtonField, source.Events(drawButtonField))
        End Sub

	End Class
End Namespace
