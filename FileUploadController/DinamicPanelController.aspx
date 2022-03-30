<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DinamicPanelController.aspx.cs" Inherits="FileUploadController.DinamicPanelController" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td><b>Control Type</b></td>
                    <td>
                        <asp:CheckBoxList ID="chkBoxListControlType" RepeatDirection="Horizontal" runat="server">
                            <asp:ListItem>Label</asp:ListItem>
                            <asp:ListItem>TextBox</asp:ListItem>
                            <asp:ListItem>Button</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                    <td><b>How Many</b></td>
                    <td>
                        <asp:TextBox ID="txtControlsCount" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btnGenerateControl" runat="server" Text="Generate Controls" OnClick="btnGenerateControl_Click" /></td>
                </tr>
                <tr>
                    <td colspan="5">
                        <h3>Label Controls</h3>
                    </td>
                </tr>
                <tr>
                    <td colspan="5" id="tdLabels" runat="server">
                        <asp:Panel ID="pnlLabels" runat="server"></asp:Panel>
                    </td>
                </tr>
                 <tr>
                    <td colspan="5">
                        <h3>TextBox Controls</h3>
                    </td>
                </tr>
                <tr>
                    <td colspan="5" id="tdTextBoxes" runat="server">
                        <asp:Panel ID="pnlTextBoxes" runat="server"></asp:Panel>
                    </td>
                </tr>
                 <tr>
                    <td colspan="5">
                        <h3>Button Controls</h3>
                    </td>
                </tr>
                <tr>
                    <td colspan="5"id="tdButtons" runat="server">
                        <asp:Panel ID="pnlButtons" runat="server"></asp:Panel>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
