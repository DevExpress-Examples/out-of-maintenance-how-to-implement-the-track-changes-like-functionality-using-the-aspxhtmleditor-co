using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TextDifferenceExample {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Init(object sender, EventArgs e) {
            if (!IsPostBack) {
                Session.Clear();
                ASPxHtmlEditor1.Html = @"<p>We are DevExpress and we are here for you. Our customers lie at the heart of our business and we are fully committed to providing the very best software development tools, unmatched customer service and expert technical support so you can build the next great app in the shortest possible time. We look forward to working with you and will do whatever we can to make your experience with us a profitable one.</p>";
                Session["InitialText"] = ASPxHtmlEditor1.Html;
            }
        }

        protected void CheckTextExternalButton_Click(object sender, EventArgs e) {
            if(Session["InitialText"] == null)
                return;

            string initialFileText = Session["InitialText"].ToString();
            Session["DifferenceResult"] = GetDiffHtml(initialFileText, ASPxHtmlEditor1.Html);
            Response.Redirect(this.ResolveUrl("CheckedTextResult.aspx"));
        }

        protected void CheckTextInHtmlEditorButton_Click(object sender, EventArgs e) {
            if (Session["InitialText"] == null)
                return;

            string initialFileText = Session["InitialText"].ToString();
            ASPxHtmlEditor1.Html = GetDiffHtml(initialFileText, ASPxHtmlEditor1.Html);

            ASPxHtmlEditor1.Settings.AllowHtmlView = false;
            ASPxHtmlEditor1.Settings.AllowDesignView = false;
            CheckTextInHtmlEditorButton.Enabled = false;
            CheckTextExternalButton.Enabled = false;
            ReloadButton.Enabled = true;
        }

        protected void ReloadButton_Click(object sender, EventArgs e) {
            Response.Redirect(Request.RawUrl);
        }

        private string GetDiffHtml(string text1, string text2) {
            HtmlDiff.HtmlDiff diffHelper = new HtmlDiff.HtmlDiff(text1, text2);
            return diffHelper.Build();
        }
    }
}