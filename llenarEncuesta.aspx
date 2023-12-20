<%@ Page Title="" Language="C#" MasterPageFile="~/Encuestas.Master" AutoEventWireup="true" CodeBehind="llenarEncuesta.aspx.cs" Inherits="Examen_3_Ernesto_Vargas.llenarEncuesta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <br />
    <br />

    <div class="container text-center">
        <h1>LLENAR ENCUESTA</h1>
    </div>

    <br />
    <br />

    <div class="container text-center">
        Numero de Encuesta:
    <asp:Label ID="LabelNumEncuesta" class="form-control" runat="server" Text="Label"></asp:Label>
        Nombre del Usuario:
    <asp:TextBox ID="TextBoxusername" class="form-control" runat="server"></asp:TextBox>
        Fecha de Nacimiento:
    <asp:TextBox ID="TextBoxFecha" class="form-control" runat="server"></asp:TextBox>
        Correo Electronico:
    <asp:TextBox ID="TextBoxemail" class="form-control" runat="server"></asp:TextBox>
        Partido Politico:
    <asp:DropDownList ID="DropDownList1" class="form-control" runat="server"></asp:DropDownList>
    </div>

    <br />
    <br />

    <div class="container text-center">
        <asp:Button ID="ButtonAgregar" class="btn btn-outline-primary" runat="server" Text="Agregar" OnClick="ButtonAgregar_Click"/>
    </div>
</asp:Content>
