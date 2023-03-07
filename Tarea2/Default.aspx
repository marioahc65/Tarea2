<%@ Page Title="Pagina Principal" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Tarea2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
         <h2 id="title"><%: Title %>.</h2>
        <h3>Asignar Trabajo</h3>
    <asp:Label ID="LNota" runat="server" Text="Label"></asp:Label>
    <br />
        <br />
        <asp:Label ID="LTipo" runat="server" Text="Seleccione el Empleado: "></asp:Label>
    <br />
     <asp:DropDownList ID="DDLEmpleado" runat="server" AppendDataBoundItems="True" Width="203px">
         <asp:ListItem Value="0" Text="--Seleccione una opcion--"></asp:ListItem>
     </asp:DropDownList>
        <br />
        <asp:Label ID="LEdificio" runat="server" Text="Seleccione un Edificio: "></asp:Label>
    <br />
     <asp:DropDownList ID="DDLEdificio" runat="server" AppendDataBoundItems="True" Width="203px">
         <asp:ListItem Value="0" Text="--Seleccione una opcion--"></asp:ListItem>
     </asp:DropDownList>
        <br />
        <asp:Label ID="LProfesion" runat="server" Text="Seleccione la profesión: "></asp:Label>
    <br />
     <asp:DropDownList ID="DDLProfesion" runat="server" AppendDataBoundItems="True" Width="203px" OnTextChanged="DDLProfesion_TextChanged">
         <asp:ListItem Value="0" Text="--Seleccione una opcion--"></asp:ListItem>
     </asp:DropDownList>
         <br />
        <asp:Label ID="Label1" runat="server" Text="Es un Ascenso Laboral? : "></asp:Label>
    <br />
        <asp:CheckBox ID="CBAscenso" runat="server" />
     <br />
     <br />
     <asp:Button ID="BTGuardar" runat="server" Text="Guardar" OnClick="BTGuardar_Click" />
    <br />
    <br />
     <asp:GridView ID="GridView1" runat="server"  CellPadding="3" CellSpacing="3" Width="756px"></asp:GridView>
    </main>

</asp:Content>
