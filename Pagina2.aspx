<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Pagina2.aspx.cs" Inherits="JosephOvarezExamen2.Pagina2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h2>Datos de facturacion</h2>
        <div>
            <label>Numero de factura</label>
        </div>
        <div>
            <asp:TextBox ID="TFactura" runat="server"></asp:TextBox>

        </div>
        <div>
            <label>Codigo de servicio</label>
        </div>
        <div>
            <asp:TextBox ID="TCodigo" runat="server" Width="168px"></asp:TextBox>
        </div>
        <div>
            <label>Mes</label>
        </div>
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>Enero</asp:ListItem>
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

            <asp:SqlDataSource ID="SqlDatos" runat="server" ConnectionString="<%$ ConnectionStrings:Examens2dbConnectionString %>" SelectCommand="SELECT * FROM [Clientes]"></asp:SqlDataSource>

        </div>
        <div>
            <label>Monto</label>
        </div>
        <div>
            <asp:TextBox ID="TMonto" runat="server"></asp:TextBox>
        </div>
        <div>
            <label>Descuento</label>
        </div>
        <div>
            <asp:TextBox ID="TDescuento" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="BAgregar" runat="server" class="button button1" Text="Agregar" OnClick="BAgregar_Click" />
            <asp:Button ID="BSalvar" runat="server" class="button button2" Text="Salvar" OnClick="BSalvar_Click" />
            <asp:Button ID="BVolver" runat="server" class="button button3" Text="Volver" OnClick="BVolver_Click" />
        </div>
    </div>

    <div>
        <h2>Datos Personales</h2>
        <div>
            <label>Nombre</label>
        </div>

        <div>
            <asp:TextBox ID="TNombre2" runat="server"></asp:TextBox>
        </div>
        <div>
            <label>Cedula</label>
        </div>
        <div>
            <asp:TextBox ID="TCedula2" runat="server"></asp:TextBox>
        </div>
        <div>
            <label>Telefono</label>

        </div>
        <div>
            <asp:TextBox ID="TTelefono2" runat="server"></asp:TextBox>

        </div>
        <div>
            <label>Direccion</label>
        </div>
        <div>
            <asp:TextBox ID="TDireccion2" runat="server"></asp:TextBox>

        </div>
    </div>

    <div>
        <h2>Detalles de pago</h2>
        <div>
            <label>Monto</label>
        
            <asp:TextBox ID="TMonto2" runat="server"></asp:TextBox>
        
            <label>Descuento</label>
        
            <asp:TextBox ID="TDescuento2" runat="server"></asp:TextBox>
       
            <label>Iva</label>
       
            <asp:TextBox ID="TIva" runat="server"></asp:TextBox>

       
            <label>Subtotal</label>

        
            <asp:TextBox ID="TSubtotal" runat="server"></asp:TextBox>

            <label>Total</label>
        
            <asp:TextBox ID="TTotal" runat="server"></asp:TextBox>

        </div>
    </div>
</asp:Content>
