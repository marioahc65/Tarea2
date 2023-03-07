<%@ Page Title="Registro de Empleado" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistroEmpleado.aspx.cs" Inherits="Tarea2.RegistroEmpleado" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
                <h2 id="title"><%: Title %>.</h2>
        <h3>Datos</h3>
        <br />
            <asp:Label ID="LIdentificacion" runat="server" Text="Identificacion: "></asp:Label>
            <br />
            <asp:TextBox ID="TIdentificacion" runat="server"></asp:TextBox>
        <br />
         <br />
        <asp:Label ID="LNombre" runat="server" Text="Nombre: "></asp:Label>
            <br />
            <asp:TextBox ID="TNombre" runat="server"></asp:TextBox>
                <br />
         <br />
        <asp:Label ID="LApellido1" runat="server" Text="Primer Apellido: "></asp:Label>
            <br />
            <asp:TextBox ID="TApellido1" runat="server"></asp:TextBox>
                <br />
         <br />
        <asp:Label ID="LApellido2" runat="server" Text="Segundo Apellido: "></asp:Label>
            <br />
            <asp:TextBox ID="TApellido2" runat="server"></asp:TextBox>
                        <br />
         <br />
        <asp:Label ID="LFechaNacimiento" runat="server" Text="Fecha de nacimiento: "></asp:Label>
            <br />
                <asp:TextBox ClientIDMode="Static" ID="txtEffDate" runat="server" CssClass="calendarImg" type="date"></asp:TextBox>
        <br />
     <br />

     <asp:Button ID="BTGuardar" runat="server" Text="Guardar" OnClick="BTGuardar_Click" />
     <br />
    <br />
     <asp:GridView ID="GridView1" runat="server"  CellPadding="3" CellSpacing="3" Width="1469px"></asp:GridView>
     <br />
     <br />
    </main>
            
    </asp:Content>
