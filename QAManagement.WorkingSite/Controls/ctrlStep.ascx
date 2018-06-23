<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrlStep.ascx.cs" Inherits="QAManagement.WorkingSite.Controls.ctrlStep" %>
<asp:FormView ID="FormView1" runat="server" DataSourceID="srcStepProvider">
    <EditItemTemplate>
        ID:
        <asp:TextBox ID="IDTextBox" runat="server" Text='<%# Bind("ID") %>' />
        <br />
        RequirementID:
        <asp:TextBox ID="RequirementIDTextBox" runat="server" 
            Text='<%# Bind("RequirementID") %>' />
        <br />
        Number:
        <asp:TextBox ID="NumberTextBox" runat="server" Text='<%# Bind("Number") %>' />
        <br />
        Description:
        <asp:TextBox ID="DescriptionTextBox" runat="server" 
            Text='<%# Bind("Description") %>' />
        <br />
        Result:
        <asp:TextBox ID="ResultTextBox" runat="server" Text='<%# Bind("Result") %>' />
        <br />
        IsTest:
        <asp:CheckBox ID="IsTestCheckBox" runat="server" 
            Checked='<%# Bind("IsTest") %>' />
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
        RequirementID:
        <asp:TextBox ID="RequirementIDTextBox" runat="server" 
            Text='<%# Bind("RequirementID") %>' />
        <br />
        Number:
        <asp:TextBox ID="NumberTextBox" runat="server" Text='<%# Bind("Number") %>' />
        <br />
        Description:
        <asp:TextBox ID="DescriptionTextBox" runat="server" 
            Text='<%# Bind("Description") %>' />
        <br />
        Result:
        <asp:TextBox ID="ResultTextBox" runat="server" Text='<%# Bind("Result") %>' />
        <br />
        IsTest:
        <asp:CheckBox ID="IsTestCheckBox" runat="server" 
            Checked='<%# Bind("IsTest") %>' />
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
        RequirementID:
        <asp:Label ID="RequirementIDLabel" runat="server" 
            Text='<%# Bind("RequirementID") %>' />
        <br />
        Number:
        <asp:Label ID="NumberLabel" runat="server" Text='<%# Bind("Number") %>' />
        <br />
        Description:
        <asp:Label ID="DescriptionLabel" runat="server" 
            Text='<%# Bind("Description") %>' />
        <br />
        Result:
        <asp:Label ID="ResultLabel" runat="server" Text='<%# Bind("Result") %>' />
        <br />
        IsTest:
        <asp:CheckBox ID="IsTestCheckBox" runat="server" 
            Checked='<%# Bind("IsTest") %>' Enabled="false" />
        <br />

    </ItemTemplate>
</asp:FormView>
<asp:ObjectDataSource ID="srcStepProvider" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="GetPaymentPoint" 
    TypeName="QAManagement.StepProvider">
    <SelectParameters>
        <asp:QueryStringParameter Name="id" QueryStringField="ID" Type="Int32" />
    </SelectParameters>
</asp:ObjectDataSource>

