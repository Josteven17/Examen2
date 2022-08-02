<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Pagina1.aspx.cs" Inherits="JosephOvarezExamen2.Pagina1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
       <h2>Datos Personales</h2>
    <div>
        <label>Nombre</label>
    </div>

    <div>
        <asp:TextBox ID="TNombre" runat="server" backgroung-color="gray" BorderColor="#669999"></asp:TextBox>
    </div>
    <div>
        <label>Cedula</label>
    </div>
    <div>
        <asp:TextBox ID="TCedula" runat="server" BorderColor="#669999"></asp:TextBox>
    </div>
    <div>
        <label>Telefono</label>

    </div>
    <div>
        <asp:TextBox ID="TTelefono" runat="server" BorderColor="#669999"></asp:TextBox>

    </div>
    <div>
        <label>Direccion</label>
    </div>
    <div>
        <asp:TextBox ID="TDireccion" runat="server" BorderColor="#669999"></asp:TextBox>

    </div>
        </div>
    <div>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;<asp:ImageButton ID="Agua" runat="server" class="boton" ImageUrl="~/Imagenes/agua.jpg" OnClick="Agua_Click1" />
        <asp:ImageButton ID="Telefono" runat="server" class="boton" ImageUrl="~/Imagenes/telefono.png" OnClick="Telefono_Click1" />
        <asp:ImageButton ID="Electricidad" runat="server" class="boton" ImageUrl="~/Imagenes/electri.png" OnClick="Electricidad_Click1" />
        <asp:ImageButton ID="Internet" runat="server" class="boton" ImageUrl="~/Imagenes/internet.png" OnClick="Internet_Click1" />
    </div>

</asp:Content>
