<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtEstadoViejo" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtEstadoLemus" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtEstadoPepe" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtEstadoHugo" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtestadoArturo" runat="server"></asp:TextBox>

        <asp:Button ID="btnIniciar" runat="server" OnClick="btnIniciar_Click"/>
    </div>
    </form>
</body>
</html>
