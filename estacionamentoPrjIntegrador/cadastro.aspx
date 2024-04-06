<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cadastro.aspx.cs" Inherits="estacionamentoPrjIntegrador.cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="/estilo/estilo.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
         <div>
            <h2>Cadastro</h2>
            <div id="txt1">
                <asp:Label ID="Label4" runat="server" Text="nome"></asp:Label>
                <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
            </div>
            <div id="txt2">
                <asp:Label ID="Label2" runat="server" Text="Senha"></asp:Label>
                <asp:TextBox ID="txtSenha" runat="server" TextMode="Password"></asp:TextBox>
            </div>
            <div id="btn">
                <asp:Button ID="btnCadastrar" runat="server" Text="cadastrar" OnClick="btnCadastrar_Click" />
                <asp:Button ID="btnVoltar" runat="server" Text="voltar" OnClick="btnVoltar_Click" />
            </div>
             <asp:Label ID="msgErro" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
