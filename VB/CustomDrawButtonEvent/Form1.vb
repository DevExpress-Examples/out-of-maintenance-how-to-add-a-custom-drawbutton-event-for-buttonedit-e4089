Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports DevExpress.XtraEditors
Imports DevExpress.Utils.Drawing
Imports System.Drawing.Drawing2D
Imports System.Data
Imports DevExpress.XtraEditors.Controls

Namespace CustomDrawButtonEvent
	Partial Public Class Form1
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
			CreateDataSource()
			item = New RepositoryItemMyButtonEdit()
			ConfigureRepositoryItemButtonEdit(item)
		End Sub

		  Private item As RepositoryItemMyButtonEdit
		Private Sub ConfigureRepositoryItemButtonEdit(ByVal item As RepositoryItemMyButtonEdit)
			item.Buttons(0).Kind = ButtonPredefines.OK
			item.Buttons.Add(New EditorButton())
			AddHandler item.DrawButton, AddressOf myButtonEdit2_DrawButton
			gridControl1.RepositoryItems.Add(item)
			gridView1.Columns("Age").ColumnEdit = item
			gridView1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
		End Sub



		Private Sub CreateDataSource()
			Dim dataTable As New DataTable()
			dataTable.Columns.Add("Name", GetType(String))
			dataTable.Columns.Add("Age", GetType(Integer))
			dataTable.Rows.Add(New Object() { "John Smith", 32 })
			dataTable.Rows.Add(New Object() { "Ivanov", 23 })
			dataTable.Rows.Add(New Object() { "Petrov", 31 })
			dataTable.Rows.Add(New Object() { "John Smith", 32 })
			dataTable.Rows.Add(New Object() { "Ivanov", 2 })
			dataTable.Rows.Add(New Object() { "Petrov", 23 })
			dataTable.Rows.Add(New Object() { "John Smith", 42 })
			dataTable.Rows.Add(New Object() { "Ivanov", 25 })
			dataTable.Rows.Add(New Object() { "Petrov", 62 })
			dataTable.Rows.Add(New Object() { "John Smith", 12 })
			gridControl1.DataSource = dataTable
		End Sub

		Private Sub DrawCustomButton(ByVal e As DrawButtonEventArgs, ByVal textOffset As Integer)
			Using brush As New LinearGradientBrush(e.Bounds, Color.DarkBlue, Color.LightSkyBlue, 30)
				e.Graphics.FillRectangle(brush, e.Bounds)

			End Using

			e.Graphics.DrawLine(Pens.Black, New Point(e.Bounds.X + 1, e.Bounds.Y + 1), New Point(e.Bounds.Right, e.Bounds.Y + 1))
			e.Graphics.DrawLine(Pens.Black, New Point(e.Bounds.X + 1, e.Bounds.Y + 1), New Point(e.Bounds.X + 1, e.Bounds.Bottom - 2))
			e.Graphics.DrawLine(Pens.LightGray, New Point(e.Bounds.Right + 2, e.Bounds.Y + 2), New Point(e.Bounds.Right - 2, e.Bounds.Bottom - 2))
			e.Graphics.DrawLine(Pens.LightGray, New Point(e.Bounds.X + 2, e.Bounds.Bottom - 2), New Point(e.Bounds.Right - 2, e.Bounds.Bottom - 2))

			Using whiteBrush As New SolidBrush(Color.White)
				e.Graphics.DrawString(e.Caption, e.Appearance.GetFont(), whiteBrush, New Point(e.Bounds.X + textOffset, e.Bounds.Y + textOffset))
			End Using

			Using yellowBrush As New SolidBrush(Color.Yellow)
				Dim size As SizeF = e.Cache.CalcTextSize(e.Caption, e.Appearance.GetFont(), New StringFormat(), e.Bounds.Size.Width)
				e.Graphics.DrawString("...", e.Appearance.GetFont(), yellowBrush, New Point(e.Bounds.X + textOffset + 2 + CInt(Fix(size.Width)), e.Bounds.Y + 1))
			End Using
		End Sub

		Private Sub myButtonEdit1_DrawButton(ByVal sender As Object, ByVal e As DrawButtonEventArgs) Handles myButtonEdit1.DrawButton
			Select Case e.Index
				Case 0
					e.Handled = True
					Dim textOffset As Integer = 4
					DrawCustomButton(e, textOffset)
				Case 1
					If e.State = ObjectState.Hot OrElse e.State = ObjectState.Pressed OrElse e.State = ObjectState.Selected Then
						e.Appearance.BackColor = Color.LightSkyBlue
					End If
			End Select

			labelControl1.Text = "CustomEditButton1 " & "index = " & " " & e.Index.ToString() & " button State = " & e.State.ToString()
		End Sub

		Private Sub myButtonEdit2_DrawButton(ByVal sender As Object, ByVal e As DrawButtonEventArgs) Handles myButtonEdit2.DrawButton
			Select Case e.Index
				Case 0
					e.State = ObjectState.Hot
				Case 1
					e.Handled = True
					Dim textOffset As Integer = 0
					DrawCustomButton(e, textOffset)
			End Select

			labelControl2.Text = "CustomEditButton2 " & "index = " & " " & e.Index.ToString() & " button State = " & e.State.ToString()
		End Sub




		Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
			RemoveHandler item.DrawButton, AddressOf myButtonEdit2_DrawButton
		End Sub
	End Class
End Namespace
