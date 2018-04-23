Imports System
Imports System.Web
Imports System.Web.UI

Partial Public Class _Default
	Inherits System.Web.UI.Page

	Protected Sub Page_PreInit(ByVal sender As Object, ByVal e As EventArgs)
		Dim c As HttpCookie = Request.Cookies("theme")
		Page.Theme = If(c Is Nothing, "Aqua", c.Value)

	End Sub
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim c As HttpCookie = Request.Cookies("theme")
		If (Not IsPostBack) AndAlso (c IsNot Nothing) Then
			rbList.Value = c.Value
		End If
	End Sub
End Class
