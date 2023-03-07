<%@ Page Title="Tipo de Profesion" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TipoProfesion.aspx.cs" Inherits="Tarea2.TipoProfesion" %>

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
            <asp:Label ID="LSalario" runat="server" Text="Salario Mensual de la Profesión: "></asp:Label>
            <br />
            <asp:TextBox ID="TBSalario" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="BTGuardar" runat="server" Text="Guardar" OnClick="BTGuardar_Click" />
            <br />
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="3" CellSpacing="3" Width="270px">
        <Columns>
                <asp:TemplateField HeaderText="Nombre">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_Name" runat="server" Text='<%#Eval("Nombre") %>'></asp:Label>  
                    </ItemTemplate>  
                </asp:TemplateField>  
                <asp:TemplateField HeaderText="Salario">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_City" runat="server" Text='<%#Eval("Salario") %>'></asp:Label>  
                    </ItemTemplate>    
                </asp:TemplateField>  
        </Columns>
    </asp:GridView>
    <br />
    <br />
    <br />
    </main>
</asp:Content>
