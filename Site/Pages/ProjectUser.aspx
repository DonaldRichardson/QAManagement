<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProjectUser.aspx.cs" Inherits="Site.Pages.ProjectUser" %>
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
            width: 19px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table cellpadding="0" cellspacing="0" class="style1">
        <tr>
            <td>
                <table cellpadding="0" cellspacing="0" class="style1">
                    <tr>
                        <td class="style2" colspan="3">
                            <asp:Panel ID="pnlPageHeader" runat="server" SkinID="PageHeader">
                                <asp:Label ID="lblPageHeader" runat="server" Text="Project Users" 
                                    SkinID="PageHeader"></asp:Label>
                            </asp:Panel>
                        </td>
                    </tr>
                    <tr>
                        <td class="style3">
                            &nbsp;</td>
                        <td>
                            <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" 
                                DataKeyNames="ID" DataSourceID="srcProject" EnableModelValidation="False" 
                                GridLines="None" Height="16px" Width="125px">
                                <Fields>
                                    <asp:TemplateField SortExpression="Name">
                                        <EditItemTemplate>
                                            <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Name") %>'></asp:TextBox>
                                        </EditItemTemplate>
                                        <InsertItemTemplate>
                                            <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Name") %>'></asp:TextBox>
                                        </InsertItemTemplate>
                                        <ItemTemplate>
                                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("Name") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Fields>
                            </asp:DetailsView>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style3">
                            &nbsp;</td>
                        <td>
                <asp:GridView ID="grdList" runat="server" AutoGenerateColumns="False" 
                                DataSourceID="srcProjectUsers" AllowPaging="True" 
                                EmptyDataText="No information found" ShowHeader="False" 
                                style="margin-left: 0px" DataKeyNames="ProjectID">
                    <Columns>
                        <asp:TemplateField ShowHeader="False">
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" 
                                    CommandName="Select" Text='<%# Eval("Username") %>'></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="UserID" HeaderText="UserID" InsertVisible="False" 
                            ReadOnly="True" SortExpression="UserID" Visible="False" />
                    </Columns>
                </asp:GridView>
                        </td>
                        <td>
                            <asp:FormView ID="FormView1" runat="server" DataKeyNames="ID" 
                                DataSourceID="srcProjectUser">
                                <EditItemTemplate>
                                    ID:
                                    <asp:Label ID="IDLabel1" runat="server" Text='<%# Eval("ID") %>' />
                                    <br />
                                    UserID:
                                    <asp:TextBox ID="UserIDTextBox" runat="server" Text='<%# Bind("UserID") %>' />
                                    <br />
                                    ProjectID:
                                    <asp:TextBox ID="ProjectIDTextBox" runat="server" 
                                        Text='<%# Bind("ProjectID") %>' />
                                    <br />
                                    <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" 
                                        CommandName="Update" Text="Update" />
                                    &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" 
                                        CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                                </EditItemTemplate>
                                <InsertItemTemplate>
                                    UserID:
                                    <asp:TextBox ID="UserIDTextBox" runat="server" Text='<%# Bind("UserID") %>' />
                                    <br />
                                    ProjectID:
                                    <asp:TextBox ID="ProjectIDTextBox" runat="server" 
                                        Text='<%# Bind("ProjectID") %>' />
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
                                    UserID:
                                    <asp:Label ID="UserIDLabel" runat="server" Text='<%# Bind("UserID") %>' />
                                    <br />
                                    ProjectID:
                                    <asp:Label ID="ProjectIDLabel" runat="server" Text='<%# Bind("ProjectID") %>' />
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
                        <td class="style3">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style3">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style3">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                </table>
                <asp:ObjectDataSource ID="srcProjectUsers" runat="server" OldValuesParameterFormatString="original_{0}" 
                    SelectMethod="GetDataByProjectID" 
                    
                    TypeName="QAManagement.Data.QADatasetTableAdapters.ProjectUserQueryTableAdapter">
                    <SelectParameters>
                        <asp:QueryStringParameter Name="ProjectID" QueryStringField="ID" Type="Int64" />
                    </SelectParameters>
                </asp:ObjectDataSource>
                <asp:ObjectDataSource ID="srcProject" runat="server" 
                    OldValuesParameterFormatString="original_{0}" SelectMethod="GetDataByID" 
                    TypeName="QAManagement.Data.QADatasetTableAdapters.ProjectTableAdapter">
                    <SelectParameters>
                        <asp:QueryStringParameter Name="ID" QueryStringField="ID" Type="Int64" />
                    </SelectParameters>
                </asp:ObjectDataSource>
                <asp:ObjectDataSource ID="srcProjectUser" runat="server" DeleteMethod="Delete" 
                    InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" 
                    SelectMethod="GetDataByProjectID" 
                    TypeName="QAManagement.Data.QADatasetTableAdapters.ProjectUsersTableAdapter" 
                    UpdateMethod="Update">
                    <DeleteParameters>
                        <asp:Parameter Name="Original_ID" Type="Int64" />
                        <asp:Parameter Name="Original_UserID" Type="Int64" />
                        <asp:Parameter Name="Original_ProjectID" Type="Int64" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="UserID" Type="Int64" />
                        <asp:Parameter Name="ProjectID" Type="Int64" />
                    </InsertParameters>
                    <SelectParameters>
                        <asp:ControlParameter ControlID="grdList" Name="ProjectID" 
                            PropertyName="SelectedValue" Type="Int64" />
                    </SelectParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="UserID" Type="Int64" />
                        <asp:Parameter Name="ProjectID" Type="Int64" />
                        <asp:Parameter Name="Original_ID" Type="Int64" />
                        <asp:Parameter Name="Original_UserID" Type="Int64" />
                        <asp:Parameter Name="Original_ProjectID" Type="Int64" />
                    </UpdateParameters>
                </asp:ObjectDataSource>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
