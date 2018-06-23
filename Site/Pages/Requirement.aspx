<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Requirement.aspx.cs" Inherits="Site.Pages.Requirement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table cellpadding="0" cellspacing="0" class="style1">
        <tr>
            <td>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    DataKeyNames="ID" DataSourceID="srcRequirements" AllowPaging="True">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" 
                            ReadOnly="True" SortExpression="ID" />
                        <asp:BoundField DataField="Description" HeaderText="Description" 
                            SortExpression="Description" />
                        <asp:BoundField DataField="LongDescription" HeaderText="LongDescription" 
                            SortExpression="LongDescription" />
                        <asp:BoundField DataField="Number" HeaderText="Number" 
                            SortExpression="Number" />
                        <asp:BoundField DataField="ProjectName" HeaderText="ProjectName" 
                            SortExpression="ProjectName" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td>
                <asp:ObjectDataSource ID="srcRequirement" runat="server" DeleteMethod="DeleteQuery" 
                    InsertMethod="InsertQuery" 
                    SelectMethod="GetDataByID" 
                    TypeName="QAManagement.Data.dsQAManagerTableAdapters.RequirementTableAdapter" 
                    UpdateMethod="UpdateQuery">
                    <DeleteParameters>
                        <asp:Parameter Name="ID" Type="Int64" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="Description" Type="String" />
                        <asp:Parameter Name="LongDescription" Type="String" />
                        <asp:Parameter Name="Number" Type="String" />
                        <asp:Parameter Name="ProjectID" Type="Int64" />
                    </InsertParameters>
                    <SelectParameters>
                        <asp:ControlParameter ControlID="GridView1" Name="ID" 
                            PropertyName="SelectedValue" Type="Int64" />
                    </SelectParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="Description" Type="String" />
                        <asp:Parameter Name="LongDescription" Type="String" />
                        <asp:Parameter Name="Number" Type="String" />
                        <asp:Parameter Name="ProjectID" Type="Int64" />
                        <asp:Parameter Name="ID" Type="Int64" />
                    </UpdateParameters>
                </asp:ObjectDataSource>
                <asp:FormView ID="FormView1" runat="server" DataKeyNames="ID" 
                    DataSourceID="srcRequirement">
                    <EditItemTemplate>
                        ID:
                        <asp:Label ID="IDLabel1" runat="server" Text='<%# Eval("ID") %>' />
                        <br />
                        Description:
                        <asp:TextBox ID="DescriptionTextBox" runat="server" 
                            Text='<%# Bind("Description") %>' />
                        <br />
                        LongDescription:
                        <asp:TextBox ID="LongDescriptionTextBox" runat="server" 
                            Text='<%# Bind("LongDescription") %>' />
                        <br />
                        Number:
                        <asp:TextBox ID="NumberTextBox" runat="server" Text='<%# Bind("Number") %>' />
                        <br />
                        ProjectName:
                        <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="srcProjects" 
                            DataTextField="Name" DataValueField="ID" 
                            SelectedValue='<%# Bind("ProjectID") %>'>
                        </asp:DropDownList>
                        <br />
                        <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" 
                            CommandName="Update" Text="Update" />
&nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" 
                            CommandName="Cancel" Text="Cancel" />
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        Description:
                        <asp:TextBox ID="DescriptionTextBox" runat="server" 
                            Text='<%# Bind("Description") %>' />
                        <br />
                        LongDescription:
                        <asp:TextBox ID="LongDescriptionTextBox" runat="server" 
                            Text='<%# Bind("LongDescription") %>' />
                        <br />
                        Number:
                        <asp:TextBox ID="NumberTextBox" runat="server" Text='<%# Bind("Number") %>' />
                        <br />
                        ProjectName:
                        <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="srcProjects" 
                            DataTextField="Name" DataValueField="ID" 
                            SelectedValue='<%# Bind("ProjectID") %>'>
                        </asp:DropDownList>
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
                        Description:
                        <asp:Label ID="DescriptionLabel" runat="server" 
                            Text='<%# Bind("Description") %>' />
                        <br />
                        LongDescription:
                        <asp:Label ID="LongDescriptionLabel" runat="server" 
                            Text='<%# Bind("LongDescription") %>' />
                        <br />
                        Number:
                        <asp:Label ID="NumberLabel" runat="server" Text='<%# Bind("Number") %>' />
                        <br />
                        ProjectName:
                        <asp:Label ID="ProjectNameLabel" runat="server" 
                            Text='<%# Bind("ProjectName") %>' />
                        <br />
                        <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" 
                            CommandName="Edit" Text="Edit" />
&nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" CommandName="Delete" 
                            Text="Delete" />
                        &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" 
                            CommandName="New" Text="New" />
                    </ItemTemplate>
                </asp:FormView>
                <asp:ObjectDataSource ID="srcProjects" runat="server" 
                    OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" 
                    TypeName="QAManagement.Data.dsQAManagerTableAdapters.ProjectTableAdapter">
                </asp:ObjectDataSource>
                <asp:ObjectDataSource ID="srcRequirements" runat="server" OldValuesParameterFormatString="original_{0}" 
                    SelectMethod="GetData" 
                    
                    TypeName="QAManagement.Data.dsQAManagerTableAdapters.RequirementTableAdapter">
                </asp:ObjectDataSource>
            </td>
        </tr>
    </table>
</asp:Content>
