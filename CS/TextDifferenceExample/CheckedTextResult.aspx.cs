using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TextDifferenceExample {
    public partial class CheckedTextResult : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            BackLink.NavigateUrl = this.ResolveUrl("Default.aspx");
            if (Session["DifferenceResult"] != null) {
                ResultsLiteral.Text = Session["DifferenceResult"].ToString();
            }
        }
    }
}