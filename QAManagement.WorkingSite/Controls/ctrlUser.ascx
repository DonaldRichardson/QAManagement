<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrlUser.ascx.cs" Inherits="QAManagement.WorkingSite.Controls.ctrlUser" %>
<asp:FormView ID="FormView1" runat="server" DataSourceID="srcUsers">
    <EditItemTemplate>
        ID:
        <asp:TextBox ID="IDTextBox" runat="server" Text='<%# Bind("ID") %>' />
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
        <asp:TextBox ID="CompanyIDTextBox" runat="server" 
            Text='<%# Bind("CompanyID") %>' />
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
        PaypointThreshold:
        <asp:TextBox ID="PaypointThresholdTextBox" runat="server" 
            Text='<%# Bind("PaypointThreshold") %>' />
        <br />
        Bank:
        <asp:TextBox ID="BankTextBox" runat="server" Text='<%# Bind("Bank") %>' />
        <br />
        AccountNo:
        <asp:TextBox ID="AccountNoTextBox" runat="server" 
            Text='<%# Bind("AccountNo") %>' />
        <br />
        BranchCode:
        <asp:TextBox ID="BranchCodeTextBox" runat="server" 
            Text='<%# Bind("BranchCode") %>' />
        <br />
        Active:
        <asp:CheckBox ID="ActiveCheckBox" runat="server" 
            Checked='<%# Bind("Active") %>' />
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
        Username:
        <asp:TextBox ID="UsernameTextBox" runat="server" 
            Text='<%# Bind("Username") %>' />
        <br />
        Password:
        <asp:TextBox ID="PasswordTextBox" runat="server" 
            Text='<%# Bind("Password") %>' />
        <br />
        CompanyID:
        <asp:TextBox ID="CompanyIDTextBox" runat="server" 
            Text='<%# Bind("CompanyID") %>' />
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
        PaypointThreshold:
        <asp:TextBox ID="PaypointThresholdTextBox" runat="server" 
            Text='<%# Bind("PaypointThreshold") %>' />
        <br />
        Bank:
        <asp:TextBox ID="BankTextBox" runat="server" Text='<%# Bind("Bank") %>' />
        <br />
        AccountNo:
        <asp:TextBox ID="AccountNoTextBox" runat="server" 
            Text='<%# Bind("AccountNo") %>' />
        <br />
        BranchCode:
        <asp:TextBox ID="BranchCodeTextBox" runat="server" 
            Text='<%# Bind("BranchCode") %>' />
        <br />
        Active:
        <asp:CheckBox ID="ActiveCheckBox" runat="server" 
            Checked='<%# Bind("Active") %>' />
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
        PaypointThreshold:
        <asp:Label ID="PaypointThresholdLabel" runat="server" 
            Text='<%# Bind("PaypointThreshold") %>' />
        <br />
        Bank:
        <asp:Label ID="BankLabel" runat="server" Text='<%# Bind("Bank") %>' />
        <br />
        AccountNo:
        <asp:Label ID="AccountNoLabel" runat="server" Text='<%# Bind("AccountNo") %>' />
        <br />
        BranchCode:
        <asp:Label ID="BranchCodeLabel" runat="server" 
            Text='<%# Bind("BranchCode") %>' />
        <br />
        Active:
        <asp:CheckBox ID="ActiveCheckBox" runat="server" 
            Checked='<%# Bind("Active") %>' Enabled="false" />
        <br />

    </ItemTemplate>
</asp:FormView>
<asp:ObjectDataSource ID="srcUsers" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="GetPaymentPoint" 
    TypeName="QAManagement.UsersProvider">
    <SelectParameters>
        <asp:QueryStringParameter Name="id" QueryStringField="ID" Type="Int32" />
    </SelectParameters>
</asp:ObjectDataSource>

