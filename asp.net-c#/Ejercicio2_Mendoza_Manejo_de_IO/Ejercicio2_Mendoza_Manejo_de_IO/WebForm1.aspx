<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Ejercicio2_Mendoza_Manejo_de_IO.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Cambria, Cochin, Georgia, Times, "Times New Roman", serif;
            font-size: x-large;
            text-decoration: underline;
            color: #0000FF;
        }
        .auto-style2 {
            width: 20px;
        }
        .auto-style3 {
            width: 20px;
            height: 23px;
        }
        .auto-style4 {
            height: 23px;
        }
        .auto-style5 {
            height: 23px;
            width: 148px;
        }
        .auto-style7 {
            height: 100px;
            width: 148px;
        }
        .auto-style8 {
            height: 100px;
        }
        .auto-style9 {
            width: 1410px;
        }
        .auto-style10 {
            height: 23px;
            width: 1410px;
        }
        .auto-style11 {
            width: 100%;
        }
        .auto-style12 {
            width: 20px;
            height: 125px;
        }
        .auto-style13 {
            height: 125px;
            width: 1410px;
        }
        .auto-style14 {
            height: 125px;
        }
        .auto-style15 {
            margin-left: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <caption class="auto-style1">
                    <strong>Mi Agenda</strong></caption>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style9">
                        <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="291px" NextPrevFormat="FullMonth" OnSelectionChanged="Calendar1_SelectionChanged" style="margin-left: 0px" Width="803px">
                            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                            <OtherMonthDayStyle ForeColor="#999999" />
                            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                            <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                            <TodayDayStyle BackColor="#CCCCCC" />
                        </asp:Calendar>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style10"></td>
                    <td class="auto-style4"></td>
                </tr>
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style10">&nbsp;<table class="auto-style11">
                        <tr>
                            <td class="auto-style5">Hora:</td>
                            <td class="auto-style4">
                                <asp:TextBox ID="txtHora" runat="server" type="Time"  Width="127px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtHora" ErrorMessage="Hora requerida." ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                            </td>
                            <td class="auto-style4"></td>
                        </tr>
                        <tr>
                            <td class="auto-style5">Título:</td>
                            <td class="auto-style4">
                                <asp:TextBox ID="txtTitulo" runat="server" Width="308px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtTitulo" ErrorMessage="Título requerido." ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                            </td>
                            <td class="auto-style4"></td>
                        </tr>
                        <tr>
                            <td class="auto-style7">Descripción:</td>
                            <td class="auto-style8">
                                <asp:TextBox ID="txtDescripcion" runat="server" Height="130px" TextMode="MultiLine" Width="308px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtDescripcion" ErrorMessage="Descripción requerida." ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                            </td>
                            <td class="auto-style8"></td>
                        </tr>
                        <tr>
                            <td class="auto-style5"></td>
                            <td class="auto-style4"></td>
                            <td class="auto-style4"></td>
                        </tr>
                        <tr>
                            <td class="auto-style5">
                        <asp:Button ID="btnAgendar" runat="server" BackColor="#3366FF" BorderColor="White" Font-Bold="True" Font-Italic="False" Font-Underline="False" ForeColor="White" Height="32px" OnClick="btnAgendar_Click" Text="Agendar" Width="96px" />
                            </td>
                            <td class="auto-style4">
                        <asp:Button ID="btnLimpiar" runat="server" BackColor="#3366FF" BorderColor="White" Font-Bold="True" Font-Italic="False" Font-Underline="False" ForeColor="White" Height="32px" OnClick="btnLimpiar_Click" Text="Limpiar" Width="96px" CssClass="auto-style15" />
                            </td>
                            <td class="auto-style4">&nbsp;</td>
                        </tr>
                        </table>
                    </td>
                    <td class="auto-style4"></td>
                </tr>
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style10">
                        &nbsp;</td>
                    <td class="auto-style4"></td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style10">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style12"></td>
                    <td class="auto-style13">
                        <asp:Label ID="lblMostrar" runat="server" Text="[]"></asp:Label>
                    </td>
                    <td class="auto-style14"></td>
                </tr>
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style10">&nbsp;</td>
                    <td class="auto-style4"></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
