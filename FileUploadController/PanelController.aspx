<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PanelController.aspx.cs" Inherits="FileUploadController.PanelController" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Value="-1">Select User</asp:ListItem>
                <asp:ListItem Value="Admin">Admin User</asp:ListItem>
                <asp:ListItem Value="NonAdmin">Non-AdminUser</asp:ListItem>
            </asp:DropDownList>
            <asp:Panel ID="AdminPanel" runat="server">
                <table>
                    <tr>
                        <td colspan="2">
                            <asp:Label ID="AdminGreeting" Font-Size="XX-Large" runat="server" Text="You are logged in as an administrator"></asp:Label>
                        </td>
                    </tr>

                    <tr>
                        <td>
                            <asp:Label ID="AdminNameLabel" runat="server" Text="Admin Name:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="AdminNameTextBox" Text="Alper" runat="server"></asp:TextBox>
                        </td>
                    </tr>

                    <tr>
                        <td>
                            <asp:Label ID="AdminRegionLabel" runat="server" Text="Admin Region:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="AdminRegionTextBox" runat="server" Text="Europa"></asp:TextBox>
                        </td>
                    </tr>

                    <tr>
                        <td>
                            <asp:Label ID="AdminActionsLabel" runat="server" Text="Actions:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="AdminActionsTextBox" runat="server" Font-Size="Medium" TextMode="MultiLine" Text="There are 4 user queries to be answered" Font-Bold="true"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </asp:Panel>
            <asp:Panel ID="NonAdminPanel" runat="server">
                <table>
                    <tr>
                        <td colspan="2">
                            <asp:Label ID="NonAdminGreeting" runat="server" Font-Size="XX-Large" Text="Welcome Elif!"></asp:Label>
                        </td>
                    </tr>

                    <tr>
                        <td>
                            <asp:Label ID="NonAdminNameLabel" runat="server" Text="User Name:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="NonAdminNameTextBox" runat="server" Text="Elif"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="NonAdminRegion" runat="server" Text="User Region:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="NonAdminRegionTextBox" runat="server" Text="United Kingdom"></asp:TextBox>
                        </td>
                    </tr>

                    <tr>
                        <td>
                            <asp:Label ID="NonAdminCityLabel" runat="server" Text="City:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="NonAdminCityTextBox" runat="server" Text="London"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </asp:Panel>

        </div>
    </form>
</body>
</html>
