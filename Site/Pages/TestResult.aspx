<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TestResult.aspx.cs" Inherits="Site.Pages.TestResult" %>
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
                    DataKeyNames="ID" DataSourceID="srcTestResults" AllowPaging="True">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" 
                            ReadOnly="True" SortExpression="ID" />
                        <asp:CheckBoxField DataField="Pass" HeaderText="Pass" SortExpression="Pass" />
                        <asp:BoundField DataField="Requirement" HeaderText="Requirement" 
                            SortExpression="Requirement" />
                        <asp:BoundField DataField="Results" HeaderText="Results" 
                            SortExpression="Results" />
                    </Columns>
                </asp:GridView>
                <asp:ObjectDataSource ID="srcTestResults" runat="server" OldValuesParameterFormatString="original_{0}" 
                    SelectMethod="GetData" 
                    
                    TypeName="QAManagement.Data.dsQAManagerTableAdapters.TestResultTableAdapter">
                </asp:ObjectDataSource>
            </td>
        </tr>
        <tr>
            <td>
                <asp:FormView ID="FormView1" runat="server" DataKeyNames="ID" 
                    DataSourceID="srcTestResult">
                    <EditItemTemplate>
                        ID:
                        <asp:Label ID="IDLabel1" runat="server" Text='<%# Eval("ID") %>' />
                        <br />
                        Pass:
                        <asp:CheckBox ID="PassCheckBox" runat="server" Checked='<%# Bind("Pass") %>' />
                        <br />
                        Requirement:
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("Requirement") %>'></asp:Label>
                        <br />
                        Results:
                        <asp:TextBox ID="ResultsTextBox" runat="server" 
                            Text='<%# Bind("Results") %>' />
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
                        Pass:
                        <asp:CheckBox ID="PassCheckBox" runat="server" Checked='<%# Bind("Pass") %>' />
                        <br />
                        Requirement:
                        <asp:DropDownList ID="DropDownList1" runat="server" 
                            DataSourceID="srcRequirements" DataTextField="Description" DataValueField="ID" 
                            SelectedValue='<%# Bind("RequirementID") %>'>
                        </asp:DropDownList>
                        <br />
                        Results:
                        <asp:TextBox ID="ResultsTextBox" runat="server" 
                            Text='<%# Bind("Results") %>' />
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
                        Requirement:
                        <asp:Label ID="RequirementLabel" runat="server" 
                            Text='<%# Bind("Requirement") %>' />
                        <br />
                        Pass:
                        <asp:CheckBox ID="PassCheckBox" runat="server" Checked='<%# Bind("Pass") %>' 
                            Enabled="false" />
                        <br />
                        Results:
                        <asp:Label ID="ResultsLabel" runat="server" Text='<%# Bind("Results") %>' />
                        <br />
                        <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" 
                            CommandName="Edit" Text="Edit" />
                        &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" 
                            CommandName="Delete" Text="Delete" />
                        &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" 
                            CommandName="New" Text="New" />
                    </ItemTemplate>
                </asp:FormView>
                <asp:ObjectDataSource ID="srcTestResult" runat="server" DeleteMethod="DeleteQuery" 
                    InsertMethod="InsertQuery" OldValuesParameterFormatString="original_{0}" 
                    SelectMethod="GetDataByID" 
                    TypeName="QAManagement.Data.dsQAManagerTableAdapters.TestResultTableAdapter" 
                    UpdateMethod="UpdateQuery">
                    <DeleteParameters>
                        <asp:Parameter Name="ID" Type="Int64" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="Results" Type="String" />
                        <asp:Parameter Name="RequirementID" Type="Int64" />
                        <asp:Parameter Name="Pass" Type="Boolean" />
                    </InsertParameters>
                    <SelectParameters>
                        <asp:ControlParameter ControlID="GridView1" Name="ID" 
                            PropertyName="SelectedValue" Type="Int64" />
                    </SelectParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="Results" Type="String" />
                        <asp:Parameter Name="RequirementID" Type="Int64" />
                        <asp:Parameter Name="Pass" Type="Boolean" />
                        <asp:Parameter Name="ID" Type="Int64" />
                    </UpdateParameters>
                </asp:ObjectDataSource>
                <asp:ObjectDataSource ID="srcRequirements" runat="server" DeleteMethod="Delete" 
                    InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" 
                    SelectMethod="GetData" 
                    TypeName="QAManagement.Data.dsQAManagerTableAdapters.RequirementTableAdapter" 
                    UpdateMethod="Update">
                    <DeleteParameters>
                        <asp:Parameter Name="Original_ID" Type="Int64" />
                        <asp:Parameter Name="Original_Description" Type="String" />
                        <asp:Parameter Name="Original_LongDescription" Type="String" />
                        <asp:Parameter Name="Original_Number" Type="String" />
                        <asp:Parameter Name="Original_ProjectID" Type="Int64" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="Description" Type="String" />
                        <asp:Parameter Name="LongDescription" Type="String" />
                        <asp:Parameter Name="Number" Type="String" />
                        <asp:Parameter Name="ProjectID" Type="Int64" />
                    </InsertParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="Description" Type="String" />
                        <asp:Parameter Name="LongDescription" Type="String" />
                        <asp:Parameter Name="Number" Type="String" />
                        <asp:Parameter Name="ProjectID" Type="Int64" />
                        <asp:Parameter Name="Original_ID" Type="Int64" />
                        <asp:Parameter Name="Original_Description" Type="String" />
                        <asp:Parameter Name="Original_LongDescription" Type="String" />
                        <asp:Parameter Name="Original_Number" Type="String" />
                        <asp:Parameter Name="Original_ProjectID" Type="Int64" />
                    </UpdateParameters>
                </asp:ObjectDataSource>
            </td>
        </tr>
    </table>
</asp:Content>
