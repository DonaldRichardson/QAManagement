<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Projects.aspx.cs" Inherits="Site.Pages.Project" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 20px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table cellpadding="0" cellspacing="0" class="style1">
        <tr>
            <td>
                <table cellpadding="0" cellspacing="0" class="style1">
                    <tr>
                        <td colspan="3">
                            <asp:Panel ID="pnlPageHeader" runat="server" SkinID="PageHeader">
                                <asp:Label ID="Label2" runat="server" SkinID="PageHeader" 
    Text="Project List"></asp:Label>
                            </asp:Panel>
                        </td>
                    </tr>
                    <tr>
                        <td class="style2">
                            &nbsp;</td>
                        <td>
                            <asp:LinkButton ID="lnkUsers" runat="server" CausesValidation="False" 
                                onclick="lnkUsers_Click">Users</asp:LinkButton>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style2">
                            &nbsp;</td>
                        <td>
                                    <asp:GridView ID="grdList" runat="server" AllowPaging="True" 
                                        AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="srcProjects" 
                                        Width="100%" onselectedindexchanged="GridSelectedIndexChanged">
                                        <Columns>
                                            <asp:TemplateField ShowHeader="False">
                                                <ItemTemplate>
                                                    <asp:LinkButton ID="LinkButton3" runat="server" CausesValidation="False" 
                                                        CommandName="Select" Text='<%# Eval("Name") %>'></asp:LinkButton>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="ID" InsertVisible="False" SortExpression="ID">
                                                <EditItemTemplate>
                                                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("ID") %>'></asp:Label>
                                                </EditItemTemplate>
                                                <ItemTemplate>
                                                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" 
                                                        CommandName="Select" Text='<%# Eval("ID") %>'></asp:LinkButton>
                                                </ItemTemplate>
                                                <HeaderStyle HorizontalAlign="Left" />
                                            </asp:TemplateField>
                                            <asp:BoundField DataField="Description" HeaderText="Description" 
                                                SortExpression="Description" >
                                            <HeaderStyle HorizontalAlign="Left" />
                                            </asp:BoundField>
                                        </Columns>
                                    </asp:GridView>
                                </td>
                        <td align="left" valign="top">
                                    <asp:FormView ID="fvEdit" runat="server" DataKeyNames="ID" 
                                        DataSourceID="srcProject">
                                        <EditItemTemplate>
                                            ID:
                                            <asp:Label ID="IDLabel1" runat="server" Text='<%# Eval("ID") %>' />
                                            <br />
                                            Name:
                                            <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
                                            <br />
                                            Description:
                                            <asp:TextBox ID="DescriptionTextBox" runat="server" 
                                                Text='<%# Bind("Description") %>' />
                                            <br />
                                            CompanyID:
                                            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="srcCompanies" 
                                                DataTextField="Name" DataValueField="ID" 
                                                SelectedValue='<%# Bind("CompanyID") %>'>
                                            </asp:DropDownList>
                                            <br />
                                            <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" 
                                                CommandName="Update" Text="Update" />
                                            &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" 
                                                CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                                        </EditItemTemplate>
                                        <EmptyDataTemplate>
                                            <asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" 
                                                CommandName="New" Text="New" />
                                        </EmptyDataTemplate>
                                        <InsertItemTemplate>
                                            Name:
                                            <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
                                            <br />
                                            Description:
                                            <asp:TextBox ID="DescriptionTextBox" runat="server" 
                                                Text='<%# Bind("Description") %>' />
                                            <br />
                                            CompanyID:
                                            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="srcCompanies" 
                                                DataTextField="Name" DataValueField="ID" 
                                                SelectedValue='<%# Bind("CompanyID") %>'>
                                            </asp:DropDownList>
                                            <br />
                                            <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" 
                                                CommandName="Insert" Text="Insert" />
                                            &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" 
                                                CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                                        </InsertItemTemplate>
                                        <ItemTemplate>
                                            ID:
                                            <asp:Label ID="IDLabel" runat="server" Text='<%# Eval("ID") %>' />
                                            <br />
                                            Name:
                                            <asp:Label ID="NameLabel" runat="server" Text='<%# Bind("Name") %>' />
                                            <br />
                                            Description:
                                            <asp:Label ID="DescriptionLabel" runat="server" 
                                                Text='<%# Bind("Description") %>' />
                                            <br />
                                            CompanyName:
                                            <asp:Label ID="CompanyNameLabel" runat="server" 
                                                Text='<%# Bind("CompanyName") %>' />
                                            <br />
                                            <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" 
                                                CommandName="Edit" Text="Edit" />
                                            &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" 
                                                CommandName="Delete" Text="Delete" />
                                            &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" 
                                                CommandName="New" Text="New" />
                                        </ItemTemplate>
                                    </asp:FormView>
                                </td>
                    </tr>
                    <tr>
                        <td class="style2">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style2">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <asp:ObjectDataSource ID="srcProject" runat="server" DeleteMethod="Delete" 
                    InsertMethod="Insert" SelectMethod="GetDataByID" 
                    TypeName="QAManagement.Data.QADatasetTableAdapters.ProjectTableAdapter" 
                    UpdateMethod="Update">
                    <DeleteParameters>
                        <asp:Parameter Name="Original_ID" Type="Int64" />
                        <asp:Parameter Name="Original_Name" Type="String" />
                        <asp:Parameter Name="Original_Description" Type="String" />
                        <asp:Parameter Name="Original_CompanyID" Type="Int64" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="Name" Type="String" />
                        <asp:Parameter Name="Description" Type="String" />
                        <asp:Parameter Name="CompanyID" Type="Int64" />
                    </InsertParameters>
                    <SelectParameters>
                        <asp:ControlParameter ControlID="grdList" Name="ID" 
                            PropertyName="SelectedValue" Type="Int64" />
                    </SelectParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="Name" Type="String" />
                        <asp:Parameter Name="Description" Type="String" />
                        <asp:Parameter Name="CompanyID" Type="Int64" />
                        <asp:Parameter Name="ID" Type="Int64" />
                    </UpdateParameters>
                </asp:ObjectDataSource>
                <asp:ObjectDataSource ID="srcProjects" runat="server" 
                    OldValuesParameterFormatString="original_{0}" SelectMethod="GetDataByCompanyID" 
                    TypeName="QAManagement.Data.QADatasetTableAdapters.ProjectTableAdapter" 
                    DeleteMethod="Delete" InsertMethod="Insert" UpdateMethod="Update">
                    <DeleteParameters>
                        <asp:Parameter Name="Original_ID" Type="Int64" />
                        <asp:Parameter Name="Original_Name" Type="String" />
                        <asp:Parameter Name="Original_Description" Type="String" />
                        <asp:Parameter Name="Original_CompanyID" Type="Int64" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="Name" Type="String" />
                        <asp:Parameter Name="Description" Type="String" />
                        <asp:Parameter Name="CompanyID" Type="Int64" />
                    </InsertParameters>
                    <SelectParameters>
                        <asp:QueryStringParameter DefaultValue="0" Name="CompanyID" 
                            QueryStringField="ID" Type="Int64" />
                    </SelectParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="Name" Type="String" />
                        <asp:Parameter Name="Description" Type="String" />
                        <asp:Parameter Name="CompanyID" Type="Int64" />
                        <asp:Parameter Name="ID" Type="Int64" />
                    </UpdateParameters>
                </asp:ObjectDataSource>
                <asp:ObjectDataSource ID="srcCompanies" runat="server" OldValuesParameterFormatString="original_{0}" 
                    SelectMethod="GetData" 
                    TypeName="QAManagement.Data.QADatasetTableAdapters.CompanyTableAdapter">
                </asp:ObjectDataSource>
            </td>
        </tr>
    </table>
</asp:Content>
