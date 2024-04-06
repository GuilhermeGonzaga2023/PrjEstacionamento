<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="estacionamentoPrjIntegrador.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="/estilo/estilo.css" rel="stylesheet" />
    <title>Estacionamento SENAC</title>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            <h2>Bem Vindo ao estacionamento</h2>
            <div id="txt1">
                <asp:Label ID="Label3" runat="server" Text="nome:"></asp:Label>
                <asp:TextBox ID="txtLogin" runat="server"></asp:TextBox>
            </div>
            <div id="txt2">
                <asp:Label ID="Label2" runat="server" Text="Senha:"></asp:Label>
                <asp:TextBox ID="txtSenha" runat="server" Visible="True" TextMode="Password"></asp:TextBox>
            </div>
            <div id="btn">
                <asp:Button ID="btnAcessar" runat="server" Text="acessar" OnClick="btnAcessar_Click" />
                <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" OnClick="btnCadastrar_Click" />

            </div>
                <asp:Label ID="msgErro" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
