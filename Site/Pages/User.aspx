<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="Site.Pages.User" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
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
                                <asp:Label ID="lblPageHeader" runat="server" Text="User Control" 
                                    SkinID="PageHeader"></asp:Label>
                            </asp:Panel>
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
                        <td align="left" valign="top">
                <asp:GridView ID="grdList" runat="server" AutoGenerateColumns="False" 
                    DataKeyNames="ID" DataSourceID="srcUsers" AllowPaging="True" 
                                EmptyDataText="No information found">
                    <Columns>
                        <asp:TemplateField ShowHeader="False">
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" 
                                    CommandName="Select" Text='<%# Eval("Username") %>'></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" 
                            ReadOnly="True" SortExpression="ID" Visible="False" />
                        <asp:BoundField DataField="Password" HeaderText="Password" 
                            SortExpression="Password" />
                    </Columns>
                </asp:GridView>
                        </td>
                        <td align="left" valign="top">
                <asp:FormView ID="fvEdit" runat="server" DataKeyNames="ID" 
                    DataSourceID="srcUser">
                    <EditItemTemplate>
                        ID:
                        <asp:Label ID="IDLabel1" runat="server" Text='<%# Eval("ID") %>' />
                        <br />
                        Username:
                        <asp:TextBox ID="UsernameTextBox" runat="server" 
                            Text='<%# Bind("Username") %>' />
                        <br />
                        Password:
                        <asp:TextBox ID="PasswordTextBox" runat="server" 
                            Text='<%# Bind("Password") %>' />
                        <br />
                        CompanyID:
                        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="srcCompanies" 
                            DataTextField="Name" DataValueField="ID" 
                            SelectedValue='<%# Bind("CompanyID") %>'>
                        </asp:DropDownList>
                        <br />
                        Email:
                        <asp:TextBox ID="EmailTextBox" runat="server" Text='<%# Bind("Email") %>' />
                        <br />
                        Address1:
                        <asp:TextBox ID="Address1TextBox" runat="server" 
                            Text='<%# Bind("Address1") %>' />
                        <br />
                        Address2:
                        <asp:TextBox ID="Address2TextBox" runat="server" 
                            Text='<%# Bind("Address2") %>' />
                        <br />
                        Address3:
                        <asp:TextBox ID="Address3TextBox" runat="server" 
                            Text='<%# Bind("Address3") %>' />
                        <br />
                        PostalCode:
                        <asp:TextBox ID="PostalCodeTextBox" runat="server" 
                            Text='<%# Bind("PostalCode") %>' />
                        <br />
                        PhoneNumber:
                        <asp:TextBox ID="PhoneNumberTextBox" runat="server" 
                            Text='<%# Bind("PhoneNumber") %>' />
                        <br />
                        CellNumber:
                        <asp:TextBox ID="CellNumberTextBox" runat="server" 
                            Text='<%# Bind("CellNumber") %>' />
                        <br />
                        <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" 
                            CommandName="Update" Text="Update" />
                        &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" 
                            CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        Username:
                        <asp:TextBox ID="UsernameTextBox" runat="server" 
                            Text='<%# Bind("Username") %>' />
                        <br />
                        Password:
                        <asp:TextBox ID="PasswordTextBox" runat="server" 
                            Text='<%# Bind("Password") %>' />
                        <br />
                        CompanyID:
                        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="srcCompanies" 
                            DataTextField="Name" DataValueField="ID" 
                            SelectedValue='<%# Bind("CompanyID") %>'>
                        </asp:DropDownList>
                        <br />
                        Email:
                        <asp:TextBox ID="EmailTextBox" runat="server" Text='<%# Bind("Email") %>' />
                        <br />
                        Address1:
                        <asp:TextBox ID="Address1TextBox" runat="server" 
                            Text='<%# Bind("Address1") %>' />
                        <br />
                        Address2:
                        <asp:TextBox ID="Address2TextBox" runat="server" 
                            Text='<%# Bind("Address2") %>' />
                        <br />
                        Address3:
                        <asp:TextBox ID="Address3TextBox" runat="server" 
                            Text='<%# Bind("Address3") %>' />
                        <br />
                        PostalCode:
                        <asp:TextBox ID="PostalCodeTextBox" runat="server" 
                            Text='<%# Bind("PostalCode") %>' />
                        <br />
                        PhoneNumber:
                        <asp:TextBox ID="PhoneNumberTextBox" runat="server" 
                            Text='<%# Bind("PhoneNumber") %>' />
                        <br />
                        CellNumber:
                        <asp:TextBox ID="CellNumberTextBox" runat="server" 
                            Text='<%# Bind("CellNumber") %>' />
                        <br />
                        <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" 
                            CommandName="Insert" Text="Insert" />
&nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" 
                            CommandName="Cancel" Text="Cancel" />
                    </InsertItemTemplate>
                    <ItemTemplate>
                        ID:
                        <asp:Label ID="IDLabel" runat="server" Text='<%# Eval("ID") %>' />
                        <br />
                        Username:
                        <asp:Label ID="UsernameLabel" runat="server" Text='<%# Bind("Username") %>' />
                        <br />
                        Password:
                        <asp:Label ID="PasswordLabel" runat="server" Text='<%# Bind("Password") %>' />
                        <br />
                        CompanyID:
                        <asp:Label ID="CompanyIDLabel" runat="server" Text='<%# Bind("CompanyID") %>' />
                        <br />
                        Email:
                        <asp:Label ID="EmailLabel" runat="server" Text='<%# Bind("Email") %>' />
                        <br />
                        Address1:
                        <asp:Label ID="Address1Label" runat="server" Text='<%# Bind("Address1") %>' />
                        <br />
                        Address2:
                        <asp:Label ID="Address2Label" runat="server" Text='<%# Bind("Address2") %>' />
                        <br />
                        Address3:
                        <asp:Label ID="Address3Label" runat="server" Text='<%# Bind("Address3") %>' />
                        <br />
                        PostalCode:
                        <asp:Label ID="PostalCodeLabel" runat="server" 
                            Text='<%# Bind("PostalCode") %>' />
                        <br />
                        PhoneNumber:
                        <asp:Label ID="PhoneNumberLabel" runat="server" 
                            Text='<%# Bind("PhoneNumber") %>' />
                        <br />
                        CellNumber:
                        <asp:Label ID="CellNumberLabel" runat="server" 
                            Text='<%# Bind("CellNumber") %>' />
                        <br />
                        <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" 
                            CommandName="Edit" Text="Edit" />
&nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" CommandName="Delete" 
                            Text="Delete" />
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
                    <tr>
                        <td class="style2">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                </table>
                <asp:ObjectDataSource ID="srcUsers" runat="server" OldValuesParameterFormatString="original_{0}" 
                    SelectMethod="GetDataByCompanyID" 
                    TypeName="QAManagement.Data.QADatasetTableAdapters.UsersTableAdapter">
                    <SelectParameters>
                        <asp:QueryStringParameter Name="CompanyID" QueryStringField="ID" Type="Int64" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </td>
        </tr>
        <tr>
            <td>
                <asp:ObjectDataSource ID="srcUser" runat="server" DeleteMethod="Delete" 
                    InsertMethod="Insert" 
                    SelectMethod="GetDataByID" 
                    TypeName="QAManagement.Data.QADatasetTableAdapters.UsersTableAdapter" 
                    UpdateMethod="Update">
                    <DeleteParameters>
                        <asp:Parameter Name="Original_ID" Type="Int64" />
                        <asp:Parameter Name="Original_Username" Type="String" />
                        <asp:Parameter Name="Original_Password" Type="String" />
                        <asp:Parameter Name="Original_CompanyID" Type="Int64" />
                        <asp:Parameter Name="Original_Email" Type="String" />
                        <asp:Parameter Name="Original_Address1" Type="String" />
                        <asp:Parameter Name="Original_Address2" Type="String" />
                        <asp:Parameter Name="Original_Address3" Type="String" />
                        <asp:Parameter Name="Original_PostalCode" Type="String" />
                        <asp:Parameter Name="Original_PhoneNumber" Type="String" />
                        <asp:Parameter Name="Original_CellNumber" Type="String" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="Username" Type="String" />
                        <asp:Parameter Name="Password" Type="String" />
                        <asp:Parameter Name="CompanyID" Type="Int64" />
                        <asp:Parameter Name="Email" Type="String" />
                        <asp:Parameter Name="Address1" Type="String" />
                        <asp:Parameter Name="Address2" Type="String" />
                        <asp:Parameter Name="Address3" Type="String" />
                        <asp:Parameter Name="PostalCode" Type="String" />
                        <asp:Parameter Name="PhoneNumber" Type="String" />
                        <asp:Parameter Name="CellNumber" Type="String" />
                    </InsertParameters>
                    <SelectParameters>
                        <asp:ControlParameter ControlID="grdList" Name="ID" 
                            PropertyName="SelectedValue" Type="Int64" />
                    </SelectParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="Username" Type="String" />
                        <asp:Parameter Name="Password" Type="String" />
                        <asp:Parameter Name="CompanyID" Type="Int64" />
                        <asp:Parameter Name="Email" Type="String" />
                        <asp:Parameter Name="Address1" Type="String" />
                        <asp:Parameter Name="Address2" Type="String" />
                        <asp:Parameter Name="Address3" Type="String" />
                        <asp:Parameter Name="PostalCode" Type="String" />
                        <asp:Parameter Name="PhoneNumber" Type="String" />
                        <asp:Parameter Name="CellNumber" Type="String" />
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
