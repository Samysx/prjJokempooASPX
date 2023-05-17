<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MaquinaVsMaquina.aspx.cs" Inherits="prjJogoJoquempô.PaginaInicial" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" type="text/css" href="CSS/Estilos.css"/>
    <title></title>
</head>

<body>
    <form id="form1" runat="server">
        <div class="bigDiv">
            <div class="container">
                <asp:Label Class="lbl" ID="Label2" runat="server" Text="Jogo Joquempô"></asp:Label>
                </br>
                <br />
                 <asp:Image class="img" ID="Image1" runat="server" Height="150px" Width="150px" />
                 <asp:Image class="img" ID="Image2" runat="server" Height="150px" Width="150px" />
                </br>
                <br />
                 <asp:Button class="btn" ID="BtnSortear" runat="server" Text="Jogar" OnClick="BtnSortear_Click" /><br />
                <asp:Label ID="Label1" runat="server" Text="Empates:"></asp:Label>
                <asp:Label ID="lblempates" runat="server" Text="0"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
