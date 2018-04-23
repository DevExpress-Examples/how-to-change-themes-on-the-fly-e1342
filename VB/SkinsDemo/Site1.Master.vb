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
Imports DevExpress.Web.ASPxEditors

Namespace SkinsDemo
	Partial Public Class Site1
		Inherits System.Web.UI.MasterPage
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			DataBind()
		End Sub
		' Skins 
		Protected Sub cbSkins_DataBound(ByVal sender As Object, ByVal e As EventArgs)
			If (Not IsPostBack) Then
				Dim item As ListEditItem = cbSkins.Items.FindByValue(Page.Theme)
				If item Is Nothing Then
					item = cbSkins.Items.FindByValue(BasePage.DefaultThemeName)
				End If
				If item IsNot Nothing Then
					cbSkins.SelectedItem = item
				End If
			End If
		End Sub
	End Class
End Namespace
