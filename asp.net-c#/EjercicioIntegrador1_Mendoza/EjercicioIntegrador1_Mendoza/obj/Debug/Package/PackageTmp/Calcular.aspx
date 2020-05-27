<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Calcular.aspx.cs" Inherits="EjercicioIntegrador1_Mendoza.Calcular1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style9 {
            width: 564px;
            height: 30px;
            text-align: right;
        }
        .auto-style10 {
            height: 30px;
        }
        .auto-style15 {
            width: 564px;
            text-align: center;
            font-size: xx-large;
        }
        .auto-style17 {
            width: 100%;
            height: 493px;
        }
        .auto-style18 {
            width: 564px;
            text-align: left;
            font-size: xx-large;
        }
        .auto-style19 {
            text-align: center;
            font-size: large;
        }
        .auto-style23 {
        width: 564px;
        text-align: center;
        font-size: large;
    }
    .auto-style25 {
        font-size: x-large;
    }
    .auto-style27 {
        width: 564px;
        text-align: center;
        font-size: xx-large;
        height: 17px;
    }
    .auto-style28 {
        height: 17px;
    }
    .auto-style29 {
        width: 564px;
        text-align: center;
        font-size: large;
        height: 38px;
    }
    .auto-style30 {
        height: 38px;
    }
    .auto-style31 {
        font-size: x-large;
        color: #8B0000;
    }
    .auto-style32 {
        width: 564px;
        text-align: center;
        font-size: large;
        height: 61px;
    }
    .auto-style33 {
        font-size: large;
        height: 61px;
    }
    .auto-style34 {
        width: 155px;
        height: 30px;
        text-align: right;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style17">
        <caption class="auto-style31">
            Cálculo de gastos</caption>
        <tr>
            <td class="auto-style27"></td>
            <td class="auto-style28"></td>
        </tr>
        <tr>
            <td class="auto-style23">Gastos fijos: </td>
            <td>
                <asp:TextBox ID="TBGastosFijos" runat="server" Width="150px" type="number" min="0.00" step="0.10" CssClass="auto-style7" TabIndex="1"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TBGastosFijos" ErrorMessage="Gastos fijos obligatorio." ForeColor="Red" CssClass="auto-style7"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style23">Gastos variables:</td>
            <td>
                <asp:TextBox ID="TBGastosVar" runat="server" Width="150px" type="number" min="0.00" step="0.10" CssClass="auto-style7" TabIndex="2"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TBGastosVar" ErrorMessage="Gastos variables obligatorio." ForeColor="Red" CssClass="auto-style7"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style23">Gastos de Sueldos:</td>
            <td>
                <asp:TextBox ID="TBGastosSueldos" runat="server" Width="150px" type="number" min="0.00" step="0.10" CssClass="auto-style7" TabIndex="3"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TBGastosSueldos" ErrorMessage="Gastos de Sueldos obligatorio." ForeColor="Red" CssClass="auto-style7"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style32">Impuestos:</td>
            <td class="auto-style33">
                <asp:TextBox ID="TBImpuestos" runat="server" Width="150px" type="number" min="0.00" step="0.10" CssClass="auto-style7" TabIndex="4"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TBImpuestos" ErrorMessage="Impuestos obligatorio." ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style29">Exento de IVA:</td>
            <td class="auto-style30">
                <asp:CheckBox ID="CheckBox1" runat="server" CssClass="auto-style7" TabIndex="5" />
            </td>
        </tr>
        <tr>
            <td class="auto-style23"><span class="auto-style7">Mes:
                        </span>
                <asp:DropDownList ID="DDLMes" runat="server" CssClass="auto-style7" TabIndex="6">
                    <asp:ListItem Selected="True">Enero</asp:ListItem>
                    <asp:ListItem>Febrero</asp:ListItem>
                    <asp:ListItem>Marzo</asp:ListItem>
                    <asp:ListItem>Abril</asp:ListItem>
                    <asp:ListItem>Mayo</asp:ListItem>
                    <asp:ListItem>Junio</asp:ListItem>
                    <asp:ListItem>Julio</asp:ListItem>
                    <asp:ListItem>Agosto</asp:ListItem>
                    <asp:ListItem>Septiembre</asp:ListItem>
                    <asp:ListItem>Octubre</asp:ListItem>
                    <asp:ListItem>Noviembre</asp:ListItem>
                    <asp:ListItem>Diciembre</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style18">
                <asp:Label ID="LblResultado" runat="server" CssClass="auto-style25" Font-Bold="True"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style23"><span class="auto-style7">Año:
                        </span>
                <asp:DropDownList ID="DDLAño" runat="server" CssClass="auto-style7" TabIndex="7">
                    <asp:ListItem Selected="True">2020</asp:ListItem>
                    <asp:ListItem>2021</asp:ListItem>
                    <asp:ListItem>2022</asp:ListItem>
                    <asp:ListItem>2023</asp:ListItem>
                    <asp:ListItem>2024</asp:ListItem>
                    <asp:ListItem>2025</asp:ListItem>
                    <asp:ListItem>2026</asp:ListItem>
                    <asp:ListItem>2027</asp:ListItem>
                    <asp:ListItem>2028</asp:ListItem>
                    <asp:ListItem>2029</asp:ListItem>
                    <asp:ListItem>2030</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style7">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style34">
                <asp:Button ID="BtnCalcular" runat="server" Text="Calcular" Width="169px" OnClick="BtnCalcular_Click" CssClass="auto-style19" TabIndex="8" />
            </td>
            <td class="auto-style10"></td>
        </tr>
        <tr>
            <td class="auto-style15">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
