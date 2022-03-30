
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FileUploadController.aspx.cs" Inherits="FileUploadController.FileUploadedü" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="FileUpload1" runat="server" /> &nbsp <asp:Button ID="btnUpload" runat="server" Text="File Upload" OnClick="btnUpload_Click" />
            <br /><asp:Label ID="lblMessage" runat="server" ></asp:Label>
        </div>
    </form>
</body>
</html>
