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
using DevExpress.Web.ASPxEditors;

namespace SkinsDemo
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataBind();
        }
        /* Skins */
        protected void cbSkins_DataBound(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListEditItem item = cbSkins.Items.FindByValue(Page.Theme);
                if (item == null)
                    item = cbSkins.Items.FindByValue(BasePage.DefaultThemeName);
                if (item != null)
                    cbSkins.SelectedItem = item;
            }
        }
    }
}
