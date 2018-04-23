Imports Microsoft.VisualBasic
Imports System
Namespace CustomDrawButtonEvent
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim serializableAppearanceObject1 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject2 As New DevExpress.Utils.SerializableAppearanceObject()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			Me.myButtonEdit2 = New CustomDrawButtonEvent.MyButtonEdit()
			Me.myButtonEdit1 = New CustomDrawButtonEvent.MyButtonEdit()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			CType(Me.myButtonEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myButtonEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' labelControl1
			' 
			Me.labelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
			Me.labelControl1.Location = New System.Drawing.Point(12, 12)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(75, 13)
			Me.labelControl1.TabIndex = 2
			Me.labelControl1.Text = "labelControl1"
			' 
			' defaultLookAndFeel1
			' 
			Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2010 Blue"
			' 
			' labelControl2
			' 
			Me.labelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
			Me.labelControl2.Location = New System.Drawing.Point(12, 70)
			Me.labelControl2.Name = "labelControl2"
			Me.labelControl2.Size = New System.Drawing.Size(75, 13)
			Me.labelControl2.TabIndex = 2
			Me.labelControl2.Text = "labelControl1"
			' 
			' myButtonEdit2
			' 
			Me.myButtonEdit2.Location = New System.Drawing.Point(12, 91)
			Me.myButtonEdit2.Name = "myButtonEdit2"
			Me.myButtonEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "test", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleLeft, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", Nothing, Nothing, True), New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.myButtonEdit2.Size = New System.Drawing.Size(100, 20)
			Me.myButtonEdit2.TabIndex = 4
'			Me.myButtonEdit2.DrawButton += New CustomDrawButtonEvent.DrawButtonEventHandler(Me.myButtonEdit2_DrawButton);
			' 
			' myButtonEdit1
			' 
			Me.myButtonEdit1.Location = New System.Drawing.Point(12, 31)
			Me.myButtonEdit1.Name = "myButtonEdit1"
			Me.myButtonEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK, "test", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleRight, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", Nothing, Nothing, True), New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.myButtonEdit1.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
			Me.myButtonEdit1.Properties.LookAndFeel.UseDefaultLookAndFeel = False
			Me.myButtonEdit1.Size = New System.Drawing.Size(100, 22)
			Me.myButtonEdit1.TabIndex = 3
'			Me.myButtonEdit1.DrawButton += New CustomDrawButtonEvent.DrawButtonEventHandler(Me.myButtonEdit1_DrawButton);
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Right
			Me.gridControl1.Location = New System.Drawing.Point(345, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(379, 262)
			Me.gridControl1.TabIndex = 5
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(724, 262)
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.myButtonEdit2)
			Me.Controls.Add(Me.myButtonEdit1)
			Me.Controls.Add(Me.labelControl2)
			Me.Controls.Add(Me.labelControl1)
			Me.LookAndFeel.SkinName = "DevExpress Dark Style"
			Me.Name = "Form1"
			Me.Text = "Custom DrawButton event"
'			Me.FormClosed += New System.Windows.Forms.FormClosedEventHandler(Me.Form1_FormClosed);
			CType(Me.myButtonEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myButtonEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private WithEvents myButtonEdit1 As MyButtonEdit
		Private WithEvents myButtonEdit2 As MyButtonEdit
		Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
		Private labelControl2 As DevExpress.XtraEditors.LabelControl
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
	End Class
End Namespace

