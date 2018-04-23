using System;
using System.Web.UI.HtmlControls;

public partial class BasePage : System.Web.UI.Page
{
    public const string DefaultThemeName = "Glass";

    private string cssLink = "";

    protected string CSSLink
    {
        set { cssLink = value; }
    }

    protected string GetThemeCookieName()
    {
        string demoCurrentTheme = "DemoCurrentTheme";
        return demoCurrentTheme;
    }

    /* Page PreInit */
    protected void Page_PreInit(object sender, EventArgs e)
    {
        string themeName = DefaultThemeName;
        if (Page.Request.Cookies[GetThemeCookieName()] != null)
        {
            themeName = Page.Request.Cookies[GetThemeCookieName()].Value;
        }

        string clientScriptBlock = "var DXCurrentThemeCookieName = \"" + GetThemeCookieName() + "\";";
        Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "DXCurrentThemeCookieName", clientScriptBlock, true);
        this.Theme = themeName;
    }
    /* Page Load */
    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        // Scripts
        RegisterScript("Utilities", "~/Scripts/Utilities.js");
        // CSS
        RegisterCSSLink("~/CSS/styles.css");
        if (!string.IsNullOrEmpty(this.cssLink))
            RegisterCSSLink(this.cssLink);
    }
    private void RegisterScript(string key, string url)
    {
        Page.ClientScript.RegisterClientScriptInclude(key, Page.ResolveUrl(url));
    }
    private void RegisterCSSLink(string url)
    {
        HtmlLink link = new HtmlLink();
        Page.Header.Controls.Add(link);
        link.EnableViewState = false;
        link.Attributes.Add("type", "text/css");
        link.Attributes.Add("rel", "stylesheet");
        link.Href = url;
    }
}

