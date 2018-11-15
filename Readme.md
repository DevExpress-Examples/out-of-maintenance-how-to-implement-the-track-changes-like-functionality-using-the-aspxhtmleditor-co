<!-- default file list -->
*Files to look at*:

* [CheckedTextResult.aspx](./CS/TextDifferenceExample/CheckedTextResult.aspx) (VB: [CheckedTextResult.aspx.vb](./VB/TextDifferenceExample/CheckedTextResult.aspx.vb))
* [CheckedTextResult.aspx.cs](./CS/TextDifferenceExample/CheckedTextResult.aspx.cs) (VB: [CheckedTextResult.aspx.vb](./VB/TextDifferenceExample/CheckedTextResult.aspx.vb))
* [diff_styles.css](./CS/TextDifferenceExample/Content/diff_styles.css)
* **[Default.aspx](./CS/TextDifferenceExample/Default.aspx) (VB: [Default.aspx.vb](./VB/TextDifferenceExample/Default.aspx.vb))**
* [Default.aspx.cs](./CS/TextDifferenceExample/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/TextDifferenceExample/Default.aspx.vb))
<!-- default file list end -->
# How to implement the track changes-like functionality using the ASPxHtmlEditor control


<p>In this example, we demonstrate how to use the ASPxHtmlEditor control to implement the <a href="https://support.office.com/en-us/article/Track-changes-in-Word-197ba630-0f5f-4a8e-9a77-3712475e806a?ui=en-US&rs=en-US&ad=US">Track Changes-like</a> functionality from Microsoft Word. Changes to the text are detected using the third-party <a href="https://github.com/Rohland/htmldiff.net">htmldiff.net</a> library and are then displayed either in the ASPxHtmlEditor control or on an external page.<br><br>The changes are highlighted using the <ins> (inserted/new text) and <del> (removed text) tags. You can provide custom styles for these tags in the ~/Content/diff_styles.css file.</p>

<br/>


