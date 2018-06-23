<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrlProjectUser.ascx.cs" Inherits="QAManagement.WorkingSite.Controls.ctrlProjectUser" %>
<asp:FormView ID="FormView1" runat="server" 
    DataSourceID="srcProjectUserProvider">
    <EditItemTemplate>
        ID:
        <asp:TextBox ID="IDTextBox" runat="server" Text='<%# Bind("ID") %>' />
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
        ID:
        <asp:TextBox ID="IDTextBox" runat="server" Text='<%# Bind("ID") %>' />
        <br />
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
        <asp:Label ID="IDLabel" runat="server" Text='<%# Bind("ID") %>' />
        <br />
        UserID:
        <asp:Label ID="UserIDLabel" runat="server" Text='<%# Bind("UserID") %>' />
        <br />
        ProjectID:
        <asp:Label ID="ProjectIDLabel" runat="server" Text='<%# Bind("ProjectID") %>' />
        <br />

    </ItemTemplate>
</asp:FormView>
<asp:ObjectDataSource ID="srcProjectUserProvider" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="GetPaymentPoint" 
    TypeName="QAManagement.ProjectUsersProvider">
    <SelectParameters>
        <asp:QueryStringParameter Name="id" QueryStringField="ID" Type="Int32" />
    </SelectParameters>
</asp:ObjectDataSource>

