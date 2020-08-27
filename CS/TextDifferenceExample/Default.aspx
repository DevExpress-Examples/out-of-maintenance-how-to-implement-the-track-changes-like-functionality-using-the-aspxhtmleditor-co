<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TextDifferenceExample.Default" %>

<%@ Register Assembly="DevExpress.Web.ASPxHtmlEditor.v15.2, Version=15.2.20.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxHtmlEditor" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>ASPxHtmlEditor - How to display text difference
        </h2>
        <blockquote cite="https://github.com/Rohland/htmldiff.net">
            In this example we demonstrate how to use a text difference library to 
            display the changes that were made to the text in the ASPxHtmlEditor contrl. 
            <br />
            Edit the text and press the "Check Text (Results on an external page)" or the
            "Check Text (Results in the ASPxHtmlEditor control)" buttons to view text differences.
        </blockquote>
        <dx:ASPxHtmlEditor ID="ASPxHtmlEditor1" runat="server">
            <CssFiles>
                <dx:HtmlEditorCssFile FilePath="~/Content/diff_styles.css"></dx:HtmlEditorCssFile>
            </CssFiles>
        </dx:ASPxHtmlEditor>
        <br />
        <dx:ASPxButton runat="server" ID="CheckTextInHtmlEditorButton" Text="Check Text (Results in the ASPxHtmlEditor control)" OnClick="CheckTextInHtmlEditorButton_Click"></dx:ASPxButton>
        <dx:ASPxButton runat="server" ID="CheckTextExternalButton" Text="Check Text (Results on an external page)" OnClick="CheckTextExternalButton_Click"></dx:ASPxButton>
        <dx:ASPxButton runat="server" ID="ReloadButton" Text="Reload" Enabled="false" OnClick="ReloadButton_Click"></dx:ASPxButton>
    </form>
</body>
</html>
