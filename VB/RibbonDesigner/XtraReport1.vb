Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
' ...

Namespace RibbonDesigner
	Partial Public Class XtraReport1
		Inherits XtraReport
		Public Sub New()
			InitializeComponent()
			PrintTool.MakeCommandResponsive(Me.PrintingSystem)
			PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Save, CommandVisibility.None)
		End Sub
	End Class
End Namespace
