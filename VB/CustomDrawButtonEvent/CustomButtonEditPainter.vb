Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Drawing

Namespace CustomDrawButtonEvent
	Public Class CustomButtonEditPainter
		Inherits ButtonEditPainter
		Public Sub New()
		End Sub

		Protected Overrides Sub DrawButton(ByVal viewInfo As ButtonEditViewInfo, ByVal info As EditorButtonObjectInfoArgs)
			Dim e As New DrawButtonEventArgs(info)
			TryCast(viewInfo.Item, RepositoryItemMyButtonEdit).RaiseDrawButtonEvent(e)
			If (Not e.Handled) Then
				MyBase.DrawButton(viewInfo, info)
			End If
		End Sub

	End Class
End Namespace
