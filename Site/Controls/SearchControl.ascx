<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SearchControl.ascx.cs" Inherits="QAManagement.Site.Controls.SearchControl" %>
<style type="text/css">
    .style1
    {
        width: 100%;
        float: left;
    }
</style>

<table cellpadding="0" cellspacing="0" class="style1">
    <tr>
        <td>
            <asp:TextBox ID="txtSearch" runat="server" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:Button ID="btnSearch" runat="server" Text=".." Height="22px" />
        </td>
    </tr>
</table>

