<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.master" AutoEventWireup="true" CodeFile="pageRegistro.aspx.cs" Inherits="pageRegistro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <form id="form1" runat="server">
        <table style="width: 100%">
            <tr>
                <td>&nbsp;</td>
                <td style="width: 762px">Registrarse</td>
            </tr>
            <tr>
                <td>Nombre</td>
                <td style="width: 762px">
                    <asp:TextBox ID="TxtNombre" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Apellidos</td>
                <td style="width: 762px">
                    <asp:TextBox ID="TxtApellidos" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Contraseña</td>
                <td style="width: 762px">
                    <asp:TextBox ID="TxtContraseña" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Usuario</td>
                <td style="width: 762px">
                    <asp:TextBox ID="TxtUsuario" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Teléfono</td>
                <td style="width: 762px">
                    <asp:TextBox ID="TxtTelefono" runat="server" TextMode="Phone" ></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Correo</td>
                <td style="width: 762px">
                    <asp:TextBox ID="TxtCorreo" runat="server" TextMode="Email" Width="252px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Descripcion</td>
                <td style="width: 762px">
                    <asp:TextBox ID="TxtDescripcion" runat="server" OnTextChanged="TxtDescripcion_TextChanged" Height="82px" Width="373px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Tipo de usuario</td>
                <td style="width: 762px">
                    <asp:DropDownList ID="DropTipoUsuario" runat="server" OnSelectedIndexChanged="DropTipoUsuario_SelectedIndexChanged">
                        <asp:ListItem>Turista</asp:ListItem>
                        <asp:ListItem>Guía</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td style="width: 762px">
                    <br />
                    <div class="g-recaptcha" data-sitekey="6LdjAncUAAAAALqfp-rYqtTYGr26TXJV5_Ofkcg8"></div>
                        <br />
                    <br />
                    <br />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td style="width: 762px">
                    <asp:Label ID="lblestado" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td style="width: 762px">
                    <asp:Button ID="BtnCrearCuenta" runat="server" Text="Crear cuenta" BackColor="Blue" ForeColor="White" OnClick="BtnCrearCuenta_Click" />
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/pageLogin.aspx">Volver</asp:HyperLink>
                </td>
            </tr>
        </table>
    </form>

</asp:Content>

