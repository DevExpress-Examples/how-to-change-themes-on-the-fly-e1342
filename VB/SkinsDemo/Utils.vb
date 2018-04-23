Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI.HtmlControls

Partial Public Class BasePage
	Inherits System.Web.UI.Page
	Public Const DefaultThemeName As String = "Glass"

	Private cssLink_Renamed As String = ""

	Protected WriteOnly Property CSSLink() As String
		Set(ByVal value As String)
			cssLink_Renamed = value
		End Set
	End Property

	Protected Function GetThemeCookieName() As String
		Dim demoCurrentTheme As String = "DemoCurrentTheme"
		Return demoCurrentTheme
	End Function

	' Page PreInit 
              Protected Overrides Sub OnPreInit(ByVal e As EventArgs)
                            MyBase.OnPreInit(e)
		Dim themeName As String = DefaultThemeName
		If Page.Request.Cookies(GetThemeCookieName()) IsNot Nothing Then
			themeName = Page.Request.Cookies(GetThemeCookieName()).Value
		End If

		Dim clientScriptBlock As String = "var DXCurrentThemeCookieName = """ & GetThemeCookieName() & """;"
		Page.ClientScript.RegisterClientScriptBlock(Me.GetType(), "DXCurrentThemeCookieName", clientScriptBlock, True)
		Me.Theme = themeName
	End Sub
	' Page Load 
	Protected Overrides Sub OnLoad(ByVal e As EventArgs)
		MyBase.OnLoad(e)
		' Scripts
		RegisterScript("Utilities", "~/Scripts/Utilities.js")
		' CSS
		RegisterCSSLink("~/CSS/styles.css")
		If (Not String.IsNullOrEmpty(Me.cssLink_Renamed)) Then
			RegisterCSSLink(Me.cssLink_Renamed)
		End If
	End Sub
	Private Sub RegisterScript(ByVal key As String, ByVal url As String)
		Page.ClientScript.RegisterClientScriptInclude(key, Page.ResolveUrl(url))
	End Sub
	Private Sub RegisterCSSLink(ByVal url As String)
		Dim link As New HtmlLink()
		Page.Header.Controls.Add(link)
		link.EnableViewState = False
		link.Attributes.Add("type", "text/css")
		link.Attributes.Add("rel", "stylesheet")
		link.Href = url
	End Sub
End Class

