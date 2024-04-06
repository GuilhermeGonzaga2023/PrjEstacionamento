<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="estacionamento.aspx.cs" Inherits="estacionamentoPrjIntegrador.estacionamento" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="/estilo/estilo.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div id="txt3">
                <asp:Label ID="lbl1" runat="server" Text="horario de chegada"></asp:Label>
                <asp:TextBox ID="txtEntrada" runat="server" TextMode="Time" DataFormatString="HH:mm"></asp:TextBox>
            </div>
            <div id="txt2">
                <asp:Label ID="lbl2" runat="server" Text="horario de saida"></asp:Label>
                <asp:TextBox ID="txtSaida" runat="server" TextMode="Time" DataFormatString="HH:mm"></asp:TextBox>
            </div>
            <div id="btn">
                <asp:Button ID="btnCalc" runat="server" Text="Calcular" OnClick="btnCalc_Click" />
            </div>
            <asp:Label ID="lblResultadoFinal" runat="server" Text=""></asp:Label>
            <asp:Label ID="msgErro" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
