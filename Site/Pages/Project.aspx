<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Project.aspx.cs" Inherits="QAManagement.Site.Pages.Project" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
        }
        .style3
        {
            width: 20px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table cellpadding="0" cellspacing="0" class="style1">
        <tr>
            <td class="style2" colspan="6">
                <asp:Panel ID="pnlPageHeader" runat="server" SkinID="PageHeader">
                    <asp:Label ID="lblPageHeader" runat="server" Text="Project Details" 
                        SkinID="PageHeader"></asp:Label>
                </asp:Panel>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td>
                <asp:LinkButton ID="lnkUser" runat="server" onclick="lnkUser_Click" 
                    SkinID="LinkHeader">Project Users</asp:LinkButton>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td colspan="4">
                <asp:GridView ID="grdList" runat="server" AutoGenerateColumns="False" 
                    DataKeyNames="ID" DataSourceID="srcRequirements" 
                    EmptyDataText="No information found" 
                    CaptionAlign="Left" AllowPaging="True">
                    <Columns>
                        <asp:TemplateField ShowHeader="False">
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" 
                                    CommandName="Select" Text='<%# Eval("ID") %>'></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" 
                            ReadOnly="True" SortExpression="ID" />
                        <asp:BoundField DataField="Description" HeaderText="Description" 
                            SortExpression="Description" />
                        <asp:BoundField DataField="LongDescription" HeaderText="LongDescription" 
                            SortExpression="LongDescription" />
                        <asp:BoundField DataField="Number" HeaderText="Number" 
                            SortExpression="Number" />
                    </Columns>
                </asp:GridView>
                <asp:ObjectDataSource ID="srcRequirements" runat="server" 
                    OldValuesParameterFormatString="original_{0}" SelectMethod="GetDataByProjectID" 
                    TypeName="QAManagement.Data.QADatasetTableAdapters.RequirementTableAdapter">
                    <SelectParameters>
                        <asp:QueryStringParameter Name="ProjectID" QueryStringField="ID" Type="Int64" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </td>
            <td align="left" valign="top">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    DataKeyNames="ID" DataSourceID="srcTestResults" 
                    EmptyDataText="No information found">
                    <Columns>
                        <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" 
                            ReadOnly="True" SortExpression="ID" />
                        <asp:BoundField DataField="Results" HeaderText="Results" 
                            SortExpression="Results" />
                        <asp:BoundField DataField="RequirementID" HeaderText="RequirementID" 
                            SortExpression="RequirementID" />
                        <asp:CheckBoxField DataField="Pass" HeaderText="Pass" SortExpression="Pass" />
                    </Columns>
                </asp:GridView>
                <asp:ObjectDataSource ID="srcTestResults" runat="server" 
                    OldValuesParameterFormatString="original_{0}" 
                    SelectMethod="GetDataByRequirementID" 
                    TypeName="QAManagement.Data.QADatasetTableAdapters.TestResultTableAdapter">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="grdList" Name="RequirementID" 
                            PropertyName="SelectedValue" Type="Int64" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td colspan="4">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td colspan="4">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td colspan="4">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
