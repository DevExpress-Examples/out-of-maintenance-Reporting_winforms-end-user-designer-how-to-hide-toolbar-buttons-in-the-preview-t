Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraReports.Design
Imports DevExpress.XtraReports.UserDesigner
' ...

Namespace RibbonDesigner
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim rep As New XtraReport1()
			Dim form As New XRDesignRibbonFormEx()
			form.DesignPanel.OpenReport(rep)
			form.ShowDialog()
			Close()
		End Sub
	End Class
End Namespace