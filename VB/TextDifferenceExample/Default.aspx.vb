Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Namespace TextDifferenceExample
    Partial Public Class [Default]
        Inherits System.Web.UI.Page

        Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
            If Not IsPostBack Then
                Session.Clear()
                ASPxHtmlEditor1.Html = "<p>We are DevExpress and we are here for you. Our customers lie at the heart of our business and we are fully committed to providing the very best software development tools, unmatched customer service and expert technical support so you can build the next great app in the shortest possible time. We look forward to working with you and will do whatever we can to make your experience with us a profitable one.</p>"
                Session("InitialText") = ASPxHtmlEditor1.Html
            End If
        End Sub

        Protected Sub CheckTextExternalButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Session("InitialText") Is Nothing Then
                Return
            End If

            Dim initialFileText As String = Session("InitialText").ToString()
            Session("DifferenceResult") = GetDiffHtml(initialFileText, ASPxHtmlEditor1.Html)
            Response.Redirect(Me.ResolveUrl("CheckedTextResult.aspx"))
        End Sub

        Protected Sub CheckTextInHtmlEditorButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Session("InitialText") Is Nothing Then
                Return
            End If

            Dim initialFileText As String = Session("InitialText").ToString()
            ASPxHtmlEditor1.Html = GetDiffHtml(initialFileText, ASPxHtmlEditor1.Html)

            ASPxHtmlEditor1.Settings.AllowHtmlView = False
            ASPxHtmlEditor1.Settings.AllowDesignView = False
            CheckTextInHtmlEditorButton.Enabled = False
            CheckTextExternalButton.Enabled = False
            ReloadButton.Enabled = True
        End Sub

        Protected Sub ReloadButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Response.Redirect(Request.RawUrl)
        End Sub

        Private Function GetDiffHtml(ByVal text1 As String, ByVal text2 As String) As String
            Dim diffHelper As New HtmlDiff.HtmlDiff(text1, text2)
            Return diffHelper.Build()
        End Function
    End Class
End Namespace