<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="EjercicioIntegrador1_Mendoza.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 98%;
            height: 245px;
        }
        .auto-style2 {
            text-align: center;
            width: 344px;
            height: 50px;
        }
        .auto-style3 {
            width: 344px;
            height: 42px;
        }
        .auto-style7 {
            text-align: center;
            width: 344px;
            font-size: x-large;
            color: #8B0000;
        }
        .auto-style15 {
            text-align: left;
        }
        .auto-style19 {
            height: 50px;
        }
        .auto-style24 {
            height: 45px;
        }
        .auto-style25 {
            text-align: right;
            width: 344px;
            height: 45px;
        }
        .auto-style27 {
            width: 100%;
        }
        .auto-style16 {
            font-size: small;
        }
        .auto-style28 {
            width: 287px;
        }
        .auto-style30 {
            width: 59px;
        }
        .auto-style31 {
            height: 45px;
            width: 59px;
        }
        .auto-style32 {
            height: 50px;
            width: 59px;
        }
        .auto-style33 {
            height: 42px;
            width: 59px;
        }
        .auto-style34 {
            height: 42px;
        }
        .auto-style35 {
            width: 500px;
        }
        .auto-style36 {
            font-size: large;
        }
        .auto-style37 {
            font-size: medium;
        }
    </style>
</head>
<body style="width: 499px; height: 313px; border-style: outset; border-color: darkRed;">
    <form id="form1" runat="server">
        <div class="auto-style35">
            <table class="auto-style1">
                <tr>
                    <td class="auto-style33"></td>
                    <td class="auto-style3"></td>
                    <td class="auto-style34"></td>
                </tr>
                <tr>
                    <td class="auto-style30">&nbsp;</td>
                    <td class="auto-style7">Iniciar sesión</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style31"></td>
                    <td class="auto-style25"><span class="auto-style36">Nombre de usuario: </span>
                        <asp:TextBox ID="TBUsuario" runat="server" CssClass="auto-style37" Width="160px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TBUsuario" CssClass="auto-style36" ErrorMessage="Usuario requerido." ForeColor="Red" SetFocusOnError="True" ValidateRequestMode="Disabled">*</asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style24"></td>
                </tr>
                <tr>
                    <td class="auto-style31"></td>
                    <td class="auto-style25"><span class="auto-style36">Contraseña: </span>
                        <asp:TextBox ID="TBContraseña" runat="server" CssClass="auto-style37" TextMode="Password" Width="160px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TBContraseña" CssClass="auto-style36" ErrorMessage="Contraseña requerido." ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style24"></td>
                </tr>
                <tr>
                    <td class="auto-style32"></td>
                    <td class="auto-style2">
                        <asp:Button ID="BtnAceptar" runat="server" BackColor="DarkRed" Font-Size="Small" Font-Underline="False" ForeColor="White" Height="60%" OnClick="BtnAceptar_Click" Text="Aceptar" Width="100px" />
                    </td>
                    <td class="auto-style19"></td>
                </tr>
            </table>
            <div class="auto-style15">
                <table class="auto-style27">
                    <tr>
                        <td class="auto-style30">&nbsp;</td>
                        <td class="auto-style28">
                            <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
                            <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="auto-style16" ForeColor="Red" Height="63px" Width="416px" />
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </div>
        </div>
    </form>
</body>
</html>
