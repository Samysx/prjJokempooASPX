<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaginaInicial.aspx.cs" Inherits="prjJogoJoquempô.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" type="text/css" href="CSS/Estilos.css"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="contPag">
            <div class="containerPag">
                    <asp:Button Class="btnButton" ID="Button1" runat="server" Text="Maquina Vs Maquina" OnClick="Button1_Click" />
                    <asp:Button Class="btnButton" ID="Button2" runat="server" Text="Player Vs Maquina" OnClick="Button2_Click" />
            </div>

        </div>
    </form>
</body>
</html>
