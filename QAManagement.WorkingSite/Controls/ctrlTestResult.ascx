<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrlTestResult.ascx.cs" Inherits="QAManagement.WorkingSite.Controls.ctrlTestResult" %>
<asp:FormView ID="FormView1" runat="server" 
    DataSourceID="srcTestResultProvider">
    <EditItemTemplate>
        ID:
        <asp:TextBox ID="IDTextBox" runat="server" Text='<%# Bind("ID") %>' />
        <br />
        Results:
        <asp:TextBox ID="ResultsTextBox" runat="server" Text='<%# Bind("Results") %>' />
        <br />
        RequirementID:
        <asp:TextBox ID="RequirementIDTextBox" runat="server" 
            Text='<%# Bind("RequirementID") %>' />
        <br />
        Pass:
        <asp:CheckBox ID="PassCheckBox" runat="server" Checked='<%# Bind("Pass") %>' />
        <br />
        <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" 
            CommandName="Update" Text="Update" />
        &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" 
            CausesValidation="False" CommandName="Cancel" Text="Cancel" />
    </EditItemTemplate>
    <InsertItemTemplate>
        ID:
        <asp:TextBox ID="IDTextBox" runat="server" Text='<%# Bind("ID") %>' />
        <br />
        Results:
        <asp:TextBox ID="ResultsTextBox" runat="server" Text='<%# Bind("Results") %>' />
        <br />
        RequirementID:
        <asp:TextBox ID="RequirementIDTextBox" runat="server" 
            Text='<%# Bind("RequirementID") %>' />
        <br />
        Pass:
        <asp:CheckBox ID="PassCheckBox" runat="server" Checked='<%# Bind("Pass") %>' />
        <br />
        <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" 
            CommandName="Insert" Text="Insert" />
        &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" 
            CausesValidation="False" CommandName="Cancel" Text="Cancel" />
    </InsertItemTemplate>
    <ItemTemplate>
        ID:
        <asp:Label ID="IDLabel" runat="server" Text='<%# Bind("ID") %>' />
        <br />
        Results:
        <asp:Label ID="ResultsLabel" runat="server" Text='<%# Bind("Results") %>' />
        <br />
        RequirementID:
        <asp:Label ID="RequirementIDLabel" runat="server" 
            Text='<%# Bind("RequirementID") %>' />
        <br />
        Pass:
        <asp:CheckBox ID="PassCheckBox" runat="server" Checked='<%# Bind("Pass") %>' 
            Enabled="false" />
        <br />

    </ItemTemplate>
</asp:FormView>
<asp:ObjectDataSource ID="srcTestResultProvider" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="GetPaymentPoint" 
    TypeName="QAManagement.TestResultProvider">
    <SelectParameters>
        <asp:QueryStringParameter Name="id" QueryStringField="ID" Type="Int32" />
    </SelectParameters>
</asp:ObjectDataSource>

