Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Namespace TextDifferenceExample
    Partial Public Class CheckedTextResult
        Inherits System.Web.UI.Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
            BackLink.NavigateUrl = Me.ResolveUrl("Default.aspx")
            If Session("DifferenceResult") IsNot Nothing Then
                ResultsLiteral.Text = Session("DifferenceResult").ToString()
            End If
        End Sub
    End Class
End Namespace