<%@ Page Title="" Language="C#" MasterPageFile="~/Encuestas.Master" AutoEventWireup="true" CodeBehind="Reporte.aspx.cs" Inherits="Examen_3_Ernesto_Vargas.Reporte" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
<br />

<div class="container text-center">
    <h1>Reporte</h1>
</div>

<br />
<br />

<div class="container text-center">
    <asp:GridView ID="datagrid" PageSize="10" HorizontalAlign="Center"
        CssClass="mydatagrid" AutoGenerateColumns="true" PagerStyle-CssClass="pager" HeaderStyle-CssClass="header"
        RomStyle-CssClass="rows" AllowPaging="true" runat="server">
    </asp:GridView>
</div>

<br />
<br />
</asp:Content>
