Imports Microsoft.VisualBasic
Imports System.Windows
Imports DevExpress.Xpf.Scheduler

Namespace WpfApplication1
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub
		#Region "#InplaceEditorShowing"
        Private Sub schedulerControl1_InplaceEditorShowing(ByVal sender As Object, _
                                                           ByVal e As InplaceEditorEventArgs)
            Dim editor As New CustomInplaceEditor(schedulerControl1, e.Appointment)
            e.InplaceEditor = editor
            editor.DataContext = editor
            e.Bounds = New Rect(e.Bounds.TopRight, New Size(editor.Width, editor.Height))
        End Sub
#End Region
	End Class
End Namespace