using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web.UI.HtmlControls;
using DevExpress.Web.ASPxEditors;

namespace Skins
{
    public partial class _Default : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CSSLink = "~/CSS/Default.css"; // Register css file
        }

    }
}
