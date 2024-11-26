<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="SistemaMantenimientoEquipos.Vistas.Usuarios" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Electronica</title>
    <style type="text/css">
        
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            padding: 0;
            color: #333;
        }

        
        h1 {
            background-color: deeppink;
            color: white;
            padding: 20px;
            text-align: center;
            margin: 0;
        }

        h2 {
            color: #555;
            text-align: center;
        }

       
        .auto-style1 {
            width: 100%;
            max-width: 500px;
            margin: 20px auto;
            display: block;
        }

       
        .form-input {
            width: 250px;
            padding: 10px;
            margin: 10px 0;
            border-radius: 5px;
            border: 1px solid #ccc;
            font-size: 16px;
        }

        
        .form-button {
            padding: 10px 20px;
            margin: 10px 5px;
            border: none;
            border-radius: 5px;
            background-color: deeppink;
            color: white;
            font-size: 16px;
            cursor: pointer;
        }

        .form-button:hover {
            background-color: darkviolet;
        }

        
        .form-container {
            width: 80%;
            margin: 20px auto;
            padding: 20px;
            background-color: white;
            border-radius: 10px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }

        .grid-view {
            width: 100%;
            margin: 20px 0;
            border-collapse: collapse;
        }

        .grid-view th, .grid-view td {
            border: 1px solid #ddd;
            padding: 10px;
            text-align: left;
        }

        .grid-view th {
            background-color: #f4f4f4;
        }

        .grid-view tr:hover {
            background-color: #f9f9f9;
        }

        /* Títulos y etiquetas */
        .form-label {
            font-weight: bold;
            margin-top: 15px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-container">
            <h1>SistemaMantenimiento</h1>
            <h2>Pagina de Usuarios</h2>

            <img src="../CPR-Reparacion-de-Celulares-de-Distelsa-885x500.jpg" class="auto-style1" />

            <asp:GridView ID="GridView1" runat="server" CssClass="grid-view"></asp:GridView>

            <div>
                <div class="form-label">UsuarioID</div>
                <asp:TextBox ID="tcodigoUusuario" runat="server" CssClass="form-input"></asp:TextBox>

                <div class="form-label">NombreUsuario</div>
                <asp:TextBox ID="tNombreUsuario" runat="server" CssClass="form-input"></asp:TextBox>

                <div class="form-label">CorreoElectronico</div>
                <asp:TextBox ID="tCorreoElectronico" runat="server" CssClass="form-input"></asp:TextBox>

                <div class="form-label">Telefono</div>
                <asp:TextBox ID="tTlelfono" runat="server" CssClass="form-input"></asp:TextBox>

                <div>
                    <asp:Button ID="Agregar" runat="server" Text="Agregar" CssClass="form-button" />
                    <asp:Button ID="Borrar" runat="server" Text="Borrar" CssClass="form-button" />
                    <asp:Button ID="Modificar" runat="server" Text="Modificar" CssClass="form-button" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>


 
  
