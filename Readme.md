<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/SkinsDemo/Default.aspx) (VB: [Default.aspx](./VB/SkinsDemo/Default.aspx))
* [Default.aspx.cs](./CS/SkinsDemo/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/SkinsDemo/Default.aspx.vb))
* [Utilities.js](./CS/SkinsDemo/Scripts/Utilities.js) (VB: [Utilities.js](./VB/SkinsDemo/Scripts/Utilities.js))
* [Site1.Master](./CS/SkinsDemo/Site1.Master) (VB: [Site1.Master](./VB/SkinsDemo/Site1.Master))
* [Site1.Master.cs](./CS/SkinsDemo/Site1.Master.cs) (VB: [Site1.Master.vb](./VB/SkinsDemo/Site1.Master.vb))
* [Utils.cs](./CS/SkinsDemo/Utils.cs) (VB: [Utils.vb](./VB/SkinsDemo/Utils.vb))
<!-- default file list end -->
# How to change themes on the fly
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e1342)**
<!-- run online end -->


<p>This example illustrates how to change themes on the fly. For this, use one of the following approaches: <br><br>1) <a href="https://documentation.devexpress.com/#AspNet/CustomDocument11725">ASP.NET mechanism</a>. Use the <strong>Page.Theme</strong> property to apply a theme to a page.<br>2) <a href="https://documentation.devexpress.com/#AspNet/CustomDocument11724">DevExpress mechanism</a>. Use the <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebASPxWebControl_GlobalThemetopic">ASPxWebControl.GlobalTheme</a> property to set a theme to a page.<br><br>In both cases, a theme should be specified in the <strong>Page_PreInit </strong>event handler.<br><br><strong><em>Note:</em></strong><br>To switch between different mechanisms, use the <em>ASP.NET way</em> and <em>DevExpress way</em> links on the Default.aspx page of the example.</p>

<br/>


