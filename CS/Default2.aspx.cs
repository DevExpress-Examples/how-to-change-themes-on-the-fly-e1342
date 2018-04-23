using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page {
	protected void Page_PreInit(object sender, EventArgs e) {
		HttpCookie c = Request.Cookies["theme"];
		Page.Theme = c == null ? "Aqua" : c.Value;

	}
	protected void Page_Load(object sender, EventArgs e) {
		HttpCookie c = Request.Cookies["theme"];
		if(!IsPostBack && (c != null))
			rbList.Value = c.Value;
	}
}