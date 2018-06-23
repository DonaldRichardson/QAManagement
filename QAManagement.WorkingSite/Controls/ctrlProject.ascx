<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrlProject.ascx.cs" Inherits="QAManagement.WorkingSite.Controls.ctrlProject" %>
<asp:FormView ID="FormView1" runat="server" DataSourceID="srcProjectProvider">
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
        CompanyID:
        <asp:TextBox ID="CompanyIDTextBox" runat="server" 
            Text='<%# Bind("CompanyID") %>' />
        <br />
        TestingDepth:
        <asp:TextBox ID="TestingDepthTextBox" runat="server" 
            Text='<%# Bind("TestingDepth") %>' />
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
        CompanyID:
        <asp:TextBox ID="CompanyIDTextBox" runat="server" 
            Text='<%# Bind("CompanyID") %>' />
        <br />
        TestingDepth:
        <asp:TextBox ID="TestingDepthTextBox" runat="server" 
            Text='<%# Bind("TestingDepth") %>' />
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
        CompanyID:
        <asp:Label ID="CompanyIDLabel" runat="server" Text='<%# Bind("CompanyID") %>' />
        <br />
        TestingDepth:
        <asp:Label ID="TestingDepthLabel" runat="server" 
            Text='<%# Bind("TestingDepth") %>' />
        <br />

    </ItemTemplate>
</asp:FormView>
<asp:ObjectDataSource ID="srcProjectProvider" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="GetProject" 
    TypeName="QAManagement.ProjectProvider">
    <SelectParameters>
        <asp:QueryStringParameter Name="id" QueryStringField="ID" Type="Int32" />
    </SelectParameters>
</asp:ObjectDataSource>

