<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckedTextResult.aspx.cs" Inherits="TextDifferenceExample.CheckedTextResult" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="Content/diff_styles.css" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:HyperLink runat="server" ID="BackLink"><- Back</asp:HyperLink>
        <br />
        <asp:Literal runat="server" ID="ResultsLiteral"></asp:Literal>
    </form>
</body>
</html>
