<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrlRequirement.ascx.cs" Inherits="QAManagement.WorkingSite.Controls.ctrlRequirement" %>
<asp:FormView ID="FormView1" runat="server" 
    DataSourceID="srcRequirementProvider">
    <EditItemTemplate>
        ID:
        <asp:TextBox ID="IDTextBox" runat="server" Text='<%# Bind("ID") %>' />
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
        ProjectID:
        <asp:TextBox ID="ProjectIDTextBox" runat="server" 
            Text='<%# Bind("ProjectID") %>' />
        <br />
        SpecificationReference:
        <asp:TextBox ID="SpecificationReferenceTextBox" runat="server" 
            Text='<%# Bind("SpecificationReference") %>' />
        <br />
        PassingDescription:
        <asp:TextBox ID="PassingDescriptionTextBox" runat="server" 
            Text='<%# Bind("PassingDescription") %>' />
        <br />
        Weighting:
        <asp:TextBox ID="WeightingTextBox" runat="server" 
            Text='<%# Bind("Weighting") %>' />
        <br />
        OwnedByUserID:
        <asp:TextBox ID="OwnedByUserIDTextBox" runat="server" 
            Text='<%# Bind("OwnedByUserID") %>' />
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
        ProjectID:
        <asp:TextBox ID="ProjectIDTextBox" runat="server" 
            Text='<%# Bind("ProjectID") %>' />
        <br />
        SpecificationReference:
        <asp:TextBox ID="SpecificationReferenceTextBox" runat="server" 
            Text='<%# Bind("SpecificationReference") %>' />
        <br />
        PassingDescription:
        <asp:TextBox ID="PassingDescriptionTextBox" runat="server" 
            Text='<%# Bind("PassingDescription") %>' />
        <br />
        Weighting:
        <asp:TextBox ID="WeightingTextBox" runat="server" 
            Text='<%# Bind("Weighting") %>' />
        <br />
        OwnedByUserID:
        <asp:TextBox ID="OwnedByUserIDTextBox" runat="server" 
            Text='<%# Bind("OwnedByUserID") %>' />
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
        ProjectID:
        <asp:Label ID="ProjectIDLabel" runat="server" Text='<%# Bind("ProjectID") %>' />
        <br />
        SpecificationReference:
        <asp:Label ID="SpecificationReferenceLabel" runat="server" 
            Text='<%# Bind("SpecificationReference") %>' />
        <br />
        PassingDescription:
        <asp:Label ID="PassingDescriptionLabel" runat="server" 
            Text='<%# Bind("PassingDescription") %>' />
        <br />
        Weighting:
        <asp:Label ID="WeightingLabel" runat="server" Text='<%# Bind("Weighting") %>' />
        <br />
        OwnedByUserID:
        <asp:Label ID="OwnedByUserIDLabel" runat="server" 
            Text='<%# Bind("OwnedByUserID") %>' />
        <br />

    </ItemTemplate>
</asp:FormView>
<asp:ObjectDataSource ID="srcRequirementProvider" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="GetPaymentPoint" 
    TypeName="QAManagement.RequirementProvider">
    <SelectParameters>
        <asp:QueryStringParameter Name="id" QueryStringField="ID" Type="Int32" />
    </SelectParameters>
</asp:ObjectDataSource>

