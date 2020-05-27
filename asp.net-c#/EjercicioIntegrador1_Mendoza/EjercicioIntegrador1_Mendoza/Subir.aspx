<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Subir.aspx.cs" Inherits="EjercicioIntegrador1_Mendoza.Subir" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style9 {
        font-size: x-large;
        text-align: center;
        color: #8B0000;
    }
    .auto-style12 {
        font-size: x-large;
        color: #8B0000;
    }
    .auto-style13 {
        font-size: medium;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
    <caption class="auto-style12">
        Subir</caption>
    <tr>
        <td class="auto-style9">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style6">
            <asp:FileUpload ID="FileUpload1" runat="server" CssClass="auto-style7" Width="473px" />
        </td>
    </tr>
    <tr>
        <td class="auto-style6">
            <asp:Button ID="BtnSubir" runat="server" CssClass="auto-style7" OnClick="BtnSubir_Click" TabIndex="1" Text="Subir" Width="110px" />
        </td>
    </tr>
    <tr>
        <td class="auto-style6">
            <asp:Label ID="LblEstado" runat="server" CssClass="auto-style13"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style6">&nbsp;</td>
    </tr>
</table>
</asp:Content>
