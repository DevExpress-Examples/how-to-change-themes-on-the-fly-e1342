<%@ Page Language="vb" AutoEventWireup="true" Codebehind="Default.aspx.vb" Inherits="Skins._Default" MasterPageFile="~/Site1.Master"%>

<%@ Register Assembly="DevExpress.Web.v8.3, Version=8.3.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web.ASPxRoundPanel" TagPrefix="dxrp" %>
<%@ Register Assembly="DevExpress.Web.v8.3, Version=8.3.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dxp" %>
<%@ Register Assembly="DevExpress.Web.ASPxGridView.v8.3, Version=8.3.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dxwgv" %>
<%@ Register Assembly="DevExpress.Web.ASPxGridView.v8.3, Version=8.3.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dxwgv" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v8.3, Version=8.3.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>
<%@ Register Assembly="DevExpress.Web.v8.3, Version=8.3.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxw" %>
	<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
		<div>
			<dxrp:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Height="481px" Width="542px">
				<PanelCollection>
					<dxp:PanelContent runat="server">
						<table width="100%">
							<tr>
								<td>
									<dxwgv:ASPxGridView ID="ASPxGridView1" runat="server" AutoGenerateColumns="False"
										DataSourceID="xdsThemes">
										<Columns>
											<dxwgv:GridViewDataTextColumn FieldName="Text" VisibleIndex="0">
											</dxwgv:GridViewDataTextColumn>
											<dxwgv:GridViewDataTextColumn FieldName="Value" VisibleIndex="1">
											</dxwgv:GridViewDataTextColumn>
										</Columns>
									</dxwgv:ASPxGridView>
								</td>
								<td>
									<dxe:ASPxTextBox ID="ASPxTextBox1" runat="server" Width="170px">
									</dxe:ASPxTextBox>
									<br />
									<dxe:ASPxButton ID="ASPxButton1" runat="server" Text="ASPxButton">
									</dxe:ASPxButton>
								</td>
							</tr>
						</table>
					</dxp:PanelContent>
				</PanelCollection>
			</dxrp:ASPxRoundPanel>
		</div>
</asp:Content>