Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Registrator
Imports System.ComponentModel

Namespace CustomDrawButtonEvent
	Public Delegate Sub DrawButtonEventHandler(ByVal sender As Object, ByVal e As DrawButtonEventArgs)

	<UserRepositoryItem("Register")> _
	Public Class MyButtonEdit
		Inherits ButtonEdit

		Shared Sub New()
			RepositoryItemMyButtonEdit.Register()
		End Sub

		Public Sub New()
		End Sub


		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return RepositoryItemMyButtonEdit.EditorName
			End Get
		End Property


		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Shadows ReadOnly Property Properties() As RepositoryItemMyButtonEdit
			Get
				Return TryCast(MyBase.Properties, RepositoryItemMyButtonEdit)
			End Get
		End Property


		<Description("Occurs when custom editor buttons are being drawn."), Category(CategoryName.Events)> _
		Public Custom Event DrawButton As DrawButtonEventHandler
			AddHandler(ByVal value As DrawButtonEventHandler)
				AddHandler Properties.DrawButton, value
			End AddHandler
			RemoveHandler(ByVal value As DrawButtonEventHandler)
				RemoveHandler Properties.DrawButton, value
			End RemoveHandler
			RaiseEvent(ByVal sender As Object, ByVal e As DrawButtonEventArgs)
			End RaiseEvent
		End Event


	End Class
End Namespace
