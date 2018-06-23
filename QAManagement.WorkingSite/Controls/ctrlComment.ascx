<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrlComment.ascx.cs"
    Inherits="QAManagement.WorkingSite.Controls.ctrlComment" %>
<style type="text/css">
    .style1
    {
        width: 100%;
        float: left;
    }
    .style2
    {
        width: 106px;
    }
</style>
<asp:Panel ID="Panel1" runat="server" Height="100%" Width="100%">
    <asp:Panel ID="pnlDetail" runat="server" Height="100%" Width="100%">
        <asp:FormView ID="FormView" runat="server" DataSourceID="srcComments" CellPadding="5"
            CellSpacing="5" DataKeyNames="ID" EmptyDataText="No Comment Found" Height="100%"
            HorizontalAlign="Left" Width="100%">
            <EditItemTemplate>
                <table cellpadding="0" cellspacing="0" class="style1">
                    <tr>
                        <td class="style2">
                            <asp:Label ID="Label1" runat="server" Text="ID:"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label6" runat="server" Text='<%# Bind("ID") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style2">
                            <asp:Label ID="Label3" runat="server" Text="Requirement ID:"></asp:Label>
                        </td>
                        <td>
                            <asp:LinkButton ID="LinkButton1" Text='<%# Bind("RequirementID") %>' runat="server">lnkRequirementID</asp:LinkButton>
                        </td>
                    </tr>
                    <tr>
                        <td class="style2">
                            <asp:Label ID="Label2" runat="server" Text="Description:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="DescriptionTextBox" runat="server" Text='<%# Bind("Description") %>'
                                Rows="5" TextMode="MultiLine" Width="100%" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style2">
                            &nbsp;
                        </td>
                        <td>
                            &nbsp;
                        </td>
                    </tr>
                </table>
                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update"
                    Text="Update" />
                &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False"
                    CommandName="Cancel" Text="Cancel" />
            </EditItemTemplate>
            <FooterTemplate>
                <asp:LinkButton ID="lnkEdit" runat="server" onclick="lnkEdit_Click">Edit</asp:LinkButton>
            </FooterTemplate>
            <HeaderTemplate>
                <asp:Label ID="lblPanelHeader" runat="server" BorderColor="Transparent" 
                    BorderStyle="Solid" BorderWidth="3px" SkinID="lblPanelHeader"></asp:Label>
            </HeaderTemplate>
            <InsertItemTemplate>
                <table cellpadding="0" cellspacing="0" class="style1">
                    <tr>
                        <td class="style2">
                            <asp:Label ID="Label1" runat="server" Text="ID:"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label6" runat="server" Text='<%# Bind("ID") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style2">
                            <asp:Label ID="Label3" runat="server" Text="Requirement ID:"></asp:Label>
                        </td>
                        <td>
                            <asp:LinkButton ID="LinkButton1" Text='<%# Bind("RequirementID") %>' runat="server">lnkRequirementID</asp:LinkButton>
                        </td>
                    </tr>
                    <tr>
                        <td class="style2">
                            <asp:Label ID="Label2" runat="server" Text="Description:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="DescriptionTextBox" runat="server" Text='<%# Bind("Description") %>'
                                Rows="5" TextMode="MultiLine" Width="100%" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style2">
                            &nbsp;
                        </td>
                        <td>
                            &nbsp;
                        </td>
                    </tr>
                </table>
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert"
                    Text="Insert" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False"
                    CommandName="Cancel" Text="Cancel" />
            </InsertItemTemplate>
            <ItemTemplate>
                    <table cellpadding="0" cellspacing="0" class="style1">
                        <tr>
                            <td class="style2">
                                <asp:Label ID="Label1" runat="server" Text="ID:"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label6" runat="server" Text='<%# Bind("ID") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="style2">
                                <asp:Label ID="Label3" runat="server" Text="Requirement ID:"></asp:Label>
                            </td>
                            <td>
                                <asp:LinkButton ID="LinkButton1" Text='<%# Bind("RequirementID") %>' runat="server">lnkRequirementID</asp:LinkButton>
                            </td>
                        </tr>
                        <tr>
                            <td class="style2" valign="top">
                                <asp:Label ID="Label2" runat="server" Text="Description:"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="DescriptionTextBox" runat="server" 
                                    Text='<%# Bind("Description") %>' Rows="5" TextMode="MultiLine" 
                                    Width="100%" Enabled="False" />
                            </td>
                        </tr>
                        <tr>
                            <td class="style2">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                    </table>
            </ItemTemplate>
        </asp:FormView>
    </asp:Panel>
</asp:Panel>
<asp:ObjectDataSource ID="srcComments" runat="server" DataObjectTypeName="QAManagement.Views.baseCommentView"
    OldValuesParameterFormatString="original_{0}" SelectMethod="GetComment" TypeName="QAManagement.Views.CommentProvider"
    UpdateMethod="UpdateComment">
    <SelectParameters>
        <asp:QueryStringParameter Name="id" QueryStringField="ID" Type="Int32" />
    </SelectParameters>
</asp:ObjectDataSource>
