using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class _Default : System.Web.UI.Page
{
	protected void Page_PreInit(object sender, EventArgs e) {
		HttpCookie c = Request.Cookies["theme"];		
		Page.Theme = c == null ? "Aqua": c.Value;
		
	}
	protected void Page_Load(object sender, EventArgs e) {
		HttpCookie c = Request.Cookies["theme"];
		if (!IsPostBack && (c != null))
			rbList.Value = c.Value;
	}
}
