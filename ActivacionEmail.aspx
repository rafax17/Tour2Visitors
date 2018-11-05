<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ActivacionEmail.aspx.cs" Inherits="ActivacionEmail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 39%;
            height: 94px;
        }
        .auto-style2 {
            width: 213px;
        }
        .auto-style3 {
            width: 151px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="Tour2Visitors"></asp:Label>
            <br />
            <br />
            Activa tu cuenta<br />
            <br />
            <asp:Label ID="Label3" runat="server"></asp:Label>
            <br />
            <br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">&nbsp;Código de activación&nbsp;</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox1" runat="server" Height="27px" Width="133px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style2">
                        <asp:Button ID="Button1" runat="server" BackColor="#99FF99" ForeColor="Black" Height="28px" Text="Verifica email" Width="101px" OnClick="Button1_Click" />
                    </td>
                </tr>
            </table>
        </div>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" BackColor="White" ForeColor="#0033CC"></asp:Label>
    </form>
</body>
</html>
