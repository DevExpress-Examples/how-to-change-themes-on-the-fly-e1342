<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Default3.aspx.vb" Inherits="Default3" %>

<%@ Register Assembly="DevExpress.Web.v13.2, Version=13.2.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.v13.2, Version=13.2.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>How to change a page's theme dynamically</title>
</head>
<body>
    <form id="form1" runat="server">
    <table>
        <tr>
            <td>
                <dx:ASPxGridView ID="ASPxGridView1" runat="server" AutoGenerateColumns="False" DataSourceID="dataSource"
                    KeyFieldName="CategoryID">
                    <Columns>
                        <dx:GridViewDataTextColumn FieldName="CategoryID" ReadOnly="True" VisibleIndex="0">
                            <EditFormSettings Visible="False" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="CategoryName" VisibleIndex="1">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="Description" VisibleIndex="2">
                        </dx:GridViewDataTextColumn>
                    </Columns>
                </dx:ASPxGridView>
                &nbsp;<br />
                <dx:ASPxTextBox ID="ASPxTextBox1" runat="server" Width="170px">
                </dx:ASPxTextBox>
                <dx:ASPxButton ID="button" runat="server" Text="Button">
                </dx:ASPxButton>
            </td>
            <td valign="top">
                <dx:ASPxRadioButtonList ID="rbList" runat="server" AutoPostBack="True" SelectedIndex="0">
                    <ClientSideEvents SelectedIndexChanged="function(s, e) { ASPxClientUtils.SetCookie('theme', s.GetValue());}" />
                    <Items>
                        <dx:ListEditItem Selected="True" Text="Aqua" Value="Aqua" />
                        <dx:ListEditItem Text="DevEx" Value="DevEx" />
                        <dx:ListEditItem Text="SoftOrange" Value="SoftOrange" />
                        <dx:ListEditItem Text="Youthful" Value="Youthful" />
                    </Items>
                </dx:ASPxRadioButtonList>
                <asp:SqlDataSource ID="dataSource" runat="server" ConnectionString="Data Source=(local);Initial Catalog=Northwind;Integrated Security=True"
                    ProviderName="System.Data.SqlClient" SelectCommand="SELECT [CategoryID], [CategoryName], [Description] FROM [Categories]">
                </asp:SqlDataSource>
            </td>
        </tr>
    </table>
    </form>
</body>
</html>