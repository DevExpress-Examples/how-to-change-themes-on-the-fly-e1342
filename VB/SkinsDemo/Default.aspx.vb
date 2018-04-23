Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web.UI.HtmlControls
Imports DevExpress.Web.ASPxEditors

Namespace Skins
	Partial Public Class _Default
		Inherits BasePage
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			CSSLink = "~/CSS/Default.css" ' Register css file
		End Sub
	End Class
End Namespace
