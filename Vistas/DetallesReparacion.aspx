<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetallesReparacion.aspx.cs" Inherits="SistemaMantenimientoEquipos.Vistas.DetallesReparacion" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Electronica</title>
    <style type="text/css">
        /* Estilos generales para el cuerpo */
        body {
            font-family: Arial, sans-serif;
            background-image: url('../shutterstock_1012957408.jpg'); /* Asegúrate de que la URL de la imagen sea correcta */
            background-size: cover;
            background-position: center;
            margin: 0;
            padding: 0;
            color: #333;
            text-align: center;
        }

        /* Contenedor principal para el formulario */
        .form-container {
            background-color: rgba(255, 255, 255, 0.8); /* Fondo blanco translúcido */
            width: 80%;
            max-width: 900px;
            margin: 30px auto;
            padding: 20px;
            border-radius: 10px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.2);
        }

        /* Estilo para el encabezado */
        h1 {
            background-color: darkred;
            color: white;
            padding: 20px;
            text-align: center;
            margin-top: 0;
            font-size: 2.5em;
            border-radius: 10px;
        }

        /* Estilo para los campos de texto */
        .form-input {
            width: 100%;
            max-width: 300px;
            padding: 10px;
            margin: 10px 0;
            border-radius: 5px;
            border: 1px solid #ccc;
            font-size: 16px;
            box-sizing: border-box;
        }

        /* Estilo para las etiquetas de los campos de texto */
        .form-label {
            font-weight: bold;
            color: #444;
            margin-top: 10px;
            display: inline-block;
        }

        /* Estilo para los botones */
        .form-button {
            padding: 10px 20px;
            margin: 10px 5px;
            border: none;
            border-radius: 5px;
            background-color: #4CAF50;
            color: white;
            font-size: 16px;
            cursor: pointer;
            transition: background-color 0.3s ease;
        }

        .form-button:hover {
            background-color: #45a049; /* Verde más oscuro al pasar el ratón */
        }

        /* Estilo para el GridView */
        .grid-view {
            width: 100%;
            margin-top: 20px;
            border-collapse: collapse;
        }

        .grid-view th, .grid-view td {
            padding: 12px;
            text-align: left;
            border: 1px solid #ddd;
        }

        .grid-view th {
            background-color: #4CAF50;
            color: white;
        }

        .grid-view tr:nth-child(even) {
            background-color: #f9f9f9;
        }

        .grid-view tr:hover {
            background-color: #ddd;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-container">
            <h1>Pagina de Detalles Reparaciones</h1>
            
            <!-- GridView para mostrar los detalles -->
            <asp:GridView ID="GridView1" runat="server" CssClass="grid-view"></asp:GridView>
            
            <!-- Campos de entrada para detalles de reparación -->
            <div>
                <label for="tcodigoDetalle" class="form-label">DetalleID</label>
                <asp:TextBox ID="tcodigoDetalle" runat="server" CssClass="form-input"></asp:TextBox>

                <label for="tReparacionID" class="form-label">ReparacionID</label>
                <asp:TextBox ID="tReparacionID" runat="server" CssClass="form-input"></asp:TextBox>

                <label for="tDescripcion" class="form-label">Descripcion</label>
                <asp:TextBox ID="tDescripcion" runat="server" CssClass="form-input"></asp:TextBox>

                <label for="tFechaInicial" class="form-label">Fecha Inicial</label>
                <asp:TextBox ID="tFechaInicial" runat="server" CssClass="form-input"></asp:TextBox>

                <label for="tFechaFinal" class="form-label">Fecha Final</label>
                <asp:TextBox ID="tFechaFinal" runat="server" CssClass="form-input"></asp:TextBox>
                
                <!-- Botones para agregar, borrar y modificar -->
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
