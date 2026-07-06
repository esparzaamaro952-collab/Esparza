<%@ Page Title="Registro" Language="C#" MasterPageFile="~/PagMaestra.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="Esparza.Registro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="contenedor-centrado">
        
        <div class="tarjeta-formulario" style="max-width: 600px;">
            
            <h3 class="text-center mb-4" style="color: #3E362E;">Registro de Alumnos</h3>
            
            <div class="mb-3">
                <asp:Label ID="lblRut" runat="server" Text="RUT del Alumno:" CssClass="form-label" Font-Bold="true"></asp:Label>
                <asp:TextBox ID="txtRut" runat="server" CssClass="form-control" placeholder="Ej: 12345678-9"></asp:TextBox>
            </div>
            
            <div class="mb-4">
                <asp:Label ID="lblNombre" runat="server" Text="Nombre Completo:" CssClass="form-label" Font-Bold="true"></asp:Label>
                <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" placeholder="Nombre y apellido"></asp:TextBox>
            </div>
            
            <div class="row mb-4">
                <div class="col-md-4">
                    <asp:Label ID="lblNota1" runat="server" Text="Nota 1:" CssClass="form-label" Font-Bold="true"></asp:Label>
                    <asp:TextBox ID="txtNota1" runat="server" CssClass="form-control text-center" placeholder="0,0"></asp:TextBox>
                </div>
                <div class="col-md-4">
                    <asp:Label ID="lblNota2" runat="server" Text="Nota 2:" CssClass="form-label" Font-Bold="true"></asp:Label>
                    <asp:TextBox ID="txtNota2" runat="server" CssClass="form-control text-center" placeholder="0,0"></asp:TextBox>
                </div>
                <div class="col-md-4">
                    <asp:Label ID="lblNota3" runat="server" Text="Nota 3:" CssClass="form-label" Font-Bold="true"></asp:Label>
                    <asp:TextBox ID="txtNota3" runat="server" CssClass="form-control text-center" placeholder="0,0"></asp:TextBox>
                </div>
            </div>
            
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn-guardar-alumno" OnClick="btnGuardar_Click" />
            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn-eliminar-alumno" OnClick="btnEliminar_Click" OnClientClick="return confirm('Seguro quieres eliminar al alumno?);" />
            
            <div class="text-center mt-3">
                <asp:Label ID="lblMensaje" runat="server" Text="" Font-Bold="true"></asp:Label>
            </div>

            <hr style="border-color: #EBE4DD; margin: 30px 0;" />

            <h4 class="text-center mb-3" style="color: #3E362E;">Listado General</h4>
            <div class="table-responsive">
                <asp:GridView ID="gdvAlumnos" runat="server" CssClass="table table-bordered text-center" AutoGenerateColumns="False" style="background-color: white;" DataKeyNames="rut">
                    <Columns>
                        <asp:BoundField DataField="rut" HeaderText="rut" ReadOnly="True" SortExpression="rut" />
                        <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
                        <asp:BoundField DataField="nota1" HeaderText="nota1" SortExpression="nota1" />
                        <asp:BoundField DataField="nota2" HeaderText="nota2" SortExpression="nota2" />
                        <asp:BoundField DataField="nota3" HeaderText="nota3" SortExpression="nota3" />
                        <asp:BoundField DataField="promfinal" HeaderText="Promedio" SortExpression="promfinal" DataFormatString="{0:N1}" />
                    </Columns>
                    <HeaderStyle BackColor="#3E362E" ForeColor="White" />
                </asp:GridView>
            </div>

        </div>
    </div>

</asp:Content>