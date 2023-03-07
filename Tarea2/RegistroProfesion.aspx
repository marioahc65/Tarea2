<%@ Page Title="Registro de Profesión" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistroProfesion.aspx.cs" Inherits="Tarea2.RegistroProfesion" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>
        <h3>Datos</h3>
        <br />
    <asp:Label ID="LNombre" runat="server" Text="Nombre de la Profesión: "></asp:Label>
    <br />
    <asp:TextBox ID="TBNombre" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="LTipo" runat="server" Text="Seleccione el Tipo de la Profesión: "></asp:Label>
    <br />
     <asp:DropDownList ID="DDLTipo" runat="server" AppendDataBoundItems="True" Width="203px">
         <asp:ListItem Value="0" Text="--Seleccione una opcion--"></asp:ListItem>
     </asp:DropDownList>
     <br />
     <br />
     <asp:Button ID="BTGuardar" runat="server" Text="Guardar" OnClick="BTGuardar_Click" />
     <br />
     <br />
     <asp:GridView ID="GridView1" runat="server"  CellPadding="3" CellSpacing="3" Width="376px"></asp:GridView>
     <br />
     <br />
     <br />
    </main>
</asp:Content>
