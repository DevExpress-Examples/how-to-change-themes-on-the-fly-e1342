Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_PreInit(ByVal sender As Object, ByVal e As EventArgs)
		Dim c As HttpCookie = Request.Cookies("theme")
		If (c Is Nothing) Then Page.Theme = "Aqua" Else Page.Theme = c.Value

	End Sub
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim c As HttpCookie = Request.Cookies("theme")
		If (Not IsPostBack) AndAlso (c IsNot Nothing) Then
			rbList.Value = c.Value
		End If
	End Sub
End Class
