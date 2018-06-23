<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrlCompany.ascx.cs" Inherits="QAManagement.WorkingSite.Controls.ctrlCompany" %>
<asp:FormView ID="FormView1" runat="server" DataSourceID="srcCompanyProvider">
    <EditItemTemplate>
        ID:
        <asp:TextBox ID="IDTextBox" runat="server" Text='<%# Bind("ID") %>' />
        <br />
        Name:
        <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
        <br />
        Description:
        <asp:TextBox ID="DescriptionTextBox" runat="server" 
            Text='<%# Bind("Description") %>' />
        <br />
        ContactPerson:
        <asp:TextBox ID="ContactPersonTextBox" runat="server" 
            Text='<%# Bind("ContactPerson") %>' />
        <br />
        ContactPersonNumber:
        <asp:TextBox ID="ContactPersonNumberTextBox" runat="server" 
            Text='<%# Bind("ContactPersonNumber") %>' />
        <br />
        ContactEmail:
        <asp:TextBox ID="ContactEmailTextBox" runat="server" 
            Text='<%# Bind("ContactEmail") %>' />
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
        OfficePhoneNumber:
        <asp:TextBox ID="OfficePhoneNumberTextBox" runat="server" 
            Text='<%# Bind("OfficePhoneNumber") %>' />
        <br />
        OfficeEmail:
        <asp:TextBox ID="OfficeEmailTextBox" runat="server" 
            Text='<%# Bind("OfficeEmail") %>' />
        <br />
        Validated:
        <asp:TextBox ID="ValidatedTextBox" runat="server" 
            Text='<%# Bind("Validated") %>' />
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
        Name:
        <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
        <br />
        Description:
        <asp:TextBox ID="DescriptionTextBox" runat="server" 
            Text='<%# Bind("Description") %>' />
        <br />
        ContactPerson:
        <asp:TextBox ID="ContactPersonTextBox" runat="server" 
            Text='<%# Bind("ContactPerson") %>' />
        <br />
        ContactPersonNumber:
        <asp:TextBox ID="ContactPersonNumberTextBox" runat="server" 
            Text='<%# Bind("ContactPersonNumber") %>' />
        <br />
        ContactEmail:
        <asp:TextBox ID="ContactEmailTextBox" runat="server" 
            Text='<%# Bind("ContactEmail") %>' />
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
        OfficePhoneNumber:
        <asp:TextBox ID="OfficePhoneNumberTextBox" runat="server" 
            Text='<%# Bind("OfficePhoneNumber") %>' />
        <br />
        OfficeEmail:
        <asp:TextBox ID="OfficeEmailTextBox" runat="server" 
            Text='<%# Bind("OfficeEmail") %>' />
        <br />
        Validated:
        <asp:TextBox ID="ValidatedTextBox" runat="server" 
            Text='<%# Bind("Validated") %>' />
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
        Name:
        <asp:Label ID="NameLabel" runat="server" Text='<%# Bind("Name") %>' />
        <br />
        Description:
        <asp:Label ID="DescriptionLabel" runat="server" 
            Text='<%# Bind("Description") %>' />
        <br />
        ContactPerson:
        <asp:Label ID="ContactPersonLabel" runat="server" 
            Text='<%# Bind("ContactPerson") %>' />
        <br />
        ContactPersonNumber:
        <asp:Label ID="ContactPersonNumberLabel" runat="server" 
            Text='<%# Bind("ContactPersonNumber") %>' />
        <br />
        ContactEmail:
        <asp:Label ID="ContactEmailLabel" runat="server" 
            Text='<%# Bind("ContactEmail") %>' />
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
        OfficePhoneNumber:
        <asp:Label ID="OfficePhoneNumberLabel" runat="server" 
            Text='<%# Bind("OfficePhoneNumber") %>' />
        <br />
        OfficeEmail:
        <asp:Label ID="OfficeEmailLabel" runat="server" 
            Text='<%# Bind("OfficeEmail") %>' />
        <br />
        Validated:
        <asp:Label ID="ValidatedLabel" runat="server" Text='<%# Bind("Validated") %>' />
        <br />

    </ItemTemplate>
</asp:FormView>
<asp:ObjectDataSource ID="srcCompanyProvider" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="GetCompany" 
    TypeName="QAManagement.CompanyProvider">
    <SelectParameters>
        <asp:QueryStringParameter Name="id" QueryStringField="ID" Type="Int32" />
    </SelectParameters>
</asp:ObjectDataSource>


